using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Collections;

namespace DirectDimensional.Bindings {
    public unsafe sealed class ComList<T> : IComCollection<T?> where T : ComObject? {
        private IntPtr _memory;
        private T?[] _items;
        private int _count;
        private bool disposedValue;

        public IntPtr NativePointer => _memory;

        public int Count => _count;

        public bool IsReadOnly => false;

        public ComList(int capacity) {
            if (capacity <= 0) throw new ArgumentOutOfRangeException(nameof(capacity), "A positive (> 0) number are required to be used as capacity");

            _items = new T?[capacity];
            _memory = Marshal.AllocHGlobal(capacity * IntPtr.Size);

            Unsafe.InitBlock(_memory.ToPointer(), 0x00, (uint)(capacity * IntPtr.Size));
        }

        public int IndexOf(T? item) {
            var ptr = item.GetNativePtr();

            for (int i = 0; i < _count; i++) {
                if (_items[i].GetNativePtr() == ptr) return i;
            }

            return -1;
        }

        public void Insert(int index, T? item) {
            if (index > _count)
                throw new IndexOutOfRangeException("Index was out of range. Must be non-negative and less than the size of collection.");

            if (_count == _items.Length) EnsureCapacityDouble(_count + 1);
            if (index < _count) {
                var copyLen = _count - index;

                Array.Copy(_items, index, _items, index + 1, copyLen);
                Unsafe.CopyBlock((_memory + (index + 1) * IntPtr.Size).ToPointer(), (_memory + index * IntPtr.Size).ToPointer(), (uint)(copyLen * IntPtr.Size));
            }

            _items[index] = item;
            Marshal.WriteIntPtr(_memory, index * IntPtr.Size, item.GetNativePtr());
        }

        public void RemoveAt(int index) {
            if (index >= _count)
                throw new IndexOutOfRangeException("Index was out of range. Must be non-negative and less than the size of collection.");

            _count--;
            if (index < _count) {
                var copyLen = _count - index;

                Array.Copy(_items, index + 1, _items, index, copyLen);
                Unsafe.CopyBlock((_memory + index * IntPtr.Size).ToPointer(), (_memory + (index + 1) * IntPtr.Size).ToPointer(), (uint)(copyLen * IntPtr.Size));
            }

            _items[_count] = null!;
            Marshal.WriteIntPtr(_memory, _count * IntPtr.Size, IntPtr.Zero);
        }

        public void Add(T? item) {
            if (_count == _items.Length) EnsureCapacityDouble(_count + 1);

            _items[_count] = item;
            Marshal.WriteIntPtr(_memory, IntPtr.Size * _count, item.GetNativePtr());

            _count++;
        }

        public void Clear() {
            Unsafe.InitBlock(_memory.ToPointer(), 0x00, (uint)(IntPtr.Size * _count));
            Array.Clear(_items);
            _count = 0;
        }

        public bool Contains(T? item) {
            IntPtr searchPtr = item.GetNativePtr();

            for (int i = 0; i < _items.Length; i++) {
                if (_items[i].GetNativePtr() == searchPtr) return true;
            }

            return false;
        }

        public void CopyTo(T?[] array, int destinationIndex) {
            Array.Copy(_items, 0, array, destinationIndex, array.Length);
        }

        public bool Remove(T? item) {
            int index = IndexOf(item);
            if (index >= 0) {
                RemoveAt(index);
                return true;
            }

            return false;
        }

        public IEnumerator<T?> GetEnumerator() {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return new Enumerator(this);
        }

        public int Capacity {
            get => _items.Length;
            set {
                if (value < _count) {
                    throw new ArgumentOutOfRangeException(nameof(value), "Capacity was less than the current collection size");
                }

                if (value == _items.Length) return;

                _memory = Marshal.ReAllocHGlobal(_memory, (nint)(_items.Length * IntPtr.Size));

                T?[] newArr = new T?[value];
                Array.Copy(newArr, _items, _items.Length);

                _items = newArr;
            }
        }

        public T? this[int index] {
            get {
                if (index >= _count)
                    throw new IndexOutOfRangeException("Index was out of range. Must be non-negative and less than the size of collection.");

                return _items[index];
            }

            set {
                if (index >= _count)
                    throw new IndexOutOfRangeException("Index was out of range. Must be non-negative and less than the size of collection.");

                _items[index] = value;
                Marshal.WriteIntPtr(_memory, IntPtr.Size * index, value.GetNativePtr());
            }
        }

        public void EnsureMinimumCapacity(int mimimum) {
            if (_items.Length < mimimum) {
                Capacity = Math.Clamp(_items.Length, mimimum, Array.MaxLength);
            }
        }
        public void EnsureCapacityDouble(int minimum) {
            if (_items.Length < minimum) {
                Capacity = Math.Clamp(_items.Length * 2, minimum, Array.MaxLength);
            }
        }

        public struct Enumerator : IEnumerator<T?> {
            private ComList<T?> list;
            private int index;
            private T? curr;

            internal Enumerator(ComList<T?> list) {
                this.list = list;
                curr = null!;
                index = 0;
            }

            public void Dispose() { }

            public T? Current => curr;
            object? IEnumerator.Current => curr;

            public void Reset() {
                curr = null!;
                index = 0;
            }

            public bool MoveNext() {
                if (index < list._count) {
                    curr = list[index];
                    index++;

                    return true;
                }

                return false;
            }
        }

        private void Dispose(bool disposing) {
            if (!disposedValue) {
                if (disposing) {
                }

                Marshal.FreeHGlobal(_memory);
                _memory = IntPtr.Zero;
                disposedValue = true;
            }
        }

        public void TrueDispose() {
            for (int i = 0; i < _count; i++) {
                _items[i].CheckAndRelease();
            }

            Dispose();
        }

        ~ComList() {
            Dispose(disposing: false);
        }

        /// <summary>
        /// Release the underlying memory pointer, to truely release reference of COM objects, use <seealso cref="TrueDispose"/>
        /// </summary>
        public void Dispose() {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

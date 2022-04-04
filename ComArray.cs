using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace DirectDimensional.Bindings {
    public unsafe sealed class ComArray<T> : IComCollection<T?> where T : ComObject? {
        private IntPtr _memory;
        private readonly T?[] _objects;
        private bool disposed;

        public ComArray(params T?[] array) {
            _objects = new T[array.Length];
            _memory = Marshal.AllocHGlobal(array.Length * IntPtr.Size);

            for (int i = 0; i < array.Length; i++) {
                _objects[i] = array[i];

                Marshal.WriteIntPtr(_memory, i * IntPtr.Size, _objects[i].GetNativePtr());
            }
        }

        public ComArray(int size) {
            _objects = new T[size];
            _memory = Marshal.AllocHGlobal(size * IntPtr.Size);

            Unsafe.InitBlock(_memory.ToPointer(), 0, (uint)(size * IntPtr.Size));
        }

        public T? this[int index] {
            get {
                var obj = _objects[index];
                if (!obj.Alive()) return null;

                return obj;
            }

            set {
                _objects[index] = value;
                Marshal.WriteIntPtr(_memory, index * IntPtr.Size, value.GetNativePtr());
            }
        }

        private void Dispose(bool disposing) {
            if (!disposed) {
                if (disposing) {
                }

                Marshal.FreeHGlobal(_memory);
                _memory = IntPtr.Zero;

                disposed = true;
            }
        }

        ~ComArray() {
            Dispose(disposing: false);
        }

        /// <summary>
        /// Release the underlying memory pointer, to truely release reference of COM objects, use <seealso cref="TrueDispose"/>
        /// </summary>
        public void Dispose() {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public void TrueDispose() {
            for (int i = 0; i < _objects.Length; i++) {
                _objects[i].CheckAndRelease();
            }

            Dispose();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return _objects.GetEnumerator();
        }

        int IList<T?>.IndexOf(T? item) {
            throw new NotImplementedException();
        }

        void IList<T?>.Insert(int index, T? item) {
            throw new NotImplementedException();
        }

        void IList<T?>.RemoveAt(int index) {
            throw new NotImplementedException();
        }

        void ICollection<T?>.Add(T? item) {
            throw new NotImplementedException();
        }

        void ICollection<T?>.Clear() {
            throw new NotImplementedException();
        }

        bool ICollection<T?>.Contains(T? item) {
            throw new NotImplementedException();
        }

        void ICollection<T?>.CopyTo(T?[] array, int arrayIndex) {
            throw new NotImplementedException();
        }

        bool ICollection<T?>.Remove(T? item) {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T?>.GetEnumerator() {
            return ((IEnumerable<T>)_objects!).GetEnumerator();
        }

        void IDisposable.Dispose() {
            throw new NotImplementedException();
        }

        public int Length => _objects.Length;
        public uint ULength => (uint)_objects.Length;

        public IntPtr NativePointer => _memory;

        int ICollection<T?>.Count { get; }
        bool ICollection<T?>.IsReadOnly { get; }
    }
}

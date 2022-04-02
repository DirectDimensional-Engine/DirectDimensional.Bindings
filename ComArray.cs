using System.Collections;
using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings {
    public unsafe sealed class ComArray<T> : IDisposable, IEnumerable<T>, ICloneable where T : ComObject? {
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

        public IEnumerator<T> GetEnumerator() {
            return ((IEnumerable<T>)_objects!).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return _objects.GetEnumerator();
        }

        public object Clone() {
            return new ComArray<T>(_objects);
        }

        public int Length => _objects.Length;
        public uint ULength => (uint)_objects.Length;

        public IntPtr NativePointer => _memory;
    }
}

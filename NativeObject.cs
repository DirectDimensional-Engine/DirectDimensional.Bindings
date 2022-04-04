using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

namespace DirectDimensional.Bindings {
    public abstract class NativeObject : IDisposable {
        protected internal IntPtr _nativePointer;
        private bool disposed;

        internal NativeObject() { }

        public NativeObject(IntPtr ptr) {
            _nativePointer = ptr;
        }

        protected abstract void DisposeImpl();
        public void Dispose() {
            if (!disposed) {
                DisposeImpl();
                disposed = true;

                GC.SuppressFinalize(this);
            }
        }
    }

    public static class NativeObjects {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool Alive([NotNullWhen(true)] this NativeObject? obj) {
            return obj != null && obj._nativePointer != IntPtr.Zero;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static IntPtr GetNativePtr(this NativeObject? obj) {
            return obj.Alive() ? obj._nativePointer : IntPtr.Zero;
        }
    }
}

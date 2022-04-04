using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

namespace DirectDimensional.Bindings {
    public abstract class ComObject : NativeObject, IUnknown {
        internal ComObject() : base() { }
        public ComObject(IntPtr ptr) : base(ptr) { }

        public virtual uint AddRef() {
            if (_nativePointer == IntPtr.Zero) {
                throw new NullReferenceException("Trying to add reference already destroyed COM object");
            }

            return (uint)Marshal.AddRef(_nativePointer);
        }

        public virtual HRESULT QueryInterface(Guid riid, out IntPtr ppOut) {
            return Marshal.QueryInterface(_nativePointer, ref riid, out ppOut);
        }

        public virtual T? QueryInterface<T>() where T : ComObject {
            var type = typeof(T);

            HRESULT hr = QueryInterface(type.GUID, out IntPtr ppOut);
            if (hr.Failed) return null;

            return Activator.CreateInstance(type, ppOut) as T;
        }

        public virtual T? QueryInterface<T>(out HRESULT hr) where T : ComObject {
            var type = typeof(T);

            hr = QueryInterface(type.GUID, out IntPtr ppOut);
            if (hr.Failed) return null;

            return Activator.CreateInstance(type, ppOut) as T;
        }

        public virtual uint Release() {
            if (_nativePointer == IntPtr.Zero) {
                throw new NullReferenceException("Trying to release already destroyed COM object");
            }

            int release = Marshal.Release(_nativePointer);
            if (release == 0) _nativePointer = IntPtr.Zero;

            return (uint)release;
        }

        public override int GetHashCode() {
            return _nativePointer.GetHashCode();
        }

        public override bool Equals(object? obj) {
            if (obj is not ComObject cobj) return false;
            if (obj.GetType() != GetType()) return false; // hmmm idk...

            return _nativePointer == cobj._nativePointer;
        }

        protected sealed override void DisposeImpl() { }
    }

    public static class ComObjects {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static uint CheckAndRelease(this ComObject? obj) {
            return obj.Alive() ? obj.Release() : 0u;
        }
    }
}

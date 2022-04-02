using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("8BA5FB08-5195-40e2-AC58-0D989C3A0102")]
    public sealed unsafe class Blob : ComObject {
        public Blob(IntPtr ptr) : base(ptr) { }

        public IntPtr GetBufferPointer() {
            IntPtr address = (*(IntPtr*)_nativePointer) + 3 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr>)(*(IntPtr*)address);

            return @delegate(_nativePointer);
        }

        public nuint GetBufferSize() {
            IntPtr address = (*(IntPtr*)_nativePointer) + 4 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, nuint>)(*(IntPtr*)address);

            return @delegate(_nativePointer);
        }
    }
}

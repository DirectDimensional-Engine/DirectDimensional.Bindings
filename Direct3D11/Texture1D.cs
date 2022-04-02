using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("f8fb5c27-c6b3-4f75-a4c8-439af2ef564c")]
    public sealed unsafe class Texture1D : Resource {
        public Texture1D(IntPtr ptr) : base(ptr) { }

        public D3D11_TEXTURE1D_DESC Description {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 10 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_TEXTURE1D_DESC*, void>)(*(IntPtr*)address);

                D3D11_TEXTURE1D_DESC desc;
                @delegate(_nativePointer, &desc);

                return desc;
            }
        }
    }
}

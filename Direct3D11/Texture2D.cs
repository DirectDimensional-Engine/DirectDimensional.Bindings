using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("6f15aaf2-d208-4e89-9ab4-489535d34f9c")]
    public sealed unsafe class Texture2D : Resource {
        public Texture2D(IntPtr ptr) : base(ptr) { }

        public D3D11_TEXTURE2D_DESC Description {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 10 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_TEXTURE2D_DESC*, void>)(*(IntPtr*)address);

                D3D11_TEXTURE2D_DESC desc;
                @delegate(_nativePointer, &desc);

                return desc;
            }
        }
    }
}

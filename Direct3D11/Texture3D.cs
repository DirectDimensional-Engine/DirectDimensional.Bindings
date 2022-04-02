using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("037e866e-f56d-4357-a8af-9dabbe6e250e")]
    public sealed unsafe class Texture3D : Resource {
        public Texture3D(IntPtr ptr) : base(ptr) { }

        public D3D11_TEXTURE3D_DESC Description {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 10 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_TEXTURE3D_DESC*, void>)(*(IntPtr*)address);

                D3D11_TEXTURE3D_DESC desc;
                @delegate(_nativePointer, &desc);

                return desc;
            }
        }
    }
}

using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("dfdba067-0b8d-4865-875b-d7b4516cc164")]
    public sealed unsafe class ShaderResourceView : ResourceView {
        public ShaderResourceView(IntPtr ptr) : base(ptr) {
        }

        public D3D11_SHADER_RESOURCE_VIEW_DESC Description {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 8 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_SHADER_RESOURCE_VIEW_DESC*, void>)(*(IntPtr*)address);

                D3D11_SHADER_RESOURCE_VIEW_DESC desc;
                @delegate(_nativePointer, &desc);

                return desc;
            }
        }
    }
}

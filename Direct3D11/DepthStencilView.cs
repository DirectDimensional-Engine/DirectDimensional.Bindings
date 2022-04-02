using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("9fdac92a-1876-48c3-afad-25b94f84a9b6")]
    public sealed unsafe class DepthStencilView : ResourceView {
        public DepthStencilView(IntPtr ptr) : base(ptr) {
        }

        public D3D11_DEPTH_STENCIL_VIEW_DESC Description {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 8 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_DEPTH_STENCIL_VIEW_DESC*, void>)(*(IntPtr*)address);

                D3D11_DEPTH_STENCIL_VIEW_DESC desc;
                @delegate(_nativePointer, &desc);

                return desc;
            }
        }
    }
}

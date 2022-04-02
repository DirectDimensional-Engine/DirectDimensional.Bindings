using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("03823efb-8d8f-4e1c-9aa2-f64bb2cbfdf1")]
    public unsafe sealed class DepthStencilState : DeviceChild {
        public DepthStencilState(IntPtr ptr) : base(ptr) {
        }

        public D3D11_DEPTH_STENCIL_DESC Description {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 7 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_DEPTH_STENCIL_DESC*, void>)(*(IntPtr*)address);

                D3D11_DEPTH_STENCIL_DESC desc;
                @delegate(_nativePointer, &desc);

                return desc;
            }
        }
    }
}

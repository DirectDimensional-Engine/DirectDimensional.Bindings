using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("9bb4ab81-ab1a-4d8f-b506-fc04200b6ee7")]
    public sealed unsafe class RasterizerState : DeviceChild {
        public RasterizerState(IntPtr ptr) : base(ptr) { }

        public D3D11_RASTERIZER_DESC Description {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 7 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_RASTERIZER_DESC*, void>)(*(IntPtr*)address);

                D3D11_RASTERIZER_DESC desc;
                @delegate(_nativePointer, &desc);

                return desc;
            }
        }
    }
}

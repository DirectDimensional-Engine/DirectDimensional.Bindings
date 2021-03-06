using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    public struct D3D11_RENDER_TARGET_BLEND_DESC {
        [MarshalAs(UnmanagedType.Bool)]
        public bool BlendEnable;
        public D3D11_BLEND SrcBlend;
        public D3D11_BLEND DestBlend;
        public D3D11_BLEND_OP BlendOp;
        public D3D11_BLEND SrcBlendAlpha;
        public D3D11_BLEND DestBlendAlpha;
        public D3D11_BLEND_OP BlendOpAlpha;
        public D3D11_COLOR_WRITE_ENABLE RenderTargetWriteMask;
    }
}

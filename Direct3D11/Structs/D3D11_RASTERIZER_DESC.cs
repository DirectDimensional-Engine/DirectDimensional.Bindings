using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    public struct D3D11_RASTERIZER_DESC {
        public D3D11_FILL_MODE FillMode = D3D11_FILL_MODE.Solid;
        public D3D11_CULL_MODE CullMode = D3D11_CULL_MODE.Back;
        public int FrontCounterClockwise = 0;
        public int DepthBias = 0;
        public float DepthBiasClamp = 0f;
        public float SlopeScaledDepthBias = 0f;
        public int DepthClipEnable = 1;
        public int ScissorEnable = 0;
        public int MultisampleEnable = 0;
        public int AntialiasedLineEnable = 0;

        internal static D3D11_RASTERIZER_DESC Default {
            get {
                D3D11_RASTERIZER_DESC desc = default;
                desc.FillMode = D3D11_FILL_MODE.Solid;
                desc.CullMode = D3D11_CULL_MODE.Back;
                desc.DepthClipEnable = 1;

                return desc;
            }
        }
    }
}

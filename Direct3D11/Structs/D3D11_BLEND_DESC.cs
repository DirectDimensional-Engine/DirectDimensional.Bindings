using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    public unsafe struct D3D11_BLEND_DESC {
        public bool AlphaToCoverageEnable {
            get => b_AlphaToCoverageEnable != 0;
            set => b_AlphaToCoverageEnable = *(int*)&value;
        }

        public bool IndependentBlendEnable {
            get => b_IndependentBlendEnable != 0;
            set => b_IndependentBlendEnable = *(int*)&value;
        }

        private int b_AlphaToCoverageEnable;
        private int b_IndependentBlendEnable;

        public D3D11_RENDER_TARGET_BLEND_DESC RenderTarget0;
        public D3D11_RENDER_TARGET_BLEND_DESC RenderTarget1;
        public D3D11_RENDER_TARGET_BLEND_DESC RenderTarget2;
        public D3D11_RENDER_TARGET_BLEND_DESC RenderTarget3;
        public D3D11_RENDER_TARGET_BLEND_DESC RenderTarget4;
        public D3D11_RENDER_TARGET_BLEND_DESC RenderTarget5;
        public D3D11_RENDER_TARGET_BLEND_DESC RenderTarget6;
        public D3D11_RENDER_TARGET_BLEND_DESC RenderTarget7;
    }
}

using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    public struct D3D11_DEPTH_STENCIL_DESC {
        [MarshalAs(UnmanagedType.Bool)]
        public bool DepthEnable;
        public D3D11_DEPTH_WRITE_MASK DepthWriteMask;
        public D3D11_COMPARISON_FUNC DepthFunc;
        [MarshalAs(UnmanagedType.Bool)]
        public bool StencilEnable;
        public byte StencilReadMask;
        public byte StencilWriteMask;
        public D3D11_DEPTH_STENCILOP_DESC FrontFace;
        public D3D11_DEPTH_STENCILOP_DESC BackFace;
    }
}

using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    public struct D3D11_SHADER_INPUT_BIND_DESC {
        [MarshalAs(UnmanagedType.LPStr)]
        public string Name;
        public D3D_SHADER_INPUT_TYPE Type;
        public uint BindPoint;
        public uint BindCount;
        public uint uFlags;
        public D3D_RESOURCE_RETURN_TYPE ReturnType;
        public D3D_SRV_DIMENSION Dimension;
        public uint NumSamples;
    }
}

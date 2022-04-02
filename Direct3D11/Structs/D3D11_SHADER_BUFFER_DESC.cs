using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    public struct D3D11_SHADER_BUFFER_DESC {
        [MarshalAs(UnmanagedType.LPStr)]
        public string Name;
        public D3D_CBUFFER_TYPE Type;
        public uint Variables;
        public uint Size;
        public uint uFlags;
    }
}

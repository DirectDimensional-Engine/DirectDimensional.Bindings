using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    public struct D3D11_SHADER_VARIABLE_DESC {
        [MarshalAs(UnmanagedType.LPStr)]
        public string Name;
        public uint StartOffset;
        public uint Size;
        public uint uFlags;
        public IntPtr DefaultValue;
        public uint StartTexture;
        public uint TextureSize;
        public uint StartSampler;
        public uint SamplerSize;
    }
}

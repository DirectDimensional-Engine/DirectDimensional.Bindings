using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.D3DCompiler {
    public struct D3D11_SHADER_VARIABLE_DESC {
        public IntPtr pName;
        public string Name => Marshal.PtrToStringAnsi(pName)!;

        public uint StartOffset;
        public uint Size;
        public uint Flags;
        public IntPtr DefaultValue;
        public uint StartTexture;
        public uint TextureSize;
        public uint StartSampler;
        public uint SamplerSize;
    }
}

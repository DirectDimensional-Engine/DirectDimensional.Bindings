using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.D3DCompiler {
    public struct D3D11_SHADER_INPUT_BIND_DESC {
        public IntPtr pName;
        public string Name => Marshal.PtrToStringAnsi(pName)!;

        public D3D_SHADER_INPUT_TYPE Type;
        public uint BindPoint;
        public uint BindCount;
        public uint Flags;
        public D3D_RESOURCE_RETURN_TYPE ReturnType;
        public D3D_SRV_DIMENSION Dimension;
        public uint NumSamples;
    }
}

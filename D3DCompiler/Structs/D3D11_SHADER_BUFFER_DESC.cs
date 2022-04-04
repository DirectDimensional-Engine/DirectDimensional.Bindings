using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.D3DCompiler {
    public struct D3D11_SHADER_BUFFER_DESC {
        public IntPtr pName;
        public string Name => Marshal.PtrToStringAnsi(pName)!;

        public D3D_CBUFFER_TYPE Type;
        public uint Variables;
        public uint Size;
        public D3D_SHADER_CBUFFER_FLAGS Flags;
    }
}

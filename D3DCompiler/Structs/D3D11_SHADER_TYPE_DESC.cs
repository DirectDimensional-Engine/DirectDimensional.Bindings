using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.D3DCompiler {
    public struct D3D11_SHADER_TYPE_DESC {
        public D3D_SHADER_VARIABLE_CLASS Class;
        public D3D_SHADER_VARIABLE_TYPE Type;
        public uint Rows;
        public uint Columns;
        public uint Elements;
        public uint Members;
        public uint Offset;
        [MarshalAs(UnmanagedType.LPStr)]
        public string Name;
    }
}

using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.D3DCompiler {
    public struct D3D11_SIGNATURE_PARAMETER_DESC {
        [MarshalAs(UnmanagedType.LPStr)]
        public string SemanticName;
        public uint SemanticIndex;
        public uint Register;
        public D3D_NAME SystemValueType;
        public D3D_REGISTER_COMPONENT_TYPE ComponentType;
        public byte Mask;
        public byte ReadWriteMask;
        public uint Stream;
        public D3D_MIN_PRECISION MinPrecision;
    }
}

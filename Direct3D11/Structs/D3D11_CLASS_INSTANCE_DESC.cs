using System;
using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    public struct D3D11_CLASS_INSTANCE_DESC {
        public uint InstanceId;
        public uint InstanceIndex;
        public uint TypeId;
        public uint ConstantBuffer;
        public uint BaseConstantBufferOffset;
        public uint BaseTexture;
        public uint BaseSampler;
        [MarshalAs(UnmanagedType.Bool)]
        public bool Created;
    }
}

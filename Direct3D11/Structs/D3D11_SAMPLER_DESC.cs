using System;
using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    public struct D3D11_SAMPLER_DESC {
        public D3D11_FILTER Filter;
        public D3D11_TEXTURE_ADDRESS_MODE AddressU;
        public D3D11_TEXTURE_ADDRESS_MODE AddressV;
        public D3D11_TEXTURE_ADDRESS_MODE AddressW;
        public float MipLODBias;
        public uint MaxAnisotropy;
        public D3D11_COMPARISON_FUNC ComparisonFunc;
        public FLOAT4 BorderColor;
        public float MinLOD;
        public float MaxLOD;
    }
}

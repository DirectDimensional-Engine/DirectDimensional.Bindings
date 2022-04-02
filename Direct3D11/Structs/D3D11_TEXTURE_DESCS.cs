using DirectDimensional.Bindings.DXGI;

namespace DirectDimensional.Bindings.Direct3D11 {
    public struct D3D11_TEXTURE1D_DESC {
        public uint Width;
        public uint MipLevels;
        public uint ArraySize;
        public DXGI_FORMAT Format;
        public D3D11_USAGE Usage;
        public D3D11_BIND_FLAG BindFlags;
        public D3D11_CPU_ACCESS_FLAG CPUAccessFlags;
        public D3D11_RESOURCE_MISC_FLAG MiscFlags;
    }

    public struct D3D11_TEXTURE2D_DESC {
        public uint Width;
        public uint Height;
        public uint MipLevels;
        public uint ArraySize;
        public DXGI_FORMAT Format;
        public DXGI_SAMPLE_DESC SampleDesc;
        public D3D11_USAGE Usage;
        public D3D11_BIND_FLAG BindFlags;
        public D3D11_CPU_ACCESS_FLAG CPUAccessFlags;
        public D3D11_RESOURCE_MISC_FLAG MiscFlags;
    }

    public struct D3D11_TEXTURE3D_DESC {
        public uint Width;
        public uint Height;
        public uint Depth;
        public uint MipLevels;
        public DXGI_FORMAT Format;
        public D3D11_USAGE Usage;
        public D3D11_BIND_FLAG BindFlags;
        public D3D11_CPU_ACCESS_FLAG CPUAccessFlags;
        public D3D11_RESOURCE_MISC_FLAG MiscFlags;
    }
}

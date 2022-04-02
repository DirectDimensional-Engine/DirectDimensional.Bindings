namespace DirectDimensional.Bindings.DXGI {
    public struct DXGI_MODE_DESC {
        public uint Width, Height;
        public DXGI_RATIONAL RefreshRate;
        public DXGI_FORMAT Format;
        public DXGI_MODE_SCANLINE_ORDER ScanlineOrder;
        public DXGI_MODE_SCALING Scaling;
    }
}

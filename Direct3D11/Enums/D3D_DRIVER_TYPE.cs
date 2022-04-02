namespace DirectDimensional.Bindings.Direct3D11 {
    public enum D3D_DRIVER_TYPE {
        Unknown = 0,
        Hardware = Unknown + 1,
        Reference = Hardware + 1,
        Null = Reference + 1,
        Software = Null + 1,
        WARP = Software + 1
    }
}

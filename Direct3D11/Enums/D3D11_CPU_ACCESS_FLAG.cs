namespace DirectDimensional.Bindings.Direct3D11 {
    [Flags]
    public enum D3D11_CPU_ACCESS_FLAG : uint {
        None = 0,

        Write = 0x10000,
        Read = 0x20000
    }
}

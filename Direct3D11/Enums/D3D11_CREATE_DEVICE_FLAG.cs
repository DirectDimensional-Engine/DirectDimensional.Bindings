namespace DirectDimensional.Bindings.Direct3D11 {
    [Flags]
    public enum D3D11_CREATE_DEVICE_FLAG {
        None = 0,

        Singlethreaded = 0x001,
        Debug = 0x002,
        SwitchToRef = 0x004,
        PreventInternalThreadingOptimization = 0x008,
        BGRASupport = 0x020,
        Debuggable = 0x040,
        PreventAlteringLayerSettingsFromRegistry = 0x080,
        DisableGPUTimeout = 0x100,
        VideoSupport = 0x800,
    }
}

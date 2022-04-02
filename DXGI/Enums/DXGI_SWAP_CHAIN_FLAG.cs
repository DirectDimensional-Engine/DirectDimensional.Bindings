using System;

namespace DirectDimensional.Bindings.DXGI {
    [Flags]
    public enum DXGI_SWAP_CHAIN_FLAG {
        NonPrerotated = 1,
        AllowModeSwitch = 2,
        GDICompatible = 4,
        RestrictedContent = 8,
        RestrictedSharedResourceDriver = 16,
        DisplayOnly = 32,
        FrameLatencyWaitableObject = 64,
        ForegroundLayer = 128,
        FullscreenVideo = 256,
        YUVVideo = 512,
        HWProtected = 1024,
        AllowTearing = 2048,
        RestrictedToAllHolographicDisplays = 4096
    }
}

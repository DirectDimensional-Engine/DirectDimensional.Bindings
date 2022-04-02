using System;

namespace DirectDimensional.Bindings.DXGI {
    [Flags]
    public enum DXGI_PRESENT : uint {
        None = 0,

        Test = 0x00000001U,
        DoNotSequence = 0x00000002U,
        Restart = 0x00000004U,
        DoNotWait = 0x00000008U,
        StereoPreferRight = 0x00000010U,
        StereoTemporaryMono = 0x00000020U,
        RestrictToOutput = 0x00000040U,
        UseDuration = 0x00000100U,
        AllowTearing = 0x00000200U,
    }
}

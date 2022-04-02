using System;

namespace DirectDimensional.Bindings.DXGI {
    [Flags]
    public enum DXGI_USAGE : uint {
        None = 0,

        ShaderInput                 = 0x00000010U,
        RenderTargetOutput          = 0x00000020U,
        BackBuffer                  = 0x00000040U,
        Shared                      = 0x00000080U,
        ReadOnly                    = 0x00000100U,
        DiscardOnPresent            = 0x00000200U,
        UnorderedAccess             = 0x00000400U,
    }
}

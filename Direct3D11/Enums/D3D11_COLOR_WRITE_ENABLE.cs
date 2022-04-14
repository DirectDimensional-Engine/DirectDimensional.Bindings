using System;
namespace DirectDimensional.Bindings.Direct3D11 {
    [Flags]
    public enum D3D11_COLOR_WRITE_ENABLE : byte {
        Red = 1,
        Green = 2,
        Blue = 4,
        Alpha = 8,
        All = Red | Green | Blue | Alpha,
    }
}

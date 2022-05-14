using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.WinAPI {
    [StructLayout(LayoutKind.Explicit)]
    internal struct RAWMOUSE {
        [FieldOffset(0)] public ushort Flags;

        [FieldOffset(4)] public uint Buttons;

        [FieldOffset(4)] public ushort ButtonFlags;
        [FieldOffset(6)] public ushort ButtonData;

        [FieldOffset(8)] public uint RawButtons;
        [FieldOffset(12)] public int LastX;
        [FieldOffset(16)] public int LastY;
        [FieldOffset(20)] public uint ExtraInformation;
    }
}

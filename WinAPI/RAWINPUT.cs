using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.WinAPI {
    [StructLayout(LayoutKind.Explicit)]
    internal struct RAWINPUT {
        [FieldOffset(0)] public RAWINPUTHEADER Header;

        [FieldOffset(24)] public RAWMOUSE Mouse;
        [FieldOffset(24)] public RAWKEYBOARD Keyboard;
        [FieldOffset(24)] public RAWHID HID;
    }
}

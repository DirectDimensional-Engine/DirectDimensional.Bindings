using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectDimensional.Bindings.WinAPI {
    // https://wiki.winehq.org/List_Of_Windows_Messages
    public enum WindowMessages : uint {
        Null = 0,
        Create = 1,
        Destroy = 2,
        Move = 3,
        Size = 5,
        Activate = 6,
        SetFocus = 7,
        KillFocus = 8,
        Enable = 10,
        Close = 16,
        Quit = 18,

        Input = 255,
        KeyDown = 256,
        KeyUp = 257,
        KeyChar = 258,

        SysKeyDown = 260,
        SysKeyUp = 261,
        SysChar = 262,

        MouseMove = 512,
        LMouseDown = 513,
        LMouseUp = 514,
        RMouseDown = 516,
        RMouseUp = 517,
        MMouseDown = 519,
        MMouseUp = 520,

        MouseWheel = 522,

        Sizing = 532,
        Moving = 534,
    }
}

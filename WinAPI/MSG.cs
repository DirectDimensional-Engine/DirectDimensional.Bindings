using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectDimensional.Bindings.WinAPI {
    internal struct MSG {
        public IntPtr hWnd = IntPtr.Zero;
        public WindowMessages Message = WindowMessages.Null;
        public nuint wParam = 0;
        public nint lParam = 0;
        public uint Time = 0;
        public POINT Point = default;
    }
}

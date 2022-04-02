using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectDimensional.Bindings.WinAPI {
    public struct RECT {
        public int Left = 0;
        public int Top = 0;
        public int Right = 0;
        public int Bottom = 0;
    }

    public struct POINT {
        public int X = 0;
        public int Y = 0;
    }

    public struct SIZE {
        public int Width = 0;
        public int Height = 0;
    }

    public struct POINTS {
        public short X = 0;
        public short Y = 0;
    }
}

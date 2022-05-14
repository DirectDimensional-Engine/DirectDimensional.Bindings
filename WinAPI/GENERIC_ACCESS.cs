using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectDimensional.Bindings.WinAPI {
    internal enum GENERIC_ACCESS : uint {
        Read = 0x80000000,
        Write = 0x40000000,
        Execute = 0x20000000,
        All = 0x10000000,
    }
}

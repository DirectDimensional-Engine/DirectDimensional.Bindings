using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectDimensional.Bindings.Direct3D11 {
    public struct D3D11_SUBRESOURCE_DATA {
        public IntPtr pData;
        public uint SysMemPitch;
        public uint SysMemSlicePitch;
    }
}

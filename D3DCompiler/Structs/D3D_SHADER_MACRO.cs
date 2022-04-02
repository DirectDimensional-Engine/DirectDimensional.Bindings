using System;
using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.D3DCompiler {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct D3D_SHADER_MACRO {
        public string? Name = null;
        public string? Definition = null;
    }
}

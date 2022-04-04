using System;

namespace DirectDimensional.Bindings.D3DCompiler {
    [Flags]
    public enum D3D_DISASM {
        Default                             = 0,

        EnableColorCode                     = 0x00000001,
        EnableDefaultValuePrint             = 0x00000002,
        EnableInstructionNumbering          = 0x00000004,
        EnableInstructionCycle              = 0x00000008,
        DisableDebugInfo                    = 0x00000010,
        EnableInstructionOffset             = 0x00000020,
        InstructionOnly                     = 0x00000040,
        PrintHexLiterals                    = 0x00000080,
    }
}

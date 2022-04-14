namespace DirectDimensional.Bindings.D3DCompiler {
    [Flags]
    public enum D3DCOMPILE {
        None = 0,

        Debug                                   = 1 << 0,
        SkipValidation                          = 1 << 1,
        SkipOptimization                        = 1 << 2,
        PackMatrixRowMajor                      = 1 << 3,
        PackMatrixColumnMajor                   = 1 << 4,
        PartialPrecision                        = 1 << 5,
        ForceVSSoftwareNoOpt                    = 1 << 6,
        ForcePSSoftwareNoOpt                    = 1 << 7,
        NoPreShader                             = 1 << 8,
        AvoidFlowControl                        = 1 << 9,
        PreferFlowControl                       = 1 << 10,
        EnableStrictness                        = 1 << 11,
        EnableBackwardsCompatibility            = 1 << 12,
        IEEEStrictness                          = 1 << 13,
        OptimizationLevel0                      = 1 << 14,
        OptimizationLevel1                      = 0,
        OptimizationLevel2                      = (1 << 14) | (1 << 15),
        OptimizationLevel3                      = 1 << 15,
        WarningsAreErrors                       = 1 << 18,
        DebugNameForSource                      = 1 << 22,
        DebugNameForBinary                      = 1 << 23,
    }
}

using System.Runtime.InteropServices;
using DirectDimensional.Bindings.Direct3D11;

namespace DirectDimensional.Bindings.D3DCompiler {
    internal static unsafe class D3D {
        public static HRESULT Compile(string input, string? sourceName, D3D_SHADER_MACRO[]? macros, Include? include, string entryPoint, string target, D3DCOMPILE flags, out Blob? outputBytecode, out Blob? outputError) {
            if (macros != null) {
                if (macros.Length == 0) {
                    macros = new D3D_SHADER_MACRO[] {
                        new D3D_SHADER_MACRO() { Name = null, Definition = null },
                    };
                } else if (macros[^1].Name != null && macros[^1].Definition != null) {
                    Array.Resize(ref macros, macros.Length + 1);
                }
            }

            HRESULT hr = D3DCompile(input, (nuint)input.Length, sourceName, macros, include == null ? IntPtr.Zero : include.VirtualTable, entryPoint, target, flags, 0, out IntPtr pBytecode, out IntPtr pError);

            if (hr.Failed) {
                if (pBytecode != IntPtr.Zero) Marshal.Release(pBytecode);   // Just to make sure, idk whether this needed

                outputBytecode = null;
                outputError = new(pError);

                return hr;
            }

            outputBytecode = new(pBytecode);
            outputError = null;
            return hr;
        }

        [DllImport("d3dcompiler_47.dll", ExactSpelling = true, ThrowOnUnmappableChar = false, CharSet = CharSet.Ansi)]
        private static extern HRESULT D3DCompile(string input, nuint inputSize, string? sourceName, [MarshalAs(UnmanagedType.LPArray)] D3D_SHADER_MACRO[]? macros, IntPtr pInclude, string entryPoint, string target, D3DCOMPILE flags, uint unused, out IntPtr ppCode, out IntPtr ppError);
    }
}

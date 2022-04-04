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

        public static HRESULT Reflect<T>(Blob bytecode, out T? reflectionInterface) where T : ComObject {
            var type = typeof(T);

            HRESULT hr = D3DReflect(bytecode.GetBufferPointer(), bytecode.GetBufferSize(), type.GUID, out IntPtr pInterface);
            if (hr.Failed) {
                reflectionInterface = null;
                return hr;
            }

            reflectionInterface = Activator.CreateInstance(type, pInterface) as T;
            return hr;
        }

        public static HRESULT Disassemble(Blob bytecode, D3D_DISASM flags, string? comments, out Blob? output) {
            HRESULT hr = D3DDisassemble(bytecode.GetBufferPointer(), bytecode.GetBufferSize(), flags, comments, out IntPtr pBlob);
            if (hr.Failed) {
                output = null;
                return hr;
            }

            output = new(pBlob);
            return hr;
        }

        internal static HRESULT WriteBlobToFile(Blob blob, string path, bool overrideContent = true) {
            return D3DWriteBlobToFile(blob._nativePointer, path, overrideContent);
        }

        [DllImport("d3dcompiler_47.dll", ExactSpelling = true, ThrowOnUnmappableChar = false, CharSet = CharSet.Ansi)]
        private static extern HRESULT D3DCompile(string input, nuint inputSize, string? sourceName, D3D_SHADER_MACRO[]? macros, IntPtr pInclude, string entryPoint, string target, D3DCOMPILE flags, uint unused, out IntPtr ppCode, out IntPtr ppError);
        [DllImport("d3dcompiler_47.dll", ExactSpelling = true, ThrowOnUnmappableChar = false)]
        private static extern HRESULT D3DReflect(IntPtr srcData, nuint inputSize, [MarshalAs(UnmanagedType.LPStruct)] Guid interfaceGuid, out IntPtr pInterface);
        [DllImport("d3dcompiler_47.dll", ExactSpelling = true, ThrowOnUnmappableChar = false, CharSet = CharSet.Ansi)]
        private static extern HRESULT D3DDisassemble(IntPtr srcData, nuint inputSize, D3D_DISASM flags, string? szComments, out IntPtr pBlob);
        [DllImport("d3dcompiler_47.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern HRESULT D3DWriteBlobToFile(IntPtr pBlob, string path, [MarshalAs(UnmanagedType.Bool)] bool bOverride);
    }
}

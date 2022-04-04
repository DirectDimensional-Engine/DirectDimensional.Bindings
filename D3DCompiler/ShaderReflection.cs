using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.D3DCompiler {
    [Guid("8d536ca1-0cca-4956-a837-786963755584")]
    public sealed unsafe class ShaderReflection : ComObject {
        public ShaderReflection(IntPtr ptr) : base(ptr) { }

        public D3D11_SHADER_DESC Description {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 3 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_SHADER_DESC*, HRESULT>)(*(IntPtr*)address);

                D3D11_SHADER_DESC desc;
                @delegate(_nativePointer, &desc);

                return desc;
            }
        }

        public ShaderReflectionConstantBuffer? GetConstantBufferByName(string name) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 5 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr>)(*(IntPtr*)address);

            var pName = Marshal.StringToHGlobalAnsi(name);
            IntPtr underlying = @delegate(_nativePointer, pName);
            Marshal.FreeHGlobal(pName);

            return underlying == IntPtr.Zero ? null : new ShaderReflectionConstantBuffer(underlying);
        }


        public ShaderReflectionVariable? GetVariableByName(string name) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 10 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr>)(*(IntPtr*)address);

            var pName = Marshal.StringToHGlobalAnsi(name);
            IntPtr underlying = @delegate(_nativePointer, pName);
            Marshal.FreeHGlobal(pName);

            return underlying == IntPtr.Zero ? null : new ShaderReflectionVariable(underlying);
        }

        public HRESULT GetResourceBindingDescByName(string name, out D3D11_SHADER_INPUT_BIND_DESC desc) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 11 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, D3D11_SHADER_INPUT_BIND_DESC*, HRESULT>)(*(IntPtr*)address);

            fixed (D3D11_SHADER_INPUT_BIND_DESC* ptr = &desc) {
                var pName = Marshal.StringToHGlobalAnsi(name);
                HRESULT hr = @delegate(_nativePointer, pName, ptr);
                Marshal.FreeHGlobal(pName);

                return hr;
            }
        }
    }
}

using System;
using System.Runtime.InteropServices;
using DirectDimensional.Bindings.DXGI;

namespace DirectDimensional.Bindings.Direct3D11 {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct D3D11_INPUT_ELEMENT_DESC : IDisposable {
        public IntPtr SemanticName;
        public uint SemanticIndex;
        public DXGI_FORMAT Format;
        public uint InputSlot;
        public uint AlignedByteOffset;
        public D3D11_INPUT_CLASSIFICATION InputSlotClass;
        public uint InstanceDataStepRate;

        public D3D11_INPUT_ELEMENT_DESC(string name, uint index, DXGI_FORMAT format, uint inputSlot, uint alignedByteOffset, D3D11_INPUT_CLASSIFICATION inputSlotClass, uint instanceStepRate) {
            SemanticName = Marshal.StringToHGlobalAnsi(name);
            SemanticIndex = index;
            Format = format;
            InputSlot = inputSlot;
            AlignedByteOffset = alignedByteOffset;
            InputSlotClass = inputSlotClass;
            InstanceDataStepRate = instanceStepRate;
        }

        public void Dispose() {
            Marshal.FreeHGlobal(SemanticName);
        }
    }
}

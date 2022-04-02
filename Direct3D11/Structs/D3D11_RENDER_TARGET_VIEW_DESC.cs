using System;
using System.Runtime.InteropServices;
using DirectDimensional.Bindings.DXGI;

namespace DirectDimensional.Bindings.Direct3D11 {
    public enum D3D11_RTV_DIMENSION : uint {
        Unknown = 0,
        Buffer,
        Texture1D = 2,
        Texture1DArray = 3,
        Texture2D = 4,
        Texture2DArray = 5,
        Texture2DMS = 6,
        Texture2DMSArray = 7,
        Texture3D = 8
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct D3D11_BUFFER_RTV {
        [FieldOffset(0)] public uint FirstElement;
        [FieldOffset(4)] public uint ElementOffset;

        [FieldOffset(0)] public uint NumElements;
        [FieldOffset(4)] public uint ElementWidth;
    }

    public struct D3D11_TEX1D_RTV {
        public uint MipSlice;
    }

    public struct D3D11_TEX1D_ARRAY_RTV {
        public uint MipSlice;
        public uint FirstArraySlice;
        public uint ArraySize;
    }

    public struct D3D11_TEX2D_RTV {
        public uint MipSlice;
    }

    public struct D3D11_TEX2DMS_RTV {
        public uint UnusedField;
    }

    public struct D3D11_TEX2D_ARRAY_RTV {
        public uint MipSlice;
        public uint FirstArraySlice;
        public uint ArraySize;
    }

    public struct D3D11_TEX2DMS_ARRAY_RTV {
        public uint FirstArraySlice;
        public uint ArraySize;
    }

    public struct D3D11_TEX3D_RTV {
        public uint MipSlice;
        public uint FirstWSlice;
        public uint WSize;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct D3D11_RENDER_TARGET_VIEW_DESC {
        [FieldOffset(0)] public DXGI_FORMAT Format;
        [FieldOffset(4)] public D3D11_RTV_DIMENSION ViewDimension;

        [FieldOffset(8)] public D3D11_BUFFER_RTV Buffer;
        [FieldOffset(8)] public D3D11_TEX1D_RTV Texture1D;
        [FieldOffset(8)] public D3D11_TEX1D_ARRAY_RTV Texture1DArray;
        [FieldOffset(8)] public D3D11_TEX2D_RTV Texture2D;
        [FieldOffset(8)] public D3D11_TEX2D_ARRAY_RTV Texture2DArray;
        [FieldOffset(8)] public D3D11_TEX2DMS_RTV Texture2DMS;
        [FieldOffset(8)] public D3D11_TEX2DMS_ARRAY_RTV Texture2DMSArray;
        [FieldOffset(8)] public D3D11_TEX3D_RTV Texture3D;
    }
}

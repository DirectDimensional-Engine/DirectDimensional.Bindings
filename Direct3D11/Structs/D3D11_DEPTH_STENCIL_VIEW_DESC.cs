using System;
using System.Runtime.InteropServices;
using DirectDimensional.Bindings.DXGI;

namespace DirectDimensional.Bindings.Direct3D11 {
    public enum D3D11_DSV_DIMENSION {
        Unknown = 0,
        Texture1D,
        Texture1DArray,
        Texture2D,
        Texture2DArray,
        Texture2DMS,
        Texture2DMSArray,
    }

    public enum D3D11_DSV_FLAG : uint {
        ReadOnlyDepth = 0x1U,
        ReadOnlyStencil = 0x2U,
    }

    public struct D3D11_TEX1D_DSV {
        public uint MipSlice;
    }

    public struct D3D11_TEX1D_ARRAY_DSV {
        public uint MipSlice;
        public uint FirstArraySlice;
        public uint ArraySize;
    }

    public struct D3D11_TEX2D_DSV {
        public uint MipSlice;
    }

    public struct D3D11_TEX2D_ARRAY_DSV {
        public uint MipSlice;
        public uint FirstArraySlice;
        public uint ArraySize;
    }

    public struct D3D11_TEX2DMS_DSV {
        public uint UnusedField;
    }

    public struct D3D11_TEX2DMS_ARRAY_DSV {
        public uint FirstArraySlice;
        public uint ArraySize;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct D3D11_DEPTH_STENCIL_VIEW_DESC {
        [FieldOffset(0)] public DXGI_FORMAT Format;
        [FieldOffset(4)] public D3D11_DSV_DIMENSION ViewDimension;
        [FieldOffset(8)] public D3D11_DSV_FLAG Flags;

        [FieldOffset(12)] public D3D11_TEX1D_DSV Texture1D;
        [FieldOffset(12)] public D3D11_TEX1D_ARRAY_DSV Texture1DArray;
        [FieldOffset(12)] public D3D11_TEX2D_DSV Texture2D;
        [FieldOffset(12)] public D3D11_TEX2D_ARRAY_DSV Texture2DArray;
        [FieldOffset(12)] public D3D11_TEX2DMS_DSV Texture2DMS;
        [FieldOffset(12)] public D3D11_TEX2DMS_ARRAY_DSV Texture2DMSArray;

        //public DXGI_FORMAT Format;
        //public D3D11_DSV_DIMENSION ViewDimension;
        //public D3D11_DSV_FLAG Flags;

        ////public D3D11_TEX1D_DSV Texture1D;
        ////public D3D11_TEX1D_ARRAY_DSV Texture1DArray;
        //public D3D11_TEX2D_DSV Texture2D;
        ////public D3D11_TEX2D_ARRAY_DSV Texture2DArray;
        ////public D3D11_TEX2DMS_DSV Texture2DMS;
        ////public D3D11_TEX2DMS_ARRAY_DSV Texture2DMSArray;
    }
}

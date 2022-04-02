using System.Runtime.InteropServices;
using DirectDimensional.Bindings.DXGI;
using DirectDimensional.Bindings.WinAPI;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("c0bfa96c-e089-44fb-8eaf-26f8796190da")]
    public unsafe sealed class DeviceContext : DeviceChild {
        public DeviceContext(IntPtr ptr) : base(ptr) {
        }

        public void VSSetConstantBuffers(uint startSlot, ComArray<Buffer?> buffers) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 7 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, uint, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, buffers.ULength, buffers.NativePointer);
        }

        public void PSSetShaderResources(uint startSlot, ComArray<ShaderResourceView?> views) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 8 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, uint, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, views.ULength, views.NativePointer);
        }

        public void PSSetShader(PixelShader? shader) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 9 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, uint, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, shader.GetNativePtr(), IntPtr.Zero, 0u);
        }

        public void PSSetSamplers(uint startSlot, ComArray<SamplerState> samplers) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 10 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, uint, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, samplers.ULength, samplers.NativePointer);
        }

        public void VSSetShader(VertexShader? shader) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 11 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, uint, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, shader.GetNativePtr(), IntPtr.Zero, 0u);
        }

        public void DrawIndexed(uint indexCount, uint startIndexLocation, int baseVertexPosition) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 12 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, uint, int, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, indexCount, startIndexLocation, baseVertexPosition);
        }

        public void Draw(uint vertexCount, uint startVertexLocation) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 13 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, uint, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, vertexCount, startVertexLocation);
        }

        public void Map(Resource resource, uint subresource, D3D11_MAP mapType, D3D11_MAPPED_SUBRESOURCE* pMappedResource) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 14 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, uint, D3D11_MAP, uint, D3D11_MAPPED_SUBRESOURCE*, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, resource._nativePointer, subresource, mapType, 0u, pMappedResource);
        }

        public void Unmap(Resource resource, uint subresource) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 15 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, uint, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, resource._nativePointer, subresource);
        }

        public void PSSetConstantBuffers(uint startSlot, ComArray<Buffer?> buffers) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 16 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, uint, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, buffers.ULength, buffers.NativePointer);
        }

        public void IASetInputLayout(InputLayout? layout) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 17 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, layout.GetNativePtr());
        }

        public void IASetVertexBuffers(uint startSlot, ComArray<Buffer> buffers, IntPtr pStrides, IntPtr pOffsets) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 18 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, uint, IntPtr, IntPtr, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, buffers.ULength, buffers.NativePointer, pStrides, pOffsets);
        }

        public void IASetVertexBuffers(uint startSlot, ComArray<Buffer> buffers, uint[] strides, uint[] offsets) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 18 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, uint, IntPtr, uint*, uint*, void>)(*(IntPtr*)address);

            fixed (uint* pStrides = &strides[0], pOffsets = &offsets[0]) {
                @delegate(_nativePointer, startSlot, buffers.ULength, buffers.NativePointer, pStrides, pOffsets);
            }
        }

        public void IASetIndexBuffer(Buffer? buffer, DXGI_FORMAT format, uint offset) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 19 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, DXGI_FORMAT, uint, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, buffer.GetNativePtr(), format, offset);
        }

        public void DrawIndexedInstanced(uint indexCountPerInstance, uint instanceCount, uint startIndexLocation, int baseVertexPosition, uint startInstancePosition) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 20 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, uint, uint, int, uint, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, indexCountPerInstance, instanceCount, startIndexLocation, baseVertexPosition, startInstancePosition);
        }

        public void DrawInstanced(uint vertexCountPerInstance, uint instanceCount, uint startVertexLocation, uint startInstancePosition) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 21 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, uint, uint, uint, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, vertexCountPerInstance, instanceCount, startVertexLocation, startInstancePosition);
        }

        public void IASetPrimitiveTopology(D3D11_PRIMITIVE_TOPOLOGY topology) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 24 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_PRIMITIVE_TOPOLOGY, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, topology);
        }

        public void VSSetShaderResources(uint startSlot, ComArray<ShaderResourceView?> views) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 25 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, uint, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, views.ULength, views.NativePointer);
        }

        public void VSSetSamplers(uint startSlot, ComArray<SamplerState> samplers) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 26 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, uint, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, samplers.ULength, samplers.NativePointer);
        }

        public void OMSetRenderTargets(ComArray<RenderTargetView> views, DepthStencilView? depthView) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 33 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, IntPtr, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, views.ULength, views.NativePointer, depthView.GetNativePtr());
        }

        //public void OMSetBlendState() {
        //    IntPtr address = (*(IntPtr*)_nativePointer) + 35 * IntPtr.Size;
        //    var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, FLOAT4*, uint, void>)(*(IntPtr*)address);
        //}

        public void OMSetDepthStencilState(DepthStencilState? depthState, uint stencilRef) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 36 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, uint, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, depthState.GetNativePtr(), stencilRef);
        }

        public void RSSetViewports(D3D11_VIEWPORT viewport) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 44 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, D3D11_VIEWPORT*, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, 1u, &viewport);
        }

        public void RSSetViewports(D3D11_VIEWPORT[] viewports) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 44 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, D3D11_VIEWPORT*, void>)(*(IntPtr*)address);

            fixed (D3D11_VIEWPORT* pViewports = &viewports[0]) {
                @delegate(_nativePointer, (uint)viewports.Length, pViewports);
            }
        }

        public void RSSetScissorRects(RECT rect) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 45 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, RECT*, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, 1u, &rect);
        }

        public void RSSetScissorRects(RECT[] rects) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 45 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, RECT*, void>)(*(IntPtr*)address);

            fixed (RECT* pRects = &rects[0]) {
                @delegate(_nativePointer, (uint)rects.Length, pRects);
            }
        }

        public void CopySubresourceRegion(Resource dest, uint destSubresource, uint destX, uint destY, uint destZ, Resource source, uint sourceSubresource, in D3D11_BOX sourceBox) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 46 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, uint, uint, uint, uint, IntPtr, uint, D3D11_BOX*, void>)(*(IntPtr*)address);

            fixed (D3D11_BOX* pBox = &sourceBox) {
                @delegate(_nativePointer, dest._nativePointer, destSubresource, destX, destY, destZ, source._nativePointer, sourceSubresource, pBox);
            }
        }

        public void CopyResource(Resource dest, Resource source) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 47 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, dest._nativePointer, source._nativePointer);
        }

        public void UpdateSubresource(Resource dest, uint destSubresource, in D3D11_BOX destBox, IntPtr source, uint sourceRowPitch, uint sourceDepthPitch) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 48 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, uint, D3D11_BOX*, IntPtr, uint, uint, void>)(*(IntPtr*)address);

            fixed (D3D11_BOX* pBox = &destBox) {
                @delegate(_nativePointer, dest._nativePointer, destSubresource, pBox, source, sourceRowPitch, sourceDepthPitch);
            }
        }

        public void ClearRenderTargetView(RenderTargetView view, in FLOAT4 clearColor) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 50 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, float*, void>)(*(IntPtr*)address);

            fixed (float* pColor = &clearColor.A) {
                @delegate(_nativePointer, view._nativePointer, pColor);
            }
        }

        public void ClearDepthStencilView(DepthStencilView view, D3D11_CLEAR_FLAG flags, float depth, byte stencil) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 53 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, D3D11_CLEAR_FLAG, float, byte, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, view._nativePointer, flags, depth, stencil);
        }

        public void GenerateMips(ShaderResourceView view) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 54 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, view._nativePointer);
        }

        public void SetResourceMinLOD(Resource resource, float minLOD) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 55 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, float, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, resource._nativePointer, minLOD);
        }

        public float GetResourceMinLOD(Resource resource) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 56 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, float>)(*(IntPtr*)address);

            return @delegate(_nativePointer, resource._nativePointer);
        }

        public void ResolveSubresource(Resource dest, uint destSubresoure, Resource source, uint sourceSubresource, DXGI_FORMAT format) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 57 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, uint, IntPtr, uint, DXGI_FORMAT, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, dest._nativePointer, destSubresoure, source._nativePointer, sourceSubresource, format);
        }

        // TODO: Implement getters
        //public void VSGetConstantBuffers() {
        //    IntPtr address = (*(IntPtr*)_nativePointer) + 72 * IntPtr.Size;
        //}
    }
}

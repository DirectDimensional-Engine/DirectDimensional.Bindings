using System.Runtime.InteropServices;
using DirectDimensional.Bindings.DXGI;
using DirectDimensional.Bindings.WinAPI;
using System.Numerics;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("c0bfa96c-e089-44fb-8eaf-26f8796190da")]
    public unsafe sealed class DeviceContext : DeviceChild {
        public DeviceContext(IntPtr ptr) : base(ptr) {
        }

        public void VSSetConstantBuffers(int startSlot, IComCollection<Buffer> buffers) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 7 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, buffers.Count, buffers.NativePointer);
        }

        public void VSSetConstantBuffers(int startSlot, int count, IntPtr buffers) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 7 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, count, buffers);
        }

        public void PSSetShaderResources(int startSlot, IComCollection<ShaderResourceView> views) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 8 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, views.Count, views.NativePointer);
        }

        public void PSSetShaderResources(int startSlot, int count, IntPtr views) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 8 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, count, views);
        }

        public void PSSetShader(PixelShader? shader) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 9 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, int, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, shader.GetNativePtr(), IntPtr.Zero, 0);
        }

        public void PSSetSamplers(int startSlot, IComCollection<SamplerState> samplers) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 10 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, samplers.Count, samplers.NativePointer);
        }

        public void PSSetSamplers(int startSlot, int count, IntPtr samplers) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 10 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, count, samplers);
        }

        public void VSSetShader(VertexShader? shader) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 11 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, int, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, shader.GetNativePtr(), IntPtr.Zero, 0);
        }

        public void DrawIndexed(int indexCount, int startIndexLocation, int baseVertexPosition) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 12 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, int, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, indexCount, startIndexLocation, baseVertexPosition);
        }

        public void Draw(int vertexCount, int startVertexLocation) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 13 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, vertexCount, startVertexLocation);
        }

        public HRESULT Map(Resource resource, int subresource, D3D11_MAP mapType, D3D11_MAPPED_SUBRESOURCE* pMappedResource) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 14 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int, D3D11_MAP, int, D3D11_MAPPED_SUBRESOURCE*, HRESULT>)(*(IntPtr*)address);

            return @delegate(_nativePointer, resource._nativePointer, subresource, mapType, 0, pMappedResource);
        }

        public void Unmap(Resource resource, int subresource) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 15 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, resource._nativePointer, subresource);
        }

        public void PSSetConstantBuffers(int startSlot, IComCollection<Buffer> buffers) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 16 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, buffers.Count, buffers.NativePointer);
        }

        public void PSSetConstantBuffers(int startSlot, int count, IntPtr buffers) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 16 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, count, buffers);
        }

        public void IASetInputLayout(InputLayout? layout) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 17 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, layout.GetNativePtr());
        }

        public void IASetVertexBuffers(int startSlot, IComCollection<Buffer> buffers, int[] strides, int[] offsets) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 18 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, IntPtr, int*, int*, void>)(*(IntPtr*)address);

            fixed (int* pStrides = &strides[0], pOffsets = &offsets[0]) {
                @delegate(_nativePointer, startSlot, buffers.Count, buffers.NativePointer, pStrides, pOffsets);
            }
        }

        public void IASetVertexBuffers(int startSlot, int count, IntPtr buffers, Span<int> strides, Span<int> offsets) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 18 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, IntPtr, int*, int*, void>)(*(IntPtr*)address);

            fixed (int* pStrides = strides, pOffset = offsets) {
                @delegate(_nativePointer, startSlot, count, buffers, pStrides, pOffset);
            }
        }

        public void IASetIndexBuffer(Buffer? buffer, DXGI_FORMAT format, int offset) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 19 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, DXGI_FORMAT, int, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, buffer.GetNativePtr(), format, offset);
        }

        public void DrawIndexedInstanced(int indexCountPerInstance, int instanceCount, int startIndexLocation, int baseVertexPosition, int startInstancePosition) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 20 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, int, int, int, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, indexCountPerInstance, instanceCount, startIndexLocation, baseVertexPosition, startInstancePosition);
        }

        public void DrawInstanced(int vertexCountPerInstance, int instanceCount, int startVertexLocation, int startInstancePosition) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 21 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, int, int, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, vertexCountPerInstance, instanceCount, startVertexLocation, startInstancePosition);
        }

        public void IASetPrimitiveTopology(D3D11_PRIMITIVE_TOPOLOGY topology) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 24 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_PRIMITIVE_TOPOLOGY, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, topology);
        }

        public void VSSetShaderResources(int startSlot, IComCollection<ShaderResourceView> views) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 25 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, views.Count, views.NativePointer);
        }

        public void VSSetShaderResources(int startSlot, int count, IntPtr views) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 25 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, count, views);
        }

        public void VSSetSamplers(int startSlot, IComCollection<SamplerState> samplers) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 26 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, samplers.Count, samplers.NativePointer);
        }

        public void VSSetSamplers(int startSlot, int count, IntPtr samplers) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 26 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, startSlot, count, samplers);
        }

        public void OMSetRenderTargets(IComCollection<RenderTargetView>? views, DepthStencilView? depthView) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 33 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, IntPtr, void>)(*(IntPtr*)address);

            if (views == null) {
                @delegate(_nativePointer, 0, IntPtr.Zero, depthView.GetNativePtr());

                Console.WriteLine("Null were binded");
            } else {
                @delegate(_nativePointer, views.Count, views.NativePointer, depthView.GetNativePtr());
            }
        }

        public void OMSetRenderTargets(int count, IntPtr views, DepthStencilView? depthView) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 33 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, IntPtr, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, count, views, depthView.GetNativePtr());
        }

        public void OMSetBlendState(BlendState? blendState, float* blendFactor, int sampleMask) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 35 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, float*, int, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, blendState.GetNativePtr(), blendFactor, sampleMask);
        }

        public void OMSetDepthStencilState(DepthStencilState? depthState, int stencilRef) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 36 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, depthState.GetNativePtr(), stencilRef);
        }

        public void RSSetState(RasterizerState? rs) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 43 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, rs.GetNativePtr());
        }

        public void RSSetViewport(D3D11_VIEWPORT viewport) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 44 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, D3D11_VIEWPORT*, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, 1, &viewport);
        }

        public void RSSetViewports(D3D11_VIEWPORT[] viewports) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 44 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, D3D11_VIEWPORT*, void>)(*(IntPtr*)address);

            fixed (D3D11_VIEWPORT* pViewports = &viewports[0]) {
                @delegate(_nativePointer, viewports.Length, pViewports);
            }
        }

        public void RSSetScissorRects(RECT rect) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 45 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, RECT*, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, 1, &rect);
        }

        public void RSSetScissorRects(RECT[] rects) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 45 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, RECT*, void>)(*(IntPtr*)address);

            fixed (RECT* pRects = &rects[0]) {
                @delegate(_nativePointer, rects.Length, pRects);
            }
        }

        public void CopySubresourceRegion(Resource dest, int destSubresource, int destX, int destY, int destZ, Resource source, int sourceSubresource, in D3D11_BOX sourceBox) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 46 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int, int, int, int, IntPtr, int, D3D11_BOX*, void>)(*(IntPtr*)address);

            fixed (D3D11_BOX* pBox = &sourceBox) {
                @delegate(_nativePointer, dest._nativePointer, destSubresource, destX, destY, destZ, source._nativePointer, sourceSubresource, pBox);
            }
        }

        public void CopyResource(Resource dest, Resource source) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 47 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, dest._nativePointer, source._nativePointer);
        }

        public void UpdateSubresource(Resource dest, int destSubresource, in D3D11_BOX destBox, IntPtr source, int sourceRowPitch, int sourceDepthPitch) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 48 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int, D3D11_BOX*, IntPtr, int, int, void>)(*(IntPtr*)address);

            fixed (D3D11_BOX* pBox = &destBox) {
                @delegate(_nativePointer, dest._nativePointer, destSubresource, pBox, source, sourceRowPitch, sourceDepthPitch);
            }
        }

        public void ClearRenderTargetView(RenderTargetView view, in Vector4 clearColor) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 50 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, float*, void>)(*(IntPtr*)address);

            fixed (float* pColor = &clearColor.X) {
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

        public void ResolveSubresource(Resource dest, int destSubresoure, Resource source, int sourceSubresource, DXGI_FORMAT format) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 57 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int, IntPtr, int, DXGI_FORMAT, void>)(*(IntPtr*)address);

            @delegate(_nativePointer, dest._nativePointer, destSubresoure, source._nativePointer, sourceSubresource, format);
        }

        // Getters
        public void VSGetConstantBuffers(int startSlot, ComArray<Buffer> buffers) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 72 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, void*, void>)(*(IntPtr*)address);

            int size = Math.Min(buffers.Count, 14 - startSlot);
            IntPtr* ptr = stackalloc IntPtr[size];

            @delegate(_nativePointer, startSlot, size, ptr);

            for (int i = 0; i < size; i++) {
                buffers[i] = ptr[i] == IntPtr.Zero ? null : new(ptr[i]);
            }
        }

        public IntPtr VSGetConstantBuffersAsPtr(int startSlot, int numBuffers) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 72 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, void**, void>)(*(IntPtr*)address);

            void** ppBuffers = null;
            @delegate(_nativePointer, startSlot, numBuffers, ppBuffers);

            return new IntPtr(ppBuffers);
        }

        public void PSGetShaderResources(int startSlot, ComArray<ShaderResourceView> resources) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 73 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, void*, void>)(*(IntPtr*)address);

            int size = Math.Min(resources.Count, 128 - startSlot);
            IntPtr* ptr = stackalloc IntPtr[size];

            @delegate(_nativePointer, startSlot, size, ptr);

            for (int i = 0; i < size; i++) {
                resources[i] = ptr[i] == IntPtr.Zero ? null : new(ptr[i]);
            }
        }

        public PixelShader? PSGetShader() {
            IntPtr address = (*(IntPtr*)_nativePointer) + 74 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, void**, void**, int*, void>)(*(IntPtr*)address);

            void* ptr;
            @delegate(_nativePointer, &ptr, null, null);
            return new(new IntPtr(ptr));
        }

        public void PSGetSamplers(int startSlot, ComArray<SamplerState> samplers) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 75 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, void*, void>)(*(IntPtr*)address);

            int size = Math.Min(samplers.Count, 128 - startSlot);
            IntPtr* ptr = stackalloc IntPtr[size];

            @delegate(_nativePointer, startSlot, size, ptr);

            for (int i = 0; i < size; i++) {
                samplers[i] = ptr[i] == IntPtr.Zero ? null : new(ptr[i]);
            }
        }

        public VertexShader? VSGetShader() {
            IntPtr address = (*(IntPtr*)_nativePointer) + 76 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, void**, void**, int*, void>)(*(IntPtr*)address);

            void* ptr;
            @delegate(_nativePointer, &ptr, null, null);
            return new(new IntPtr(ptr));
        }

        public void PSGetConstantBuffers(int startSlot, ComArray<Buffer> buffers) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 77 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, void*, void>)(*(IntPtr*)address);

            int size = Math.Min(buffers.Count, 14 - startSlot);
            IntPtr* ptr = stackalloc IntPtr[size];

            @delegate(_nativePointer, startSlot, size, ptr);

            for (int i = 0; i < size; i++) {
                buffers[i] = ptr[i] == IntPtr.Zero ? null : new(ptr[i]);
            }
        }

        public InputLayout? IAGetInputLayout() {
            IntPtr address = (*(IntPtr*)_nativePointer) + 78 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, void**, void>)(*(IntPtr*)address);

            void* pIL;
            @delegate(_nativePointer, &pIL);

            return pIL == null ? null : new(new IntPtr(pIL));
        }

        public void IAGetVertexBuffers(int startSlot, ComArray<Buffer> buffers, int[]? strides, int[]? offsets) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 79 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, void*, int*, int*, void>)(*(IntPtr*)address);

            int size = Math.Min(buffers.Count, 32 - (int)startSlot);

            IntPtr* ptr = stackalloc IntPtr[size];

            fixed (int* pStride = strides.AsSpan(), pOffset = offsets.AsSpan()) {
                @delegate(_nativePointer, startSlot, size, ptr, pStride, pOffset);

                for (int i = 0; i < size; i++) {
                    buffers[i] = ptr[i] == IntPtr.Zero ? null : new(ptr[i]);
                }
            }
        }

        public Buffer? IAGetIndexBuffer(out DXGI_FORMAT format, out int offset) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 80 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, void**, DXGI_FORMAT*, int*, void>)(*(IntPtr*)address);

            fixed (DXGI_FORMAT* pFormat = &format) {
                fixed (int* pOffset = &offset) {
                    void* pOutput;
                    @delegate(_nativePointer, &pOutput, pFormat, pOffset);

                    return pOutput == null ? null : new(new IntPtr(pOutput));
                }
            }
        }

        public D3D11_PRIMITIVE_TOPOLOGY IAGetPrimitiveTopology() {
            IntPtr address = (*(IntPtr*)_nativePointer) + 83 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_PRIMITIVE_TOPOLOGY*, void>)(*(IntPtr*)address);

            D3D11_PRIMITIVE_TOPOLOGY output;
            @delegate(_nativePointer, &output);

            return output;
        }

        public void VSGetShaderResources(int startSlot, ComArray<ShaderResourceView> views) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 84 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, void*, void>)(*(IntPtr*)address);

            int size = Math.Min(views.Count, 128 - (int)startSlot);

            IntPtr* ptr = stackalloc IntPtr[size];

            @delegate(_nativePointer, startSlot, size, ptr);

            for (int i = 0; i < size; i++) {
                views[i] = ptr[i] == IntPtr.Zero ? null : new(ptr[i]);
            }
        }

        public void VSGetSamplers(int startSlot, ComArray<SamplerState> samplers) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 85 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, int, void*, void>)(*(IntPtr*)address);

            int size = Math.Min(samplers.Count, 16 - (int)startSlot);
            IntPtr* ptr = stackalloc IntPtr[size];

            @delegate(_nativePointer, startSlot, size, ptr);

            for (int i = 0; i < size; i++) {
                samplers[i] = ptr[i] == IntPtr.Zero ? null : new(ptr[i]);
            }
        }

        public void OMGetRenderTargets(ComArray<RenderTargetView> views, out DepthStencilView? depthView) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 89 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, void*, void**, void>)(*(IntPtr*)address);

            int size = Math.Min(views.Count, 8);

            IntPtr* ptr = stackalloc IntPtr[size];
            void* pDepthView;

            @delegate(_nativePointer, views.Count, ptr, &pDepthView);

            depthView = pDepthView == null ? null : new(new IntPtr(pDepthView));

            for (int i = 0; i < size; i++) {
                views[i] = ptr[i] == IntPtr.Zero ? null : new(ptr[i]);
            }
        }

        public BlendState? OMGetBlendState(out Vector4 blendFactor, out int sampleMask) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 91 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, void**, Vector4*, int*, void>)(*(IntPtr*)address);

            void* pBlend;
            fixed (Vector4* pBlendFactor = &blendFactor) {
                fixed (int* pSampleMask = &sampleMask) {
                    @delegate(_nativePointer, &pBlend, pBlendFactor, pSampleMask);

                    return pBlend == null ? null : new(new IntPtr(pBlend));
                }
            }
        }

        public DepthStencilState? OMGetDepthStencilState(out int stencilRef) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 92 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, void**, int*, void>)(*(IntPtr*)address);

            fixed (int* pStencilRef = &stencilRef) {
                void* pState;
                @delegate(_nativePointer, &pState, pStencilRef);

                return pState == null ? null : new(new IntPtr(pState));
            }
        }

        public RasterizerState? RSGetState() {
            IntPtr address = (*(IntPtr*)_nativePointer) + 94 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, void**, void>)(*(IntPtr*)address);

            void* pState;
            @delegate(_nativePointer, &pState);

            return pState == null ? null : new(new IntPtr(pState));
        }

        public void RSGetViewports(Span<D3D11_VIEWPORT> viewports, out int numViewports) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 95 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int*, D3D11_VIEWPORT*, void>)(*(IntPtr*)address);

            numViewports = (int)viewports.Length;
            fixed (int* pNumViewports = &numViewports) {
                fixed (D3D11_VIEWPORT* pViewports = viewports) {
                    @delegate(_nativePointer, pNumViewports, pViewports);
                }
            }
        }

        public void RSGetScissorRects(Span<RECT> rects, out int numRects) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 96 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int*, RECT*, void>)(*(IntPtr*)address);

            numRects = (int)rects.Length;
            fixed (int* pNumRects = &numRects) {
                fixed (RECT* pRects = rects) {
                    @delegate(_nativePointer, pNumRects, pRects);
                }
            }
        }

        public void ClearState() {
            IntPtr address = (*(IntPtr*)_nativePointer) + 110 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer);
        }

        public void Flush() {
            IntPtr address = (*(IntPtr*)_nativePointer) + 111 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer);
        }
    }
}

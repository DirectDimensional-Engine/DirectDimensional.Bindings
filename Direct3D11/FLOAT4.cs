using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    public struct FLOAT4 {
        public float A;
        public float B;
        public float C;
        public float D;

        public FLOAT4(float a, float b, float c, float d) {
            A = a; B = b; C = c; D = d;
        }

        public static explicit operator FLOAT4(float[] array) {
            return new FLOAT4(ElementAtOrDefault(array, 0), ElementAtOrDefault(array, 1), ElementAtOrDefault(array, 2), ElementAtOrDefault(array, 3));
        }

        private static float ElementAtOrDefault(float[] array, int index) {
            return index >= 0 && index < array.Length ? array[index] : 0;
        }
    }
}

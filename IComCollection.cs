namespace DirectDimensional.Bindings {
    public interface IComCollection<T> : IList<T?>, IDisposable where T : ComObject? {
        IntPtr NativePointer { get; }
    }
}

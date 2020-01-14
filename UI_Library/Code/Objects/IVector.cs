namespace UI_Library.Code.CrashObject.Properties
{
    interface IVector
    {
        T this[int index] { get; set; }

        Vector<T> add(Vector<T> vector);
        Vector<T> Clone();
        Vector<T> scalarProduct(Vector<T> vector);
        Vector<T> VectorialProduct(Vector<T> vector);
    }
}
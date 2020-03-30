namespace UI_Library.Code.Objects
{
    public interface IVector<T>
    {
        T this[int index] { get; set; }

        Vector<T> add(Vector<T> vector);
        Vector<T> scalarProduct(Vector<T> vector);
    }
}
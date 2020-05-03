namespace IteratorPattern
{
    public interface IIterator<T> where T : class
    {
        bool HasNext();

        T Next();
    }
}

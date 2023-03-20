namespace IteratorPattern.Solution
{
    public interface IIterator<T>
    {
        bool hasNext();
        T Current();
        void Next();
    }
}

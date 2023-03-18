namespace MememtoPattern.BankTransaction
{
    public class TransactionMemento<T>
    {
        private T _state;
        public TransactionMemento(T state)
        {
            _state = state;
        }

        public T GetState()
        {
            return _state;
        }
    }
}

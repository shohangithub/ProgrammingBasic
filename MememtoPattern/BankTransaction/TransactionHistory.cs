namespace MememtoPattern.BankTransaction
{
    public class TransactionHistory<T>
    {
       private List<TransactionMemento<T>> stateList = new ();

        public void push(TransactionMemento<T> transactionMemento)
        {
            stateList.Add(transactionMemento);
        }

        public TransactionMemento<T> pop()
        {
            var lastState = stateList[stateList.Count - 1];
            stateList.Remove(lastState);
            return lastState;
        }
        
    }
}

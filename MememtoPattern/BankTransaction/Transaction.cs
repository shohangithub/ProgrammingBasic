namespace MememtoPattern.BankTransaction
{
    public class Transaction
    {
        private int _balance;
        public Transaction(int openingBalance)
        {
            _balance = openingBalance;
        }
        public TransactionMemento<int> CreateTransaction(int Amount)
        {
            _balance += Amount;
            return new TransactionMemento<int>(Amount);
        }
        public void UndoTransaction(TransactionMemento<int> m)
        {
            _balance -= m.GetState();
        }
        public override string ToString()
        {
            return $"{nameof(_balance)} : {_balance}";
        }
    }
}

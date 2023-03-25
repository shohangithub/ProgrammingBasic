namespace ObserverPattern.PullStyle
{
    public class DataSource : Subject
    {
        private int _value;

        public int GetValue() => _value;
        public void SetValue(int value)
        {
            _value = value;
            NotifyObserver();
        }
    }
}

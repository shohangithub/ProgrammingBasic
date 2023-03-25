namespace ObserverPattern.PushStyle
{
    public class DataSource : Subject
    {
        private int _value;

        public int GetValue() => _value;
        public void SetValue(int value)
        {
            _value = value;
            NotifyObserver(value);
        }
    }
}

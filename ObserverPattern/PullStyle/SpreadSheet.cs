namespace ObserverPattern.PullStyle
{
    public class SpreadSheet : IObserver
    {
        private readonly DataSource _dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Spread sheet got notified !" + _dataSource.GetValue());
        }
    }
}
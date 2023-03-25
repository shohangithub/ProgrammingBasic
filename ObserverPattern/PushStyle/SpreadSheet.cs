namespace ObserverPattern.PushStyle
{
    public class SpreadSheet : IObserver
    {
        public void Update(int v)
        {
            Console.WriteLine("Spread sheet got notified !" + v);
        }
    }
}
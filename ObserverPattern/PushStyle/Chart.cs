namespace ObserverPattern.PushStyle
{
    public class Chart : IObserver
    {
        public void Update(int v)
        {
            Console.WriteLine("Chart got Notified !"+ v);
        }
    }
}
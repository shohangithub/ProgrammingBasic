namespace ObserverPattern.Concept
{
    public class Chart : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Chart got Notified !");
        }
    }
}
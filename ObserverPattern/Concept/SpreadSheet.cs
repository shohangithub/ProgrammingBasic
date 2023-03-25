namespace ObserverPattern.Concept
{
    public class SpreadSheet : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Spread sheet got notified !"); ;
        }
    }
}
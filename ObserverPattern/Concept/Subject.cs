namespace ObserverPattern.Concept
{
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        public void AddObserver(IObserver observer) => observers.Add(observer);
        public void RemoveObserver(IObserver observer) => observers.Remove(observer);
        public void NotifyObserver() { 
         foreach (IObserver observer in observers)observer.Update();
        }
    }
}
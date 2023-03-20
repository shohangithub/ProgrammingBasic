namespace IteratorPattern.Solution
{
    public  class BrowserHistory<T>
    {
        private List<T> urls = new List<T>();

        public void push(T url) => urls.Add(url);
        public T pop()
        {
            var lastUrl = urls[urls.Count - 1];
            urls.Remove(lastUrl);
            return lastUrl;
        }


        public IIterator<T> CreateIterator() => new ListIterator(this);

        public class ListIterator :IIterator<T> 
        {
            private BrowserHistory<T> _history;
            private int index;

            public ListIterator(BrowserHistory<T> history)=> _history = history;

            public T Current()=> _history.urls[index];
            public bool hasNext()=> index < _history.urls.Count;
            public void Next() => index++;
        }
         
    }
}

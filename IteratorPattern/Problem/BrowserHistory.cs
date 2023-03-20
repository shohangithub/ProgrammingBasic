namespace IteratorPattern.Problem
{
    public class BrowserHistory
    {
        private List<string> urls = new List<string>();

        public void push(string url) => urls.Add(url);
        public string pop()
        {
            var lastUrl = urls[urls.Count - 1];
            urls.Remove(lastUrl);
            return lastUrl;
        }
        public List<string> getUrls() => urls;
    }
}

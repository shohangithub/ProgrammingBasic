//using IteratorPattern.Problem;
using IteratorPattern.Solution;

Console.WriteLine("Iterator Pattern");

var history = new BrowserHistory<string>();

history.push("Url 1");
history.push("Url 2");
history.push("Url 3");

Console.WriteLine("Brower history");

IIterator<string> iterator = history.CreateIterator();

while (iterator.hasNext())
{
    var url = iterator.Current();
    Console.WriteLine(url);
    iterator.Next();
}

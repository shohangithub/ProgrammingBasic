namespace StrategyPattern.Solution
{
    public class ContrastFilter : IFilter
    {
        public void Apply(string fileName) => Console.WriteLine("Apply filter using contrast");
    }
}

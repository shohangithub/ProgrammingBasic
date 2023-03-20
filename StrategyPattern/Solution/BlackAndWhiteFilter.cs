namespace StrategyPattern.Solution
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string fileName)=> Console.WriteLine("Using Filter with Black and White");
    }
}

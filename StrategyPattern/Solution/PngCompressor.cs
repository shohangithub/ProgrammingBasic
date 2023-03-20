namespace StrategyPattern.Solution
{
    public class PngCompressor : ICompressor
    {
        public void Compress(string data)
        {
            Console.WriteLine("Compressing using png");
        }
    }
}
namespace StrategyPattern.Solution
{
    public class JpegCompressor : ICompressor
    {
        public void Compress(string data)
        {
            Console.WriteLine("Compressing using jpeg");
        }
    }
}
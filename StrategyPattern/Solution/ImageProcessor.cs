namespace StrategyPattern.Solution
{
    public class ImageProcessor
    {
        public void Process(string fileName, ICompressor compressor, IFilter filter)
        {
            compressor.Compress(fileName);
            filter.Apply(fileName);
        }
    }
}
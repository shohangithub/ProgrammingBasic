namespace StrategyPattern.Problem
{
    public class ImageProcessor
    {
        private string _compressor;
        private string _filter;

        public ImageProcessor(string compressor, string filter)
        {
            _compressor = compressor;
            _filter = filter;
        }


        public void Process(string fileName)
        {
            if(_compressor == "jpeg") Console.WriteLine("Compressing using jpeg");
            else if(_compressor == "png") Console.WriteLine("Compressing using png");

            if(_filter == "b&w") Console.WriteLine("Applying B&W filter");
            else if(_filter == "high-contrast") Console.WriteLine("Applying contrast filter");
        }
    }
}
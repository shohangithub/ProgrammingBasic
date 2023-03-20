// See https://aka.ms/new-console-template for more information
using StrategyPattern.Solution;

Console.WriteLine("########### Strategy Pattern ############");

var processor = new ImageProcessor();

processor.Process("fileName", new PngCompressor(), new BlackAndWhiteFilter());
processor.Process("fileName", new JpegCompressor(), new ContrastFilter());
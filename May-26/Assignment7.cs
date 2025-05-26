/*

7. Abstract Class + Strategy Pattern (Manual)
Task:
Create an abstract class CompressionStrategy with method Compress(string
inputPath, string outputPath) .
Implement ZipCompression , RarCompression .
In a Compressor class, pass the strategy object.
Use polymorphism to switch compression algorithm at runtime.

*/

using System;

public abstract class CompressionStrategy
{
    public abstract void Compress(string inputPath, string outputPath);
}

public class ZipCompression : CompressionStrategy
{
    public override void Compress(string inputPath, string outputPath)
    {
        Console.WriteLine($"Compressing '{inputPath}' to '{outputPath}' using ZIP compression.");
    }
}

public class RarCompression : CompressionStrategy
{
    public override void Compress(string inputPath, string outputPath)
    {
        Console.WriteLine($"Compressing '{inputPath}' to '{outputPath}' using RAR compression.");
    }
}

public class Compressor
{
    private CompressionStrategy _strategy;

    public Compressor(CompressionStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(CompressionStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Compress(string inputPath, string outputPath)
    {
        _strategy.Compress(inputPath, outputPath);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var inputPath = "example.txt";
        var outputPath = "example_compressed";

        var zipStrategy = new ZipCompression();
        var compressor = new Compressor(zipStrategy);
        compressor.Compress(inputPath, outputPath + ".zip");

        var rarStrategy = new RarCompression();
        compressor.SetStrategy(rarStrategy);
        compressor.Compress(inputPath, outputPath + ".rar");
    }
}

/*

Output:

Compressing 'example.txt' to 'example_compressed.zip' using ZIP compression.
Compressing 'example.txt' to 'example_compressed.rar' using RAR compression.

*/
// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        var results = BenchmarkRunner.Run<Demo>();
    }
}
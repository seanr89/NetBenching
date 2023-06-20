using System.Text;
using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Demo
{
    [Benchmark]
    public string GetFullStringDefault()
    {
        string output = "";
        for(int i = 0; i < 100; i++)
        {
            output+=i;
        }
        return output;
    }

    [Benchmark]
    public string GetFullStringWithStringBuilder()
    {
        StringBuilder output = new();

        for(int i = 0; i < 100; i++)
        {
            output.Append(i);
        }
        return output.ToString();
    }
}
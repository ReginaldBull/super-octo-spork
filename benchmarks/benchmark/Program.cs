namespace benchmark
{
    using System.Text;
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Running;
    
    public static class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkArray>();
        }
    }

    [RPlotExporter]
    public class BenchmarkArray
    {
        [Benchmark]
        public static string Run()
        {
            string value = string.Empty;

            for (int index = 0; index < 1000; index++)
            {
                value += index;
            }

            return value;
        }

        [Benchmark]
        public static string RunStringBuilder()
        {
            var value = new StringBuilder();

            for (int index = 0; index < 1000; index++)
            {
                value.Append(index);
            }

            return value.ToString();
        }
    }
}
using System;

namespace calc_
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string expression = args[0];
                Console.WriteLine(AnalyzerClass.Estimate(expression));
            }
        }
    }
}

using System;


namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 0 - exit");
            string expression = "1";
            while (expression != "0")
            {
                Console.Write("Enter expression: ");
                expression = Console.ReadLine();
                if(expression != "0")
                {
                    Console.WriteLine(AnalyzerClass.Estimate(expression));
                }
            }
        }
    }
}

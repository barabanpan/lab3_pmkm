using System;


namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "23 + 96 7 *7";
            //string n = expression.Substring(3, 1);
            //string n1 = "+";
            //if (expression.Substring(3, 1) == "+")
            //{
            //    Console.WriteLine("Uviii");
            //}

            AnalyzerClass.Estimate("(2+1)*6");
            

        }
    }
}

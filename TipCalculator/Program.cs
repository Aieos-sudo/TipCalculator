using System;

namespace TipCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tip Calculator\n");
            Console.Write("Cost of meal: ");
            string cost = Console.ReadLine();
            double doubleCost = Convert.ToDouble(cost);
            Console.WriteLine();
            Console.WriteLine("15%");
            Console.WriteLine("Tip amount: " + Math.Round(doubleCost * .15,2));
            Console.WriteLine("Total amount: " + Math.Round(doubleCost * 1.15,2));
            Console.WriteLine();
            Console.WriteLine("20%");
            Console.WriteLine("Tip amount: " + Math.Round(doubleCost * .20,2));
            Console.WriteLine("Total amount: " + Math.Round(doubleCost * 1.20,2));
            Console.WriteLine();
            Console.WriteLine("25%");
            Console.WriteLine("Tip amount: " + Math.Round(doubleCost * .25,2));
            Console.WriteLine("Total amount " + Math.Round(doubleCost * 1.25,2));
        }


    }
}
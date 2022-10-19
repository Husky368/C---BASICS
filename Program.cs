using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());

            if (statists > 150)
            {
                clothesPrice *= 0.90;
            }
            double decoration = budget * 0.10;
            double clothesPriceTotal = statists * clothesPrice;
            double taxes = decoration + clothesPriceTotal;
            if (budget>=taxes)
            {
                double left = budget - taxes;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {left:f2} leva left.");
            }
            else
            {
                double need = taxes - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {need:f2} leva more.");
            }
        }
    }
}

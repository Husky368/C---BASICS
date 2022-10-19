using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            //•	Пъзел - 2.60 лв.
            //•	Говореща кукла -3 лв.
            //•	Плюшено мече -4.10 лв.
            //•	Миньон - 8.20 лв.
            //•	Камионче - 2 лв.
            double budget = 0;
            int numbers = puzzle + dolls + bears + minions + trucks;
            budget += puzzle * 2.60;
            budget += dolls * 3;
            budget += bears * 4.10;
            budget += minions * 8.20;
            budget += trucks * 2;
            if (numbers>=50 )
            {
                budget *= 0.75;
            }
            budget *= 0.90;
            //o	"Yes! {оставащите пари} lv left."
            if (budget>=tripPrice)
            {
                double left = budget - tripPrice;
                Console.WriteLine($"Yes! {left:f2} lv left.");
            }
            else
            {
                double need = tripPrice - budget;
                Console.WriteLine($"Not enough money! {need:f2} lv needed.");
            }
        }
    }
}

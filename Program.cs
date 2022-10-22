using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double goal = double.Parse(Console.ReadLine());
            double budget = 0;
            double totalb = 0;
            while (true)
            {
                string cocktail = Console.ReadLine();
                if (cocktail == "Party!")
                {
                    if (totalb >= goal)
                    {
                        Console.WriteLine($"Target acquired.");
                    }
                    else if (totalb < goal)
                    {
                        double need = goal - totalb;
                        Console.WriteLine($"We need {need:f2} leva more.");
                    }
                    Console.WriteLine($"Club income - {totalb:f2} leva.");
                    break;
                }
                int numbers = int.Parse(Console.ReadLine());
                int lettersNum = cocktail.Length;
                budget = lettersNum * numbers;
                if (budget % 2 == 1)
                {
                    budget *= 0.75;
                }
                totalb += budget;
                if (totalb>=goal)
                {
                    Console.WriteLine($"Target acquired.");
                    Console.WriteLine($"Club income - {totalb:f2} leva.");
                    break;
                }
            }
        }
    }
}

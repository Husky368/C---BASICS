using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            int daySpend = 0;
            int daysCounter = 0;
            while (daySpend < 5)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;
                if (action == "spend")
                {
                    currentMoney -= money;
                    if (currentMoney < 0)
                    {
                        currentMoney = 0;
                    }
                    daySpend++;
                }
                else if (action == "save")
                {
                    currentMoney += money;
                    if (money < 0)
                    {
                        money = 0;
                    }
                }
                if (trip<=currentMoney)
                {
                    Console.WriteLine($"You saved the money for {daysCounter} days.");
                    break;
                }
            }
            if (daySpend>=5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
        }
    }
}

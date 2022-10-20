using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string opinion = Console.ReadLine();
            days -= 1;
            double cost = 0;

            switch (type)
            {
                case "apartment":
                    if (days < 10)
                    {
                        cost = days * 25;
                        cost *= 0.70;
                        if (opinion=="positive")
                        {
                            cost *= 1.25;
                        }
                        else
                        {
                            cost *= 0.90;
                        }
                        Console.WriteLine($"{cost:f2}");
                        break;
                    }
                    else if (days <= 15)
                    {
                        cost = days * 25;
                        cost *= 0.65;
                        if (opinion == "positive")
                        {
                            cost *= 1.25;
                        }
                        else
                        {
                            cost *= 0.90;
                        }
                        Console.WriteLine($"{cost:f2}");
                        break;
                    }
                    else
                    {
                        cost = days * 25;
                        cost *= 0.50;
                        if (opinion == "positive")
                        {
                            cost *= 1.25;
                        }
                        else
                        {
                            cost *= 0.90;
                        }
                        Console.WriteLine($"{cost:f2}");
                        break;
                    }
                case "room for one person":
                    if (days < 10)
                    {
                        cost = days * 18;
                        if (opinion == "positive")
                        {
                            cost *= 1.25;
                        }
                        else
                        {
                            cost *= 0.90;
                        }
                        Console.WriteLine($"{cost:f2}");
                        break;
                    }
                    else if (days <= 15)
                    {
                        cost = days * 18;
                        if (opinion == "positive")
                        {
                            cost *= 1.25;
                        }
                        else
                        {
                            cost *= 0.90;
                        }
                        Console.WriteLine($"{cost:f2}");
                        break;
                    }
                    else
                    {
                        cost = days * 18;
                        if (opinion == "positive")
                        {
                            cost *= 1.25;
                        }
                        else
                        {
                            cost *= 0.90;
                        }
                        Console.WriteLine($"{cost:f2}");
                        break;
                    }
                case "president apartment":
                    if (days < 10)
                    {
                        cost = days * 35;
                        cost *= 0.90;
                        if (opinion == "positive")
                        {
                            cost *= 1.25;
                        }
                        else
                        {
                            cost *= 0.90;
                        }
                        Console.WriteLine($"{cost:f2}");
                        break;
                    }
                    else if (days <= 15)
                    {
                        cost = days * 35;
                        cost *= 0.85;
                        if (opinion == "positive")
                        {
                            cost *= 1.25;
                        }
                        else
                        {
                            cost *= 0.90;
                        }
                        Console.WriteLine($"{cost:f2}");
                        break;
                    }
                    else
                    {
                        cost = days * 35;
                        cost *= 0.80;
                        if (opinion == "positive")
                        {
                            cost *= 1.25;
                        }
                        else
                        {
                            cost *= 0.90;
                        }
                        Console.WriteLine($"{cost:f2}");
                        break;
                    }
                default:
                    break;
            }
        }
    }
}

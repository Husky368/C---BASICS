using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            double cake = l * w;
            double cakeFirst = cake;
            double addTotal = 0;
            string stop = Console.ReadLine();
            while (stop!="STOP")
            {
                int addCake = int.Parse(stop);
                cake -= addCake;
                addTotal += addCake;
                if (cake < 0)
                {
                    double diff = Math.Abs( cakeFirst - addTotal);

                    Console.WriteLine($"No more cake left! You need {diff} pieces more.");
                    break;
                }
                stop = Console.ReadLine();
            }
            if (stop=="STOP")
            {
                double diff = cakeFirst - addTotal;
                Console.WriteLine($"{diff} pieces are left.");
            }
        }
    }
}

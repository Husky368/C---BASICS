using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double coin = double.Parse(Console.ReadLine());
            int coinCount = 0;
             while (coin>=2)
            {
                coin -= 2;
                coinCount += 1;
                Math.Round(coin, 2 , MidpointRounding.AwayFromZero);
            }
            while (coin >= 1)
            {
                coin -= 1;
                coinCount += 1;
                coin = Math.Round(coin, 2, MidpointRounding.AwayFromZero);
            }
            while (coin >= 0.50)
            {
                coin -= 0.50;
                coinCount += 1;
                coin = Math.Round(coin, 2, MidpointRounding.AwayFromZero);
            }
            while (coin >= 0.20)
            {
                coin -= 0.20;
                coinCount += 1;
                coin = Math.Round(coin, 2, MidpointRounding.AwayFromZero);
            }
            while (coin >= 0.10)
            {
                coin -= 0.10;
                coinCount += 1;
                coin = Math.Round(coin, 2, MidpointRounding.AwayFromZero);
            }
            while (coin >= 0.05)
            {
                coin -= 0.05;
                coinCount += 1;
                coin = Math.Round(coin, 2, MidpointRounding.AwayFromZero);
            }
            while (coin >= 0.02)
            {
                coin -= 0.02;
                coinCount += 1;
                coin = Math.Round(coin, 2, MidpointRounding.AwayFromZero);
            }
            while (coin >= 0.01)
            {
                coin -= 0.01;
                coinCount += 1;
                coin = Math.Round(coin, 2, MidpointRounding.AwayFromZero);
                if (coin<0.01)
                {
                    coin = 0;
                }
            }
            Console.WriteLine(coinCount);
        }
    }
}

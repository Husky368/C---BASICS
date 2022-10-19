using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (points % 2 == 0)
            {
                bonus += 1;
            }
            else if(points % 5 == 5)
            {
                bonus += 2;
            }
            if (points <= 100)
            {
                bonus += 5;
                Console.WriteLine(bonus);
                Console.WriteLine(bonus + points);
            }
            else if (points <= 1000)
            {
                bonus = points * 0.2;
                Console.WriteLine(bonus);
                Console.WriteLine(bonus + points);
            }
            else
            {
                bonus = points * 0.1;
                Console.WriteLine(bonus);
                Console.WriteLine(bonus + points);
            }
        }
    }
}

using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = first + second + third;
            int mins = sum / 60;
            int seconds = sum % 60;

            if (mins<1)
            {
                if (seconds<10)
                {
                    Console.WriteLine($"0:0{seconds:f0}");
                }
                else
                {
                    Console.WriteLine($"0:{seconds:f0}");
                }
            }
            if (mins>=1)
            {
                if (seconds<10)
                {
                    Console.WriteLine($"{mins:f0}:0{seconds:f0}");
                }
                else
                {
                    Console.WriteLine($"{mins:f0}:{seconds:f0}");
                }
            }
        }
    }
}

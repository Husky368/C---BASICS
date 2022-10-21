using System;

namespace average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double times = 0;
            for (int i = 1; i <=  n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                times += 1;
            }
            double avrg = sum / times;
            Console.WriteLine($"{avrg:f2}");
        }
    }
}

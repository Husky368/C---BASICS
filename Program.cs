using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int current = 1;
            int bigger = 0;
            for (int row = 1; row <= num; row++)
            {
                for (int i = 1; i <= row; i++)
                {
                    Console.Write($"{current} ");
                    current++;
                    if (current>num)
                    {
                        bigger++;
                        break;
                    }
                }
                Console.WriteLine();
                if (bigger==1)
                {
                    break;
                }
            }
        }
    }
}

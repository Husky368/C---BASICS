using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    double result = i * j;
                    Console.WriteLine($"{i} * {j} = {result}");
                }
            }
        }
    }
}

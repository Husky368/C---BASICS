using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            int times = 0;
            int valid = 0;
            int done = 0;
            for (int i = start; i <= finish; i++)
            {
                for (int j = start; j <= finish; j++)
                {
                    times++;
                    if (i+j==num)
                    {
                        valid++;
                        Console.WriteLine($"Combination N:{times} ({i} + {j} = {num})");
                        done++;
                        break;
                    }
                }
                if (done == 1)
                {
                    break;
                }
            }
            if (valid == 0)
            {
                Console.WriteLine($"{times} combinations - neither equals {num}");
            }
        }
    }
}

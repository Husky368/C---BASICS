using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int times = 0;
            for (int first = 0; first <= n; first++)
            {
                for (int second = 0; second <= n; second++)
                {
                    for (int third = 0; third <= n; third++)
                    {
                        if (first + second + third == n)
                        {
                            times++;
                        }
                    }
                }
            }
            Console.WriteLine(times);
        }
    }
}

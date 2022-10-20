using System;

namespace Operations_between_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;
            int number = 0;
            for (int i = 1; i <= n; i++)
            {
                number += 1;
                int currentNumber = int.Parse(Console.ReadLine());
                if (number % 2 == 1)
                {
                    odd += currentNumber;
                }
                else if (number % 2 == 0)
                {
                    even += currentNumber;
                }
            }
            int bigger = 0;
            int smaller = 0;
            if (odd < even)
            {
                smaller = odd;
                bigger = even;
            }
            else if (odd > even)
            {
                smaller = even;
                bigger = odd;
            }
            if (odd == even)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + even);
            }
            else if (odd != even)
            {
                int diff = bigger - smaller;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}

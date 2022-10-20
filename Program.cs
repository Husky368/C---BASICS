using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int flat = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            int curruntFlat = flat;
            while (curruntFlat>0)
            {
                if (curruntFlat==flat)
                {
                    for (int i = 0; i < rooms; i++)
                    {
                        Console.Write($"L{curruntFlat}{i} ");
                    }
                    curruntFlat--;
                    Console.WriteLine();
                }
                if (curruntFlat % 2 == 0)
                {
                    for (int i = 0; i < rooms; i++)
                    {
                        Console.Write($"O{curruntFlat}{i} ");
                    }
                    curruntFlat--;
                    Console.WriteLine();
                }
                if (curruntFlat % 2 == 1)
                {
                    for (int i = 0; i < rooms; i++)
                    {
                        Console.Write($"A{curruntFlat}{i} ");
                    }
                    curruntFlat--;
                    Console.WriteLine();
                }
            }
        }
    }
}

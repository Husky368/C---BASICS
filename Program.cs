using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            mins += 15;
            if (mins >= 60)
            {
                mins -= 60;
                hours += 1;
            }
            if (hours >= 24)
            {
                hours = 0;
            }
            if (mins >= 10)
            {
                Console.WriteLine($"{hours}:{mins}");
            }
            else
            {
                Console.WriteLine($"{hours}:0{mins}");
            }
        }
    }
}

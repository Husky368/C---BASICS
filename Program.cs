using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double needness = double.Parse(Console.ReadLine());
                while (true)
                {
                    double money = double.Parse(Console.ReadLine());
                    needness -= money;
                    if (needness<=0)
                    {
                        break;
                    }
                }
                Console.WriteLine($"Going to {destination}!"); 
                destination = Console.ReadLine();
            }
        }
    }
}

using System;

namespace Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	При скорост до 10(включително) отпечатайте "slow"
            //•	При скорост над 10 и до 50(включително) отпечатайте "average"
            //•	При скорост над 50 и до 150(включително) отпечатайте "fast"
            //•	При скорост над 150 и до 1000(включително) отпечатайте "ultra fast"
            //•	При по-висока скорост отпечатайте "extremely fast"
            double a = double.Parse(Console.ReadLine());
            if (a <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (a <= 50)
            {
                Console.WriteLine("average");
            }
            else if (a <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (a <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}

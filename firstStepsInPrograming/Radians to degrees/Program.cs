using System;

namespace Radians_to_degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //градус = радиан * 180 / π. 
            double radians = double.Parse(Console.ReadLine());
            Console.WriteLine(radians*180/Math.PI);
        }
    }
}

using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            //((daysInMonth * capsulesCount) * pricePerCapsule)
            int N = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for (int i = 1; i <= N; i++)
            {
                float pricePerCapsule = float.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());
                float Price = (days * capsuleCount) * pricePerCapsule;
                totalPrice += Price;
                Console.WriteLine($"The price for the coffee is: ${Math.Round(Price, 2, MidpointRounding.AwayFromZero):f2}");
            }
            Console.WriteLine($"Total: ${Math.Round(totalPrice, 2, MidpointRounding.AwayFromZero):f2}");
        }
    }
}

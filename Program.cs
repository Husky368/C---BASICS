using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double swimingOneMeter = double.Parse(Console.ReadLine());

            double swimingTime = meters * swimingOneMeter;
            swimingTime += (meters / 15) * 12.5;
            Math.Floor(swimingTime);
            if (swimingTime <= record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {swimingTime:f2} seconds.");
            }
            else
            {
                double need = swimingTime-record;
                Console.WriteLine($"No, he failed! He was {need:f2} seconds slower.");
            }
        }
    }
}

using System;

namespace Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            double kilos = input * 1000;
            double eaten = 0;
            string adopted = Console.ReadLine();
            while (adopted != "Adopted")
            {
                double grams = double.Parse(adopted);
                eaten += grams;
                adopted = Console.ReadLine();
            }
            if (eaten <= kilos)
            {
                double left = kilos - eaten;
                Console.WriteLine($"Food is enough! Leftovers: {left} grams.");
            }
            else
            {
                double need = eaten - kilos;
                Console.WriteLine($"Food is not enough. You need {need} grams more.");
            }
        }
    }
}

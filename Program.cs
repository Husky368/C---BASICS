using System;

namespace Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSpace = double.Parse(Console.ReadLine());
            double availbleSpace = totalSpace;
            string end = Console.ReadLine();
            int times = 0;
            int inside = 0;
            int nomorespace = 0;
            while (end!="End")
            {
                double suitcase = double.Parse(end);
                times++;
                if (times==3)
                {
                    suitcase *= 1.10;
                    times = 0;
                }
                if (availbleSpace>suitcase)
                {
                    availbleSpace -= suitcase;
                    inside++;
                }
                else
                {
                    Console.WriteLine("No more space!");
                    Console.WriteLine($"Statistic: {inside} suitcases loaded.");
                    nomorespace++;
                    break;
                }
                end = Console.ReadLine();
            }
            if (nomorespace == 0)
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
                Console.WriteLine($"Statistic: {inside} suitcases loaded.");
            }
        }
    }
}

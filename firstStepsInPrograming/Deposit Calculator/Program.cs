using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            double depositAmount = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            percent /= 100;
            double interest = depositAmount * percent;
            double monthInterest = interest / 12;
            double math = depositAmount + (month * monthInterest);
            Console.WriteLine(math);
        }
    }
}

using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string curentBook = Console.ReadLine();
            int num = 0;
            while (curentBook != book)
            {
                curentBook = Console.ReadLine();
                num++;
                if (curentBook==book)
                {
                    Console.WriteLine($"You checked {num} books and found it.");
                    break;
                }
                if (curentBook=="No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {num} books.");
                    break;
                }
            }
        }
    }
}

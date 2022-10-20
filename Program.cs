using System;

namespace Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            switch (city)
            {
                case "Varna":
                    if (sales < 0)
                    {
                        Console.WriteLine("error");
                        break;
                    }
                    if (sales <= 500)
                    {
                        Console.WriteLine($"{(sales * 0.045):f2}");
                    }
                    else if (sales <= 1000)
                    {
                        Console.WriteLine($"{(sales * 0.075):f2}");
                    }
                    else if (sales <= 10000)
                    {
                        Console.WriteLine($"{(sales * 0.10):f2}");
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine($"{(sales * 0.13):f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Sofia":
                    if (sales < 0)
                    {
                        Console.WriteLine("error");
                        break;
                    }
                    if (sales <= 500)
                    {
                        Console.WriteLine($"{(sales * 0.05):f2}");
                    }
                    else if (sales <= 1000)
                    {
                        Console.WriteLine($"{(sales * 0.07):f2}");
                    }
                    else if (sales <= 10000)
                    {
                        Console.WriteLine($"{(sales * 0.08):f2}");
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine($"{(sales * 0.12):f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    //0 ≤ s ≤ 500	500 < s ≤ 1 000	    1 000 < s ≤ 10 000	s > 10 000
                    //  5.5%	            8%	                12%         	14.5%
                    if (sales<0)
                    {
                        Console.WriteLine("error");
                        break;
                    }
                    if (sales <= 500)
                    {
                        Console.WriteLine($"{(sales * 0.055):f2}");
                    }
                    else if (sales <= 1000)
                    {
                        Console.WriteLine($"{(sales * 0.08):f2}");
                    }
                    else if (sales <= 10000)
                    {
                        Console.WriteLine($"{(sales * 0.12):f2}");
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine($"{(sales * 0.145):f2}");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}

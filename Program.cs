using System;

namespace Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string sugar = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());

            //При избрана напитка без захар има 35 % отстъпка.
            //При избрана напитка "Espresso" и закупени поне 5 броя, има 25 % отстъпка.
            //При сума надвишава 15 лева, 20 % отстъпка от крайната цена, 
            double Price = 0;
            switch (product)
            {
                //"You bought {брой напитки} cups of {напитка} for {крайна цена} lv."
                //Без захар        Нормално        Допълнително захар
                //1.00 лв. /бр.     1.20 лв. /бр.        1.60 лв. /бр.
                case "Espresso":
                    if (sugar == "Without")
                    {
                        Price = amount * 0.90;
                        Price *= 0.65;
                        if (amount > 5)
                        {
                            Price *= 0.75;
                        }
                        if (Price>15)
                        {
                            Price *= 0.80;
                        }
                        Console.WriteLine($"You bought {amount} cups of {product} for {Price:f2} lv.");
                        break;
                    }
                    else if (sugar == "Normal")
                    {
                        Price = amount * 1;
                        if (amount>5)
                        {
                            Price *= 0.75;
                        }
                        if (Price>15)
                        {
                            Price *= 0.80;
                        }
                        Console.WriteLine($"You bought {amount} cups of {product} for {Price:f2} lv.");
                        break;

                    }
                    else if (sugar == "Extra")
                    {
                        Price = amount * 1.20;
                        if (amount>5)
                        {
                            Price *= 0.75;
                        }
                        if (Price>15)
                        {
                            Price *= 0.80;
                        }
                        Console.WriteLine($"You bought {amount} cups of {product} for {Price:f2} lv.");
                        break;
                    }
                    break;
                case "Cappuccino":
                    if (sugar == "Without")
                    {
                        Price = amount * 1;
                        Price *= 0.65;                                       
                        if (Price > 15)
                        {
                            Price *= 0.80;
                        }
                        Console.WriteLine($"You bought {amount} cups of {product} for {Price:f2} lv.");
                        break;
                    }
                    else if (sugar == "Normal")
                        {
                            Price = amount * 1.20;
                            if (Price > 15)
                            {
                                Price *= 0.80;
                            }
                            Console.WriteLine($"You bought {amount} cups of {product} for {Price:f2} lv.");
                            break;

                        }
                    else if (sugar == "Extra")
                    {
                        Price = amount * 1.60;
                        if (Price > 15)
                        {
                            Price *= 0.80;
                        }
                        Console.WriteLine($"You bought {amount} cups of {product} for {Price:f2} lv.");
                        break;
                    }
                    break;
                case "Tea":
                    if (sugar == "Without")
                    {
                        Price = amount * 0.50;
                        Price *= 0.65;
                        if (Price > 15)
                        {
                            Price *= 0.80;
                        }
                        Console.WriteLine($"You bought {amount} cups of {product} for {Price:f2} lv.");
                        break;
                    }
                    else if (sugar == "Normal")
                    {
                        Price = amount * 0.60;
                        if (Price > 15)
                        {
                            Price *= 0.80;
                        }
                        Console.WriteLine($"You bought {amount} cups of {product} for {Price:f2} lv.");
                        break;

                    }
                    else if (sugar == "Extra")
                    {
                        Price = amount * 0.70;
                        if (Price > 15)
                        {
                            Price *= 0.80;
                        }
                        Console.WriteLine($"You bought {amount} cups of {product} for {Price:f2} lv.");
                        break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}

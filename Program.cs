using System;

namespace Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int lose = 0;
            int won = 0;
            string gameName = Console.ReadLine();
            string status = Console.ReadLine();
            for (int i = 1; i <= days; i++)
            {
                int wonNum = 0;
                int loseNum = 0;
                if (status=="Win")
                {
                    money += 20;
                    wonNum++;
                }
                else if (status == "lose")
                {
                    loseNum++;
                }
                if (loseNum<wonNum)
                {
                    won++;
                    money *= 1.10;
                }
                if (loseNum>wonNum)
                {
                    lose++;
                }
                gameName = Console.ReadLine();
                if (gameName == "Finish")
                {
                    if ()
                    {

                    }
                }
            }
        }
    }
}

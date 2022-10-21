using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGrades = int.Parse(Console.ReadLine());
            int numNegGrades = 0;
            double sumGrades = 0;
            int exercises = 0;
            string last = "";
            while (numGrades > numNegGrades)
            {
                string currentEx = Console.ReadLine();
                if (currentEx!="Enough")
                {
                    last = currentEx;
                }
                if (currentEx == "Enough")
                {
                    Console.WriteLine($"Average score: {(sumGrades / exercises):f2}");
                    Console.WriteLine($"Number of problems: {exercises}");
                    Console.WriteLine($"Last problem: {last}");
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                sumGrades += grade;
                exercises++;
                if (grade <= 4)
                {
                    numNegGrades++;
                }

            }
            if (numNegGrades >= numGrades)
            {
                Console.WriteLine($"You need a break, {numNegGrades} poor grades.");
            }
        }
    }
}

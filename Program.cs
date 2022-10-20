using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string currentProject;
            double currentGrade = 0;
            int numGrades = 0;
            double gradesSum = 0;
            double currentGradeSum = 0;
            while (input != "Finish")
            {
                currentProject = input;
                for (int i = 1; i <= jury; i++)
                {
                    currentGrade = double.Parse(Console.ReadLine());
                    numGrades++;
                    currentGradeSum += currentGrade;
                    gradesSum += currentGrade;
                }
                double avrg = currentGradeSum / jury;
                Console.WriteLine($"{currentProject} - {avrg:f2}.");
                currentGradeSum = 0;
                input = Console.ReadLine();
            }
            double avrgAll = gradesSum / numGrades;
            Console.WriteLine($"Student's final assessment is {avrgAll:f2}.");
        }
    }
}

using System;

namespace Calculator{
    class Program{
        static int Score_Calculator(){
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            int subjects;
            do
            {
                Console.Write("Enter the number of subjects: ");
            } while (!int.TryParse(Console.ReadLine(), out subjects) || subjects <= 0);

            Dictionary<string, int> subjectScores = new Dictionary<string, int>();
            for (int i = 1; i <= subjects; i++)
            {
                Console.Write($"Enter name of subject {i}: ");
                string subName = Console.ReadLine();
                int subScore;
                do
                {
                    Console.Write($"Enter the score for subject {i}: ");
                } while (!int.TryParse(Console.ReadLine(), out subScore) || subScore < 0 || subScore > 100);

                subjectScores.Add(subName, subScore);
            }

            int totalScore = 0;
            foreach (var score in subjectScores.Values)
            {
                totalScore += score;
            }

            double averageScore = (double)totalScore / subjects;

            Console.WriteLine("\nGrade Summary");
            Console.WriteLine($"Student: {name}");
            Console.WriteLine("Individual subject grades:");
            foreach (var subject in subjectScores)
            {
                Console.WriteLine($"{subject.Key}: {subject.Value}");
            }
            Console.WriteLine($"Average grade: {averageScore:F2}");

            return 0;
        }

        static void Main(string[] args){
            Score_Calculator();
        }
    }

}

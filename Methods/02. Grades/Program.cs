namespace _02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void GradeInWords(double grade)
            {
                if (grade >= 2 && grade < 3)
                {
                    Console.WriteLine("Fail");
                }
                else if (grade >= 3 && grade < 3.5)
                {
                    Console.WriteLine("Average");
                }
                else if (grade >= 3.50 && grade < 4.5)
                {
                    Console.WriteLine("Good");
                }
                else if (grade >= 4.50 && grade < 5.50)
                {
                    Console.WriteLine("Very good");
                }
                else 
                {
                    Console.WriteLine("Excellent");
                }
            }
            double grades = double.Parse(Console.ReadLine());   
            GradeInWords(grades);
        }
    }
}
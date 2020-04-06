using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new DiskBook("Arindam's Grade book");
            book.GradeAdded += OnGradeAdded;
            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The Letter grade is {stats.Letter}");
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or enter 'q' to quit ");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void OnGradeAdded(Object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }
}

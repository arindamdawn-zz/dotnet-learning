using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Arindam's Grade book");
            book.AddGrade(23.33);
            book.AddGrade(73.45);

            book.ShowStatistics();
        }
    }
}

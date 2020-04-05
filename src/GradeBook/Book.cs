using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var sum = 0.0;
            var highestGrade = double.MinValue;
            var lowestGrade = double.MaxValue;

            foreach (double grade in grades)
            {
                sum += grade;
                highestGrade = Math.Max(grade, highestGrade);
                lowestGrade = Math.Min(grade, lowestGrade);
            }

            Console.WriteLine($"The highest grade is {highestGrade}");
            Console.WriteLine($"The lowest grade is {lowestGrade}");
            Console.WriteLine($"The average grade is {sum/grades.Count}");

            

        }

        private List<double> grades;
        private string name;
    }
}
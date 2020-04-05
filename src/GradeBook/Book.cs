using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            if (grade > 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}!");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            var sum = 0.0;

            foreach (double grade in grades)
            {
                sum += grade;
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
            }

            result.Average = sum / grades.Count;

            switch (result.Average)
            {
                case var d when d >= 90:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;

            }
            return result;
        }

        public int Count
        {
            get
            {
                return grades.Count;
            }
        }
        public string Name
        {
            get;set;
        }
        private List<double> grades;
        private string name;
    }
}
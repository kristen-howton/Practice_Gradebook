using System;
using System.Collections.Generic;
using System.Linq;

namespace Gradebook
{

    //class is a blueprint
    class Book

    {

        //contructor must have same nane as class
        //public Book is an access modifier
        private string _name;
        public Book(string name)
        {
            _name = name;
        }
        public void AddGrade(double grade)
        {

        }

        public void ShowStatistics()

        {
            List<double> grades = new List<double>() { 1.4, 2.4, 3, 4 };
            grades.Add(5);

            double highGrade = double.MinValue;
            double lowGrade = double.MaxValue;
            double average = grades.Average();

            foreach (double grade in grades)
            {
                lowGrade = Math.Min(grade, lowGrade);
                highGrade = Math.Max(grade, highGrade);

            }
            Console.WriteLine($"This is the highest grade {highGrade}");
            Console.WriteLine($"This is the lowest grade {lowGrade}");
            Console.WriteLine($"The average grade is {average:N1}");

        }
    }
}
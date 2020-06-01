using System;
using System.Collections.Generic;
using System.Linq;

namespace Gradebook
{

    //class is a blueprint
    class Book

    {
        private string _name;

        //contructor must have same nane as class
        //public Book is an access modifier
        public Book(string name)
        {
            _name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()

        {

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

        private List<double> grades;
        private string name;
    }
}
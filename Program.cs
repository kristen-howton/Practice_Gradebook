using System;
using System.Collections.Generic;
using System.Linq;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>() { 1.4, 2.4, 3, 4 };
            grades.Add(5);

            double average = grades.Average();
            Console.WriteLine($"The average grade is {average:N1}");

            foreach (double grade in grades)
            {
                Console.WriteLine(grade);
            }

        }
    }
}
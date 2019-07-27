using System;
using System.Collections.Generic;


namespace Gradebook 
{
    class Book
    {

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade (double grade)
        {

            grades.Add(grade);
        }

        public void ShowStats()
        {
            
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (double number in grades)
            {

                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }
            //to calculate an average
            result = result/grades.Count;
            //formatting decimals
            System.Console.WriteLine($"Hello, the average is {result:N2}");
             System.Console.WriteLine($"The lowest grade is {lowGrade}");
             System.Console.WriteLine($"The highest grade is {highGrade}");

        }

        private List <double> grades;
        private string name;
    }
}



//declaring a var that is avail across an entire app
//field definition
// List<double> grades;

using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        //what is static?
        //associated with the type that they are defined inside of.
                
        {

            /*
                infinite loop
                var p = new Program ();
                Program.Main(args);
            
             */

            var book = new Book("Canadian cranes");
            book.AddGrade(90.06);
            book.AddGrade(28.03);
            book.AddGrade(90.50);

            var grades = new List <double>()  {5, 20, 30, 40};
            grades.Add(10);
            
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (double number in grades)
            {
                // if ( number < highGrade)
                // {
                //     highGrade = number;
                // }
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
    }
}

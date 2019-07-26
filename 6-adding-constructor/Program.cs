using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
                static void Main(string[] args)
        {
           
            var book = new Book();

            var grades = new List <double>()  {12, 23.4, 21.11, 233, 900};
            grades.Add(10);
            
            var result = 0.0;
            foreach (double number in grades)
            {
                result += number;
            }
            //to calculate an average
            result = result/grades.Count;
            //formatting decimals
            System.Console.WriteLine($"Hello, the average is {result:N2}");

          
        }
    }
}

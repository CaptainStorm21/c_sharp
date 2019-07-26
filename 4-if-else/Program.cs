using System;
using System.Collections.Generic;
namespace gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var numbers = new double [] {12, 23.4, 21.11, 233, 900};
            var grades = new List <double>()  {12, 23.4, 21.11, 233, 900};
            grades.Add(90010000);
            

            var result = 0.0;
            foreach (double number in grades)
            {
                result += number;
            }
            //to calculate an average
            result = result/grades.Count;
            System.Console.WriteLine($"Hello, the average is {result}");

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello from {args[0]}");
            }
            else
            {
                Console.WriteLine("Hello! This is invalid");
            }
        }
    }
}

//if in prompt no name is entered, the output will be else statement
//if a name was entered, you will see Hello from name

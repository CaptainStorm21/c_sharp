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
            grades.Add(5000);
            

            var result = 0.0;
            foreach (double number in grades)
            {
                result += number;
            }
            //to calculate an average
            result = result/grades.Count;
            //formatting decimals
            System.Console.WriteLine($"Hello, the average is {result:N2}");

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

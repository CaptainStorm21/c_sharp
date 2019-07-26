using System.Collections.Generic;


namespace Gradebook 
{
    class Book
    {

        public Book()
        {
            grades = new List<double>();
        }
        public void AddGrade (double grade)
        {

            grades.Add(grade);
        }

        List <double> grades;
    }
}



//declaring a var that is avail across an entire app
//field definition
// List<double> grades;

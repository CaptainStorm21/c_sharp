using System.Collections.Generic;


namespace Gradebook 
{
    class Book
    {

        public Book(string name)
        {
            grades = new List<double>();
            //field name on left hand side
            //parameter name on right hand side;
            //this is an implicit variable that is always avail inside of the methods
            //and inside of constructor. you always use it when you want to refer to the object that is currently
            //being operated on. 
            this.name = name;
        }
        public void AddGrade (double grade)
        {

            grades.Add(grade);
        }

        private List <double> grades;
        private string name;
    }
}



//declaring a var that is avail across an entire app
//field definition
// List<double> grades;

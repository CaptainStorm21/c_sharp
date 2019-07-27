using System; 
using System.Collections.Generic; 

namespace Gradebook {
    class Program {
        static void Main(string[] args) {

            var book = new Book("Canadian cranes"); 
            book.AddGrade(1.06); 
            book.AddGrade(28.03); 
            book.AddGrade(90.50); 
            book.ShowStats(); 


          
        }
    }
}

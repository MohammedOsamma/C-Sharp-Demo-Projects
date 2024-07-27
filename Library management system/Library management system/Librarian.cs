using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class Librarian : User
    {

        public Librarian(string name ) {
            Name = name;        
        }
      public int EmployeeNumber { get; set; }


        public void AddBook(Book newBook ,Library library)
        {
            //add LogiC LATER

            library.Add(newBook);
        }
        public void RemoveBook(Book book ,Library library)
        {
            //add LogiC LATER

            library.Remove(book);
        }
    }
}

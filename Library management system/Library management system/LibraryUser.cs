using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class LibraryUser : User
    {
        public LibraryUser(string name)
        {
            Name = name;
        }
        public LibraryCard Card { get; set; }
       
        public void BorrowedBook(Book book ,Library library)
        {
            //add logic later
            library.Borrwored(book ,library);


        }
    }
}

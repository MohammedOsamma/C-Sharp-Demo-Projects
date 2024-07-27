using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class Library
    {
        private Book[] books = new Book[100];//maximum capcity
        private int currentBookCount =0;

        private Book[] BorrworedBooks = new Book[500];
        private int currentBorrwedBookCount =0;


        public void Display() { 
       
        for (int i = 0;i <currentBookCount;i++)
            {
                Console.WriteLine($"{i+1} - {books[i].Title}");
                Console.WriteLine($"{"  "}- {books[i].Author}");
                Console.WriteLine($"{"  "}- {books[i].Year}");
                Console.WriteLine("======");
            }
        }
        public void Add(Book book) { 
            if (currentBookCount< books.Length)
            {
                books[currentBookCount] = book;
                currentBookCount++;
                Console.WriteLine("Book added successfully ");

            }
            else
            {
                Console.WriteLine("The labrary is full ");
            }
        }
        public void Remove(Book book) {
        int index = Array.IndexOf(books, book);
            books[index] = null;
            currentBookCount--;

            Console.WriteLine("Book removed ");

        }

        public void Borrwored(Book book ,Library library)
        {
            if (currentBorrwedBookCount < BorrworedBooks.Length)
            {
                books[currentBorrwedBookCount] = book;
                currentBorrwedBookCount++;
                Console.WriteLine("Book borrowed successfully ");

            }
            else
            {
                Console.WriteLine("Sorry can't borrow any book ");
            }
        }
    }
}

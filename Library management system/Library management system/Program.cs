namespace Library_management_system
{


    /*
    USER STORIES

    1.As a user I want to have a library card so that I can borrow books from the library
    2.As a librarian I want to new books to the library's collection so that they can be available for borrowing.
    3.As a librarian I want to remove books from the library's collection so that we can keep the collection up-to-date.
    4.As a librarian I want to display a list of all the books in the library's collection sothat users can easily find books they are interested in.

     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Library system");

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
            //make library object to keep track in system
            Library library = new Library();

                Console.Write("Are you librarian or regulaer user (L /R ): ?");
                var userType = Console.ReadLine().ToUpper()[0];




            if (userType == 'L')
            {
                // librarian logic 

                Console.WriteLine($"Welcome Enter Your Name :");
                var librarianName = Console.ReadLine();
                Librarian l1 = new Librarian(librarianName);
                Console.WriteLine($"Welcome {l1.Name}");
                while (true)
                {
                    Console.WriteLine("__________________________________");
                    Console.Write("Please choice to add Book (A) /Remove book (R) /Display (D) /Exit (E): ");
                    char choice = Console.ReadLine().ToUpper()[0];

                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("Enter book details to add  ==> Name , Author , Year : ");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = int.Parse(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            l1.AddBook(book, library);
                            break;

                        case 'R':
                            Console.WriteLine("Enter book details to remove  ==> Name , Author , Year : ");
                            bookName = Console.ReadLine();
                            bookAuthor = Console.ReadLine();
                            bookYear = int.Parse(Console.ReadLine());
                            book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            l1.RemoveBook(book, library);
                            break;
                        case 'D':
                            Console.WriteLine("The book list");
                            l1.DisplayBooks(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }



                }
            }
            else if (userType == 'R')
            {
                //user Logic

                Console.WriteLine($"Welcome ,user Enter Your Name :");
                var userName = Console.ReadLine();
                LibraryUser u1 = new LibraryUser(userName);
                Console.WriteLine($"Welcome {u1.Name}");



                while (true)
                {
                    Console.WriteLine("__________________________________");
                    Console.Write("Please choice to Display (D)/Borrow Book (B)/Exit (E): ");
                    char choice = Console.ReadLine().ToUpper()[0];

                    switch (choice)
                    {
                        
                        case 'D':
                            Console.WriteLine("The book list");
                            u1.DisplayBooks(library);
                            break;

                        case 'B':
                            Console.WriteLine("Enter book details to Borrowe ==> Name , Author , Year : ");
                          string   bookName = Console.ReadLine();
                           string bookAuthor = Console.ReadLine();
                           int  bookYear = int.Parse(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            u1.BorrowedBook(book, library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }



                }




            }
            else
            {
                Console.WriteLine("Please enter correct value (L or R ) :");
            }
            }
        }
    
}

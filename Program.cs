// Purpose: Main program file for the Module 5 Challenge.

using System; // Importing the System namespace for console operations

// Main program class
class Program
{
    // Entry point of the program
    static void Main(string[] args)
    {
        // Creating a library object with the name "Central Library"
        Library library = new Library("Central Library");

        // Creating two member objects with names and IDs
        Member member1 = new Member("Alice", 1);
        Member member2 = new Member("Bob", 2);

        // Adding books to the library collection
        library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780446310789"));
        library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

        // Displaying the list of available books before borrowing
        library.DisplayAvailableBooks();

        Console.WriteLine("\nBorrowing books:"); // Informational message

        // Members borrowing books by ISBN
        member1.BorrowBook(library, "9780743273565"); // Alice borrows "The Great Gatsby"
        member2.BorrowBook(library, "9780446310789"); // Bob borrows "To Kill a Mockingbird"

        // Displaying available books after members have borrowed some
        library.DisplayAvailableBooks();

        // Displaying books currently borrowed by each member
        member1.DisplayBorrowedBooks();
        member2.DisplayBorrowedBooks();

        Console.WriteLine("\nReturning a book:"); // Informational message

        // Alice returns "The Great Gatsby" to the library
        member1.ReturnBook(library, "9780743273565");

        // Displaying the final list of available books after return
        library.DisplayAvailableBooks();
    }
}

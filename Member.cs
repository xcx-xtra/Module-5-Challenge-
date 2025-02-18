// Purpose: Class representing a library member.

using System;
using System.Collections.Generic;
using System.Linq;

// Class representing a library member
public class Member
{
    // Public properties for member's name and ID
    public string Name { get; set; }
    public int ID { get; set; }

    // Private list to store books borrowed by the member
    private List<Book> BorrowedBooks { get; set; }

    // Constructor to initialize member details and borrowed books list
    public Member(string name, int id)
    {
        Name = name;       // Set member name
        ID = id;           // Set member ID
        BorrowedBooks = new List<Book>(); // Initialize empty borrowed books list
    }

    // Method to borrow a book from the library
    public void BorrowBook(Library library, string isbn)
    {
        // Retrieve the book from the library by ISBN
        Book book = library.GetBook(isbn);
        
        // Check if the book is available
        if (book != null)
        {
            BorrowedBooks.Add(book);      // Add the book to borrowed books list
            library.RemoveBook(isbn);     // Remove the book from the library
            Console.WriteLine($"{Name} borrowed: {book}"); // Display message
        }
        else
        {
            Console.WriteLine("Book not available."); // Book not found message
        }
    }

    // Method to return a book to the library
    public void ReturnBook(Library library, string isbn)
    {
        // Find the borrowed book by ISBN
        Book book = BorrowedBooks.FirstOrDefault(b => b.ISBN == isbn);
        
        // Check if the book is found in borrowed list
        if (book != null)
        {
            BorrowedBooks.Remove(book);   // Remove the book from borrowed list
            library.AddBook(book);        // Add the book back to the library
            Console.WriteLine($"{Name} returned: {book}"); // Display return message
        }
        else
        {
            Console.WriteLine("Book not found in borrowed list."); // Not found message
        }
    }

    // Method to display all borrowed books
    public void DisplayBorrowedBooks()
    {
        Console.WriteLine($"{Name}'s Borrowed Books:"); // Header
        
        // Loop through and display each borrowed book
        foreach (var book in BorrowedBooks)
        {
            Console.WriteLine(book);
        }
    }
}

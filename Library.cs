// Purpose: Defines a class to manage a library of books.

using System;                          // Importing system utilities (Console, etc.)
using System.Collections.Generic;      // Importing generic collections (List, etc.)
using System.Linq;                     // Importing LINQ for querying collections

// Defines a public class named 'Library' to manage book collections
public class Library
{
    // Public property for the library name with automatic getter and setter
    public string Name { get; set; }

    // Private list to store books in the library
    private List<Book> Books { get; set; }

    // Constructor to initialize the library with a name and an empty book list
    public Library(string name)
    {
        Name = name;
        Books = new List<Book>();
    }

    // Method to add a book to the library
    public void AddBook(Book book)
    {
        Books.Add(book);  // Adds the book to the list
        Console.WriteLine($"Added: {book}");  // Prints confirmation
    }

    // Method to remove a book from the library using its ISBN
    public bool RemoveBook(string isbn)
    {
        // Finds the book with the specified ISBN or returns null if not found
        Book bookToRemove = Books.FirstOrDefault(b => b.ISBN == isbn);
        
        if (bookToRemove != null) // If book is found
        {
            Books.Remove(bookToRemove);  // Removes the book from the list
            Console.WriteLine($"Removed: {bookToRemove}");  // Prints confirmation
            return true;  // Returns true indicating successful removal
        }

        // Prints message if book not found and returns false
        Console.WriteLine("Book not found.");
        return false;
    }

    // Method to display all available books in the library
    public void DisplayAvailableBooks()
    {
        Console.WriteLine("Available Books:");
        foreach (var book in Books)  // Loops through all books in the list
        {
            Console.WriteLine(book);  // Prints each book
        }
    }

    // Method to search for a book using its ISBN
    public Book GetBook(string isbn)
    {
        // Returns the first book with the matching ISBN or null if not found
        return Books.FirstOrDefault(b => b.ISBN == isbn);
    }
}

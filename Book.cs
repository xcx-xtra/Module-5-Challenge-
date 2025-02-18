
// Defines a class named 'Book' to represent book information
public class Book
{
    // Public properties with automatic getters and setters for book details
    public string Title { get; set; }  // Holds the title of the book
    public string Author { get; set; } // Holds the author's name
    public string ISBN { get; set; }   // Holds the ISBN number

    // Constructor to initialize a new Book object with title, author, and ISBN
    public Book(string title, string author, string isbn)
    {
        Title = title;   // Assigns the passed title to the 'Title' property
        Author = author; // Assigns the passed author to the 'Author' property
        ISBN = isbn;     // Assigns the passed ISBN to the 'ISBN' property
    }

    // Overrides the default ToString() method to provide a custom string representation
    public override string ToString()
    {
        // Returns a formatted string containing book details
        return $"{Title} by {Author} (ISBN: {ISBN})";
    }
}

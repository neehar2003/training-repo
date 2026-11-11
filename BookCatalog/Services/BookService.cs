using BookCatalog.Models;

namespace BookCatalog.Services;

public class BookService : IBookService         //class implements the interface
{
    private readonly List<Book> books = SeedBooks();

    private static List<Book> SeedBooks()

    {
        return new List<Book>                                //seeding 3 books
        {
            new Book{Id = 1, Title = "Wings of Fire", Author ="Abdul Kalam", CopiesAvailable = 3 },
            new Book{Id = 2, Title = "Harry Potter Deathly Hallows", Author ="JK Rowling",CopiesAvailable = 4 },
            new Book{Id = 3, Title = "Atomic Habits", Author ="James Clear", CopiesAvailable = 7},
        };
    }

    public List<Book> GetAll(string? author)            //handles both GET /books and GET /books?author=
    {
        if (string.IsNullOrWhiteSpace(author))
            return books.ToList();
        //Where(b => condition) is a LINQ, keeps only items for which conditions is true
        //string.Equals(author,b.Author, OrdinalIgnoreCase) compares ignoring lower& upper cases
        //Eg: jk rowling matches JK Rowling
        //author with no match returns an empty list
        return books.Where(b => string.Equals(author,b.Author,StringComparison.OrdinalIgnoreCase)).ToList();
        
    }

    public Book? GetById(int id)
    {
        //returns first book matching the condition, or default value when none matches
        return books.FirstOrDefault(b => b.Id == id);
    }
    public Book? Add(Book book)
    {
        var exists = books.Any(b => b.Title == book.Title);
        if (exists)
            return null;
        //ternary operator , Any() asks does the list have atleast 1 book
        //if yes new id = highest id + 1
        //if no id = 1 
        book.Id = books.Any()? books.Max(b => b.Id) + 1 : 1;
        //adds book and return it, returned object now has its id
        books.Add(book);
        return book;
    }
    public bool Delete(int id)
    {
        //FirstOrDefault() searches books for first book whose Id matches
        //if none matches, it returns null
        var book = books.FirstOrDefault(b => b.Id == id);
        //if book is null, returns false
        if (book == null)
            return false;
        //if book found, books.Remove(book) takes exact object out of the list
        books.Remove(book);
        //report success, returns true
        return true;
    }
   
}
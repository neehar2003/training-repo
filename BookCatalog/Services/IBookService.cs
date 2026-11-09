using BookCatalog.Models;

namespace BookCatalog.Services;

public interface IBookService
{
    List<Book> GetAll(string? author);    //return all books, nullable author makes filter optional
    Book? GetById(int id);                //return book with given id, return null if not exists.

    //returnType Name(parameterType parameterName)
    Book Add(Book book);                  //adds a new book returns with generated id

    bool Delete(int id);                  //deletes book with given id, returns true if deleted, false if no book had that id.
}
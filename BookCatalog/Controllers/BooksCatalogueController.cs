using BookCatalog.Models;
using BookCatalog.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookCatalog.Controllers;

[ApiController]            //returns bad request if breaks required or range rules 
[Route("api/v1/books")]
public class BooksCatalogueController : ControllerBase          
{
    private readonly IBookService _bookService;         //constructor injection

    public BooksCatalogueController(IBookService bookService)        //type is interface, so controllers doesnt know about BookService
    {
        _bookService = bookService;
    }

    [HttpGet]
    //ActionResult<List<Book>> means a list of books or any HTTP result
    //Ok(books) return data with status code 200
    public ActionResult<List<Book>> GetAll([FromQuery] string? author)
    {
        var books = _bookService.GetAll(author);
        return Ok(books);
    }

    [HttpGet("{id:int}")]           //{id:int} means {routeParameter : routeConstraint},  helps swagger treats field as number
    //if service return null, controller returns 404 not found, otherwise return 200 with the book
    public ActionResult<Book> GetById(int id)
    {
        var book = _bookService.GetById(id);
        if (book == null)
            return NotFound();

        return Ok(book);
    }

    [HttpPost]              //handles POST requests to /books
    public ActionResult<Book> Add(Book book)
    {
        var created = _bookService.Add(book);
        //CreatedAtAction returns 201 created
        //its arguments are actions that can get the new resource, route values for it , and the body
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpDelete("{id:int}")]
    //no body to send , only status, so use IActionResult
    //earlier used ActionResult because it returns a body
    public IActionResult Delete(int id)     //no body to send , only status, so use IActionResult
    {
        var deleted = _bookService.Delete(id);
        //not deleted , return 404
        if(!deleted)
            return NotFound();
        //no content, return 204
        return NoContent();
    }
}
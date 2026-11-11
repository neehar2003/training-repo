using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Models;

public class Book
{
    public int Id { get; set; }
    [Required] 
    public required string Title { get; set; }          //title is required field
    public string? Author { get; set; }

    [Range(0,int.MaxValue)]
    public int CopiesAvailable { get; set;}             //range given here so that it cannot be negative, 0 is the minimum
}
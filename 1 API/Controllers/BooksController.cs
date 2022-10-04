using _1_API.Data.Models;
using _1_API.Data.Services;
using _1_API.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BookServices _bookServices;
        public BooksController(BookServices bookServices)
        {
            _bookServices = bookServices;
        }



        [HttpPost("add-book")]
        public IActionResult AddBooks(BookVM book)
        {
            _bookServices.AddBooksWithAuthor(book);
            return Ok();
        }

        [HttpGet("get-all-books")]
        public IActionResult GetBooks()
        {
            var books = _bookServices.GetBooks();   
            return Ok(books);   
        }

        [HttpGet("get-book-by-id/(id)")]

        public IActionResult GetBookById1(int id)
        {
            var bookid = _bookServices.GetBookById1(id);
            return Ok(bookid);  
                
        }
  

        [HttpPut("update-book-by-id/(id)")]

        public IActionResult UpdateBooks(int id, [FromBody] BookVM book)
        {
            var bookupted = _bookServices.UpdateBooks(id, book);
            return Ok(bookupted);

        }



        [HttpDelete("delete-book-by-id/(id)")]
        public IActionResult Deleting(int id)
        {
            _bookServices.Deleting(id);
            return Ok();
        }
}  }

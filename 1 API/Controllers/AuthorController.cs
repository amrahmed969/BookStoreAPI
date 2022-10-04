using _1_API.Data.Services;
using _1_API.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        public AuthorServices _AuthorServices;
        public AuthorController(AuthorServices authorServices)
        {
            _AuthorServices = authorServices;
        }
        [HttpPost("addauthor")]  
        
        public IActionResult AddAuthor([FromBody] AuthorVM author)
        {
            _AuthorServices.AddAuther(author);
            return Ok();
        }

        [HttpGet("get-autor-book-by-id/{id}")]
        public IActionResult GetAuthorwithBook(int id)
        {
            var result = _AuthorServices.GetAutrorwithBookVM(id);
            return Ok(result);
        }


    }
}

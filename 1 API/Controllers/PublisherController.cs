using _1_API.Data.Services;
using _1_API.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        public PublisherServices _PublisherServices;
        public PublisherController(PublisherServices publisherServices)
        {
            _PublisherServices = publisherServices;
        }
        [HttpPost("addpublisher")]

        public IActionResult AddPublisher([FromBody] PublisherVM author)
        {
            _PublisherServices.AddPublisher(author);
            return Ok();
        }

        [HttpGet("get-publisher-book-with-author-by-id/{id}")]
        public IActionResult GetPublisherdata(int id)
        {
            var result =_PublisherServices.GetpublisherData(id);
            return Ok(result);
        }


        [HttpDelete("delete-publisher-by-id/{id}")]

        public IActionResult DeletePublisherById(int id)
        {
            _PublisherServices.DeletePublisherById(id);
            return Ok();

        }


    }
}

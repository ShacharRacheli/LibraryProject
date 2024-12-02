using Library.Core.Interface;
using Library.Core.Models;
using Library.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Books> Get()
        {
            return _bookService.GetAll();
        }
        [HttpGet("GetByCode")]
        public ActionResult Get([FromQuery] int code)
        {
            //Books book = _bookService.GetByCode(code);
            if (_bookService.GetByCode(code))
                return Ok();///?????
            return NotFound();
        }
        // GET api/<BooksController>/5
        [HttpGet("ByCategory")]
        //  [HttpGet("{category}/{code}/{isBorrowed}")]
        public IEnumerable<Books> Get([FromQuery] ECategories category)
        {
            return _bookService.GetByCategory(category);
        }


        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] Books book)
        {
            _bookService.PostBook(book);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Books book)
        {
            _bookService.PutBook(id, book);           
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _bookService.DeleteBook(id);
        }
    }
}

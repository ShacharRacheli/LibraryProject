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
        public ActionResult Get()
        {
            List<Books>books= _bookService.GetAll();
            if(books.Any())
                return Ok(books);
            return NotFound("The list of books is empty");
        }
        [HttpGet("GetByCode")]
        public ActionResult Get([FromQuery] int code)
        {
            var book = _bookService.GetByCode(code);
            if (book == null)
                return NotFound();
            return Ok(book);
        }
        // GET api/<BooksController>/5
        [HttpGet("ByCategory")]
        //  [HttpGet("{category}/{code}/{isBorrowed}")]
        public ActionResult<List<Books>> Get([FromQuery] ECategories category)
        {          
            List<Books> books = _bookService.GetByCategory(category);
            
            if (books.Any())
                return Ok(books);
            
            return NotFound("The list of books is empty");
        }


        // POST api/<BooksController>
        [HttpPost]
        public ActionResult Post([FromBody] Books book)
        {
           if(_bookService.PostBook(book))
                return Ok(book);
           return NotFound("The object was null");
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Books book)
        {
            if(_bookService.PutBook(id, book))
                return Ok();
            return NotFound("There is no such a book to update");
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if(_bookService.DeleteBook(id))
                return Ok();
            return NotFound("There is no such a book to delete");
        }
    }
}

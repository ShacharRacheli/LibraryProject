using Library.Core.Interface;
using Library.Core.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BooksController : ControllerBase
    {
        private readonly IDataContext _context;

        public BooksController(IDataContext dataContext)
        {
            _context = dataContext;
        }

        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Books> Get()
        {
            return _context.BookList;
        }
        [HttpGet("GetByCode")]
        public ActionResult Get([FromQuery] int code)
        {
            Books book = _context.BookList.FirstOrDefault(book => book.Code == code);
            if (book != null)
                return Ok(book);
            return NotFound();
        }
        // GET api/<BooksController>/5
        [HttpGet("ByCategory")]
        //  [HttpGet("{category}/{code}/{isBorrowed}")]
        public IEnumerable<Books> Get([FromQuery] ECategories category)
        {
            return _context.BookList.Where(book => book.Category == category).ToList();
        }


        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] Books book)
        {
            _context.BookList.Add(book);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Books book)
        {
            Books temp = _context.BookList.FirstOrDefault(book => book.Code == id);
            if (temp != null)
            {
                temp.Author = book.Author;
                temp.Name = book.Name;
                temp.Category = book.Category;
                temp.IsBorrowed = book.IsBorrowed;
                temp.DateOfPurchase = book.DateOfPurchase;
            }
            //Data.BookList.FirstOrDefault(book => book.Code == id).Author = book.Author;
            //Data.BookList.FirstOrDefault(book => book.Code == id).Name = book.Name;
            //Data.BookList.FirstOrDefault(book => book.Code == id).Category = book.Category;
            //Data.BookList.FirstOrDefault(book => book.Code == id).IsBorrowed = book.IsBorrowed;
            //Data.BookList.FirstOrDefault(book => book.Code == id).DateOfPurchase = book.DateOfPurchase;
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Books b = _context.BookList.FirstOrDefault(book => book.Code == id);
            if (b != null)
                _context.BookList.Remove(b);
        }
    }
}

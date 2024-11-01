using Microsoft.AspNetCore.Mvc;
using WebApplication1.module;
using WebApplication1.Helper;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BooksController : ControllerBase
    {
        public BooksController()
        { 
        }

        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Books> Get()
        {
            return Data.BookList;
        }
        [HttpGet("GetByCode")]
        public IActionResult Get([FromQuery] int code)
        {
            Books book = Data.BookList.FirstOrDefault(book => book.Code == code);
            if (book != null)
                return Ok(book);
            return NotFound();
        }
        // GET api/<BooksController>/5
        [HttpGet("ByCategory")]
        //  [HttpGet("{category}/{code}/{isBorrowed}")]
        public IEnumerable<Books> Get([FromQuery] ECategories category)
        {
            return Data.BookList.Where(book=>book.Category==category).ToList();
        }
        

        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] Books book)
        {
            Data.BookList.Add(book);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Books book)
        {
            Books temp = Data.BookList.FirstOrDefault(book => book.Code == id);
            if (temp != null)
            {
                temp.Author=book.Author;
                temp.Name=book.Name;
                temp.Category=book.Category;
                temp.IsBorrowed=book.IsBorrowed;
                temp.DateOfPurchase=book.DateOfPurchase;
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
            Books b = Data.BookList.FirstOrDefault(book => book.Code == id);
            if (b != null)
                Data.BookList.Remove(b);         
        }
    }
}

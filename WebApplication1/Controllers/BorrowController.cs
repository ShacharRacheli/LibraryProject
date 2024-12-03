using Library.Core.Models;
using Library.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowController : ControllerBase
    {
        private readonly IBorrowService _borrowService;

        public BorrowController(IBorrowService borrowService)
        {
            _borrowService = borrowService;
        }


        // GET: api/<BorrowController>
        [HttpGet]
        public ActionResult Get()
        {
            List<Borrow> borrowList = _borrowService.GetAll();
            if (borrowList.Any())
                return Ok(borrowList);
            return NotFound();
        }
        // GET api/<BorrowController>/5
        [HttpGet("ListOfBorrowsByBookCode")]
        public ActionResult Get([FromQuery] int code)
        {
            List<Borrow> borrows = _borrowService.SGetBorrowsByBookCode(code);
            if (borrows.Any())
                return Ok(borrows);
            return NotFound();
        }
        [HttpGet("SameSubscriber")]
        public ActionResult Get([FromQuery] string id)
        {
            List<Borrow> borrows = _borrowService.SGetBorrowsSameSubscriber(id);
            if (borrows.Any())
                return Ok(borrows);
            return NotFound();
        }
        // POST api/<BorrowController>
        [HttpPost]
        public void Post([FromQuery] int codeBook, [FromQuery] string idSubscriber)
        {
            _borrowService.SAddBorrow(codeBook, idSubscriber);
        }

        // PUT api/<BorrowController>/5
        [HttpPut("End_Of_Borrowing {id}")]//////////////
        public ActionResult Put(int code)
        {
            if (_borrowService.SUpdateEndOfBorrow(code))
                return Ok();
            return NotFound("There is not such borrowing code to update");
        }
        //[HttpPut("changeStatus {id}")]
        //public void Put(int id, [FromQuery] bool isBookBorrowed)
        //{
        //    Data.Borrows.FirstOrDefault(brw => brw.Id == id).Book.IsBorrowed = isBookBorrowed;
        //}
        // DELETE api/<BorrowController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if(_borrowService.SDeleteBorrow(id))
return Ok();
            return NotFound("There is not such borrowing code to delete");
        }
    }
}

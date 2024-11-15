﻿using Library.Interface;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Helper;
using WebApplication1.module;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowController : ControllerBase
    {
        private readonly IDataContext _context;

        public BorrowController(IDataContext dataContext)
        {
            _context = dataContext;
        }


        // GET: api/<BorrowController>
        [HttpGet]
        public IEnumerable<Borrow> Get()
        {
            return _context.Borrows ;
        }

        // GET api/<BorrowController>/5
        [HttpGet("SameBook")]
        public IEnumerable<Borrow> Get([FromQuery] int code)
        {
            return _context.Borrows.Where(bo=>bo.Book.Code==code).ToList();
        }
        [HttpGet("SameSubscriber")]
        public IEnumerable<Borrow> Get([FromQuery]string id)
        {
            return _context.Borrows.Where(bo => bo.Subscriber.ID==id).ToList();
        }
        // POST api/<BorrowController>
        [HttpPost]
        public void Post([FromQuery] int codeBook, [FromQuery]string idSubscriber)
        {
          Books b= _context.BookList.FirstOrDefault(book => book.Code == codeBook);
          Subscribe s= _context.SubscribeList.FirstOrDefault(sub=>sub.ID==idSubscriber);
            if (s != null&&b!=null)
            {
                if (b.IsBorrowed == false)
                {
                    b.IsBorrowed = true;
                    Borrow borrow = new Borrow()
                    {
                        Book = b,
                        Subscriber = s,
                        BeginDate = DateTime.Today,
                        IsReturned = false
                    };
                    _context.Borrows.Add(borrow);
                }
            }
        }

        // PUT api/<BorrowController>/5
        [HttpPut("End_Of_Borrowing {id}")]//////////////
        public void Put(int id)
        {
            Borrow borrow = _context.Borrows.FirstOrDefault(brw => brw.Id == id);
            if (borrow != null) {         
                borrow.EndDate=DateTime.Today;
                borrow.IsReturned = true;
                borrow.Book.IsBorrowed=false;
            }
        }
        //[HttpPut("changeStatus {id}")]
        //public void Put(int id, [FromQuery] bool isBookBorrowed)
        //{
        //    Data.Borrows.FirstOrDefault(brw => brw.Id == id).Book.IsBorrowed = isBookBorrowed;
        //}
        // DELETE api/<BorrowController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Borrow b = _context.Borrows.FirstOrDefault(borrow => borrow.Id == id && borrow.Book.IsBorrowed == false);
            if (b != null)
                _context.Borrows.Remove(b);
        }
    }
}

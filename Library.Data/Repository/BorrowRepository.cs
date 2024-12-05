using Library.Core.Models;
using Library.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repository
{
    public class BorrowRepository:IBorrowRepository
    {
        private readonly DataContext _dataContext;
        public BorrowRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Borrow> GetList() 
        {
            return _dataContext.BorrowList.ToList();
        }
        public void RAddBorrow(int code,string id)
        {
            Books? book=_dataContext.BookList.FirstOrDefault(x => x.Code == code);
            Subscribe? subscribe=_dataContext.SubscribeList.FirstOrDefault(x => x.SubscribeID == id);
            if (subscribe != null && book != null)
            {
                if (book.IsBorrowed==false)
                {
                    book.IsBorrowed = true;
                    Borrow borrow = new Borrow()
                    {
                        Book = book,
                        Subscriber = subscribe,
                        BeginDate = DateTime.Now,
                        EndDate = DateTime.Now.AddDays(14),
                        IsReturned = false
                    };
                    _dataContext.BorrowList.Add(borrow);
                }
            }
        }
        public void RUpdateEndOfBorrow(int code)
        {
            Borrow? borrow = _dataContext.BorrowList.FirstOrDefault(x => x.Code == code);
            borrow.EndDate = DateTime.Today;
            borrow.IsReturned = true;
            borrow.Book.IsBorrowed = false;
        }
        public void RDeleteBorrow(int code)
        {
            Borrow? borrow = _dataContext.BorrowList.FirstOrDefault(x => x.Code == code);
            _dataContext.BorrowList.Remove(borrow);
        }
    }
}

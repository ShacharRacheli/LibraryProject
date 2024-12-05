using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class BorrowService:IBorrowService
    {
        private readonly IBorrowRepository _borrowRepository;
        public BorrowService(IBorrowRepository borrowRepository)
        {
            _borrowRepository = borrowRepository;
        }
        public List<Borrow> GetAll()
        { 
        return _borrowRepository.GetList();
        }
        public List<Borrow>SGetBorrowsByBookCode(int bookCode)
        {
            return _borrowRepository.GetList().Where(x=>x.Book.Code==bookCode).ToList();
        }
        public List<Borrow>SGetBorrowsSameSubscriber(string subscriberCode)
        {
            return _borrowRepository.GetList().Where(x=>x.Subscriber.SubscribeID==subscriberCode).ToList();
        }
        public void SAddBorrow(int bookCode, string subscriberCode)
        { 
            _borrowRepository.RAddBorrow(bookCode, subscriberCode);
        }
        public bool SUpdateEndOfBorrow(int code)
        {
            Borrow? borrow=_borrowRepository.GetList().FirstOrDefault(x=>x.Code==code);
            if (borrow != null) { 
                _borrowRepository.RUpdateEndOfBorrow(code);
                return true;
            }
            return false;
        }
        public bool SDeleteBorrow(int bookCode) 
        { 
         Borrow? borrow=_borrowRepository.GetList().FirstOrDefault(x=> x.Code==bookCode&& x.Book.IsBorrowed == false);
            if (borrow != null) { 
                _borrowRepository.RDeleteBorrow(bookCode);
            return true;
            }
            return false;
        }
    }
}

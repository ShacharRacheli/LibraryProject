using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Services
{
    public interface IBorrowService
    {
         List<Borrow> GetAll();
        List<Borrow> SGetBorrowsByBookCode(int bookCode);
        List<Borrow> SGetBorrowsSameSubscriber(string subscriberCode);
        void SAddBorrow(int bookCode, string subscriberCode);
         bool SUpdateEndOfBorrow(int code);
        bool SDeleteBorrow(int bookCode);


    }
}

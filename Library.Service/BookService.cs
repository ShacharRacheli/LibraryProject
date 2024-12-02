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
    public class BookService:IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public List<Books> GetAll()
        {
            return _bookRepository.getlist();
        }
        public bool GetByCode(int code)
        {
            Books book=_bookRepository.getlist().FirstOrDefault(x => x.Code == code);
            if (book != null)
            { 

            return false;
            }
            return true;
        }
    }
}

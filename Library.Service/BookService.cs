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
        public Books GetByCode(int code)
        {
            return _bookRepository.GetBookWithID(code);
        }
        public List<Books> GetByCategory(ECategories category)
        {
            return _bookRepository.getlist().Where(x => x.Category == category).ToList();
        }
        public bool PostBook(Books book)
        {
            if (book != null)
            {
                _bookRepository.PostABook(book);
                return true;
            }
            return false;
        }
        public bool PutBook(int code,Books book)
        {
            Books? tmp = _bookRepository.getlist().FirstOrDefault(x => x.Code == code);
            if (tmp != null) 
            {
                _bookRepository.PutABook(code, book);
                return true;
            }
            return false;
        }
        public bool DeleteBook(int code) {
            Books? book = _bookRepository.getlist().FirstOrDefault(x => x.Code == code);
            if (book != null) { 
            _bookRepository.DeleteABook(code);
                return true;
            }
            return false;
        }
    }
}

using Library.Core.Models;
using Library.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repository
{
    public class BookRepository:IBookRepository
    {
        private readonly DataContext _dataContext;
        public BookRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Books> getlist()
        {
            return _dataContext.BookList;
        }
        public Books GetBookWithID(int code) 
        { 
            return _dataContext.GetBookByCode(code);
        }
        public void PostABook(Books book)
        { 
        _dataContext.BookList.Add(book);
        }
        public void PutABook(int code,Books book)
        {
            Books temp=_dataContext.GetBookByCode(code);
            temp.Author = book.Author;
            temp.Name = book.Name;
            temp.Category = book.Category;
            temp.IsBorrowed = book.IsBorrowed;
            temp.DateOfPurchase = book.DateOfPurchase;
        }
        public void DeleteABook(int code) { 
            Books temp=_dataContext.GetBookByCode(code);
            _dataContext.BookList.Remove(temp);
        }
    }
}

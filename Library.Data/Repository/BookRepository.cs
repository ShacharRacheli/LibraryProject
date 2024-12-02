using Library.Core.Helper;
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
        public Books GetID(Books book) 
        { 
        }
    }
}

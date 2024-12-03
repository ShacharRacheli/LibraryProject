using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Services
{
    public interface IBookService
    {
        List<Books> GetAll();
        Books GetByCode(int code);
        List<Books> GetByCategory(ECategories category);
        bool PostBook(Books book);
        bool PutBook(int code, Books book);
        bool DeleteBook(int code);
      
        }
    }

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
        bool GetByCode(int code);
        List<Books> GetByCategory(ECategories category);
        void PostBook(Books book);
        void PutBook(int code, Books book);
        void DeleteBook(int code);
      
        }
    }

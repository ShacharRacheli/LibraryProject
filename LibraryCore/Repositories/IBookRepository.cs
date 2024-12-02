using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IBookRepository
    {
        List<Books> getlist();
        Books GetBookWithID(int code);
         void PostABook(Books book);
        void PutABook(int code, Books book);
        void DeleteABook(int code);
      


        }
    }

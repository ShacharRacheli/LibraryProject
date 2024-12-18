using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IManagerRepository
    {
        IBookRepository Books { get; }
   IBorrowRepository Borrows { get; }
        ISubscribeRepository Subscribe { get; }
        void Save();
    }
}

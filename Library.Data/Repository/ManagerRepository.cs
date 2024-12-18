using Library.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repository
{
    public class ManagerRepository
    {
private readonly DataContext _context;
        public ISubscribeRepository Subscribes { get;}
        public IBorrowRepository Borrows { get;}
        public IBookRepository Books { get;}
        public ManagerRepository(DataContext context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

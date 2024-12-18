﻿using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IBorrowRepository
    {
        List<Borrow> GetList();
         void RAddBorrow(int code, string id);
         void RUpdateEndOfBorrow(int code);
        void RDeleteBorrow(int code);

    }
}

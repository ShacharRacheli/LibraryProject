using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface ISubscribeRepository
    {
        List<Subscribe> GetAll();
        Subscribe RGetByID(string id);
         bool RPost(Subscribe subscribe);
         void RPut(string id, Subscribe subscribe);
         void RDelete(string id);


    }
}

using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Services
{
    public interface ISubscribeService
    {
        List<Subscribe> GetList();
        Subscribe SGetByID(string id);
        List<Subscribe> SGetListActive(bool active);
        bool SPost(Subscribe subscribe);
        bool SPut(string id, Subscribe subscribe);
        bool SDelete(string id);





    }
}

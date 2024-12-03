using Library.Core.Models;
using Library.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repository
{
    public class SubscribeRepository : ISubscribeRepository
    {
        private readonly DataContext _dataContext;
        public SubscribeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Subscribe> GetAll()
        {
            return _dataContext.SubscribeList;
        }
        public Subscribe RGetByID(string id)
        {
            return _dataContext.GetSubscribeByID(id);
        }
        public void RPost(Subscribe subscribe)
        {
            _dataContext.SubscribeList.Add(subscribe);
        }
        public void RPut(string id, Subscribe subscribe)
        {
            Subscribe temp = _dataContext.GetSubscribeByID(id);
            if (temp != null)
            {
                temp.Name = subscribe.Name;
                temp.IsActive = subscribe.IsActive;
                temp.Address = subscribe.Address;
                temp.Phone = subscribe.Phone;
            }
        }
        public void RDelete(string id)
        {
            Subscribe temp = _dataContext.GetSubscribeByID(id);
            _dataContext.SubscribeList.Remove(temp);
        }
    }
}

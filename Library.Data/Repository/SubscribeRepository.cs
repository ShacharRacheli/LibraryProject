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
            return _dataContext.SubscribeList.ToList();
        }
        public Subscribe RGetByID(string id)
        {
            return _dataContext.SubscribeList.FirstOrDefault(x => x.SubscribeID == id);
        }
        public bool RPost(Subscribe subscribe)
        {
            _dataContext.SubscribeList.Add(subscribe);
            _dataContext.SaveChanges();
            return true;
        }
        public void RPut(string id, Subscribe subscribe)
        {
            Subscribe? temp = _dataContext.SubscribeList.FirstOrDefault(x => x.SubscribeID == id);
            if (temp != null)
            {
                temp.Name = subscribe.Name;
                temp.IsActive = subscribe.IsActive;
                temp.Address = subscribe.Address;
                temp.Phone = subscribe.Phone;
            }
            _dataContext.SaveChanges();
        }
        public void RDelete(string id)
        {
            Subscribe? temp = _dataContext.SubscribeList.FirstOrDefault(x => x.SubscribeID == id);
           temp.IsActive=false;
            _dataContext.SaveChanges();
        }
    }
}

using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class SubscribeService : ISubscribeService
    {
        private readonly ISubscribeRepository _subscribeRepository;
        public SubscribeService(ISubscribeRepository subscribeRepository)
        {
            _subscribeRepository = subscribeRepository;
        }
        public List<Subscribe> GetList()
        {
            return _subscribeRepository.GetAll();
        }
        public Subscribe SGetByID(string id)
        {
            //Subscribe subscribe=_subscribeRepository.GetAll().FirstOrDefault(x=>x.ID==id);
            //if (subscribe != null)
            return _subscribeRepository.RGetByID(id);   
        }
        public List<Subscribe> SGetListActive(bool active)
        {
            return _subscribeRepository.GetAll().Where(x=>x.IsActive==active).ToList();
        }
        public bool SPost(Subscribe subscribe)
        {
            if (subscribe != null)
            {
                _subscribeRepository.RPost(subscribe);
                return true;
            }
            return false;
        }
        public bool SPut(string id, Subscribe subscribe)
        { 
        Subscribe subscribe1=_subscribeRepository.RGetByID(id);
            if (subscribe1 != null) { 
            _subscribeRepository.RPut(id, subscribe);
                    return true;
            }
            return false;
        }
        public bool SDelete(string id) 
        { 
        Subscribe subscribe1=_subscribeRepository.RGetByID(id);
            if (subscribe1 != null)
            {
                _subscribeRepository.RDelete(id);
                    return true;
            }
            return false;
        }
    }
}

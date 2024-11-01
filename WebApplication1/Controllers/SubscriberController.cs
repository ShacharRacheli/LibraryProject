﻿using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Helper;
using WebApplication1.module;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriberController : ControllerBase
    {
        // GET: api/<SubscriberController>
        [HttpGet]
        public IEnumerable<Subscribe> Get()
        {
            return Data.SubscribeList;
        }

        // GET api/<SubscriberController>/5
        [HttpGet("{id}")]
        public IActionResult Get([FromQuery]string id)
        {
            Subscribe subs = Data.SubscribeList.FirstOrDefault(sub => sub.ID == id);
            if (subs != null)
            {
                return Ok(subs);
            }           
               return NotFound();           
        }
        [HttpGet("ListIsActive")]
        public IEnumerable<Subscribe> Get([FromQuery]bool isActive)
        {
            return Data.SubscribeList.Where(sub => sub.IsActive==isActive).ToList();
        }
        // POST api/<SubscriberController>
        [HttpPost]
        public void Post([FromBody] Subscribe value)
        {
            Data.SubscribeList.Add(value);
        }

        // PUT api/<SubscriberController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Subscribe value)
        {
            Subscribe temp =Data.SubscribeList.FirstOrDefault(sub=>sub.ID==id);
            if (temp != null) { 
                temp.Name = value.Name;
                temp.IsActive = value.IsActive;
                temp.Address = value.Address;
                temp.Phone = value.Phone;
            }
            //Data.SubscribeList.FirstOrDefault(sub=>sub.ID.Equals(id)).Name = value.Name;
            //Data.SubscribeList.FirstOrDefault(sub=>sub.ID.Equals(id)).Address = value.Address;
            //Data.SubscribeList.FirstOrDefault(sub=>sub.ID.Equals(id)).Phone = value.Phone;
            //Data.SubscribeList.FirstOrDefault(sub=>sub.ID.Equals(id)).IsActive = value.IsActive;
        }

        // DELETE api/<SubscriberController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Subscribe s = Data.SubscribeList.FirstOrDefault(sub => sub.ID == id);
            if (s!=null)
            Data.SubscribeList.Remove(s);
        }
    }
}

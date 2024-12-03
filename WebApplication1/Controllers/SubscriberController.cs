using Library.Core.Interface;
using Library.Core.Models;
using Library.Core.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriberController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;
        public SubscriberController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        // GET: api/<SubscriberController>
        [HttpGet]
        public ActionResult Get()
        {
            List<Subscribe> tmp= _subscribeService.GetList();
            if(tmp.Any())
                return Ok(tmp);
            return NotFound();
        }

        // GET api/<SubscriberController>/5
        [HttpGet("{id}")]
        public ActionResult Get([FromQuery] string id)
        {
            var subscribe = _subscribeService.SGetByID(id);
            if (subscribe == null)
                return NotFound();
            return Ok(subscribe);
        }
        [HttpGet("ListIsActive")]
        public ActionResult Get([FromQuery] bool isActive)
        {
            List<Subscribe> list =_subscribeService.SGetListActive(isActive);
            if(list.Any())
                return Ok(list);
            return NotFound();
        }
        // POST api/<SubscriberController>
        [HttpPost]
        public ActionResult Post([FromBody] Subscribe value)
        {
            if(_subscribeService.SPost(value))
                return Ok();
            return NotFound("The subscribe object was null");
        }

        // PUT api/<SubscriberController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Subscribe value)
        {
            if(_subscribeService.SPut(id, value))
                return Ok();
            return NotFound("There is not such subscribe to update");
        }

        // DELETE api/<SubscriberController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            if(_subscribeService.SDelete(id))
                return Ok();
            return NotFound("There is not such subscribe to delete");
        }
    }
}

using Library.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class EventControllerTest
    {
        private readonly SubscriberController _subscriberController;

        public EventControllerTest()
        {
            //FakeData fakeData = new FakeData();
            _subscriberController = new SubscriberController(new FakeData());
        }

        [Fact]
        public void GetByID_ReturnsOK()
        {
            var id = "214872789";
            var res = _subscriberController.Get(id);
            Assert.IsType<OkObjectResult>(res);
        }

        [Fact]
        public void GetByID_ReturnsNotFound()
        {
            var id = "214789";
            var res = _subscriberController.Get(id);
            Assert.IsType<NotFoundResult>(res);
        }
        [Fact]
        public void GetAll_ReturnsList()
        {
            var res = _subscriberController.Get();
            Assert.IsType<List<Subscribe>>(res);
        }

    }
}
 
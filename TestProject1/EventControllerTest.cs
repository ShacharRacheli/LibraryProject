using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Controllers;
using WebApplication1.module;

namespace TestProject1
{
    public class EventControllerTest
    {
        [Fact]
        public void GetByID_ReturnsOK()
        {
            var id = "214872789";
            var controller = new SubscriberController();
            var res = controller.Get(id);
            Assert.IsType<OkObjectResult>(res);
        }

        [Fact]
        public void GetByID_ReturnsNotFound()
        {
            var id = "214789";
            var controller = new SubscriberController();
            var res = controller.Get(id);
            Assert.IsType<NotFoundResult>(res);
        }
        [Fact]
        public void GetAll_ReturnsList()
        {
            var controller = new SubscriberController();
            var res = controller.Get();
            Assert.IsType<List<Subscribe>>(res);
        }
    }
}

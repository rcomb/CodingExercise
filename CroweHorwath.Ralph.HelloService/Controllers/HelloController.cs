using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CroweHorwath.Ralph.HelloService.Controllers
{
    public class HelloController : ApiController
    {
        // GET api/values
        public string Get()
        {
            return "Hello World";
        }


        // GET api/values
        public string Get(string id)
        {
            return string.Format("Hello {0}", id);
        }
    }
}

using HelloWorldRepository.BusinessLayer;
using HelloWorldRepository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldWebAPI.Controllers
{
    public class HelloWorldController : ApiController
    {
        private IHelloWorldBusinessLayer _objHelloBal;
        public HelloWorldController(IHelloWorldBusinessLayer objHelloBal)
        {
            _objHelloBal = objHelloBal;
        }
        [HttpGet]
        public MyData Get()
        {
            return _objHelloBal.GetHelloWorldData();
        }
    }
}

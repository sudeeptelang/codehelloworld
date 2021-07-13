using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldRepository.DataAccessLayer;
using HelloWorldRepository.Model;

namespace HelloWorldRepository.BusinessLayer
{
    public class HelloWorldBusinessLayer : IHelloWorldBusinessLayer
    {
        private IHelloWorldDataAccessLayer _objHelloDal;
        public HelloWorldBusinessLayer(IHelloWorldDataAccessLayer objHelloDal)
        {
            _objHelloDal = objHelloDal;
        }
        public MyData GetHelloWorldData()
        {
            return _objHelloDal.GetHelloWorldData();
        }

    }
}

using HelloWorldRepository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldRepository.BusinessLayer
{
   public interface IHelloWorldBusinessLayer
    {
        MyData GetHelloWorldData();
    }
}

using HelloWorldRepository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp.Services
{
   public  interface IHelloWorldWebService
    {
        MyData GetHelloWorldData();
    }
}

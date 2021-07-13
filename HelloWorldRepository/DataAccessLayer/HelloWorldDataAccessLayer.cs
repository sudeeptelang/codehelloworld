using HelloWorldRepository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldRepository.DataAccessLayer
{
   public class HelloWorldDataAccessLayer: IHelloWorldDataAccessLayer
    {
        public MyData GetHelloWorldData()
        {
            return new MyData
            {
                Data = "Hello World",
               
            };
        }
    }
}

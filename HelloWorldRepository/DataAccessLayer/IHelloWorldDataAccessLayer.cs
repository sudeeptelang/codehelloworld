using HelloWorldRepository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldRepository.DataAccessLayer
{
  public  interface IHelloWorldDataAccessLayer
    {
        MyData GetHelloWorldData();
    }
}

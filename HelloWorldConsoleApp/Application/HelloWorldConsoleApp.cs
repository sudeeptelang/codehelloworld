using HelloWorldConsoleApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp.Application
{
    public class HelloWorldConsoleApp : IHelloWorldConsoleApp
    {
        
        private readonly IHelloWorldWebService helloWorldWebService;

        
        public HelloWorldConsoleApp(IHelloWorldWebService helloWorldWebService)
        {
            this.helloWorldWebService = helloWorldWebService;
          
        }

       
        public void Run(string[] arguments)
        {
           
            var data = this.helloWorldWebService.GetHelloWorldData();

            // Write Today's data to the screen
            Console.WriteLine(data != null ? data.Data : "No data was found!", null);
        }
    }
}

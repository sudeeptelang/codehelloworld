using HelloWorldConsoleApp.Services;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp.Application
{
    public class Source
    {
        /// <summary>
        ///     Starts the console application with the specified command line arguments
        /// </summary>
        /// <param name="args">Command line arguments</param>
        public static void Main(string[] args)
        {
           
            using (var container = new ServiceContainer())
            {
              
                container.Register<IHelloWorldConsoleApp, HelloWorldConsoleApp>();
              
                container.Register<IHelloWorldWebService, HelloWorldWebService>();
                

                // Run the main program
                container.GetInstance<IHelloWorldConsoleApp>().Run(args);
            }
        }
    }
}

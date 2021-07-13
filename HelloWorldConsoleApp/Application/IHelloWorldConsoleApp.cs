using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp.Application
{
    public interface IHelloWorldConsoleApp
    {
        /// <summary>
        ///     Runs the main Hello World Console Application
        /// </summary>
        /// <param name="arguments">The command line arguments.</param>
        void Run(string[] arguments);
    }
}

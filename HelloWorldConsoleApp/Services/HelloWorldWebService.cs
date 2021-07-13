using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using HelloWorldRepository.Model;
using Newtonsoft.Json;

namespace HelloWorldConsoleApp.Services
{
    public class HelloWorldWebService : IHelloWorldWebService
    {
       

        public MyData GetHelloWorldData() //Get All Events Records  
        {
            MyData data = null;

            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("http://localhost:52791/api/HelloWorld"); //URI  
                var resp = JsonConvert.DeserializeObject<MyData>(result);
                data = resp;
            }
            return data;
        }

      
    }
}

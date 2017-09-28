using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CroweHorwath.Ralph.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                name = "World";
            }
            string endpointUrl = ConfigurationManager.AppSettings["endpointUrl"];
            ApiClient client = new ApiClient(endpointUrl);
            string result = client.GetAsync(name).Result;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        
    }
}

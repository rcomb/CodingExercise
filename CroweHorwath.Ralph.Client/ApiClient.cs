using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CroweHorwath.Ralph.Client
{
    public class ApiClient
    {
        private string endpoint;
        private HttpClient client;

        public ApiClient(string endpoint)
        {
            this.endpoint = endpoint;
            this.client = new HttpClient();
        }

        public ApiClient(HttpClient client)
        {
            this.client = client;
        }

        public async Task<string> GetAsync(string name = "World")
        {
            
            return await client.GetStringAsync(this.endpoint + "/" + name);
        }
    }
}

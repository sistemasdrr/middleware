using System;
using System.Configuration;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Middleware.Data
{
    internal class HttpRestClient
    {
       
        public async Task<string> SendEmail(string json)
        {
           
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = ConfigurationManager.AppSettings["UriRestEmail"];
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromMinutes(10);
                    var response = await client.PostAsync(url, data);
                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch(Exception ex) {
                throw new Exception(ex.Message);
            }
          
        } 
    }
}

using System.Configuration;
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
            using (var client=new HttpClient())
            {
                var response = await client.PostAsync(url, data);
                return await response.Content.ReadAsStringAsync();
            }
          
        } 
    }
}

using Middleware.Entities;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Middleware.Data
{
    public class DEmail
    {
        readonly HttpRestClient client;
        public DEmail()
        {
            client = new HttpRestClient();
        }
        public async Task<Response> SendEmail(Request request)
        {           
            var json = JsonConvert.SerializeObject(request);
            return JsonConvert.DeserializeObject<Response>(await client.SendEmail(json));
        }
    }
}

using Middleware.Entities;
using Newtonsoft.Json;

namespace Middleware.Data
{
    public class DEmail
    {
        readonly HttpRestClient client;
        public DEmail()
        {
            client = new HttpRestClient();
        }
        public Response SendEmail(Request request)
        {           
            var json = JsonConvert.SerializeObject(request);
            return JsonConvert.DeserializeObject<Response>(client.SendEmail(json));
        }
    }
}

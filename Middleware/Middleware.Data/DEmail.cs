using Middleware.Entities;
using Newtonsoft.Json;
using System;
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
            try
            {
                var json = JsonConvert.SerializeObject(request);
                return JsonConvert.DeserializeObject<Response>(await client.SendEmail(json));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
    }
}

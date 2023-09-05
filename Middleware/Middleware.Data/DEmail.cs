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
            var response=new    Response();
            try
            {
                var json = JsonConvert.SerializeObject(request);
                string respuesta = await client.SendEmail(json);
                response = JsonConvert.DeserializeObject<Response>(respuesta);
                response.Message = respuesta;
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
    }
}

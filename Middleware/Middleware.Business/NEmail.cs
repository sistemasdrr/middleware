using Middleware.Data;
using Middleware.Entities;
using System.Threading.Tasks;

namespace Middleware.Business
{
    public class NEmail
    {
        readonly DEmail email;
        public NEmail()
        {
            email = new DEmail();
        }
        public async Task<Response> SendEmail(Request request)
        {
            return await email.SendEmail(request);
        }
    }
}

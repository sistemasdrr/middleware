using Middleware.Data;
using Middleware.Entities;

namespace Middleware.Business
{
    public class NEmail
    {
        readonly DEmail email;
        public NEmail()
        {
            email = new DEmail();
        }
        public Response SendEmail(Request request)
        {
            return email.SendEmail(request);
        }
    }
}

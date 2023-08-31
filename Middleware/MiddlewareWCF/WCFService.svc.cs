using Middleware.Business;
using Middleware.Entities;

namespace MiddlewareWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WCFService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WCFService.svc o WCFService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WCFService : IWCFService
    {
        public NEmail email;
        public Response SendMail(Request request)
        {
            email=new NEmail();
            return email.SendEmail(request);  
        }
    }
}

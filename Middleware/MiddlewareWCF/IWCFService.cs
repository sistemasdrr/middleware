using Middleware.Entities;
using System.ServiceModel;

namespace MiddlewareWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWCFService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWCFService
    {
        [OperationContract]
        Response SendMail(Request request);
    }
}

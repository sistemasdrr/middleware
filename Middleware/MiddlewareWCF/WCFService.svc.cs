﻿using Middleware.Business;
using Middleware.Entities;
using System;
using System.Threading.Tasks;

namespace MiddlewareWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WCFService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WCFService.svc o WCFService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WCFService : IWCFService
    {
        public NEmail email;

        public string Get(string request)
        {
            return "hola : "+request;
        }

        public  Response SendMail(Request request)
        {
            try
            {
                email = new NEmail();
                return email.SendEmail(request).Result;
            }
            catch(Exception ex){
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }
    }
}

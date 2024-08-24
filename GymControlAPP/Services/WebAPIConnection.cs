using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymControlAPP.Services
{
    public static class WebAPIConnection
    {
        //esta clase auto instanciada permite configurar la ruta de consumo base 
        //del servicio web API. Normalmente es un nombre DNS como www.misitio.com/api/
        //o la dirección IP del servidor como por ejemplo 85.25.45.10/api o local 
        //como 192.168.0.10/api

        public static string BaseURL = "http://192.168.100.2:45455/api/";

        //acá también es importante incluir la info de seguridad como el API Key
        //ya que debe ser incluido en cada llamada a los end point del API 
       
        public static string ApiKeyName = "ApiKey";
        public static string ApiKeyValue = "julio123queso";

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace direccinesIP
{
    /// <summary>
    /// Descripción breve de direccionIP
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class direccionIP : System.Web.Services.WebService
    {

        [WebMethod]
        public string direccion(int ip)
        {
            var direc = "";
            if (ip >= 0 && ip <= 127)
            {
                return direc = "La direccion IP es  clase A";
            }
            else 
            {
                if (ip >= 128 && ip <= 191)
                {
                    return direc = "La direccion IP es  clase B";
                }
                else 
                {
                    if (ip >= 192 && ip <= 223)
                    {
                        return direc = "La direccion IP es  clase C";
                    }
                    else 
                    {
                        return direc = "La direccion no pertenece a ninguna de las clas A B o C o introduce correctamenta la direccion";
                    }
                }
            }
        }
    }
}

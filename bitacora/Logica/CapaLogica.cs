using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class CapaLogica
    {
        CapaDatos cdatos = new CapaDatos();

        void accion(string host,string usuario, string accion)
        {
            if(host!="")
            {
                cdatos.insertAccion(host, usuario, accion);
            }
        }
    }
}

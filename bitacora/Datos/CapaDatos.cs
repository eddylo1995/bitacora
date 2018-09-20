using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CapaDatos
    {
        public int insertAccion(string host, string usuario, string accion)
        {
            string query = "INSERT INTO VALUES('" + host + "','" + usuario + "','" + accion + "')'";
            return 1;
        }
    }
}

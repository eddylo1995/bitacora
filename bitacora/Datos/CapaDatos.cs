using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Drawing;
using System.ComponentModel;
namespace Datos
{
    public class CapaDatos
    {
        MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=seguridad_db ;Uid=root; pwd= ; ");
        void conexion()
        {
            try
            {
                conectar.Open();
                MySqlCommand comando = new MySqlCommand("INSERT into bitacora values(?,?)", conectar);
                comando.ExecuteNonQuery();
              

            }
            catch(Exception)
            {
                conectar.Close();
            }
        }
    }
}

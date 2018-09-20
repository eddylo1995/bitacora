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
        public MySqlConnection conectar()
        {
            string conexionString = "server=localhost; userid=root; password=''; database=seguridad_bd;Sslmode=none";
            MySqlConnection conexionDB = new MySqlConnection(conexionString);
            try
            {
                conexionDB.Open();
                return conexionDB;
            }
            catch(Exception ex)
            {
                return null;
            }
 }
    }
}

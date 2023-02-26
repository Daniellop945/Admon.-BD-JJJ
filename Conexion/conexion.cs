using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conexion
{
    public class conexion
    {
        public static MySqlConnection connection;
        public bool conectar()
        {
            try
            {
                connection = new MySqlConnection("server=localhost;database=inventario;uid=root; password=root");
                connection.Open();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public void desconectar()
        {
            try {
                connection.Close();
                Console.WriteLine("Se ha cerrado");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al cerrar el servidor");
            }
        }
    }
}

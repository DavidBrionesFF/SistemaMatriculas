using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Trabajo1
{
    class Conexion
    {
        private SqlConnection coneccion;
        private static Conexion instance = new Conexion();

        public static Conexion getInstance()
        {
            return instance;
        }

        public SqlConnection getConextion()
        {
            return coneccion;
        }

        private Conexion()
        {
            coneccion = new SqlConnection(Properties.Settings.Default.conexion);
            coneccion.Open();
        }



    }
}

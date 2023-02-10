using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Central.Clases
{
    class Conexion
    {
        string cadena_conn = "server=localhost;  database=central; user=usuario; password=1532666; port=3306; allow zero Datetime= true";
        //string cadena_conn = "server=localhost;  database=central; user= Central; password=Centr-Sis-2020; port=3306; allow zero Datetime= true";

        // string cadena_conn = "server=localhost;  database=chente; user= root; password=Ami_1532; port=3306; allow zero Datetime= true";

        public MySqlConnection conn = new MySqlConnection();

        public void iniciar()
        {
            conn.ConnectionString = cadena_conn;
        }


        public string probar_conn()
        {
            string mensaje;
            conn.ConnectionString = cadena_conn;
            try
            {
                conn.Open();
                conn.Close();
                mensaje = "Conexion exitosa";
                return mensaje;
            }
            catch (Exception ex)
            {
                conn.Close();
                mensaje = "Error: " + ex.ToString() + "\n" + cadena_conn;
                return mensaje;
            }
        }
    }
}

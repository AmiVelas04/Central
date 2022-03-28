using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Central.Clases
{
    class Login
    {
        Conexion con = new Conexion();
        #region "General"
        private DataTable buscar(string consulta)
        {
            con.iniciar();
            DataTable datos = new DataTable();
            try
            {

                MySqlDataAdapter adap = new MySqlDataAdapter(consulta, con.conn);
                adap.Fill(datos);
            }
            catch (Exception ex)
            {
                
               // MessageBox.Show("Error de conexion, consulte con su administrador de sistemas\n" +consulta+"\n** "+ ex.ToString ());
                
              //  MessageBox.Show(consulta);
            }
            return datos;
        }
        private bool consulta_gen(string consulta)
        {
            con.iniciar();
            MySqlCommand com1 = new MySqlCommand();
            com1.Connection = con.conn;
            com1.CommandText = consulta;
            com1.CommandType = CommandType.Text;
            try
            {
                con.conn.Open();
                com1.ExecuteNonQuery();
                con.conn.Close();
            }

            catch (Exception ex)
            {
                con.conn.Close();
                MessageBox.Show(ex.ToString());
                MessageBox.Show(consulta);
                return false;
            }
            return true;
        }
        #endregion
        public  DataTable  inicio(string usu, string pass)
        {
            
            string consulta = "Select id_cajero, nombre,id_tipo from cajero where Usuario='" + usu + "' and pass='" + pass + "'";
            return buscar(consulta);
            
        }
    }
}

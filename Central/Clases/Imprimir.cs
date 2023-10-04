using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace Central.Clases
{
    class Imprimir
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

                MessageBox.Show("Error de conexion, consulte con su administrador de sistemas\n" + consulta + "\n** " + ex.ToString());

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

        public string ImpresoraPred()
        {
            for (Int32 i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                PrinterSettings a = new PrinterSettings();
                a.PrinterName = PrinterSettings.InstalledPrinters[i].ToString();
                if (a.IsDefaultPrinter)
                { return PrinterSettings.InstalledPrinters[i].ToString(); }

            }
            return "";
        }

        public void imprimir()
        {
          
        }

        public string impresotaSet() {
            string consulta = "Select impresora from impresora where id_imp=1";
           DataTable datos= buscar(consulta);
            string retorno = "";
            if (datos.Rows.Count > 0)
            { retorno = datos.Rows[0][0].ToString(); }
            return retorno;
        }

        public bool saveprint(string imp) {
            try
            {
                string consulta;
                consulta = consulta = $"Update impresora set impresora='{imp}'";
                return consulta_gen(consulta);
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}

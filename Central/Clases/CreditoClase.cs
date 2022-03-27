using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Central.Clases
{
    class CreditoClase
    {
        Conexion conec = new Conexion();
        Clases.PagoClase pag = new PagoClase();
     
        #region "General"
        private DataTable buscar(string consulta)
        {
            conec.iniciar();
            DataTable datos = new DataTable();
            try
            {
                MySqlDataAdapter adap = new MySqlDataAdapter(consulta, conec.conn);
                adap.Fill(datos);
            }
            catch (Exception ex)
            {
                string mensaje = ex.ToString() + "\n" + consulta;
                MessageBox.Show("Se presento un inconveniente en el proceso de credito ", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return datos;


        }

        private bool consulta_gen(string consulta)
        {
            conec.iniciar();
            MySqlCommand com1 = new MySqlCommand();
            com1.Connection = conec.conn;
            com1.CommandText = consulta;
            com1.CommandType = CommandType.Text;
            try
            {
                conec.conn.Open();
                com1.ExecuteNonQuery();
                conec.conn.Close();
            }

            catch (Exception ex)
            {
                conec.conn.Close();
                string mensaje = ex.ToString() + "\n" + consulta;
                MessageBox.Show("Se presento un inconveniente en el proceso de credito ", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }


        #endregion


        #region Cargadatos
        public String VentaxCredito(string cre)
        {
            DataTable datos = new DataTable();
            string Consulta = "Select id_venta from credito where id_cred="+cre;
            datos=buscar(Consulta);
            if (datos.Rows.Count > 0)
            { return datos.Rows[0][0].ToString(); }
            else
            { return "0"; }
        }

        public DataTable CreditoxCli(string cli)
        {
            string Consulta = "Select id_cred from credito where id_cli=" + cli;
            return  buscar(Consulta);
        }
        #endregion

        #region IngresoDatos
        public bool IngresoCred(string[] datos)
        {
            string consulta;
            int idcred;
            idcred = MaxIdcred();
            idcred++;
            consulta = "Insert into credito(id_cred,id_cli,id_venta,Total,Anticipo,Estado) "+
                       "values("+idcred+","+datos[0]+","+datos[1]+","+datos[2]+","+datos[3]+",'"+datos[4]+"')";
            if (datos[3].Equals("0"))
            { }
            else
            {
                if (consulta_gen(consulta))
                {
                    string fecha = DateTime.Now.ToString("yyyy/MM/dd");
                    string[] pagdata = { idcred.ToString(), datos[3], "Primer pago de credito No " + idcred, fecha, datos[5] };
                    return pag.Guardarpago(pagdata);
                }
               
            }
            return false;
        }
        #endregion

        #region Id's
        private int MaxIdcred()
        {
            int id;
            DataTable datos = new DataTable();
            string consulta = "Select Max(id_cred) from credito";
            datos = buscar(consulta);
            if (datos.Rows[0][0] == DBNull.Value)
            {
                id = 0;
            }
            else
            {
                id = int.Parse(datos.Rows[0][0].ToString());
            }
            return id;
        }
        #endregion

    }
}

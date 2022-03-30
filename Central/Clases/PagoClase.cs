using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Central.Clases;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Central.Clases
{
    class PagoClase
    {
        Conexion conec = new Conexion();
        Caja caj = new Caja();
        Usuario usua = new Usuario();
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
                MessageBox.Show("Se presento un inconveniente en el proceso de pagos ", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Se presento un inconveniente en el proceso de pagos ", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }


        #endregion


        #region Pagos
        public decimal PagosHechos(string cre)
        {
            DataTable dato = new DataTable();
            decimal total;
            string consulta = "SELECT SUM(p.Monto) " +
                              "FROM pago p " +
                              "INNER JOIN credito cre ON cre.ID_CRED = p.id_cred " +
                              "WHERE cre.ID_CRED = " + cre;
            dato = buscar(consulta);
            if (dato.Rows[0][0] == DBNull.Value)
            {
                total = 0;
            }
            else
            { total = decimal.Parse(dato.Rows[0][0].ToString()); }

            return total;
        }

        public bool Guardarpago(string[] datos)
        {
            try
            {
                string consulta;
                int idpag;
                idpag = MaxIdPag();
                idpag++;
                consulta = "Insert into pago(id_pago,id_cred,monto,detalle,fecha,id_cajero) " +
                         "Values(" + idpag.ToString() + "," + datos[0] + "," + datos[1] + ",'" + datos[2] + "','" + datos[3] + "'," + datos[4] + ")";
                string atendio;
                DataTable usu = new DataTable();
                usu = usua.buscusu(datos[4]);
                atendio = usu.Rows[0][0].ToString();
                string[] opera = { "Ingreso", "Abono de credito No " + datos[0] + ",Operado por " + atendio, datos[1], DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"), datos[4] };
                return (consulta_gen(consulta) && caj.ingreope(opera));
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable ListaPag(string idcredi)
        {
            string consulta;
            consulta = "Select id_pago as No,Monto,Detalle,Date_Format(Fecha,'%d/%M/%Y') as Fecha from pago where id_cred="+idcredi;
            return buscar(consulta);
        }

        private bool EditaPago()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }


        #endregion


        #region Ids
        private int MaxIdPag()
        {
            int id;
            DataTable datos = new DataTable();
            string consulta = "Select Max(id_pago) from pago";
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

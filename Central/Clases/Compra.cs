using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Central.Clases
{
    class Compra
    {
        Conexion conect = new Conexion();
        Producto prod = new Producto();
        Usuario usu = new Usuario();


        #region "General"
        private DataTable buscar(string consulta)
        {
            conect.iniciar();
            DataTable datos = new DataTable();
            try
            {

                MySqlDataAdapter adap = new MySqlDataAdapter(consulta, conect.conn);
                adap.Fill(datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n" + consulta);
                //MessageBox.Show(consulta);
            }
            return datos;
        }
        private bool consulta_gen(string consulta)
        {
            conect.iniciar();
            MySqlCommand com1 = new MySqlCommand();
            com1.Connection = conect.conn;
            com1.CommandText = consulta;
            com1.CommandType = CommandType.Text;
            try
            {
                conect.conn.Open();
                com1.ExecuteNonQuery();
                conect.conn.Close();
            }

            catch (Exception ex)
            {
                conect.conn.Close();
                MessageBox.Show(consulta + "\n" + ex.ToString());
                return false;
            }
            return true;
        }


        #endregion

        #region "Datos"
        public int idcomp()
        {
            DataTable datos = new DataTable();
            int val;
            string consulta = "select max(id_venta) from compra";
            datos = buscar(consulta);
            if (datos.Rows[0][0] == DBNull.Value)
            { val = 0; }
            else { val = Int32.Parse(datos.Rows[0][0].ToString()); }
            return val;
        }

        private int idetalle()
        {
            DataTable datos = new DataTable();
            int val;
            string consulta = "select max(id_detalle) from comp_det";
            datos = buscar(consulta);
            if (datos.Rows[0][0] == DBNull.Value)
            { val = 0; }
            else { val = Int32.Parse(datos.Rows[0][0].ToString()); }
            return val;
        }

        #endregion

        #region "Procesos"

        public DataTable cargaprod(string cod) {
         return prod.buscarprod(cod);
        }

       public bool GenComp(DataTable datos, string prove) {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

      //  public bool GenCompDet() { }

        
        #endregion


    }
}

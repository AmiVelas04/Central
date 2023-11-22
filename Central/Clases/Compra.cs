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
            string consulta = "select max(id_comp) from compra";
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
            string consulta = "select max(id_compdet) from comp_det";
            datos = buscar(consulta);
            if (datos.Rows[0][0] == DBNull.Value)
            { val = 0; }
            else { val = Int32.Parse(datos.Rows[0][0].ToString()); }
            return val;
        }

        #endregion

        #region "Procesos"

        public DataTable cargaprod(string cod)
        {
            return prod.buscarprod(cod);
        }

        public bool GenComp(DataTable datos, string vende, string tot, string prove)
        {
            try
            {
                int id = idcomp() + 1;
                string fecha = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                string consulta = $"Insert into Compra(Id_comp,id_caj,Fecha,Total,Prove) values({id},{vende},'{fecha}',{tot},'{prove}')";
                if (consulta_gen(consulta))
                {
                    return GenCompDet(datos, id.ToString());

                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error:\n{ex}");
                return false;

            }
        }

        public bool GenCompDet(DataTable datos, string compra)
        {
            int total = datos.Rows.Count;
            for (int i = 0; i < total; i++)
            {
                if (prod.existeprod(datos.Rows[i][0].ToString()))
                { prod.ReponProd(datos.Rows[i][0].ToString(), datos.Rows[i][8].ToString()); }
                else
                {
                    string[] valor = { datos.Rows[i][0].ToString(), datos.Rows[i][1].ToString(), datos.Rows[i][2].ToString(), datos.Rows[i][3].ToString(), datos.Rows[i][4].ToString(), datos.Rows[i][5].ToString(), datos.Rows[i][8].ToString(), DateTime.Now.AddYears(2).ToString("yyyy/MM/dd HH:mm:ss"), "0", "0", datos.Rows[i][8].ToString(), datos.Rows[i][8].ToString() };
                    prod.agregprod(valor);
                }
                int iddet = idetalle() + 1;
                string idcomp = compra;
                string idprod = datos.Rows[i][0].ToString();
                string cant = datos.Rows[i][8].ToString();
                string costo = datos.Rows[i][4].ToString();

                string consulta = "Insert into comp_det(id_compdet,id_comp,id_prod,cant, costo) " +
                            $"values ({iddet},{idcomp},'{idprod}',{cant},{costo})";
                if (!consulta_gen(consulta))
                {
                    return false;
                }

            }
            return true;
        }


        #endregion
    }
}

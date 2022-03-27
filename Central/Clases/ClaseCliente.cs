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
    class ClaseCliente
    {
        Conexion conec = new Conexion();
      
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
                MessageBox.Show("Se presento un inconveniente en el proceso de clientes", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Se presento un inconveniente en el proceso de clientes ", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        #endregion

        #region Manejo de clientes

        public DataTable clientes()
        {
            String consulta;
            DataTable datos = new DataTable();
            consulta = "Select id_cli, nombre from clientes";
            datos = buscar(consulta);
            return datos;
        }
        public DataTable clientesCre()
        {
            String consulta;
            DataTable datos = new DataTable();
            consulta = "Select id_cli, nombre from clientes where id_cli!=1" ;
            datos = buscar(consulta);
            return datos;
        }

        public DataTable clienSin()
        {
            String consulta;
            DataTable datos = new DataTable();
            consulta = "Select id_cli, nombre from clientes where id_cli != 1";
            datos = buscar(consulta);
            return datos;

        }
        private int IdCli()
        {
            string consulta = "Select max(id_cli) from clientes";
            DataTable datos = new DataTable();
            datos = buscar(consulta);
            if (datos.Rows[0][0] != DBNull.Value)
            {
                return int.Parse(datos.Rows[0][0].ToString()) + 1;
            }
            else
            { return 1; }
        }

     

        public DataTable buscli(string cli)
        {
            string consulta;
            consulta = "Select DIRECCION,nit,Nombre,telefono, dpi from clientes where id_cli =" + cli;
            return buscar(consulta);
        }

      

        public bool ingrecli(string[] datos)
        {
            int id = IdCli();
            string consulta = "insert into clientes(id_cli,nombre,direccion,nit,dpi,telefono) " +
                "Values(" + id + ",'" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "')";
            return consulta_gen(consulta);
        }

        public string clienvent(string[] datos)
        {
            int id = IdCli();
            string consulta = "insert into clientes(id_cli,nombre,direccion,nit,dpi,telefono,credi) " +
                "Values(" + id + ",'" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "'," + datos[5] + ")";
            if (consulta_gen(consulta))
            {
                return id.ToString();
            }
            else
            {
                return "0";
            }
        }


        public DataTable Nomcliente(string nom)
        {
            string consulta = "Select id_cli,Nombre, Direccion,Nit, Telefono,Dpi from clientes " +
                "where nombre like '%" + nom + "%'";
            return buscar(consulta);
        }
        public bool Actucli(string[] datos)
        {
            string consulta = "Update Clientes set Nombre='" + datos[0] + "', direccion='" + datos[1] + "', nit='" + datos[2] + "', dpi='" + datos[3] +
                "', telefono='" + datos[4] + "' where id_cli="+datos[5];
            return consulta_gen(consulta);
        }
        #endregion
    }
}

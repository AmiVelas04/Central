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
    class Usuario
    {
        Conexion conect = new Conexion();
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
                MessageBox.Show(ex.ToString());
                MessageBox.Show(consulta);
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
                MessageBox.Show(ex.ToString());
                MessageBox.Show(consulta);
                return false;
            }
            return true;
        }
        #endregion
        public bool existeusu(string idusu)
        {
            string consulta = "Select count(*) from cajero where id_cajero=" + idusu ;
            return (Int32.Parse(buscar(consulta).Rows[0][0].ToString()) > 0);
        }

        public DataTable Usutodos()
        {
            string consulta = "Select id_cajero,Nombre from cajero where id_cajero>1";
            return buscar(consulta);
        }

        public DataTable UsumAdmin()
        {
            string consulta = "Select id_cajero,Nombre, from cajero where id_cajero";
            return buscar(consulta);
        }
        private int idusu()
        {
            DataTable datos = new DataTable();
            int val;
            string consulta = "select max(id_cajero) from cajero";
            datos = buscar(consulta);
            if (datos.Rows[0][0] == DBNull.Value)
            { val = 0; }
            else { val = Int32.Parse(datos.Rows[0][0].ToString()); }
            return val;
        }

        public bool ingreusu(string[] datos)
        {
            int cod = idusu() + 1;
            string consulta = "insert into cajero( id_cajero, nombre, usuario,pass,id_tipo,estado) " +
                            $"values ({cod},'{datos[0]}','{datos[1]}','{datos[2]}',{datos[3]},'{datos[4]}')";
            return consulta_gen(consulta);

        }

        public bool updtusu(string[] datos)
        {
            string consulta;
            consulta = consulta = $"Update cajero set nombre='{datos[1]}', usuario='{datos[2]}', pass='{datos[3]}', id_tipo={datos[4]} where id_cajero={datos[0]}";
            return consulta_gen(consulta );
        }

        public bool AcDesUsu(string[] datos)
        {
            string consulta;
            consulta = $"Update cajero set nombre='{datos[1]}', usuario='{datos[2]}', pass='{datos[3]}', id_tipo={datos[4]}, Estado='{datos[5]}' where id_cajero={datos[0]}";
            return consulta_gen(consulta);
        }

        public DataTable usuarios()
        {
            string consulta;
            consulta = "Select id_cajero,nombre from cajero where id_cajero !=1";
            return buscar(consulta);
        }

        public DataTable buscusu(string id)
        {
            string consulta;
            consulta = "Select nombre,usuario,id_tipo from cajero where id_cajero="+ id;
            return buscar(consulta);
        }

        public DataTable buscUsuEdit(string id)
        {
            string consulta;
            consulta = "Select nombre,usuario,pass,id_tipo,estado from cajero where id_cajero=" + id;
            return buscar(consulta);
        }



        public DataTable SearchUsubyNomAct(string nom)
        {
            string consulta;
            consulta = $"Select id_cajero,nombre,usuario,id_tipo,estado from cajero where nombre like '%{nom}%' and estado='Activo' and id_cajero !=1";
            return buscar(consulta);
        }

        public DataTable SearchUsubyNom(string nom)
        {
            string consulta;
            consulta = $"Select id_cajero,nombre,usuario,id_tipo,estado from cajero where nombre like '%{nom}%' and id_cajero !=1";
            return buscar(consulta);
        }

        public DataTable SearchUsuAllAct()
        {
            string consulta;
            consulta = $"Select id_cajero,nombre,usuario,id_tipo,estado from cajero where estado='Activo' and id_cajero !=1";
            return buscar(consulta);
        }

        public DataTable SearchUsuAll()
        {
            string consulta;
            consulta = $"Select id_cajero,nombre,usuario,id_tipo,estado from cajero where id_cajero!=1";
            return buscar(consulta);
        }



        public bool Eliminar(string id,string iddel)
        {
            string cambiarid = "update venta set id_cajero=" + iddel;
            if (consulta_gen(cambiarid))
            {
                string consulta = "Delete from cajero where id_cajero=" + id;
                return consulta_gen(consulta);
            }
            else
            {
                return false;
            }
        }
        private void ReasingVen()
        { }
    }
    
}

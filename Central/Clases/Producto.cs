using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Central.Clases
{
    
    class Producto
    {
        Conexion conect = new Conexion();
        //Venta Ven = new Venta();
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

        public bool existeprod(string cod)
        {
            string consulta;
            consulta = "Select count(*) from producto where id_prod='" + cod + "'";
            if (Int32.Parse(buscar(consulta).Rows[0][0].ToString()) > 0) return true;
            return false;
            

        }
        public bool agregprod(string[] datos)
        {
            string consulta;
            consulta = "Insert into producto (id_prod,nombre, descripcion,marca,precio_c,precio_v,cantidad,fecha_cad,pack,p_pack) "+
                "Values('"+datos [0] + "','"+ datos[1] + "','"+ datos[2] + "','"+ datos[3] + "'," + datos[4] + ","+ datos[5] + "," + datos[6] + ",'" + datos[7] +"',"+datos[8]+","+datos [9]+")";
            return consulta_gen(consulta);

        }

        public bool actualprod(string[] datos)
        {
            string consulta;
            consulta = "Update producto set nombre='"+ datos[1] + "', descripcion ='"+ datos[2] + "',marca ='"+datos[3] +"',precio_c=" + datos[4] + ",precio_v="+ datos[5] + ",cantidad="+ datos[6] + ",fecha_cad= '" + datos[7] + "',pack="+datos[8]+", p_pack="+datos[9] + 
                " Where id_prod='" + datos[0] + "'";
            return consulta_gen(consulta);

        }

        public DataTable buscarprod(string cod)
        {
            string consulta;
            consulta = "Select Nombre,Descripcion,Marca,precio_c as Costo,precio_v as Venta,Cantidad,Date_format(fecha_cad,'%d-%m-%y')as Caducidad, pack as Paquete,p_pack as PrecioxPaquete "+
                "from producto where id_prod='" + cod + "'";
            return buscar(consulta);
        }

        public DataTable Buscarprodnom(string nom,string marc, string desc)
        {
            string consulta;
            consulta = "Select id_prod as Codigo,Nombre,Descripcion,Marca,precio_c as Costo,precio_v as Venta,Cantidad,Date_format(fecha_cad,'%d-%m-%y')as Caducidad, pack as Paquete,p_pack as PrecioxPaquete "+
                        "from producto "+
                        "where nombre like'%" + nom + "%' and marca like '%"+marc+"%' and descripcion like '%"+desc+"%'" ;
            return buscar(consulta);
        }
        public bool DescontProd(string idprod, string cant)
        {
            string consultap,consultac;
            int cantAnt;
            consultap = "select cantidad from producto where id_prod='"+idprod +"'";
            cantAnt = Int32.Parse(buscar(consultap).Rows[0][0].ToString ());
            cantAnt -= Int32.Parse(cant);
            consultac = "update producto set cantidad="+cantAnt + " where id_prod='"+idprod + "'";
            return consulta_gen(consultac);
        }
        public void Inventario()
        {
            string consulta = "SELECT Id_prod, Nombre,Descripcion,Marca,PRecio_c,cantidad,precio_V FROM producto ORDER BY nombre";
            DataTable datos = new DataTable ();
            datos = buscar(consulta);
            Reportes.DiarioEnc enca = new Reportes.DiarioEnc();
            int cant=datos.Rows .Count , cont;
            for (cont = 0; cont < cant; cont++)
            {
                Reportes.DiarioDet Deta = new Reportes.DiarioDet();
                Deta.orden = cont+1;
                Deta.codigo = datos.Rows[cont][0].ToString();
                Deta .producto = datos.Rows[cont][1].ToString();
                Deta .desc = datos.Rows[cont][2].ToString();
                Deta .marca = datos.Rows[cont][3].ToString();
                Deta .precio =decimal.Parse ( datos.Rows[cont][4].ToString());
                Deta .cantidad= int.Parse (datos.Rows[cont][5].ToString());
                Deta.subtotal = decimal.Parse(datos.Rows[cont][4].ToString()) * int.Parse(datos.Rows[cont][5].ToString());
                Deta.precioV = decimal.Parse(datos.Rows[cont][6].ToString());
                enca.Detalle.Add(Deta);
            }
            Reportes.Inventario inve = new Reportes.Inventario();
            inve.Detalle = enca.Detalle;
            inve.Show();
        }

        public void Ganacia(string fechai,string fechaf)
        {
            Reportes.DiarioEnc enc = new Reportes.DiarioEnc();
            enc.fecha = fechai;
            enc.F2 = fechaf;
            fechai +=  " 00:00:00";
            fechaf +=  " 23:59:59";
            string consulta = "SELECT v.id_venta, vd.id_detalle,Date_format(v.FECHA_H,'%d/%m/%Y') ,COUNT(vd.ID_DETALLE ),SUM((vd.cantidad*vd.precio)),v.Descu, (SUM(((vd.cantidad*vd.precio)-(vd.cantidad*p.precio_c)))-v.descu) AS ganancia FROM venta v " +
                               "INNER JOIN detalle vd ON vd.ID_VENTA = v.ID_VENTA " +
                               "INNER JOIN producto p on vd.ID_PROD = p.ID_PROD " +
                               "WHERE v.FECHA_H >= '" + fechai + "' AND v.FECHA_H <= '" + fechaf + "' " +
                               "GROUP BY v.ID_VENTA";
            DataTable datos = new DataTable();
            datos = buscar(consulta);
            
            int cont, cant=datos .Rows.Count;
            for (cont=0;cont<cant;cont++)
            {
                Reportes.DiarioDet detalle = new Reportes.DiarioDet();
                detalle.orden = int.Parse (datos.Rows[cont][0].ToString());
                //Productos vendidos
                detalle.cantidad= int.Parse(datos.Rows[cont][3].ToString());
                //total Vendido
                detalle .precio = decimal.Parse(datos.Rows[cont][4].ToString())-decimal.Parse(datos.Rows[cont][5].ToString());
                //Ganacia
                detalle.subtotal = decimal.Parse(datos.Rows[cont][6].ToString());
                string f = datos.Rows[cont][2].ToString();
                //DateTime fecha = DateTime.Parse(datos.Rows[cont][2].ToString());
                detalle.marca = f;
                enc.Detalle.Add(detalle);
           }
            Reportes.Ganancia gan = new Reportes.Ganancia();
            gan.Encabezado.Add(enc);
            gan.Detalle = enc.Detalle;
            gan.Show();
        }

        public DataTable TodProd()
        {
            string consulta;
            consulta = "Select id_prod,Concat(Nombre,' ',Marca,' ',Descripcion) as Nombre from producto";
            return buscar(consulta);
        }

        public DataTable Prodbusque(string busca)
        {
            string consulta;
            consulta = "Select id_prod,Concat(Nombre,' ',Marca,' ',Descripcion) as Nombre "+
                       "from producto "+
                       "Where Nombre like '%"+busca+"%' or marca like '%"+busca+"%' or descripcion like '%"+busca+"%'" ;
            return buscar(consulta);
        }

        public void MasVen(string fechai, string fechaf)
        {
            fechai += " 00:00:00";
            fechaf += " 23:59:59";
            DataTable datos = new DataTable();
            int cant, cont;

            string consulta="SELECT p.ID_PROD,p.NOMBRE,p.MARCA,p.DESCRIPCION, COUNT(vd.ID_PROD) AS Total from producto p " +
                            "INNER JOIN detalle vd ON vd.ID_PROD = p.ID_PROD "+
                            "INNER JOIN venta v ON v.ID_VENTA = vd.ID_VENTA "+
                            "WHERE v.FECHA_H >= '"+fechai+"' AND v.FECHA_H <= '"+fechaf+"'" +
                            "GROUP BY p.ID_PROD " +
                            "ORDER BY Total desc";
            datos = buscar(consulta);
            cant = datos.Rows.Count;
            Reportes.DiarioEnc titulo = new Reportes.DiarioEnc();
            titulo.fecha = fechai;
            titulo.F2 = fechaf;
            if (cant > 0) { 
            for (cont = 0; cont <= 9; cont++)
            {
                Reportes.Diezmas Grafi = new Reportes.Diezmas();
                Grafi.cantidad = int.Parse(datos.Rows[cont][4].ToString());
                
                Grafi.Producto =char.ConvertFromUtf32(cont+65)+   ") " +datos.Rows[cont][1].ToString()+" "+ datos.Rows[cont][2].ToString()+" "+ datos.Rows[cont][3].ToString();
                titulo.Diez.Add(Grafi);
            }
            }
            for (cont = 0; cont < cant; cont++)
            {
                Reportes.DiarioDet detall = new Reportes.DiarioDet();
                detall.codigo = datos.Rows[cont][0].ToString();
                detall.producto= datos.Rows[cont][1].ToString();
                detall.marca= datos.Rows[cont][2].ToString();
                detall.desc= datos.Rows[cont][3].ToString();
                detall.cantidad= int.Parse(datos.Rows[cont][4].ToString());
                titulo.Detalle.Add(detall);
            }
            Reportes.Masven Mas = new Reportes.Masven();
            Mas.Titu.Add(titulo);
            Mas.Gra = titulo.Diez;
            Mas.Detalle = titulo.Detalle;
            Mas.Show();
        }

        public bool caducado(string cod,string fecha)
        {
            string consulta,fechamod;
            int canti;
            DataTable datos = new DataTable();
            fechamod = fecha + " 00:00:00";
            consulta = "SELECT COUNT(*) FROM producto p "+
                       "WHERE p.FECHA_CAD <= '"+fechamod+"' AND p.ID_PROD = '"+cod+"'";
            datos = buscar(consulta);
            canti = Int32.Parse(datos.Rows[0][0].ToString());
            if (canti > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

        public int cantidadcaduca()
        {
            string consulta, fecha;
            int cantidad;
            DateTime fechaini = DateTime.Now;
            DataTable datos = new DataTable();
            fechaini = fechaini.AddDays(31);
            fecha = fechaini.ToString("yyyy/MM/dd");
            fecha = fecha + " 00:00:00";
            consulta = "SELECT COUNT(*) FROM producto p " +
                       "WHERE p.FECHA_CAD <= '" + fecha + "'";
            datos = buscar(consulta);
            cantidad = Int32.Parse(datos.Rows[0][0].ToString());
            return cantidad;
        }


        public int cantidadbaja()
        {
            string consulta, fecha;
            int cantidad;
            DataTable datos = new DataTable();
            consulta = "SELECT COUNT(*) FROM producto p " +
                      "WHERE p.Cantidad <= " + 5;
            datos = buscar(consulta);
            cantidad = Int32.Parse(datos.Rows[0][0].ToString());
            return cantidad;

        }

        public bool Cantibaja(string cod)
        {
            string consulta;
            int canti;
            DataTable datos = new DataTable();
          
            consulta = "SELECT COUNT(*) FROM producto p " +
                       "WHERE p.Cantidad <= 5 AND p.ID_PROD = '" + cod + "'";
            datos = buscar(consulta);
            canti = Int32.Parse(datos.Rows[0][0].ToString());
            if (canti > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
             public DataTable BuscaRapProd(string nom)
        {
            string consulta;
            consulta = "Select id_prod as Codigo,Nombre,Descripcion,Marca,precio_c as Costo,precio_v as Precio,Cantidad,Date_format(fecha_cad,'%d-%m-%y')as Caducidad, pack as Paquete,p_pack as PrecioxPaquete " +
                        "from producto " +
                        "where nombre like'%" + nom + "%' or marca like '%" + nom + "%' or descripcion like '%" + nom + "%'";
            return buscar(consulta);
        }
    

       
    }
}

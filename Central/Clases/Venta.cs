using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Central.Clases
{
    class Venta
    {
        Conexion conect = new Conexion();
        Producto prod = new Producto();
        Usuario usu = new Usuario();
        Caja caj = new Caja();
        Cajon Regi = new Cajon();       
       
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
                MessageBox.Show(ex.ToString()+"\n"+consulta);
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
                MessageBox.Show(consulta +"\n" +ex.ToString());
                return false;
            }
            return true;
        }
        #endregion


        #region "Datos"
      public  int idventa()
        {
            DataTable datos = new DataTable();
            int val;
            string consulta = "select max(id_venta) from venta";
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
            string consulta = "select max(id_detalle) from detalle";
            datos = buscar(consulta);
            if (datos.Rows[0][0] == DBNull.Value)
            { val = 0; }
            else { val = Int32.Parse(datos.Rows[0][0].ToString()); }
            return val;
        }

        public DataTable titulos(string venta)
        {
            string consulta= "SELECT ca.nombre, Date_format(v.fecha_h,'%d/%m/%Y') as fecha, Date_format(v.fecha_h,'%H:%i:%s') as hora, CLI.Nombre as CLIENTE,v.cliente as nom, v.nit FROM cajero ca " +
                             "INNER JOIN venta v ON v.ID_CAJERO = ca.ID_CAJERO "+
                             "INNER JOIN CLIENTES CLI ON CLI.ID_CLI = V.ID_CLI "+
                             "WHERE v.ID_VENTA ="+venta;
            return buscar(consulta);
        }

        public DataTable VentasxCli(string cli)
        {
            string consulta = "SELECT * FROM venta v " +
                              "INNER JOIN credito cre ON cre.id_venta = v.ID_VENTA "+
                              "WHERE WHERE cre.ID_CLI ="+cli;
            return buscar(consulta);
        }


        public DataTable DetalleOneSaleDate(string idv) {
            string consulta;
            DataTable datos = new DataTable();
       
            consulta = "SELECT v.ID_VENTA AS venta , p.id_prod AS idP, p.nombre AS nombre,p.descripcion as descr, d.cantidad, d.precio, (d.cantidad*d.precio), SUM((d.cantidad*d.precio)),v.descu FROM producto p  " +
                       "INNER JOIN detalle d ON d.ID_PROD = p.id_prod " +
                       "INNER JOIN venta v ON v.ID_VENTA = d.ID_VENTA " +
                        "WHERE v.ID_VENTA= " + idv + " " +
                       "GROUP BY d.ID_DETALLE,v.ID_VENTA " +
                       "ORDER BY v.ID_VENTA";
            return  buscar(consulta);
        }

        public DataTable VentasxDate(string fecha)
        {
            string FechI, FechaF, consulta;
            DataTable datos = new DataTable();
            FechI = fecha + " 00:00:00";
            FechaF = fecha + " 23:59:59";
            consulta = "SELECT * from venta as v " +
                "WHERE v.FECHA_H >= '" + FechI + "' AND v.FECHA_H <= '" + FechaF + "' and Estado='Activa'";
            return buscar(consulta);
        }



        #endregion

        public int generarv(DataTable datos, decimal efect, string cliente, string cajero, string descu,string clinom,string nit ,[Optional]string proces)
        {
            int resp;
            int codv = idventa()+1;
            string fecha = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            string consulta;
            consulta = "insert into  venta(id_venta,id_cli,id_cajero,Fecha_H,descu,estado,cliente,nit) " +
                      $"values ({codv},{cliente},{cajero},'{fecha}',{descu},'Activa','{clinom}','{nit}')";
            if (consulta_gen(consulta))
            {
                if (generardet(datos, codv, efect, cajero, descu, proces))
                {
                    resp= codv;
                }
                else
                {

                  resp= 0;
                }
                            }
            else
            {
                resp = 0;
            }
            return resp;

            
        }

        public bool generardet(DataTable datos, int venta,decimal efect,string cajero,string descu, [Optional]string proces)
        {
            
            int cant= datos.Rows.Count,cont;
            decimal total = 0;
            for (cont = 0; cont < cant; cont++)
            {
                int id = idetalle() + 1;
                
                string consulta;
                string idprod, precio, canti, subT;
                idprod = datos.Rows[cont][0].ToString();
                precio = datos.Rows[cont][4].ToString();
                canti = datos.Rows[cont][5].ToString();
                subT = datos.Rows[cont][6].ToString();
                              consulta = "Insert into detalle(id_detalle,id_prod,id_venta, cantidad, precio, total) "+
                            "values ("+id+",'"+idprod + "'," +venta+","+ canti+","+precio+"," +subT +")";

                if (!consulta_gen(consulta) || !prod.DescontProd (idprod ,canti))
                { return false; }
                total += decimal.Parse(subT);
            }
            total -= decimal.Parse(descu);
            string atendio;
            DataTable usur = new DataTable();
            usur = usu.buscusu(cajero);
            atendio = usur.Rows[0][0].ToString();
            if (total > efect)
            {

            }
            if (efect >= total)
            {
                string[] opera = { "Ingreso", "Venta No " + venta + ",Operado por " + atendio, total.ToString(), DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"), cajero };
                caj.ingreope(opera);
            }
            else if (efect > 0)
            {

            }
               
            if (MessageBox.Show("¿Desea imprimir comprobante de venta?", "¿Imprimir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { PrintTicket(venta, datos, efect, descu);
                if (proces.Equals("Cred")) PrintTicket(venta, datos, efect, descu);

            }
            else { Regi.AbreCajon();
                Regi.ImprimirTicket();
            }
            return true;
        }

        public bool anularSale(string idv,string idvende, string vendenom,string total)
        {
            try
            {
                string updvent = $"Update venta set estado='Anulada {DateTime.Now.ToString("dd/MM/yyyy")}, por {vendenom}' "+
                                    $"Where id_venta={idv}";
                string descrip = $"Se anulo la venta numero {idv} por {vendenom}";
                return (consulta_gen(updvent) && devolallprod(idv) && addcaja(idvende,descrip,total));
            }
            catch (Exception)
            {
                return false;
            }
        
        }

        private bool addcaja(string idven,string descrip,string tot)
        {
            string fecha = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            string ope = "Egreso";
            string monto = tot;
            string desc =descrip;
            string cajero = idven;
            string[] datos = { ope, desc, monto, fecha,cajero };
            return (caj.ingreope(datos));
           
   
        }

        private bool devolallprod(string idv)
        {
            DataTable datos = new DataTable();
            string consulta = $"Select id_prod, cantidad from detalle where id_venta={idv}";
            datos = buscar(consulta);
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                if (!prod.ReponProd($"{datos.Rows[i][0]}", $"{datos.Rows[i][1]}"))
                {
                    return false;
                }
            }
            return true;
        }

        public void PrintTicket(int venta, DataTable datos,decimal efect,string descu)
        {
            int cant, cont;
            decimal Neto;
            DataTable superior = new DataTable();
            Reportes.FacturaEnc Enca = new Reportes.FacturaEnc();
            superior = titulos(venta.ToString());
            Enca.ticket = venta;
            Enca.cajero = superior.Rows[0][0].ToString();
            string fetch =superior.Rows[0][1].ToString();
            Enca.fecha = superior.Rows[0][1].ToString();
            Enca.hora  = superior.Rows[0][2].ToString();
            Enca.efectivo =  efect.ToString ();
            Enca.cliente = superior.Rows[0][4].ToString();
            Enca.nit=superior.Rows[0][5].ToString();
            cant = datos.Rows.Count;
            decimal total=0;
            for (cont=0;cont<cant;cont++)
            {
                Reportes.FacturaDet detalle = new Reportes.FacturaDet();
                string prod = datos.Rows[cont][1].ToString() + ", "+ datos.Rows[cont][3].ToString() + ", " + datos.Rows[cont][2].ToString();
                detalle.produ = prod;
                detalle.cant = Int32.Parse(datos .Rows [cont][5].ToString ());
                detalle.pre = datos.Rows[cont][4].ToString();
                detalle.subt = datos.Rows[cont][6].ToString();
                Enca.Detall.Add(detalle);
                total +=decimal .Parse(datos.Rows[cont][6].ToString());
            }
            Neto = decimal.Parse(total.ToString()) - decimal.Parse(descu);
            Enca.total = total.ToString();
            Enca.descu = descu.ToString();
            decimal camb = 0;
            camb = efect - Neto;
            if (camb <= 0) camb = 0;
            Enca.cambio = Convert .ToString (camb);
            Reportes.Ticket ticket = new Reportes.Ticket();
            ticket.Encabezado.Add(Enca);
            ticket.Detalle = Enca.Detall;
            ticket.total = cant;
            ticket.Show();
          ticket.Close();


        }

        public decimal TotalVenta(string venta)
        {
            decimal total;
            string consulta = "SELECT SUM(d.TOTAL) AS total "+
                              "FROM detalle d "+
                              "INNER JOIN venta v ON v.ID_VENTA = d.ID_VENTA "+
                              "WHERE v.ID_VENTA ="+venta;
            DataTable datos = new DataTable();
            datos=buscar(consulta);
            total = decimal.Parse(datos.Rows[0][0].ToString());
            return total;
        }

     }
}

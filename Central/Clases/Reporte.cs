﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Central.Clases
{
    class Reporte
    {
        Conexion conect = new Conexion();
        CreditoClase cred = new CreditoClase();
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

        public void RepD(string fecha)
        {
            Reportes.DiarioEnc enc = new Reportes.DiarioEnc();
            int cant, cont;
            string FechI, FechaF, consulta;
            DataTable datos = new DataTable();
            FechI = fecha+" 00:00:00";
            FechaF = fecha + " 23:59:59";
            consulta = "SELECT v.ID_VENTA AS venta , p.id_prod AS idP, p.nombre AS nombre,p.descripcion as descr, d.cantidad, d.precio, (d.cantidad*d.precio), SUM((d.cantidad*d.precio)),v.descu FROM producto p  " +
                       "INNER JOIN detalle d ON d.ID_PROD = p.id_prod "+
                       "INNER JOIN venta v ON v.ID_VENTA = d.ID_VENTA "+
                       "WHERE v.FECHA_H >= '"+FechI+"' AND v.FECHA_H <= '"+FechaF+"' "+
                       "GROUP BY d.ID_DETALLE,v.ID_VENTA "+
                       "ORDER BY v.ID_VENTA";
            datos = buscar(consulta);
            cant = datos.Rows.Count;
            enc.fecha = fecha;
            enc.descuento = decimal.Parse(datos.Rows[0][8].ToString());
            for (cont = 0; cont < cant; cont++)
            {
                Reportes.DiarioDet Det = new Reportes.DiarioDet();
                Det.orden = cont + 1;
                Det.venta =Int32.Parse(datos.Rows[cont][0].ToString());
                Det.codigo = datos.Rows[cont][1].ToString();
                Det.producto = datos.Rows[cont][2].ToString();
                Det.desc = datos.Rows[cont][3].ToString();
                Det.cantidad = Int32.Parse(datos.Rows[cont][4].ToString());
                Det.precio = decimal.Parse(datos.Rows[cont][5].ToString());
                Det.subtotal = decimal.Parse(datos.Rows[cont][6].ToString());
                enc.Detalle.Add(Det);
            }
            Reportes.Diario repo = new Reportes.Diario();
            repo.Enca.Add(enc);
            repo.Deta = enc.Detalle;
            repo.Show();
        }

        public void Vendidos(string fechai, string fechaf)
        {
            DataTable datos = new DataTable();
            fechai = fechai + " 00:00:00";
            fechaf = fechaf + " 23:59:59";
            int cant, cont;
            string consulta = "SELECT v.ID_VENTA ,Date_format(v.FECHA_H,'%d/%m/%y') as fecha,SUM(vd.TOTAL) AS Total " +
                               "FROM venta v " +
                               "INNER JOIN detalle vd ON vd.ID_VENTA = v.ID_VENTA " +
                               "WHERE v.FECHA_H >= '" + fechai + "' AND v.FECHA_H <= '" + fechaf + "' " +
                               "GROUP BY CAST(v.FECHA_H AS DATE)";

            datos = buscar(consulta);
            cant = datos.Rows.Count;
            Reportes.DiarioEnc titulo = new Reportes.DiarioEnc();
            titulo.fecha = fechai;
            titulo.F2 = fechaf; 
            for (cont = 0; cont < cant; cont++)
            {
                //DateTime fecha= DateTime.Parse(datos.Rows[cont][1].ToString());
                Reportes.DiarioDet Detalle = new Reportes.DiarioDet();
                Detalle.orden = cont + 1;
                Detalle.venta = int.Parse(datos.Rows[cont][0].ToString());
                Detalle.desc = datos.Rows[cont][1].ToString();
                Detalle.subtotal = decimal.Parse(datos.Rows[cont][2].ToString());
                titulo.Detalle.Add(Detalle);
            }
            Reportes.Vendidos vende = new Reportes.Vendidos();
            vende.Encabezado.Add(titulo);
            vende.Detalle = titulo.Detalle;
            vende.Show();
        }

        public void Totales(string fechai, string fechaf)
        {
            DataTable datos = new DataTable();
            fechai = fechai + " 00:00:00";
            fechaf = fechaf + " 23:59:59";
            int cant, cont;
            string consulta = "SELECT Date_format(v.FECHA_H,'%d/%m/%y') as fecha,(SUM((vd.cantidad*vd.precio))-v.Descu),v.Descu, (SUM(((vd.cantidad*vd.precio)-(vd.cantidad*p.precio_c)))-v.descu) AS ganancia " +
                            "FROM venta v " +
                            "INNER JOIN detalle vd ON vd.ID_VENTA = v.ID_VENTA " +
                            "INNER JOIN producto p on vd.ID_PROD = p.ID_PROD " +
                            "WHERE v.FECHA_H >= '"+fechai+"' AND v.FECHA_H <= '"+fechaf+"' " +
                            "GROUP BY CAST(v.FECHA_H AS DATE)";
            datos = buscar(consulta);
            cant = datos.Rows.Count;
            Reportes.DiarioEnc titulo = new Reportes.DiarioEnc();
            titulo.fecha = fechai;
            titulo.F2 = fechaf;
            for (cont = 0; cont < cant; cont++)
            {
                //DateTime fechas = DateTime.Parse(datos.Rows[cont][0].ToString());
                Reportes.DiarioDet Detalle = new Reportes.DiarioDet();
                Detalle.orden = cont + 1;
                //Marca = fecha
                Detalle.marca = datos.Rows[cont][0].ToString();//fechas.ToString("dd/MM/yyyy");
                //Vendido = Subtotal
                Detalle.subtotal = decimal.Parse(datos.Rows[cont][1].ToString());
                //Ganacia= precio
                Detalle.precio = decimal.Parse(datos.Rows[cont][3].ToString());
                //sin ganacia= desc
                Detalle.desc = (Detalle.subtotal - Detalle.precio).ToString();
                titulo.Detalle.Add(Detalle);
            }
            Reportes.Totales Total = new Reportes.Totales();
            Total.Encabezado.Add(titulo);
            Total.Detalle = titulo.Detalle;
            Total.Show();

        }

        public void VentaCli(string fechai, string fechaf)
        {
            Reportes.DiarioEnc enc = new Reportes.DiarioEnc();
            int cant, cont;
            string FechI, FechaF, consulta;
            DataTable datos = new DataTable();
            FechI = fechai + " 00:00:00";
            FechaF = fechaf + " 23:59:59";
            consulta = "SELECT v.ID_VENTA AS venta , p.id_prod AS idP, p.nombre AS nombre,p.descripcion as descr, d.cantidad, d.precio, (d.cantidad*d.precio), SUM((d.cantidad*d.precio)),v.descu FROM producto p,Date_format(v.FECHA_H,'%d/%m/%y') as Fecha  " +
                       "INNER JOIN detalle d ON d.ID_PROD = p.id_prod " +
                       "INNER JOIN venta v ON v.ID_VENTA = d.ID_VENTA " +
                       "WHERE v.FECHA_H >= '" + FechI + "' AND v.FECHA_H <= '" + FechaF + "' " +
                       "GROUP BY d.ID_DETALLE,v.ID_VENTA " +
                       "ORDER BY v.ID_VENTA";
            datos = buscar(consulta);
            cant = datos.Rows.Count;
          //  enc.fecha = fecha;
            enc.descuento = decimal.Parse(datos.Rows[0][8].ToString());
            for (cont = 0; cont < cant; cont++)
            {
                Reportes.DiarioDet Det = new Reportes.DiarioDet();
                Det.orden = cont + 1;
                Det.venta = Int32.Parse(datos.Rows[cont][0].ToString());
                Det.codigo = datos.Rows[cont][1].ToString();
                Det.producto = datos.Rows[cont][2].ToString();
                Det.desc = datos.Rows[cont][3].ToString();
                Det.cantidad = Int32.Parse(datos.Rows[cont][4].ToString());
                Det.precio = decimal.Parse(datos.Rows[cont][5].ToString());
                Det.subtotal = decimal.Parse(datos.Rows[cont][6].ToString());
                
                enc.Detalle.Add(Det);
            }
            Reportes.Diario repo = new Reportes.Diario();
            repo.Enca.Add(enc);
            repo.Deta = enc.Detalle;
            repo.Show();
        }

        public void Creditos(string fechai,string fechaf)
        {
            Reportes.CrediEnc Enca = new Reportes.CrediEnc();
            string FechaI, FechaF, consulta;
            int cont;
            decimal totalcred;
            DateTime f1, f2;
            f1 = DateTime.Parse(fechai);
            f2 = DateTime.Parse(fechaf);
            FechaI = fechai + " 00:00:00";
            FechaF = fechaf + " 23:59:59";
            totalcred = cred.TotalCredi(fechai, fechaf);
            DataTable datos = new DataTable();
            consulta = "SELECT c.id_cred,cli.nombre,c.TOTAL ,Date_format(pag.fecha,'%d/%m/%y') as fecha,pag.monto "+
                       "FROM credito c "+
                       "inner JOIN clientes cli ON c.ID_CLI = cli.ID_CLI "+
                       "INNER JOIN pago pag ON pag.id_cred = c.ID_CRED "+
                       "Inner join venta v on v.id_venta=c.id_venta "+
                       "where v.Fecha_h>='"+fechai+"' and v.fecha_h<='" +fechaf+"' ";
            datos = buscar(consulta);
            Enca.Titulo = "Reporte de creditos";
            Enca.fecha1 = f1.ToString("dd/MM/yyyy");
            Enca.fecha2 = f2.ToString("dd/MM/yyyy");
            Enca.TotalCred = totalcred;
            for (cont = 0; cont < datos.Rows.Count; cont++)
            {
                Reportes.CrediDet deta = new Reportes.CrediDet();
                deta.orden = int.Parse(datos.Rows[cont][0].ToString());
                deta.Cliente = datos.Rows[cont][1].ToString();
                deta.Monto = decimal.Parse(datos.Rows[cont][2].ToString());
                deta.Saldo = 0;
                deta.fecha = datos.Rows[cont][3].ToString();
                deta.pago = decimal.Parse(datos.Rows[cont][4].ToString());
                Enca.Detalle.Add(deta);
            }
            Reportes.Creditos credi = new Reportes.Creditos();
            credi.Enca.Add(Enca);
            credi.Deta = Enca.Detalle;
            credi.Show();
        }
    }
}

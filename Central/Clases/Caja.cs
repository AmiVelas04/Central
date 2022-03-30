using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using MySql.Data.MySqlClient;

namespace Central.Clases
{

    class Caja
    {
        Conexion conect= new Conexion();
       
        public decimal ingreso { get; set; }
        public decimal egreso { get; set; }
        public decimal total { get; set; }
        private DateTime fecha;
        private string Cajero;
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

        private int idope()
        {
            DataTable datos = new DataTable();
            int val;
            string consulta = "select max(id_ope) from caja";
            datos = buscar(consulta);
            if (datos.Rows[0][0] == DBNull.Value)
            { val = 0; }
            else { val = Int32.Parse(datos.Rows[0][0].ToString()); }
            return val;
        }
        public bool ingreope(string [] datos)
        {
            int cod = idope() + 1;
            string consulta = "insert into caja(id_ope,operacion,descripcion,monto,fecha,estado,id_caje) "+
                              "Values("+cod+",'" + datos[0]+ "','"+datos[1]+ "',"+datos[2]+",'"+datos[3] +"','Activo',"+datos[4]+")";
            return consulta_gen(consulta);
        }


       public DataTable buscaropes(string fecha)
        {
            string consulta;
            string fech1,fech2;
            fech1 = fecha + " 00:00:00";
            fech2 = fecha + " 23:59:59";

            consulta = "Select operacion, Descripcion,monto from caja "+
                "where fecha>='"+ fech1 + "' and fecha<='"+ fech2 + "' and estado ='Activo'";
            return buscar(consulta);
        }

        public DataTable BuscarOpeVende(string idvende, string fecha)
        {
            string consulta;
            string fech1, fech2;
            fech1 = fecha + " 00:00:00";
            fech2 = fecha + " 23:59:59";

            consulta = "Select operacion, Descripcion,monto from caja " +
                "where fecha>='" + fech1 + "' and fecha<='" + fech2 + "' and estado ='Activo' and id_caje="+idvende;
            return buscar(consulta);
        }

        public decimal ingre(string fecha, string idven)
        {
            string consulta;
            string fech1, fech2;
            fech1 = fecha + " 00:00:00";
            fech2 = fecha + " 23:59:59";
            DataTable datos = new DataTable();
            if (idven.Equals("0"))
            {
                consulta = "Select Sum(monto) from caja " +
                   "where fecha>='" + fech1 + "' and fecha<='" + fech2 + "' and operacion = 'Ingreso' and estado ='Activo'";
            }
            else {
                consulta = "Select Sum(monto) from caja " +
             "where fecha>='" + fech1 + "' and fecha<='" + fech2 + "' and operacion = 'Ingreso' and estado ='Activo' and id_caje="+idven;
            }
            
            datos = buscar(consulta);
            if (datos.Rows[0][0] != DBNull.Value)
                return decimal.Parse(datos.Rows[0][0].ToString ());
            return 0;
        }
        public  decimal egres(string fecha,string idven)
        {
            string consulta;
            string fech1, fech2;
            fech1 = fecha + " 00:00:00";
            fech2 = fecha + " 23:59:59";
            DataTable datos = new DataTable();
            if (idven.Equals("0"))
            {
                consulta = "Select Sum(monto) from caja " +
                "where fecha>='" + fech1 + "' and fecha<='" + fech2 + "' and operacion = 'Egreso' and estado ='Activo'";
            }
            else
            {
                consulta = "Select Sum(monto) from caja " +
                "where fecha>='" + fech1 + "' and fecha<='" + fech2 + "' and operacion = 'Egreso' and estado ='Activo' and id_caje="+idven;
            }
              
            datos = buscar(consulta);
            if (datos.Rows[0][0] != DBNull.Value)
                return decimal.Parse(datos.Rows[0][0].ToString());
            return 0;
        }


        //Ipresion de ticket de caja
        
       
        void pd_printpage(object sender, PrintPageEventArgs ev)
        {
            //string Esc = "\u001B";
            //string Gs = "\u001D";
            
            Graphics g = ev.Graphics;
            g.DrawRectangle(Pens.Black, 1, 1, 280,325 );
            Font fBody = new Font("Lucida Console", 9, FontStyle.Regular );
            Font fBodyN = new Font("Lucida Console", 9, FontStyle.Bold);
            Font fBodyT = new Font("Lucida Console", 12, FontStyle.Bold);

            SolidBrush sb = new SolidBrush(Color.Black);
            g.DrawString("",fBody ,sb,10,10);
            g.DrawString("Ticket de cierre de caja. cajero: "+Cajero, fBodyT, sb, 10, 30);
            g.DrawString(fecha.ToString("dd/MM/yyyy HH:mm:ss"), fBody, sb, 10, 50);
            
            g.DrawString("Realizó cierre: " + Formularios.Main.nombre , fBody, sb, 10, 90);
            g.DrawString("Ingresos:      Q." + ingreso, fBody, sb, 10, 140);
            g.DrawString("Egresos:       Q." + egreso, fBody, sb, 10, 160);
            g.DrawString("__________________________________", fBody, sb, 10, 165);
            g.DrawString("Total de caja: Q." + (ingreso -egreso), fBodyN, sb, 10, 180);
                              
            g.Dispose();
            

        }

        public void imprimir(DateTime fechaCierre,string caje)
        {
            fecha = fechaCierre;
            Cajero = caje;
            PrintDocument pd = new PrintDocument();
            PaperSize ps = new PaperSize("", 312, 340);
            pd.PrintPage += new PrintPageEventHandler(pd_printpage);
            pd.PrinterSettings.PrinterName = ImpresoraPred();

            pd.DefaultPageSettings.Margins.Left = 0;
            pd.DefaultPageSettings.Margins.Right = 0;
            pd.DefaultPageSettings.Margins.Top = 0;
            pd.DefaultPageSettings.Margins.Bottom = 0;
            pd.DefaultPageSettings.PaperSize = ps;
           
            if (!pd.PrinterSettings.IsValid)
            {
                throw new Exception(String.Format("No se puede encontrar la impresora \"{0}\".", ImpresoraPred()));

            }
            else
            {
               
                pd.Print();
               
            }
           
        }

        private string ImpresoraPred()
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

    }
}



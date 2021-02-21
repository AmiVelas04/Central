using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Drawing.Printing;


namespace Central.Formularios
{
    public partial class Caja : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern SafeFileHandle CreateFile(string lpFileName, FileAccess swDesireAccess, uint dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsandAttributes, IntPtr hTemplateFile);

        StringBuilder linea = new StringBuilder();


        Clases.Caja caj = new Clases.Caja();
        public Caja()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string fecha = DtpFecha.Value.ToString("yyyy/MM/dd");
            DataTable datos = new DataTable();
            datos = caj.buscaropes(fecha);
            
            DgvOpe.DataSource = datos;
            total();

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            prepararcaj ();
        }
        private void prepararcaj()
        {
            string fecha = DtpFecha.Value.ToString ("yyyy/MM/dd hh:mm:ss");
            string ope= CboOpe .Text ;
            string monto=TxtMonto.Text;
            string desc=TxtDesc .Text ;
            string cajero = Main.id.ToString ();
            string [] datos={ope,desc,monto,fecha,"Activo" };
            if (caj.ingreope(datos))
            { MessageBox.Show("Ingreso de operacion correcta"); }
            else
            { MessageBox.Show("Error en el ingreso de operacion"); }
            total();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void Caja_Load(object sender, EventArgs e)
        {
            CboOpe.Items.Add("Ingreso");
            CboOpe.Items.Add("Egreso");
            CboOpe.SelectedIndex = 0;
            total();
        }

        private  void total()
        {
            decimal total;
            decimal ingre;
            decimal egre;
            ingre = caj.ingre(DtpFecha.Value.ToString ("yyyy/MM/dd"));
            egre = caj.egres(DtpFecha.Value.ToString("yyyy/MM/dd"));
            total = ingre - egre;
            TxtEgre.Text = egre.ToString ();
            TxtIngre.Text = ingre.ToString();
            TxtTotal.Text = total.ToString();
        }

         
        private static string ImpresoraPred()
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
        private void button1_Click(object sender, EventArgs e)
        {   caj.ingreso = caj.ingre(DtpFecha.Value.ToString("yyyy/MM/dd"));
            caj .egreso = caj.egres(DtpFecha.Value.ToString("yyyy/MM/dd"));
            caj.imprimir(DtpFecha .Value);
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            Clases.Cajon caj = new Clases.Cajon();
            caj.AbreCajon();
            caj.ImprimirTicket();

        }
    }
}

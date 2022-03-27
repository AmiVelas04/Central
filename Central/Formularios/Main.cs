using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Central.Formularios
{
    public partial class Main : Form
    {
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public static string nivel { get; set; }
        public static string nombre { get; set; }
        public static int id { get; set; }

  
        public Main()
        {
            InitializeComponent();
        }
        private void abrir_form(Object formhijo)
        {
            if (this.PanCentral.Controls.Count >= 1)
            {
                this.PanCentral.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanCentral.Controls.Add(fh);
            this.PanCentral.Tag = fh;
            fh.Show();
           
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            // abrir_form(new Ventas());
            PanCentral.Controls.Clear();
            Ventas formul = new Ventas();
            formul.TopLevel = false;
            PanCentral.Controls.Add(formul);
            PanCentral.Tag = formul;
            formul.idusu = id.ToString();
            formul.nivelusu = nivel.ToString();
            formul.nombreU = nombre;
            formul.Show();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            abrir_form(new Productos ());
        }

        private void BtnUsu_Click(object sender, EventArgs e)
        {
            abrir_form(new Usuarios());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LblUsu.Text = "Usuario: " + nombre;
            if (nivel == "3")
            {
                //BtnCaja.Visible = false;
                // BtnProductos.Visible = false;
                BtnUsu.Visible = false;
                BtnREportes.Visible = false;
                BtnCap.Visible = false;
            }
       

            if (id.ToString() == "5" || id.ToString()=="4")
            {
                BtnProductos.Visible = true;
              //  BtnCaja.Visible = true;
            }

        }

        private void BtnREportes_Click(object sender, EventArgs e)
        {
            abrir_form(new Reportes());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            abrir_form(new Caja());
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanSup_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCap_Click(object sender, EventArgs e)
        {
            Respaldo resp = new Respaldo();
            resp.Show();
        }

        private void BtnCli_Click(object sender, EventArgs e)
        {
            abrir_form(new Cliente());
        }

        private void BtnCred_Click(object sender, EventArgs e)
        {
            //abrir_form(new Credito());
            PanCentral.Controls.Clear();
            Credito formul = new Credito();
            formul.TopLevel = false;
            PanCentral.Controls.Add(formul);
            PanCentral.Tag = formul;
            formul.idvende = id.ToString();
            formul.Cajero = nombre;
            formul.Show();
        }
    }
}

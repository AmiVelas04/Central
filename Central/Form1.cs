using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Central
{
    public partial class Form1 : Form
    {
       


        public Form1()
        {
            InitializeComponent();
        }

        private void Tmr1_Tick(object sender, EventArgs e)
        {
            Tmr1.Enabled = false;
            this.Hide();
            Formularios.Login Inicio = new Formularios.Login();
            Inicio.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PanCent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

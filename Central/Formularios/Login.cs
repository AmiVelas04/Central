using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Central.Formularios
{
    public partial class Login : Form
    {
        Clases.Login log = new Clases.Login();
        
        public Login()
        {
            InitializeComponent();
        }

        private void limpiar()
        { TxtPass.Clear();
            TxtUsu.Clear();
        }
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            loguear();


        }

        private void loguear()
        {
            string nom, pass;
            nom = TxtUsu.Text;
            pass = TxtPass.Text;
            DataTable datos = new DataTable();
            datos = log.inicio(nom, pass);
            if (datos.Rows.Count > 0)
            {

                Main Menu = new Main();
                MessageBox.Show("Ingreso correcto", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Main.id = int.Parse(datos.Rows[0][0].ToString());
                Main.nombre = datos.Rows[0][1].ToString();
                Main.nivel = datos.Rows[0][2].ToString();
               
                Menu.Show();
            }
            else
            {
                MessageBox.Show("Error de datos, intentelo de nuevo");
            }
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                loguear();
            }
        }
    }
}

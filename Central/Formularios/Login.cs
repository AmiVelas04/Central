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
        Clases.Producto prod = new Clases.Producto();
        
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
            //log.probarconn();
        }

        private void loguear()
        {
            string nom, pass;
            nom = TxtUsu.Text;
            pass = TxtPass.Text;
            DataTable datos = log.inicio(nom, pass); 
      
            if (datos.Rows.Count > 0)
            {

                if (datos.Rows[0][3].ToString().Equals("Activo"))
                {
                    Main Menu = new Main();
                    //  MessageBox.Show("Ingreso correcto", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    // MessageBox.Show("¡Existen  " + prod.cantidadcaduca().ToString() + " producto(s) que caducarán en 30 días o menos! \n¡Verifique listado de productos!","Productos que caducan",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    Main.id = int.Parse(datos.Rows[0][0].ToString());
                    Main.nombre = datos.Rows[0][1].ToString();
                    Main.nivel = datos.Rows[0][2].ToString();

                    Menu.Show();
                }
                else
                {
                    MessageBox.Show("El usuario se encuentra inactivo, solicite activacion a un usuario administrador", "Usuario inactivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
         
            }
            else
            {
                MessageBox.Show("El usuario o contrasenia son icorrectos, intente de nuevo", "intentelo de nuevo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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

        private void Login_Load(object sender, EventArgs e)
        {
            TxtUsu.Focus();
        }
    }
}

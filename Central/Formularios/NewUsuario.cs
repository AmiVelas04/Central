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
    public partial class NewUsuario : Form
    {
        string Estate = "Activo";
        int IdU = 0;
        Clases.Usuario Usu = new Clases.Usuario();
        public NewUsuario()
        {
            InitializeComponent();
        }

        private void PanSup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (ChkAllUsu.Checked)
            {
                searchAll();
            }
            else
            {
                searchactiv();
            }

         
        }
        private void searchactiv() {
            string nom = TxtBcli.Text;
            if (nom != "") {
                DataTable datos = Usu.SearchUsubyNomAct(nom);
                LstUsu.DataSource = datos;
                LstUsu.ValueMember = "id_cajero";
                LstUsu.DisplayMember = "Nombre";
            }
            else
            {
                DataTable datos = Usu.SearchUsuAllAct();
                LstUsu.DataSource = datos;
                LstUsu.ValueMember = "id_cajero";
                LstUsu.DisplayMember = "Nombre";
            }
                
        }

        private void searchAll()
        {
            string nom = TxtBcli.Text;
            if (nom != "")
            {
                DataTable datos = Usu.SearchUsubyNom(nom);
                LstUsu.DataSource = datos;
                LstUsu.ValueMember = "id_cajero";
                LstUsu.DisplayMember = "Nombre";
            }
            else
            {
                DataTable datos = Usu.SearchUsuAll();
                LstUsu.DataSource = datos;
                LstUsu.ValueMember = "id_cajero";
                LstUsu.DisplayMember = "Nombre";
            }

        }

        private void searchOneEdit()
        {
            //string idcaj = LstUsu.SelectedValue.ToString();
           
                DataTable datos = Usu.buscUsuEdit(IdU.ToString());
            TxtNom.Text = datos.Rows[0][0].ToString();
            TxtUsu.Text = datos.Rows[0][1].ToString();
            TxtPass.Text =  datos.Rows[0][2].ToString();
            if ("1".Equals(datos.Rows[0][3].ToString()) || "2".Equals(datos.Rows[0][3].ToString()))
            {
                CboLevel.SelectedIndex = 0;
            }
            else { CboLevel.SelectedIndex = 1; }
            Estate = datos.Rows[0][4].ToString();
            if (datos.Rows[0][4].ToString().Equals("Activo"))
            {
                TstLblEstado.Text = "Usuario Activo";
                TstLblEstado.BackColor = Color.Green;
                TstLblEstado.ForeColor = Color.White;
                TstLblEstado.Font = new Font(TstLblEstado.Font,FontStyle.Bold);
                BtnActiv.Enabled = false;
                BtnDesct.Enabled = true;
            }
            else
            {
            
                TstLblEstado.BackColor = Color.Red;
                TstLblEstado.ForeColor = Color.White;
                TstLblEstado.Font = new Font(TstLblEstado.Font, FontStyle.Bold);
                TstLblEstado.Text = "Usuario Inactivo";
                BtnActiv.Enabled = true;
                BtnDesct.Enabled = false;
            }


        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //searchOneEdit();

            EditUsu();
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            string datos = $"Los siguientes datos seran ingresados\nNombre: {TxtNom.Text}\nUsuario: {TxtUsu.Text}\nTipo de Usuario: {CboLevel.Text}";
            if (MessageBox.Show(datos,"Ingresar datos?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                saveUsu();
            }
        }

        private void saveUsu() {
            
          
            int nivel = 0;
            if (CboLevel.SelectedIndex==0)
            {
                nivel = 2;
            }
            else
            {
                nivel = 3;
            }

            string[] datos = { TxtNom.Text,TxtUsu.Text,TxtPass.Text,nivel.ToString(),"Activo"};
            if (Usu.ingreusu(datos)) {
                MessageBox.Show("El usuario fue ingresado correctamente","Guardado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No pudo ingresarse los datos del usuario", "Algo salio mal!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

      



        private void Activadesactiva() {
            int nivel = 0;
            if (CboLevel.SelectedIndex == 0)
            {
                nivel = 2;
            }
            else
            {
                nivel = 3;
            }
            string[] datos = { IdU.ToString(), TxtNom.Text, TxtUsu.Text, TxtPass.Text, nivel.ToString(), Estate };
            if (Usu.AcDesUsu(datos))
            {
                MessageBox.Show($"El estado del usuario fue cambiado a {Estate}", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha podido cambiar el estado del usuario", "Algo salio mal!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            searchOneEdit();
           // limpiar();
        }

        private void EditUsu()
        {
            int nivel = 0;
            if (CboLevel.SelectedIndex == 0)
            {
                nivel = 2;
            }
            else
            {
                nivel = 3;
            }
            string[] datos = { IdU.ToString(), TxtNom.Text, TxtUsu.Text, TxtPass.Text, nivel.ToString()};
            if (Usu.updtusu(datos))
            {
                MessageBox.Show("El usuario fue editado correctamente", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No pudo editarse los datos del usuario", "Algo salio mal!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            limpiar();
        }


        private void limpiar() {
            TxtNom.Clear();
            TxtPass.Clear();
            TxtUsu.Clear();
            TstLblEstado.Text = "";
            TstLblEstado.BackColor = Color.Transparent;
            IdU = 0;
        }


        private void LstUsu_DoubleClick(object sender, EventArgs e)
        {
            IdU = int.Parse(LstUsu.SelectedValue.ToString());
            searchOneEdit();
        }

        private void BtnActiv_Click(object sender, EventArgs e)
        {
            Estate = "Activo";
            Activadesactiva();
        }

        private void BtnDesct_Click(object sender, EventArgs e)
        {
            Estate = "Inactivo";
            Activadesactiva();
        }
    }
}

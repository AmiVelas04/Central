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
    public partial class Usuarios : Form
    {
        Clases.Usuario Usu = new Clases.Usuario();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CboTipo.Items.Add("Administrador");
            CboTipo.Items.Add("Cajero");
            CboTipo.SelectedIndex = 1;
            cargarUsu();
            buscar();
        }

        private void limpiar()
        {
            TxtPass1.Clear();
            TxtPass2.Clear();
            TxtUsu.Clear();
            CboTipo.SelectedIndex = 1;
        }
        private void cargarUsu()
            { DataTable datos = new DataTable();
            datos = Usu.usuarios();
            CboUsu.DataSource = datos;
            CboUsu.DisplayMember = "nombre";
            CboUsu.ValueMember = "id_cajero";
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in datos.Rows)
            {
                coleccion.Add(row["nombre"].ToString());
            }
            CboUsu.AutoCompleteCustomSource = coleccion;
            CboUsu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CboUsu.AutoCompleteSource = AutoCompleteSource.CustomSource; 


        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string tipo="";
            if (CboTipo.SelectedIndex.ToString() == "0")
            { tipo = "2"; }
            else if (CboTipo.SelectedIndex.ToString() == "1") {
                tipo = "3";
            }
            string[] datos = { CboUsu.Text, TxtUsu.Text, TxtPass1.Text, tipo,Lblid .Text};
            if (comparPass())
            {
                if (exiteU())
                {
                    Usu.updtusu(datos);
                    MessageBox.Show("Datos del usuario actualizados correctamente");
                }
                else
                { Usu.ingreusu(datos);
                    MessageBox.Show("Usuario ingresado correctamente");
                }
            }
        }

        private bool comparPass()
        {
            return TxtPass1.Text.Equals(TxtPass2.Text);

        }
        private bool exiteU()
        {
            return Usu.existeusu(Lblid.Text);
        }

        private void CboUsu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboUsu.SelectedValue.ToString() != "System.Data.DataRowView" && CboUsu.Text!="")
            {
                buscar();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (CboUsu .Text !="") buscar();
        }

        private void buscar()
        {
            DataTable dt = new DataTable();
            dt = Usu.buscusu(CboUsu.SelectedValue.ToString());
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("No existen datos que modficar");

            }
            else
            {
                Lblid.Text = CboUsu.SelectedValue.ToString();
                TxtUsu.Text = dt.Rows[0][0].ToString();
                TxtUsu.Text = dt.Rows[0][1].ToString();
                if (dt.Rows[0][2].ToString() == "2") CboTipo.SelectedIndex = 0;
                if (dt.Rows[0][2].ToString() == "3") CboTipo.SelectedIndex = 1;


            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (CboUsu.SelectedValue.ToString() != Main.id.ToString())
            {
                if (Usu.Eliminar(CboUsu.SelectedValue.ToString(), Main.id.ToString()))
                {
                    MessageBox.Show("Cajero eliminado","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    buscar();
                }
                else
                { MessageBox.Show("Error al eliminar cajero","Eliminar",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            }
            else
            { MessageBox.Show("No se puede eliminar el mismo usuario","Eliminar",MessageBoxButtons.OK,MessageBoxIcon.Exclamation); }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            Lblid.Text = "0";
        }
    }
}

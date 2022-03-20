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
    public partial class BuscaRap : Form
    {
        public delegate void permiso(string codi);
        public event permiso RetornoCod;
        Clases.Producto prod = new Clases.Producto();
        public BuscaRap()
        {
            InitializeComponent();
        }

        private void buscarnom()
        {
            string nombre = Txtprod.Text;
            DataTable datos = new DataTable();
            datos = prod.BuscaRapProd(nombre);
            if (datos.Rows.Count > 0) {
                DgvDatos.DataSource = datos;
                DgvDatos.Columns[4].Visible = false;
                DgvDatos.Columns[6].Visible = false;
                DgvDatos.Columns[8].Visible = false;
                DgvDatos.Columns[9].Visible = false;
            }
            else { MessageBox.Show("No existe el producto buscado", "No existe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        }

        private void Txtprod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                buscarnom();
            }
        }

        private void BuscaRap_Load(object sender, EventArgs e)
        {

        }



     /*   private void BuscarProdu()
        {
            DataTable datos = new DataTable();
            string nom;
            nom = Txtprod.Text;
            datos = prod.Buscarprodnom(nom,nom,nom);
            DgvDatos.DataSource = datos;
            

        }*/

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string codigo;
            int indice = DgvDatos.CurrentRow.Index; ;
            codigo = DgvDatos.Rows[indice].Cells[0].Value.ToString();
            RetornoCod(codigo);
            this.Close();
        }
    }
}

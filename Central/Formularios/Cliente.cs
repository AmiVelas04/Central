using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Central.Clases;

namespace Central.Formularios
{
    public partial class Cliente : Form
    {
        ClaseCliente cli = new ClaseCliente();
        public Cliente()
        {
            InitializeComponent();
        }
        #region Controles
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (DgvCli.Rows.Count > 0)
            {
                BtnSave.Text = "Actualizar";
                editar();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtNom.Tag.ToString() == "0")
            { guardar(); }
            else
            { Updt(); }
            limpiar();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void BtnBusq_Click(object sender, EventArgs e)
        {
            buscarcli();
        }
        #endregion



        #region Manejo Clientes
        private void guardar()
        {
            string nombre, dir, nit, dpi, tel;
            if (TxtNom.Text == "")
            {
                MessageBox.Show("No se ha ingresado el nombre del cliente");
                return;
            }

            nombre = TxtNom.Text;
            dir = TxtDir.Text != "" ? TxtDir.Text : "N/E";
            nit = "C/F";
            dpi = "S/D";
            tel = TxtTel.Text != "" ? TxtTel.Text : "N/E";

            string[] datos = { nombre, dir, nit, dpi, tel };
            if (cli.ingrecli(datos))
            {
                MessageBox.Show("Cliente ingresado correctamente");
            }
            else { MessageBox.Show("Error en ingreso de cliente"); }
        }

        private void Updt()
        {
            string idcli,nombre, dir, nit, dpi, tel;
            idcli = TxtNom.Tag.ToString();
            nombre = TxtNom.Text;
            dir = TxtDir.Text;
            nit ="C/F";
            dpi = "";
            tel = TxtTel.Text;
            string[] datos = { nombre, dir, nit, dpi, tel,idcli };
            if (cli.Actucli(datos))
            {
                MessageBox.Show("Cliente Actualizado correctamente");
            }
            else { MessageBox.Show("Error al actualizar cliente"); }
        }

        private void editar()
        {
            int indice = DgvCli.CurrentRow.Index;
            TxtNom.Tag = DgvCli.Rows[indice].Cells[0].Value.ToString();
            TxtNom.Text = DgvCli.Rows[indice].Cells[1].Value.ToString();
            TxtDir.Text = DgvCli.Rows[indice].Cells[2].Value.ToString();
            TxtTel.Text = DgvCli.Rows[indice].Cells[4].Value.ToString();
        }


        private void limpiar()
        {
            TxtNom.Clear();

            TxtDir.Clear();

            TxtTel.Clear();

            BtnSave.Text = "Guardar";
            TxtNom.Tag = "0";
        }



        private void buscarcli()
        {
            DataTable datos = new DataTable();
            datos = cli.Nomcliente(TxtClinom.Text);
            DgvCli.DataSource = datos;
            DgvCli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvCli.Columns[0].Visible = false;
        }
        #endregion




    }
}

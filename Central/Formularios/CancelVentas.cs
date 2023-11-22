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
    public partial class CancelVentas : Form
    {
        Clases.Venta ven = new Clases.Venta();
        public string operador { get; set; }
        public string idvende { get; set; }
        public CancelVentas()
        {
            InitializeComponent();
            Dtp1.Value = DateTime.Now;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            BorrarTodos();
            decimal tot=0;
            if (CboVen.SelectedValue == null) return;
            string idv = CboVen.SelectedValue.ToString();
            DataTable datos = new DataTable();
            DataTable cabec = new DataTable();
            datos=ven.DetalleOneSaleDate(idv);
            cabec = ven.titulos(idv);
            if (datos.Rows.Count<=0)
            {
                MessageBox.Show("Esta venta no registró ningún producto");
            }
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                Dgv1.Rows.Add(datos.Rows[i][2].ToString()+", "+ datos.Rows[i][3].ToString(), datos.Rows[i][4].ToString(), datos.Rows[i][5].ToString(), datos.Rows[i][6].ToString());
                tot += (decimal.Parse(datos.Rows[i][6].ToString()));
            }
            TxtCaje.Text = cabec.Rows[0][0].ToString();
            TxtCli.Text = cabec.Rows[0][4].ToString();
            TxtTotal.Text = $"{tot}";
        }

        private void AnularVen() {
            if (CboVen.SelectedValue == null) return;
            string idv = CboVen.SelectedValue.ToString();
            if (ven.anularSale(idv,idvende,operador,TxtTotal.Text))
            { MessageBox.Show("La venta se anulo correctamente", "Correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BorrarTodos();
                cargaxdate();
            }
            else
            {
                MessageBox.Show("No fue posible anular la venta, porfavor intente de nuevo","Algo salio mal!", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }

        private void cargaxdate() {
            string fecha = Dtp1.Value.ToString("yyyy/MM/dd");
      
            DataTable datos = ven.VentasxDate(fecha);
            CboVen.DataSource = datos;
            CboVen.ValueMember = "id_venta";
            CboVen.DisplayMember = "id_venta";
     
        }

        private void Dtp1_ValueChanged(object sender, EventArgs e)
        {
            cargaxdate();
        }

        private void BorrarTodos() {
            int contar = Dgv1.Rows.Count;
            for (int i = 0; i < contar; i++)
            {
                Dgv1.Rows.RemoveAt(0);
            }

        }

        private void BtnAnul_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show($"¿Desea anular la venta No. {CboVen.SelectedValue}?","¿Anular?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                AnularVen();
            }
            
        }

        private void TxtCaje_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

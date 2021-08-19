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
    public partial class Reportes : Form
    {
        Clases.Reporte Rep = new Clases.Reporte();
        Clases.Producto Prod = new Clases.Producto();
        public Reportes()
        {
            InitializeComponent();
        }

        private void BtnRepD_Click(object sender, EventArgs e)
        {
            string fecha = DtpF1.Value.ToString("yyyy/MM/dd");
            Rep.RepD(fecha);
        }

        private void BtnRepS_Click(object sender, EventArgs e)
        {
            string fechai, fechaf;
            fechai = DtpTi.Value.ToString("yyyy/MM/dd");
            fechaf = DtpTf.Value.ToString("yyyy/MM/dd");
            Rep.Totales(fechai, fechaf);
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            int indice = int.Parse(CboInven.SelectedIndex.ToString());
            if (indice == 0)
            {
                Prod.Inventario();
            }
            else if (indice==1)
            {
                Prod.inventario1();
            }
            else if (indice ==2)
            {
                Prod.inventario2();
            }
            else if (indice==3)
            {
                Prod.inventario3();
            }

              
        }

        private void BtnGan_Click(object sender, EventArgs e)
        {
            string fechai, fechaf;
            fechai = DtpGI.Value.ToString("yyyy/MM/dd");
            fechaf = DtpGf.Value.ToString("yyyy/MM/dd");
            Prod.Ganacia(fechai, fechaf);
        }

              private void BtnMasVen_Click_1(object sender, EventArgs e)
        {
            string fechai, fechaf;
            fechai = DtpGI.Value.ToString("yyyy/MM/dd");
            fechaf = DtpGf.Value.ToString("yyyy/MM/dd");
            Prod.MasVen(fechai, fechaf);
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            string fechai, fechaf;
            fechai = DtpGI.Value.ToString("yyyy/MM/dd");
            fechaf = DtpGf.Value.ToString("yyyy/MM/dd");
            Rep.Vendidos(fechai,fechaf);
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            CboInven.SelectedIndex = 0;

        }
    }
}

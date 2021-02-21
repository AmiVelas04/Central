using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

    namespace Central.Reportes
{
    partial class Inventario : Form
    {
        public List<DiarioDet> Detalle = new List<DiarioDet>();
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            this.RpwInv.LocalReport.DataSources.Clear();
            this.RpwInv.LocalReport.DataSources.Add(new ReportDataSource("Detalle", Detalle));
            this.RpwInv.SetDisplayMode(DisplayMode.PrintLayout);
            this.RpwInv.ZoomMode = ZoomMode.Percent;
            //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
            this.RpwInv.ZoomPercent = 100;
            this.RpwInv.RefreshReport();
        }
    }
}

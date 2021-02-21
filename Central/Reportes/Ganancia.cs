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
    partial class Ganancia : Form
    {
        public List<DiarioEnc> Encabezado = new List<DiarioEnc>();
        public List<DiarioDet> Detalle = new List<DiarioDet>();
        public Ganancia()
        {
            InitializeComponent();
        }

        private void Ganancia_Load(object sender, EventArgs e)
        {
            this.RpvGan.LocalReport.DataSources.Clear();
            this.RpvGan.LocalReport.DataSources.Add(new ReportDataSource("Enca", Encabezado));
            this.RpvGan.LocalReport.DataSources.Add(new ReportDataSource("Detalle", Detalle));
            this.RpvGan.SetDisplayMode(DisplayMode.PrintLayout);
            this.RpvGan.ZoomMode = ZoomMode.Percent;
            //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
            this.RpvGan.ZoomPercent = 100;
            this.RpvGan.RefreshReport();
        }
    }
}

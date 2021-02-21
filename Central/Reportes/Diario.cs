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
    partial class Diario : Form
    {
        public List<DiarioDet> Deta = new List<DiarioDet>();
        public List<DiarioEnc> Enca = new List<DiarioEnc>();
        public Diario()
        {
            InitializeComponent();
        }

        private void Diario_Load(object sender, EventArgs e)
        {
            this.RpvDiario.LocalReport.DataSources.Clear();
            this.RpvDiario.LocalReport.DataSources.Add(new ReportDataSource("Encabe", Enca));
            this.RpvDiario.LocalReport.DataSources.Add(new ReportDataSource("Deta", Deta));
            this.RpvDiario.SetDisplayMode(DisplayMode.PrintLayout);
            this.RpvDiario.ZoomMode = ZoomMode.Percent;
            //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
            this.RpvDiario.ZoomPercent = 100;
            this.RpvDiario.RefreshReport();
        }
    }
}

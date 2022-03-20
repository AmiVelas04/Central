using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Central.Reportes
{
    public partial class VentaCli : Form
    {
        public VentaCli()
        {
            InitializeComponent();
        }

        private void VentaCli_Load(object sender, EventArgs e)
        {
            this.RpvCli.LocalReport.DataSources.Clear();
           /* this.RpvCli.LocalReport.DataSources.Add(new ReportDataSource("Detalle", Detalle));
            this.RpvCli.LocalReport.DataSources.Add(new ReportDataSource("Detalle", Detalle));*/
            this.RpvCli.SetDisplayMode(DisplayMode.PrintLayout);
            this.RpvCli.ZoomMode = ZoomMode.Percent;
            //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
            this.RpvCli.ZoomPercent = 100;
            this.RpvCli.RefreshReport();
        }
    }
}

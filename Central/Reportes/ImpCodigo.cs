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
 partial class ImpCodigo : Form
    {
        public List<EtiquetaImp> detalle = new List<EtiquetaImp>();
        public ImpCodigo()
        {
            InitializeComponent();
        }

        private void ImpCodigo_Load(object sender, EventArgs e)
        {
            this.Rpv1.LocalReport.DataSources.Clear();
            Rpv1.LocalReport.EnableExternalImages = true;
            this.Rpv1.LocalReport.DataSources.Add(new ReportDataSource("Deta", detalle));
            this.Rpv1.SetDisplayMode(DisplayMode.PrintLayout);
            this.Rpv1.ZoomMode = ZoomMode.Percent;
            //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
            this.Rpv1.ZoomPercent = 100;
            this.Rpv1.RefreshReport();
            this.Rpv1.RefreshReport();
        }
    }
}

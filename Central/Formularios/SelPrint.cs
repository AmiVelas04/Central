using System;
using System.Drawing.Printing;
using System.Linq;

using System.Windows.Forms;

namespace Central.Formularios
{
    public partial class SelPrint : Form
    {
        Clases.Imprimir imp = new Clases.Imprimir();
        public SelPrint()
        {
            InitializeComponent();
        }

      private void  cargaimpresora()
        {
            int total = PrinterSettings.InstalledPrinters.Count;
            for (Int32 i = 0; i <total ; i++)
            {
                PrinterSettings a = new PrinterSettings();
                CboPrint.Items.Add(PrinterSettings.InstalledPrinters[i].ToString());
            }
            if (total>1)
            {
                CboPrint.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No se encontraron impresoras instaladas!","Sin Impresoras",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void SelPrint_Load(object sender, EventArgs e)
        {
            cargaimpresora();
        }

        private void BtnSelPrint_Click(object sender, EventArgs e)
        {
            string impre = CboPrint.Text;
            if (imp.saveprint(impre))
            { MessageBox.Show("Se selecciono la impresora correctamente", "Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                MessageBox.Show("No se pudo seleccionar la impresora", "Algo salio mal!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

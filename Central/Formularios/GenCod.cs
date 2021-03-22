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
    public partial class GenCod : Form
    {
        private Clases.CodigoGen codif = new Clases.CodigoGen();

        public GenCod()
        {
            InitializeComponent();
        }

        private void BtnGen_Click(object sender, EventArgs e)
        {
            generar();
        }

        private void generar()
        {

            bool bandera=true;
            while (bandera)
            {
                int cont;
                string cod = "1010";
                for (cont=1;cont<=9;cont++)
                {
                   
                    var guid = Guid.NewGuid();
                    var justnumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
                    var seed = int.Parse(justnumbers.Substring(0,4));
                    var random = new Random(seed);
                    var value = random.Next(0,9);
                    cod = cod + value.ToString();
                }
                if (!codif.existecod(cod))
                {
                    bandera = false;
                    TxtCodBarras.Text = cod;
                }
                else
                {
                    bandera = true;
                }

            }
           
        }

        private void Imprimir()
        {
            string texto = TxtCodBarras.Text;
            string mensaje;
        try
                {
                float alto = 40;
                
                mensaje = "";
                Bitmap bm = new Bitmap(codif.codigob(texto, true, alto, mensaje));
                PcbCod.BackgroundImage = bm;
                Image imagen = PcbCod.BackgroundImage;
                imagen.Save(@"D:\C.jpg");
                int cantidadeti;
                cantidadeti = Int32.Parse(NudEtiqueta.Value.ToString());
                codif.imprimircod(mensaje, cantidadeti);
                    }
            catch (Exception ex)
                {
                MessageBox.Show(ex.ToString());
                }
        }

        private void BtnImp_Click(object sender, EventArgs e)
        {
            if (TxtCodBarras.Text != "")
            { Imprimir(); }
            else
            { MessageBox.Show("No se ha generado ningún código para imprimir"); }
        }

        private void ChkEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkEditar.Checked)
            { TxtCodBarras.Enabled = true; }
            else
            {
                TxtCodBarras.Enabled = false;
            }
        }
    }
}

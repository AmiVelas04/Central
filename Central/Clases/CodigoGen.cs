using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing;
using System.Drawing.Imaging;



namespace Central.Clases
{
    class CodigoGen
    {
        Conexion conect = new Conexion();
        #region "General"
        private DataTable buscar(string consulta)
        {
            conect.iniciar();
            DataTable datos = new DataTable();
            try
            {

                MySqlDataAdapter adap = new MySqlDataAdapter(consulta, conect.conn);
                adap.Fill(datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show(consulta);
            }
            return datos;
        }
        private bool consulta_gen(string consulta)
        {
            conect.iniciar();
            MySqlCommand com1 = new MySqlCommand();
            com1.Connection = conect.conn;
            com1.CommandText = consulta;
            com1.CommandType = CommandType.Text;
            try
            {
                conect.conn.Open();
                com1.ExecuteNonQuery();
                conect.conn.Close();
            }

            catch (Exception ex)
            {
                conect.conn.Close();
                MessageBox.Show(ex.ToString());
                MessageBox.Show(consulta);
                return false;
            }
            return true;
        }

        #endregion

        #region "Procesos de codigo"
        public System.Drawing.Image codigob(string codigo, Boolean Contexto = false, Single alto = 0, String texto = "")
        {
            Barcode128 barcode = new Barcode128();
            barcode.StartStopText = true;
        if (alto != 0) barcode.BarHeight = alto;


            barcode.Code = codigo;
            barcode.ChecksumText = true;
            barcode.CodeType = BarcodeEANSUPP.UPCA;

        try
                {
                String letras;
                letras = codigo +"\n"+ texto;
                Size talla = new Size();
                talla.Width = 200;
                talla.Height = 75;
                Bitmap bm = new Bitmap(barcode.CreateDrawingImage(Color.Black, Color.White), talla);
                System.Drawing.Image bmt = new Bitmap(bm.Width, bm.Height + 14);
                Graphics g =Graphics.FromImage(bmt);
                SolidBrush bru = new SolidBrush(Color.White);
                g.FillRectangle(bru, 0, 0, bm.Width, bm.Height + 14);
                System.Drawing.Font PintarTexto = new System.Drawing.Font("arial",10);
                SolidBrush brocha = new SolidBrush(Color.Black);
                SizeF stringsize;
                stringsize = g.MeasureString(codigo,PintarTexto);
                float centrox;
                centrox = (bm.Width - stringsize.Width) / 2;
                float x;
                float y;
                x = centrox;
                y = bm.Height;
                StringFormat drawformat = new StringFormat();
                drawformat.FormatFlags = StringFormatFlags.NoWrap;
                g.DrawImage(bm,0,0);
                string ncode= codigo.Substring(1,codigo.Length-2);
                g.DrawString(codigo, PintarTexto, brocha, x, y, drawformat);
                return bmt;
                    }
            catch(Exception ex)
                {
                throw new Exception("Error al genera el codigo:" + ex.ToString());
        }
                    }

        public void imprimircod(string texto, int cant )
        {

            Reportes.DiarioEnc enca = new Reportes.DiarioEnc();

            int cantfil,ultcol;
            cantfil = (cant - (cant % 5)) / 5;
            if ((cant%5)>0)
            {
                cantfil += 1;
                ultcol = cant % 5;
            }
            else {
                ultcol = 5;
            }
            int fila,columna;
            string[,] titulo = new string[cantfil,5];
            string[,] imgcod = new string[cantfil, 5];
            for (fila=0; fila <= (cantfil - 1); fila++)
            {
                for (columna=0;columna<=4;columna++)
                {
                    titulo[fila, columna] = "";
                    imgcod[fila, columna] = "";
                }
            }


            for (fila=0;fila<=(cantfil-1);fila++)
            {
                if (fila == (cantfil - 1))
                {
                    for (columna = 0; columna <= (ultcol - 1); columna++)
                    {
                        titulo[fila, columna] = "";
                        imgcod[fila, columna] = @"D:\C.jpg";//direccion donde se ecnutra la imagen guardada
                    }
                }
                else
                {
                    for (columna = 0; columna <= 4; columna++)
                    {
                        titulo[fila, columna] = "";
                        imgcod[fila, columna] = @"D:\C.jpg";//direccion donde se ecnutra la imagen guardada
                    }
                }
            }

            for (fila=0;fila<=(cantfil-1);fila++)
            {

            }

            for (fila=0;fila<=(cantfil-1);fila++)
            {
                Reportes.EtiquetaImp etiq = new Reportes.EtiquetaImp();
                etiq.etiqueta1 = "";
                etiq.codigo1 = imgcod[fila,0];
                etiq.etiqueta2 = "";
                etiq.codigo2 = imgcod[fila, 1];
                etiq.etiqueta3 = "";
                etiq.codigo3 = imgcod[fila, 2];
                etiq.etiqueta4 = "";
                etiq.codigo4 = imgcod[fila, 3];
                etiq.etiqueta5 = "";
                etiq.codigo5 = imgcod[fila, 4];

                enca.Etiqueta.Add(etiq);

            }
            Reportes.ImpCodigo ventana = new Reportes.ImpCodigo();
            ventana.detalle = enca.Etiqueta;
            ventana.Show();

            /* For fila = 0 To cantfil - 1

            Dim etiq As New EtiquetaClase
            etiq.Etiqueta1 = titulo(fila, 0)
            etiq.Codigo1 = imgcod(fila, 0)
            etiq.Etiqueta2 = titulo(fila, 1)
            etiq.Codigo2 = imgcod(fila, 1)
            etiq.Etiqueta3 = titulo(fila, 2)
            etiq.Codigo3 = imgcod(fila, 2)
            etiq.Etiqueta4 = titulo(fila, 3)
            etiq.Codigo4 = imgcod(fila, 3)
            etiq.Etiqueta5 = titulo(fila, 4)
            etiq.Codigo5 = imgcod(fila, 4)
            enca.Etiqueta.Add(etiq)

        Next

        Dim ventana As New ImpCodigoB
        ventana.encabezado.Add(enca)
        ventana.code = enca.Etiqueta
        ventana.Show()
        */

        }



        public bool existecod(string cod) {
            DataTable datos = new DataTable();
            string consulta;
            consulta = "select COUNT(*) FROM producto p WHERE p.ID_PROD='" + cod + "'";
            datos = buscar(consulta);
            int codi;
            codi = Int32.Parse(datos.Rows[0][0].ToString());
            if (codi>0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
  }

    }
        #endregion

    }


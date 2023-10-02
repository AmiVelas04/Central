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
    public partial class Compras : Form
    {
        Clases.Compra Comp = new Clases.Compra();


        public Compras()
        {
            InitializeComponent();
        }

        private void DgvDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void checkprod(string cod, int i) {
            if (cod != null) {
                DataTable eprod = Comp.cargaprod(cod);
                if (eprod.Rows.Count>0)
                {
                    DgvDatos.Rows[i].Cells[1].Value = eprod.Rows[0][0];
                    DgvDatos.Rows[i].Cells[2].Value = eprod.Rows[0][1];
                    DgvDatos.Rows[i].Cells[3].Value = eprod.Rows[0][2];
                    DgvDatos.Rows[i].Cells[4].Value = eprod.Rows[0][3];
                        DgvDatos.Rows[i].Cells[5].Value = eprod.Rows[0][4];
                    DgvDatos.Rows[i].Cells[6].Value = eprod.Rows[0][4];
                        DgvDatos.Rows[i].Cells[7].Value = 0;
                        DgvDatos.Rows[i].Cells[8].Value = eprod.Rows[0][5];
                                 
                }
            }
        }

        private void DgvDatos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDatos.RowCount > 0)
            {
                int indice = DgvDatos.CurrentRow.Index;
                string codigo = DgvDatos.Rows[indice].Cells[0].Value.ToString();
                checkprod(codigo, indice);
            }
        }

        private void addprodus() {
            int total = DgvDatos.Rows.Count - 1;
            DataTable datos = new DataTable();
            datos.Columns.Add("Cod").DataType = Type.GetType("System.String");
            datos.Columns.Add("Prod").DataType = Type.GetType("System.String");
            datos.Columns.Add("Des").DataType = Type.GetType("System.String");
            datos.Columns.Add("Marca").DataType = Type.GetType("System.String");
            datos.Columns.Add("Precio1").DataType = Type.GetType("System.String");
            datos.Columns.Add("Precio2").DataType = Type.GetType("System.String");
            datos.Columns.Add("Precio3").DataType = Type.GetType("System.String");
            datos.Columns.Add("Cantidad").DataType = Type.GetType("System.String");
     
            for (int i = 0; i < total; i++)
            {
                DataRow fila = datos.NewRow();
                fila["Cod"] = DgvDatos.Rows[i].Cells[0].Value;
                fila["Prod"] = DgvDatos.Rows[i].Cells[1].Value;
                fila["Des"] = DgvDatos.Rows[i].Cells[2].Value;
                fila["Marca"] = DgvDatos.Rows[i].Cells[3].Value;
                fila["Precio1"] = DgvDatos.Rows[i].Cells[4].Value;
                fila["Precio2"] = DgvDatos.Rows[i].Cells[5].Value;
                fila["Precio3"] = DgvDatos.Rows[i].Cells[6].Value;
                fila["Cantidad"] = DgvDatos.Rows[i].Cells[7].Value;
                datos.Rows.Add(fila);
            }



        }
    }
}

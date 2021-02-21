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
    public partial class Ventas : Form
    {
        Clases.Producto prod = new Clases.Producto();
        Clases.Venta ven = new Clases.Venta();
        DataTable respaldo = new DataTable();
        decimal Refectivo;

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            TxtCod.Focus();
            Ttinfo.SetToolTip(BtnImp, "Imprimir el ultimo comprobante");
            listadoprod();
        }

      

        private void TxtCod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) {
                if (!String.IsNullOrEmpty(TxtCod.Text))
                {
                    TxtCod.SelectionStart = 0;
                    TxtCod.SelectionLength = TxtCod.Text.Length;
                    TxtCod.Focus();
                }
                listprod(TxtCod.Text); }
        }
        private void listprod(string codigo)
        {
            if (prod.existeprod(codigo))
            {
                if (NudCant.Value.ToString() == "0") { NudCant.Value = 1; }
                if (DgvProd.Rows.Count <= 0)
                {
                    DgvProd.Columns.Add("Cod", "Codigo");
                    DgvProd.Columns.Add("Producto", "Producto");
                    DgvProd.Columns.Add("Des", "Descripcion");
                    DgvProd.Columns.Add("Marca", "Marca");
                    DgvProd.Columns.Add("Precio", "Precio");
                    DgvProd.Columns.Add("Cantidad", "Cantidad");
                    DgvProd.Columns.Add("Subtotal", "Subtotal");
                    DgvProd.Columns.Add("Paquete", "paquete");
                    DgvProd.Columns.Add("Preciop", "Preciop");

                    DgvProd.Columns[0].Visible = false;
                   // DgvProd.Columns[7].Visible = false;
                   // DgvProd.Columns[8].Visible = false;
                }
                DataTable prods = new DataTable();
                prods = prod.buscarprod(codigo);

                decimal subtotal=decimal.Parse(NudCant .Value.ToString () )*decimal.Parse (prods.Rows[0][4].ToString());
                
                DgvProd.Rows.Add(codigo,prods.Rows[0][0].ToString(), prods.Rows[0][1].ToString(), prods.Rows[0][2].ToString(), prods.Rows[0][4].ToString(), NudCant.Value,subtotal, prods.Rows[0][7].ToString(), prods.Rows[0][8].ToString());
                calcTot();
                contarprod();
                TxtCod.Focus();
                NudCant.Value = 1;
            }
            else
            {
                MessageBox.Show("No existe el producto que busca");
            }
        }

        private void calcTot()
        {
            decimal subtotal,desc=0;
            int cant, cont;
            cant = DgvProd.Rows.Count;
            if (TxtTotal .Text == "")
            { subtotal = 0; }
            else
            { subtotal = decimal.Parse(TxtTotal.Text); }
            subtotal = 0;
            int i, j;
           
           for (cont=0; cont<cant; cont++ )
            { int[] total= new int[cant];
              string[] cod = new string[cant];
                cod [cont]= DgvProd.Rows[cont].Cells[0].Value.ToString();
                bool estado=true;
                for (i = cont-1; i>=0;i--)
                {

                    if (cod[cont] == DgvProd.Rows[i].Cells[0].Value.ToString()) estado = false;
                }

                decimal descuento=0,tot=0;
                int Tprod =0;

                //producto cuando existe precio de paquete
                if (estado && int.Parse (DgvProd.Rows[cont].Cells[7].Value.ToString())>0) {
                    
                    for (j = 0; j < cant; j++)
                    {   if (DgvProd.Rows[cont].Cells[0].Value.ToString() == DgvProd.Rows[j].Cells[0].Value.ToString())                            Tprod += int.Parse(DgvProd.Rows[j].Cells[5].Value.ToString());
                    }
                    int sobra, tpack, packente;
                    int paquete = int.Parse(DgvProd.Rows[cont].Cells[7].Value.ToString());
                    decimal pPack = decimal.Parse(DgvProd.Rows[cont].Cells[8].Value.ToString());
                    sobra = Tprod % paquete;
                    packente = Tprod - sobra;
                    tpack = packente / paquete;
                    tot = Tprod * decimal.Parse(DgvProd.Rows[cont].Cells[4].Value.ToString());
                    descuento = (packente * decimal.Parse(DgvProd.Rows[cont].Cells[4].Value.ToString())) - (tpack * decimal.Parse(DgvProd.Rows[cont].Cells[8].Value.ToString()));
                }

                //Producto cuando no existe precio de paquete
                if (estado && int.Parse(DgvProd.Rows[cont].Cells[7].Value.ToString()) == 0)
                {

                    for (j = 0; j < cant; j++)
                    {
                        if (DgvProd.Rows[cont].Cells[0].Value.ToString() == DgvProd.Rows[j].Cells[0].Value.ToString()) Tprod += int.Parse(DgvProd.Rows[j].Cells[5].Value.ToString());
                    }
                    descuento = 0;
                    int paquete = int.Parse(DgvProd.Rows[cont].Cells[7].Value.ToString());
                    decimal pPack = decimal.Parse(DgvProd.Rows[cont].Cells[8].Value.ToString());
                    tot = Tprod * decimal.Parse(DgvProd.Rows[cont].Cells[4].Value.ToString());
                   
                }
                subtotal += tot;
                subtotal -= descuento ;
                desc += descuento;

            }
        
            //subtotal += decimal.Parse(subt);
           // LblTotal.Text = subtotal.ToString ();
            TxtTotal.Text = subtotal.ToString();
            LblDesc.Text = desc.ToString ();
            contarprod();
        }

        private void listadoprod()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            DataTable datos = new DataTable();
            datos = prod.TodProd();
            CboNom.DataSource = datos;
            CboNom.DisplayMember = "Nombre";
            CboNom.ValueMember = "id_prod";
            foreach (DataRow row in datos.Rows)
            {
                coleccion.Add(row["Nombre"].ToString ());

            }
            CboNom.AutoCompleteMode = AutoCompleteMode.Suggest;
            CboNom.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CboNom.AutoCompleteCustomSource = coleccion;

        }
        private void BtnCobrar_Click(object sender, EventArgs e)
        {
            cambio();

            if (DgvProd.Rows.Count <= 0)
            {
                MessageBox.Show("No existen Productos");
            }
            else if (decimal.Parse(TxtCamb.Text) < 0)
            { MessageBox.Show("El monto de efectivo es incorrecto"); }
            else if (TxtEfect.Text == "")
            { MessageBox.Show("No se ha ingresado el monto del efectivo"); }

            else
            {

                PrepProd();
                limpiar();
                TxtCod.Focus();
            }
            
            
        }

        private void PrepProd()
        {
            DataTable datos = new DataTable();
            int total= DgvProd.Rows.Count;
            int cont;
            string descu = LblDesc.Text;
            if ( total> 0)
            {
                datos.Columns.Add("Cod").DataType = Type.GetType("System.String");
                datos.Columns.Add("Producto").DataType = Type.GetType("System.String");
                datos.Columns.Add("Des").DataType = Type.GetType("System.String");
                datos.Columns.Add("Marca").DataType = Type.GetType("System.String");
                datos.Columns.Add("Precio").DataType = Type.GetType("System.String");
                datos.Columns.Add("Cantidad").DataType = Type.GetType("System.String");
                datos.Columns.Add("Subtotal").DataType = Type.GetType("System.String");
                datos.Columns.Add("Paquete").DataType = Type.GetType("System.String");
                datos.Columns.Add("PrecioxPaquete").DataType = Type.GetType("System.String");
                for (cont= 0;cont<total;cont++)
                {
                    DataRow fila = datos.NewRow();
                    fila["Cod"] = DgvProd.Rows[cont].Cells[0].Value;
                    fila["Producto"] = DgvProd.Rows[cont].Cells[1].Value;
                    fila["Des"] = DgvProd.Rows[cont].Cells[2].Value;
                    fila["Marca"] = DgvProd.Rows[cont].Cells[3].Value;
                    fila["Precio"] = DgvProd.Rows[cont].Cells[4].Value;
                    fila["Cantidad"] = DgvProd.Rows[cont].Cells[5].Value;
                    fila["Subtotal"] = DgvProd.Rows[cont].Cells[6].Value;
                    fila["Paquete"] = DgvProd.Rows[cont].Cells[7].Value;
                    fila["PrecioxPaquete"] = DgvProd.Rows[cont].Cells[8].Value;
                    datos.Rows.Add(fila);
                }
                decimal efect = decimal.Parse(TxtEfect.Text);
                respaldo = datos;
                Refectivo = decimal.Parse(TxtEfect.Text);
                if (ven.generarv(datos, efect,"1", Main.id.ToString (),descu))
                {
                  
                    MessageBox.Show("Venta correcta");
                }
                else
                {
                    MessageBox.Show("error en venta");
                }
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (DgvProd.RowCount > 0)
            {
                int indice = DgvProd.CurrentRow.Index;
                decimal cant = decimal.Parse(DgvProd.Rows[indice].Cells[6].Value.ToString());
                cant *= -1;
                DgvProd.Rows.RemoveAt(indice);
                calcTot();
                contarprod();
            }
            else
            {
                TxtCod.Clear();
                TxtCod.Focus();


            }
            TxtCod.Focus();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            while (DgvProd .Rows .Count>0)
            {
                DgvProd.Rows.RemoveAt(0);
            }
            
            DgvProd.Columns.RemoveAt(8);
            DgvProd.Columns.RemoveAt(7);
            DgvProd.Columns.RemoveAt(6);
            DgvProd.Columns.RemoveAt(5);
            DgvProd.Columns.RemoveAt(4);
            DgvProd.Columns.RemoveAt(3);
            DgvProd.Columns.RemoveAt(2);
            DgvProd.Columns.RemoveAt(1);
            DgvProd.Columns.RemoveAt(0);


            TxtCod.Clear();
            TxtCamb.Clear();
            Txtdesc.Clear();
            TxtMarca.Clear();
            TxtPrecio.Clear();
            TxtTotal.Clear();
            TxtCod.Focus();
            TxtEfect.Clear();
        }


        private void reimprimir()
        {
            int id = ven.idventa();
            ven.PrintTicket(id, respaldo, Refectivo,LblDesc.Text );
        }
      
        private void NudCant_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                if (DgvProd.Rows.Count > 0)
                {
                    int indice = DgvProd.CurrentRow.Index;
                    decimal cant;
                    int ingre = Int32.Parse(NudCant.Value.ToString());
                    if (ingre > 0)
                    {
                        if (decimal.TryParse(DgvProd.Rows[indice].Cells[4].Value.ToString(), out cant))
                        {
                            decimal subtotal = cant * ingre;
                            DgvProd.Rows[indice].Cells[5].Value = ingre;
                            DgvProd.Rows[indice].Cells[6].Value = subtotal;
                            calcTot();
                            TxtCod.Focus();
                            NudCant.Value = 1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar valores mayores que 0", "Valores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                contarprod();
            }
            NudCant.Value = 1;
            
        }

        private void TxtEfect_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtEfect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cambio();
            }
        }


        private void cambio()
            {
            decimal pago, efectivo, cambio;
                if (!decimal.TryParse(TxtTotal.Text, out pago)) pago = 0;
                if (decimal.TryParse(TxtEfect.Text, out efectivo))
                { }
                else
                {
                    TxtEfect.Text = "0";
                    efectivo = 0; ;
                    MessageBox.Show("Valor invalido!");
                    return;
                }

    cambio = efectivo - pago;
                TxtCamb.Text = cambio.ToString ();
            BtnCobrar.Focus();
            }
        private void contarprod()
        {
            if (DgvProd.Rows.Count > 0)
            {
                int cant, cont, sum = 0;
                cant = DgvProd.Rows.Count;
                for (cont = 0; cont < cant; cont++)
                {
                    sum += int.Parse(DgvProd.Rows[cont].Cells[5].Value.ToString());
                }
                LblCant.Text = "Productos: " + sum;

            }
            else
            { LblCant.Text = "Productos: 0" ; }

        }


        private void DgvProd_Click(object sender, EventArgs e)
        {
            if (DgvProd.Rows.Count > 0)
            {
                int indice = DgvProd.CurrentRow.Index;
                //TxtNom.Text = DgvProd.Rows[indice].Cells[1].Value.ToString();
                Txtdesc.Text = DgvProd.Rows[indice].Cells[2].Value.ToString();
                TxtMarca.Text = DgvProd.Rows[indice].Cells[3].Value.ToString();
                TxtPrecio .Text = DgvProd.Rows[indice].Cells[4].Value.ToString();
                NudCant.Value = decimal.Parse(DgvProd.Rows[indice].Cells[5].Value.ToString ());
            }
        }

        private void BtnAgreg_Click(object sender, EventArgs e)
        {

        }

        private void Ventas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5 && Refectivo !=0)
            {
                reimprimir();
            }
        }

        private void BtnImp_Click(object sender, EventArgs e)
        {
            if (Refectivo != 0) reimprimir();
        }

     

        private void CboNom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                listprod(CboNom.SelectedValue.ToString());
            }
        }
    }
}

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
        Clases.ClaseCliente cli = new Clases.ClaseCliente();
        Clases.CreditoClase credi = new Clases.CreditoClase();
        public string idusu, nombreU, nivelusu;
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
            cargacli();
            TxtCamb.Text = "0";
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
            else if (e.KeyCode==Keys.F5)
            {
                BuscaRap busca = new BuscaRap();
                busca.RetornoCod += new BuscaRap.permiso(BuscaRap);
                busca.ShowDialog();
            }
            else if (e.KeyCode == Keys.F12 && (Main.nivel.Equals("1")|| Main.nivel.Equals("2")))
            {
                CancelVentas anul = new CancelVentas();
                anul.operador = Main.nombre;
                anul.ShowDialog();
            }
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
                int cantactual = int.Parse(prods.Rows[0][5].ToString()),prodadd=0;
                prodadd = int.Parse(NudCant.Value.ToString()) + CantxProd(codigo);

                if (cantactual < prodadd)
                {
                    var msj = MessageBox.Show("No hay existencias suficientes para realizar la venta\n¿Desea realizar la venta de todos modos?","Sin existencias suficientes",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                    if (msj == DialogResult.No)
                    {
                        return;
                    }
                }
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
            string[] cod = new string[cant];
            for (cont=0; cont<cant; cont++ )
            { int[] total= new int[cant];
            
                cod [cont] = DgvProd.Rows[cont].Cells[0].Value.ToString();
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
                    descuento = 0;
                        //(packente * decimal.Parse(DgvProd.Rows[cont].Cells[4].Value.ToString())) - (tpack * decimal.Parse(DgvProd.Rows[cont].Cells[8].Value.ToString()));
                }

                //Producto cuando no existe precio de paquete
                if (int.Parse(DgvProd.Rows[cont].Cells[7].Value.ToString()) == 0)
                {

                    for (j = 0; j < cant; j++)
                   /* {
                        if (DgvProd.Rows[cont].Cells[0].Value.ToString() == DgvProd.Rows[j].Cells[0].Value.ToString()) Tprod += int.Parse(DgvProd.Rows[j].Cells[5].Value.ToString());
                    }*/
                    descuento = 0;
                    int paquete = int.Parse(DgvProd.Rows[cont].Cells[7].Value.ToString());
                    decimal pPack = decimal.Parse(DgvProd.Rows[cont].Cells[8].Value.ToString());
                    tot = int.Parse(DgvProd.Rows[cont].Cells[5].Value.ToString()) * decimal.Parse(DgvProd.Rows[cont].Cells[4].Value.ToString()); //Tprod * decimal.Parse(DgvProd.Rows[cont].Cells[4].Value.ToString());

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

        public void listarpordbusq()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            DataTable datos = new DataTable();
            datos = prod.Prodbusque(CboNom.Text);
            CboNom.DataSource = datos;
            CboNom.DisplayMember = "Nombre";
            CboNom.ValueMember = "id_prod";
            foreach (DataRow row in datos.Rows)
            {
                coleccion.Add(row["Nombre"].ToString());

            }
            CboNom.AutoCompleteMode = AutoCompleteMode.Suggest;
            CboNom.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CboNom.AutoCompleteCustomSource = coleccion;
        }
        private void BtnCobrar_Click(object sender, EventArgs e)
        {
            if (ChkCredito.Checked)
            {
                if (CboCli.SelectedValue.ToString().Equals("1"))
                {
                    MessageBox.Show("No se puede generar credito al cosumidor final!", "No credito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    TxtCamb.Text = "0";
                    PrepProd();
                    limpiar();
                    TxtCod.Focus();
                }
            }
            else
            {
                if (TxtEfect.Text == "") TxtEfect.Text = "0";
                cambio();
                if (DgvProd.Rows.Count <= 0)
                {
                    MessageBox.Show("No existen Productos");
                    return;
                }
                else if (TxtEfect.Text == "")
                { MessageBox.Show("El monto de efectivo es incorrecto");
                    TxtEfect.Text = "0";
                    return;
                }
                /*  else if (decimal.Parse(TxtCamb.Text) < 0)
                  { MessageBox.Show("No se ha ingresado el monto del efectivo");
                      return;
                  }*/
                else
                {
                    decimal Verchan=0,Vtot=0,Vefec=0;
                    Vtot = decimal.Parse(TxtTotal.Text);
                    Vefec = decimal.Parse(TxtEfect.Text);
                    Verchan = Vefec - Vtot;
                   // Verchan = decimal.Parse(TxtCamb.Text);
                    if (CboCli.SelectedValue.ToString().Equals("1") && (Verchan<0))
                    {
                        MessageBox.Show("No se puede generar credito a consumidor final","Venta no generada", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }
                    PrepProd();
                    limpiar();
                    TxtCod.Focus();
                }
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
                if (TxtEfect.Text == "") TxtEfect.Text = "0";
                decimal efect = decimal.Parse(TxtEfect.Text);
                respaldo = datos;
                Refectivo = decimal.Parse(TxtEfect.Text);
                string idc= idcli();
                decimal totalpag = decimal.Parse(TxtTotal.Text);
                string venta = "";
                string estado="";
                if (efect < totalpag && ChkCredito.Checked)  estado= "Cred";
                if (idc.Equals("0"))
                {
                    MessageBox.Show("No se le puede asignar credito al cliente seleccionado");
                    return;
                }
                int ventanum = ven.generarv(datos, efect, idc, Main.id.ToString(), descu, estado);
                if (ventanum != 0)
                {
                    if (estado.Equals("Cred"))
                    {
                        //venta = ven.idventa().ToString();
                        RegCredi(ventanum.ToString());
                    }
                    else
                    {
                        //MessageBox.Show("Credito no generado","No credito",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                    MessageBox.Show("Venta correcta","Correcto",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("error en venta","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
        }

        private void RegCredi(string idven)
        {
            string clien,total,abono;
            total = TxtTotal.Text;
            if (TxtEfect.Text == "")
            { abono = "0"; }
            else
            { abono = TxtEfect.Text; }
            clien = CboCli.SelectedValue.ToString();
            string[] datos = {clien,idven,total,abono,"Activo",idusu};
            if (credi.IngresoCred(datos))
            {
                MessageBox.Show("Credito registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { MessageBox.Show("No se pudo registrar el Credito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
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
                            DataTable produ = new DataTable();
                            string codprod= DgvProd.Rows[indice].Cells[0].Value.ToString() ;
                            int cantactual = CantxProd(codprod),prodstock=0;
                            produ=prod.buscarprod(codprod);
                            cantactual += ingre;
                            prodstock = int.Parse(produ.Rows[0][5].ToString());
                            if (prodstock < cantactual)
                            {
                                var msj = MessageBox.Show("No hay existencias suficientes para realizar la venta\n¿Desea realizar la venta de todos modos?", "Sin existencias suficientes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                if (msj == DialogResult.No)
                                {
                                    return;
                                }
                            }
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
            if (ChkCredito.Checked)
            { return; }
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
            if (cambio < 0)
            {
                if (ChkCredito.Checked)
                {
                    cambio=0;
                }
                else
                {
                    MessageBox.Show("Valor invalido!");
                    return;
                }
            }
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
                DataTable precio = new DataTable();
                   
                int indice = DgvProd.CurrentRow.Index,CantAnte;
                string codi;
                decimal preciante;

                codi = DgvProd.Rows[indice].Cells[0].Value.ToString();
                precio = prod.precios(codi);
                preciante = decimal.Parse(DgvProd.Rows[indice].Cells[4].Value.ToString());
                CantAnte = int.Parse(DgvProd.Rows[indice].Cells[5].Value.ToString());


                while (CboPrecio.Items.Count > 0)
                {
                    CboPrecio.Items.RemoveAt(0);
                }
                CboPrecio.Items.Add(precio.Rows[0][0].ToString());
                CboPrecio.Items.Add(precio.Rows[0][1].ToString());
                CboPrecio.Items.Add(precio.Rows[0][2].ToString());

                CboPrecio.SelectedIndex = 0;
                DgvProd.Rows[indice].Cells[4].Value = preciante;
                DgvProd.Rows[indice].Cells[5].Value = CantAnte;
                DgvProd.Rows[indice].Cells[6].Value =(CantAnte*preciante);
                calcTot();
                TxtCod.Focus();
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

        private void CboNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ComboPresionado();
        }

        private void CboNom_TextChanged(object sender, EventArgs e)
        {
           //if (CboNom.Text.Length==0) ComboPresionado();
        }

        private void ComboPresionado()
        {
            CboNom.DroppedDown = true;
            object[] ListaOriginal = (object[])CboNom.Tag;
            if (ListaOriginal == null)
            {
                ListaOriginal = new object[CboNom.Items.Count];
                CboNom.Items.CopyTo(ListaOriginal, 0);
                CboNom.Tag = ListaOriginal;
            }
            //preparar lista de los valores que encajan
            string s = CboNom.Text.ToLower();
            IEnumerable<object> NuevaList = ListaOriginal;
            if (s.Length > 0)
            {
                NuevaList = ListaOriginal.Where(item => item.ToString().ToLower().Contains(s));
            }
            // Limpiar la lista
            while (CboNom.Items.Count > 0)
            {
                CboNom.Items.RemoveAt(0);
            }

            //Re enlistar 
            CboNom.Items.AddRange(NuevaList.ToArray());

        }

        //Funcion delegada donde se obtiene el codigo del producto
        private void BuscaRap(string cod)
        {
             listprod(cod);
        }


        private void cargacli()
        {
            DataTable datos = new DataTable();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            datos = cli.clientes();
            CboCli.DataSource = datos;
            CboCli.ValueMember = "id_cli";
            CboCli.DisplayMember = "Nombre";
            foreach (DataRow row in datos.Rows)
            {
                coleccion.Add(row["Nombre"].ToString());
            }
            CboCli.AutoCompleteMode = AutoCompleteMode.Suggest;
            CboCli.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CboCli.AutoCompleteCustomSource = coleccion;
        }

        private string idcli()
        {
            DataTable datos = new DataTable();
            string idcli;
            idcli = CboCli.SelectedValue.ToString();
            datos = cli.buscli(idcli);
            if (datos.Rows.Count > 0)
            {
                return idcli;
            }
            else

            { return "0"; }
        }

        private void CboPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambioPrecio();
        }

        private void ChkCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCredito.Checked)
            {
                BtnCobrar.Text = "Generar credito";
            }
            else
            { BtnCobrar.Text = "Cobrar"; }
        }

        private void CambioPrecio()
        {
            if (DgvProd.Rows.Count > 0)
            {
                int indice = DgvProd.CurrentRow.Index;
                decimal cant;
                int ingre = Int32.Parse(DgvProd.Rows[indice].Cells[5].Value.ToString());
                if (ingre > 0)
                {
                    if (decimal.TryParse(DgvProd.Rows[indice].Cells[4].Value.ToString(), out cant))
                    {
                        cant= decimal.Parse(CboPrecio.Text);
                        decimal subtotal = cant * ingre;
                        DgvProd.Rows[indice].Cells[4].Value = cant;
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

        private int CantxProd(string cod)
        {
            int cant,prodstock=0;
            cant = DgvProd.Rows.Count;
            for (int i = 0; i < cant; i++)
            {
                if (DgvProd.Rows[i].Cells[0].Value.ToString().Equals(cod))
                {
                    int CanTemp = 0;
                    CanTemp = int.Parse( DgvProd.Rows[i].Cells[5].Value.ToString());
                    prodstock += CanTemp;
                }
            }
            return prodstock;
        }
    }
}

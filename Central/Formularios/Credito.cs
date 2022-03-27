using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Central.Clases;
namespace Central.Formularios
{
    public partial class Credito : Form
    {
        ClaseCliente cli = new ClaseCliente();
        Venta ven = new Venta();
        PagoClase Pag = new PagoClase();
        CreditoClase Credi = new CreditoClase();
        public string idvende, Cajero;
        
        public Credito()
        {
            InitializeComponent();
        }

        #region Cargas


        private void CargaCli()
        {
            DataTable datcli = new DataTable();
            datcli = cli.clientesCre();
            CboCliente.DataSource = datcli;
            CboCliente.DisplayMember = "Nombre";
            CboCliente.ValueMember = "Id_cli";
        }

        private void CargaVenta()
        {
            string credito;
            credito = CboCre.SelectedValue.ToString();
            TxtVenta.Text = Credi.VentaxCredito(credito);
            if (TxtVenta.Text == "0")
            {

            }
            else
            {
                cargarpagos();
            }
        }

        private void CargaCredito()
        {
            string IdCli;
            DataTable datos = new DataTable();
            IdCli = CboCliente.SelectedValue.ToString();
            datos = Credi.CreditoxCli(IdCli);
            CboCre.DataSource = datos;
            CboCre.ValueMember = "id_cred";
            CboCre.DisplayMember = "Id_cred";
        }

        private void cargarpagos()
        {
            string id_venta;
            id_venta = TxtVenta.Text;
            Montospagos(id_venta);
            Listapago();
        }

        private void Montospagos(string idventa)
        {
            decimal total, pagos, saldo;
            string credito = CboCre.SelectedValue.ToString();
            string venta = TxtVenta.Text;
            total = ven.TotalVenta(venta);
            pagos = Pag.PagosHechos(credito);
            saldo = total - pagos;
            TxtPagos.Text = pagos.ToString();
            TxtSaldo.Text = saldo.ToString();
            TxtMontoV.Text = total.ToString();
            if (saldo <= 0)
            {
                MessageBox.Show("El credito ya ha sido cancelado","Credito cancelado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                bloquear();
            }
            else
            {
                desbloquear();
            }

        }


        private void Listapago()
        {
            string IdCredi;
            IdCredi = CboCre.SelectedValue.ToString();
            DataTable pagos = new DataTable();
            pagos = Pag.ListaPag(IdCredi);
            DgvPagos.DataSource = pagos;
        }
        #endregion

        private void CboCre_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboCre.SelectedValue != null && CboCre.SelectedValue.ToString() != "System.Data.DataRowView")
            { CargaVenta(); }
            
        }

        private void PanSup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Credito_Load(object sender, EventArgs e)
        {
            CargaCli();
        }

        private void CboCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboCliente.SelectedValue.ToString() != "System.Data.DataRowView")
            { CargaCredito(); }
        }

        private void BtnPago_Click(object sender, EventArgs e)
        {
            string cred, monto, detalle, fecha, cajero;
            cred = CboCre.SelectedValue.ToString();
            monto = TxtMontoPag.Text;
            detalle = "Abono a credito No."+cred;
            fecha = DateTime.Now.ToString("yyyy/MM/dd");
            cajero = idvende;
            string[] datos = {cred,monto,detalle,fecha,cajero};
            if (Pag.Guardarpago(datos))
            { MessageBox.Show("Pago registrado correctamente", "Pago correcto", MessageBoxButtons.OK,MessageBoxIcon.Information);
                Listapago();
            }
            else
            { MessageBox.Show("No se pudo registrar el pago", "pago no registrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void bloquear()
        {
            BtnPago.Enabled = false;
            TxtMontoPag.Enabled = false;
        }

        private void desbloquear()
        {
            BtnPago.Enabled = true;
            TxtMontoPag.Enabled = true;
        }
    }
}

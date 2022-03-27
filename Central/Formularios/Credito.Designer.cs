namespace Central.Formularios
{
    partial class Credito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credito));
            this.PanSup = new System.Windows.Forms.Panel();
            this.TxtVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GbxPago = new System.Windows.Forms.GroupBox();
            this.BtnPago = new System.Windows.Forms.Button();
            this.TxtMontoPag = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.TxtPagos = new System.Windows.Forms.TextBox();
            this.TxtMontoV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboCre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanCent = new System.Windows.Forms.Panel();
            this.DgvPagos = new System.Windows.Forms.DataGridView();
            this.PanSup.SuspendLayout();
            this.GbxPago.SuspendLayout();
            this.PanCent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanSup
            // 
            this.PanSup.Controls.Add(this.TxtVenta);
            this.PanSup.Controls.Add(this.label7);
            this.PanSup.Controls.Add(this.GbxPago);
            this.PanSup.Controls.Add(this.TxtSaldo);
            this.PanSup.Controls.Add(this.TxtPagos);
            this.PanSup.Controls.Add(this.TxtMontoV);
            this.PanSup.Controls.Add(this.label5);
            this.PanSup.Controls.Add(this.label4);
            this.PanSup.Controls.Add(this.label3);
            this.PanSup.Controls.Add(this.CboCre);
            this.PanSup.Controls.Add(this.label2);
            this.PanSup.Controls.Add(this.CboCliente);
            this.PanSup.Controls.Add(this.label1);
            this.PanSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSup.Location = new System.Drawing.Point(0, 0);
            this.PanSup.Margin = new System.Windows.Forms.Padding(5);
            this.PanSup.Name = "PanSup";
            this.PanSup.Size = new System.Drawing.Size(871, 203);
            this.PanSup.TabIndex = 0;
            this.PanSup.Paint += new System.Windows.Forms.PaintEventHandler(this.PanSup_Paint);
            // 
            // TxtVenta
            // 
            this.TxtVenta.Enabled = false;
            this.TxtVenta.Location = new System.Drawing.Point(12, 160);
            this.TxtVenta.Name = "TxtVenta";
            this.TxtVenta.Size = new System.Drawing.Size(100, 29);
            this.TxtVenta.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Venta";
            // 
            // GbxPago
            // 
            this.GbxPago.Controls.Add(this.BtnPago);
            this.GbxPago.Controls.Add(this.TxtMontoPag);
            this.GbxPago.Controls.Add(this.label6);
            this.GbxPago.Location = new System.Drawing.Point(618, 3);
            this.GbxPago.Name = "GbxPago";
            this.GbxPago.Size = new System.Drawing.Size(241, 192);
            this.GbxPago.TabIndex = 10;
            this.GbxPago.TabStop = false;
            this.GbxPago.Text = "Pagos";
            // 
            // BtnPago
            // 
            this.BtnPago.Image = ((System.Drawing.Image)(resources.GetObject("BtnPago.Image")));
            this.BtnPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPago.Location = new System.Drawing.Point(10, 146);
            this.BtnPago.Name = "BtnPago";
            this.BtnPago.Size = new System.Drawing.Size(104, 40);
            this.BtnPago.TabIndex = 2;
            this.BtnPago.Text = "Pago";
            this.BtnPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPago.UseVisualStyleBackColor = true;
            this.BtnPago.Click += new System.EventHandler(this.BtnPago_Click);
            // 
            // TxtMontoPag
            // 
            this.TxtMontoPag.Location = new System.Drawing.Point(6, 49);
            this.TxtMontoPag.Name = "TxtMontoPag";
            this.TxtMontoPag.Size = new System.Drawing.Size(180, 29);
            this.TxtMontoPag.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Monto";
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.BackColor = System.Drawing.Color.Gold;
            this.TxtSaldo.Enabled = false;
            this.TxtSaldo.Location = new System.Drawing.Point(256, 159);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(133, 29);
            this.TxtSaldo.TabIndex = 9;
            this.TxtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPagos
            // 
            this.TxtPagos.BackColor = System.Drawing.Color.SpringGreen;
            this.TxtPagos.Enabled = false;
            this.TxtPagos.Location = new System.Drawing.Point(256, 97);
            this.TxtPagos.Name = "TxtPagos";
            this.TxtPagos.Size = new System.Drawing.Size(133, 29);
            this.TxtPagos.TabIndex = 8;
            this.TxtPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtMontoV
            // 
            this.TxtMontoV.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtMontoV.Enabled = false;
            this.TxtMontoV.Location = new System.Drawing.Point(256, 36);
            this.TxtMontoV.Name = "TxtMontoV";
            this.TxtMontoV.Size = new System.Drawing.Size(133, 29);
            this.TxtMontoV.TabIndex = 7;
            this.TxtMontoV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Abonos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monto";
            // 
            // CboCre
            // 
            this.CboCre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCre.FormattingEnabled = true;
            this.CboCre.Location = new System.Drawing.Point(12, 97);
            this.CboCre.Name = "CboCre";
            this.CboCre.Size = new System.Drawing.Size(121, 29);
            this.CboCre.TabIndex = 3;
            this.CboCre.SelectedValueChanged += new System.EventHandler(this.CboCre_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Credito";
            // 
            // CboCliente
            // 
            this.CboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(12, 36);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(202, 29);
            this.CboCliente.TabIndex = 1;
            this.CboCliente.SelectedValueChanged += new System.EventHandler(this.CboCliente_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // PanCent
            // 
            this.PanCent.Controls.Add(this.DgvPagos);
            this.PanCent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanCent.Location = new System.Drawing.Point(0, 203);
            this.PanCent.Margin = new System.Windows.Forms.Padding(5);
            this.PanCent.Name = "PanCent";
            this.PanCent.Size = new System.Drawing.Size(871, 284);
            this.PanCent.TabIndex = 1;
            // 
            // DgvPagos
            // 
            this.DgvPagos.AllowUserToAddRows = false;
            this.DgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPagos.Location = new System.Drawing.Point(0, 0);
            this.DgvPagos.Margin = new System.Windows.Forms.Padding(5);
            this.DgvPagos.Name = "DgvPagos";
            this.DgvPagos.ReadOnly = true;
            this.DgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPagos.Size = new System.Drawing.Size(871, 284);
            this.DgvPagos.TabIndex = 0;
            // 
            // Credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 487);
            this.Controls.Add(this.PanCent);
            this.Controls.Add(this.PanSup);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Credito";
            this.Text = "Credito";
            this.Load += new System.EventHandler(this.Credito_Load);
            this.PanSup.ResumeLayout(false);
            this.PanSup.PerformLayout();
            this.GbxPago.ResumeLayout(false);
            this.GbxPago.PerformLayout();
            this.PanCent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanSup;
        private System.Windows.Forms.Panel PanCent;
        private System.Windows.Forms.DataGridView DgvPagos;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboCre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.TextBox TxtPagos;
        private System.Windows.Forms.TextBox TxtMontoV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GbxPago;
        private System.Windows.Forms.Button BtnPago;
        private System.Windows.Forms.TextBox TxtMontoPag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtVenta;
        private System.Windows.Forms.Label label7;
    }
}
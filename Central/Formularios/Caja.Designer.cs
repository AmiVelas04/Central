namespace Central.Formularios
{
    partial class Caja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja));
            this.PanSup = new System.Windows.Forms.Panel();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEgre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtIngre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CboOpe = new System.Windows.Forms.ComboBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.PanInf = new System.Windows.Forms.Panel();
            this.DgvOpe = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CboVende = new System.Windows.Forms.ComboBox();
            this.BtnTodos = new System.Windows.Forms.Button();
            this.PanSup.SuspendLayout();
            this.PanInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOpe)).BeginInit();
            this.SuspendLayout();
            // 
            // PanSup
            // 
            this.PanSup.Controls.Add(this.BtnTodos);
            this.PanSup.Controls.Add(this.CboVende);
            this.PanSup.Controls.Add(this.label8);
            this.PanSup.Controls.Add(this.label7);
            this.PanSup.Controls.Add(this.BtnAbrir);
            this.PanSup.Controls.Add(this.button1);
            this.PanSup.Controls.Add(this.TxtTotal);
            this.PanSup.Controls.Add(this.label6);
            this.PanSup.Controls.Add(this.TxtEgre);
            this.PanSup.Controls.Add(this.label5);
            this.PanSup.Controls.Add(this.TxtIngre);
            this.PanSup.Controls.Add(this.label4);
            this.PanSup.Controls.Add(this.TxtMonto);
            this.PanSup.Controls.Add(this.label3);
            this.PanSup.Controls.Add(this.BtnImprimir);
            this.PanSup.Controls.Add(this.BtnIngresar);
            this.PanSup.Controls.Add(this.BtnBuscar);
            this.PanSup.Controls.Add(this.TxtDesc);
            this.PanSup.Controls.Add(this.label2);
            this.PanSup.Controls.Add(this.label1);
            this.PanSup.Controls.Add(this.CboOpe);
            this.PanSup.Controls.Add(this.DtpFecha);
            this.PanSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanSup.Location = new System.Drawing.Point(0, 0);
            this.PanSup.Margin = new System.Windows.Forms.Padding(4);
            this.PanSup.Name = "PanSup";
            this.PanSup.Size = new System.Drawing.Size(832, 233);
            this.PanSup.TabIndex = 0;
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbrir.Image")));
            this.BtnAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbrir.Location = new System.Drawing.Point(338, 124);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(120, 38);
            this.BtnAbrir.TabIndex = 17;
            this.BtnAbrir.Text = "Abrir Caja";
            this.BtnAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Visible = false;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cierre de caja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.Color.LightGreen;
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(662, 147);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(158, 43);
            this.TxtTotal.TabIndex = 15;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(574, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total";
            // 
            // TxtEgre
            // 
            this.TxtEgre.BackColor = System.Drawing.Color.LightCoral;
            this.TxtEgre.Enabled = false;
            this.TxtEgre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEgre.Location = new System.Drawing.Point(662, 95);
            this.TxtEgre.Name = "TxtEgre";
            this.TxtEgre.Size = new System.Drawing.Size(158, 35);
            this.TxtEgre.TabIndex = 13;
            this.TxtEgre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(574, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Egresos";
            // 
            // TxtIngre
            // 
            this.TxtIngre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtIngre.Enabled = false;
            this.TxtIngre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIngre.Location = new System.Drawing.Point(662, 41);
            this.TxtIngre.Name = "TxtIngre";
            this.TxtIngre.Size = new System.Drawing.Size(158, 35);
            this.TxtIngre.TabIndex = 11;
            this.TxtIngre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(574, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ingresos";
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(31, 194);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(158, 25);
            this.TxtMonto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Monto";
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("BtnImprimir.Image")));
            this.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprimir.Location = new System.Drawing.Point(212, 124);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(120, 38);
            this.BtnImprimir.TabIndex = 7;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Visible = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(266, 168);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(154, 38);
            this.BtnIngresar.TabIndex = 6;
            this.BtnIngresar.Text = "Ingresar a Caja";
            this.BtnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(213, 78);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(120, 38);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Visible = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(31, 144);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(158, 25);
            this.TxtDesc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operacion";
            // 
            // CboOpe
            // 
            this.CboOpe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboOpe.FormattingEnabled = true;
            this.CboOpe.Location = new System.Drawing.Point(31, 90);
            this.CboOpe.Name = "CboOpe";
            this.CboOpe.Size = new System.Drawing.Size(168, 25);
            this.CboOpe.TabIndex = 1;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(31, 34);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(168, 25);
            this.DtpFecha.TabIndex = 0;
            // 
            // PanInf
            // 
            this.PanInf.Controls.Add(this.DgvOpe);
            this.PanInf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanInf.Location = new System.Drawing.Point(0, 233);
            this.PanInf.Margin = new System.Windows.Forms.Padding(4);
            this.PanInf.Name = "PanInf";
            this.PanInf.Size = new System.Drawing.Size(832, 185);
            this.PanInf.TabIndex = 1;
            // 
            // DgvOpe
            // 
            this.DgvOpe.AllowUserToAddRows = false;
            this.DgvOpe.AllowUserToDeleteRows = false;
            this.DgvOpe.AllowUserToResizeColumns = false;
            this.DgvOpe.AllowUserToResizeRows = false;
            this.DgvOpe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvOpe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOpe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvOpe.EnableHeadersVisualStyles = false;
            this.DgvOpe.Location = new System.Drawing.Point(0, 0);
            this.DgvOpe.Name = "DgvOpe";
            this.DgvOpe.ReadOnly = true;
            this.DgvOpe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvOpe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOpe.Size = new System.Drawing.Size(832, 185);
            this.DgvOpe.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Vendedor";
            this.label8.Visible = false;
            // 
            // CboVende
            // 
            this.CboVende.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboVende.FormattingEnabled = true;
            this.CboVende.Location = new System.Drawing.Point(219, 34);
            this.CboVende.Name = "CboVende";
            this.CboVende.Size = new System.Drawing.Size(201, 25);
            this.CboVende.TabIndex = 20;
            this.CboVende.Visible = false;
            // 
            // BtnTodos
            // 
            this.BtnTodos.Image = ((System.Drawing.Image)(resources.GetObject("BtnTodos.Image")));
            this.BtnTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTodos.Location = new System.Drawing.Point(339, 80);
            this.BtnTodos.Name = "BtnTodos";
            this.BtnTodos.Size = new System.Drawing.Size(120, 38);
            this.BtnTodos.TabIndex = 21;
            this.BtnTodos.Text = "Caja Gen.";
            this.BtnTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTodos.UseVisualStyleBackColor = true;
            this.BtnTodos.Visible = false;
            this.BtnTodos.Click += new System.EventHandler(this.BtnTodos_Click);
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 418);
            this.Controls.Add(this.PanInf);
            this.Controls.Add(this.PanSup);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Caja";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.Caja_Load);
            this.PanSup.ResumeLayout(false);
            this.PanSup.PerformLayout();
            this.PanInf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOpe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanSup;
        private System.Windows.Forms.Panel PanInf;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboOpe;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.DataGridView DgvOpe;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtEgre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtIngre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboVende;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnTodos;
    }
}
namespace Central.Formularios
{
    partial class CancelVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelVentas));
            this.PanSup = new System.Windows.Forms.Panel();
            this.PanCent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CboVen = new System.Windows.Forms.ComboBox();
            this.Dgv1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtp1 = new System.Windows.Forms.DateTimePicker();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnAnul = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCaje = new System.Windows.Forms.TextBox();
            this.Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanSup.SuspendLayout();
            this.PanCent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanSup
            // 
            this.PanSup.Controls.Add(this.TxtCaje);
            this.PanSup.Controls.Add(this.label3);
            this.PanSup.Controls.Add(this.BtnAnul);
            this.PanSup.Controls.Add(this.BtnSearch);
            this.PanSup.Controls.Add(this.Dtp1);
            this.PanSup.Controls.Add(this.label2);
            this.PanSup.Controls.Add(this.CboVen);
            this.PanSup.Controls.Add(this.label1);
            this.PanSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSup.Location = new System.Drawing.Point(0, 0);
            this.PanSup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanSup.Name = "PanSup";
            this.PanSup.Size = new System.Drawing.Size(733, 111);
            this.PanSup.TabIndex = 0;
            // 
            // PanCent
            // 
            this.PanCent.Controls.Add(this.Dgv1);
            this.PanCent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanCent.Location = new System.Drawing.Point(0, 111);
            this.PanCent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanCent.Name = "PanCent";
            this.PanCent.Size = new System.Drawing.Size(733, 321);
            this.PanCent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venta";
            // 
            // CboVen
            // 
            this.CboVen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboVen.FormattingEnabled = true;
            this.CboVen.Location = new System.Drawing.Point(12, 33);
            this.CboVen.Name = "CboVen";
            this.CboVen.Size = new System.Drawing.Size(120, 29);
            this.CboVen.TabIndex = 1;
            // 
            // Dgv1
            // 
            this.Dgv1.AllowUserToAddRows = false;
            this.Dgv1.AllowUserToDeleteRows = false;
            this.Dgv1.AllowUserToResizeColumns = false;
            this.Dgv1.AllowUserToResizeRows = false;
            this.Dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prod,
            this.Cant,
            this.Precio,
            this.Subt});
            this.Dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv1.Enabled = false;
            this.Dgv1.Location = new System.Drawing.Point(0, 0);
            this.Dgv1.Name = "Dgv1";
            this.Dgv1.ReadOnly = true;
            this.Dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv1.Size = new System.Drawing.Size(733, 321);
            this.Dgv1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // Dtp1
            // 
            this.Dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp1.Location = new System.Drawing.Point(335, 33);
            this.Dtp1.Name = "Dtp1";
            this.Dtp1.Size = new System.Drawing.Size(129, 29);
            this.Dtp1.TabIndex = 3;
            this.Dtp1.Value = new System.DateTime(2023, 9, 27, 0, 0, 0, 0);
            this.Dtp1.ValueChanged += new System.EventHandler(this.Dtp1_ValueChanged);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(604, 12);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(117, 41);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnAnul
            // 
            this.BtnAnul.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnul.Image")));
            this.BtnAnul.Location = new System.Drawing.Point(604, 62);
            this.BtnAnul.Name = "BtnAnul";
            this.BtnAnul.Size = new System.Drawing.Size(117, 41);
            this.BtnAnul.TabIndex = 5;
            this.BtnAnul.Text = "Anular";
            this.BtnAnul.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnul.UseVisualStyleBackColor = true;
            this.BtnAnul.Click += new System.EventHandler(this.BtnAnul_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Operó";
            // 
            // TxtCaje
            // 
            this.TxtCaje.Enabled = false;
            this.TxtCaje.Location = new System.Drawing.Point(138, 33);
            this.TxtCaje.Name = "TxtCaje";
            this.TxtCaje.Size = new System.Drawing.Size(175, 29);
            this.TxtCaje.TabIndex = 7;
            // 
            // Prod
            // 
            this.Prod.HeaderText = "Producto";
            this.Prod.Name = "Prod";
            this.Prod.ReadOnly = true;
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Cantidad";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Subt
            // 
            this.Subt.HeaderText = "SubTotal";
            this.Subt.Name = "Subt";
            this.Subt.ReadOnly = true;
            // 
            // CancelVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 432);
            this.Controls.Add(this.PanCent);
            this.Controls.Add(this.PanSup);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CancelVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Anular ventas";
            this.PanSup.ResumeLayout(false);
            this.PanSup.PerformLayout();
            this.PanCent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanSup;
        private System.Windows.Forms.Panel PanCent;
        private System.Windows.Forms.ComboBox CboVen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv1;
        private System.Windows.Forms.Button BtnAnul;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtCaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subt;
    }
}
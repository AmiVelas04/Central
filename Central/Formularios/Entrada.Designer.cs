namespace Central.Formularios
{
    partial class Entrada
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
            this.PanSup = new System.Windows.Forms.Panel();
            this.PanCent = new System.Windows.Forms.Panel();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTot = new System.Windows.Forms.Label();
            this.TxtProve = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanSup.SuspendLayout();
            this.PanCent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanSup
            // 
            this.PanSup.Controls.Add(this.label1);
            this.PanSup.Controls.Add(this.TxtProve);
            this.PanSup.Controls.Add(this.LblTot);
            this.PanSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSup.Location = new System.Drawing.Point(0, 0);
            this.PanSup.Name = "PanSup";
            this.PanSup.Size = new System.Drawing.Size(802, 107);
            this.PanSup.TabIndex = 0;
            // 
            // PanCent
            // 
            this.PanCent.Controls.Add(this.DgvDatos);
            this.PanCent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanCent.Location = new System.Drawing.Point(0, 107);
            this.PanCent.Name = "PanCent";
            this.PanCent.Size = new System.Drawing.Size(802, 260);
            this.PanCent.TabIndex = 1;
            // 
            // DgvDatos
            // 
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Desc,
            this.Marca,
            this.Costo,
            this.PrecioV,
            this.PrecioV2,
            this.PrecioV3,
            this.Cant});
            this.DgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDatos.Location = new System.Drawing.Point(0, 0);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.Size = new System.Drawing.Size(802, 260);
            this.DgvDatos.TabIndex = 0;
            this.DgvDatos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatos_CellEndEdit);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Descripcion";
            this.Desc.Name = "Desc";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // PrecioV
            // 
            this.PrecioV.HeaderText = "PrecioV1";
            this.PrecioV.Name = "PrecioV";
            // 
            // PrecioV2
            // 
            this.PrecioV2.HeaderText = "PrecioV2";
            this.PrecioV2.Name = "PrecioV2";
            // 
            // PrecioV3
            // 
            this.PrecioV3.HeaderText = "PrecioV3";
            this.PrecioV3.Name = "PrecioV3";
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Cantidad";
            this.Cant.Name = "Cant";
            // 
            // LblTot
            // 
            this.LblTot.AutoSize = true;
            this.LblTot.Location = new System.Drawing.Point(573, 46);
            this.LblTot.Name = "LblTot";
            this.LblTot.Size = new System.Drawing.Size(13, 13);
            this.LblTot.TabIndex = 0;
            this.LblTot.Text = "0";
            // 
            // TxtProve
            // 
            this.TxtProve.Location = new System.Drawing.Point(392, 20);
            this.TxtProve.Name = "TxtProve";
            this.TxtProve.Size = new System.Drawing.Size(100, 20);
            this.TxtProve.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proveedor";
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 367);
            this.Controls.Add(this.PanCent);
            this.Controls.Add(this.PanSup);
            this.Name = "Entrada";
            this.Text = "Entrada";
            this.PanSup.ResumeLayout(false);
            this.PanSup.PerformLayout();
            this.PanCent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanSup;
        private System.Windows.Forms.Panel PanCent;
        private System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.Label LblTot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtProve;
    }
}
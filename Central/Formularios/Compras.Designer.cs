namespace Central.Formularios
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            this.PanSup = new System.Windows.Forms.Panel();
            this.BtnIng = new System.Windows.Forms.Button();
            this.BtnElim = new System.Windows.Forms.Button();
            this.TxtProve = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanCent = new System.Windows.Forms.Panel();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.IdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venta1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venta2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venta3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanSup.SuspendLayout();
            this.PanCent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanSup
            // 
            this.PanSup.Controls.Add(this.label2);
            this.PanSup.Controls.Add(this.LblTot);
            this.PanSup.Controls.Add(this.BtnIng);
            this.PanSup.Controls.Add(this.BtnElim);
            this.PanSup.Controls.Add(this.TxtProve);
            this.PanSup.Controls.Add(this.label1);
            this.PanSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSup.Location = new System.Drawing.Point(0, 0);
            this.PanSup.Name = "PanSup";
            this.PanSup.Size = new System.Drawing.Size(743, 115);
            this.PanSup.TabIndex = 0;
            // 
            // BtnIng
            // 
            this.BtnIng.Image = ((System.Drawing.Image)(resources.GetObject("BtnIng.Image")));
            this.BtnIng.Location = new System.Drawing.Point(506, 32);
            this.BtnIng.Name = "BtnIng";
            this.BtnIng.Size = new System.Drawing.Size(95, 46);
            this.BtnIng.TabIndex = 4;
            this.BtnIng.Text = "Ingresar";
            this.BtnIng.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIng.UseVisualStyleBackColor = true;
            this.BtnIng.Click += new System.EventHandler(this.BtnIng_Click);
            // 
            // BtnElim
            // 
            this.BtnElim.Image = ((System.Drawing.Image)(resources.GetObject("BtnElim.Image")));
            this.BtnElim.Location = new System.Drawing.Point(622, 21);
            this.BtnElim.Name = "BtnElim";
            this.BtnElim.Size = new System.Drawing.Size(95, 66);
            this.BtnElim.TabIndex = 2;
            this.BtnElim.Text = "Borrar Producto";
            this.BtnElim.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnElim.UseVisualStyleBackColor = true;
            this.BtnElim.Click += new System.EventHandler(this.BtnElim_Click);
            // 
            // TxtProve
            // 
            this.TxtProve.Location = new System.Drawing.Point(12, 42);
            this.TxtProve.Name = "TxtProve";
            this.TxtProve.Size = new System.Drawing.Size(100, 20);
            this.TxtProve.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            // 
            // PanCent
            // 
            this.PanCent.Controls.Add(this.DgvDatos);
            this.PanCent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanCent.Location = new System.Drawing.Point(0, 115);
            this.PanCent.Name = "PanCent";
            this.PanCent.Size = new System.Drawing.Size(743, 394);
            this.PanCent.TabIndex = 1;
            // 
            // DgvDatos
            // 
            this.DgvDatos.AllowUserToDeleteRows = false;
            this.DgvDatos.AllowUserToResizeRows = false;
            this.DgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProd,
            this.Nom,
            this.Desc,
            this.Marca,
            this.Costo,
            this.Venta1,
            this.Venta2,
            this.Venta3,
            this.Cant});
            this.DgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDatos.Location = new System.Drawing.Point(0, 0);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvDatos.Size = new System.Drawing.Size(743, 394);
            this.DgvDatos.TabIndex = 0;
            this.DgvDatos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatos_CellEndEdit);
            this.DgvDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatos_CellEnter);
            // 
            // IdProd
            // 
            this.IdProd.HeaderText = "Codigo";
            this.IdProd.Name = "IdProd";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Producto";
            this.Nom.Name = "Nom";
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
            // Venta1
            // 
            this.Venta1.HeaderText = "Venta 1";
            this.Venta1.Name = "Venta1";
            // 
            // Venta2
            // 
            this.Venta2.HeaderText = "Venta 2";
            this.Venta2.Name = "Venta2";
            // 
            // Venta3
            // 
            this.Venta3.HeaderText = "Venta 3";
            this.Venta3.Name = "Venta3";
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Cantidad";
            this.Cant.Name = "Cant";
            // 
            // LblTot
            // 
            this.LblTot.AutoSize = true;
            this.LblTot.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTot.Location = new System.Drawing.Point(381, 53);
            this.LblTot.Name = "LblTot";
            this.LblTot.Size = new System.Drawing.Size(23, 25);
            this.LblTot.TabIndex = 5;
            this.LblTot.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total de productos";
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 509);
            this.Controls.Add(this.PanCent);
            this.Controls.Add(this.PanSup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compras";
            this.Text = "Compras";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venta3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIng;
        private System.Windows.Forms.Button BtnElim;
        private System.Windows.Forms.TextBox TxtProve;
        private System.Windows.Forms.Label LblTot;
        private System.Windows.Forms.Label label2;
    }
}
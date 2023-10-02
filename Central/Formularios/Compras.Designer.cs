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
            this.PanSup = new System.Windows.Forms.Panel();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnIng = new System.Windows.Forms.Button();
            this.PanSup.SuspendLayout();
            this.PanCent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanSup
            // 
            this.PanSup.Controls.Add(this.BtnIng);
            this.PanSup.Controls.Add(this.button2);
            this.PanSup.Controls.Add(this.Btn);
            this.PanSup.Controls.Add(this.textBox1);
            this.PanSup.Controls.Add(this.label1);
            this.PanSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSup.Location = new System.Drawing.Point(0, 0);
            this.PanSup.Name = "PanSup";
            this.PanSup.Size = new System.Drawing.Size(853, 115);
            this.PanSup.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // PanCent
            // 
            this.PanCent.Controls.Add(this.DgvDatos);
            this.PanCent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanCent.Location = new System.Drawing.Point(0, 115);
            this.PanCent.Name = "PanCent";
            this.PanCent.Size = new System.Drawing.Size(853, 380);
            this.PanCent.TabIndex = 1;
            // 
            // DgvDatos
            // 
            this.DgvDatos.AllowUserToDeleteRows = false;
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
            this.DgvDatos.Size = new System.Drawing.Size(853, 380);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(567, 12);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(95, 46);
            this.Btn.TabIndex = 2;
            this.Btn.Text = "button1";
            this.Btn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(567, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnIng
            // 
            this.BtnIng.Location = new System.Drawing.Point(700, 32);
            this.BtnIng.Name = "BtnIng";
            this.BtnIng.Size = new System.Drawing.Size(95, 46);
            this.BtnIng.TabIndex = 4;
            this.BtnIng.Text = "Ingresar";
            this.BtnIng.UseVisualStyleBackColor = true;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 495);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.TextBox textBox1;
    }
}
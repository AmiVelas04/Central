namespace Central.Formularios
{
    partial class BuscaRap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaRap));
            this.PanSup = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Txtprod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanCent = new System.Windows.Forms.Panel();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.PanSup.SuspendLayout();
            this.PanCent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanSup
            // 
            this.PanSup.Controls.Add(this.BtnAdd);
            this.PanSup.Controls.Add(this.Txtprod);
            this.PanSup.Controls.Add(this.label1);
            this.PanSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSup.Location = new System.Drawing.Point(0, 0);
            this.PanSup.Margin = new System.Windows.Forms.Padding(5);
            this.PanSup.Name = "PanSup";
            this.PanSup.Size = new System.Drawing.Size(892, 83);
            this.PanSup.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(760, 21);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(120, 41);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Txtprod
            // 
            this.Txtprod.Location = new System.Drawing.Point(12, 33);
            this.Txtprod.Name = "Txtprod";
            this.Txtprod.Size = new System.Drawing.Size(516, 29);
            this.Txtprod.TabIndex = 1;
            this.Txtprod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtprod_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // PanCent
            // 
            this.PanCent.Controls.Add(this.DgvDatos);
            this.PanCent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanCent.Location = new System.Drawing.Point(0, 83);
            this.PanCent.Margin = new System.Windows.Forms.Padding(5);
            this.PanCent.Name = "PanCent";
            this.PanCent.Size = new System.Drawing.Size(892, 309);
            this.PanCent.TabIndex = 1;
            // 
            // DgvDatos
            // 
            this.DgvDatos.AllowUserToAddRows = false;
            this.DgvDatos.AllowUserToDeleteRows = false;
            this.DgvDatos.AllowUserToResizeColumns = false;
            this.DgvDatos.AllowUserToResizeRows = false;
            this.DgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDatos.Location = new System.Drawing.Point(0, 0);
            this.DgvDatos.Margin = new System.Windows.Forms.Padding(5);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.ReadOnly = true;
            this.DgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDatos.Size = new System.Drawing.Size(892, 309);
            this.DgvDatos.TabIndex = 0;
            // 
            // BuscaRap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 392);
            this.Controls.Add(this.PanCent);
            this.Controls.Add(this.PanSup);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BuscaRap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda rápida";
            this.Load += new System.EventHandler(this.BuscaRap_Load);
            this.PanSup.ResumeLayout(false);
            this.PanSup.PerformLayout();
            this.PanCent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanSup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanCent;
        private System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox Txtprod;
    }
}
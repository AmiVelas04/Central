namespace Central.Formularios
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.PanLat = new System.Windows.Forms.Panel();
            this.BtnCap = new System.Windows.Forms.Button();
            this.BtnCaja = new System.Windows.Forms.Button();
            this.BtnREportes = new System.Windows.Forms.Button();
            this.BtnUsu = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.PanSup = new System.Windows.Forms.Panel();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.LblUsu = new System.Windows.Forms.Label();
            this.PanCentral = new System.Windows.Forms.Panel();
            this.PanLat.SuspendLayout();
            this.PanSup.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanLat
            // 
            this.PanLat.BackColor = System.Drawing.Color.Gray;
            this.PanLat.Controls.Add(this.BtnCap);
            this.PanLat.Controls.Add(this.BtnCaja);
            this.PanLat.Controls.Add(this.BtnREportes);
            this.PanLat.Controls.Add(this.BtnUsu);
            this.PanLat.Controls.Add(this.BtnProductos);
            this.PanLat.Controls.Add(this.BtnVentas);
            this.PanLat.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanLat.Location = new System.Drawing.Point(0, 0);
            this.PanLat.Name = "PanLat";
            this.PanLat.Size = new System.Drawing.Size(131, 600);
            this.PanLat.TabIndex = 0;
            // 
            // BtnCap
            // 
            this.BtnCap.FlatAppearance.BorderSize = 0;
            this.BtnCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCap.Image = ((System.Drawing.Image)(resources.GetObject("BtnCap.Image")));
            this.BtnCap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCap.Location = new System.Drawing.Point(3, 549);
            this.BtnCap.Name = "BtnCap";
            this.BtnCap.Size = new System.Drawing.Size(122, 48);
            this.BtnCap.TabIndex = 5;
            this.BtnCap.Text = "Respaldo";
            this.BtnCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCap.UseVisualStyleBackColor = true;
            this.BtnCap.Click += new System.EventHandler(this.BtnCap_Click);
            // 
            // BtnCaja
            // 
            this.BtnCaja.FlatAppearance.BorderSize = 0;
            this.BtnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCaja.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCaja.Image = ((System.Drawing.Image)(resources.GetObject("BtnCaja.Image")));
            this.BtnCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCaja.Location = new System.Drawing.Point(0, 294);
            this.BtnCaja.Name = "BtnCaja";
            this.BtnCaja.Size = new System.Drawing.Size(131, 35);
            this.BtnCaja.TabIndex = 4;
            this.BtnCaja.Text = "Caja";
            this.BtnCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCaja.UseVisualStyleBackColor = true;
            this.BtnCaja.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnREportes
            // 
            this.BtnREportes.FlatAppearance.BorderSize = 0;
            this.BtnREportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnREportes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnREportes.Image = ((System.Drawing.Image)(resources.GetObject("BtnREportes.Image")));
            this.BtnREportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnREportes.Location = new System.Drawing.Point(-9, 237);
            this.BtnREportes.Name = "BtnREportes";
            this.BtnREportes.Size = new System.Drawing.Size(140, 44);
            this.BtnREportes.TabIndex = 3;
            this.BtnREportes.Text = "Reportes";
            this.BtnREportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnREportes.UseVisualStyleBackColor = true;
            this.BtnREportes.Click += new System.EventHandler(this.BtnREportes_Click);
            // 
            // BtnUsu
            // 
            this.BtnUsu.FlatAppearance.BorderSize = 0;
            this.BtnUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsu.Image = ((System.Drawing.Image)(resources.GetObject("BtnUsu.Image")));
            this.BtnUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsu.Location = new System.Drawing.Point(-9, 183);
            this.BtnUsu.Name = "BtnUsu";
            this.BtnUsu.Size = new System.Drawing.Size(140, 40);
            this.BtnUsu.TabIndex = 2;
            this.BtnUsu.Text = "Usuarios";
            this.BtnUsu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUsu.UseVisualStyleBackColor = true;
            this.BtnUsu.Click += new System.EventHandler(this.BtnUsu_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.Image = ((System.Drawing.Image)(resources.GetObject("BtnProductos.Image")));
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.Location = new System.Drawing.Point(-9, 128);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(140, 40);
            this.BtnProductos.TabIndex = 1;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnVentas
            // 
            this.BtnVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.Image = ((System.Drawing.Image)(resources.GetObject("BtnVentas.Image")));
            this.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.Location = new System.Drawing.Point(-9, 66);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(140, 47);
            this.BtnVentas.TabIndex = 0;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVentas.UseVisualStyleBackColor = true;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // PanSup
            // 
            this.PanSup.BackColor = System.Drawing.Color.Gray;
            this.PanSup.Controls.Add(this.BtnMin);
            this.PanSup.Controls.Add(this.BtnCerrar);
            this.PanSup.Controls.Add(this.LblUsu);
            this.PanSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSup.Location = new System.Drawing.Point(131, 0);
            this.PanSup.Name = "PanSup";
            this.PanSup.Size = new System.Drawing.Size(869, 66);
            this.PanSup.TabIndex = 1;
            this.PanSup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanSup_MouseDown);
            // 
            // BtnMin
            // 
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Image = ((System.Drawing.Image)(resources.GetObject("BtnMin.Image")));
            this.BtnMin.Location = new System.Drawing.Point(748, 5);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(55, 55);
            this.BtnMin.TabIndex = 2;
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrar.Location = new System.Drawing.Point(809, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(60, 63);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblUsu
            // 
            this.LblUsu.AutoSize = true;
            this.LblUsu.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsu.ForeColor = System.Drawing.Color.White;
            this.LblUsu.Location = new System.Drawing.Point(40, 22);
            this.LblUsu.Name = "LblUsu";
            this.LblUsu.Size = new System.Drawing.Size(56, 21);
            this.LblUsu.TabIndex = 0;
            this.LblUsu.Text = "label1";
            // 
            // PanCentral
            // 
            this.PanCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.PanCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanCentral.Location = new System.Drawing.Point(131, 66);
            this.PanCentral.Name = "PanCentral";
            this.PanCentral.Size = new System.Drawing.Size(869, 534);
            this.PanCentral.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.PanCentral);
            this.Controls.Add(this.PanSup);
            this.Controls.Add(this.PanLat);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.PanLat.ResumeLayout(false);
            this.PanSup.ResumeLayout(false);
            this.PanSup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanLat;
        private System.Windows.Forms.Panel PanSup;
        private System.Windows.Forms.Panel PanCentral;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.Button BtnUsu;
        private System.Windows.Forms.Button BtnREportes;
        private System.Windows.Forms.Label LblUsu;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnCaja;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnCap;
    }
}
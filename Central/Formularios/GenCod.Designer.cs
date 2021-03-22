namespace Central.Formularios
{
    partial class GenCod
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
            this.PanIz = new System.Windows.Forms.Panel();
            this.PcbCod = new System.Windows.Forms.PictureBox();
            this.ChkEditar = new System.Windows.Forms.CheckBox();
            this.NudEtiqueta = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodBarras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanDer = new System.Windows.Forms.Panel();
            this.BtnImp = new System.Windows.Forms.Button();
            this.BtnGen = new System.Windows.Forms.Button();
            this.PanIz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudEtiqueta)).BeginInit();
            this.PanDer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanIz
            // 
            this.PanIz.Controls.Add(this.PcbCod);
            this.PanIz.Controls.Add(this.ChkEditar);
            this.PanIz.Controls.Add(this.NudEtiqueta);
            this.PanIz.Controls.Add(this.label2);
            this.PanIz.Controls.Add(this.TxtCodBarras);
            this.PanIz.Controls.Add(this.label1);
            this.PanIz.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanIz.Location = new System.Drawing.Point(0, 0);
            this.PanIz.Name = "PanIz";
            this.PanIz.Size = new System.Drawing.Size(391, 159);
            this.PanIz.TabIndex = 0;
            // 
            // PcbCod
            // 
            this.PcbCod.Location = new System.Drawing.Point(259, 103);
            this.PcbCod.Name = "PcbCod";
            this.PcbCod.Size = new System.Drawing.Size(51, 37);
            this.PcbCod.TabIndex = 5;
            this.PcbCod.TabStop = false;
            this.PcbCod.Visible = false;
            // 
            // ChkEditar
            // 
            this.ChkEditar.AutoSize = true;
            this.ChkEditar.Location = new System.Drawing.Point(299, 44);
            this.ChkEditar.Name = "ChkEditar";
            this.ChkEditar.Size = new System.Drawing.Size(76, 24);
            this.ChkEditar.TabIndex = 4;
            this.ChkEditar.Text = "Editar";
            this.ChkEditar.UseVisualStyleBackColor = true;
            this.ChkEditar.CheckedChanged += new System.EventHandler(this.ChkEditar_CheckedChanged);
            // 
            // NudEtiqueta
            // 
            this.NudEtiqueta.Location = new System.Drawing.Point(89, 115);
            this.NudEtiqueta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudEtiqueta.Name = "NudEtiqueta";
            this.NudEtiqueta.Size = new System.Drawing.Size(74, 26);
            this.NudEtiqueta.TabIndex = 3;
            this.NudEtiqueta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de etiquetas";
            // 
            // TxtCodBarras
            // 
            this.TxtCodBarras.Enabled = false;
            this.TxtCodBarras.Location = new System.Drawing.Point(23, 44);
            this.TxtCodBarras.Name = "TxtCodBarras";
            this.TxtCodBarras.Size = new System.Drawing.Size(270, 26);
            this.TxtCodBarras.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de barras";
            // 
            // PanDer
            // 
            this.PanDer.Controls.Add(this.BtnImp);
            this.PanDer.Controls.Add(this.BtnGen);
            this.PanDer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanDer.Location = new System.Drawing.Point(391, 0);
            this.PanDer.Name = "PanDer";
            this.PanDer.Size = new System.Drawing.Size(224, 159);
            this.PanDer.TabIndex = 1;
            // 
            // BtnImp
            // 
            this.BtnImp.Location = new System.Drawing.Point(37, 92);
            this.BtnImp.Name = "BtnImp";
            this.BtnImp.Size = new System.Drawing.Size(165, 55);
            this.BtnImp.TabIndex = 1;
            this.BtnImp.Text = "Imprimir código";
            this.BtnImp.UseVisualStyleBackColor = true;
            this.BtnImp.Click += new System.EventHandler(this.BtnImp_Click);
            // 
            // BtnGen
            // 
            this.BtnGen.Location = new System.Drawing.Point(37, 12);
            this.BtnGen.Name = "BtnGen";
            this.BtnGen.Size = new System.Drawing.Size(165, 55);
            this.BtnGen.TabIndex = 0;
            this.BtnGen.Text = "Generar código";
            this.BtnGen.UseVisualStyleBackColor = true;
            this.BtnGen.Click += new System.EventHandler(this.BtnGen_Click);
            // 
            // GenCod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 159);
            this.Controls.Add(this.PanDer);
            this.Controls.Add(this.PanIz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenCod";
            this.Text = "Generacion de código";
            this.PanIz.ResumeLayout(false);
            this.PanIz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudEtiqueta)).EndInit();
            this.PanDer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanIz;
        private System.Windows.Forms.NumericUpDown NudEtiqueta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodBarras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanDer;
        private System.Windows.Forms.CheckBox ChkEditar;
        private System.Windows.Forms.Button BtnImp;
        private System.Windows.Forms.Button BtnGen;
        private System.Windows.Forms.PictureBox PcbCod;
    }
}
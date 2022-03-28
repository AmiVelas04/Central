namespace Central.Formularios
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.PanIzq = new System.Windows.Forms.Panel();
            this.GbxDatCli = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PanInf = new System.Windows.Forms.Panel();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnBusq = new System.Windows.Forms.Button();
            this.TxtClinom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PnaCent = new System.Windows.Forms.Panel();
            this.DgvCli = new System.Windows.Forms.DataGridView();
            this.PanIzq.SuspendLayout();
            this.GbxDatCli.SuspendLayout();
            this.PanInf.SuspendLayout();
            this.PnaCent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCli)).BeginInit();
            this.SuspendLayout();
            // 
            // PanIzq
            // 
            this.PanIzq.Controls.Add(this.GbxDatCli);
            this.PanIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanIzq.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanIzq.Location = new System.Drawing.Point(0, 0);
            this.PanIzq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanIzq.Name = "PanIzq";
            this.PanIzq.Size = new System.Drawing.Size(249, 487);
            this.PanIzq.TabIndex = 0;
            // 
            // GbxDatCli
            // 
            this.GbxDatCli.Controls.Add(this.BtnSave);
            this.GbxDatCli.Controls.Add(this.TxtTel);
            this.GbxDatCli.Controls.Add(this.label4);
            this.GbxDatCli.Controls.Add(this.TxtDir);
            this.GbxDatCli.Controls.Add(this.label3);
            this.GbxDatCli.Controls.Add(this.TxtNom);
            this.GbxDatCli.Controls.Add(this.label2);
            this.GbxDatCli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbxDatCli.Location = new System.Drawing.Point(0, 0);
            this.GbxDatCli.Name = "GbxDatCli";
            this.GbxDatCli.Size = new System.Drawing.Size(249, 487);
            this.GbxDatCli.TabIndex = 0;
            this.GbxDatCli.TabStop = false;
            this.GbxDatCli.Text = "Datos Cliente";
            // 
            // BtnSave
            // 
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(3, 446);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(243, 38);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(12, 222);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(230, 27);
            this.TxtTel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teléfono";
            // 
            // TxtDir
            // 
            this.TxtDir.Location = new System.Drawing.Point(12, 135);
            this.TxtDir.Name = "TxtDir";
            this.TxtDir.Size = new System.Drawing.Size(230, 27);
            this.TxtDir.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección";
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(12, 59);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(230, 27);
            this.TxtNom.TabIndex = 1;
            this.TxtNom.Tag = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // PanInf
            // 
            this.PanInf.Controls.Add(this.BtnLimpiar);
            this.PanInf.Controls.Add(this.BtnEdit);
            this.PanInf.Controls.Add(this.BtnBusq);
            this.PanInf.Controls.Add(this.TxtClinom);
            this.PanInf.Controls.Add(this.label1);
            this.PanInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanInf.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanInf.Location = new System.Drawing.Point(249, 417);
            this.PanInf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanInf.Name = "PanInf";
            this.PanInf.Size = new System.Drawing.Size(622, 70);
            this.PanInf.TabIndex = 1;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(517, 25);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(93, 35);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.Location = new System.Drawing.Point(401, 25);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(93, 35);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnBusq
            // 
            this.BtnBusq.Image = ((System.Drawing.Image)(resources.GetObject("BtnBusq.Image")));
            this.BtnBusq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBusq.Location = new System.Drawing.Point(282, 25);
            this.BtnBusq.Name = "BtnBusq";
            this.BtnBusq.Size = new System.Drawing.Size(103, 35);
            this.BtnBusq.TabIndex = 2;
            this.BtnBusq.Text = "Buscar";
            this.BtnBusq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBusq.UseVisualStyleBackColor = true;
            this.BtnBusq.Click += new System.EventHandler(this.BtnBusq_Click);
            // 
            // TxtClinom
            // 
            this.TxtClinom.Location = new System.Drawing.Point(11, 29);
            this.TxtClinom.Name = "TxtClinom";
            this.TxtClinom.Size = new System.Drawing.Size(253, 27);
            this.TxtClinom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Cliente";
            // 
            // PnaCent
            // 
            this.PnaCent.Controls.Add(this.DgvCli);
            this.PnaCent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnaCent.Location = new System.Drawing.Point(249, 0);
            this.PnaCent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnaCent.Name = "PnaCent";
            this.PnaCent.Size = new System.Drawing.Size(622, 417);
            this.PnaCent.TabIndex = 2;
            // 
            // DgvCli
            // 
            this.DgvCli.AllowUserToAddRows = false;
            this.DgvCli.AllowUserToDeleteRows = false;
            this.DgvCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCli.Location = new System.Drawing.Point(0, 0);
            this.DgvCli.Name = "DgvCli";
            this.DgvCli.ReadOnly = true;
            this.DgvCli.Size = new System.Drawing.Size(622, 417);
            this.DgvCli.TabIndex = 0;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(871, 487);
            this.Controls.Add(this.PnaCent);
            this.Controls.Add(this.PanInf);
            this.Controls.Add(this.PanIzq);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.PanIzq.ResumeLayout(false);
            this.GbxDatCli.ResumeLayout(false);
            this.GbxDatCli.PerformLayout();
            this.PanInf.ResumeLayout(false);
            this.PanInf.PerformLayout();
            this.PnaCent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanIzq;
        private System.Windows.Forms.Panel PanInf;
        private System.Windows.Forms.Panel PnaCent;
        private System.Windows.Forms.DataGridView DgvCli;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnBusq;
        private System.Windows.Forms.TextBox TxtClinom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbxDatCli;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}
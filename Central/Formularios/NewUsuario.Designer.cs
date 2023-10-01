namespace Central.Formularios
{
    partial class NewUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUsuario));
            this.PanSup = new System.Windows.Forms.Panel();
            this.PanIz = new System.Windows.Forms.Panel();
            this.PanCent = new System.Windows.Forms.Panel();
            this.LstUsu = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtUsu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Stt1 = new System.Windows.Forms.StatusStrip();
            this.ChkAllUsu = new System.Windows.Forms.CheckBox();
            this.TstLblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TxtBcli = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnAlta = new System.Windows.Forms.Button();
            this.BtnDesct = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnActiv = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CboLevel = new System.Windows.Forms.ComboBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanSup.SuspendLayout();
            this.PanIz.SuspendLayout();
            this.PanCent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Stt1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanSup
            // 
            this.PanSup.Controls.Add(this.BtnSalir);
            this.PanSup.Controls.Add(this.BtnActiv);
            this.PanSup.Controls.Add(this.BtnEdit);
            this.PanSup.Controls.Add(this.BtnDesct);
            this.PanSup.Controls.Add(this.BtnAlta);
            this.PanSup.Controls.Add(this.BtnSearch);
            this.PanSup.Controls.Add(this.TxtBcli);
            this.PanSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSup.Location = new System.Drawing.Point(0, 0);
            this.PanSup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanSup.Name = "PanSup";
            this.PanSup.Size = new System.Drawing.Size(839, 103);
            this.PanSup.TabIndex = 0;
            this.PanSup.Paint += new System.Windows.Forms.PaintEventHandler(this.PanSup_Paint);
            // 
            // PanIz
            // 
            this.PanIz.Controls.Add(this.ChkAllUsu);
            this.PanIz.Controls.Add(this.LstUsu);
            this.PanIz.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanIz.Location = new System.Drawing.Point(0, 103);
            this.PanIz.Name = "PanIz";
            this.PanIz.Size = new System.Drawing.Size(200, 325);
            this.PanIz.TabIndex = 1;
            // 
            // PanCent
            // 
            this.PanCent.Controls.Add(this.CboLevel);
            this.PanCent.Controls.Add(this.label4);
            this.PanCent.Controls.Add(this.Stt1);
            this.PanCent.Controls.Add(this.TxtPass);
            this.PanCent.Controls.Add(this.label3);
            this.PanCent.Controls.Add(this.TxtUsu);
            this.PanCent.Controls.Add(this.label2);
            this.PanCent.Controls.Add(this.TxtNom);
            this.PanCent.Controls.Add(this.label1);
            this.PanCent.Controls.Add(this.pictureBox1);
            this.PanCent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanCent.Location = new System.Drawing.Point(200, 103);
            this.PanCent.Name = "PanCent";
            this.PanCent.Size = new System.Drawing.Size(639, 325);
            this.PanCent.TabIndex = 2;
            // 
            // LstUsu
            // 
            this.LstUsu.Dock = System.Windows.Forms.DockStyle.Top;
            this.LstUsu.FormattingEnabled = true;
            this.LstUsu.ItemHeight = 17;
            this.LstUsu.Location = new System.Drawing.Point(0, 0);
            this.LstUsu.Name = "LstUsu";
            this.LstUsu.Size = new System.Drawing.Size(200, 293);
            this.LstUsu.TabIndex = 0;
            this.LstUsu.DoubleClick += new System.EventHandler(this.LstUsu_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(244, 57);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(357, 23);
            this.TxtNom.TabIndex = 2;
            // 
            // TxtUsu
            // 
            this.TxtUsu.Location = new System.Drawing.Point(244, 104);
            this.TxtUsu.Name = "TxtUsu";
            this.TxtUsu.Size = new System.Drawing.Size(143, 23);
            this.TxtUsu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(476, 104);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(125, 23);
            this.TxtPass.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña:";
            // 
            // Stt1
            // 
            this.Stt1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TstLblEstado});
            this.Stt1.Location = new System.Drawing.Point(0, 303);
            this.Stt1.Name = "Stt1";
            this.Stt1.Size = new System.Drawing.Size(639, 22);
            this.Stt1.TabIndex = 7;
            this.Stt1.Text = "statusStrip1";
            // 
            // ChkAllUsu
            // 
            this.ChkAllUsu.AutoSize = true;
            this.ChkAllUsu.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkAllUsu.Location = new System.Drawing.Point(3, 299);
            this.ChkAllUsu.Name = "ChkAllUsu";
            this.ChkAllUsu.Size = new System.Drawing.Size(186, 20);
            this.ChkAllUsu.TabIndex = 1;
            this.ChkAllUsu.Text = "Mostrar usuarios desactivados";
            this.ChkAllUsu.UseVisualStyleBackColor = true;
            // 
            // TstLblEstado
            // 
            this.TstLblEstado.Name = "TstLblEstado";
            this.TstLblEstado.Size = new System.Drawing.Size(42, 17);
            this.TstLblEstado.Text = "Estado";
            // 
            // TxtBcli
            // 
            this.TxtBcli.Location = new System.Drawing.Point(12, 39);
            this.TxtBcli.Name = "TxtBcli";
            this.TxtBcli.Size = new System.Drawing.Size(142, 23);
            this.TxtBcli.TabIndex = 0;
            // 
            // BtnSearch
            // 
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(160, 28);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(92, 45);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnAlta
            // 
            this.BtnAlta.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlta.Image")));
            this.BtnAlta.Location = new System.Drawing.Point(328, 23);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(80, 60);
            this.BtnAlta.TabIndex = 2;
            this.BtnAlta.Text = "Alta";
            this.BtnAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // BtnDesct
            // 
            this.BtnDesct.Enabled = false;
            this.BtnDesct.Image = ((System.Drawing.Image)(resources.GetObject("BtnDesct.Image")));
            this.BtnDesct.Location = new System.Drawing.Point(522, 23);
            this.BtnDesct.Name = "BtnDesct";
            this.BtnDesct.Size = new System.Drawing.Size(80, 60);
            this.BtnDesct.TabIndex = 3;
            this.BtnDesct.Text = "Desactivar";
            this.BtnDesct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDesct.UseVisualStyleBackColor = true;
            this.BtnDesct.Click += new System.EventHandler(this.BtnDesct_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(635, 23);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(80, 60);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnActiv
            // 
            this.BtnActiv.Enabled = false;
            this.BtnActiv.Image = ((System.Drawing.Image)(resources.GetObject("BtnActiv.Image")));
            this.BtnActiv.Location = new System.Drawing.Point(426, 23);
            this.BtnActiv.Name = "BtnActiv";
            this.BtnActiv.Size = new System.Drawing.Size(80, 60);
            this.BtnActiv.TabIndex = 5;
            this.BtnActiv.Text = "Activar";
            this.BtnActiv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnActiv.UseVisualStyleBackColor = true;
            this.BtnActiv.Click += new System.EventHandler(this.BtnActiv_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nivel";
            // 
            // CboLevel
            // 
            this.CboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboLevel.FormattingEnabled = true;
            this.CboLevel.Items.AddRange(new object[] {
            "Administrador",
            "Cajero"});
            this.CboLevel.Location = new System.Drawing.Point(244, 151);
            this.CboLevel.Name = "CboLevel";
            this.CboLevel.Size = new System.Drawing.Size(143, 25);
            this.CboLevel.TabIndex = 9;
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(756, 8);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(80, 85);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Cerrar";
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // NewUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 428);
            this.Controls.Add(this.PanCent);
            this.Controls.Add(this.PanIz);
            this.Controls.Add(this.PanSup);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUsuario";
            this.PanSup.ResumeLayout(false);
            this.PanSup.PerformLayout();
            this.PanIz.ResumeLayout(false);
            this.PanIz.PerformLayout();
            this.PanCent.ResumeLayout(false);
            this.PanCent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Stt1.ResumeLayout(false);
            this.Stt1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanSup;
        private System.Windows.Forms.Panel PanIz;
        private System.Windows.Forms.Panel PanCent;
        private System.Windows.Forms.ListBox LstUsu;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip Stt1;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUsu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkAllUsu;
        private System.Windows.Forms.ToolStripStatusLabel TstLblEstado;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtBcli;
        private System.Windows.Forms.Button BtnActiv;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDesct;
        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.ComboBox CboLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSalir;
    }
}
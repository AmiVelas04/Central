namespace Central.Formularios
{
    partial class SelPrint
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
            this.label1 = new System.Windows.Forms.Label();
            this.CboPrint = new System.Windows.Forms.ComboBox();
            this.BtnSelPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar impresora";
            // 
            // CboPrint
            // 
            this.CboPrint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPrint.FormattingEnabled = true;
            this.CboPrint.Location = new System.Drawing.Point(26, 35);
            this.CboPrint.Name = "CboPrint";
            this.CboPrint.Size = new System.Drawing.Size(247, 21);
            this.CboPrint.TabIndex = 1;
            // 
            // BtnSelPrint
            // 
            this.BtnSelPrint.Location = new System.Drawing.Point(26, 88);
            this.BtnSelPrint.Name = "BtnSelPrint";
            this.BtnSelPrint.Size = new System.Drawing.Size(247, 23);
            this.BtnSelPrint.TabIndex = 2;
            this.BtnSelPrint.Text = "Seleccionar impresora";
            this.BtnSelPrint.UseVisualStyleBackColor = true;
            this.BtnSelPrint.Click += new System.EventHandler(this.BtnSelPrint_Click);
            // 
            // SelPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 139);
            this.Controls.Add(this.BtnSelPrint);
            this.Controls.Add(this.CboPrint);
            this.Controls.Add(this.label1);
            this.Name = "SelPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar impresora";
            this.Load += new System.EventHandler(this.SelPrint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboPrint;
        private System.Windows.Forms.Button BtnSelPrint;
    }
}
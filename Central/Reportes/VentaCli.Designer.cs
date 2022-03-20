namespace Central.Reportes
{
    partial class VentaCli
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
            this.RpvCli = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RpvCli
            // 
            this.RpvCli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RpvCli.LocalReport.ReportEmbeddedResource = "Central.Reportes.VentaCli.rdlc";
            this.RpvCli.Location = new System.Drawing.Point(0, 0);
            this.RpvCli.Name = "RpvCli";
            this.RpvCli.Size = new System.Drawing.Size(533, 261);
            this.RpvCli.TabIndex = 0;
            // 
            // VentaCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 261);
            this.Controls.Add(this.RpvCli);
            this.Name = "VentaCli";
            this.Text = "Ventas por Cliente";
            this.Load += new System.EventHandler(this.VentaCli_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RpvCli;
    }
}
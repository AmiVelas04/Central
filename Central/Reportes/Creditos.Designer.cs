namespace Central.Reportes
{
    partial class Creditos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CrediDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CrediEncBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Rpv1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.CrediDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrediEncBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CrediDetBindingSource
            // 
            this.CrediDetBindingSource.DataSource = typeof(Central.Reportes.CrediDet);
            // 
            // CrediEncBindingSource
            // 
            this.CrediEncBindingSource.DataSource = typeof(Central.Reportes.CrediEnc);
            // 
            // Rpv1
            // 
            this.Rpv1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Detalle";
            reportDataSource1.Value = this.CrediDetBindingSource;
            reportDataSource2.Name = "Enca";
            reportDataSource2.Value = this.CrediEncBindingSource;
            this.Rpv1.LocalReport.DataSources.Add(reportDataSource1);
            this.Rpv1.LocalReport.DataSources.Add(reportDataSource2);
            this.Rpv1.LocalReport.ReportEmbeddedResource = "Central.Reportes.Creditos.rdlc";
            this.Rpv1.Location = new System.Drawing.Point(0, 0);
            this.Rpv1.Name = "Rpv1";
            this.Rpv1.Size = new System.Drawing.Size(932, 378);
            this.Rpv1.TabIndex = 0;
            // 
            // Creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 378);
            this.Controls.Add(this.Rpv1);
            this.Name = "Creditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creditos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Creditos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CrediDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrediEncBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Rpv1;
        private System.Windows.Forms.BindingSource CrediDetBindingSource;
        private System.Windows.Forms.BindingSource CrediEncBindingSource;
    }
}
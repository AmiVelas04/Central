namespace Central.Reportes
{
    partial class Masven
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Rpv1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DiarioEncBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DiezmasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DiarioDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DiarioEncBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiezmasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiarioDetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Rpv1
            // 
            this.Rpv1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Encabe";
            reportDataSource1.Value = this.DiarioEncBindingSource;
            reportDataSource2.Name = "MasV";
            reportDataSource2.Value = this.DiezmasBindingSource;
            reportDataSource3.Name = "Produ";
            reportDataSource3.Value = this.DiarioDetBindingSource;
            this.Rpv1.LocalReport.DataSources.Add(reportDataSource1);
            this.Rpv1.LocalReport.DataSources.Add(reportDataSource2);
            this.Rpv1.LocalReport.DataSources.Add(reportDataSource3);
            this.Rpv1.LocalReport.ReportEmbeddedResource = "Central.Reportes.Masven.rdlc";
            this.Rpv1.Location = new System.Drawing.Point(0, 0);
            this.Rpv1.Name = "Rpv1";
            this.Rpv1.Size = new System.Drawing.Size(903, 336);
            this.Rpv1.TabIndex = 0;
            // 
            // DiarioEncBindingSource
            // 
            this.DiarioEncBindingSource.DataSource = typeof(Central.Reportes.DiarioEnc);
            // 
            // DiezmasBindingSource
            // 
            this.DiezmasBindingSource.DataSource = typeof(Central.Reportes.Diezmas);
            // 
            // DiarioDetBindingSource
            // 
            this.DiarioDetBindingSource.DataSource = typeof(Central.Reportes.DiarioDet);
            // 
            // Masven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 336);
            this.Controls.Add(this.Rpv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Masven";
            this.Text = "Mas vendidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Masven_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiarioEncBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiezmasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiarioDetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Rpv1;
        private System.Windows.Forms.BindingSource DiarioEncBindingSource;
        private System.Windows.Forms.BindingSource DiezmasBindingSource;
        private System.Windows.Forms.BindingSource DiarioDetBindingSource;
    }
}
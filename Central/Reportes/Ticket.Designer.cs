namespace Central.Reportes
{
    partial class Ticket
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
            this.RpwTicket = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturaDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturaEncBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaEncBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RpwTicket
            // 
            this.RpwTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Detalle";
            reportDataSource1.Value = this.FacturaDetBindingSource;
            reportDataSource2.Name = "Titulo";
            reportDataSource2.Value = this.FacturaEncBindingSource;
            this.RpwTicket.LocalReport.DataSources.Add(reportDataSource1);
            this.RpwTicket.LocalReport.DataSources.Add(reportDataSource2);
            this.RpwTicket.LocalReport.ReportEmbeddedResource = "Central.Reportes.Ticket.rdlc";
            this.RpwTicket.Location = new System.Drawing.Point(0, 0);
            this.RpwTicket.Name = "RpwTicket";
            this.RpwTicket.Size = new System.Drawing.Size(284, 261);
            this.RpwTicket.TabIndex = 0;
            // 
            // FacturaDetBindingSource
            // 
            this.FacturaDetBindingSource.DataSource = typeof(Central.Reportes.FacturaDet);
            // 
            // FacturaEncBindingSource
            // 
            this.FacturaEncBindingSource.DataSource = typeof(Central.Reportes.FacturaEnc);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.RpwTicket);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaEncBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RpwTicket;
        private System.Windows.Forms.BindingSource FacturaDetBindingSource;
        private System.Windows.Forms.BindingSource FacturaEncBindingSource;
    }
}
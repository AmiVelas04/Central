namespace Central
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tmr1 = new System.Windows.Forms.Timer(this.components);
            this.PanCent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Tmr1
            // 
            this.Tmr1.Enabled = true;
            this.Tmr1.Interval = 1500;
            this.Tmr1.Tick += new System.EventHandler(this.Tmr1_Tick);
            // 
            // PanCent
            // 
            this.PanCent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanCent.BackgroundImage")));
            this.PanCent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanCent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanCent.Location = new System.Drawing.Point(0, 0);
            this.PanCent.Name = "PanCent";
            this.PanCent.Size = new System.Drawing.Size(570, 298);
            this.PanCent.TabIndex = 0;
            this.PanCent.Paint += new System.Windows.Forms.PaintEventHandler(this.PanCent_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(570, 298);
            this.Controls.Add(this.PanCent);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Tmr1;
        private System.Windows.Forms.Panel PanCent;
    }
}


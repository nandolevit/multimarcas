namespace WinForms
{
    partial class FormRelatorioFicha
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
            this.reportViewerFichaOS = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerFichaOS
            // 
            this.reportViewerFichaOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerFichaOS.LocalReport.ReportEmbeddedResource = "WinForms.reportRelatorioFicha.rdlc";
            this.reportViewerFichaOS.Location = new System.Drawing.Point(0, 0);
            this.reportViewerFichaOS.Name = "reportViewerFichaOS";
            this.reportViewerFichaOS.ServerReport.BearerToken = null;
            this.reportViewerFichaOS.Size = new System.Drawing.Size(784, 561);
            this.reportViewerFichaOS.TabIndex = 0;
            // 
            // FormRelatorioFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewerFichaOS);
            this.Name = "FormRelatorioFicha";
            this.Text = "Imprimir Ficha de Ordem de Serviço::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRelatorioFicha_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerFichaOS;
    }
}
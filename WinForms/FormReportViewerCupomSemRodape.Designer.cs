namespace WinForms
{
    partial class FormReportViewerCupomSemRodape
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
            this.reportViewerCupomSemRodape = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerCupomSemRodape
            // 
            this.reportViewerCupomSemRodape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerCupomSemRodape.LocalReport.ReportEmbeddedResource = "WinForms.ReportCupomSemRadape.rdlc";
            this.reportViewerCupomSemRodape.Location = new System.Drawing.Point(0, 0);
            this.reportViewerCupomSemRodape.Name = "reportViewerCupomSemRodape";
            this.reportViewerCupomSemRodape.ServerReport.BearerToken = null;
            this.reportViewerCupomSemRodape.Size = new System.Drawing.Size(800, 450);
            this.reportViewerCupomSemRodape.TabIndex = 0;
            // 
            // FormReportViewerCupomSemRodape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerCupomSemRodape);
            this.Name = "FormReportViewerCupomSemRodape";
            this.Text = "Imprimir";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReportViewerCupomSemRodape_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCupomSemRodape;
    }
}
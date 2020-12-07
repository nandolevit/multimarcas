namespace WinForms
{
    partial class FormReportVenda
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
            this.reportViewerVenda = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerVenda
            // 
            this.reportViewerVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerVenda.LocalReport.ReportEmbeddedResource = "WinForms.ReportVenda.rdlc";
            this.reportViewerVenda.Location = new System.Drawing.Point(0, 0);
            this.reportViewerVenda.Name = "reportViewerVenda";
            this.reportViewerVenda.ServerReport.BearerToken = null;
            this.reportViewerVenda.Size = new System.Drawing.Size(800, 450);
            this.reportViewerVenda.TabIndex = 0;
            // 
            // FormReportVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerVenda);
            this.Name = "FormReportVenda";
            this.Text = "Imprimir";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReportVenda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerVenda;
    }
}
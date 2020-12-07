using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FormReportViewerCupomSemRodape : Form
    {
        string texto = string.Empty;

        public FormReportViewerCupomSemRodape(string text)
        {
            InitializeComponent();
            texto = text;
        }

        private void FormReportViewerCupomSemRodape_Load(object sender, EventArgs e)
        {
            this.reportViewerCupomSemRodape.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewerCupomSemRodape.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewerCupomSemRodape.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Cupom", texto));
            this.reportViewerCupomSemRodape.RefreshReport();
        }
    }
}

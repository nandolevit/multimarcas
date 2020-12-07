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
    public partial class FormReportVenda : Form
    {
        public string[] Venda { get; set; }

        public FormReportVenda(string[] venda)
        {
            InitializeComponent();
            Venda = venda;
        }

        private void FormReportVenda_Load(object sender, EventArgs e)
        {
            this.reportViewerVenda.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewerVenda.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewerVenda.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Venda", Venda[0]));
            this.reportViewerVenda.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Rodape", Venda[1]));
            this.reportViewerVenda.RefreshReport();
        }
    }
}

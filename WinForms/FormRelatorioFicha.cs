using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjTransfer;

namespace WinForms
{
    public partial class FormRelatorioFicha : Form
    {
        ServicoInfo infoServ = new ServicoInfo();
        ClienteInfo clienteInfo = new ClienteInfo();
        FuncInfo infoFunc;
        ProdEletroInfo infoEletro;
        ClienteNegocios clienteNegocios = new ClienteNegocios(Form1.Empresa.empconexao);
        ServicoNegocio negocioServ = new ServicoNegocio(Form1.Empresa.empconexao);
        FuncNegocios negociosFunc = new FuncNegocios(Form1.Empresa.empconexao);

        public FormRelatorioFicha(ServicoInfo serv)
        {
            InitializeComponent();
            infoServ = serv;
            clienteInfo = BuscarClientePorId();
            infoEletro = negocioServ.ConsultarEletroId(infoServ.serideletro);
            infoFunc = negociosFunc.ConsultarFuncPorId(infoServ.seridfunc);
        }

        private ClienteInfo BuscarClientePorId()
        {
            return clienteNegocios.ConsultarClientePorId(infoServ.seridcliente);
        }

        private string ConsultarIdEnd(int Id)
        {
            EnderecoInfo enderecoInfo = new EnderecoInfo();

            string End = string.Empty;
            string endComp = string.Empty;

            enderecoInfo = clienteNegocios.ConsultarEnderecoPorIdEnd(Id);

            endComp = "BAIRRO: " + enderecoInfo.endBairro + ", " + Environment.NewLine + "CIDADE: " + enderecoInfo.endCidade + "/" +
                enderecoInfo.endUf + Environment.NewLine + enderecoInfo.endLogradouro + ", " + Environment.NewLine;
            End = "End.: " + string.Format(@"{0:00\.000\-000}", Convert.ToInt32(enderecoInfo.Cep)) + ", " +
                enderecoInfo.Complemento + Environment.NewLine + ", Ponto de Ref.: " + enderecoInfo.PontoReferencia;

            endComp += End;
            return endComp;
        }

        private string Empresa()
        {
            EmpresaInfo empresaInfo = Form1.Empresa;

            string emp = empresaInfo.empfantasia;
            emp += Environment.NewLine + " Telefones: " + empresaInfo.emptelefone + "; Site: " +  empresaInfo.empsite + "; Email: " + empresaInfo.empemail;
            //emp += Environment.NewLine + empresaInfo.empcomplemento + "; " + empresaInfo.empreferencia;
            //emp += Environment.NewLine + empresaInfo.emplogradouro + "; " + empresaInfo.empbairro + "; " + empresaInfo.empcidade + "-" + empresaInfo.empuf;

            return emp;
        }

        private void FormRelatorioFicha_Load(object sender, EventArgs e)
        {
            this.reportViewerFichaOS.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewerFichaOS.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewerFichaOS.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Descricao", infoServ.serdescricao));
            this.reportViewerFichaOS.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("OS", string.Format("{0:000000}", infoServ.serid)));
            this.reportViewerFichaOS.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Taxa", string.Format( "{0:C2}",infoServ.sertaxa)));
            this.reportViewerFichaOS.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Def", infoServ.serdefeitodescricao));
            this.reportViewerFichaOS.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Obs", "Observações: -> " + infoServ.serobs));
            this.reportViewerFichaOS.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataAgend", infoServ.serdataagend.ToLongDateString()));
            this.reportViewerFichaOS.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Nome", clienteInfo.clinome));
            this.reportViewerFichaOS.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Email", clienteInfo.cliemail));
            this.reportViewerFichaOS.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Telefone", clienteInfo.clitel));
            this.reportViewerFichaOS.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Endereco", ConsultarIdEnd(infoServ.seridend)));
            this.reportViewerFichaOS.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Empresa", Empresa()));
            this.reportViewerFichaOS.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("EmpFantasia", Form1.Empresa.empfantasia));
            this.reportViewerFichaOS.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Chamado", string.IsNullOrEmpty(infoEletro.cadelechamado) ? "" : "CHAMADO: " + infoEletro.cadelechamado));
            this.reportViewerFichaOS.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Atendente", "ABERTA POR: " + infoFunc.funNome + " " + infoServ.serdatacad.ToLongDateString() + " " + infoServ.serdatacad.ToLongTimeString()));

            this.reportViewerFichaOS.RefreshReport();
            this.Text += " " + clienteInfo.clinome;
        }
    }
}

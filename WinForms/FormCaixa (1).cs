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
    public enum EnumCaixa { Turno, Caixa}

    public partial class FormCaixa : Form
    {
        CaixaNegocios caixaNegocios = new CaixaNegocios(Form1.Empresa.empconexao);
        FuncNegocios funcNegocios = new FuncNegocios(Form1.Empresa.empconexao);
        EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios(Form1.Empresa.empconexao);
        CaixaTurnoInfo caixaTurnoInfo = new CaixaTurnoInfo();
        CaixaFecharInfo fechar = new CaixaFecharInfo();
        EnumCaixa enumCaixa = new EnumCaixa();

        decimal saldo = 0;
        decimal totalCaixa = 0;
        decimal caixaAbrir = 0;
        decimal recebe = 0;
        decimal pagamento = 0;

        public FormCaixa(EnumCaixa enumFechar)
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            Caixa caixa = new Caixa();
            caixaTurnoInfo = caixa.ConsultarTurnoAberto();
            enumCaixa = enumFechar;

            if (enumFechar == EnumCaixa.Turno)
            {
                this.Text = "Fechamento de turno";
                this.buttonFechamento.Text = "Fechamento de turno";
            }
        }

        private void FormCaixa_Load(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();

            if (enumCaixa == EnumCaixa.Turno)
                fechar = caixa.PreencherTurno();
            else
                fechar = caixa.PreencherCaixaTotal();

            if (fechar != null)
            {
                labelDinheiroValor.Text = fechar.caixafecharvalordinheiro.ToString("C2");
                labelDebitoValor.Text = fechar.caixafecharvalorcartaodebito.ToString("C2");
                labelCreditoValor.Text = fechar.caixafecharvalorcartaocredito.ToString("C2");
                labelChequeValor.Text = fechar.caixafecharvalorcheque.ToString("C2");
                labelDepositoValor.Text = fechar.caixafecharvalordeposito.ToString("C2");
                labelOutrasValor.Text = fechar.caixafecharvalorcarne.ToString("C2");
                labelTotalValor.Text = fechar.caixafecharvalortotal.ToString("C2");
            }

            

            decimal[] diversos = new decimal[2];
            decimal saldoSangria = 0;

            if (enumCaixa == EnumCaixa.Turno)
            {
                CaixaTurnoInfo caixaTurnoInfo = caixa.ConsultarTurnoAberto();
                if (caixaTurnoInfo != null)
                {
                    labelValorTurno.Text = caixaTurnoInfo.caixaturnonum.ToString();
                    diversos = caixa.CalcularSaldoRecebimentoPagamentoTurno(caixaTurnoInfo.caixaturnoid);
                    saldoSangria = caixaNegocios.ConsultarSangriaSaldoIdTurno(caixaTurnoInfo.caixaturnoid);

                    caixaAbrir = caixaTurnoInfo.caixaturnovalorabrir;
                    labelDataAbertura.Text = caixaTurnoInfo.caixaturnodata.ToShortDateString();
                    labelHoraAbertura.Text = caixaTurnoInfo.caixaturnodata.ToShortTimeString();
                    labelValorAbertura.Text = caixaAbrir.ToString("C2");
                    labelAbrirFunc.Text = funcNegocios.ConsultarFuncPorId(caixaTurnoInfo.caixaturnoidfunc).funNome;
                }
            }
            else
            {
                CaixaAbrirInfo caixaAbrirInfo = caixa.CaixaAberto();
                caixaAbrir = caixaAbrirInfo.caixaabrirvalor;
                labelDataAbertura.Text = caixaAbrirInfo.caixaabrirdata.ToShortDateString();
                labelHoraAbertura.Text = caixaAbrirInfo.caixaabrirdata.ToShortTimeString();
                labelValorAbertura.Text = caixaAbrir.ToString("C2");
                labelValorTurno.Text = caixa.ConsultarTurnoColecaoIdCaixa().Count.ToString();
                labelAbrirFunc.Text = funcNegocios.ConsultarFuncPorId(caixaAbrirInfo.caixaabriridfunc).funNome;
                diversos = caixa.CalcularSaldoRecebimentoPagamentoCaixa(caixaAbrirInfo.caixaabririd);
                saldoSangria = caixaNegocios.ConsultarSangriaSaldoIdCaixa(caixaAbrirInfo.caixaabririd);
            }

            saldo = (diversos[0] - diversos[1]);
            pagamento = diversos[1];
            recebe = diversos[0];
            totalCaixa = caixa.SaldoEspecieCaixa();
            labelRecebimentoValor.Text = diversos[0].ToString("C2");
            labelPagamentoValor.Text = diversos[1].ToString("C2");
            labelSaldoValor.Text = saldo.ToString("C2");
            labelCaixaSaldo.Text = totalCaixa.ToString("C2");
            labelSangriaValor.Text = saldoSangria.ToString("C2");

        }

        private void textBoxProxCaixaValor_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat((TextBox)sender);
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FecharCaixa()
        {
            Caixa caixa = new Caixa();
            if (enumCaixa == EnumCaixa.Caixa)
            {
                if (FormMessage.ShowMessegeQuestion("Deseja realizar o fechamento do caixa?" + Environment.NewLine + "Ao fechar o caixa o mesmo só poderá ser aberto novamente no dia seguinte.") == DialogResult.Yes)
                {
                    CaixaAbrirInfo caixaAbrirInfo = caixa.CaixaAberto();
                    CaixaFecharInfo caixaFecharInfo = new CaixaFecharInfo
                    {
                        caixafechardata = DateTime.Now,
                        caixafecharid = 0,
                        caixafecharidabrir = caixaTurnoInfo.caixaturnoidabrir,
                        caixafecharidfunc = Form1.User.useidfuncionario,
                        caixafecharvalorcarne = 0,
                        caixafecharvalorcartaocredito = fechar.caixafecharvalorcartaocredito,
                        caixafecharvalorcartaodebito = fechar.caixafecharvalorcartaodebito,
                        caixafecharvalorcheque = fechar.caixafecharvalorcheque,
                        caixafecharvalordeposito = fechar.caixafecharvalordeposito,
                        caixafecharvalordinheiro = fechar.caixafecharvalordinheiro,
                        caixafecharvalortotal = fechar.caixafecharvalortotal,
                        caixafecharvalorpagamentos = pagamento,
                        caixafecharvalorrecebimentos = recebe,
                        caixafecharvalorsaldoespecie = caixa.SaldoEspecieCaixa(),
                        caixafecharvalorsangria = caixaNegocios.ConsultarSangriaSaldoIdCaixa(caixaAbrirInfo.caixaabririd)
                    };

                    if (caixaTurnoInfo != null)
                        FechamentoTurno();

                    if (caixaNegocios.InsertCaixaFechar(caixaFecharInfo) > 0)
                    {
                        FormMessage.ShowMessegeInfo("Caixa fechado com sucesso!");
                        this.Close();
                    }
                }
            }
            else
            {
                if (FormMessage.ShowMessegeQuestion("Deseja confirmar o fechamento do turno?") == DialogResult.Yes)
                {
                    if (FechamentoTurno() > 0)
                    {
                        FormMessage.ShowMessegeInfo("Turno fechado com sucesso!");
                        this.Close();
                    }
                }
            }
        }

        private void buttonFechamento_Click(object sender, EventArgs e)
        {
            FecharCaixa();
        }

        private int FechamentoTurno()
        {
            Caixa caixa = new Caixa();
            CaixaTurnoInfo caixaTurnoSalvar = new CaixaTurnoInfo
            {
                caixaturnoid = caixaTurnoInfo.caixaturnoid,
                caixaturnovalorcarne = 0,
                caixaturnovalorcartaocredito = fechar.caixafecharvalorcartaocredito,
                caixaturnovalorcartaodebito = fechar.caixafecharvalorcartaodebito,
                caixaturnovalorcheque = fechar.caixafecharvalorcheque,
                caixaturnovalordeposito = fechar.caixafecharvalordeposito,
                caixaturnovalordinheiro = fechar.caixafecharvalordinheiro,
                caixaturnovalorpagamentos = pagamento,
                caixaturnovalorrecebimentos = recebe,
                caixaturnovalorsaldoespecie = caixa.SaldoEspecieCaixaTurno(),
                caixaturnovalortotal = fechar.caixafecharvalortotal,
                caixaturnovalorsangria = caixaNegocios.ConsultarSangriaSaldoIdTurno(caixaTurnoInfo.caixaturnoid),
            };

            return caixaNegocios.UpdateFechamentoTurno(caixaTurnoSalvar);
        }
    }
}

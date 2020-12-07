using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Negocios;
using ObjTransfer;

namespace WinForms
{
    public enum EnumCaixa { Turno, Caixa}

    public partial class FormCaixa : Form
    {
        Form1 form1 = new Form1();
        Thread thread;
        CaixaNegocios caixaNegocios = new CaixaNegocios(Form1.Empresa.empconexao);
        FuncNegocios funcNegocios = new FuncNegocios(Form1.Empresa.empconexao);
        EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios(Form1.Empresa.empconexao);
        CaixaTurnoInfo caixaTurnoInfo = new CaixaTurnoInfo();
        CaixaAbrirInfo caixaaberto = new CaixaAbrirInfo();
        CaixaAbrirInfo caixaAbrirInfo = new CaixaAbrirInfo();
        Caixa caixa = new Caixa();
        EnumCaixa enumCaixa = new EnumCaixa();
        
        decimal caixaAbrir = 0;

        public FormCaixa(EnumCaixa enumFechar)
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            caixaaberto = caixa.CaixaAberto();
            caixaTurnoInfo = caixa.ConsultarTurnoAberto();
            enumCaixa = enumFechar;

            if (enumFechar == EnumCaixa.Turno)
            {
                labelTitle.Text = "TURNO";
                this.Text = "Fechamento de turno";
                this.buttonFechamento.Text = "Fechamento de turno";
            }
            else
                labelTitle.Text = "CAIXA";
        }

        private void PreencherClasseThread()
        {
            thread = new Thread(PreencherClasse);
            form1.ExecutarThread(thread);
            this.Activate();
        }

        private void FormCaixa_Load(object sender, EventArgs e)
        {
            PreencherClasseThread();

            if (caixaaberto != null)
            {
                if (enumCaixa == EnumCaixa.Turno)
                {
                    if (caixaTurnoInfo != null)
                    {
                        labelValorTurno.Text = caixaTurnoInfo.caixaturnonum.ToString() + "/3";
                        labelAbrirFunc.Text = funcNegocios.ConsultarFuncPorId(caixaTurnoInfo.caixaturnoidfuncabrir).funNome;
                        labelDataAbertura.Text = caixaTurnoInfo.caixaturnodata.ToShortDateString();
                        labelHoraAbertura.Text = caixaTurnoInfo.caixaturnodata.ToShortTimeString();
                        labelValorAbertura.Text = caixaTurnoInfo.caixaturnovalorabrir.ToString("C2");
                        if (caixaTurnoInfo.caixaturnonum == 3)
                            buttonFechamento.Enabled = false;
                    }
                }
                else
                {
                    caixaAbrir = caixaaberto.caixaabrirvalor;
                    labelDataAbertura.Text = caixaaberto.caixaabrirdata.ToShortDateString();
                    labelHoraAbertura.Text = caixaaberto.caixaabrirdata.ToShortTimeString();
                    labelValorAbertura.Text = caixaAbrir.ToString("C2");
                    labelAbrirFunc.Text = funcNegocios.ConsultarFuncPorId(caixaaberto.caixafecharidfunc).funNome;

                    CaixaTurnoColecao turno = caixa.ConsultarTurnoColecaoIdCaixa();
                    if (turno != null)
                        labelValorTurno.Text = turno.Count.ToString();
                }
                
                labelDinheiroValor.Text = caixaaberto.caixafecharvalordinheiro.ToString("C2");
                labelDebitoValor.Text = caixaaberto.caixafecharvalorcartaodebito.ToString("C2");
                labelCreditoValor.Text = caixaaberto.caixafecharvalorcartaocredito.ToString("C2");
                labelChequeValor.Text = caixaaberto.caixafecharvalorcheque.ToString("C2");
                labelDepositoValor.Text = caixaaberto.caixafecharvalordeposito.ToString("C2");
                labelOutrasValor.Text = caixaaberto.caixafecharvalorcarne.ToString("C2");
                labelTotalValor.Text = caixaaberto.caixafecharvalortotal.ToString("C2");
                labelRecebimentoValor.Text = caixaaberto.caixafecharvalorrecebimentos.ToString("C2");
                labelPagamentoValor.Text = caixaaberto.caixafecharvalorpagamentos.ToString("C2");
                labelSaldoValor.Text = (caixaaberto.caixafecharvalorrecebimentos - caixaaberto.caixafecharvalorpagamentos).ToString("C2");
                labelCaixaSaldo.Text = caixaaberto.caixafecharvalorsaldoespecie.ToString("C2");
                labelSangriaValor.Text = caixaaberto.caixafecharvalorsangria.ToString("C2");

                
            }
        }

        public void PreencherClasse()
        {
            CaixaAbrirInfo caixaabertura = caixa.PreencherCaixaTotal(enumCaixa);

            caixaaberto.caixafecharvalordinheiro = caixaabertura.caixafecharvalordinheiro;
            caixaaberto.caixafecharvalorcartaodebito = caixaabertura.caixafecharvalorcartaodebito;
            caixaaberto.caixafecharvalorcartaocredito = caixaabertura.caixafecharvalorcartaocredito;
            caixaaberto.caixafecharvalorcheque = caixaabertura.caixafecharvalorcheque;
            caixaaberto.caixafecharvalordeposito = caixaabertura.caixafecharvalordeposito;
            caixaaberto.caixafecharvalorcarne = caixaabertura.caixafecharvalorcarne;
            caixaaberto.caixafecharvalortotal = caixaabertura.caixafecharvalortotal;
            caixaaberto.caixafecharvalorrecebimentos = caixaabertura.caixafecharvalorrecebimentos;
            caixaaberto.caixafecharvalorpagamentos = caixaabertura.caixafecharvalorpagamentos;
            caixaaberto.caixafecharvalorsaldoespecie = caixaabertura.caixafecharvalorsaldoespecie;
            caixaaberto.caixafecharvalorsangria = caixaabertura.caixafecharvalorsangria;
            caixaaberto.caixafechardata = DateTime.Now;

            Form1.encerrarThread = true;
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
                if (FormMessage.ShowMessegeQuestion("Deseja realizar o fechamento do caixa?") == DialogResult.Yes)
                {
                    if (caixaaberto.caixaabrirdata.Date == DateTime.Now.Date)
                        if (FormMessage.ShowMessegeQuestion("Ao fechar o caixa o mesmo só poderá ser aberto novamente no dia seguinte. Deseja fechar o caixa assim mesmo?") == DialogResult.No)
                            return;


                    if (caixaTurnoInfo != null)
                        FechamentoTurno();

                    PreencherClasseThread();

                    if (caixaNegocios.UpdateCaixaFechar(caixaaberto) > 0)
                    {
                        FormMessage.ShowMessegeInfo("Caixa fechado com sucesso!");

                        FormCupom formCupom = new FormCupom(caixaaberto.caixaabririd, EnumCupom.SemRodape, EnumCaixa.Caixa);
                        formCupom.ShowDialog(this);
                        formCupom.Dispose();

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
                        FormCupom formCupom = new FormCupom(caixaaberto.caixaabririd, EnumCupom.SemRodape, EnumCaixa.Turno);
                        formCupom.ShowDialog(this);
                        formCupom.Dispose();
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
            PreencherClasseThread();

            CaixaTurnoInfo caixaTurnoSalvar = new CaixaTurnoInfo
            {
                caixaturnoid = caixaTurnoInfo.caixaturnoid,
                caixaturnovalorcarne = caixaaberto.caixafecharvalorcarne,
                caixaturnovalorcartaocredito = caixaaberto.caixafecharvalorcartaocredito,
                caixaturnovalorcartaodebito = caixaaberto.caixafecharvalorcartaodebito,
                caixaturnovalorcheque = caixaaberto.caixafecharvalorcheque,
                caixaturnovalordeposito = caixaaberto.caixafecharvalordeposito,
                caixaturnovalordinheiro = caixaaberto.caixafecharvalordinheiro,
                caixaturnovalorpagamentos = caixaaberto.caixafecharvalorpagamentos,
                caixaturnovalorrecebimentos = caixaaberto.caixafecharvalorrecebimentos,
                caixaturnovalorsaldoespecie = caixaaberto.caixafecharvalorsaldoespecie,
                caixaturnovalortotal = caixaaberto.caixafecharvalortotal,
                caixaturnovalorsangria = caixaaberto.caixafecharvalorsangria,
                caixaturnoidfuncfechar = Form1.User.useidfuncionario,
                caixaturnodatafechamento = DateTime.Now
            };

            int cod = caixaNegocios.UpdateFechamentoTurno(caixaTurnoSalvar);
            return cod;
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            FormCupom formCupom = new FormCupom(caixaaberto.caixaabririd, EnumCupom.SemRodape, enumCaixa);
            formCupom.ShowDialog(this);
            formCupom.Dispose();
        }
    }
}

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
    public partial class FormAbrirCaixa : Form
    {
        CaixaNegocios caixaNegocios = new CaixaNegocios(Form1.Empresa.empconexao);
        CaixaAbrirInfo caixaAbrirInfo = new CaixaAbrirInfo();
        CaixaTurnoInfo caixaTurnoInfo = new CaixaTurnoInfo();
        CaixaTurnoColecao caixaTurnoColacao = new CaixaTurnoColecao();
        EnumCaixa enumFecharTurno = new EnumCaixa();

        public FormAbrirCaixa(EnumCaixa enumFechar)
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.AcceptButton = buttonAbrir;
            enumFecharTurno = enumFechar;
            
            labelDataDescricao.Text = DateTime.Now.Date.ToLongDateString();
        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat((TextBox)sender);
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {

            switch (enumFecharTurno)
            {
                case EnumCaixa.Caixa:
                    ExecuteCaixaAbrir();
                    break;
                case EnumCaixa.Turno:
                    if (FormMessage.ShowMessegeQuestion("Deseja abrir o turno?") == DialogResult.Yes)
                        ExecuteTurnoAbrir();
                    break;
                default:
                    break;
            }
        }

        private void ExecuteCaixaAbrir()
        {
            if (FormMessage.ShowMessegeQuestion("Deseja abrir o caixa?") == DialogResult.Yes)
            {
                CaixaAbrirInfo caixaAbrir = new CaixaAbrirInfo
                {
                    caixaabrirdata = DateTime.Now,
                    caixaabririd = 0,
                    caixaabriridfunc = Form1.User.useidfuncionario,
                    caixaabrirvalor = Convert.ToDecimal(textBoxValor.Text),
                    caixaabriridunidade = Form1.Unidade.uniid
                };

                if (caixaNegocios.InsertCaixaAbrir(caixaAbrir) > 0)
                {
                    ExecuteTurnoAbrir();
                    FormMessage.ShowMessegeInfo("O caixa foi aberto com sucesso!");
                    this.DialogResult = DialogResult.Yes;
                }
                else
                    FormMessage.ShowMessegeWarning("Falha ao tentar abrir o caixa!");
            }
        }

        private void ExecuteTurnoAbrir()
        {
            Caixa caixa = new Caixa();
            caixaAbrirInfo = caixa.CaixaAberto();
            int numTurno = 1;
            if (caixaTurnoColacao != null)
                numTurno = caixaTurnoColacao.Count + 1;

            CaixaTurnoInfo turnoSalvar = new CaixaTurnoInfo
            {
                caixaturnonum = numTurno,
                caixaturnoidabrir = caixaAbrirInfo.caixaabririd,
                caixaturnoidfuncabrir = Form1.User.useidfuncionario,
                caixaturnovalorabrir = Convert.ToDecimal(textBoxValor.Text),
            };

            if (caixaNegocios.InsertCaixaTurno(turnoSalvar) > 0)
            {
                FormMessage.ShowMessegeInfo("O turno foi aberto com sucesso!");
                this.DialogResult = DialogResult.Yes;
            }
            else
                FormMessage.ShowMessegeWarning("Falha ao tentar abrir o turno!");
        }

        private void FormAbrirCaixa_Load(object sender, EventArgs e)
        {

            caixaAbrirInfo = caixaNegocios.ConsultarCaixaAbrirUltimoAberto(Form1.Unidade.uniid);
            if (caixaAbrirInfo != null)

                textBoxValor.Text = caixaAbrirInfo.caixafecharvalorsaldoespecie.ToString();

            if (enumFecharTurno == EnumCaixa.Turno)
            {
                Caixa caixa = new Caixa();
                caixaTurnoColacao = caixa.ConsultarTurnoColecaoIdCaixa();
                int numTurno = 1;

                if (caixaTurnoColacao != null)
                {
                    numTurno = caixaTurnoColacao.Count + 1;
                    textBoxValor.Text = caixa.ConsultarTurnoUltimoFechado().caixaturnovalorsaldoespecie.ToString();
                }

                labelTurnoDescricao.Text = numTurno.ToString();
                this.Text = "Abrir Turno " + numTurno;
                
                buttonAbrir.Text = "&Abrir Turno";
                groupBoxCaixa.Text = "Abertura de turno " + numTurno;
                labelValor.Text = "Valor do turno anterior:";
            }

            buttonAbrir.Select();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using ObjTransfer;
using Negocios;

namespace WinForms
{
    public partial class FormSangria : Form
    {
        Form1 form1 = new Form1();
        CaixaAbrirInfo caixaAbrirInfo = new CaixaAbrirInfo();
        CaixaNegocios caixaNegocios = new CaixaNegocios(Form1.Empresa.empconexao);
        Thread thread;
        
        decimal totalEspecie;
        int contaCod;
        decimal valor;
        string obs;

        public FormSangria()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            caixaAbrirInfo = caixaNegocios.ConsultarCaixaAberto(Form1.Unidade.uniid);
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonContaAdd_Click(object sender, EventArgs e)
        {
            SangriaInfo sangria = new SangriaInfo();
            FormCadTexto formCadTexto = new FormCadTexto(sangria);
            formCadTexto.ShowDialog(this);
            formCadTexto.Dispose();
        }

        private void buttonContaBuscar_Click(object sender, EventArgs e)
        {
            CodDescricaoColecao codDescricaoInfos = caixaNegocios.ConsultarSangriaTipo();
            ConsultarSangriaTipo(codDescricaoInfos);
        }

        private void ConsultarSangriaTipo(CodDescricaoColecao codDescricaoColecao)
        {
            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();

            if (codDescricaoColecao != null)
            {
                foreach (CodDescricaoInfo cod in codDescricaoColecao)
                {
                    Form_Consultar form_Consultar = new Form_Consultar
                    {
                        Cod = string.Format("{0:000}", cod.cod),
                        Descricao = cod.descricao
                    };

                    form_ConsultarColecao.Add(form_Consultar);
                }
            }

            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, "Produtos");
            formConsultar_Cod_Descricao.ShowDialog(this);

            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
            {
                textBoxContaCod.Text = formConsultar_Cod_Descricao.Selecionado.Cod;
                labelContaDescricao.Text = formConsultar_Cod_Descricao.Selecionado.Descricao;
                textBoxValor.Select();
            }
        }

        private bool CamposObrigatorios()
        {
            string aviso = "O preenchimento dos campos abaixo é obrigatório!";
            bool campo = true;

            if (string.IsNullOrEmpty(textBoxContaCod.Text))
            {
                aviso = Environment.NewLine + labelDestino.Text;
                campo = false;
            }

            if (!decimal.TryParse(textBoxValor.Text, out decimal cod))
            {
                if (!(cod > 0))
                {
                    aviso = Environment.NewLine + labelSangria.Text;
                    campo = false;
                }
            }

            if (!campo)
                FormMessage.ShowMessegeWarning(aviso);

            return campo;
        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat((TextBox)sender);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (FormMessage.ShowMessegeQuestion("Deseja este valor como sangria?") == DialogResult.Yes)
            {
                if (CamposObrigatorios())
                {
                    contaCod = Convert.ToInt32(textBoxContaCod.Text);
                    valor = Convert.ToDecimal(textBoxValor.Text);
                    obs = textBoxObs.Text;
                    thread = new Thread(Salvar);
                    form1.ExecutarThread(thread);
                    this.Activate();
                    this.Close();
                }
            }
        }

        private void Salvar()
        {
            CaixaNegocios caixaNegocios = new CaixaNegocios(Form1.Empresa.empconexao);
            CaixaAbrirInfo caixaAbrirInfo = caixaNegocios.ConsultarCaixaAberto(Form1.Unidade.uniid);
            Caixa caixa = new Caixa();
            CaixaTurnoInfo caixaTurnoInfo = caixa.ConsultarTurnoAberto();

            SangriaInfo sangriaInfo = new SangriaInfo
            {
                sangriadatacad = DateTime.Now,
                sangriaid = 0,
                sangriaidcaixa = caixaAbrirInfo.caixaabririd,
                sangriaidfunc = Form1.User.useidfuncionario,
                sangriaidtipo = contaCod,
                sangriaidunidade = caixaAbrirInfo.caixaabriridunidade,
                sangriaobs = obs,
                sangriavalor = valor,
                sangriaidturno = caixaTurnoInfo.caixaturnoid
            };

            if (caixaNegocios.InsertSangria(sangriaInfo) > 0)
            {
                Form1.encerrarThread = true;
                FormMessage.ShowMessegeInfo("Salvo com sucesso.");
                this.Close();
            }
            else
            {
                Form1.encerrarThread = true;
                FormMessage.ShowMessegeWarning("Falha ao tentar salvar!");
            }
        }

        private void FormSangria_Load(object sender, EventArgs e)
        {
            thread = new Thread(Saldo);
            form1.ExecutarThread(thread);
            this.Activate();
            labelCaixa.Text = totalEspecie.ToString("C2");
            textBoxValor.Text = "0";
        }

        private void Saldo()
        {
            Caixa caixa = new Caixa();
            totalEspecie = caixa.PreencherCaixaTotal(EnumCaixa.Caixa).caixafecharvalorsaldoespecie;
            Form1.encerrarThread = true;
        }
    }
}

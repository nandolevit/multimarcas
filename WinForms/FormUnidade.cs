using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjTransfer;
using Negocios;
using System.Diagnostics;

namespace WinForms
{
    public partial class FormUnidade : Form
    {
        ClienteNegocios clienteNegocios = new ClienteNegocios(Form1.Empresa.empconexao);
        UnidadeInfo unidadeInfo = new UnidadeInfo();
        EmpresaNegocios empresaNegocios = new EmpresaNegocios(Form1.Empresa.empconexao);

        public FormUnidade()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void PreencherUnidade()
        {
            unidadeInfo.unibairro = textBoxBairro.Text;
            unidadeInfo.unicep = maskedTextBoxCep.Text;
            unidadeInfo.unicidade = textBoxCidade.Text;
            unidadeInfo.unicnpj = maskedTextBoxCpf.Text;
            unidadeInfo.unicomplemento = textBoxComplemento.Text;
            unidadeInfo.uniemail = textBoxEmail.Text;
            unidadeInfo.unifantasia = textBoxNome.Text;
            unidadeInfo.uniidEmpresa = Form1.Unidade.uniidEmpresa;
            unidadeInfo.unilogradouro = textBoxLogradouro.Text;
            unidadeInfo.unirazaoSocial = textBoxRazao.Text;
            unidadeInfo.unireferencia = textBoxPontoReferencia.Text;
            unidadeInfo.unisite = textBoxSite.Text;
            unidadeInfo.unitelefone = maskedTextBoxTel1.Text + (string.IsNullOrEmpty(maskedTextBoxTel2.Text) ? "" : "/" + maskedTextBoxTel2.Text);
            unidadeInfo.uniuf = textBoxUF.Text;
            unidadeInfo.uniunidade = textBoxIdent.Text;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (!CamposPreenchidos())
            {
                int cod;
                PreencherUnidade();

                cod = empresaNegocios.InsertUnidade(unidadeInfo);
                textBoxId.Text = string.Format("{0:000000}", cod);

                if (cod > 0)
                {
                    FormMessage.ShowMessegeInfo("Salvo com sucesso!");
                    buttonSalvar.Enabled = false;
                }
                else
                    FormMessage.ShowMessegeWarning("Não foi possível salvar!");
            }
            else
                FormMessage.ShowMessegeWarning("Preencha todos os campos!");
        }

        private bool CamposPreenchidos()
        {

            if (string.IsNullOrEmpty(textBoxBairro.Text))
                return true;

            if (string.IsNullOrEmpty(maskedTextBoxCep.Text))
                return true;

            if (string.IsNullOrEmpty(maskedTextBoxCpf.Text))
                return true;

            if (string.IsNullOrEmpty(textBoxComplemento.Text))
                return true;

            if (string.IsNullOrEmpty(textBoxEmail.Text))
                return true;

            if (string.IsNullOrEmpty(textBoxNome.Text))
                return true;

            if (string.IsNullOrEmpty(textBoxRazao.Text))
                return true;

            if (string.IsNullOrEmpty(textBoxPontoReferencia.Text))
                return true;

            if (string.IsNullOrEmpty(textBoxSite.Text))
                return true;

            return false;

        }
        private void maskedTextBoxCep_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxCep.Text.Length > 7)
            {
                CepInfo cepInfo = new CepInfo();

                cepInfo = clienteNegocios.ConsultarCep(maskedTextBoxCep.Text);

                if (cepInfo != null)
                {
                    textBoxLogradouro.Text = cepInfo.Logradouro;
                    textBoxBairro.Text = cepInfo.Bairro;
                    textBoxCidade.Text = cepInfo.Cidade;
                    textBoxUF.Text = cepInfo.Uf;
                    textBoxIdent.Text = cepInfo.Bairro;
                    textBoxIdent.Enabled = true;
                }
                else
                    FormMessage.ShowMessegeWarning("CEP não encontrado, tente outro CEP!");
            }
            else
            {
                textBoxLogradouro.Clear();
                textBoxBairro.Clear();
                textBoxCidade.Clear();
                textBoxUF.Clear();
            }
        }

        private void linkLabelCep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.buscacep.correios.com.br/sistemas/buscacep/");
        }
    }
}

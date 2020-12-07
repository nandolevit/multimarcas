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
using System.Diagnostics;

namespace WinForms
{
    public partial class FormEditEndereco : Form
    {
        Form1 form1 = new Form1();
        Thread thread;
        EnderecoInfo infoEnd;
        ClienteInfo infoCliente;
        EnderecoInfo novoEndereco;

        ClienteNegocios clienteNegocios = new ClienteNegocios(Form1.Empresa.empconexao);
        bool alterar = true;
        int idSave = 0;

        public FormEditEndereco(ClienteInfo cliente)
        {
            Inicializar();
            infoCliente = cliente;
            alterar = false;
            this.Text = "Inserir o endereço!";
        }

        public FormEditEndereco(EnderecoInfo endereco)
        {
            Inicializar();
            infoEnd = endereco;
            PreencherForm();
            alterar = true;
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            maskedTextBoxCep.Select();
            this.AcceptButton = buttonSalvar;
        }

        private void PreencherForm()
        {
            maskedTextBoxCep.Text = infoEnd.Cep;
            textBoxComplemento.Text = infoEnd.Complemento;
            textBoxPontoReferencia.Text = infoEnd.PontoReferencia;
            textBoxLogradouro.Text = infoEnd.endLogradouro;
            textBoxBairro.Text = infoEnd.endBairro;
            textBoxCidade.Text = infoEnd.endCidade;
            textBoxUF.Text = infoEnd.endUf;
        }

        private bool EndNull()
        {
            if (!String.IsNullOrEmpty(maskedTextBoxCep.Text.Replace(".", "").Replace("-", "").Trim()) &&
                !String.IsNullOrEmpty(textBoxComplemento.Text) && !String.IsNullOrEmpty(textBoxPontoReferencia.Text))
            {
                return true;
            }
            else
                return false;
        }

        private void Salvar()
        {
            if (alterar)

                idSave = clienteNegocios.UpdateEndereco(novoEndereco);
            else
                idSave = clienteNegocios.InserirEndereco(novoEndereco);

            Form1.encerrarThread = true;
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (EndNull())
            {
                    
                if (FormMessage.ShowMessegeQuestion("Deseja salvar o endereço?") == DialogResult.Yes)
                {
                    novoEndereco = new EnderecoInfo
                    {
                        Cep = maskedTextBoxCep.Text,
                        Complemento = textBoxComplemento.Text,
                        endBairro = textBoxBairro.Text,
                        endCidade = textBoxCidade.Text,
                        endLogradouro = textBoxLogradouro.Text,
                        endUf = textBoxUF.Text,
                        IdCliente = infoCliente == null ? infoEnd.IdCliente : infoCliente.cliid,
                        IdEnd = infoEnd == null ? 0 : infoEnd.IdEnd,
                        PontoReferencia = textBoxPontoReferencia.Text
                    };

                    thread = new Thread(Salvar);
                    form1.ExecutarThread(thread);
                    this.Activate();

                    if (idSave > 0)
                    {
                        FormMessage.ShowMessegeInfo("Salvo com sucesso!");
                        this.DialogResult = DialogResult.Yes;
                    }
                    else
                        FormMessage.ShowMessegeInfo("Não foi possível salvar!");
                }
            }
            else
                FormMessage.ShowMessegeWarning("Preencha todos os campos do endereço!");
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelCep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.buscacep.correios.com.br/sistemas/buscacep/");
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            CepInfo cepInfo = new CepInfo();

            cepInfo = clienteNegocios.ConsultarCep(maskedTextBoxCep.Text);

            if (cepInfo != null)
            {
                textBoxLogradouro.Text = cepInfo.Logradouro;
                textBoxBairro.Text = cepInfo.Bairro;
                textBoxCidade.Text = cepInfo.Cidade;
                textBoxUF.Text = cepInfo.Uf;
                textBoxComplemento.Select();
            }
            else
            {
                FormMessage.ShowMessegeWarning("CEP não encontrado, tente outro CEP!");
            }
        }
    }
}

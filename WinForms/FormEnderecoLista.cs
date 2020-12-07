using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Negocios;
using ObjTransfer;
using System.Diagnostics;

namespace WinForms
{
    public partial class FormEnderecoLista : Form
    {
        Form1 form1 = new Form1();
        Thread thread;
        ClienteInfo clienteInfo;
        EnderecoInfo infoEnd;
        EnderecoColecao colecaoEndereco;
        public EnderecoInfo SelecionandoEnd { get; set; }

        ClienteNegocios negociosCliente = new ClienteNegocios(Form1.Empresa.empconexao);

        public FormEnderecoLista(EnderecoColecao end)
        {
            colecaoEndereco = end;
            Inicializar();
            PreencherDataGridEnd();
        }

        public FormEnderecoLista(ClienteInfo cliente)
        {
            clienteInfo = cliente;
            Inicializar();
            PreencherForm();
        }
        private void PreencherForm()
        {
            thread = new Thread(ConsultarEnd);
            form1.ExecutarThread(thread);
            this.Activate();
            PreencherDataGridEnd();
            DesativarBotaoPadrao();
            dataGridViewEndereco.Select();
        }

        private void ConsultarEnd()
        {
            colecaoEndereco = negociosCliente.ConsultarEnderecoPorIdCliente(clienteInfo.cliid);
            Form1.encerrarThread = true;
        }

        private void PreencherDataGridEnd()
        {
            EnderecoColecao colecao = new EnderecoColecao();

            if (colecaoEndereco != null)
            {
                foreach (EnderecoInfo end in colecaoEndereco)
                {
                    string padrao = string.Empty;

                    if (end.endpadrao)
                        padrao = "(PADRÃO) - ";

                    EnderecoInfo nEnd = new EnderecoInfo
                    {
                        IdEnd = end.IdEnd,
                        IdCliente = end.IdCliente,
                        endpadrao = end.endpadrao,
                        Complemento = padrao + "Bairro: " + end.endBairro + ", Local: " + end.endLogradouro + ", End.: " + end.Complemento
                    };

                    colecao.Add(nEnd);
                }
            }
            else
            {
                EnderecoInfo nEnd = new EnderecoInfo
                {
                    Complemento = "NENHUM ENDEREÇO CADASTRADO PARA ESTE CLIENTE"
                };

                colecao.Add(nEnd);
            }

            dataGridViewEndereco.DataSource = colecao;
            dataGridViewEndereco.Select();

            
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            //this.FormBorderStyle = FormBorderStyle.None;
            this.AcceptButton = buttonSelecionar;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            Selecionado();
            DialogResult = DialogResult.Yes;
        }

        private void Selecionado()
        {
            if (dataGridViewEndereco.SelectedRows.Count > 0)
            {
                infoEnd = (EnderecoInfo)dataGridViewEndereco.SelectedRows[0].DataBoundItem;

                foreach (EnderecoInfo end in colecaoEndereco)
                    if (end.IdEnd == infoEnd.IdEnd)
                        SelecionandoEnd = end;
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormEditEndereco formEditEndereco = new FormEditEndereco(clienteInfo);
            formEditEndereco.ShowDialog(this);
            formEditEndereco.Dispose();

            if (formEditEndereco.DialogResult == DialogResult.Yes)
                PreencherForm();
        }

        private void buttonAlter_Click(object sender, EventArgs e)
        {
            Selecionado();

            FormEditEndereco formEditEndereco = new FormEditEndereco(SelecionandoEnd);
            formEditEndereco.Activate();
            formEditEndereco.ShowDialog(this);
            formEditEndereco.Dispose();

            if (formEditEndereco.DialogResult == DialogResult.Yes)
                PreencherForm();
        }

        private void buttonPadrao_Click(object sender, EventArgs e)
        {
            Selecionado();
            thread = new Thread(DefinirPadrao);
            form1.ExecutarThread(thread);
            this.Activate();
            PreencherForm();
        }

        private void DefinirPadrao()
        {
            negociosCliente.UpdateDefinirEnderecoPadrao(infoEnd);
            Form1.encerrarThread = true;
        }

        private void dataGridViewEndereco_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DesativarBotaoPadrao();
        }

        private void DesativarBotaoPadrao()
        {
            Selecionado();

            if (infoEnd != null)
            {
                if (infoEnd.endpadrao)
                    buttonPadrao.Enabled = false;
                else
                    buttonPadrao.Enabled = true;
            }
        }

        private void FormEnderecoLista_Load(object sender, EventArgs e)
        {
            if (dataGridViewEndereco.Rows.Count > 0)
            {
                dataGridViewEndereco.Rows[0].Cells["ColComplemento"].Style.BackColor = Color.FromArgb(224, 255, 255);
                dataGridViewEndereco.Rows[0].Cells["ColComplemento"].Style.ForeColor = Color.Green;
                dataGridViewEndereco.ClearSelection();
            }
            DesativarBotaoPadrao();
        }

        private void DataGridViewEndereco_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }
    }
}

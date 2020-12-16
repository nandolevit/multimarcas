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

namespace WinForms
{
    public partial class FormClienteConsultar : Form
    {
        Form1 form1 = new Form1();
        Thread thread;
        ClienteNegocios clienteNegocios = new ClienteNegocios(Form1.Empresa.empconexao);
        public ClienteInfo SelecionadoCliente { get; set; }
        ClienteInfo infoCliente;
        ServicoInfo infoServico;
        ClienteColecao colecaoCliente;
        string pesquisa;
        bool modSelect;

        public FormClienteConsultar(bool mod)
        {
            Inicializar();
            modSelect = mod;
        }
        public FormClienteConsultar()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.AcceptButton = buttonBuscar;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            RealizarPesquisa();
        }

        private void RealizarPesquisaThread()
        {
            colecaoCliente = clienteNegocios.ConsultarPorNome(pesquisa);
            Form1.encerrarThread = true;
        }

        private void RealizarPesquisa()
        {
            pesquisa = textBoxPesquisar.Text.Trim();
            thread = new Thread(RealizarPesquisaThread);
            form1.ExecutarThread(thread);
            this.Activate();
            PreencherGrid();
        }

        private void PreencherGrid()
        {
            if (colecaoCliente != null)
            {
                dataGridViewPesquisarCliente.DataSource = colecaoCliente;
                dataGridViewPesquisarCliente.Select();
            }
            else
            {
                ClienteInfo cliente = new ClienteInfo
                {
                    clinome = "NENHUM REGISTRO FOI ENCONTRADO!"
                };

                colecaoCliente = new ClienteColecao
                {
                    cliente
                };

                dataGridViewPesquisarCliente.DataSource = colecaoCliente;
                textBoxPesquisar.Select();
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            AbrirCliente();
        }

        private void dataGridViewPesquisarCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirCliente();
        }

        private void AbrirCliente()
        {
            Selecionado();

            if (modSelect)
                DialogResult = DialogResult.Yes;
            else
            {
                using (FormCadastroPessoa formCadastroPessoa = new FormCadastroPessoa(infoCliente))
                {
                    if(formCadastroPessoa.ShowDialog(this)== DialogResult.Yes)
                    {
                        RealizarPesquisa();
                    }
                }
            }
        }

        private void Selecionado()
        {
            if (dataGridViewPesquisarCliente.SelectedRows.Count > 0)
            {
                infoCliente = (ClienteInfo)dataGridViewPesquisarCliente.SelectedRows[0].DataBoundItem;
                SelecionadoCliente = infoCliente;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            RealizarPesquisa();
        }

        private void FormClienteConsultar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    AbrirCliente();
                    break;
                default:
                    break;
            }
        }

        private void FormClienteConsultar_Load(object sender, EventArgs e)
        {
            textBoxPesquisar.Select();
        }
    }
}

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
    public partial class FormProdutosConsultar : Form
    {
        ProdutoNegocios produtoNegocios = new ProdutoNegocios(Form1.Empresa.empconexao);
        ProdutoColecao produtosColecao;

        public int CodProd { get; set; }
        public ProdutoInfo Produtos { get; set; }
        ProdEnum prodEnum = new ProdEnum();

        public FormProdutosConsultar()
        {
            Inicializar();
        }

        public FormProdutosConsultar(ProdEnum prod)
        {
            Inicializar();
            prodEnum = prod;
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.AcceptButton = buttonPesquisar;
            textBoxPesquisar.Select();

        }

        private void PreencherGrid()
        {

            int pesquisa = 0;
            produtosColecao = new ProdutoColecao();

            if (radioButtonProd.Checked)
                pesquisa = 0;

            if (radioButtonId.Checked)
                pesquisa = 1;

            if (radioButtonBarras.Checked)
                pesquisa = 2;

            switch (pesquisa)
            {
                case 0:
                    produtosColecao = produtoNegocios.ConsultarProdutosDescricao(textBoxPesquisar.Text);
                    break;
                case 1:
                    if (int.TryParse(textBoxPesquisar.Text, out int id))
                        produtosColecao.Add(produtoNegocios.ConsultarProdutosId(id));
                    else
                        FormMessage.ShowMessegeWarning("Digite um código válido!");
                    break;
                case 2:
                    produtosColecao.Add(produtoNegocios.ConsultarProdutoCodBarras(textBoxPesquisar.Text));
                    break;
                default:
                    break;
            }
            
            dataGridViewProd.DataSource = null;

            if (produtosColecao != null)
            {
                dataGridViewProd.DataSource = produtosColecao;
                dataGridViewProd.Select();
            }
            else
            {
                dataGridViewProd.Rows.Add(null, null, "Nenhum produto foi encontrado!");
                textBoxPesquisar.Select();
            }

            //dataGridViewProd.ClearSelection();
            textBoxPesquisar.Clear();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            PreencherGrid();
        }

        private void radioButtonProd_CheckedChanged(object sender, EventArgs e)
        {
            TipoPesquisaChange();
        }

        private void radioButtonId_CheckedChanged(object sender, EventArgs e)
        {
            TipoPesquisaChange();
        }

        private void radioButtonBarras_CheckedChanged(object sender, EventArgs e)
        {
            TipoPesquisaChange();
        }

        private void TipoPesquisaChange()
        {
            textBoxPesquisar.Clear();
            textBoxPesquisar.Select();
            dataGridViewProd.DataSource = null;
        }

        private void ProdSelecionado()
        {
            if (produtosColecao != null)
            {
                ProdutoInfo produtosInfo = (ProdutoInfo)dataGridViewProd.SelectedRows[0].DataBoundItem;

                switch (prodEnum)
                {
                    case ProdEnum.Prod:
                        CodProd = produtosInfo.proId;
                        FormProdutos formProdutos = new FormProdutos(CodProd);
                        formProdutos.ShowDialog(this);
                        break;
                    case ProdEnum.Pedido:
                    case ProdEnum.Venda:
                    case ProdEnum.Estoque:
                        Produtos = produtosInfo;
                        DialogResult = DialogResult.Yes;
                        break;
                    default:
                        break;
                }
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProdutosConsultar_Load(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void FormProdutosConsultar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (this.ActiveControl.Equals(dataGridViewProd))
                        ProdSelecionado();
                    break;
                default:
                    break;
            }
        }

        private void dataGridViewProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdSelecionado();
        }
    }
}

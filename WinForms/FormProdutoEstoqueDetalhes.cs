using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjTransfer;

namespace WinForms
{
    public partial class FormProdutoEstoqueDetalhes : Form
    {
        EstoqueNegocios estoqueNegocios = new EstoqueNegocios(Form1.Empresa.empconexao);
        ProdutoNegocios produtoNegocios = new ProdutoNegocios(Form1.Empresa.empconexao);
        GridFormProdutoEstoqueColecao gridProdEstoque = new GridFormProdutoEstoqueColecao();
        GridFormProdutoEstoqueColecao gridProdEstoqueCopia = new GridFormProdutoEstoqueColecao(); //mantem uma copia do gridProdEstoque
        int dbLista;
        decimal dbEstoque, dbCompra, dbVarejo;

        public FormProdutoEstoqueDetalhes()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void dataGridViewProdutos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GridFormProdutoEstoqueInfo prod = (GridFormProdutoEstoqueInfo)dataGridViewProdutos.SelectedRows[0].DataBoundItem;
            FormProdutos formProdutos = new FormProdutos(prod.proid);
            formProdutos.ShowDialog(this);
            formProdutos.Dispose();

            if (formProdutos.DialogResult == DialogResult.Yes)
                BuscarLista();
        }

        private void FormProdutoEstoqueDetalhes_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewProdutos.Columns.Count; i++)
                dataGridViewProdutos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            BuscarLista();
            textBoxPesquisar.Select();
        }

        private bool PesquisarProduto()
        {
            string pesquisar = textBoxPesquisar.Text.Trim();

            if (gridProdEstoque.Count != gridProdEstoqueCopia.Count)
                gridProdEstoque = gridProdEstoqueCopia;

            if (radioButtonCod.Checked)
            {
                if (int.TryParse(pesquisar, out int cod))
                {
                    foreach (GridFormProdutoEstoqueInfo item in gridProdEstoque)
                    {
                        if (cod == item.proid)
                        {
                            gridProdEstoque = new GridFormProdutoEstoqueColecao();
                            gridProdEstoque.Add(item);
                            return true;
                        }
                    }
                    
                }
            }
            else if (radioButtonBarras.Checked)
            {
                textBoxPesquisar.Clear();
                foreach (GridFormProdutoEstoqueInfo item in gridProdEstoque)
                {
                    if (pesquisar == item.procodbarras)
                    {
                        gridProdEstoque = new GridFormProdutoEstoqueColecao();
                        gridProdEstoque.Add(item);
                        return true;
                    }
                }
            }
            else if (radioButtonDescricao.Checked)
            {
                gridProdEstoque = new GridFormProdutoEstoqueColecao();
                gridProdEstoque = estoqueNegocios.ConsultarEstoqueProdutosDescricao(pesquisar);

                if (gridProdEstoque != null)
                    return true;
                else
                    return false;
            }

            return false;
        }

        private void PreencherGridNaoEncontrado()
        {
            GridFormProdutoEstoqueInfo item = new GridFormProdutoEstoqueInfo
            {
                prodescricao = "Nenhum produto foi encontrado!"
            };

            gridProdEstoque = new GridFormProdutoEstoqueColecao();
            gridProdEstoque.Add(item);
            PreencherGrid();
        }

        private void FormProdutoEstoqueDetalhes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ResultadoPesquisa();
                    break;
                default:
                    break;
            }
        }

        private void ResultadoPesquisa()
        {
            //Thread thread = new Thread(Carregando);
            //thread.Start();
            buttonBuscar.Enabled = false;
            textBoxPesquisar.Enabled = false;
            if (PesquisarProduto())
                PreencherGrid();
            else
                PreencherGridNaoEncontrado();
            buttonBuscar.Enabled = true;
            textBoxPesquisar.Enabled = true ;
            textBoxPesquisar.Select();


            //thread.Abort();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ResultadoPesquisa();
        }

        private void radioButtonCod_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPesquisar.Select();
        }

        private void radioButtonBarras_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPesquisar.Select();
        }

        private void radioButtonDescricao_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPesquisar.Select();
        }

        private void BuscarLista()
        {
            gridProdEstoque = estoqueNegocios.ConsultarEstoqueProdutos();
            gridProdEstoqueCopia = gridProdEstoque;
            PreencherGrid();
        }

        private void PreencherGrid()
        {
            if (gridProdEstoque != null)
            {
                dbEstoque = 0;
                dbLista = 0;
                dbVarejo = 0;
                dbCompra = 0;
                dataGridViewProdutos.DataSource = null;
                dataGridViewProdutos.DataSource = gridProdEstoque;

                foreach (GridFormProdutoEstoqueInfo item in gridProdEstoque)
                {
                    dbEstoque += item.prodestoquequant;
                    dbCompra += (item.prodestoquequant * item.provalorcompra);
                    dbVarejo += (item.prodestoquequant * item.provalorvarejo);
                }

                dbLista = gridProdEstoque.Count;

                labelLista.Text = "Itens listados: " + string.Format("{0:00000}", dbLista);
                labelCompra.Text = "Custo do estoque: " + dbCompra.ToString("C2");
                labelVarejo.Text = "Valor do estoque: " + dbVarejo.ToString("C2");
                labelEstoque.Text = "Total em estoque: " + string.Format("{0:00000}", dbEstoque);
            }
        }
    }
}

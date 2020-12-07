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
    public partial class FormEstoqueContagem : Form
    {
        ProdutoNegocios produtoNegocios = new ProdutoNegocios(Form1.Empresa.empconexao);
        EstoqueNegocios estoqueNegocios = new EstoqueNegocios(Form1.Empresa.empconexao);
        SerializarNegocios serializarNegocios = new SerializarNegocios(Form1.Caminho);
        ProdutoInfo produtoInfo;
        EstoqueContarInfo estoqueContarInfo;
        GridLancarEstoqueColecao gridLancarEstoqueColecao = new GridLancarEstoqueColecao();
        private bool Cancelar { get; set; }
        public static string CodBarras { get; set; }
        private bool ProdContagem { get; set; }

        public FormEstoqueContagem(bool contagem)
        {
            Inicializar();
            ProdContagem = contagem;
            textBoxValorCod.Enabled = false;
        }

        public FormEstoqueContagem()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void FormEstoqueContagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxProdutoCod.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ConsultarProduto();
                }
            }
        }

        private void ConsultarProduto()
        {
            produtoInfo = new ProdutoInfo();

            if (radioButtonBarras.Checked)
            {
                produtoInfo = produtoNegocios.ConsultarProdutoCodBarras(textBoxProdutoCod.Text);

                if (produtoInfo != null)
                    PreencherProdForm(produtoInfo);
                else
                {
                    CodBarras = textBoxProdutoCod.Text;
                    textBoxProdutoCod.Clear();
                    FormProdutos formProdutos = new FormProdutos(ProdEnum.Estoque);
                    formProdutos.ShowDialog(this);
                    formProdutos.Dispose();
                }
            }
            else
            {
                if (int.TryParse(textBoxProdutoCod.Text, out int cod))
                {
                    produtoInfo = produtoNegocios.ConsultarProdutosId(cod);

                    if (produtoInfo != null)
                        PreencherProdForm(produtoInfo);
                }
                else
                {
                    FormMessage.ShowMessegeWarning("Insira um código válido!");
                    textBoxProdutoCod.Clear();
                }
            }
        }

        private void PreencherProdForm(ProdutoInfo produto)
        {
            if (produto.proControleEstoque)
                produto = produtoNegocios.ConsultarEstoqueIdProdutoUnid(produtoInfo.proId, Form1.Unidade.uniid);
            else
            {
                if (FormMessage.ShowMessegeQuestion("O controle de estoque não está ativo para este produto! Deseja ativar o controle?") == DialogResult.Yes)
                {
                    if (produtoNegocios.UpdateProdutoConfirmarLancEstoqueId(produtoInfo.proId) > 0)
                        produto = produtoNegocios.ConsultarEstoqueIdProdutoUnid(produtoInfo.proId, Form1.Unidade.uniid);
                }
                else
                    return;
            }

            labelProdutoDescricao.Text = string.IsNullOrEmpty(produto.proCodBarras) ? produto.proDescricao : produto.proCodBarras + " - " + produto.proDescricao;
            labelValorUnit.Text = string.Format("{0:C}", produto.proValorCompra);
            buttonAddItem.Enabled = true;
            labelQuantEstoque.Text = string.Format("{0:000}", produto.prodestoquequant);

            produtoInfo = produto;
            PreencherGrid();
        }

        private void buttonProdutoBuscar_Click(object sender, EventArgs e)
        {
            produtoInfo = new ProdutoInfo();
            FormProdutosConsultar formProdutosConsultar = new FormProdutosConsultar(ProdEnum.Estoque);
            formProdutosConsultar.ShowDialog(this);

            if (formProdutosConsultar.DialogResult == DialogResult.Yes)
            {
                produtoInfo = formProdutosConsultar.Produtos;
                PreencherProdForm(produtoInfo);
            }

            formProdutosConsultar.Dispose();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            PreencherGrid();
        }

        private void PreencherGrid()
        {
            if (produtoInfo != null)
            {
                int quant = Convert.ToInt32(textBoxQuant.Text);

                GridLancarEstoqueInfo gridLancarEstoqueInfo = new GridLancarEstoqueInfo
                {
                    descricao = string.IsNullOrEmpty(produtoInfo.proCodBarras)? produtoInfo.prodetalhes : produtoInfo.proCodBarras + " - " + produtoInfo.prodetalhes,
                    idestoque = estoqueContarInfo.estoquecontarid,
                    idproduto = produtoInfo.proId,
                    quant = quant,
                    valorTotal = quant * produtoInfo.proValorCompra,
                    valorUnit = produtoInfo.proValorCompra,

                };

                if (gridLancarEstoqueColecao.Count > 0)
                {
                    for (int i = 0; i < gridLancarEstoqueColecao.Count; i++)
                    {
                        if (gridLancarEstoqueColecao[i].idproduto == gridLancarEstoqueInfo.idproduto)
                        {
                            gridLancarEstoqueInfo.quant += gridLancarEstoqueColecao[i].quant;
                            gridLancarEstoqueInfo.valorTotal = gridLancarEstoqueInfo.quant * gridLancarEstoqueInfo.valorUnit;
                            gridLancarEstoqueColecao.RemoveAt(i);
                        }
                    }
                }

                EstoqueContarDetalhesInfo estoquecontar = new EstoqueContarDetalhesInfo
                {
                    estoquecontardetalhesid = gridLancarEstoqueInfo.id,
                    estoquecontardetalhesidcontar = gridLancarEstoqueInfo.idestoque,
                    estoquecontardetalhesidproduto = gridLancarEstoqueInfo.idproduto,
                    estoquecontardetalhesquant = gridLancarEstoqueInfo.quant,
                    estoquecontardetalhesvalor = gridLancarEstoqueInfo.valorUnit
                };

                EstoqueContarDetalhesInfo contar = estoqueNegocios.ConsultarEstoqueContarDetalhesIdProd(gridLancarEstoqueInfo.idproduto, gridLancarEstoqueInfo.id);

                if (contar != null)
                {
                    estoquecontar.estoquecontardetalhesid = contar.estoquecontardetalhesid;
                    produtoNegocios.UpdateEstoqueContarDetalhes(estoquecontar);
                }
                else
                {
                    produtoNegocios.InsertEstoqueContarDetalhes(estoquecontar);
                }

                GridLancarEstoqueColecao novo = new GridLancarEstoqueColecao
                {
                    gridLancarEstoqueInfo
                };

                for (int i = 0; i < gridLancarEstoqueColecao.Count; i++)
                    novo.Add(gridLancarEstoqueColecao[i]);

                gridLancarEstoqueColecao = novo;
                
            }

            PreencherGridDataSource();
        }

        private void PreencherGridDataSource()
        {
            dataGridViewLancarEstoqueDetalhes.DataSource = null;
            dataGridViewLancarEstoqueDetalhes.DataSource = gridLancarEstoqueColecao;
            ContarGrid();
            
            textBoxProdutoCod.Clear();
            textBoxQuant.Text = "1";
            textBoxProdutoCod.Select();
            buttonAddItem.Enabled = false;
            produtoInfo = null;
        }

        private void ContarGrid()
        {
            if (dataGridViewLancarEstoqueDetalhes.Rows.Count > 0)
            {
                decimal quant = 0;
                decimal valor = 0;

                foreach (GridLancarEstoqueInfo lancar in gridLancarEstoqueColecao)
                {
                    quant += lancar.quant;
                    valor += lancar.valorTotal;
                }

                labelValorTotal.Text = string.Format("{0:C}", valor);
                labelValorTotalQuant.Text = string.Format("{0:0000}", quant);
            }
        }

        private void FormEstoqueContagem_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewLancarEstoqueDetalhes.ColumnCount; i++)
                dataGridViewLancarEstoqueDetalhes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            

            if (gridLancarEstoqueColecao.Count > 0)
            {
                estoqueContarInfo = produtoNegocios.ConstularEstoqueContarId(gridLancarEstoqueColecao[0].id);

                if (estoqueContarInfo != null)
                    if (estoqueContarInfo.estoquecontarconfirmado == 1 && estoqueContarInfo.estoquecontaridunidade == Form1.Unidade.uniid)
                        PreencherFormEstoque(estoqueContarInfo);
            }

            if (ProdContagem)
            {
                this.Text = "CONTAGEM POR PRODUTO";
                this.labelTitle.Text = "CONTAGEM POR PRODUTO";
            }
            else
            {

                this.Text = "CONTAGEM DO ESTOQUE";
                this.labelTitle.Text = "CONTAGEM DO ESTOQUE";
            }
        }

        private void textBoxProdutoCod_Leave(object sender, EventArgs e)
        {
        }

        private void buttonProdutoAdd_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos();
            formProdutos.ShowDialog(this);
            formProdutos.Dispose();
        }

        private void buttonProdutoConsultar_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos(produtoInfo.proId);
            formProdutos.ShowDialog(this);
            formProdutos.Dispose();
        }

        private void buttonInicializar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxValorCod.Text))
            {
                if (FormMessage.ShowMessegeQuestion("Deseja realizar uma nova contagem do estoque?") == DialogResult.Yes)
                {
                    estoqueContarInfo = new EstoqueContarInfo
                    {
                        estoquecontardata = DateTime.Now,
                        estoquecontaridfunc = Form1.User.useidfuncionario,
                        estoquecontaridunidade = Form1.Unidade.uniid
                    };

                    int cod = produtoNegocios.InsertEstoqueContar(estoqueContarInfo);

                    if (cod > 0)
                    {
                        estoqueContarInfo.estoquecontarid = cod;
                        PreencherFormEstoque(estoqueContarInfo);
                        PreencherGrid();
                    }
                    else
                        FormMessage.ShowMessegeWarning("Falha ao tentar salvar!");
                }
            }
            else
            {
                if (int.TryParse(textBoxValorCod.Text, out int cod))
                {
                    estoqueContarInfo = produtoNegocios.ConstularEstoqueContarId(cod);

                    if (estoqueContarInfo != null)
                    {
                        if (estoqueContarInfo.estoquecontarconfirmado != 1)
                        {
                            PreencherFormEstoque(estoqueContarInfo);

                            EstoqueContarDetalhesColecao contar = produtoNegocios.ConsultarEstoqueContarDetalhesIdContar(estoqueContarInfo.estoquecontarid);

                            if (contar != null)
                            {
                                gridLancarEstoqueColecao = new GridLancarEstoqueColecao();
                                foreach (EstoqueContarDetalhesInfo item in contar)
                                {
                                    ProdutoInfo prod = produtoNegocios.ConsultarProdutosId(item.estoquecontardetalhesidproduto);
                                    GridLancarEstoqueInfo grid = new GridLancarEstoqueInfo
                                    {
                                        descricao = prod.proCodBarras + " - " + prod.proDescricao,
                                        id = item.estoquecontardetalhesid,
                                        idestoque = estoqueContarInfo.estoquecontarid,
                                        idproduto = item.estoquecontardetalhesidproduto,
                                        quant = item.estoquecontardetalhesquant,
                                        valorTotal = item.estoquecontardetalhesvalor * item.estoquecontardetalhesquant,
                                        valorUnit = item.estoquecontardetalhesvalor
                                    };

                                    gridLancarEstoqueColecao.Add(grid);
                                }

                            }
                            
                            PreencherGridDataSource();
                        }
                        else
                            FormMessage.ShowMessegeWarning("Esta contagem já foi encerrada!");
                    }
                    else
                    {
                        FormMessage.ShowMessegeWarning("Estoque não encontrado!");
                        textBoxValorCod.Select();
                    }
                }
                else
                {
                    FormMessage.ShowMessegeWarning("Insira um valor válido!");
                    textBoxValorCod.Clear();
                    textBoxValorCod.Select();
                }
            }
        }

        private void PreencherFormEstoque(EstoqueContarInfo estoqueContarInfo)
        {
            textBoxValorCod.Enabled = false;
            textBoxValorCod.Text = string.Format("{0:000000}", estoqueContarInfo.estoquecontarid);
            labelValorData.Text = string.Format("{0:dddd, dd MMMM yyyy HH:mm}", estoqueContarInfo.estoquecontardata);
            groupBoxItem.Enabled = true;
            buttonInicializar.Enabled = false;
            buttonFechar.Text = "Cancel.";
            Cancelar = true;
            textBoxProdutoCod.Select();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            if (dataGridViewLancarEstoqueDetalhes.Rows.Count > 0)
            {
                if (!ProdContagem) //somente zerar o estoque caso não for no modo contagem
                    produtoNegocios.UpdateProdEstoqueZerar(Form1.Unidade.uniid, estoqueContarInfo.estoquecontarid);

                int cont = 1;
                foreach (DataGridViewRow row in dataGridViewLancarEstoqueDetalhes.Rows)
                {
                    progressBar1.Value = cont * (100 / dataGridViewLancarEstoqueDetalhes.Rows.Count);
                    cont++;
                    GridLancarEstoqueInfo gridLancarEstoqueInfo = (GridLancarEstoqueInfo)row.DataBoundItem;
                    EstoqueContarDetalhesInfo estoqueContarDetalhesInfo = new EstoqueContarDetalhesInfo
                    {
                        estoquecontardetalhesid = 0,
                        estoquecontardetalhesidcontar = gridLancarEstoqueInfo.idestoque,
                        estoquecontardetalhesidproduto = gridLancarEstoqueInfo.idproduto,
                        estoquecontardetalhesquant = gridLancarEstoqueInfo.quant,
                        estoquecontardetalhesvalor = gridLancarEstoqueInfo.valorUnit
                    };

                    if (!(produtoNegocios.InsertEstoqueContarDetalhes(estoqueContarDetalhesInfo) > 0))
                    {
                        FormMessage.ShowMessegeWarning("Falha ao tentar salvar!");
                        return;
                    }

                    ProdutoInfo produto = produtoNegocios.ConsultarEstoqueIdProdutoUnid(gridLancarEstoqueInfo.idproduto, Form1.Unidade.uniid);
                    produto.prodestoquequant = gridLancarEstoqueInfo.quant;
                    if (!(produtoNegocios.UpdateEstoqueId(produto) > 0))
                    {
                        FormMessage.ShowMessegeWarning("Falha ao tentar salvar!");
                        return;
                    }
                }

                estoqueContarInfo.estoquecontarconfirmado = 1;
                estoqueContarInfo.estoquecontarquant = Convert.ToInt32(labelValorTotalQuant.Text);
                estoqueContarInfo.estoquecontarvalor = Convert.ToDecimal(labelValorTotal.Text.Replace("R$ ",""));

                if (produtoNegocios.UpdateEstoqueContarId(estoqueContarInfo) > 0)
                {
                    progressBar1.Visible = false;
                    FormMessage.ShowMessegeInfo("O estoque foi contado com sucesso!");
                    LimparForm();
                }
            }
            else
                FormMessage.ShowMessegeWarning("Adicione um produto antes!");
            
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            if (!Cancelar)
            {
                this.Close();
            }
            else
            {
                if (FormMessage.ShowMessegeQuestion("Deseja cancelar a contagem?") == DialogResult.Yes)
                {
                    if (produtoNegocios.DeleteEstoqueContar(estoqueContarInfo.estoquecontarid) > 0)
                    {
                        FormMessage.ShowMessegeInfo("Contagem foi cancelada com sucesso!");
                        LimparForm();
                    }
                }
            }
        }

        private void LimparForm()
        {
            textBoxQuant.Text = "1";
            labelProdutoDescricao.Text = "";
            labelValorUnit.Text = "";
            labelQuantEstoque.Text = "";

            if (!ProdContagem)
                textBoxValorCod.Enabled = true;

            textBoxValorCod.Text = "";
            labelValorData.Text = "";
            gridLancarEstoqueColecao = new GridLancarEstoqueColecao();
            dataGridViewLancarEstoqueDetalhes.DataSource = null;
            buttonInicializar.Enabled = true;
            groupBoxItem.Enabled = false;
            buttonInicializar.Select();
            Cancelar = false;
            buttonFechar.Text = "&Fechar";
            labelValorTotal.Text = "";
            labelValorTotalQuant.Text = "";
        }

        private void radioButtonBarras_CheckedChanged(object sender, EventArgs e)
        {
            textBoxProdutoCod.Select();
        }
    }
}

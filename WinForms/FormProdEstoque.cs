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

namespace WinForms
{
    public partial class FormProdEstoque : Form
    {
        FornecedorNegocios fornecedorNegocios = new FornecedorNegocios(Form1.Empresa.empconexao);
        ProdutoNegocios produtoNegocios = new ProdutoNegocios(Form1.Empresa.empconexao);
        FornecedorInfo fornecedorInfo = new FornecedorInfo();
        ProdutoEstoqueInfo produtoEstoqueInfo = new ProdutoEstoqueInfo();
        ProdutoInfo produtoInfo = new ProdutoInfo();
        GridLancarEstoqueColecao gridLancarEstoqueColecao = new GridLancarEstoqueColecao();
        EstoqueLancamentoInfo estoqueLancamentoInfo;
        SerializarNegocios serializarNegocios = new SerializarNegocios(Form1.Caminho);
        private bool Cancelar { get; set; }
        private string FileName { get { return "est_lanc.lvt"; } }

        public FormProdEstoque()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void buttonBuscarFornecedor_Click(object sender, EventArgs e)
        {
            BuscarFornecedor();
        }

        private void BuscarFornecedor()
        {
            FornecedorColecao fornecedorColecao = fornecedorNegocios.ConsultarForncedor();
            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();

            if (fornecedorColecao != null)
            {
                Form_Consultar Consultar = new Form_Consultar
                {
                    Cod = string.Format("{0:000}", 0),
                    Descricao = "*FORNECEDORES DIVERSOS*"
                };

                form_ConsultarColecao.Add(Consultar);

                foreach (FornecedorInfo info in fornecedorColecao)
                {
                    Form_Consultar form_Consultar = new Form_Consultar
                    {
                        Cod = string.Format("{0:000}", info.forId),
                        Descricao = info.forNome
                    };

                    form_ConsultarColecao.Add(form_Consultar);
                }
            }

            Form_Consultar formConsultar = AbrirForm(form_ConsultarColecao, "Fornecedores");

            if (formConsultar != null)
            {
                textBoxFornecedorCod.Text = formConsultar.Cod;
                labelFornecedorDescricao.Text = formConsultar.Descricao;
                if (formConsultar.Cod != "000")
                    PreencherFormFornecedor();
                else
                {
                    fornecedorInfo = null;
                    buttonInicializar.Enabled = true;
                    buttonInicializar.Select();
                }
            }
        }

        private Form_Consultar AbrirForm(Form_ConsultarColecao form_Consultar, string titulo)
        {
            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_Consultar, titulo);
            formConsultar_Cod_Descricao.ShowDialog(this);

            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
                return formConsultar_Cod_Descricao.Selecionado;
            else
            {
                formConsultar_Cod_Descricao.Dispose();
                return null;
            }

        }

        private void buttonAddFornecedor_Click(object sender, EventArgs e)
        {
            FormCadastroPessoa formCadastroPessoa = new FormCadastroPessoa(fornecedorInfo);
            formCadastroPessoa.ShowDialog(this);
            formCadastroPessoa.Dispose();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (labelFornecedorDescricao.Text != "*FORNECEDORES DIVERSOS*")
                PreencherListaProdutos();
            else
            {
                FormProdutosConsultar formProdutosConsultar = new FormProdutosConsultar(ProdEnum.Estoque);
                formProdutosConsultar.ShowDialog(this);

                if (formProdutosConsultar.DialogResult == DialogResult.Yes)
                    BuscarProdutos(formProdutosConsultar.Produtos.proId.ToString());

                formProdutosConsultar.Dispose();
            }
        }

        private void PreencherListaProdutos()
        {
            ProdutoColecao produtoColecao = new ProdutoColecao();
            if (fornecedorInfo != null)
                produtoColecao = produtoNegocios.ConsultarProdutoEstoqueFornecedorId(fornecedorInfo.forId);
            else
                produtoColecao = produtoNegocios.ConsultarProdutosTodos();

               Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();

                if (produtoColecao != null)
                {
                    foreach (ProdutoInfo info in produtoColecao)
                    {
                        Form_Consultar form_Consultar = new Form_Consultar
                        {
                            Cod = string.Format("{0:000}", info.proId),
                            Descricao = info.proDescricao
                        };

                        form_ConsultarColecao.Add(form_Consultar);
                    }
                }

                Form_Consultar formConsultar = AbrirForm(form_ConsultarColecao, "Produtos por Fornecedores");


            if (formConsultar != null)
                BuscarProdutos(formConsultar.Cod);
        }

        private void PreencherFormProduto(ProdutoInfo produto)
        {
            textBoxProdutoCod.Text = string.Format("{0:000}", produto.proId);
            labelProdutoDescricao.Text = produto.prodetalhes;
            labelValorUnit.Text = string.Format("{0:C}", produto.proValorCompra);
            labelQuantEstoque.Text = string.Format("{0:000}", produto.prodestoquequant);
            
            textBoxQuant.Select();
            buttonProdutoInfo.Enabled = true;
            buttonAddItem.Enabled = true;

            produtoInfo = produto;
        }

        private void buttonProdutoAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFornecedorCod.Text != "000")
            {
                FormProdutos formProdutos = new FormProdutos(fornecedorInfo);
                formProdutos.ShowDialog(this);
                formProdutos.Dispose();
            }
            else
            {
                FormProdutos formProdutos = new FormProdutos();
                formProdutos.ShowDialog(this);
                formProdutos.Dispose();
            }
        }

        private void LimparProduto()
        {
            //textBoxProdutoCod.Clear();
            textBoxQuant.Text = string.Format("{0:0.000}",1);
            labelValorUnit.Text = string.Format("{0:C}", 0);
            labelQuantEstoque.Text = 0.ToString();
            labelProdutoDescricao.Text = "";
        }

        private void FormProdEstoque_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewLancarEstoqueDetalhes.ColumnCount; i++)
                dataGridViewLancarEstoqueDetalhes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

            if (serializarNegocios.ArquivoExiste(FileName))
            {
                gridLancarEstoqueColecao = (serializarNegocios.DesserializarObjeto(FileName) as GridLancarEstoqueColecao);

                if (gridLancarEstoqueColecao != null)
                {
                    estoqueLancamentoInfo = produtoNegocios.ConsultarEstoqueLancamento(gridLancarEstoqueColecao[0].id);

                    if (estoqueLancamentoInfo != null && estoqueLancamentoInfo.estoquelancamentoidunid == Form1.Unidade.uniid)
                    {
                        labelValorCod.Text = string.Format("{0:000000}", estoqueLancamentoInfo.estoquelancamentoid);
                        labelValorData.Text = estoqueLancamentoInfo.estoquelancamentodatahora.ToLongDateString() + " " + estoqueLancamentoInfo.estoquelancamentodatahora.ToShortTimeString();
                        textBoxFornecedorCod.Text = string.Format("{0:000}", 0);
                        labelFornecedorDescricao.Text = "*FORNECEDORES DIVERSOS*";
                        textBoxFornecedorCod.Enabled = false;
                        buttonAddFornecedor.Enabled = false;
                        buttonBuscarFornecedor.Enabled = false;
                        Cancelar = true;
                        buttonFechar.Text = "Cancel.";

                        groupBoxItem.Enabled = true;
                        buttonRemover.Enabled = true;
                        buttonInicializar.Enabled = false;
                        PreencherGrid();
                        textBoxProdutoCod.Select();
                    }
                }
            }

            textBoxFornecedorCod.Select();
        }

        private void textBoxFornecedorCod_Leave(object sender, EventArgs e)
        {
            PreencherFormFornecedor();
        }

        private void PreencherFormFornecedor()
        {
            if (!string.IsNullOrEmpty(textBoxFornecedorCod.Text))
            {
                if (textBoxFornecedorCod.Text != "000")
                {
                    if (int.TryParse(textBoxFornecedorCod.Text, out int cod))
                    {
                        fornecedorInfo = fornecedorNegocios.ConsultarForncedorId(cod);

                        if (fornecedorInfo != null)
                        {
                            textBoxFornecedorCod.Text = string.Format("{0:000}", fornecedorInfo.forId);
                            labelFornecedorDescricao.Text = fornecedorInfo.forNome;
                            buttonInicializar.Enabled = true;
                            buttonInicializar.Select();
                        }
                        else
                        {
                            FormMessage.ShowMessegeWarning("Nenhum fornecedor encontrado!");
                            textBoxFornecedorCod.Clear();
                            textBoxFornecedorCod.Select();
                        }
                    }
                    else
                    {
                        FormMessage.ShowMessegeWarning("Insira um código numérico!");
                        textBoxFornecedorCod.Clear();
                        textBoxFornecedorCod.Select();
                    }
                }
                else
                {
                    textBoxFornecedorCod.Text = string.Format("{0:000}", 0);
                    labelFornecedorDescricao.Text = "*FORNECEDORES DIVERSOS*";
                    fornecedorInfo = null;
                    buttonInicializar.Enabled = true;
                    buttonInicializar.Select();
                }
            }
        }

        private void textBoxFornecedorCod_TextChanged(object sender, EventArgs e)
        {
            labelFornecedorDescricao.Text = "";
        }

        private void buttonInicializar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFornecedorCod.Text))
            {
                estoqueLancamentoInfo = new EstoqueLancamentoInfo
                {
                    estoquelancamentoid = 0,
                    estoquelancamentodatahora = DateTime.Now
                };

                estoqueLancamentoInfo.estoquelancamentoid = produtoNegocios.InsertEstoqueLancamento(estoqueLancamentoInfo, Form1.Unidade.uniid);

                if (!string.IsNullOrEmpty(textBoxFornecedorCod.Text) && estoqueLancamentoInfo.estoquelancamentoid > 0) //o número 1 é referente a compra de mercadoria
                {
                    labelValorCod.Text = string.Format("{0:000000}", estoqueLancamentoInfo.estoquelancamentoid);
                    labelValorData.Text = estoqueLancamentoInfo.estoquelancamentodatahora.ToLongDateString();
                    textBoxFornecedorCod.Enabled = false;
                    buttonAddFornecedor.Enabled = false;
                    buttonBuscarFornecedor.Enabled = false;
                    buttonInicializar.Enabled = false;

                    groupBoxItem.Enabled = true;
                    textBoxProdutoCod.Select();
                }

                buttonFechar.Text = "&Cancel.";
                Cancelar = true;
            }
            else
            {
                FormMessage.ShowMessegeWarning("Selecione um fornecedor!");
                textBoxFornecedorCod.Select();
            }
        }

        private void textBoxProdutoCod_Leave(object sender, EventArgs e)
        {
            
        }

        private void BuscarProdutos(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                if (radioButtonCod.Checked)
                {
                    if (int.TryParse(id, out int cod))
                        produtoInfo = produtoNegocios.ConsultarProdutosId(cod);
                    else
                        FormMessage.ShowMessegeWarning("Insira um código válido!");
                }
                else
                    produtoInfo = produtoNegocios.ConsultarProdutoCodBarras(textBoxProdutoCod.Text);

                if (produtoInfo != null)
                {
                    if (produtoInfo.proControleEstoque == true)
                    {
                        ProdutoInfo produto = produtoNegocios.ConsultarEstoqueIdProdutoUnid(produtoInfo.proId, Form1.Unidade.uniid);

                        if (produto != null)
                        {
                            if (textBoxFornecedorCod.Text == "000")
                                PreencherFormProduto(produto);
                            else
                            {
                                if (produto.proidfornecedor == fornecedorInfo.forId)
                                    PreencherFormProduto(produto);
                                else
                                {
                                    FormMessage.ShowMessegeWarning("Este produto não pertence a este fornecedor!");
                                    textBoxProdutoCod.Clear();
                                }
                            }
                        }
                        else
                        {
                            if (produtoNegocios.InsertProdutoEstoque(produtoInfo.proId, Form1.Unidade.uniid) > 0)
                            {
                                produto = produtoNegocios.ConsultarEstoqueIdProdutoUnid(produtoInfo.proId, Form1.Unidade.uniid);
                                PreencherFormProduto(produto);
                            }
                            else
                                FormMessage.ShowMessegeWarning("Falha!");
                        }

                    }
                    else
                    {
                        if(FormMessage.ShowMessegeQuestion("O controle de estoque não está ativo para este produto! Deseja ativar o controle?") == DialogResult.Yes)
                        {
                            if(produtoNegocios.UpdateProdutoConfirmarLancEstoqueId(produtoInfo.proId) > 0)
                                PreencherFormProduto(produtoInfo);
                        }
                    }
                }
                else
                {
                    FormMessage.ShowMessegeWarning("Código inválido!");
                    textBoxProdutoCod.Clear();
                    textBoxProdutoCod.Select();
                }
            }
        }

        private void textBoxProdutoCod_TextChanged(object sender, EventArgs e)
        {
            LimparProduto(); 
        }

        private void radioButtonCod_CheckedChanged(object sender, EventArgs e)
        {
            LimparProduto();
        }

        private void buttonProdutoInfo_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos(produtoInfo.proId);
            formProdutos.ShowDialog(this);

            if (formProdutos.DialogResult == DialogResult.Yes)
                BuscarProdutos(textBoxProdutoCod.Text);

            formProdutos.Dispose();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxQuant.Text))
                AddNovoItem();
            else
                FormMessage.ShowMessegeWarning("Selecione um produto!");
        }

        private void AddNovoItem()
        {
            if (produtoInfo != null)
            {
                decimal quant = Convert.ToDecimal(textBoxQuant.Text);

                GridLancarEstoqueInfo gridLancarEstoqueInfo = new GridLancarEstoqueInfo
                {
                    descricao = produtoInfo.prodetalhes,
                    id = estoqueLancamentoInfo.estoquelancamentoid,
                    idproduto = produtoInfo.proId,
                    idestoque = produtoInfo.prodestoqueid,
                    quant = quant,
                    valorTotal = quant * produtoInfo.proValorCompra,
                    valorUnit = produtoInfo.proValorCompra
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

                GridLancarEstoqueColecao novo = new GridLancarEstoqueColecao();
                novo.Add(gridLancarEstoqueInfo);

                for (int i = 0; i < gridLancarEstoqueColecao.Count; i++)
                    novo.Add(gridLancarEstoqueColecao[i]);

                gridLancarEstoqueColecao = novo;

            }

            PreencherGrid();
            textBoxProdutoCod.Clear();
            textBoxProdutoCod.Select();
            LimparProduto();
            buttonConfirmar.Enabled = true;
            buttonRemover.Enabled = true;
            buttonAddItem.Enabled = false;
            labelRemover.ForeColor = Color.Red;
        }

        private void PreencherGrid()
        {
            dataGridViewLancarEstoqueDetalhes.DataSource = null;
            dataGridViewLancarEstoqueDetalhes.DataSource = gridLancarEstoqueColecao;
            dataGridViewLancarEstoqueDetalhes.ClearSelection();
            serializarNegocios.SerializarObjeto(gridLancarEstoqueColecao, FileName);
            ContarGrid();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (FormMessage.ShowMessegeQuestion("Deseja salvar no estoque?") == DialogResult.Yes)
                SalvarEstoque();
        }

        private bool InsertDetalhes(GridLancarEstoqueInfo lancar)
        {
            EstoqueLancamentoDetalhesInfo detalhes = new EstoqueLancamentoDetalhesInfo
            {
                estoquedetalhesidlancamento = estoqueLancamentoInfo.estoquelancamentoid,
                estoquedetalhesidprod = lancar.idproduto,
                estoquedetalhesquant = lancar.quant,
                estoquedetalhesvalor = lancar.valorUnit
            };

            if (produtoNegocios.InsertEstoqueLancamentoDetalhes(detalhes) > 0)
                return true;
            else
                return false;
        }

        private void SalvarEstoque()
        {
            if (dataGridViewLancarEstoqueDetalhes.RowCount > 0)
            {
                estoqueLancamentoInfo.estoquelancamentovalor = Convert.ToDecimal(labelValorTotal.Text.Replace("R$ ", ""));
                estoqueLancamentoInfo.estoquelancamentoquant = Convert.ToInt32(labelValorTotalQuant.Text);

                if (produtoNegocios.UpdateEstoqueLancamentoId(estoqueLancamentoInfo) > 0)
                {
                    EntradaSaidaInfo entradaSaidaSalvar = new EntradaSaidaInfo
                    {
                        entracodtodasparcelas = 0,
                        entraconfirmada = true,
                        entradatalancamento = DateTime.Now,
                        entradatavenc = DateTime.Now.Date,
                        entradocumento = Convert.ToString(estoqueLancamentoInfo.estoquelancamentoid),
                        entraid = 0,
                        entraidfunc = Form1.User.useidfuncionario,
                        entraidunidade = Form1.Unidade.uniid,
                        entranumparcela = 1,
                        entranumtotalparcelas = 1,
                        entraobs = "Controle do lançamento do estoque: " + string.Format("{0:00000}", estoqueLancamentoInfo.estoquelancamentoid) + Environment.NewLine +
                        "Quatidade de itens: " + string.Format("{0:000}", estoqueLancamentoInfo.estoquelancamentoquant) + Environment.NewLine + "Lançado por: " + Form1.User.usenome,
                        entratipocatdecricao = "",
                        entratipoidcat = 1,
                        entravalor = estoqueLancamentoInfo.estoquelancamentovalor,
                        entravalorpago = estoqueLancamentoInfo.estoquelancamentovalor,
                        entraidtipoentrada = 3,
                        entraparcelado = false
                    };

                    EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios(Form1.Empresa.empconexao);
                    if (entradaSaidaNegocios.InsertEntradaSaidaLancamento(entradaSaidaSalvar) == 0)
                    {
                        FormMessage.ShowMessegeWarning("Falha, tente novamente!");
                        return;
                    }

                    foreach (GridLancarEstoqueInfo lancar in gridLancarEstoqueColecao)
                    {
                        if(!InsertDetalhes(lancar))
                        {
                            FormMessage.ShowMessegeWarning("Falha ao tentar salvar!");
                            return;
                        }

                        ProdutoEstoqueInfo estoque = new ProdutoEstoqueInfo
                        {
                            prodestoqueid = lancar.idestoque,
                            prodestoquequant = lancar.quant
                        };

                        int cod = produtoNegocios.UpdateEstoqueId(estoque);
                        if (cod > 0)
                        {
                            MovEstoqueInfo movEstoqueInfo = new MovEstoqueInfo
                            {
                                movestoqueidproduto = lancar.idproduto,
                                movestoqueidtipomovimento = estoqueLancamentoInfo.estoquelancamentoidtipo,
                                movestoquequant = lancar.quant,
                                movestoquevalor = lancar.valorUnit
                            };

                            if (!produtoNegocios.InsertMovEstoque(movEstoqueInfo))
                            {
                                FormMessage.ShowMessegeWarning("Falha ao tentar salvar!");
                                return;
                            }
                        }
                        else
                        {
                            FormMessage.ShowMessegeWarning("Falha ao tentar salvar!");
                            return;
                        }
                    }
                }
                else
                {
                    FormMessage.ShowMessegeWarning("Falha ao tentar salvar!");
                    return;
                }

                FormMessage.ShowMessegeInfo("O estoque foi atualizado com sucesso!");

                LimparCampos();
            }
            else
                FormMessage.ShowMessegeWarning("Adicione um produto a lista!");
        }

        private void LimparCampos()
        {
            buttonConfirmar.Enabled = false;
            groupBoxItem.Enabled = false;

            labelValorCod.Text = string.Format("{0:000000}", 0);
            textBoxFornecedorCod.Enabled = true;
            textBoxFornecedorCod.Clear();
            textBoxFornecedorCod.Select();
            labelFornecedorDescricao.Text = "";
            buttonAddFornecedor.Enabled = true;
            buttonBuscarFornecedor.Enabled = true;
            buttonInicializar.Enabled = false;
            buttonFechar.Text = "&Ferchar";
            LimparProduto();
            textBoxProdutoCod.Clear();
            Cancelar = false;

            produtoInfo = new ProdutoInfo();
            gridLancarEstoqueColecao = new GridLancarEstoqueColecao();
            dataGridViewLancarEstoqueDetalhes.DataSource = null;
            serializarNegocios.ExcluirArquivo(FileName);
            labelValorTotal.Text = string.Format("{0:C}", 0);
            labelValorTotalQuant.Text = string.Format("{0:0000}", 0);
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            if (Cancelar)
            {
                if (FormMessage.ShowMessegeQuestion("Deseja cancelar este lançamento?") == DialogResult.Yes)
                {
                    if (produtoNegocios.UpdateEstoqueLancamentoStatus(estoqueLancamentoInfo.estoquelancamentoid, 3) > 0)
                    {
                        FormMessage.ShowMessegeInfo("O lançamento foi cancelado com sucesso!");
                        LimparCampos();
                    }
                    else
                        FormMessage.ShowMessegeWarning("Falha ao tentar falhar!");
                }
            }
            else
                this.Close();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewLancarEstoqueDetalhes.SelectedRows.Count > 0)
            {
                GridLancarEstoqueInfo selecionado = (GridLancarEstoqueInfo)dataGridViewLancarEstoqueDetalhes.SelectedRows[0].DataBoundItem;
                
                for (int i = 0; i < gridLancarEstoqueColecao.Count; i++)
                    if (selecionado.id == gridLancarEstoqueColecao[i].id)
                        gridLancarEstoqueColecao.RemoveAt(i);

                PreencherGrid();
            }
            else
                FormMessage.ShowMessegeWarning("Selecione o item a ser removido!");
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

        private void FormProdEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarProdutos(textBoxProdutoCod.Text);
            }
        }

        private void textBoxQuant_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.Format3casasdecimais((TextBox)sender);
        }
    }
}

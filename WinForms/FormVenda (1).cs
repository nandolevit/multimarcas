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
    public partial class FormVenda : Form
    {

        FuncNegocios funcNegocios = new FuncNegocios(Form1.Empresa.empconexao);
        FuncInfo funcInfo = new FuncInfo();
        ProdutoNegocios produtoNegocios = new ProdutoNegocios(Form1.Empresa.empconexao);
        ItemVendaColecao itemVendaColecao = new ItemVendaColecao();
        ClienteInfo clienteInfo = new ClienteInfo();
        VendaNegocios vendaNegocios = new VendaNegocios(Form1.Empresa.empconexao);
        VendaInfo vendaInfo = new VendaInfo();
        ItemVendaInfo itemSelecionando = new ItemVendaInfo();
        SerializarNegocios serializarNegocios = new SerializarNegocios(Form1.Caminho);
        FuncInfo responsavel = new FuncInfo();

        private bool VendaVip { get; set; }
        private bool VendaEncerrada { get; set; }
        private bool VendaAtiva { get; set; }
        private string FileName { get { return "vend.lvt"; } }

        decimal qtTotal = 0;
        decimal dcTotal = 0;

        public FormVenda()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private int InserirVenda()
        {
            if (FormMessage.ShowMessegeQuestion("Deseja encerrar essa venda?") != DialogResult.Yes)
                return 0;

            CaixaNegocios caixaNegocios = new CaixaNegocios(Form1.Empresa.empconexao);
            CaixaAbrirInfo caixaAbrirInfo = caixaNegocios.ConsultarCaixaAberto(Form1.Unidade.uniid);
            Caixa caixa = new Caixa();
            CaixaTurnoInfo caixaTurnoInfo = caixa.ConsultarTurnoAberto();

            vendaInfo = new VendaInfo
            {
                vendata = DateTime.Now.Date,
                venidcliente = clienteInfo.Id,
                venidfunc = funcInfo.funId,
                venidunidade = Form1.Unidade.uniid,
                venquant = qtTotal,
                venvalor = dcTotal,
                venvip = VendaVip ? 1 : 0,
                venmodo = 1,
                venidturno = caixaTurnoInfo.caixaturnoid
            };

            vendaInfo.venid = vendaNegocios.InsertVenda(vendaInfo);

            foreach (ItemVendaInfo item in itemVendaColecao)
            {
                VendaDetalhesInfo vendaDetalhesInfo = new VendaDetalhesInfo
                {
                    vendetalhesid = 0,
                    vendetalhesidprod = item.Id,
                    vendetalhesidvenda = vendaInfo.venid,
                    vendetalhesquant = item.Quant,
                    vendetalhesvalordesc = item.ValorDesc,
                    vendetalhesvalorunit = item.ValorUnit,
                    vendetalhesfunc = item.funid
                };

                if (vendaNegocios.InsertVendaDetalhes(vendaDetalhesInfo) == 0)
                {
                    FormMessage.ShowMessegeWarning("Falha ao salvar os itens!");
                    return 0;
                }
            }
            return vendaInfo.venid;
        }

        private void ExecutarContagem()
        {
            decimal dc = 0;
            decimal dcQuant = 0;

            foreach (ItemVendaInfo vend in itemVendaColecao)
            {
                dc += vend.Total;
                dcQuant += vend.Quant;
            }

            dcTotal = dc;
            qtTotal = dcQuant;
            labelValorTotal.Text = dc.ToString("C");
            labelValorVolume.Text = dcQuant.ToString("000");

            if (dc > 0)
                buttonConcluir.Enabled = true;
            else
                buttonConcluir.Enabled = false;
        }

        private void FormVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (!VendaEncerrada)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ConsultarProduto();
                }

                if (e.KeyCode == Keys.F11)
                {
                    if (FormMessage.ShowMessegeQuestion("Deseja cancelar está venda?") == DialogResult.Yes)
                        this.Close();
                }

                CriarFuncoes(e);
            }
            else
            {
                if (e.KeyCode == Keys.F11)
                    this.Close();
            }
        }

        private void PreencherFormProduto(ProdutoInfo produtosInfo)
        {
            decimal dbQuant = Convert.ToDecimal(textBoxQuant.Text);

            if (produtosInfo.proControleEstoque == 1)
            {
                int cod = produtosInfo.proId;
                produtosInfo = new ProdutoInfo();
                produtosInfo = produtoNegocios.ConsultarEstoqueIdProdutoUnid(cod, Form1.Unidade.uniid);

                if (produtosInfo.prodestoquequant < 1)
                    FormMessage.ShowMessegeWarning("Verificar o estoque, consta que não tem mais desse produto!");
            }


            ItemVendaInfo itemVendaInfo = new ItemVendaInfo
            {
                Id = produtosInfo.proId,
                ValorDesc = produtosInfo.proValorVarejo,
                Barras = produtosInfo.proCodBarras,
                Descricao = produtosInfo.proDescricao,
                Quant = dbQuant,
                Total = produtosInfo.proValorVarejo * dbQuant,
                ValorUnit = produtosInfo.proValorVarejo,
                funid = funcInfo.funId,
                funnome = funcInfo.funNome
            };

            if (produtosInfo.proControleEstoque == 1)
                if (itemVendaInfo.Quant > produtosInfo.prodestoquequant)
                    FormMessage.ShowMessegeWarning("A quantidade de produto lançada é maior que a quantidade que há no estoque!");

            labelDescricao.Text = produtosInfo.proDescricao;
            labelValorTotalProd.Text = itemVendaInfo.Total.ToString("C");

            labelValorProdCod.Text = string.Format("{0:000000}", produtosInfo.proId);
            labelValorProdBarras.Text = produtosInfo.proCodBarras;
            labelValorProdQuant.Text = dbQuant.ToString("000");
            labelValorProdPreco.Text = itemVendaInfo.ValorDesc.ToString("C");
            labelValorEstoque.Text = string.Format("{0:000}", produtosInfo.prodestoquequant);

            textBoxQuant.Text = "1,000";
            textBoxBarras.Clear();
            textBoxBarras.Select();
            buttonRemover.Enabled = true;
            
            if (itemVendaColecao.Count > 0)
            {
                for (int i = 0; i < itemVendaColecao.Count; i++)
                {
                    if (itemVendaColecao[i].Id == itemVendaInfo.Id)
                    {
                        itemVendaInfo.ValorDesc = itemVendaColecao[i].ValorDesc;
                        itemVendaInfo.Quant += itemVendaColecao[i].Quant;
                        itemVendaInfo.Total = itemVendaColecao[i].ValorDesc * itemVendaInfo.Quant;
                        itemVendaInfo.funid = itemVendaColecao[i].funid;
                        itemVendaInfo.funnome = itemVendaColecao[i].funnome;
                        itemVendaColecao.RemoveAt(i);
                    }
                }

                AdicionarResponsavel(itemVendaInfo);
            }
            else
            {
                if (produtosInfo.proControleEstoque == 1)
                    if (itemVendaInfo.Quant > produtosInfo.prodestoquequant)
                        FormMessage.ShowMessegeWarning("A quantidade de produto lançada é maior que a quantidade que há no estoque!");

                itemVendaColecao.Add(itemVendaInfo);
                AdicionarItemProd();
            }
        }

        private void MudarResponsavel()
        {
            ItemVendaInfo item = (ItemVendaInfo)dataGridViewItens.SelectedRows[0].DataBoundItem;
            
            for (int i = 0; i < itemVendaColecao.Count; i++)
            {
                if (itemVendaColecao[i].Id == item.Id)
                {
                    item.funid = responsavel.funId;
                    item.funnome = responsavel.funNome;
                    itemVendaColecao.RemoveAt(i);
                }
            }

            AdicionarResponsavel(item);
        }

        private void AdicionarResponsavel(ItemVendaInfo item)
        {
            ItemVendaColecao vendnova = new ItemVendaColecao();
            vendnova.Add(item);

            for (int i = 0; i < itemVendaColecao.Count; i++)
                vendnova.Add(itemVendaColecao[i]);

            itemVendaColecao = vendnova;
            AdicionarItemProd();
        }

        private void AdicionarItemProd()
        {
            dataGridViewItens.DataSource = null;
            dataGridViewItens.DataSource = itemVendaColecao;
            dataGridViewItens.ClearSelection();
            serializarNegocios.SerializarObjeto(itemVendaColecao, FileName);

            foreach (DataGridViewRow row in dataGridViewItens.Rows)
                row.Cells["colItem"].Value = string.Format("{0:00}", row.Index + 1);


            ExecutarContagem();
        }

        private void TipoVenda()
        {
            FormVendaVip formVendaVip = new FormVendaVip();
            formVendaVip.ShowDialog();

            if (formVendaVip.DialogResult == DialogResult.Yes)
            {
                VendaVip = true;
                BuscarCliente();
            }
            else if (formVendaVip.DialogResult == DialogResult.OK)
            {
                ClienteNegocios clienteNegocios = new ClienteNegocios(Form1.Empresa.empconexao);
                clienteInfo = clienteNegocios.ConsultarClientePadrao();
                labelCliente.Text = "Cliente: " + clienteInfo.Nome;
                AtivarForm(true);
                VendaVip = false;
            }

            formVendaVip.Dispose();
        }

        private void ConsultarProduto()
        {
            string barras = textBoxBarras.Text;

            if (!string.IsNullOrEmpty(barras))
            {
                string codBarras = textBoxBarras.Text.Substring(0, 1);

                switch (codBarras)
                {
                    case "*":
                        decimal db = Convert.ToDecimal(barras.Substring(1, barras.Length - 1));
                        textBoxQuant.Text = string.Format("{0:0.000}", db);
                        textBoxBarras.Clear();
                        return;

                    case "-":
                        barras = barras.Replace("-", "");
                        break;
                    case "+":
                        barras = barras.Replace("+", "");
                        break;

                    default:
                        break;
                }

                ProdutoInfo produtosInfo = produtoNegocios.ConsultarProdutoCodBarras(barras);

                if (produtosInfo != null)
                    PreencherFormProduto(produtosInfo);
                else
                    FormMessage.ShowMessegeWarning("Produto não encontrado!");
            }
            else
                FormMessage.ShowMessegeWarning("Insira um código de barras!");
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewItens.ColumnCount; i++)
                dataGridViewItens.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
        }

        private void buttonDesconto_Click(object sender, EventArgs e)
        {
            AddDesconto();
        }

        private void AddDesconto()
        {
            if (dataGridViewItens.SelectedRows.Count > 0)
            {
                ProdutoInfo produto = produtoNegocios.ConsultarProdutosId(itemSelecionando.Id);
                FormProdDesconto formProdDesconto = new FormProdDesconto(produto);
                formProdDesconto.ShowDialog();

                if (formProdDesconto.DialogResult == DialogResult.Yes)
                {

                    for (int i = 0; i < itemVendaColecao.Count; i++)
                    {
                        if (itemSelecionando.Id == itemVendaColecao[i].Id)
                        {
                            itemSelecionando.ValorDesc = Convert.ToDecimal(formProdDesconto.valor[1]);
                            itemSelecionando.Total = itemSelecionando.ValorDesc * itemSelecionando.Quant;
                            itemVendaColecao.RemoveAt(i);
                        }
                    }

                    ItemVendaColecao vendColecao = new ItemVendaColecao
                    {
                        itemSelecionando
                    };

                    for (int i = 0; i < itemVendaColecao.Count; i++)
                        vendColecao.Add(itemVendaColecao[i]);

                    itemVendaColecao = vendColecao;
                    AdicionarItemProd();
                }

                formProdDesconto.Dispose();
            }
            else
                FormMessage.ShowMessegeWarning("Selecione o produto que deseja aplicar o desconto!");
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            TipoVenda();
        }

        private void AtivarForm(bool ativar)
        {
            textBoxQuant.Enabled = ativar;
            textBoxBarras.Enabled = ativar;
            buttonResponsavel.Enabled = ativar;
            buttonProd.Enabled = ativar;
            buttonDesconto.Enabled = ativar;
            VendaAtiva = ativar;
            textBoxBarras.Select();
            funcInfo = funcNegocios.ConsultarFuncPorId(Form1.User.useidfuncionario);
            labelVendedor.Text = "Vendedor: " + funcInfo.funNome;

        }

        private void CriarFuncoes(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    TipoVenda();
                    break;
                default:
                    if (VendaAtiva)
                    {
                        switch (e.KeyCode)
                        {
                            case Keys.F2:
                                BuscarVendedor();
                                break;
                            case Keys.F3:
                                FormProdutosConsultar formProdutosConsultar = new FormProdutosConsultar(ProdEnum.Venda);
                                formProdutosConsultar.ShowDialog();

                                if (formProdutosConsultar.DialogResult == DialogResult.Yes)
                                    PreencherFormProduto(formProdutosConsultar.Produtos);

                                formProdutosConsultar.Dispose();

                                break;
                            case Keys.F4:
                                AddDesconto();
                                break;
                            case Keys.F6:
                                textBoxQuant.Select();
                                break;
                            case Keys.F7:
                                textBoxBarras.Select();
                                break;
                            case Keys.F12:

                                if (!(dataGridViewItens.Rows.Count > 0))
                                {
                                    FormMessage.ShowMessegeWarning("Nenhum item foi lançado!");
                                    return;
                                }

                                InserirVenda();
                                break;
                            default:
                                break;
                        }
                    }
                    break;
            }
        }

        private void ConcluirVenda()
        {
            foreach (ItemVendaInfo item in itemVendaColecao)
            {
                //dar baixa no estoque
                ProdutoInfo produtoInfo = produtoNegocios.ConsultarProdutosId(item.Id);

                if (produtoInfo.proControleEstoque == 1)
                {
                    produtoInfo = new ProdutoInfo();
                    produtoInfo = produtoNegocios.ConsultarEstoqueIdProdutoUnid(item.Id, Form1.Unidade.uniid);
                    produtoInfo.prodestoquequant = -item.Quant;

                    if (produtoNegocios.UpdateEstoqueId(produtoInfo) == 0)
                    {
                        FormMessage.ShowMessegeWarning("Falha ao salvar os itens!");
                        return;
                    }

                    MovEstoqueInfo movEstoqueInfo = new MovEstoqueInfo
                    {
                        movestoqueidproduto = item.Id,
                        movestoqueidtipomovimento = vendaInfo.venidtipoentrada,
                        movestoquequant = item.Quant,
                        movestoquevalor = item.ValorDesc
                    };

                    if (!produtoNegocios.InsertMovEstoque(movEstoqueInfo))
                    {
                        FormMessage.ShowMessegeWarning("Falha ao salvar os itens!");
                        return;
                    }
                }

            }

            AtivarForm(false);
            buttonConcluir.Enabled = false;
            buttonCliente.Enabled = false;
            buttonRemover.Enabled = false;
            dataGridViewItens.Enabled = false;
            VendaEncerrada = true;
        }

        private void BuscarCliente()
        {
            if (VendaVip)
            {
                FormClienteConsultar formClienteConsultar = new FormClienteConsultar(true);
                formClienteConsultar.ShowDialog();
                clienteInfo =  new ClienteInfo();

                if (formClienteConsultar.DialogResult == DialogResult.Yes)
                {
                    clienteInfo = formClienteConsultar.Cliente;
                    labelCliente.Text = "Cliente: " + clienteInfo.Nome;
                    AtivarForm(true);
                }

                formClienteConsultar.Dispose();
            }
        }

        private void buttonConcluir_Click(object sender, EventArgs e)
        {
            if (InserirVenda() > 0)
            {
                labelOperacao.Text += " " + string.Format("{0:000000}", vendaInfo.venid);
                FormPagamento formPagamento = new FormPagamento(vendaInfo);
                formPagamento.ShowDialog(this);

                if (formPagamento.DialogResult == DialogResult.Yes)
                {
                    ConcluirVenda();
                    //FormMessage.ShowMessegeInfo("Venda concluída com sucesso!");
                    FormCupom formCupom = new FormCupom(vendaInfo.venid);
                    formCupom.ShowDialog(this);
                }
            }
            else
                FormMessage.ShowMessegeWarning("Falha ao tentar concluir venda, tente novamente!");
        }

        private void textBoxBarras_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonProd_Click(object sender, EventArgs e)
        {

            FormProdutosConsultar formProdutosConsultar = new FormProdutosConsultar( ProdEnum.Venda);
            formProdutosConsultar.ShowDialog();

            if (formProdutosConsultar.DialogResult == DialogResult.Yes)
                PreencherFormProduto(formProdutosConsultar.Produtos);

            formProdutosConsultar.Dispose();
        }

        private void labelOperacao_Click(object sender, EventArgs e)
        {

        }

        private void buttonVendedor_Click(object sender, EventArgs e)
        {
            BuscarVendedor();
        }

        private void BuscarVendedor()
        {
            if (dataGridViewItens.SelectedRows.Count > 0)
            {
                Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();
                FuncColecao funcColecao = new FuncColecao();
                funcColecao = funcNegocios.ConsultatFuncTotal();

                foreach (FuncInfo func in funcColecao)
                {
                    Form_Consultar form_Consultar = new Form_Consultar
                    {
                        Cod = string.Format("{0:000}", func.funId),
                        Descricao = func.funNome
                    };

                    form_ConsultarColecao.Add(form_Consultar);
                }

                FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, "Funcionário");
                formConsultar_Cod_Descricao.ShowDialog();

                if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
                    responsavel = funcNegocios.ConsultarFuncPorId(Convert.ToInt32(formConsultar_Cod_Descricao.Selecionado.Cod));

                MudarResponsavel();

                formConsultar_Cod_Descricao.Dispose();
            }
            else
                FormMessage.ShowMessegeWarning("Selecione o item que deseja alterar o responsável!");
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            if (VendaEncerrada)
                this.Close();
            else
            {
                if (FormMessage.ShowMessegeQuestion("Deseja cancelar está venda?") == DialogResult.Yes)
                    this.Close();
            }
        }

        private void DefinirResponsavel(FuncInfo func)
        {

        }

        private void dataGridViewItens_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewItens.SelectedRows.Count > 0)
                itemSelecionando = (ItemVendaInfo)dataGridViewItens.SelectedRows[0].DataBoundItem;
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewItens.SelectedRows.Count > 0)
            {
                for (int i = 0; i < itemVendaColecao.Count; i++)
                {
                    if (itemSelecionando.Id == itemVendaColecao[i].Id)
                    {
                        itemVendaColecao.RemoveAt(i);
                        AdicionarItemProd();
                    }
                }

                textBoxBarras.Select();
            }
            else
                FormMessage.ShowMessegeWarning("Selecione o produto que deseja excluir!");
        }

        private void textBoxQuant_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.Format3casasdecimais((TextBox)sender);
        }
    }
}

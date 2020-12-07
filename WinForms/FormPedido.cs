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
    public partial class FormPedido : Form
    {
        GridPedidoColecao colecaoGridPedido;
        ProdutoEstoqueInfo infoEstoque;
        ProdEletroInfo infoEletro;
        ProdutoInfo infoProd;
        ServicoInfo infoServ;
        ClienteInfo infoCliente;
        PedidoInfo infoPedido;

        ProdutoNegocios produtoNegocios = new ProdutoNegocios(Form1.Empresa.empconexao);
        ServicoNegocio servicoNegocio = new ServicoNegocio(Form1.Empresa.empconexao);
        ClienteNegocios clienteNegocios = new ClienteNegocios(Form1.Empresa.empconexao);
        PedidoNegocios pedidoNegocios = new PedidoNegocios(Form1.Empresa.empconexao);
        EstoqueNegocios estoqueNegocios = new EstoqueNegocios(Form1.Empresa.empconexao);
        private string FileName { get { return "est_ped.lvt"; } }

        //int textprodutocod = 0;
        int textquant = 0;
        int texos = 0;

        public FormPedido()
        {
            Inicialize();
        }

        private void Inicialize()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            textBoxProdutoCod.LostFocus += new EventHandler(textBoxProdutoCod_LostFocus);
        }

        public FormPedido(PedidoInfo pedidoInfo)
        {
            Inicialize();
            BuscarPedido(pedidoInfo);
            buttonConfirmar.Enabled = false;
            labelStatusDescricao.Text = pedidoInfo.status;

            switch (pedidoInfo.pedidoidstatus)
            {
                case 1:
                    labelStatusDescricao.ForeColor = Color.Blue;
                    break;
                case 2:
                    labelStatusDescricao.ForeColor = Color.Green;
                    break;
                case 3:
                    labelStatusDescricao.ForeColor = Color.Yellow;
                    break;
                case 4:
                    labelStatusDescricao.ForeColor = Color.Red;
                    break;
                default:
                    break;
            }
        }

        private void BuscarPedido(PedidoInfo pedidoInfo)
        {
            labelPedidoCod.Text = pedidoInfo.pedidocod;
            labelDataPedido.Text = pedidoInfo.pedidodata.ToLongDateString();
            groupBoxOs.Enabled = false;
            BuscarServico(pedidoInfo.pedidoidserv);

            PedidoDetalhesColecao pedidoDetalhesColecao = pedidoNegocios.ConsultarPedidoDetalhesPedId(pedidoInfo.pedidoid);

            if (pedidoDetalhesColecao != null)
            {
                foreach (PedidoDetalhesInfo pedido in pedidoDetalhesColecao)
                {
                    GridPedidoInfo gridPedidoInfo = new GridPedidoInfo
                    {
                        cod = pedido.peddetalhesid,
                        descricao = produtoNegocios.ConsultarProdutosId(pedido.peddetalhesidprod).proDescricao,
                        quant = pedido.peddetalhesquant,
                        valorDesc = pedido.peddetalhesvalordesc,
                        valorTotal = pedido.peddetalhesvalordesc * pedido.peddetalhesquant,
                        valorUnit = pedido.peddetalhesvalorunit
                    };

                    colecaoGridPedido.Add(gridPedidoInfo);
                }

                PreencherGridPedido();
            }
            
        }

        private void buttonDesconto_Click(object sender, EventArgs e)
        {
            FormProdDesconto formProdDesconto = new FormProdDesconto(infoProd.proValorVarejo, infoProd.proDescricao);
            formProdDesconto.ShowDialog(this);

            if (formProdDesconto.DialogResult == DialogResult.Yes)
                labelValorDesc.Text = formProdDesconto.valorFinal[1];

            formProdDesconto.Dispose();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOsBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxOsCod.Text, out int cod))
            {
                BuscarServico(cod);
            }
            else
            {
                FormMessage.ShowMessegeWarning("Insira um código válido!");
                textBoxOsCod.Select();
            }
        }

        private void BuscarServico(int cod)
        {
            infoServ = servicoNegocio.ConsultarServicoPorOs(cod);

            if (infoServ != null)
            {
                infoCliente = clienteNegocios.ConsultarClientePorId(infoServ.seridcliente);
                infoEletro = servicoNegocio.ConsultarEletroId(infoServ.serideletro);
                infoPedido = new PedidoInfo
                {
                    pedidodata = DateTime.Now,
                    pedidoidfunc = Form1.User.useidfuncionario,
                    pedidoidserv = infoServ.serid,
                    pedidoidunid = Form1.Unidade.uniid,
                    pedidoidstatus = 1
                };

                labelDataPedido.Text = infoPedido.pedidodata.ToLongDateString();
                PreencherFormOs();
                buttonLancar.Select();
            }
        }
        private void PreencherFormOs()
        {
            textBoxOsCod.Text = string.Format("{0:000000}", infoServ.serid);
            labelDataAgend.Text = infoServ.serdataagend.ToLongDateString();
            labelClienteNome.Text = infoCliente.clinome;
            labelProdEletroCod.Text = string.Format("{0:000}", infoEletro.idCadEle);
            labelProdEletroDescricao.Text = infoEletro.descricao;
            AtivarCampos();
        }

        private void AtivarCampos(bool ativ = true)
        {
            buttonClienteBuscar.Enabled = ativ;
            buttonEletroBuscar.Enabled = ativ;
            buttonLancar.Enabled = ativ;

            if (!ativ)
            {
                labelDataAgend.Text = "";
                labelClienteNome.Text = "";
                labelProdEletroCod.Text = "";
                labelProdEletroDescricao.Text = "";
            }
        }

        private void textBoxOsCod_TextChanged(object sender, EventArgs e)
        {
            AtivarCampos(false);
        }

        private void buttonLancar_Click(object sender, EventArgs e)
        {
            groupBoxOs.Enabled = false;
            groupBoxItem.Enabled = true;
            textBoxProdutoCod.Select();
        }

        private void buttonClienteBuscar_Click(object sender, EventArgs e)
        {
            FormServicoConsultar formServicoConsultar = new FormServicoConsultar(infoServ.serid);
            formServicoConsultar.ShowDialog(this);
            formServicoConsultar.Dispose();
        }

        private void buttonEletroBuscar_Click(object sender, EventArgs e)
        {
            FormCadEletro formCadEletro = new FormCadEletro(infoCliente);
            formCadEletro.ShowDialog(this);
            formCadEletro.Dispose();
        }

        private void buttonProdutoBuscar_Click(object sender, EventArgs e)
        {
            FormProdutosConsultar formProdutosConsultar = new FormProdutosConsultar(ProdEnum.Pedido);
            formProdutosConsultar.ShowDialog(this);

            if (formProdutosConsultar.DialogResult == DialogResult.Yes)
            {
                infoProd = formProdutosConsultar.Produtos;
                PreencherFormProduto();
            }

            formProdutosConsultar.Dispose();
        }

        private void PreencherFormProduto()
        {
            infoEstoque = estoqueNegocios.ConsultarEstoqueIdProdutoUnid(infoProd.proId, Form1.Unidade.uniid);
            textBoxProdutoCod.Text = string.Format("{0:000}", infoProd.proId);
            labelProdutoDescricao.Text = infoProd.proDescricao;
            labelValorUnit.Text = string.Format("{0:C}", infoProd.proValorVarejo);
            labelValorDesc.Text = string.Format("{0:C}", infoProd.proValorVarejo);
            textquant = 1;

            if (infoEstoque != null)
                labelQuantEstoque.Text = string.Format("{0:000}", infoEstoque.prodestoquequant);
            else
                labelQuantEstoque.Text = "000";

            AoAlterar_textBoxProdutoCod(true);

            textBoxQuant.Select();
        }

        private void buttonProdutoAdd_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos(ProdEnum.Pedido);
            formProdutos.ShowDialog(this);
            formProdutos.Dispose();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (textquant > 0)
            {
                decimal desc = Convert.ToDecimal(labelValorDesc.Text.Replace("R$ ", ""));

                GridPedidoInfo gridPedidoInfo = new GridPedidoInfo
                {
                    cod = infoProd.proId,
                    descricao = infoProd.proDescricao,
                    quant = textquant,
                    valorDesc = desc,
                    valorUnit = infoProd.proValorVarejo,
                    valorTotal = textquant * desc
                };

                if (dataGridViewPedido.Rows.Count > 0)
                {
                    for (int i = 0; i < colecaoGridPedido.Count; i++)
                    {
                        if (gridPedidoInfo.cod == colecaoGridPedido[i].cod)
                        {
                            gridPedidoInfo.quant += colecaoGridPedido[i].quant;
                            gridPedidoInfo.valorTotal = colecaoGridPedido[i].valorDesc * gridPedidoInfo.quant;
                            colecaoGridPedido.RemoveAt(i);
                        }
                    }
                }

                colecaoGridPedido.Add(gridPedidoInfo);
                textBoxProdutoCod.Clear();
                textBoxProdutoCod.Select();
                AoAlterar_textBoxProdutoCod();
                PreencherGridPedido();
            }
            else
            {
                FormMessage.ShowMessegeWarning("Informe a quantidade!");
                textBoxQuant.Select();
            }
        }

        private void PreencherGridPedido()
        {
            dataGridViewPedido.DataSource = null;
            dataGridViewPedido.DataSource = colecaoGridPedido;
            ContarItens();
            dataGridViewPedido.ClearSelection();
        }

        private void ContarItens()
        {
            decimal total = 0;
            decimal quant = 0;

            foreach (GridPedidoInfo grid in colecaoGridPedido)
            {
                total += grid.valorTotal;
                quant += grid.quant;
            }

            labelItensDescricao.Text = string.Format("{0:000}", quant);
            labelTotalDescricao.Text = string.Format("{0:C}", total);
        }

        private void textBoxProdutoCod_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBoxProdutoCod_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxProdutoCod.Text))
            {
                ConsultarProduto(ConvertNum(textBoxProdutoCod));
            }
        }
        private void ConsultarProduto(int id)
        {
            infoProd = produtoNegocios.ConsultarProdutosId(id);

            if (infoProd != null)
                PreencherFormProduto();
            else
            {
                FormMessage.ShowMessegeWarning("Insira um código válido!");
                textBoxProdutoCod.Clear();
                textBoxProdutoCod.Select();
            }
        }

        private int ConvertNum(TextBox text)
        {
            if (!string.IsNullOrEmpty(text.Text))
            {
                if (int.TryParse(text.Text, out int cod))
                    return cod;
                else
                {
                    text.Clear();
                    text.Select();
                    return 0;
                }
            }
            else
                return 0;
        }

        private void textBoxQuant_Leave(object sender, EventArgs e)
        {
            textquant = ConvertNum(textBoxQuant);
        }

        private void textBoxOsCod_Leave(object sender, EventArgs e)
        {
            texos = ConvertNum(textBoxOsCod);
        }

        private void textBoxProdutoCod_TextChanged(object sender, EventArgs e)
        {
            AoAlterar_textBoxProdutoCod();
        }

        private void AoAlterar_textBoxProdutoCod(bool change = false)
        {
            textBoxQuant.Enabled = change;
            buttonAddItem.Enabled = change;
            buttonDesconto.Enabled = change;
            buttonProdutoInfo.Enabled = change;
            buttonRemover.Enabled = !change;

            if (!change)
            {
                textBoxQuant.Text = "1";
                labelProdutoDescricao.Text = "";
                labelValorDesc.Text = "";
                labelValorUnit.Text = "";
                labelQuantEstoque.Text = "";
            }
        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewPedido.ColumnCount; i++)
                dataGridViewPedido.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
        }

        private void buttonProdutoInfo_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos(infoProd.proId);
            formProdutos.ShowDialog(this);

            if (formProdutos.DialogResult == DialogResult.Yes)
                ConsultarProduto(infoProd.proId);

            formProdutos.Dispose();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewPedido.SelectedRows.Count > 0)
            {
                GridPedidoInfo gridPedidoInfo = (GridPedidoInfo)dataGridViewPedido.SelectedRows[0].DataBoundItem;

                for (int i = 0; i < colecaoGridPedido.Count; i++)
                    if (gridPedidoInfo.cod == colecaoGridPedido[i].cod)
                        colecaoGridPedido.RemoveAt(i);

                dataGridViewPedido.DataSource = null;
                dataGridViewPedido.DataSource = colecaoGridPedido;

                ContarItens();
                textBoxProdutoCod.Select();
            }
            else
                FormMessage.ShowMessegeWarning("Selecione o item que deseja remover!");
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            infoPedido.pedidototalitem = Convert.ToInt32(labelItensDescricao.Text);
            infoPedido.pedidototalvalor = Convert.ToDecimal(labelTotalDescricao.Text.Replace("R$ ", ""));
            int id = pedidoNegocios.InsertPedido(infoPedido);
            if (id > 0)
            {
                string cod = "PE" + string.Format("{0:000000}", id);
                labelPedidoCod.Text = cod;
                bool salvo = false;

                if (pedidoNegocios.UpdatePedidoCod(id, cod) > 0)
                {
                    PedidoDetalhesColecao pedidoDetalhesColecao = new PedidoDetalhesColecao();
                    foreach (GridPedidoInfo pedido in colecaoGridPedido)
                    {
                        PedidoDetalhesInfo pedidoDetalhesInfo = new PedidoDetalhesInfo
                        {
                            peddetalhesidprod = pedido.cod,
                            peddetalhesquant = pedido.quant,
                            peddetalhesvalordesc = pedido.valorDesc,
                            peddetalhesvalorunit = pedido.valorUnit,
                            peddetalhesidpedido = id
                        };

                        if (pedidoNegocios.InsertPedidoDetalhes(pedidoDetalhesInfo))
                            salvo = true;
                        else
                        {
                            salvo = false;
                            break;
                        }

                    }

                    if (salvo)
                    {
                        FormMessage.ShowMessegeInfo("Salvo com sucesso!");
                        buttonConfirmar.Enabled = false;
                        buttonRemover.Enabled = false;
                        groupBoxItem.Enabled = false;
                    }
                    else
                        FormMessage.ShowMessegeWarning("Falha ao salvar!");
                }
            }
        }
    }
}

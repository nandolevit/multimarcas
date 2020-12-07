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
    public partial class FormServicoConsultar : Form
    {
        Thread thread;
        Form1 form1 = new Form1();

        ServicoObsTecColecao servicoObsTecColecao;
        ServicoOrcamentoColecao orcamentoColecao;
        ProdutoEstoqueInfo produtoEstoqueInfo;
        ServicoOrcamentoInfo servicoOrcamento;
        GridPedidoColecao gridPedidoColecao;
        VendaDetalhesColecao colecaoDetalhes;
        ProdEletroInfo infoEletro;
        ClienteInfo infoCliente;
        ServicoInfo infoServ;
        ProdutoInfo produtoInfo;
        VendaInfo vendaInfo;
        ServicoInfo servicoAlter;
        FuncInfo responsavel;
        ProdutoInfo taxa;
        EnderecoInfo infoEnd;
        CepInfo infoCep;
        NotaColecao colecaoNota;
        NotaInfo infoNota;
        Caixa caixa;
        CaixaTurnoInfo infoTurno;

        ProdutoNegocios negocioProduto = new ProdutoNegocios(Form1.Empresa.empconexao);
        EstoqueNegocios negocioEstoque = new EstoqueNegocios(Form1.Empresa.empconexao);
        ClienteNegocios negocioCliente = new ClienteNegocios(Form1.Empresa.empconexao);
        ServicoNegocio negocioServ = new ServicoNegocio(Form1.Empresa.empconexao);
        VendaNegocios negocioVenda = new VendaNegocios(Form1.Empresa.empconexao);
        FuncNegocios negocioFunc = new FuncNegocios(Form1.Empresa.empconexao);

        bool alter; //caso o usuário tenha feito alguma alteração
        int textquant = 0;
        decimal total = 0;
        decimal quant = 0;
        string resp, status, addAlteracao, defeito, observacao, data, ntaxa, chamado, nomefun, obstec;

        private int IdentOs { get; set; }

        public FormServicoConsultar()
        {
            Inicializar();

            if (textBoxOs.ReadOnly)
                textBoxObsTec.Select();
            else
                textBoxOs.Select();

        }

        public FormServicoConsultar(int os)
        {
            Inicializar();
            IdentOs = os;
            BuscarServico();
        }

        private void Inicializar()
        {
            gridPedidoColecao = new GridPedidoColecao();
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            FormatDataGrid();
            textBoxObsTec.MaxLength = 32767;
        }

        private void BuscarServico()
        {
            thread = new Thread(BuscarServicoThread);
            form1.ExecutarThread(thread);
            this.Activate();
            if (infoServ != null)
            {
                FormatDataGrid();
                PreencherForm();
                PreencherGridPedido();
                PreecherGidObs();
                textBoxObsTec.Select();
                textBoxOs.Enabled = false;
                buttonBuscarCliente.Enabled = true;
            }
            else
            {
                FormMessage.ShowMessegeWarning("Ordem de Serviço não inexistente, tente outra!");
                textBoxOs.Clear();
                textBoxOs.Select();
            }
        }

        private void BuscarServicoThread()
        {
            infoServ = negocioServ.ConsultarServicoPorOs(IdentOs);

            if (infoServ != null)
            {
                nomefun = negocioFunc.ConsultarFuncPorId(infoServ.seridtecresp).funNome;

                if (Form1.Offline == false)
                {
                    orcamentoColecao = negocioServ.ConsultarServicoOrcamento(infoServ.serid);
                    servicoObsTecColecao = negocioServ.ConsultarObsTecPorIdOs(infoServ.serid);

                    if (orcamentoColecao != null)
                        PreencherOrcamento();
                }
                else
                {
                    tabControlPrincipal.TabPages.RemoveAt(1);
                    tabControlPrincipal.TabPages.RemoveAt(1);
                    buttonTaxa.Visible = false;
                    buttonAddProduto.Visible = false;
                    buttonAddTec.Visible = false;
                    buttonSalvar.Enabled = false;
                }

                PreencherFormThread();
            }

            Form1.encerrarThread = true;
        }

        private void FormatDataGrid()
        {
            dataGridViewObsTec.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewObsTec.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //dataGridViewObsTec.Columns["colFuncCad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            //dataGridViewObsTec.Columns["colObsTec"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            //dataGridViewObsTec.Columns["colLancado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dataGridViewObsTec.ClearSelection();
        }

        private void PreencherFormThread()
        {
            infoEnd = negocioCliente.ConsultarEnderecoPorIdEnd(infoServ.seridend);
            infoCep = negocioCliente.ConsultarCep(infoEnd.Cep);
            infoCliente = negocioCliente.ConsultarClientePorId(infoServ.seridcliente);
            infoEletro = negocioServ.ConsultarEletroId(infoServ.serideletro);
        }
        private void PreencherForm()
        {
            textBoxOs.Text = string.Format("{0:000000000}", infoServ.serid);
            textBoxAgend.Text = infoServ.serdataagend.ToString("ddd, dd/MM/yy");
            textBoxCliente.Text = infoCliente.clinome;
            textBoxEnd.Text = ConsultarIdEnd();
            textBoxDefeito.Text = infoServ.serdefeitodescricao;
            textBoxObs.Text = infoServ.serobs;
            textBoxTaxa.Text = String.Format("{0:C2}", infoServ.sertaxa);
            textBoxDescricao.Text = infoServ.serdescricao;
            textBoxCodStatus.Text = string.Format("{0:000}", infoServ.seridstatus);
            textBoxStatus.Text = infoServ.serstatusdescricao;
            textBoxCodTec.Text = string.Format("{0:000}", infoServ.seridtecresp);
            textBoxResponsavel.Text = nomefun;
            textBoxChamado.Text = infoEletro.cadelechamado;

            resp = textBoxResponsavel.Text;
            status = textBoxStatus.Text;
            defeito = textBoxDefeito.Text;
            observacao = textBoxObs.Text;
            data = textBoxAgend.Text;
            ntaxa = textBoxTaxa.Text;
            chamado = textBoxChamado.Text;


            TimeSpan timeSpan = new TimeSpan();
            timeSpan = DateTime.Now.Date.Subtract(infoServ.serdataagend);
            textBoxQuant.Text = timeSpan.Days.ToString("000");
            timeSpan = new TimeSpan();
            timeSpan = DateTime.Now.Date.Subtract(infoServ.serdatafinalizada);
            int dias = 90 - timeSpan.Days;
            labelPrazos.Text = dias > 0 ? dias + " dias restão." : -dias + " dias fora da garantia.";

            labelUserCad.Text = "Cadastrada Por: " + infoServ.sernomefunc;
            labelDataCad.Text = "Aberta em: " + infoServ.serdatacad;


            if (orcamentoColecao != null)
                foreach (ServicoOrcamentoInfo orc in orcamentoColecao)
                    if (orc.servicoorcamentotaxaativo == true)
                        buttonTaxa.Enabled = false;

            if (infoServ.seridstatus == 2)
            {
                BloquearForm();
            }
            else
            {
                textBoxObsTec.ReadOnly = false;
                buttonAddObs.Enabled = true;
                buttonImprimir.Enabled = true;
            }

            if (infoServ.sergarantia == true)
            {
                buttonTaxa.Enabled = false;
                buttonNota.Visible = true;
                textBoxChamado.Visible = true;
                labelChamado.Visible = true;
                this.Text = " [OS " + string.Format("{0:00000}", infoServ.serid) + " GARANTIA]";
                labelTitle.Text = " [OS " + string.Format("{0:00000}", infoServ.serid) + " GARANTIA]";
            }
            else
            {
                this.Text = " [OS " + string.Format("{0:00000}", infoServ.serid) + " PARTICULAR]";
                labelTitle.Text = " [OS " + string.Format("{0:00000}", infoServ.serid) + " PARTICULAR]";
            }

            if (infoServ.servendaconfirm == true)
            {
                buttonProdutoBuscar.Enabled = false;
                buttonProdutoAdd.Enabled = false;
                textBoxProdutoCod.Enabled = false;
                buttonAddItem.Enabled = false;
                labelFinalizada.Visible = true;
                dataGridViewPedido.Enabled = false;
                buttonVenda.Enabled = false;
                buttonConfirmar.Enabled = false;
            }
        }

        private string ConsultarIdEnd()
        {

            string End = string.Empty;
            string endComp = string.Empty;


            if (infoCep != null)
                endComp = infoCep.Logradouro + ", " + infoCep.Bairro + ", " + infoCep.Cidade + "/" + infoCep.Uf;

            End = "End.: " + infoEnd.Complemento + ", Ponto de Ref.: " + infoEnd.PontoReferencia;
            End += Environment.NewLine + string.Format(@"{0:00\.000\-000}", Convert.ToInt32(infoEnd.Cep)) + ", " + endComp;

            return End;
        }

        private void buttonAddObs_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxObsTec.Text.Trim()))
            {
                obstec = textBoxObsTec.Text.Trim();

                thread = new Thread(NovaObsTec);
                form1.ExecutarThread(thread);
                this.Activate();
                PreecherGidObs();
            }
            else
            {
                textBoxObsTec.Clear();
                textBoxObsTec.Select();
            }
        }

        private void NovaObsTec()
        {
            ServicoObsTecInfo servicoObsTecInfo = new ServicoObsTecInfo
            {
                IdOs = infoServ.serid,
                ObsTec = obstec,
                IdFunc = Form1.User.useidfuncionario
            };

            negocioServ.InserirObsTec(servicoObsTecInfo);
            servicoObsTecColecao = negocioServ.ConsultarObsTecPorIdOs(infoServ.serid);

            Form1.encerrarThread = true;  
        }

        private void PreecherGidObs()
        {
            dataGridViewObsTec.DataSource = null;
            dataGridViewObsTec.DataSource = servicoObsTecColecao;
            dataGridViewObsTec.ClearSelection();
            textBoxObsTec.Clear();
            textBoxObsTec.Select();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            FormCadastroPessoa formCadastroPessoa = new FormCadastroPessoa(infoCliente);
            formCadastroPessoa.ShowDialog();
            formCadastroPessoa.Dispose();

            if (formCadastroPessoa.DialogResult == DialogResult.Yes)
                BuscarServico();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRelatorioFicha formRelatorioFicha = new FormRelatorioFicha(infoServ);
            formRelatorioFicha.ShowDialog(this);
            formRelatorioFicha.Dispose();
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            FormRelatorioFicha formRelatorioFicha = new FormRelatorioFicha(infoServ);
            formRelatorioFicha.Show(this);
        }

        private void BloquearForm()
        {
            textBoxOs.ReadOnly = true;
            groupBoxItem.Enabled = false;
            buttonAddItem.Enabled = false;
            textBoxObsTec.Enabled = false;
            buttonConfirmar.Enabled = false;
            buttonVenda.Enabled = false;
            buttonEncerrar.Enabled = false;
            buttonImprimir.Enabled = true;
            textBoxCodStatus.Enabled = false;
            textBoxCodTec.Enabled = false;
            buttonAddItem.Enabled = false;
            buttonBuscarStatus.Enabled = false;
            buttonAddTec.Enabled = false;
            buttonBuscarTec.Enabled = false;
            buttonTaxa.Enabled = false;
            labelPrazo.Visible = true;
            labelPrazos.Visible = true;
            buttonSalvar.Enabled = false;
            textBoxDefeito.ReadOnly = true;
            textBoxObs.ReadOnly = true;
            buttonProd.Enabled = false;
        }

        private void buttonOsBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxOs.Text.Trim()))
            {
                if (int.TryParse(textBoxOs.Text, out int cod))
                {
                    IdentOs = cod;
                    BuscarServico();
                }
                else
                {
                    FormMessage.ShowMessegeWarning("Digite um valor numérico e tente novamente!");
                    textBoxOs.Clear();
                    textBoxOs.Select();
                }
            }
            else
                FormMessage.ShowMessegeInfo("Digite a Ordem de Serviço e clique em Buscar!");
        }

        private void PreencherOrcamento()
        {
            if (orcamentoColecao != null)
            {
                gridPedidoColecao = new GridPedidoColecao();
                foreach (ServicoOrcamentoInfo orc in orcamentoColecao)
                {
                    decimal descont = orc.servicoorcamentotaxaativo ? -orc.servicoorcamentovalordesc : orc.servicoorcamentovalordesc;

                    ProdutoInfo prodTaxa = negocioProduto.ConsultarProdutosId(orc.servicoorcamentoidprod);

                    GridPedidoInfo grid = new GridPedidoInfo
                    {
                        cod = orc.servicoorcamentoidprod,
                        descricao = prodTaxa.proDescricao,
                        quant = orc.servicoorcamentoquant,
                        valorDesc = descont,
                        valorTotal = descont * orc.servicoorcamentoquant,
                        valorUnit =  orc.servicoorcamentovalorunit
                    };

                    gridPedidoColecao.Add(grid);
                }
            }
        }

        private void PreencherGridPedido()
        {
            if (gridPedidoColecao != null)
            {
                if (gridPedidoColecao.Count > 0)
                {
                    dataGridViewPedido.DataSource = null;
                    dataGridViewPedido.DataSource = gridPedidoColecao;
                    ContarItens();
                    dataGridViewPedido.ClearSelection();

                    if (total > 0 && infoServ.servendaconfirm == false)
                        buttonVenda.Enabled = true;

                    buttonRemover.Enabled = true;
                }
                else
                    buttonVenda.Enabled = false;
            }
        }

        private void AoAlterar_textBoxProdutoCod(bool change = false)
        {
            textBoxQuantPedido.Enabled = change;
            buttonAddItem.Enabled = change;
            buttonDesconto.Enabled = change;
            buttonProdutoInfo.Enabled = change;
            buttonRemover.Enabled = !change;

            if (!change)
            {
                textBoxQuantPedido.Text = "1";
                labelProdutoDescricao.Text = "";
                labelValorDesc.Text = "";
                labelValorUnit.Text = "";
                labelQuantEstoque.Text = "";
            }

        }

        private void textBoxProdutoCod_TextChanged(object sender, EventArgs e)
        {
            AoAlterar_textBoxProdutoCod();
        }

        private void buttonProdutoBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxProdutoCod.Text))
            {
                ConsultarProduto(ConvertNum(textBoxProdutoCod));
            }
            else
            {
                FormProdutosConsultar formProdutosConsultar = new FormProdutosConsultar(ProdEnum.Pedido);
                formProdutosConsultar.ShowDialog(this);

                if (formProdutosConsultar.DialogResult == DialogResult.Yes)
                {
                    produtoInfo = formProdutosConsultar.Produtos;
                    PreencherFormProduto();
                }

                formProdutosConsultar.Dispose();
            }
        }

        private void buttonProdutoAdd_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos(ProdEnum.Pedido);
            formProdutos.ShowDialog(this);
            formProdutos.Dispose();
        }

        private void PreencherFormProduto()
        {
            produtoEstoqueInfo = negocioEstoque.ConsultarEstoqueIdProdutoUnid(produtoInfo.proId, Form1.Unidade.uniid);
            textBoxProdutoCod.Text = string.Format("{0:000}", produtoInfo.proId);
            labelProdutoDescricao.Text = produtoInfo.proDescricao;
            labelValorUnit.Text = string.Format("{0:C}", produtoInfo.proValorVarejo);
            labelValorDesc.Text = string.Format("{0:C}", produtoInfo.proValorVarejo);
            textquant = 1;

            if (produtoEstoqueInfo != null)
                labelQuantEstoque.Text = string.Format("{0:000}", produtoEstoqueInfo.prodestoquequant);
            else
                labelQuantEstoque.Text = "000";

            AoAlterar_textBoxProdutoCod(true);

            textBoxQuantPedido.Select();
        }

        private void buttonProdutoInfo_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos(produtoInfo.proId);
            formProdutos.ShowDialog(this);

            if (formProdutos.DialogResult == DialogResult.Yes)
                ConsultarProduto(produtoInfo.proId);

            formProdutos.Dispose();
        }

        private void ConsultarProduto(int id)
        {
            produtoInfo = negocioProduto.ConsultarProdutosId(id);

            if (produtoInfo != null)
                PreencherFormProduto();
            else
            {
                FormMessage.ShowMessegeWarning("Insira um código válido!");
                textBoxProdutoCod.Clear();
                textBoxProdutoCod.Select();
            }
        }

        private void buttonDesconto_Click(object sender, EventArgs e)
        {
            FormProdDesconto formProdDesconto = new FormProdDesconto(produtoInfo.proValorVarejo, produtoInfo.proDescricao);
            formProdDesconto.ShowDialog(this);

            if (formProdDesconto.DialogResult == DialogResult.Yes)
                labelValorDesc.Text = formProdDesconto.valorFinal[1];

            formProdDesconto.Dispose();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (textquant > 0)
            {
                decimal desc = Convert.ToDecimal(labelValorDesc.Text.Replace("R$ ", ""));

                GridPedidoInfo gridPedidoInfo = new GridPedidoInfo
                {
                    cod = produtoInfo.proId,
                    descricao = produtoInfo.proDescricao,
                    quant = textquant,
                    valorDesc = desc,
                    valorUnit = produtoInfo.proValorVarejo,
                    valorTotal = textquant * desc
                };

                if (dataGridViewPedido.Rows.Count > 0)
                {
                    for (int i = 0; i < gridPedidoColecao.Count; i++)
                    {
                        if (gridPedidoInfo.cod == gridPedidoColecao[i].cod)
                        {
                            gridPedidoInfo.quant += gridPedidoColecao[i].quant;
                            gridPedidoInfo.valorTotal = gridPedidoColecao[i].valorDesc * gridPedidoInfo.quant;
                            gridPedidoColecao.RemoveAt(i);
                        }
                    }
                }

                gridPedidoColecao.Add(gridPedidoInfo);
                textBoxProdutoCod.Clear();
                textBoxProdutoCod.Select();
                AoAlterar_textBoxProdutoCod();
                PreencherGridPedido();
                buttonConfirmar.Enabled = true;
                buttonVenda.Enabled = false;
            }
            else
            {
                FormMessage.ShowMessegeWarning("Informe a quantidade!");
                textBoxQuant.Select();
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewPedido.SelectedRows.Count > 0)
            {
                GridPedidoInfo gridPedidoInfo = (GridPedidoInfo)dataGridViewPedido.SelectedRows[0].DataBoundItem;

                for (int i = 0; i < gridPedidoColecao.Count; i++)
                    if (gridPedidoInfo.cod == gridPedidoColecao[i].cod)
                        gridPedidoColecao.RemoveAt(i);

                dataGridViewPedido.DataSource = null;
                dataGridViewPedido.DataSource = gridPedidoColecao;

                ContarItens();
                textBoxProdutoCod.Select();
                buttonConfirmar.Enabled = true;
                buttonVenda.Enabled = false;
            }
            else
                FormMessage.ShowMessegeWarning("Selecione o item que deseja remover!");
        }

        private void ContarItens()
        {
            total = 0;
            quant = 0;
            foreach (GridPedidoInfo grid in gridPedidoColecao)
            {
                total += grid.valorTotal;
                quant += grid.quant;
            }

            labelItensDescricao.Text = string.Format("{0:000}", quant);
            labelTotalDescricao.Text = string.Format("{0:C}", total);
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

        private bool VerificarAlteracao()
        {

            if (!status.Equals(textBoxStatus.Text))
                addAlteracao += "Status foi alterado de " + status + " para -> " + textBoxStatus.Text + Environment.NewLine;

            if (!resp.Equals(textBoxResponsavel.Text))
                addAlteracao += "Técnico responsável foi alterado de " + resp + " para -> " + textBoxResponsavel.Text + Environment.NewLine;

            if (!defeito.Equals(textBoxDefeito.Text))
                addAlteracao += "Defeito foi alterado de " + defeito + " para -> " + textBoxDefeito.Text + Environment.NewLine;

            if (!observacao.Equals(textBoxObs.Text))
                addAlteracao += "Observação foi alterado de " + observacao + " para -> " + textBoxObs.Text;

            if (!data.Equals(textBoxAgend.Text))
                addAlteracao += "Observação foi alterado de " + data + " para -> " + textBoxAgend.Text;

            if (!ntaxa.Equals(textBoxTaxa.Text))
                addAlteracao += "Observação foi alterado de " + ntaxa + " para -> " + textBoxTaxa.Text;

            if (!chamado.Equals(textBoxChamado.Text))
                addAlteracao += "Observação foi alterado de " + chamado + " para -> " + textBoxChamado.Text;

            if (string.IsNullOrEmpty(addAlteracao))
                return false;
            else
                return true;
        }
        
        private void FormServicoConsultar_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewPedido.ColumnCount; i++)
                dataGridViewPedido.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
        }

        private void textBoxQuantPedido_Leave(object sender, EventArgs e)
        {
            textquant = ConvertNum(textBoxQuantPedido);
        }

        private void buttonEncerrar_Click(object sender, EventArgs e)
        {
            if (FormMessage.ShowMessegeQuestion("Deseja encerrar esta Ordem de Serviço?") == DialogResult.Yes)
            {
                if (infoServ.servendaconfirm == false)
                {
                    if (total > 0)
                    {
                        if (FormMessage.ShowMessegeQuestion("Há um orçamento em aberto. Deseja realizar uma venda?") == DialogResult.Yes)
                            if (VerificarCaixa())
                                IniciarVenda();
                    }
                }

                thread = new Thread(EncerrarServico);
                form1.ExecutarThread(thread);
                this.Activate();
                alter = true;
                FormMessage.ShowMessegeInfo("Ordem de Serviço foi encerrada com sucesso!");
                this.Close();
            }
        }

        private void EncerrarServico()
        {

            negocioServ.UpdateServicoStatus(os: infoServ.serid, status: 2, dateTimePickerFinal.Value.Date);
            Form1.encerrarThread = true;
        }

        private void CriarVenda(EnumVenda enumVenda)
        {
            vendaInfo = new VendaInfo
            {
                vendata = DateTime.Now.Date,
                venidcliente = infoServ.seridcliente,
                venidfunc = infoServ.seridtecresp,
                venidstatus = 1,
                venidunidade = Form1.Unidade.uniid,
                venquant = quant,
                venvalor = total,
                venvip = 1,
                venmodo = 1,
                venidturno = 0,
                venidtipoentrada = 2                
            };
            
            colecaoDetalhes = new VendaDetalhesColecao();

            if (enumVenda == EnumVenda.Taxa)
            {
                VendaDetalhesInfo vendaDetalhesInfo = new VendaDetalhesInfo
                {
                    vendetalhesid = 0,
                    vendetalhesidprod = taxa.proId,
                    vendetalhesidvenda = vendaInfo.venid,
                    vendetalhesquant = 1,
                    vendetalhesvalordesc = infoServ.sertaxa,
                    vendetalhesvalorunit = infoServ.sertaxa,
                    vendetalhesidfunc = vendaInfo.venidfunc
                };

                colecaoDetalhes.Add(vendaDetalhesInfo);
            }
            else
            {
                foreach (GridPedidoInfo pedido in gridPedidoColecao)
                {
                    VendaDetalhesInfo vendaDetalhesInfo = new VendaDetalhesInfo
                    {
                        vendetalhesid = 0,
                        vendetalhesidprod = pedido.cod,
                        vendetalhesidvenda = vendaInfo.venid,
                        vendetalhesquant = pedido.quant,
                        vendetalhesvalordesc = pedido.valorDesc,
                        vendetalhesvalorunit = pedido.valorUnit,
                        vendetalhesidfunc = vendaInfo.venidfunc
                    };

                    colecaoDetalhes.Add(vendaDetalhesInfo);
                }
            }

            Form1.encerrarThread = true;

            AbrirVenda(enumVenda);
        }

        private bool AbrirVenda(EnumVenda enumVenda)
        {
            string OsTexto = string.Empty;
            OsTexto = "OS: " + string.Format("{0:000000}", infoServ.serid);

            FormVenda formVenda = new FormVenda(vendaInfo, colecaoDetalhes, OsTexto, enumVenda);
            formVenda.ShowDialog(this);
            formVenda.Dispose();

            if (formVenda.DialogResult == DialogResult.Yes)
            {
                servicoOrcamento = formVenda.ServicoTaxa;
                VendaConcluida(enumVenda);
                FormMessage.ShowMessegeInfo("Venda realizada com sucesso.");
                return true;
            }
            else
                return false;

        }

        private void VendaConcluida(EnumVenda enumVenda)
        {
            if (enumVenda == EnumVenda.Taxa)
            {
                thread = new Thread(InserirTaxa);
                form1.ExecutarThread(thread);
            }
            else
            {
                thread = new Thread(AtualizarServico);
                form1.ExecutarThread(thread);
            }
            this.Activate();
        }

        private void InserirTaxa()
        {
            servicoOrcamento.servicoorcamentoidserv = infoServ.serid;
            negocioServ.InsertServicoOrcamento(servicoOrcamento);
            negocioServ.UpdateServicoTaxa(servicoOrcamento);
            negocioServ.UpdateServicoStatus(os: infoServ.serid, status: infoServ.seridstatus, dateTimePickerFinal.Value.Date);
            Form1.encerrarThread = true;
        }

        private void AtualizarServico()
        {
            negocioServ.UpdateServicoStatus(os: infoServ.serid, status: infoServ.seridstatus, dateTimePickerFinal.Value.Date);
            negocioServ.UpdateServicoConfirmVenda(infoServ.serid);
            Form1.encerrarThread = true;
        }

        private void buttonVenda_Click(object sender, EventArgs e)
        {
            if (FormMessage.ShowMessegeQuestion("Deseja realizar uma venda para este orçamento?") == DialogResult.Yes)
                if (VerificarCaixa())
                    IniciarVenda();
        }
        
        private void IniciarVenda()
        {
            CriarVenda(EnumVenda.Servico);
            BuscarServico();
        }

        private void buttonBuscarTec_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrEmpty(textBoxCodTec.Text) || !string.IsNullOrEmpty(textBoxResponsavel.Text))
            {
                FuncColecao colecao = negocioFunc.ConsultatFuncTotal();
                ConsultarResponsavel(colecao);
            }
            else
            {
                responsavel = negocioFunc.ConsultarFuncPorId(ConvertNum(textBoxCodTec));

                if (responsavel != null)
                {
                    textBoxCodTec.Text = string.Format("{0:000}", responsavel.funId);
                    textBoxResponsavel.Text = responsavel.funNome;
                }
                else
                {
                    FormMessage.ShowMessegeWarning("Código inválido, tente outro!");
                    textBoxCodTec.Clear();
                    textBoxCodTec.Select();
                }
            }
        }

        private void buttonBuscarStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCodStatus.Text) || !string.IsNullOrEmpty(textBoxStatus.Text))
            {
                CodDescricaoColecao colecao = negocioServ.ConsultarStatus();
                ConsultarStatus(colecao);
            }
            else
            {

            }
        }

        private void ConsultarStatus(CodDescricaoColecao colecao)
        {
            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();

            foreach (CodDescricaoInfo cod in colecao)
            {
                if (cod.cod != 2)
                {
                    Form_Consultar form_Consultar = new Form_Consultar
                    {
                        Cod = string.Format("{0:000}", cod.cod),
                        Descricao = cod.descricao
                    };

                    form_ConsultarColecao.Add(form_Consultar);
                }
            }

            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, "Técnico Responsável");
            formConsultar_Cod_Descricao.ShowDialog(this);

            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
            {
                textBoxCodStatus.Text = formConsultar_Cod_Descricao.Selecionado.Cod;
                textBoxStatus.Text = formConsultar_Cod_Descricao.Selecionado.Descricao;
                textBoxCodStatus.Select();
                buttonSalvar.Enabled = true;
            }
        }

        private void ConsultarResponsavel(FuncColecao funcColecao)
        {
            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();

            foreach (FuncInfo func in funcColecao)
            {
                Form_Consultar form_Consultar = new Form_Consultar
                {
                    Cod = string.Format("{0:000}", func.funId),
                    Descricao = func.funNome
                };

                form_ConsultarColecao.Add(form_Consultar);
            }

            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, "Técnico Responsável");
            formConsultar_Cod_Descricao.ShowDialog(this);

            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
            {
                textBoxCodTec.Text = formConsultar_Cod_Descricao.Selecionado.Cod;
                textBoxResponsavel.Text = formConsultar_Cod_Descricao.Selecionado.Descricao;
                responsavel = negocioFunc.ConsultarFuncPorId(Convert.ToInt32(formConsultar_Cod_Descricao.Selecionado.Cod));
                textBoxCodTec.Select();
                buttonSalvar.Enabled = true;
            }
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (FormMessage.ShowMessegeQuestion("Deseja salvar esta lista?") == DialogResult.Yes)
            {
                thread = new Thread(SalvarOrcamento);
                form1.ExecutarThread(thread);
                this.Activate();
                FormMessage.ShowMessegeInfo("Lista atualizada com sucesso!");
                buttonConfirmar.Enabled = false;
                BuscarServico();
            }
        }

        private void SalvarOrcamento()
        {
            negocioServ.DeleteServOrcamento(infoServ.serid);

            foreach (GridPedidoInfo pedido in gridPedidoColecao)
            {
                if (pedido.valorDesc > 0)
                {
                    ServicoOrcamentoInfo orc = new ServicoOrcamentoInfo
                    {
                        servicoorcamentoidprod = pedido.cod,
                        servicoorcamentoidserv = infoServ.serid,
                        servicoorcamentoquant = pedido.quant,
                        servicoorcamentovalordesc = pedido.valorDesc,
                        servicoorcamentovalorunit = pedido.valorUnit
                    };

                    negocioServ.InsertServicoOrcamento(orc);
                }
            }

            Form1.encerrarThread = true;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (FormMessage.ShowMessegeQuestion("Deseja salvar as alterações?") == DialogResult.Yes)
            {
                if (VerificarAlteracao())
                {
                    servicoAlter = new ServicoInfo
                    {
                        seridstatus = ConvertNum(textBoxCodStatus),
                        seridtecresp = ConvertNum(textBoxCodTec),
                        serdefeitodescricao = textBoxDefeito.Text,
                        serobs = textBoxObs.Text,
                        serid = infoServ.serid,
                        sertaxa = Convert.ToDecimal(textBoxTaxa.Text.Replace("R$ ", "")),
                        serdataagend = Convert.ToDateTime(textBoxAgend.Text).Date,
                    };

                    thread = new Thread(SalvarAlteracoes);
                    form1.ExecutarThread(thread);
                    this.Activate();
                    alter = true;
                    FormMessage.ShowMessegeInfo("Alterações salvas com sucesso.");
                    BuscarServico();
                }
                else
                {
                    FormMessage.ShowMessegeInfo("Não houve alterações para serem salvas.");
                }

                addAlteracao = string.Empty;

            }
        }

        private void ButtonProd_Click(object sender, EventArgs e)
        {
            FormCadEletro formCadEletro = new FormCadEletro(infoServ.serideletro);
            formCadEletro.ShowDialog(this);
            formCadEletro.Dispose();

            if (formCadEletro.DialogResult == DialogResult.Yes)
            {
                infoEletro = formCadEletro.SelecionadoEletro;
                BuscarServico();
            }
        }

        private void ConsultarColecaoNota()
        {
            colecaoNota = negocioServ.ConsultarNotaClienteId(infoCliente.cliid);
            Form1.encerrarThread = true;
        }
        private void ButtonNota_Click(object sender, EventArgs e)
        {
            thread = new Thread(ConsultarColecaoNota);
            form1.ExecutarThread(thread);
            this.Activate();

            if (colecaoNota != null)
            {
                FormNotaLista formNotaLista = new FormNotaLista(colecaoNota);
                formNotaLista.ShowDialog(this);
                formNotaLista.Dispose();

                if (formNotaLista.DialogResult == DialogResult.Yes)
                {
                    infoNota = formNotaLista.SelecionadoNota;

                    FormNotaFiscal formNotaFiscal = new FormNotaFiscal(infoNota);
                    formNotaFiscal.ShowDialog(this);
                    formNotaFiscal.Dispose();
                }
            }
            else
            {
                FormNotaFiscal formNotaFiscal = new FormNotaFiscal(infoCliente);
                formNotaFiscal.ShowDialog(this);
                formNotaFiscal.Dispose();
            }
        }

        private void FormServicoConsultar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alter)
                this.DialogResult = DialogResult.Yes;
        }

        private void SalvarAlteracoes()
        {
            ServicoObsTecInfo obs = new ServicoObsTecInfo
            {
                IdFunc = Form1.User.useidfuncionario,
                ObsTec = addAlteracao,
                IdOs = infoServ.serid
            };
            
            negocioServ.UpdateServicoAlter(servicoAlter);
            negocioServ.InserirObsTec(obs);
            Form1.encerrarThread = true;
        }

        private void buttonTaxa_Click(object sender, EventArgs e)
        {
            if (VerificarCaixa())
            {
                if (CadTaxa())
                {
                    taxa = negocioProduto.ConsultarProdutosTaxa();
                    CriarVenda(EnumVenda.Taxa);
                    BuscarServico();
                }
            }
        }

        private bool VerificarCaixa()
        {
            caixa = new Caixa();
            return caixa.VerificarCaixa();
        }

        private bool CadTaxa()
        {
            ProdutoInfo taxa = negocioProduto.ConsultarProdutosTaxa();

            if (taxa == null)
            {
                FornecedorNegocios fornecedorNegocios = new FornecedorNegocios(Form1.Empresa.empconexao);
                FornecedorInfo fornecedorInfo = fornecedorNegocios.ConsultarForncedorPadrao();

                ProdutoInfo prod = new ProdutoInfo
                {
                    proCodBarras = "",
                    proControleEstoque = false,
                    proDescricao = "TAXA VISITA TÉCNICA",
                    proQuantMinima = 0,
                    proValorAtacado = 1,
                    proValorCompra = 1,
                    proValorVarejo = 1,
                    proidfornecedor = fornecedorInfo.forId,
                    proidmarca = 65,
                    proidstatus = 1,
                    proidsubcategoria = 1,
                    proidUser = Form1.User.useidfuncionario,
                    procodkit = "",
                    protaxa = true
                };

                if (negocioProduto.InsertProduto(prod) > 0)
                    return true;
                else
                    return false;
            }
            else
                return true;
        }

        private void textBoxObs_TextChanged(object sender, EventArgs e)
        {
            buttonSalvar.Enabled = true;
        }

        private void textBoxCodTec_TextChanged(object sender, EventArgs e)
        {
            textBoxResponsavel.Clear();
        }

        private void textBoxCodStatus_TextChanged(object sender, EventArgs e)
        {
            textBoxStatus.Clear();
        }
    }
}

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
    public partial class FormPagamento : Form
    {
        Form1 form1 = new Form1();
        VendaNegocios vendaNegocios = new VendaNegocios(Form1.Empresa.empconexao);
        CaixaNegocios caixaNegocios = new CaixaNegocios(Form1.Empresa.empconexao);
        ClienteNegocios clienteNegocios = new ClienteNegocios(Form1.Empresa.empconexao);

        VendaInfo vendaInfo;
        CodDescricaoColecao pagtipo;
        CodDescricaoColecao maquineta;
        VendaDetalhesColecao vendacolecao;
        FormaPagamentoColecao formaPagamentoColecao;
        GridFormaPagamentoColecao gridFormaPagamentoColecao;

        Thread thread;
        


        public VendaInfo VendaConcluida { get; set; }
        private decimal VendaValor { get; set; }
        decimal troco;


        public FormPagamento()
        {
            Inicializar();
        }

        public FormPagamento(VendaInfo venda, VendaDetalhesColecao colecao)
        {
            Inicializar();
            vendaInfo = venda;
            vendacolecao = colecao;
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();

            gridFormaPagamentoColecao = new GridFormaPagamentoColecao();

            formaPagamentoColecao = vendaNegocios.ConsultarFormaPagamento();
            textBoxForma.Text = string.Format("{0:000}", formaPagamentoColecao[0].formpagid);
            labelValorForma.Text = formaPagamentoColecao[0].formpagdescricao;

            maquineta = vendaNegocios.ConsultarMaquineta();
            comboBoxBandeira.DisplayMember = "descricao";
            comboBoxBandeira.ValueMember = "cod";
            comboBoxBandeira.DataSource = maquineta;

            pagtipo = vendaNegocios.ConsultarPagamentoTipo();
            comboBoxTipo.DisplayMember = "descricao";
            comboBoxTipo.ValueMember = "cod";
            comboBoxTipo.DataSource = pagtipo;

            textBoxForma.LostFocus += new EventHandler(textBoxForma_LostFocus);
        }

        private void FormPagamento_Load(object sender, EventArgs e)
        {

            textBoxValor.Text = vendaInfo.venvalor.ToString("C2");
            textBoxValor.Select();
            labelValorCompra.Text = vendaInfo.venvalor.ToString("C");
            textBoxValor.Text = vendaInfo.venvalor.ToString("C").Replace("R$", "");
            troco = -vendaInfo.venvalor;
            labelValorTroco.Text = troco.ToString("C");
            AoDeixar();

            
        }

        private void BuscarFormaPag()
        {
            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();

            if (formaPagamentoColecao != null)
            {
                foreach (FormaPagamentoInfo pag in formaPagamentoColecao)
                {
                    Form_Consultar form_Consultar = new Form_Consultar
                    {
                        Cod = string.Format("{0:000}", pag.formpagid),
                        Descricao = pag.formpagdescricao
                    };

                    form_ConsultarColecao.Add(form_Consultar);
                }
            }
            else
            {
                Form_Consultar form_Consultar = new Form_Consultar
                {
                    Cod = "",
                    Descricao = "NENHUMA FORMA DE PAGAMENTO FOI CADASTRADA"
                };

                form_ConsultarColecao.Add(form_Consultar);
            }


            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, "Formas de pagamentos");
            formConsultar_Cod_Descricao.ShowDialog(this);

            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
            {
                textBoxForma.Text = formConsultar_Cod_Descricao.Selecionado.Cod;
                labelValorForma.Text = formConsultar_Cod_Descricao.Selecionado.Descricao;
                textBoxValor.Select();
                AoDeixar();
            }
            formConsultar_Cod_Descricao.Dispose();
        }

        private void textBoxForma_TextChanged(object sender, EventArgs e)
        {
            labelValorForma.Text = "";

        }

        private void textBoxForma_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxForma.Text))
            {
                if (int.TryParse(textBoxForma.Text, out int cod))
                {
                    foreach (FormaPagamentoInfo pag in formaPagamentoColecao)
                    {
                        if (cod == pag.formpagid)
                        {
                            textBoxForma.Text = string.Format("{0:000}", pag.formpagid);
                            labelValorForma.Text = pag.formpagdescricao;
                            textBoxValor.Select();
                            return;
                        }
                    }

                    textBoxForma.Clear();
                }
            }
        }
        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            BuscarFormaPag();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddPagamento();
        }

        private void AddPagamento()
        {
            if (Convert.ToDecimal(textBoxForma.Text) > 0)
            {
                if (decimal.TryParse(textBoxValor.Text, out decimal cod))
                {
                    GridFormaPagamentoInfo gridFormaPagamentoInfo = new GridFormaPagamentoInfo
                    {
                        pagband = Convert.ToInt32(comboBoxBandeira.SelectedValue),
                        pagbanddescricao = comboBoxBandeira.Text,
                        pagdescricao = labelValorForma.Text,
                        pagid = Convert.ToInt32(textBoxForma.Text),
                        pagtipo = Convert.ToInt32(comboBoxTipo.SelectedValue),
                        pagvalor = Convert.ToDecimal(textBoxValor.Text),
                        parcela = comboBoxTipo.Text + "/" + comboBoxParcela.Text,
                        parc = Convert.ToInt32(comboBoxParcela.Text.Replace("x", ""))
                    };

                    gridFormaPagamentoColecao.Add(gridFormaPagamentoInfo);
                    PreencherGrid();
                }
                else
                {
                    FormMessage.ShowMessegeWarning("Insira um valor válido!");
                    textBoxValor.Clear();
                }
            }
            else
                FormMessage.ShowMessegeWarning("Defina a forma de pagamento!");
        }

        private void PreencherGrid()
        {
            dataGridViewFormaPag.DataSource = null;
            dataGridViewFormaPag.DataSource = gridFormaPagamentoColecao;

            decimal total = 0;
            foreach (GridFormaPagamentoInfo formaPag in gridFormaPagamentoColecao)
                total += formaPag.pagvalor;

            VendaValor = total;
            troco = total - vendaInfo.venvalor;

            if (troco < 0)
            {
                decimal valor = -troco;
                textBoxValor.Text = valor.ToString("C").Replace("R$", "");
            }
            else
                textBoxValor.Text = "0";

            labelValorTroco.Text = string.Format("{0:C2}", troco);

            if ((total - vendaInfo.venvalor) < 0)
                labelValorTroco.ForeColor = Color.Brown;
            else
                labelValorTroco.ForeColor = Color.Green;

            labelTotalPag.Text = string.Format("{0:C2}", VendaValor);
            buttonRemover.Enabled = true;

            if ((vendaInfo.venvalor - VendaValor) <= 0)
            {
                groupBoxPag.Enabled = false;
                buttonConcluir.Enabled = true;
                comboBoxBandeira.SelectedValue = 0;
                comboBoxTipo.SelectedValue = 0;
                comboBoxParcela.SelectedValue = 0;
                textBoxForma.Clear();
                textBoxValor.Clear();
                labelValorForma.Text = "";
            }
        }

        private void AoDeixar()
        {
            if (int.TryParse(textBoxForma.Text, out int cod))
            {
                FormaPagamentoInfo pag = vendaNegocios.ConsultarFormaPagamentoId(cod);
                textBoxForma.Text = string.Format("{0:000}", cod);
                labelValorForma.Text = pag.formpagdescricao;

                switch (cod)
                {
                    case 1:
                        comboBoxBandeira.Enabled = false;
                        comboBoxBandeira.SelectedValue = 1;
                        comboBoxTipo.Enabled = false;
                        comboBoxTipo.SelectedValue = 1;
                        comboBoxParcela.Enabled = false;
                        comboBoxParcela.Text = "1x";
                        break;
                    case 2:
                        comboBoxBandeira.Enabled = true;
                        comboBoxBandeira.SelectedValue = 2;
                        comboBoxTipo.Enabled = false;
                        comboBoxTipo.SelectedValue = 1;
                        comboBoxParcela.Enabled = false;
                        comboBoxParcela.Text = "1x";
                        break;
                    case 3:
                        comboBoxBandeira.Enabled = true;
                        comboBoxBandeira.SelectedValue = 2;
                        comboBoxTipo.Enabled = true;
                        comboBoxTipo.SelectedValue = 2;
                        comboBoxParcela.Enabled = true;
                        comboBoxParcela.Text = "2x";
                        break;
                    case 4:
                        comboBoxBandeira.Enabled = false;
                        comboBoxBandeira.SelectedValue = 1;
                        comboBoxTipo.Enabled = true;
                        comboBoxTipo.SelectedValue = 1;
                        comboBoxParcela.Enabled = true;
                        comboBoxParcela.Text = "2x";
                        break;
                    case 5:
                        comboBoxBandeira.Enabled = false;
                        comboBoxBandeira.SelectedValue = 1;
                        comboBoxTipo.Enabled = false;
                        comboBoxTipo.SelectedValue = 1;
                        comboBoxParcela.Enabled = false;
                        comboBoxParcela.Text = "1x";
                        break;
                    case 6:
                        comboBoxBandeira.Enabled = false;
                        comboBoxBandeira.SelectedValue = 1;
                        comboBoxTipo.Enabled = false;
                        comboBoxTipo.SelectedValue = 1;
                        comboBoxParcela.Enabled = false;
                        comboBoxParcela.Text = "1x";
                        break;
                    default:
                        break;
                }

                buttonAdd.Enabled = true;
            }
        }

        private void textBoxForma_Leave(object sender, EventArgs e)
        {
            AoDeixar();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewFormaPag.SelectedRows.Count > 0)
            {
                GridFormaPagamentoInfo gridFormaPagamentoInfo = (dataGridViewFormaPag.SelectedRows[0].DataBoundItem as GridFormaPagamentoInfo);
                for (int i = 0; i < gridFormaPagamentoColecao.Count; i++)
                {
                    if (gridFormaPagamentoInfo.pagid == gridFormaPagamentoColecao[i].pagid)
                        gridFormaPagamentoColecao.RemoveAt(i);
                }

                textBoxForma.Text = "1";
                groupBoxPag.Enabled = true;

                AoDeixar();
                PreencherGrid();
            }
            else
                FormMessage.ShowMessegeWarning("Selecione um item!");
        }

        private void buttonConcluir_Click(object sender, EventArgs e)
        {
            ConcluirVenda();
        }

        private void ConcluirVenda()
        {
            thread = new Thread(Concluir);
            form1.ExecutarThread(thread);
            this.Activate();
        }

        private int InserirVenda()
        {
            vendaInfo.venidstatus = 2;
            vendaInfo.venid = vendaNegocios.InsertVenda(vendaInfo);

            if (vendaInfo.venid > 0)
            {
                foreach (VendaDetalhesInfo vendaDetalhesInfo in vendacolecao)
                {
                    vendaDetalhesInfo.vendetalhesidvenda = vendaInfo.venid;

                    if (vendaNegocios.InsertVendaDetalhes(vendaDetalhesInfo) == 0)
                    {
                        FormMessage.ShowMessegeWarning("Falha ao salvar os itens!");
                        return 0;
                    }
                }

                VendaConcluida = vendaInfo;
                return vendaInfo.venid;
            }
            else
                return 0;
        }

        private void Concluir()
        {
            if (troco >= 0)
            {
                if (InserirVenda() > 0)
                {
                    PagamentoInfo pagamentoInfo = new PagamentoInfo
                    {
                        pagamentoid = 0,
                        pagamentoidvenda = vendaInfo.venid,
                        pagamentoquantforma = dataGridViewFormaPag.RowCount,
                        pagamentovalor = vendaInfo.venvalor,
                        pagamentotroco = troco
                    };

                    int cod = vendaNegocios.InsertPagamento(pagamentoInfo);
                    if (cod > 0)
                    {
                        foreach (GridFormaPagamentoInfo pag in gridFormaPagamentoColecao)
                        {
                            PagamentoDetalhesInfo pagamentoDetalhesInfo = new PagamentoDetalhesInfo
                            {
                                pagdetalhesid = 0,
                                pagdetalhesidmaquineta = pag.pagband,
                                pagdetalhesidpag = cod,
                                pagdetalhesidtipopag = pag.pagtipo,
                                pagdetalhesnumparcelas = pag.parc,
                                pagdetalhesvalor = pag.pagid == 1 ? pag.pagvalor - troco : pag.pagvalor,
                                pagdetalhesidform = pag.pagid
                            };

                            if (vendaNegocios.InsertPagamentoDetalhes(pagamentoDetalhesInfo) == 0)
                            {
                                Form1.encerrarThread = true;
                                FormMessage.ShowMessegeWarning("Falha, tente novamente!");
                                return;
                            }
                        }

                        ClienteInfo clienteInfo = clienteNegocios.ConsultarClientePorId(vendaInfo.venidcliente);
                        
                        EntradaSaidaInfo entradaSaidaSalvar = new EntradaSaidaInfo
                        {
                            entracodtodasparcelas = 0,
                            entraconfirmada = true,
                            entradatalancamento = DateTime.Now,
                            entradatavenc = DateTime.Now.Date,
                            entradocumento = Convert.ToString(vendaInfo.venid),
                            entraid = 0,
                            entraidfunc = Form1.User.useidfuncionario,
                            entraidunidade = Form1.Unidade.uniid,
                            entranumparcela = 1,
                            entranumtotalparcelas = 1,
                            entraobs = "Controle da venda: " + string.Format("{0:000000000}", pagamentoInfo.pagamentoidvenda) + Environment.NewLine +
                            "Cliente: " + clienteInfo.clinome + Environment.NewLine + "Vendedor: " + Form1.User.usenome,
                            entratipocatdecricao = "",
                            entratipoidcat = 4,
                            entravalor = pagamentoInfo.pagamentovalor,
                            entravalorpago = pagamentoInfo.pagamentovalor,
                            entraidtipoentrada = 4,
                            entraparcelado = false,
                        };

                        EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios(Form1.Empresa.empconexao);
                        if (entradaSaidaNegocios.InsertEntradaSaidaLancamento(entradaSaidaSalvar) == 0)
                        {
                            Form1.encerrarThread = true;
                            FormMessage.ShowMessegeWarning("Falha, tente novamente!");
                            return;
                        }

                        Form1.encerrarThread = true;
                        this.DialogResult = DialogResult.Yes;
                    }
                }
                else
                {
                    Form1.encerrarThread = true;
                    FormMessage.ShowMessegeWarning("Falha ao tentar concluir a venda!");
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                Form1.encerrarThread = true;
                FormMessage.ShowMessegeWarning("Todo o valor precisa ser liquidado para concluir a venda!");
            }

            Form1.encerrarThread = true;
        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat((TextBox)sender);
        }

        private void FormPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    BuscarFormaPag();
                    break;
                case Keys.F2:
                    textBoxValor.Select();
                    break;
                case Keys.F3:
                    AddPagamento();
                    break;
                case Keys.F11:
                this.Close();
                    break;
                case Keys.F12:
                    ConcluirVenda();
                    break;

                default:
                    break;
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPagamento_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}

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

using ObjTransfer;
using Negocios;

namespace WinForms
{
    public partial class FormVendaRelatorio : Form
    {
        Form1 form1 = new Form1();
        Thread thread;
        VendaInfo infoVenda;
        VendaColecao colecaoVenda;
        ClienteInfo infoCliente;
        GridViewVendaPeriodoColecao gridViewVendaPeriodoColecao;
        CaixaNegocios negociosCaixa = new CaixaNegocios(Form1.Empresa.empconexao);
        VendaNegocios negociosVenda = new VendaNegocios(Form1.Empresa.empconexao);
        ClienteNegocios negociosCliente = new ClienteNegocios(Form1.Empresa.empconexao);

        DateTime dataIni;
        DateTime dataFim;

        int combo;
        int radio;

        decimal totaldinheiro = 0;
        decimal totaldebito = 0;
        decimal totalcredito = 0;
        decimal totalcheque = 0;
        decimal totaldeposito = 0;
        decimal totaloutras = 0;
        decimal total = 0;

        public FormVendaRelatorio()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            comboBoxTurno.SelectedIndex = 0;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            PreencherListaThread();
        }

        private void PreencherListaThread()
        {
            buttonCancelar.Enabled = true;
            buttonAbrir.Enabled = true;

            dataIni = dateTimePickerIni.Value.Date;
            dataFim = dateTimePickerFinal.Value.Date;

            if (radioButtonConcluida.Checked)
                radio = 1;
            else if (radioButtonCancelada.Checked)
                radio = 2;
            else if (radioButtonAberta.Checked)
                radio = 3;
            combo = comboBoxTurno.SelectedIndex;

            gridViewVendaPeriodoColecao = new GridViewVendaPeriodoColecao();
            thread = new Thread(PreencherLista);
            form1.ExecutarThread(thread);
            this.Activate();

            labelValorDinheiro.Text = totaldinheiro.ToString("C");
            labelValorDebito.Text = totaldebito.ToString("C");
            labelValorCredito.Text = totalcredito.ToString("C");
            labelValorCheque.Text = totalcheque.ToString("C");
            labelValorDeposito.Text = totaldeposito.ToString("C");
            labelValorOutras.Text = totaloutras.ToString("C");
            labelValorTotal.Text = total.ToString("C");

            if (colecaoVenda == null)
            {
                
                GridViewVendaPeriodo gridViewVendaPeriodo = new GridViewVendaPeriodo
                {
                    Cheque = 0,
                    Cliente = "Nenhuma venda realizada neste período!",
                    Credito = 0,
                    Debito = 0,
                    Deposito = 0,
                    Dinheiro = 0,
                    ID = 0,
                    Outras = 0,
                    Total = 0,
                    Turno = 0
                };

                gridViewVendaPeriodoColecao = new GridViewVendaPeriodoColecao
                {
                    gridViewVendaPeriodo
                };

                buttonCancelar.Enabled = false;
                buttonAbrir.Enabled = false;
                
            }

            dataGridViewVendaPeriodo.DataSource = null;
            dataGridViewVendaPeriodo.DataSource = gridViewVendaPeriodoColecao;
        }

        private void PreencherLista()
        {
            if (radio == 1)
                colecaoVenda = negociosVenda.ConsultarVendaPeriodo(dataIni, dataFim, 2);
            else if (radio == 2)
                colecaoVenda = negociosVenda.ConsultarVendaPeriodo(dataIni, dataFim, 3);
            else if (radio == 3)
                colecaoVenda = negociosVenda.ConsultarVendaPeriodo(dataIni, dataFim, 1); ;


            if (colecaoVenda != null)
            {
                foreach (VendaInfo venda in colecaoVenda)
                {
                    decimal dinheiro = 0;
                    decimal debito = 0;
                    decimal credito = 0;
                    decimal cheque = 0;
                    decimal deposito = 0;
                    decimal outras = 0;

                    FormaPagamentoPorVendaColecao forma = negociosVenda.ConsultarFormaPagamentoPorVenda(venda.venid);

                    foreach (FormaPagamentoPorVendaInfo pag in forma)
                    {
                        switch (pag.formpagdescricao)
                        {
                            case "DINHEIRO":
                                dinheiro = pag.pagdetalhesvalor;
                                break;
                            case "CARTAO DE DEBITO":
                                debito = pag.pagdetalhesvalor;
                                break;
                            case "CARTAO DE CREDITO":
                                credito = pag.pagdetalhesvalor;
                                break;
                            case "CHEQUE":
                                cheque = pag.pagdetalhesvalor;
                                break;
                            case "DEPOSITO BANCARIO":
                                deposito = pag.pagdetalhesvalor;
                                break;
                            default:
                                outras = pag.pagdetalhesvalor;
                                break;
                        }
                    }

                    infoCliente = negociosCliente.ConsultarClientePorId(venda.venidcliente);

                    CaixaTurnoInfo turno = negociosCaixa.ConsultarCaixaTurnoId(venda.venidturno);


                    GridViewVendaPeriodo gridViewVendaPeriodo = new GridViewVendaPeriodo
                    {
                        Cheque = cheque,
                        Cliente = infoCliente.clinome,
                        Credito = credito,
                        Data = venda.vendata,
                        Debito = debito,
                        Deposito = deposito,
                        Dinheiro = dinheiro,
                        ID = venda.venid,
                        Outras = outras,
                        Total = venda.venvalor,
                        Turno = turno.caixaturnonum
                    };

                    switch (combo)
                    {
                        case 1:
                            if (turno.caixaturnonum == 1)
                                gridViewVendaPeriodoColecao.Add(gridViewVendaPeriodo);
                            break;
                        case 2:
                            if (turno.caixaturnonum == 2)
                                gridViewVendaPeriodoColecao.Add(gridViewVendaPeriodo);
                            break;
                        case 3:
                            if (turno.caixaturnonum == 3)
                                gridViewVendaPeriodoColecao.Add(gridViewVendaPeriodo);
                            break;
                        default:
                            gridViewVendaPeriodoColecao.Add(gridViewVendaPeriodo);
                            break;
                    }
                }


                foreach (GridViewVendaPeriodo periodo in gridViewVendaPeriodoColecao)
                {
                    totaldinheiro += periodo.Dinheiro;
                    totaldebito += periodo.Debito;
                    totalcredito += periodo.Credito;
                    totalcheque += periodo.Cheque;
                    totaldeposito += periodo.Deposito;
                    totaloutras += periodo.Outras;
                    total += periodo.Total;
                }
            }
            Form1.encerrarThread = true;
        }

        private bool ItemSelecionado()
        {
            if (dataGridViewVendaPeriodo.SelectedRows.Count > 0)
            {
                GridViewVendaPeriodo gridViewVendaPeriodo = (dataGridViewVendaPeriodo.SelectedRows[0].DataBoundItem as GridViewVendaPeriodo);
                infoVenda = negociosVenda.ConsultarVendaId(gridViewVendaPeriodo.ID);
                return true;
            }
            else
            {
                FormMessage.ShowMessegeWarning("Selecione uma venda!");
                return false;
            }
        }

        private void FormVendaRelatorio_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewVendaPeriodo.ColumnCount; i++)
                dataGridViewVendaPeriodo.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            AbrirVenda();
        }

        private void AbrirVenda()
        {
            if (ItemSelecionado())
            {
                FormVenda formVenda = new FormVenda(infoVenda);
                formVenda.ShowDialog(this);
                formVenda.Dispose();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            if (caixa.VerificarCaixa())
            {
                if (ItemSelecionado())
                {
                    FormVendaCancelar formVendaCancelar = new FormVendaCancelar(infoVenda);
                    formVendaCancelar.ShowDialog(this);
                    formVendaCancelar.Dispose();

                    if (formVendaCancelar.DialogResult == DialogResult.Yes)
                        PreencherListaThread();
                }
            }
        }

        private void LimparCampos()
        {
            labelValorDinheiro.Text = string.Empty;
            labelValorDebito.Text = string.Empty;
            labelValorCredito.Text = string.Empty;
            labelValorCheque.Text = string.Empty;
            labelValorDeposito.Text = string.Empty;
            labelValorOutras.Text = string.Empty;
            labelValorTotal.Text = string.Empty;
            
            dataGridViewVendaPeriodo.DataSource = null;
        }

        private void dataGridViewVendaPeriodo_DoubleClick(object sender, EventArgs e)
        {
            AbrirVenda();
        }

        private void radioButtonCancelada_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCancelada.Checked)
                buttonCancelar.Visible = false;
            else
                buttonCancelar.Visible = true;

            LimparCampos();
        }

        private void radioButtonAberta_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void radioButtonConcluida_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}

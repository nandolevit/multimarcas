using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using ObjTransfer;
using Negocios;

namespace WinForms
{
    public partial class FrmServico : Form
    {
        Form1 form1 = new Form1();
        Thread thread;
        ClienteInfo infoCliente;
        EnderecoColecao colecaoEnd;
        FuncInfo responsavel;
        FuncColecao colecaofunc;
        ServicoColecao colecaoServico;
        ServicoInfo infoServ;
        EnderecoInfo infoEnd;
        ClienteNegocios negociosCliente = new ClienteNegocios(Form1.Empresa.empconexao);
        ServicoNegocio servicoNegocio = new ServicoNegocio(Form1.Empresa.empconexao);
        FuncNegocios funcNegocios = new FuncNegocios(Form1.Empresa.empconexao);

        int idSave;
        int eletro = 0;
        int tipo = 0;
        bool saved; //confirma se a OS foi salva, para quando fechar a janela atualizar a lista

        public FrmServico(ClienteInfo cliente)
        {
            Inicializar();
            infoCliente = cliente;
            PreencherForm();
        }
        public FrmServico()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            colecaoServico = new ServicoColecao();
        }

        private void PreencherForm()
        {
            textBoxNome.Text = infoCliente.cliid + " - " + infoCliente.clinome;

            thread = new Thread(PreencherFormThread);
            form1.ExecutarThread(thread);
            this.Activate();

            if (colecaoEnd != null)
            {
                infoEnd = colecaoEnd[0];
                PreencherEnd();

                if (colecaoEnd.Count > 1)
                    buttonEnd.Enabled = true;
                else
                    buttonEnd.Enabled = false;
            }
            else
            {
                FormMessage.ShowMessegeWarning("Não existe um endereço cadastrado para este cliente!");
                this.Close();
            }

            if (colecaofunc.Count == 1)
            {
                responsavel = colecaofunc[0];
                textBoxCodTec.Text = string.Format("{0:000}", responsavel.funId);
                textBoxResponsavel.Text = responsavel.funNome;
            }
            else
                ConsultarResponsavel(colecaofunc);

            buttonAdd.Enabled = true;
        }

        private void PreencherFormThread()
        {
            colecaoEnd = negociosCliente.ConsultarEnderecoPorIdCliente(infoCliente.cliid);
            colecaofunc = funcNegocios.ConsultarFuncTecnico();
            Form1.encerrarThread = true;
        }

        private void PreencherEnd()
        {
            textBoxEnd.Text = infoEnd.Cep + " - " + infoEnd.Complemento + " (Ponto de Ref.: " + infoEnd.PontoReferencia + ")";
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AbrirEletro();
        }

        private void AbrirEletro()
        {
            FormProdutoDefeito formProdutoDefeito = new FormProdutoDefeito(infoCliente);
            formProdutoDefeito.ShowDialog(this);
            formProdutoDefeito.Dispose();

            if (formProdutoDefeito.DialogResult == DialogResult.Yes)
            {
                textBoxDescricao.Text = formProdutoDefeito.desc[0];
                textBoxDefeito.Text = formProdutoDefeito.desc[1];
                eletro = Convert.ToInt32(formProdutoDefeito.desc[2]);
                tipo = Convert.ToInt32(formProdutoDefeito.desc[3]);
                textBoxObs.Select();
                buttonSalvar.Enabled = false;
                buttonAddServico.Enabled = true;
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (dataGridViewServico.Rows.Count > 0)
            {
                if (FormMessage.ShowMessegeQuestion("Deseja salvar este registro?") == DialogResult.Yes)
                {
                    List<int> listInt = new List<int>();
                    colecaoServico = new ServicoColecao();

                    foreach (DataGridViewRow row in dataGridViewServico.Rows)
                    {
                        idSave = servicoNegocio.InsertServico((ServicoInfo)row.DataBoundItem);
                        if (idSave > 0)
                            listInt.Add(idSave);
                        else
                            break;
                    }

                    if (idSave > 0)
                    {
                        foreach (int item in listInt)
                            colecaoServico.Add(servicoNegocio.ConsultarServicoPorOs(item));

                        PreencherGrid();
                        saved = true;
                    }
                    else
                        MessageBox.Show("Falha ao tentar salvar!");
                }
            }
            else
                FormMessage.ShowMessegeWarning("Insira uma Ordem de serviço para poder salvar!");
        }

        private void PreencherGrid()
        {
            dataGridViewServico.DataSource = null;
            dataGridViewServico.DataSource = colecaoServico;

            ServGrarantia();
            FormMessage.ShowMessegeInfo("Serviço salvo com sucesso!");
            buttonSalvar.Enabled = false;
            groupBoxServico.Enabled = false;
            buttonRemover.Enabled = false;
            buttonImprimir.Enabled = true;
            buttonImprimir.Select();
        }

        private void buttonAddServico_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDescricao.Text))
            {
                if (!string.IsNullOrEmpty(textBoxResponsavel.Text))
                {
                    bool add = true;

                    ServicoInfo servicoInfo = new ServicoInfo
                    {
                        seridcliente = infoCliente.cliid,
                        seridend = infoEnd.IdEnd,
                        serid = 000000000,
                        serdescricao = textBoxDescricao.Text,
                        serobs = string.IsNullOrEmpty(textBoxObs.Text.Trim()) ? "NENHUMA OBSERVACAO" : textBoxObs.Text.Trim(),
                        serdataagend = dateTimePickerData.Value.Date,
                        sertaxa = radioButtonSim.Checked ? 0 : Convert.ToDecimal(textBoxTaxa.Text),
                        seridunid = Form1.Unidade.uniid,
                        seridfunc = Form1.User.useidfuncionario,
                        sergarantia = radioButtonSim.Checked,
                        serideletro = eletro,
                        seridtipo = tipo,
                        seridstatus = 1,
                        seridtecresp = Convert.ToInt32(textBoxCodTec.Text),
                        serdefeitodescricao = textBoxDefeito.Text
                    };

                    foreach (DataGridViewRow row in dataGridViewServico.Rows)
                    {
                        if (servicoInfo.serdescricao == Convert.ToString(row.Cells["colDescricao"].Value))
                            add = false;
                    }

                    if (add)
                    {

                        colecaoServico.Add(servicoInfo);
                        dataGridViewServico.DataSource = null;
                        dataGridViewServico.DataSource = colecaoServico;
                    }
                    else
                        FormMessage.ShowMessegeWarning("Este produto já foi adicionado");

                    textBoxDescricao.Clear();
                    textBoxDefeito.Clear();
                    buttonSalvar.Select();
                    buttonRemover.Enabled = true;
                    buttonSalvar.Enabled = true;
                }
                else
                {
                    FormMessage.ShowMessegeWarning("Selecione o técnico responsável pelo serviço!");
                    textBoxCodTec.Select();
                }
            }
            else
                FormMessage.ShowMessegeInfo("Preencher o campo Descrição!");
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            Selecionado();

            if (infoServ != null)
            {
                FormRelatorioFicha formRelatorioFicha = new FormRelatorioFicha(infoServ);
                formRelatorioFicha.Show(this);
            }
        }

        private void Selecionado()
        {
            if (dataGridViewServico.SelectedRows.Count > 0)
                infoServ = (ServicoInfo)dataGridViewServico.SelectedRows[0].DataBoundItem;
        }

        private void ServGrarantia()
        {
            Selecionado();

            if (dataGridViewServico.SelectedRows.Count > 0)
            {
                if (infoServ.sergarantia)
                    buttonNota.Enabled = true;
                else
                    buttonNota.Enabled = false;
            }
                
        }
        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (FormMessage.ShowMessegeQuestion("Deseja remover esta Ordem de Serviço?") == DialogResult.Yes)
            {
                if (dataGridViewServico.SelectedRows.Count > 0)
                {
                    ServicoColecao servicoCol = new ServicoColecao();

                    foreach (DataGridViewRow row in dataGridViewServico.Rows)
                        if (dataGridViewServico.SelectedRows[0].Index != row.Index)
                            servicoCol.Add((ServicoInfo)row.DataBoundItem);

                    dataGridViewServico.DataSource = null;
                    dataGridViewServico.DataSource = servicoCol;
                }
                else
                {
                    buttonAdd.Select();
                    buttonRemover.Enabled = false;
                }
            }
        }

        private void buttonFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxTaxa_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat((TextBox)sender);
        }

        private void FrmServico_Load(object sender, EventArgs e)
        {

            servicoNegocio = new ServicoNegocio(Form1.Empresa.empconexao);
            textBoxTaxa.Text = Convert.ToString(servicoNegocio.ConsultarTaxa());
            buttonCliente.Select();

            if (infoCliente != null)
                AbrirEletro();
        }

        private void buttonBuscarTec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCodTec.Text))
            {
                ConsultarResponsavel(colecaofunc);
            }
            else
            {
                responsavel = funcNegocios.ConsultarFuncPorId(ConvertNum(textBoxCodTec));

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
            buttonAddServico.Select();
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

            AbrirFormConsultar(form_ConsultarColecao);
        }

        private void AbrirFormConsultar(Form_ConsultarColecao form_ConsultarColecao)
        {
            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, "Técnico Responsável");
            formConsultar_Cod_Descricao.ShowDialog(this);

            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
            {
                textBoxCodTec.Text = formConsultar_Cod_Descricao.Selecionado.Cod;
                textBoxResponsavel.Text = formConsultar_Cod_Descricao.Selecionado.Descricao;
                
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

        private void textBoxCodTec_TextChanged(object sender, EventArgs e)
        {
            textBoxResponsavel.Clear();
        }

        private void ButtonCliente_Click(object sender, EventArgs e)
        {
            ServicoInfo servico = new ServicoInfo();
            FormClienteConsultar formClienteConsultar = new FormClienteConsultar(true);
            formClienteConsultar.ShowDialog(this);
            formClienteConsultar.Dispose();

            if (formClienteConsultar.DialogResult == DialogResult.Yes)
            {
                infoCliente = formClienteConsultar.SelecionadoCliente;
                PreencherForm();
            }
        }

        private void ButtonEnd_Click(object sender, EventArgs e)
        {
            FormEnderecoLista formEnderecoLista = new FormEnderecoLista(colecaoEnd);
            formEnderecoLista.ShowDialog(this);
            formEnderecoLista.Dispose();

            if (formEnderecoLista.DialogResult == DialogResult.Yes)
            {
                infoEnd = formEnderecoLista.SelecionandoEnd;
                PreencherEnd();
            }
        }

        private void TextBoxObs_Leave(object sender, EventArgs e)
        {
            buttonAddServico.Select();
        }

        private void ButtonNota_Click(object sender, EventArgs e)
        {
            FormNotaFiscal formNotaFiscal = new FormNotaFiscal(infoCliente);
            formNotaFiscal.ShowDialog(this);
            formNotaFiscal.Dispose();
        }

        private void DataGridViewServico_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ServGrarantia();
        }

        private void FrmServico_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (saved)
                this.DialogResult = DialogResult.Yes;
        }
    }
}

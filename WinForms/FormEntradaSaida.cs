using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Negocios;
using ObjTransfer;

namespace WinForms
{
    public partial class FormEntradaSaida : Form
    {
        Form1 form1 = new Form1();
        Thread thread;
        int confirmados = 0;
        string confirmar = string.Empty;
        string tipo = string.Empty;
        string categoria = string.Empty;

        EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios(Form1.Empresa.empconexao);
        GridEntradaSaidaColecao gridEntradaSaidaColecao;
        GridEntradaSaidaInfo saida;

        public FormEntradaSaida()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.AcceptButton = buttonBuscar;
        }

        private void FormEntradaSaida_Load(object sender, EventArgs e)
        {
            dateTimePickerInicial.Value = new  DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, 1);
            dateTimePickerFinal.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.DaysInMonth(DateTime.Now.Date.Year, DateTime.Now.Date.Month));
            comboBoxEntSai.SelectedIndex = 0;
            buttonBuscar.Select();
            //ExecutarConsulta();
        }

        private void ExecuntarConsultaThread()
        {
            EntradaSaidaPesquisar entradaSaidaPesquisar = new EntradaSaidaPesquisar
            {
                Confirmado = confirmar,
                DataFinal = dateTimePickerFinal.Value,
                DataInicial = dateTimePickerInicial.Value,
                Tipo = tipo,
                Categoria = categoria,
                Unidade = Form1.Unidade.uniid
            };

            gridEntradaSaidaColecao = new GridEntradaSaidaColecao();
            EntradaSaidaColecao consultLancamento = new EntradaSaidaColecao();
            consultLancamento = entradaSaidaNegocios.ConsultarEntradaLancamento(entradaSaidaPesquisar);

            if (consultLancamento != null)
            {
                foreach (EntradaSaidaInfo entra in consultLancamento)
                {
                    GridEntradaSaidaInfo gridEntradaSaidaInfo = new GridEntradaSaidaInfo
                    {
                        categoria = entra.entratipocatdecricao,
                        datapagamento = entra.entradatavenc,
                        entralancamentoid = entra.entraid,
                        obs = entra.entraobs,
                        parcelas = entra.entranumparcela + "/" + entra.entranumtotalparcelas,
                        strConfirmado = entra.entraconfirmada ? 'S' : 'N',
                        strEntradaSaida = entra.identradasaida == 1 ? 'E' : 'S',
                        valor = entra.entravalorpago,
                        tipo = entra.entraidtipoentrada
                    };

                    gridEntradaSaidaColecao.Add(gridEntradaSaidaInfo);
                }
            }

            Form1.encerrarThread = true;
        }
        
        private void PreencherGrid()
        {
            decimal entrada = 0;
            decimal saida = 0;
            decimal saldo = 0;


            dataGridViewEntradaSaida.DataSource = null;
            dataGridViewEntradaSaida.DataSource = gridEntradaSaidaColecao;

            if (gridEntradaSaidaColecao != null)
            {
                buttonExcluir.Enabled = true;
                buttonConfirmar.Enabled = true;
                buttonAbrir.Enabled = true;
            }

            foreach (DataGridViewRow row in dataGridViewEntradaSaida.Rows)
            {
                if (Convert.ToString(row.Cells["colEntSai"].Value) == "E")
                    entrada += Convert.ToDecimal(row.Cells["colValor"].Value);
                else
                    saida += Convert.ToDecimal(row.Cells["colValor"].Value);
            }

            labelSomaEntrada.Text = entrada.ToString("C");
            labelSomaSaida.Text = saida.ToString("C");
            saldo = entrada - saida;

            labelSomaSaldo.Text = (saldo).ToString("C");

            if ((saldo) > 0)
                labelSomaSaldo.ForeColor = Color.Green;
            else
                labelSomaSaldo.ForeColor = Color.Red;
            labelTotalItem.Text = dataGridViewEntradaSaida.Rows.Count.ToString();
            dataGridViewEntradaSaida.Select();
            Selecionado();
        }

        private void dataGridViewEntradaSaida_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && Convert.ToString(e.Value) == "S")
            {
                DataGridViewRow row = dataGridViewEntradaSaida.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.FromArgb(255, 245, 238);
                    cell.Style.ForeColor = Color.Red;
                }
            }
            else if(e.ColumnIndex == 1 && Convert.ToString(e.Value) == "E")
            {
                DataGridViewRow row = dataGridViewEntradaSaida.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.FromArgb(224, 255, 255);
                    cell.Style.ForeColor = Color.Green;
                }
            }
            
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ParametroPesquisar()
        {
            if (radioButtonAmbos.Checked)
                confirmados = 0;

            if (radioButtonConfirmado.Checked)
                confirmados = 1;

            if (radioButtonNotConfirmado.Checked)
                confirmados = 2;

            switch (confirmados)
            {
                case 0:
                    confirmar = "%";
                    break;
                case 1:
                    confirmar = "1";
                    break;
                case 2:
                    confirmar = "0";
                    break;
                default:
                    break;
            }

            switch (comboBoxEntSai.Text)
            {
                case "Entradas/Saídas":
                    tipo = "%";
                    break;
                case "Entradas":
                    tipo = "1";
                    break;
                case "Saídas":
                    tipo = "2";
                    break;
                default:
                    break;
            }

            if (int.TryParse(textBoxCategoriaCod.Text, out int cod))
            {
                if (cod > 0)
                    categoria = cod.ToString();
                else
                    categoria = "%";
            }
        }

        private void ExecutarConsulta()
        {
            ParametroPesquisar();
            thread = new Thread(ExecuntarConsultaThread);
            form1.ExecutarThread(thread);
            this.Activate();
            PreencherGrid();
            

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntradaSaida.SelectedRows.Count > 0)
            {
                GridEntradaSaidaInfo saida = (GridEntradaSaidaInfo)dataGridViewEntradaSaida.SelectedRows[0].DataBoundItem;

                if (saida.strConfirmado != 'S')
                {

                    FormLancamentosConfirmar formLancamentosConfirmar = new FormLancamentosConfirmar(saida);
                    formLancamentosConfirmar.ShowDialog(this);
                    formLancamentosConfirmar.Dispose();

                    if (formLancamentosConfirmar.DialogResult == DialogResult.Yes)
                        ExecutarConsulta();
                }
                else
                {
                    if (FormMessage.ShowMessegeQuestion("Este lancamento já foi confirmado! Deseja cancelar a confirmação?") == DialogResult.Yes)
                    {
                        thread = new Thread(AtualizarConselar);
                        form1.ExecutarThread(thread);
                        this.Activate();
                        FormMessage.ShowMessegeInfo("Alteração realizada com sucesso! Abra o lançamento novamente...");
                        ExecutarConsulta();
                    }
                }
            }
            else
                FormMessage.ShowMessegeInfo("Selecione um lançamento da lista!");
        }

        private void AtualizarConselar()
        {
            EntradaSaidaInfo ent = entradaSaidaNegocios.ConsultarEntradaSaidaId(saida.entralancamentoid);
            ent.entraconfirmada = false;
            entradaSaidaNegocios.UpdateEntradaSaidaLancamentoConfirmar(ent);
            Form1.encerrarThread = true;
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void Abrir()
        {
            if (dataGridViewEntradaSaida.SelectedRows.Count > 0)
            {
                GridEntradaSaidaInfo saida = (GridEntradaSaidaInfo)dataGridViewEntradaSaida.SelectedRows[0].DataBoundItem;
                FormLancamentos formLancamentos = new FormLancamentos(saida);
                formLancamentos.ShowDialog(this);
                formLancamentos.Dispose();

                if (formLancamentos.DialogResult == DialogResult.Yes)
                    ExecutarConsulta();
            }
            else
                FormMessage.ShowMessegeInfo("Selecione um lançamento da lista!");
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            if (caixa.VerificarCaixa())
            {
                FormLancamentos formLancamentos = new FormLancamentos(false);
                formLancamentos.ShowDialog(this);

                if (formLancamentos.DialogResult == DialogResult.Yes)
                    ExecutarConsulta();

                formLancamentos.Dispose();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntradaSaida.SelectedRows.Count > 0)
            {
                if (saida.strConfirmado == 'S')
                {
                    FormMessage.ShowMessegeWarning("Já foi confirmado o recebimento para este lançamento . " +
                        "Caso deseje cancelar, é necessário cancelar este recebimento antes!");
                    return;
                }

                if (FormMessage.ShowMessegeQuestion("Deseja cancelar este lançamento?") == DialogResult.Yes)
                {
                    thread = new Thread(Desativar);
                    form1.ExecutarThread(thread);
                    this.Activate();
                    ExecutarConsulta();
                }
            }
            else
                FormMessage.ShowMessegeInfo("Selecione um lançamento da lista!");
        }

        private void Desativar()
        {
            entradaSaidaNegocios.DesativarEntradaSaidaLancamento(saida.entralancamentoid);
            Form1.encerrarThread = true;
        }

        private void comboBoxEntSai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ExecutarConsulta();
        }

        private void buttonCategoriaBuscar_Click(object sender, EventArgs e)
        {
            string tipo = string.Empty;

            switch (comboBoxEntSai.Text)
            {
                case "Entradas/Saídas":
                    tipo = "%";
                    break;
                case "Entradas":
                    tipo = "1";
                    break;
                case "Saídas":
                    tipo = "2";
                    break;
                default:
                    break;
            }

            CodDescricaoColecao codDescricaoColecao = entradaSaidaNegocios.ConsultarCategoriaEntradaSaidaId(tipo);

            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();

            Form_Consultar consultar = new Form_Consultar
            {
                Cod = string.Format("{0:000}", 0),
                Descricao = " Todas as categorias"
            };

            form_ConsultarColecao.Add(consultar);

            if (codDescricaoColecao != null)
            {
                foreach (CodDescricaoInfo cod in codDescricaoColecao)
                {
                    Form_Consultar form_Consultar = new Form_Consultar
                    {
                        Cod = string.Format("{0:000}", cod.cod),
                        Descricao = cod.descricao
                    };

                    form_ConsultarColecao.Add(form_Consultar);
                }
            }

            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, "Categorias");
            formConsultar_Cod_Descricao.ShowDialog(this);

            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
            {
                textBoxCategoriaCod.Text = formConsultar_Cod_Descricao.Selecionado.Cod;
                labelCategoriaDescricao.Text = formConsultar_Cod_Descricao.Selecionado.Descricao;
                buttonBuscar.Select();
            }
        }

        private void textBoxCategoriaCod_TextChanged(object sender, EventArgs e)
        {
            comboBoxEntSai.SelectedIndex = 0;
            labelCategoriaDescricao.Text = "";
        }

        private void textBoxCategoriaCod_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCategoriaCod.Text))
            {
                textBoxCategoriaCod.Text = "000";
            }
            else
            {
                if (int.TryParse(textBoxCategoriaCod.Text, out int cod))
                {
                    if (cod > 0)
                    {
                        CodDescricaoInfo codDescricaoInfo = entradaSaidaNegocios.ConsultarEntradaSaidaCategoriaId(cod);

                        if (codDescricaoInfo != null)
                        {
                            textBoxCategoriaCod.Text = string.Format("{0:000}", codDescricaoInfo.cod);
                            labelCategoriaDescricao.Text = codDescricaoInfo.descricao;
                            buttonBuscar.Select();
                        }
                        else
                        {
                            FormMessage.ShowMessegeWarning("Código não identificado!");
                            textBoxCategoriaCod.Text = "000";
                            labelCategoriaDescricao.Text = "Todas as categorias";
                            textBoxCategoriaCod.Select();
                        }
                    }
                }
            }
        }

        private void dataGridViewEntradaSaida_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecionado();
        }

        private void Selecionado()
        {
            if (gridEntradaSaidaColecao != null)
            {
                if (dataGridViewEntradaSaida.SelectedRows.Count > 0)
                {
                    saida = (GridEntradaSaidaInfo)dataGridViewEntradaSaida.SelectedRows[0].DataBoundItem;

                    if (saida.tipo == 1)
                    {
                        buttonConfirmar.Enabled = true;
                        buttonExcluir.Enabled = true;
                    }
                    else
                    {
                        buttonConfirmar.Enabled = false;
                        buttonExcluir.Enabled = false;
                    }
                }
            }
        }

        private void FormEntradaSaida_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:

                    if (this.ActiveControl.Equals(dataGridViewEntradaSaida))
                        Abrir();
                    break;
                default:
                    break;
            }
        }
        
        private void dataGridViewEntradaSaida_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Selecionado();
        }
    }
}

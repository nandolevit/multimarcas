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
    public partial class FormEntradaSaida : Form
    {
        EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios(Form1.Empresa.empconexao);
        EntradaSaidaInfo entradaSaidaInfo;

        public FormEntradaSaida()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void FormEntradaSaida_Load(object sender, EventArgs e)
        {
            dateTimePickerInicial.Value = DateTime.Now.Date;
            dateTimePickerFinal.Value = DateTime.Now.Date.Date;
            comboBoxEntSai.SelectedIndex = 0;
            
            foreach (DataGridViewColumn col in dataGridViewEntradaSaida.Columns)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            ExecutarConsulta();
        }

        private void PreencherGrid()
        {
            int confirmados = 0;
            string confirmar = string.Empty;
            string tipo = string.Empty;
            string categoria = string.Empty;

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

            EntradaSaidaPesquisar entradaSaidaPesquisar = new EntradaSaidaPesquisar
            {
                Confirmado = confirmar,
                DataFinal = dateTimePickerFinal.Value,
                DataInicial = dateTimePickerInicial.Value,
                Tipo = tipo,
                Categoria = categoria,
                Unidade = Form1.Unidade.uniid
            };

            EntradaSaidaColecao consultLancamento = new EntradaSaidaColecao();
            consultLancamento = entradaSaidaNegocios.ConsultarEntradaLancamento(entradaSaidaPesquisar);
            GridEntradaSaidaColecao gridEntradaSaidaColecao = new GridEntradaSaidaColecao();

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
                        strEntradaSaida = entra.entsaitipoidentradasaida == 1 ? 'R' : 'D',
                        valor = entra.entravalorpago
                    };

                    gridEntradaSaidaColecao.Add(gridEntradaSaidaInfo);
                }
            }

            dataGridViewEntradaSaida.DataSource = null;
            dataGridViewEntradaSaida.DataSource = gridEntradaSaidaColecao;

            decimal entrada = 0;
            decimal saida = 0;
            decimal saldo = 0;

            foreach (DataGridViewRow row in dataGridViewEntradaSaida.Rows)
            {
                if (Convert.ToString(row.Cells["colEntSai"].Value) == "R")
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

            dataGridViewEntradaSaida.ClearSelection();
        }

        private void dataGridViewEntradaSaida_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            int num;
            num = e.RowIndex;

            if (e.ColumnIndex == 1 && Convert.ToString(e.Value) == "D")
            {
                DataGridViewRow row = dataGridViewEntradaSaida.Rows[num];
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.FromArgb(255, 245, 238);
                    cell.Style.ForeColor = Color.Red;
                }
            }
            else if(e.ColumnIndex == 1 && Convert.ToString(e.Value) == "R")
            {
                DataGridViewRow row = dataGridViewEntradaSaida.Rows[num];
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

        private void ExecutarConsulta()
        {
            if (DateTime.Compare(dateTimePickerInicial.Value, dateTimePickerFinal.Value) <= 0)
            {
                PreencherGrid();
                labelTotalItem.Text = dataGridViewEntradaSaida.Rows.Count.ToString();
                if (dataGridViewEntradaSaida.Rows.Count > 0)
                {
                    buttonExcluir.Enabled = true;
                    buttonConfirmar.Enabled = true;
                    buttonAbrir.Enabled = true;
                }
            }
            else
                FormMessage.ShowMessegeWarning("Intervalo de datas é inválido!");
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntradaSaida.SelectedRows.Count > 0)
            {
                if (!entradaSaidaInfo.entraconfirmada)
                {
                    FormLancamentosConfirmar formLancamentosConfirmar = new FormLancamentosConfirmar(entradaSaidaInfo);
                    formLancamentosConfirmar.ShowDialog();

                    if (formLancamentosConfirmar.DialogResult == DialogResult.Yes)
                        ExecutarConsulta();

                    formLancamentosConfirmar.Dispose();
                }
                else
                {
                    if (FormMessage.ShowMessegeQuestion("Este lancamento já foi confirmado! Deseja cancelar a confirmação?") == DialogResult.Yes)
                    {
                        if (entradaSaidaNegocios.UpdateEntradaLancamentoCancelarConfirmar(entradaSaidaInfo.entraid) > 0)
                        {
                            FormMessage.ShowMessegeInfo("Alteração realizada com sucesso! Abra o lançamento novamente...");
                            ExecutarConsulta();
                        }
                    }
                }
            }
            else
                FormMessage.ShowMessegeInfo("Selecione um lançamento da lista!");
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntradaSaida.SelectedRows.Count > 0)
            {
                FormLancamentos formLancamentos = new FormLancamentos((GridEntradaSaidaInfo)dataGridViewEntradaSaida.SelectedRows[0].DataBoundItem);
                formLancamentos.ShowDialog(this);

                if (formLancamentos.DialogResult == DialogResult.Yes)
                    ExecutarConsulta();

                formLancamentos.Dispose();
            }
            else
                FormMessage.ShowMessegeInfo("Selecione um lançamento da lista!");
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            FormLancamentos formLancamentos = new FormLancamentos(false);
            formLancamentos.ShowDialog();

            if (formLancamentos.DialogResult == DialogResult.Yes)
                ExecutarConsulta();

            formLancamentos.Dispose();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntradaSaida.SelectedRows.Count > 0)
            {
                if (entradaSaidaInfo.entraconfirmada)
                {
                    FormMessage.ShowMessegeWarning("Já foi confirmado o recebimento para este lançamento . " +
                        "Caso deseje cancelar, é necessário cancelar este recebimento antes!");
                    return;
                }

                if (FormMessage.ShowMessegeQuestion("Deseja cancelar este lançamento?") == DialogResult.Yes)
                {
                    if (entradaSaidaNegocios.DesativarEntradaSaidaLancamento(entradaSaidaInfo.entraid) > 0)
                        ExecutarConsulta();
                    else
                        FormMessage.ShowMessegeWarning("Falha ao tentar cancelar, tente novamente!");
                }
            }
            else
                FormMessage.ShowMessegeInfo("Selecione um lançamento da lista!");
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
            formConsultar_Cod_Descricao.ShowDialog();

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

        private void dataGridViewEntradaSaida_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntradaSaida.SelectedRows.Count > 0)
            {
                GridEntradaSaidaInfo gridEntradaSaidaInfo = dataGridViewEntradaSaida.SelectedRows[0].DataBoundItem as GridEntradaSaidaInfo;
                entradaSaidaInfo = entradaSaidaNegocios.ConsultarEntradaSaidaId(gridEntradaSaidaInfo.entralancamentoid);

                if (entradaSaidaInfo.entralancamentotipo > 0)
                {
                    buttonConfirmar.Enabled = false;
                    buttonExcluir.Enabled = false;
                }
                else
                {
                    buttonConfirmar.Enabled = true;
                    buttonExcluir.Enabled = true;
                }
            }
        }
    }
}

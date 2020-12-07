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
using System.Threading;

namespace WinForms
{
    public partial class FormRelatorioVendaVendedor : Form
    {
        Form1 form1 = new Form1();
        Thread thread;
        VendaInfo vendaInfo;
        GridViewComissaoInfo gridViewComissaoInfo;
        GridViewComissaoColecao gridViewComissaoColecao;
        VendaNegocios vendaNegocios = new VendaNegocios(Form1.Empresa.empconexao);
        FuncNegocios funcNegocios = new FuncNegocios(Form1.Empresa.empconexao);
        decimal valor;
        decimal dbQuant;
        int combo;
        int comboFunc;
        DateTime dataIni;
        DateTime dataFim;

        public FormRelatorioVendaVendedor()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            PreencherComboBoxFunc();
            dateTimePickerIni.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePickerFinal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            textBoxPorcento.Text = "1,00";
            this.AcceptButton = buttonBuscar;
        }

        private void ConsultarComissaoThread()
        {
            if (combo == 0)
                gridViewComissaoColecao = vendaNegocios.ConsultarVendaDetalhesTodosFunc(dataIni.Date, dataFim.Date);
            else
                gridViewComissaoColecao = vendaNegocios.ConsultarVendaDetalhesIdFunc(comboFunc, dataIni.Date, dataFim.Date);
            Form1.encerrarThread = true;
        }

        private void ConsultarComissao()
        {
            GridFormatComissao();
            PreencherGrid();
        }

        private void ConsultarComissaoDetalhada()
        {
            GridFormatComissaoDetalhada();
            PreencherGrid();
            CalcularPorcentagem();
        }

        private void PreencherGrid()
        {
            valor = 0;
            dbQuant = 0;

            if (gridViewComissaoColecao != null)
            {
                dataGridViewComissao.DataSource = null;
                dataGridViewComissao.DataSource = gridViewComissaoColecao;

                foreach (GridViewComissaoInfo comissao in gridViewComissaoColecao)
                {
                    valor += comissao.Valor;
                    dbQuant += comissao.Quant;
                }

                labelValorTotal.Text = valor.ToString("C2");
                labelQuantValor.Text = string.Format("{0:000}", dbQuant);
                buttonAbrir.Enabled = true;
                dataGridViewComissao.Select();
            }
            else
            {
                GridViewComissaoInfo gridViewComissaoInfo = new GridViewComissaoInfo
                {
                    DescricaoProduto = "Nada foi encontrado neste período!"
                };

                gridViewComissaoColecao = new GridViewComissaoColecao();
                gridViewComissaoColecao.Add(gridViewComissaoInfo);
                dataGridViewComissao.DataSource = null;
                dataGridViewComissao.DataSource = gridViewComissaoColecao;
                labelValorTotal.Text = 0.ToString("C2");
                labelQuantValor.Text = string.Format("{0:000}", 0);
                buttonAbrir.Enabled = false;
            }
        }

        private void CalcularPorcentagem()
        {
            labelComissao.Text = string.Format("{0:C2}", (valor * (Convert.ToDecimal(textBoxPorcento.Text) / 100)));
        }

        private void PreencherComboBoxFunc()
        {
            FuncColecao funcColecao = new FuncColecao();
            FuncInfo funcInfo = new FuncInfo
            {
                funId = 0,
                funNome = "*RESUMO - TODOS FUNCIONÁRIOS*"
            };

            funcColecao.Add(funcInfo);

            FuncColecao colecao = funcNegocios.ConsultatFuncTotal();

            foreach (FuncInfo func in colecao)
                funcColecao.Add(func);

            comboBoxNome.DisplayMember = "funnome";
            comboBoxNome.ValueMember = "funid";
            comboBoxNome.DataSource = funcColecao;
        }

        private void GridFormatComissao()
        {
            dataGridViewComissao.DataSource = null;
            dataGridViewComissao.Columns.Clear();
            dataGridViewComissao.ColumnCount = 4;
            dataGridViewComissao.Columns[0].Name = "Cod:";
            dataGridViewComissao.Columns[1].Name = "Nome:";
            dataGridViewComissao.Columns[2].Name = "Quant:";
            dataGridViewComissao.Columns[3].Name = "Valor vendido:";

            dataGridViewComissao.Columns[0].DisplayIndex = 0;
            dataGridViewComissao.Columns[1].DisplayIndex = 1;
            dataGridViewComissao.Columns[2].DisplayIndex = 2;
            dataGridViewComissao.Columns[3].DisplayIndex = 3;

            dataGridViewComissao.Columns[0].Width = 50;
            dataGridViewComissao.Columns[1].Width = 900;
            dataGridViewComissao.Columns[2].Width = 75;
            dataGridViewComissao.Columns[3].Width = 200;

            dataGridViewComissao.Columns[0].DataPropertyName = "IdProduto";
            dataGridViewComissao.Columns[1].DataPropertyName = "DescricaoProduto";
            dataGridViewComissao.Columns[2].DataPropertyName = "Quant";
            dataGridViewComissao.Columns[3].DataPropertyName = "Valor";

            dataGridViewComissao.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewComissao.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewComissao.Columns[0].DefaultCellStyle.Format = "00000";
            dataGridViewComissao.Columns[3].DefaultCellStyle.Format = "C2";
        }

        private void GridFormatComissaoDetalhada()
        {

            dataGridViewComissao.DataSource = null;
            dataGridViewComissao.Columns.Clear();
            dataGridViewComissao.ColumnCount = 9;
            dataGridViewComissao.Columns[0].Name = "Cod.:";
            dataGridViewComissao.Columns[1].Name = "Produto:";
            dataGridViewComissao.Columns[2].Name = "Categoria/Subcategoria:";
            dataGridViewComissao.Columns[3].Name = "Quant:";
            dataGridViewComissao.Columns[4].Name = "Valor Unit:";
            dataGridViewComissao.Columns[5].Name = "Valor:";
            dataGridViewComissao.Columns[6].Name = "Venda:";
            dataGridViewComissao.Columns[7].Name = "Data:";
            dataGridViewComissao.Columns[8].Name = "Marca:";
            
            dataGridViewComissao.Columns[0].DisplayIndex = 2;
            dataGridViewComissao.Columns[1].DisplayIndex = 3;
            dataGridViewComissao.Columns[2].DisplayIndex = 5;
            dataGridViewComissao.Columns[3].DisplayIndex = 6;
            dataGridViewComissao.Columns[4].DisplayIndex = 7;
            dataGridViewComissao.Columns[5].DisplayIndex = 8;
            dataGridViewComissao.Columns[6].DisplayIndex = 0;
            dataGridViewComissao.Columns[7].DisplayIndex = 1;
            dataGridViewComissao.Columns[8].DisplayIndex = 4;

            dataGridViewComissao.Columns[0].Width = 50;
            dataGridViewComissao.Columns[1].Width = 400;
            dataGridViewComissao.Columns[2].Width = 200;
            dataGridViewComissao.Columns[3].Width = 75;
            dataGridViewComissao.Columns[4].Width = 100;
            dataGridViewComissao.Columns[5].Width = 100;
            dataGridViewComissao.Columns[6].Width = 65;
            dataGridViewComissao.Columns[7].Width = 100;
            dataGridViewComissao.Columns[8].Width = 150;

            dataGridViewComissao.Columns[0].DataPropertyName = "IdProduto";
            dataGridViewComissao.Columns[1].DataPropertyName = "DescricaoProduto";
            dataGridViewComissao.Columns[2].DataPropertyName = "CategoriaSub";
            dataGridViewComissao.Columns[3].DataPropertyName = "Quant";
            dataGridViewComissao.Columns[4].DataPropertyName = "ValorUnit";
            dataGridViewComissao.Columns[5].DataPropertyName = "Valor";
            dataGridViewComissao.Columns[6].DataPropertyName = "IdVenda";
            dataGridViewComissao.Columns[7].DataPropertyName = "DataVenda";
            dataGridViewComissao.Columns[8].DataPropertyName = "Marca";

            dataGridViewComissao.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewComissao.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewComissao.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewComissao.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewComissao.Columns[0].DefaultCellStyle.Format = "00000";
            dataGridViewComissao.Columns[6].DefaultCellStyle.Format = "0000000";
            dataGridViewComissao.Columns[4].DefaultCellStyle.Format = "C2";
            dataGridViewComissao.Columns[5].DefaultCellStyle.Format = "C2";
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            combo = comboBoxNome.SelectedIndex;
            dataIni = dateTimePickerIni.Value.Date;
            dataFim = dateTimePickerFinal.Value.Date;
            comboFunc = Convert.ToInt32(comboBoxNome.SelectedValue);

            thread = new Thread(ConsultarComissaoThread);
            form1.ExecutarThread(thread);
            this.Activate();

            if (combo == 0)
            {
                ConsultarComissao();
                groupBoxComissao.Visible = false;
            }
            else
            {

                ConsultarComissaoDetalhada();
                groupBoxComissao.Visible = true;
                buttonAbrir.Visible = true;
            }
        }

        private void textBoxPorcento_TextChanged(object sender, EventArgs e)
        {
            labelComissao.Text = "";
            FormTextoFormat.MoedaFormat((TextBox)sender);
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            CalcularPorcentagem();
        }

        private void comboBoxNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewComissao.DataSource = null;
            groupBoxComissao.Visible = false;
            buttonAbrir.Visible = false;
            labelValorTotal.Text = 0.ToString("C2");
            labelQuantValor.Text = string.Format("{0:000}", 0);
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void Abrir()
        {
            if (dataGridViewComissao.SelectedRows.Count > 0 && combo > 0)
            {
                gridViewComissaoInfo = (GridViewComissaoInfo)dataGridViewComissao.SelectedRows[0].DataBoundItem;

                thread = new Thread(AbrirVendaThread);
                form1.ExecutarThread(thread);
                this.Activate();
                AbrirVenda(vendaInfo);
            }
        }

        private void AbrirVendaThread()
        {
            vendaInfo = vendaNegocios.ConsultarVendaId(gridViewComissaoInfo.IdVenda);
            Form1.encerrarThread = true;
        }

        private void AbrirVenda(VendaInfo vendaInfo)
        {
            FormVenda formVenda = new FormVenda(vendaInfo);
            formVenda.ShowDialog(this);
            formVenda.Dispose();
        }

        private void FormRelatorioVendaVendedor_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void FormRelatorioVendaVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Abrir();
                    break;
                default:
                    break;
            }
        }
    }
}

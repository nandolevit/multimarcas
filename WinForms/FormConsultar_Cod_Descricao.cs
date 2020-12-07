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

namespace WinForms
{
    public partial class FormConsultar_Cod_Descricao : Form
    {
        public Form_Consultar Selecionado { get; set; }

        public FormConsultar_Cod_Descricao(Form_ConsultarColecao consultar, string titulo)
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.Text = titulo;

            for (int i = 0; i < dataGridViewConsultar.ColumnCount; i++)
                dataGridViewConsultar.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None; 

            dataGridViewConsultar.DataSource = consultar;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Selecionar()
        {
            if (dataGridViewConsultar.SelectedRows.Count > 0)
            {
                Selecionado = (Form_Consultar)dataGridViewConsultar.SelectedRows[0].DataBoundItem;
                DialogResult = DialogResult.Yes;
            }
            else
                FormMessage.ShowMessegeWarning("Selecione um item da lista!");
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void dataGridViewConsultar_DoubleClick(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void FormConsultar_Cod_Descricao_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Selecionar();
                return;
            }

            foreach (DataGridViewRow row in dataGridViewConsultar.Rows)
            {
                string nome = row.Cells[1].Value.ToString();

                if (nome[0].ToString() == e.KeyData.ToString())
                {
                    dataGridViewConsultar.CurrentCell = dataGridViewConsultar.Rows[row.Index].Cells[0];
                    dataGridViewConsultar.Select();
                    break;
                }

            }
        }

        private void FormConsultar_Cod_Descricao_Load(object sender, EventArgs e)
        {
            dataGridViewConsultar.Select();
        }

        private void DataGridViewConsultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

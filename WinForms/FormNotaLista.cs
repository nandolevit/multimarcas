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
    public partial class FormNotaLista : Form
    {
        NotaColecao colecaoNota;
        ClienteNegocios clienteNegocios = new ClienteNegocios(Form1.Empresa.empconexao);

        public NotaInfo SelecionadoNota { get; set; }

        public FormNotaLista(NotaColecao nota)
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.AcceptButton = buttonSelecionar;
            colecaoNota = nota;
            PreencherGridNota();
        }

        private void PreencherGridNota()
        {
            dataGridViewNota.DataSource = null;
            dataGridViewNota.DataSource = colecaoNota;
            dataGridViewNota.Select();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonNovo_Click(object sender, EventArgs e)
        {
            if (dataGridViewNota.SelectedRows.Count > 0)
            {
                SelecionadoNota = (NotaInfo)dataGridViewNota.SelectedRows[0].DataBoundItem;
                this.DialogResult = DialogResult.Yes;
            }
        }
    }
}

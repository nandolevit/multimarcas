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

namespace WinForms
{
    public partial class FormTaxa : Form
    {
        ServicoNegocio negServ;
        public FormTaxa()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void textBoxTaxa_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat(textBoxTaxa);
        }

        private void FormTaxa_Load(object sender, EventArgs e)
        {
            negServ = new ServicoNegocio(Form1.Empresa.empconexao);
            textBoxTaxa.Text = Convert.ToString(negServ.ConsultarTaxa());
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            negServ = new ServicoNegocio(Form1.Empresa.empconexao);
            if(negServ.UpdateTaxa(Convert.ToDecimal(textBoxTaxa.Text)))
            {
                FormMessage.ShowMessegeInfo("Taxa alterada com sucesso!");
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                FormMessage.ShowMessegeWarning("Falha ao tentar alterar...");
            }
        }
    }
}

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
    public partial class FormCupom : Form
    {
        Cupom cupom = new Cupom();
        VendaNegocios vendaNegocios = new VendaNegocios(Form1.Empresa.empconexao);
        string[] ArrCupom = new string[2];

        public FormCupom(int idVenda)
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            CriarCupom(idVenda);
            buttonTeste.Visible = false;
            textBoxTeste.Visible = false;
            labelTeste.Visible = false;
            buttonImprimir.Enabled = true;
            buttonImprimir.Select();
        }

        public FormCupom()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTeste.Text, out int cod))
            {
                //CriarCupom(cod);
                CriarCaixa(cod);
            }
            else
                FormMessage.ShowMessegeWarning("Insira um código válido!");

        }

        private void CriarCaixa(int idcaixa)
        {
            CaixaNegocios caixaNegocios = new CaixaNegocios(Form1.Empresa.empconexao);
            CaixaAbrirInfo caixaAbrirInfo = caixaNegocios.ConsultarCaixaPorId(idcaixa);
            ArrCupom[0] = cupom.CriarCupomCaixa(caixaAbrirInfo);
            PreencherForm(ArrCupom[0]);
        }

        private void CriarCupom(int id)
        {
            VendaInfo vendaInfo = vendaNegocios.ConsultarVendaId(id);

            if (vendaInfo != null)
            {
                ArrCupom = cupom.CriarCupom(vendaInfo);
                PreencherForm(ArrCupom[0] + ArrCupom[1]);
            }
            else
                FormMessage.ShowMessegeWarning("Nada foi encontrado!");
        }

        private void PreencherForm(string texto)
        {
            textBoxCupom.Text = texto;
            buttonImprimir.Enabled = true;
            buttonImprimir.Select();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            FormReportVenda formReportVenda = new FormReportVenda(ArrCupom);
            formReportVenda.Show();
        }

        private void textBoxTeste_TextChanged(object sender, EventArgs e)
        {
            buttonImprimir.Enabled = false;
            textBoxCupom.Clear();
        }
    }
}

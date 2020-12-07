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
    public partial class FormProdDesconto : Form
    {
        private decimal Valor { get; set; }
        public string Descricao { get; set; }
        public string[] valorFinal = new string[2];

        public FormProdDesconto()
        {
            Inicializar();
        }

        public FormProdDesconto(decimal valor, string descricao = "VALOR ACRÉSCIMO/DESCONTO")
        {
            Inicializar();
            Valor = valor;
            Descricao = descricao;
            PreencherForm();
        }
        
        private void PreencherForm()
        {
            labelDescricao.Text = Descricao;
            labelValorAtual.Text = Valor.ToString("C2");
        }

        //public FormProdDesconto(ProdutoInfo produtosInfo)
        //{
        //    Inicializar();
        //    produtos = produtosInfo;
        //    PreencherFormProd();
        //    booVenda = false;
        //}

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }
        private void radioButtonDecresc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDecresc.Checked)
                labelDef.Text = "Valor do desconto:";
            else
                labelDef.Text = "Valor do acréscimo:";

            Calcular();
            textBoxDesconto.Select();
        }
        
        private void Calcular()
        {
            if (decimal.TryParse(textBoxDesconto.Text, out decimal valor))
            {
                if (radioButtonDecresc.Checked)
                {
                    if (radioButtonPorcento.Checked)
                        labelValorDesconto.Text = (Valor * ((100 - valor) / 100)).ToString("C");
                    else
                        labelValorDesconto.Text = (Valor - valor).ToString("C");
                }
                else
                {
                    if (radioButtonPorcento.Checked)
                        labelValorDesconto.Text = (Valor * ((valor / 100) + 1)).ToString("C");
                    else
                        labelValorDesconto.Text = (Valor + valor).ToString("C");
                }
                
            }
        }

        private void textBoxDesconto_TextChanged(object sender, EventArgs e)
        {

            FormTextoFormat.MoedaFormat((TextBox)sender);
            Calcular();
        }

        private void radioButtonPorcento_CheckedChanged(object sender, EventArgs e)
        {
            Calcular();
            textBoxDesconto.Select();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            ConfirmarValor();
        }

        private void ConfirmarValor()
        {
            if (!string.IsNullOrEmpty(textBoxDesconto.Text))
            {
                if (radioButtonValor.Checked)
                    valorFinal[0] = textBoxDesconto.Text.Replace("R$", "");
                else
                    valorFinal[0] = textBoxDesconto.Text + "%";

                valorFinal[1] = labelValorDesconto.Text.Replace("R$", "");

                DialogResult = DialogResult.Yes;
            }
        }

        private void FormProdDesconto_Load(object sender, EventArgs e)
        {
            textBoxDesconto.Select();
        }

        private void FormProdDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ConfirmarValor();
        }
    }
}

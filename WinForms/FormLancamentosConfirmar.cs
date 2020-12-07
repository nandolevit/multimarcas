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
    public partial class FormLancamentosConfirmar : Form
    {
        Form1 form1 = new Form1();
        Thread thread;

        EntradaSaidaInfo ent;
        GridEntradaSaidaInfo grid;
        EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios(Form1.Empresa.empconexao);

        public FormLancamentosConfirmar(GridEntradaSaidaInfo entrada)
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            grid = entrada;
            thread = new Thread(Consultar);
            form1.ExecutarThread(thread);
            this.Activate();
        }

        private void Consultar()
        {
            ent = entradaSaidaNegocios.ConsultarEntradaSaidaId(grid.entralancamentoid);
            Form1.encerrarThread = true;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            ent.entravalorpago = Convert.ToDecimal(labelValorSaldo.Text.Replace("R$", ""));
            ent.entradatavenc = dateTimePickerData.Value;

            thread = new Thread(Atualizar);
            form1.ExecutarThread(thread);
            this.Activate();
            this.DialogResult = DialogResult.Yes;
        }

        private void Atualizar()
        {
            ent.entraconfirmada = true;
            entradaSaidaNegocios.UpdateEntradaSaidaLancamentoConfirmar(ent);
            Form1.encerrarThread = true;
        }

        private void FormLancamentosConfirmar_Load(object sender, EventArgs e)
        {
            labelValorParc.Text = string.Format("{0:C2}", ent.entravalor);
            labelValorSaldo.Text = string.Format("{0:C2}", ent.entravalorpago);
        }

        private void textBoxJuros_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat((TextBox)sender);
        }

        private void buttonJuros_Click(object sender, EventArgs e)
        {
            FormProdDesconto formProdDesconto = new FormProdDesconto(ent.entravalor, "LANÇAMENTO ACRÉSCIMO/DESCONTO");
            formProdDesconto.ShowDialog(this);
            formProdDesconto.Dispose();

            if (formProdDesconto.DialogResult == DialogResult.Yes)
                labelValorSaldo.Text = formProdDesconto.valorFinal[1];
        }
    }
}

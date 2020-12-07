using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjTransfer;

namespace WinForms
{
    public partial class FormVendaCancelar : Form
    {
        VendaInfo vendaInfo = new VendaInfo();
        VendaNegocios vendaNegocios = new VendaNegocios(Form1.Empresa.empconexao);

        public FormVendaCancelar(VendaInfo venda )
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            vendaInfo = venda;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDescricao.Text))
                FormMessage.ShowMessegeWarning("Insira o motivo do concelamento!");
            else
            {
                if (FormMessage.ShowMessegeQuestion("Deseja cancelar está venda?") == DialogResult.Yes)
                {
                    int cod = vendaNegocios.InsertVendaCancelada(Form1.User.useidfuncionario, vendaInfo.venid, textBoxDescricao.Text);
                    if (cod > 0)
                    {
                        ClienteNegocios clienteNegocios = new ClienteNegocios(Form1.Empresa.empconexao);
                        ClienteInfo clienteInfo = clienteNegocios.ConsultarClientePorId(vendaInfo.venidcliente);

                        string nome = string.Empty;

                        if (clienteInfo != null)
                            nome = clienteInfo.clinome;
                        else
                            nome = "CLIENTE AVULSO";

                        EntradaSaidaInfo entradaSaidaSalvar = new EntradaSaidaInfo
                        {
                            entracodtodasparcelas = 0,
                            entraconfirmada = true,
                            entradatalancamento = DateTime.Now,
                            entradatavenc = DateTime.Now.Date,
                            entradocumento = Convert.ToString(vendaInfo.venid),
                            entraid = 0,
                            entraidfunc = Form1.User.useidfuncionario,
                            entraidunidade = Form1.Unidade.uniid,
                            entranumparcela = 1,
                            entranumtotalparcelas = 1,
                            entraobs = "Controle da venda: " + string.Format("{0:000000000}", vendaInfo.venid) +  Environment.NewLine +
                           "Motivo do cancelamento:" + Environment.NewLine + textBoxDescricao.Text + Environment.NewLine  + 
                           "Cliente: " + nome + Environment.NewLine + "Cancelado por: " + Form1.User.usenome,
                            entratipocatdecricao = "",
                            entratipoidcat = 7, //caracterizado como estorno de venda
                            entravalor = vendaInfo.venvalor,
                            entravalorpago = vendaInfo.venvalor,
                            entraidtipoentrada = 4, //caraterizado como venda
                            entraparcelado = false,
                        };

                        EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios(Form1.Empresa.empconexao);
                        if (entradaSaidaNegocios.InsertEntradaSaidaLancamento(entradaSaidaSalvar) == 0)
                        {
                            FormMessage.ShowMessegeWarning("Falha, tente novamente!");
                            return;
                        }

                        this.DialogResult = DialogResult.Yes;
                    }
                }
            }
            
        }

        private void FormVendaCancelar_Load(object sender, EventArgs e)
        {
            labelNome.Text = Form1.User.usenome;
        }
    }
}

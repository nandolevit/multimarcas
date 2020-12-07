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
    public partial class FormCadTipoCategoria : Form
    {
        EntradaSaidaNegocios entradaSaida = new EntradaSaidaNegocios(Form1.Empresa.empconexao);

        public FormCadTipoCategoria(bool b)
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();

            if (b)
                radioButtonEntrada.Checked = true;
            else
                radioButtonSaida.Checked = true;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDescricao.Text))
                FormMessage.ShowMessegeWarning("Preencher o campo descrição!");
            else
            {
                if (FormMessage.ShowMessegeQuestion("Deseja salvar?") == DialogResult.Yes)
                {
                    int num = 0;

                    if (radioButtonEntrada.Checked)
                        num = 1;
                    else
                        num = 2;

                    TipoEntradaSaidaInfo tipoEntradaSaidaInfo = new TipoEntradaSaidaInfo
                    {
                        TipoDescricao = textBoxDescricao.Text.Trim(),
                        TipoEntSai = num
                    };

                    EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios(Form1.Empresa.empconexao);

                    if (entradaSaidaNegocios.InsertEntradaSaidaCategoria(tipoEntradaSaidaInfo) > 0)
                    {
                        FormMessage.ShowMessegeInfo("Salvo com sucesso!");
                        this.DialogResult = DialogResult.Yes;
                    }
                    else
                        FormMessage.ShowMessegeWarning("Falha ao tenta salvar!");
                }
            }
        }
    }
}

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
    public partial class FormParcelas : Form
    {
        Form1 form1 = new Form1();
        Thread thread;
        EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios(Form1.Empresa.empconexao);
        EntradaSaidaInfo entradaSaidaInfo = new EntradaSaidaInfo();
        EntradaSaidaColecao entraColecao = new EntradaSaidaColecao();

        public FormParcelas(EntradaSaidaInfo entrada)
        {
            InitializeComponent();
            entradaSaidaInfo = entrada;
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();

            foreach (DataGridViewColumn col in dataGridViewParcelas.Columns)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        }

        private void radioButtonFixo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFixo.Checked)
            {
                textBoxCorridos.Enabled = false;
            }
            else
            {
                textBoxCorridos.Enabled = true;
            }
        }

        private void buttonParcelas_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxParcelas.Text, out int parc))
            {
                for (int i = 0; i < parc; i++)
                {
                    DateTime data = radioButtonFixo.Checked ? entradaSaidaInfo.entradatavenc.AddMonths(i + 1) : entradaSaidaInfo.entradatavenc.AddDays(Convert.ToInt32(textBoxCorridos.Text) * (i + 1));

                    EntradaSaidaInfo parcelas = new EntradaSaidaInfo
                    {
                        entracodtodasparcelas = entradaSaidaInfo.entraid,
                        entradatavenc = data,
                        entraidfunc = Form1.User.useidfuncionario,
                        entraidunidade = entradaSaidaInfo.entraidunidade,
                        entranumparcela = i + 2,
                        entranumtotalparcelas = parc + 1,
                        entraobs = entradaSaidaInfo.entraobs,
                        entraparcelado = true,
                        entratipoidcat = entradaSaidaInfo.entratipoidcat,
                        entravalor = entradaSaidaInfo.entravalor,
                        entravalorpago = entradaSaidaInfo.entravalorpago,
                        entraidtipoentrada = entradaSaidaInfo.entraidtipoentrada
                            
                    };

                    entraColecao.Add(parcelas);
                }

                entradaSaidaInfo.entranumtotalparcelas = parc + 1;
                dataGridViewParcelas.DataSource = entraColecao;
                dataGridViewParcelas.ClearSelection();
                buttonParcelas.Enabled = false;
            }

            buttonSalvar.Enabled = true;
            
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            dataGridViewParcelas.DataSource = null;
            buttonParcelas.Enabled = true;
            buttonSalvar.Enabled = false;
            entraColecao = new EntradaSaidaColecao();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            thread = new Thread(Salvar);
            form1.ExecutarThread(thread);
            this.Activate();
            this.DialogResult = DialogResult.Yes;
        }

        private void Salvar()
        {
            foreach (EntradaSaidaInfo entra in entraColecao)
                entradaSaidaNegocios.InsertEntradaSaidaLancamento(entra);

            entradaSaidaNegocios.UpdateEntradaSaidaLancamentoParcelas(entradaSaidaInfo);

            Form1.encerrarThread = true;
        }
        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormParcelas_Load(object sender, EventArgs e)
        {
            
        }
    }
}

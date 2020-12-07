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
    public partial class FormConsultarServico : Form
    {
        Form1 form1 = new Form1();
        Thread thread;
        bool selecionado;
        string palavraPesquisa;
        string status;
        string atend;
        string garant;
        DateTime dataIni;
        DateTime dataFim;
        GridConsultarServicoListaColecao servicoColecao;
        ServicoNegocio servicoNegocio = new ServicoNegocio(Form1.Empresa.empconexao);
        
        public FormConsultarServico()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void FormConsultarServico_Load(object sender, EventArgs e)
        {
            if (Form1.Offline)
                checkBoxDetalhada.Enabled = false;

            textBoxPesquisar.Select();
        }

        private void PreencherComboboxAtendente()
        {
            FuncNegocios funcNegocios = new FuncNegocios(Form1.Empresa.empconexao);
            FuncColecao colecao = new FuncColecao();
            FuncColecao funcColecao = funcNegocios.ConsultatFuncTotal();

            FuncInfo funcInfo = new FuncInfo
            {
                funId = 0,
                funNome = "*TODOS ATENDENTES*"
            };

            colecao.Add(funcInfo);

            foreach (FuncInfo func in funcColecao)
                colecao.Add(func);

            comboBoxAtendente.DisplayMember = "funnome";
            comboBoxAtendente.ValueMember = "funid";
            comboBoxAtendente.DataSource = colecao;
        }

        private void PreencherComboboxStatus()
        {
            CodDescricaoColecao colecao = servicoNegocio.ConsultarStatus();
            CodDescricaoColecao codDescricao = new CodDescricaoColecao();

            CodDescricaoInfo descricao = new CodDescricaoInfo
            {
                cod = 0,
                descricao = "*TODOS STATUS*"
            };
            codDescricao.Add(descricao);
            foreach (CodDescricaoInfo cod in colecao)
                codDescricao.Add(cod);
            
            comboBoxStatus.DisplayMember = "descricao";
            comboBoxStatus.ValueMember = "cod";
            comboBoxStatus.DataSource = codDescricao;
        }

        private void ConsultarServicoTotal()
        {
            thread = new Thread(ConsultarServicoTotalThread);
            form1.ExecutarThread(thread);
            this.Activate();
            PreencherGridConsultar();

        }

        private void ConsultarServicoTotalThread()
        {
            servicoColecao = new GridConsultarServicoListaColecao();
            servicoColecao = servicoNegocio.ConsultarServico3meses();
            Form1.encerrarThread = true;
        }

        private void PreencherGridConsultar()
        {

            if (servicoColecao != null)
            {
                dataGridViewConsultar.DataSource = null;
                dataGridViewConsultar.DataSource = servicoColecao;
                labelCountLista.Text = "Total de itens listados: " + servicoColecao.Count();
                dataGridViewConsultar.Select();
            }
            else
            {
                GridConsultarServicoLista lista = new GridConsultarServicoLista
                {
                    Status = "Nada foi encontrado!"
                };

                servicoColecao = new GridConsultarServicoListaColecao();
                servicoColecao.Add(lista);
                dataGridViewConsultar.DataSource = null;
                dataGridViewConsultar.DataSource = servicoColecao;
                labelCountLista.Text = "Total de itens listados: 0";
                textBoxPesquisar.Select();
            }

            dataGridViewConsultar.Select();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consultar()
        {
            if (servicoColecao != null)
            {
                GridConsultarServicoLista lista = dataGridViewConsultar.SelectedRows[0].DataBoundItem as GridConsultarServicoLista;

                if (lista != null)
                {
                    FormServicoConsultar formServicoConsultar = new FormServicoConsultar(Convert.ToInt32(lista.Os));
                    formServicoConsultar.ShowDialog(this);
                    formServicoConsultar.Dispose();

                    if (formServicoConsultar.DialogResult == DialogResult.Yes)
                    {
                        if (checkBoxDetalhada.Checked)
                            PesquisaDetalhada();
                        else
                        {
                            if (string.IsNullOrEmpty(palavraPesquisa))
                                ConsultarServicoTotal();
                            else
                                Pesquisar();
                        }
                    }
                }
            }
            else
                FormMessage.ShowMessegeWarning("Selecionar um registro primeiro!");
        }

        private void LimparForm()
        {
            dataGridViewConsultar.DataSource = null;
            servicoColecao = null;
        }

        private void checkBoxDetalhada_CheckedChanged(object sender, EventArgs e)
        {

            LimparForm();

            if (checkBoxDetalhada.Checked)
            {
                groupBoxDetalhada.Enabled = true;
                groupBoxTipo.Enabled = false;

                PreencherComboboxStatus();
                PreencherComboboxAtendente();

            }
            else
            {
                groupBoxDetalhada.Enabled = false;
                groupBoxTipo.Enabled = true;
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            palavraPesquisa = textBoxPesquisar.Text;
            selecionado = radioButtonOs.Checked;

            if (!string.IsNullOrEmpty(palavraPesquisa))
            {
                thread = new Thread(ExecutarPesquisa);
                form1.ExecutarThread(thread);
                this.Activate();
                PreencherGridConsultar();
            }
            else
                ConsultarServicoTotal();

        }

        private void ExecutarPesquisa()
        {
            if (selecionado)
            {
                if (int.TryParse(palavraPesquisa, out int cod))
                    servicoColecao = servicoNegocio.ConsultarServicoListaOs(cod);
                else
                    FormMessage.ShowMessegeWarning("A forma de pesquisa é pela OS, ensira um valor válido!");
            }
            else
                servicoColecao = servicoNegocio.ConsultarOsPorNomeCliente(palavraPesquisa);

            Form1.encerrarThread = true;
        }

        private void radioButtonOs_CheckedChanged(object sender, EventArgs e)
        {
            LimparForm();
            textBoxPesquisar.Select();
            textBoxPesquisar.Clear();
        }

        private void FormConsultarServico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (checkBoxDetalhada.Checked)
                {

                }
                else
                {
                    if (this.ActiveControl.Equals(dataGridViewConsultar))
                        Consultar();
                    else
                        Pesquisar();
                }
            }
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void buttonPesquisarDetalhada_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(comboBoxStatus.SelectedValue) == 0)
                status = "%";
            else
                status = Convert.ToString(comboBoxStatus.SelectedValue);

            if (Convert.ToInt32(comboBoxAtendente.SelectedValue) == 0)
                atend = "%";
            else
                atend = Convert.ToString(comboBoxAtendente.SelectedValue);

            if (!checkBoxGarantia.Checked)
                garant = "%";
            else
                garant = "1";

            dataIni = dateTimePickerIni.Value;
            dataFim = dateTimePickerFim.Value;


            thread = new Thread(PesquisaDetalhada);
            form1.ExecutarThread(thread);
            this.Activate();
            PreencherGridConsultar();
        }

        private void PesquisaDetalhada()
        {
            servicoColecao = servicoNegocio.ConsultarServicoPeriodo(garant, atend, status, dataIni.Date, dataFim.Date);
            Form1.encerrarThread = true;
        }

        private void checkBoxGarantia_CheckedChanged(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void comboBoxAtendente_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void dateTimePickerIni_ValueChanged(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void dateTimePickerFim_ValueChanged(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void textBoxPesquisar_TextChanged(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void radioButtonNome_CheckedChanged(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void dataGridViewConsultar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Consultar();
        }

        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            FrmServico frmServico = new FrmServico();
            frmServico.ShowDialog(this);
            frmServico.Dispose();

            if (frmServico.DialogResult == DialogResult.Yes)
                ConsultarServicoTotal();

        }
    }
}

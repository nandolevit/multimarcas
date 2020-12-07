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
    public partial class FormLancamentos : Form
    {
        Form1 form1 = new Form1();

        FuncNegocios funcNegocios = new FuncNegocios(Form1.Empresa.empconexao);
        EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios(Form1.Empresa.empconexao);
        EntradaSaidaInfo entradaSaidaInfo;
        GridEntradaSaidaInfo grid;
        bool Diversos;
        bool alterar;
        int codCategoria;

        Thread thread;
        string obs;
        int cat;
        decimal valor;
        string nomeFunc;

        public FormLancamentos(bool diversos)
        {
            Inicializador();
            textBoxValor.Text = string.Format("{0:C}", 0);
            labelValorRecebido.Text = string.Format("{0:C}", 0);
            labelNumParcela.Text = "1";
            labelDataLanc.Text = DateTime.Now.ToLongDateString();
            buttonParcelas.Enabled = false;
            entradaSaidaInfo = null;
            labelSaldo.Text = "Valor a pagar:";
            Diversos = diversos;
            
        }

        public FormLancamentos(GridEntradaSaidaInfo entrada)
        {
            Inicializador();
            grid = entrada;
            thread = new Thread(Consultar);
            form1.ExecutarThread(thread);
            this.Activate();
            ConsultarLancamento();
            alterar = true;
        }

        private void Consultar()
        {
            entradaSaidaInfo = entradaSaidaNegocios.ConsultarEntradaSaidaId(grid.entralancamentoid);
            nomeFunc = funcNegocios.ConsultarFuncPorId(entradaSaidaInfo.entraidfunc).funNome;
            Form1.encerrarThread = true;
        }

        private void ConsultarLancamento()
        {
            
            if (entradaSaidaInfo.identradasaida == 1)
                radioButtonEntradas.Checked = true;
            else
                radioButtonSaidas.Checked = true;

            textBoxValor.Text =  entradaSaidaInfo.entravalor.ToString();
            textBoxObs.Text = entradaSaidaInfo.entraobs;
            dateTimePickerVenc.Value = entradaSaidaInfo.entradatavenc;
            labelDataLanc.Text = string.Format("{0:f}", entradaSaidaInfo.entradatalancamento);
            textBoxCodCat.Text = string.Format("{0:000}", entradaSaidaInfo.entratipoidcat);
            labelDescricao.Text = entradaSaidaInfo.entratipocatdecricao;
            labelNumParcela.Text = entradaSaidaInfo.entranumparcela + "/" + entradaSaidaInfo.entranumtotalparcelas;
            labelValorRecebido.Text = string.Format("{0:C2}", entradaSaidaInfo.entravalorpago);

            if (entradaSaidaInfo.entraparcelado)
                buttonParcelas.Enabled = false;

            if (entradaSaidaInfo.entraconfirmada)
            {
                buttonSalvar.Enabled = false;
                buttonParcelas.Enabled = false;
            }


            labelFunc.Text += nomeFunc;

            if (entradaSaidaInfo.entraidtipoentrada > 1)
                EnabledFormulario(false);

            if (entradaSaidaInfo.entraidtipoentrada == 1)
                textBoxObs.ReadOnly = true;
        }

        private void Inicializador()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            textBoxCodCat.LostFocus += new EventHandler(textBoxCodCat_LostFocus);
        }

        private void FormLancamentos_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (CamposObrigatorio())
            {
                obs = textBoxObs.Text;
                cat = Convert.ToInt32(textBoxCodCat.Text);
                valor = Convert.ToDecimal(textBoxValor.Text);
                thread = new Thread(Salvar);
                form1.ExecutarThread(thread);
                this.Activate();
                Fechar();
            }
        }

        private void Salvar()
        {
            string entradaSaida = string.Empty;

            if (radioButtonEntradas.Checked)
                entradaSaida = "[RECEBIMENTOS DIVERSOS] " + Environment.NewLine;
            else
                entradaSaida = "[PAGAMENTOS DIVERSOS] " + Environment.NewLine;

            EntradaSaidaInfo entradaSaidaSalvar = new EntradaSaidaInfo
            {
                entracodtodasparcelas = 0,
                entraconfirmada = Diversos,
                entradatalancamento = DateTime.Now,
                entradatavenc = dateTimePickerVenc.Value,
                entradocumento = "",
                entraid = entradaSaidaInfo == null ? 0 : entradaSaidaInfo.entraid,
                entraidfunc = Form1.User.useidfuncionario,
                entraidunidade = Form1.Unidade.uniid,
                entranumparcela = 1,
                entranumtotalparcelas = 1,
                entraobs = Diversos ? entradaSaida + obs : obs,
                entratipocatdecricao = "",
                entratipoidcat = cat,
                entravalor = valor,
                entravalorpago = valor,
                entraidtipoentrada = 1,
                entraparcelado = Diversos,
            };

            if (!alterar)
            {
                int id = entradaSaidaNegocios.InsertEntradaSaidaLancamento(entradaSaidaSalvar);

                if (id > 0)
                {
                    if (Diversos)
                    {
                        Caixa caixa = new Caixa();
                        CaixaTurnoInfo caixaTurnoInfo = caixa.ConsultarTurnoAberto();

                        EntradaDiversosInfo diversosInfo = new EntradaDiversosInfo
                        {
                            diversosidturno = caixaTurnoInfo.caixaturnoid,
                            diversosidentrada = id
                        };

                        entradaSaidaNegocios.InsertEntradaDiversos(diversosInfo);
                    }

                    if (entradaSaidaNegocios.UpdateEntradaSaidaLancamentoCodParcelas(id) > 0)
                    {
                        Form1.encerrarThread = true;
                        FormMessage.ShowMessegeInfo("Lançamento realizado com sucesso!");
                    }
                    else
                    {
                        Form1.encerrarThread = true;
                        FormMessage.ShowMessegeWarning("Falha ao tentar salvar!");
                    }
                }
                else
                {
                    Form1.encerrarThread = true;
                    FormMessage.ShowMessegeWarning("Falha ao tentar salvar!");
                }
            }
            else
            {
                if (FormMessage.ShowMessegeQuestion("Deseja salvar alterações?") == DialogResult.Yes)
                {
                    if (entradaSaidaNegocios.UpdateEntradaSaidaLancamento(entradaSaidaSalvar) > 0)
                    {
                        Form1.encerrarThread = true;
                        this.DialogResult = DialogResult.Yes;
                    }
                }
            }

            if (thread.IsAlive)
                Form1.encerrarThread = true;
        }
        
        private void Fechar()
        {
            if (Diversos)
                this.Close();
            else
                this.DialogResult = DialogResult.Yes;
        }

        private bool CamposObrigatorio()
        {
            string campos = string.Empty;
            bool confCampos = true;

            if (string.IsNullOrEmpty(textBoxCodCat.Text))
            {
                campos += "\nCategoria";
                confCampos = false;
            }

            if (string.IsNullOrEmpty(textBoxObs.Text))
            {
                campos += "\nObservações";
                confCampos = false;
            }

            if (!(Convert.ToDecimal(textBoxValor.Text) > 0))
            {
                campos += "\nValor do lançamento";
                confCampos = false;
            }

            if (confCampos)
                return confCampos;
            else
            {
                FormMessage.ShowMessegeWarning("Preenchar os campos abaixo: " + campos);
                return confCampos;
            }

        }

        private void EnabledFormulario(bool b)
        {
            groupBoxInfo.Enabled = b;
            textBoxCodCat.ReadOnly = !b;
            buttonCategoriaAdd.Enabled = b;
            dateTimePickerVenc.Enabled = b;
            textBoxValor.ReadOnly = !b;
            buttonCategoriaBuscar.Enabled = b;
            textBoxObs.ReadOnly = !b;
            buttonParcelas.Enabled = b;
        }

        private void textBoxValor_GotFocus(object sender, EventArgs e)
        {
            textBoxValor.Text = textBoxValor.Text.Replace("R$", "").Trim();
        }

        private void buttonParcelas_Click(object sender, EventArgs e)
        {
            FormParcelas formParcelas = new FormParcelas(entradaSaidaInfo);
            formParcelas.ShowDialog(this);

            if (formParcelas.DialogResult == DialogResult.Yes)
                this.DialogResult = DialogResult.Yes;

            formParcelas.Dispose();
        }
        
        private void textBoxCodCat_TextChanged(object sender, EventArgs e)
        {
            labelDescricao.Text = "";
        }

        private void textBoxCodCat_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCodCat.Text))
            {
                if (int.TryParse(textBoxCodCat.Text, out int cod))
                {
                    
                }
                else
                {
                    FormMessage.ShowMessegeWarning("Insira um código número!");
                    textBoxCodCat.Clear();
                    textBoxCodCat.Select();
                }
            }
        }

        private void radioButtonEntradas_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCodCat.Clear();
            labelDescricao.Text = "";
        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat((TextBox)sender);
        }

        private void buttonCategoriaBuscar_Click(object sender, EventArgs e)
        {
            string tipo = string.Empty;

            if (radioButtonEntradas.Checked)
                tipo = "1";
            else
                tipo = "2";

            CodDescricaoColecao codDescricaoColecao = entradaSaidaNegocios.ConsultarCategoriaEntradaSaidaId(tipo);

            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();

            if (codDescricaoColecao != null)
            {
                foreach (CodDescricaoInfo cod in codDescricaoColecao)
                {
                    Form_Consultar form_Consultar = new Form_Consultar
                    {
                        Cod = string.Format("{0:000}", cod.cod),
                        Descricao = cod.descricao
                    };

                    form_ConsultarColecao.Add(form_Consultar);
                }
            }
            
            string titulo = string.Empty;

            if (radioButtonEntradas.Checked)
                titulo = "Selecionar uma categoria de Entradas/Receitas";
            else
                titulo = "Selecionar uma categoria de Saídas/Despesas";

            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, titulo);
            formConsultar_Cod_Descricao.ShowDialog(this);

            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
            {
                codCategoria = Convert.ToInt16(formConsultar_Cod_Descricao.Selecionado.Cod);
                textBoxCodCat.Text = formConsultar_Cod_Descricao.Selecionado.Cod;
                labelDescricao.Text = formConsultar_Cod_Descricao.Selecionado.Descricao;
                textBoxValor.Select();
            }
            formConsultar_Cod_Descricao.Dispose();
        }

        private void buttonCategoriaAdd_Click(object sender, EventArgs e)
        {
            FormCadTipoCategoria formCadTipoCategoria = new FormCadTipoCategoria(radioButtonEntradas.Checked);
            formCadTipoCategoria.ShowDialog(this);
            formCadTipoCategoria.Dispose();
        }

        private void textBoxValor_Leave(object sender, EventArgs e)
        {
            labelValorRecebido.Text = textBoxValor.Text;
        }
    }
}

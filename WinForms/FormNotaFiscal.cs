using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Negocios;
using ObjTransfer;

namespace WinForms
{
    public partial class FormNotaFiscal : Form
    {
        Form1 form1 = new Form1();
        ClienteNegocios negocioCliente = new ClienteNegocios(Form1.Empresa.empconexao);
        ServicoNegocio negocioServ = new ServicoNegocio(Form1.Empresa.empconexao);
        AutorizadaNegocios negocioAut = new AutorizadaNegocios(Form1.Empresa.empconexao);

        Thread thread;
        NotaInfo infoNota;
        NotaColecao colecaoNota;
        ClienteInfo infoCliente;
        ProdEletroInfo infoEletro;

        public int NumNota { get; set; }
        int idSave;

        public FormNotaFiscal()
        {
            Inicializar();
        }

        public FormNotaFiscal(ClienteInfo cliente)
        {
            Inicializar();
            infoCliente = cliente;
            DefinirCliente();
        }

        public FormNotaFiscal(NotaInfo nota)
        {
            Inicializar();
            infoNota = nota;
            PreencherForm();
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.AcceptButton = buttonSalvar;
        }

        private void DefinirCliente()
        {
            textBoxNomeCliente.Text = infoCliente.clinome;
            textBoxNotaNome.Text = infoCliente.clinome;
            groupBoxNota.Enabled = true;
            groupBoxSelecionar.Enabled = true;
            buttonSalvar.Enabled = true;
            buttonAddLoja.Select();
        }

        private void ConsultarCliente()
        {
            infoCliente = negocioCliente.ConsultarClientePorId(infoNota.notIdCliente);
            infoEletro = negocioServ.ConsultarEletroNotaId(infoNota.notId);
            Form1.encerrarThread = true;
        }

        private void PreencherForm()
        {
            thread = new Thread(ConsultarCliente);
            form1.ExecutarThread(thread);
            this.Activate();
            DefinirCliente();

            textBoxCodEletro.Text = infoEletro.idCadEle.ToString();
            textBoxCodAutorizada.Text = infoNota.notIdAutorizada.ToString();
            textBoxCodLoja.Text = infoNota.notIdloja.ToString();
            textBoxNotaNome.Text = infoNota.notNome;
            textBoxNotaN.Text = infoNota.notNum;
            textBoxNotaS.Text = infoNota.notNumSerie;
            textBoxObs.Text = infoNota.notObs;
            textBoxData.Text = infoNota.notEmissao.ToString("ddd, dd 'de' MMMM 'de' yyyy").ToUpper();

            Autorizada_Leave();
            Eletro_Leave();
            Loja_Leave();
        }

        private void AbrirConsultarAutorizada()
        {
            AutorizadaColecao autorizadaColecao = negocioAut.ConsultarAutorizadaConfirm();
            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();
            Form_Consultar consultar = new Form_Consultar();

            if (autorizadaColecao != null)
            {
                foreach (AutorizadaInfo auto in autorizadaColecao)
                {
                    Form_Consultar form_Consultar = new Form_Consultar
                    {
                        Cod = string.Format("{0:000}", auto.autid),
                        Descricao = auto.autnome
                    };

                    form_ConsultarColecao.Add(form_Consultar);
                }
            }
                consultar = AbrirFormConsultar(form_ConsultarColecao, "Autorizadas");

                if (consultar != null)
                {
                    textBoxCodAutorizada.Text = consultar.Cod;
                    labelAutorizadaDescricao.Text = consultar.Descricao;
                    buttonBuscarEletro.Select();
                }
        }

        private void AbrirConsultarEletro(ClienteInfo cliente)
        {
            ProdEletroColecao prodEletroColecao = negocioServ.ConsultarEletroCliente(cliente.cliid);
            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();
            Form_Consultar consultar = new Form_Consultar();

            if (prodEletroColecao != null)
            {
                foreach (ProdEletroInfo eletro in prodEletroColecao)
                {
                    NotaInfo notaInfo = negocioServ.ConsultarvNotaEletroId(eletro.idCadEle);

                    if (notaInfo == null)
                    {
                        if (int.TryParse(textBoxCodAutorizada.Text, out int cod))
                        {
                            if (cod == eletro.idmarcacad)
                            {
                                Form_Consultar form_Consultar = new Form_Consultar
                                {
                                    Cod = string.Format("{0:000}", eletro.idCadEle),
                                    Descricao = eletro.descricao
                                };

                                form_ConsultarColecao.Add(form_Consultar);
                            }
                        }
                    }
                }

                consultar = AbrirFormConsultar(form_ConsultarColecao, "Eletros");

                if (consultar != null)
                {
                    textBoxCodEletro.Text = consultar.Cod;
                    labelEletroDescricao.Text = consultar.Descricao;
                    textBoxNotaNome.Select();
                }
            }
            else
            {
                FormCadEletro formCadProdCliente = new FormCadEletro(infoCliente);
                formCadProdCliente.ShowDialog(this);
                formCadProdCliente.Dispose();
            }
        }

        private void AbrirConsultarEletroLoja()
        {
            EletroLojaColecao eletroLojaColecao = negocioServ.ConsultarEletroLoja();
            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();
            Form_Consultar consultar = new Form_Consultar();

            if (eletroLojaColecao != null)
            {
                foreach (EletroLojaInfo eletro in eletroLojaColecao)
                {
                    Form_Consultar form_Consultar = new Form_Consultar
                    {
                        Cod = string.Format("{0:000}", eletro.LojId),
                        Descricao = eletro.LojDescricao
                    };

                    form_ConsultarColecao.Add(form_Consultar); 
                }

                consultar = AbrirFormConsultar(form_ConsultarColecao, "Lojas");

                if (consultar != null)
                {
                    textBoxCodLoja.Text = consultar.Cod;
                    labelLojaDescricao.Text = consultar.Descricao;
                    buttonBuscarAutorizada.Select();
                }
            }
        }

        private Form_Consultar AbrirFormConsultar(Form_ConsultarColecao form_ConsultarColecao, string nome)
        {
            Form_Consultar form_Consultar = new Form_Consultar();
            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, nome);
            formConsultar_Cod_Descricao.ShowDialog(this);
            formConsultar_Cod_Descricao.Dispose();

            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
            {
                form_Consultar.Cod = formConsultar_Cod_Descricao.Selecionado.Cod;
                form_Consultar.Descricao = formConsultar_Cod_Descricao.Selecionado.Descricao;

                return form_Consultar;
            }
            else
                return null;
        }

        private void textBoxCodEletro_Leave(object sender, EventArgs e)
        {
            Eletro_Leave();
        }

        private void Eletro_Leave()
        {
            if (!string.IsNullOrEmpty(textBoxCodEletro.Text))
            {
                if (int.TryParse(textBoxCodEletro.Text, out int cod))
                {
                    ProdEletroInfo prod = negocioServ.ConsultarEletroClienteId(infoCliente.cliid, cod);

                    if (prod != null)
                    {
                        if (int.TryParse(textBoxCodAutorizada.Text, out int aut))
                        {
                            if (prod.idmarcacad == aut)
                            {
                                textBoxCodEletro.Text = string.Format("{0:000}", prod.idCadEle);
                                labelEletroDescricao.Text = prod.descricao;
                            }
                            else
                                textBoxCodEletro.Clear();
                        }
                    }
                    else
                    {
                        textBoxCodEletro.Text = string.Empty;
                        labelEletroDescricao.Text = string.Empty;
                    }
                }
                else
                {
                    FormMessage.ShowMessegeWarning("Insira um valor numérico!");
                    textBoxCodEletro.Text = string.Empty;
                    labelEletroDescricao.Text = string.Empty;
                }
            }
        }
        private void textBoxCodLoja_Leave(object sender, EventArgs e)
        {
            Loja_Leave();
        }

        private void Loja_Leave()
        {
            if (!string.IsNullOrEmpty(textBoxCodLoja.Text))
            {
                if (int.TryParse(textBoxCodLoja.Text, out int cod))
                {
                    EletroLojaInfo loja = negocioServ.ConsultarEletroLojaId(cod);

                    if (loja != null)
                    {
                        textBoxCodLoja.Text = string.Format("{0:000}", cod);
                        labelLojaDescricao.Text = loja.LojDescricao;
                    }
                    else
                    {
                        textBoxCodLoja.Text = string.Empty;
                        labelLojaDescricao.Text = string.Empty;
                    }
                }
                else
                {
                    FormMessage.ShowMessegeWarning("Insira um valor numérico!");
                    textBoxCodLoja.Text = string.Empty;
                    labelLojaDescricao.Text = string.Empty;
                }
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCodAutorizada_Leave(object sender, EventArgs e)
        {
            Autorizada_Leave();
        }

        private void Autorizada_Leave()
        {
            if (!string.IsNullOrEmpty(textBoxCodAutorizada.Text))
            {
                if (int.TryParse(textBoxCodAutorizada.Text, out int cod))
                {
                    AutorizadaInfo auto = negocioServ.ConsultarAutorizadaId(cod);

                    if (auto != null)
                    {
                        textBoxCodAutorizada.Text = string.Format("{0:000}", cod);
                        labelAutorizadaDescricao.Text = auto.autnome;
                    }
                    else
                    {
                        textBoxCodAutorizada.Text = string.Empty;
                        labelAutorizadaDescricao.Text = string.Empty;
                    }
                }
                else
                {
                    FormMessage.ShowMessegeWarning("Insira um valor numérico!");
                    textBoxCodAutorizada.Text = string.Empty;
                    labelAutorizadaDescricao.Text = string.Empty;
                }
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBoxCodAutorizada.Text) || string.IsNullOrEmpty(textBoxCodEletro.Text) ||
                string.IsNullOrEmpty(textBoxCodLoja.Text) || string.IsNullOrEmpty(textBoxNotaNome.Text) || string.IsNullOrEmpty(textBoxNotaS.Text) ||
                string.IsNullOrEmpty(textBoxNotaN.Text)))
            {
                if (infoNota == null)
                {
                    PreencherNotaInfo();
                    thread = new Thread(Salvar);
                    form1.ExecutarThread(thread);
                    this.Activate();
                }
                else
                {
                    int idnota = infoNota.notId;
                    PreencherNotaInfo();
                    infoNota.notId = idnota;
                    thread = new Thread(Alterar);
                    form1.ExecutarThread(thread);
                    this.Activate();
                }

                if (idSave > 0)
                {
                    NumNota = idSave;
                    FormMessage.ShowMessegeInfo("Nota salva com sucesso!");
                    this.DialogResult = DialogResult.Yes;
                }
            }
            else
                FormMessage.ShowMessegeWarning("Preencher os campos obrigatórios!");
        }

        private void PreencherNotaInfo()
        {
            infoNota = new NotaInfo
            {
                notEmissao = Convert.ToDateTime(textBoxData.Text).Date,
                notIdAutorizada = Convert.ToInt32(textBoxCodAutorizada.Text),
                notIdCliente = infoCliente.cliid,
                notIdloja = Convert.ToInt32(textBoxCodLoja.Text),
                notNome = textBoxNotaNome.Text,
                notNumSerie = textBoxNotaS.Text,
                notNum = textBoxNotaN.Text,
                notObs = textBoxObs.Text,
                notIdFunc = Form1.User.useidfuncionario,
                notideletro = Convert.ToInt32(textBoxCodEletro.Text),
            };
        }

        private void Salvar()
        {
            idSave = negocioServ.InsertNota(infoNota);
            negocioServ.InsertNotaEletro(infoNota.notideletro, idSave);
            Form1.encerrarThread = true;
        }

        private void Alterar()
        {
            idSave = negocioServ.UpdateNota(infoNota);
            negocioServ.UpdateNotaEletro(infoNota.notideletro, idSave);
            Form1.encerrarThread = true;
        }

        private void buttonBuscarLoja_Click(object sender, EventArgs e)
        {
            AbrirConsultarEletroLoja();
        }

        private void buttonBuscarAutorizada_Click(object sender, EventArgs e)
        {
            AbrirConsultarAutorizada();
        }

        private void buttonAddAutorizada_Click(object sender, EventArgs e)
        {
            AutorizadaInfo autorizadaInfo = new AutorizadaInfo();
            FormCadastroPessoa formCadastroPessoa = new FormCadastroPessoa(autorizadaInfo);
            formCadastroPessoa.ShowDialog(this);
            formCadastroPessoa.Dispose();
        }

        private void buttonBuscarEletro_Click(object sender, EventArgs e)
        {
            AbrirConsultarEletro(infoCliente);
        }

        private void buttonAddEletro_Click(object sender, EventArgs e)
        {
            FormCadEletro formCadProdCliente = new FormCadEletro(infoCliente);
            formCadProdCliente.ShowDialog(this);
            formCadProdCliente.Dispose();
        }

        private void buttonAddLoja_Click(object sender, EventArgs e)
        {
            EletroLojaInfo eletroLojaInfo = new EletroLojaInfo();
            FormCadTexto formCadTexto = new FormCadTexto(eletroLojaInfo);
            formCadTexto.ShowDialog(this);
            formCadTexto.Dispose();
        }

        private void ButtonCliente_Click(object sender, EventArgs e)
        {
            ServicoInfo servico = new ServicoInfo();
            FormClienteConsultar formClienteConsultar = new FormClienteConsultar(true);
            formClienteConsultar.ShowDialog(this);
            formClienteConsultar.Dispose();

            if (formClienteConsultar.DialogResult == DialogResult.Yes)
            {
                infoCliente = formClienteConsultar.SelecionadoCliente;
                DefinirCliente();
            }
        }

        private void ButtonAddNiver_Click(object sender, EventArgs e)
        {
            FormAddData formAddData = new FormAddData();
            formAddData.ShowDialog(this);
            formAddData.Dispose();

            if (formAddData.DialogResult == DialogResult.Yes)
            {
                DateTime data = Convert.ToDateTime(formAddData.textoData);
                textBoxData.Text = data.ToString("ddd, dd 'de' MMMM 'de' yyyy").ToUpper();
                textBoxObs.Select();
            }
        }

        private void FormNotaFiscal_Load(object sender, EventArgs e)
        {
            buttonBuscarLoja.Select();
        }
    }
}

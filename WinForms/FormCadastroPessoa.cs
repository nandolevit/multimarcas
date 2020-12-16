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
using System.Diagnostics;

namespace WinForms
{
    public partial class FormCadastroPessoa : Form
    {
        Form1 form1 = new Form1();
        int modSave;
        int idSave;
        bool config = false;
        string cpf;
        int codCargo;

        Thread thread;
        FuncInfo infoFunc;
        ClienteInfo infoCliente;
        ClienteColecao colecaoCliente;
        EnderecoInfo infoEnd;
        AutorizadaInfo infoAutorizada;
        FornecedorInfo infoFornecedor;
        EnderecoColecao colecaoEndereco;

        ClienteNegocios negocioCliente = new ClienteNegocios(Form1.Empresa.empconexao);
        FuncNegocios funcNegocios = new FuncNegocios(Form1.Empresa.empconexao);
        EmpresaNegocios empresaNegocios = new EmpresaNegocios(Form1.Empresa.empconexao);
        ClienteNegocios clienteNegocios = new ClienteNegocios(Form1.Empresa.empconexao);
        AutorizadaNegocios autorizadaNegocios = new AutorizadaNegocios(Form1.Empresa.empconexao);
        FornecedorNegocios fornecedorNegocios = new FornecedorNegocios(Form1.Empresa.empconexao);
        

        //public FormCadastroPessoa()
        //{
        //    Inicializar();
        //}

        public FormCadastroPessoa(UnidadeInfo unidadeInfo)
        {
            Inicializar();
            modSave = 4;
            this.Text = "FUNCIONÁRIO";
            this.labelTitle.Text = "FUNCIONÁRIO";
            labelUnidadeDescricao.Visible = true;
            labelUnidade.Visible = true;
            config = true;
            buttonBuscarUnidade.Visible = false;
            labelUnidadeDescricao.Text = unidadeInfo.uniunidade;
        }

        public FormCadastroPessoa(FornecedorInfo fornecedor)
        {
            Inicializar();
            modSave = 3;
            this.Text = "FORNECEDOR";
            this.labelTitle.Text = "FORNECEDOR";
            buttonBuscarUnidade.Visible = false;
            labelUnidade.Visible = false;
            labelUnidadeDescricao.Visible = false;
        }

        public FormCadastroPessoa(FuncInfo func)
        {
            Inicializar();
            modSave = 2;
            this.Text = "FUNCIONÁRIO";
            this.labelTitle.Text = "FUNCIONÁRIO";
            labelUnidadeDescricao.Visible = true;
            labelUnidade.Visible = true;    
        }
        
        public FormCadastroPessoa(AutorizadaInfo autorizada)
        {
            Inicializar();
            modSave = 1;
            this.Text = "AUTORIZADA";
            this.labelTitle.Text = "AUTORIZADA";
            buttonBuscarUnidade.Visible = false;
            labelUnidade.Visible = false;
            labelUnidadeDescricao.Visible = false;
        }

        public FormCadastroPessoa(ClienteInfo cli)
        {
            Inicializar();
            modSave = 0;
            this.Text = "CLIENTE";
            this.labelTitle.Text = "CLIENTE";
            labelUnidadeDescricao.Visible = false;
            labelUnidade.Visible = false;
            buttonBuscarUnidade.Visible = false;
            infoCliente = cli;

            if (cli.cliid > 0)
                PreencherFormCliente();
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();

            if (Form1.Offline == true)
            {
                buttonEnd.Visible = false;
                linkLabelCep.Visible = false;
            }

            this.AcceptButton = buttonSalvar;
            buttonAlterar.Select();
        }

        private void ConsultarEndCliente()
        {
            colecaoEndereco = negocioCliente.ConsultarEnderecoPorIdCliente(infoCliente.cliid);

            if (colecaoEndereco != null)
                infoEnd = colecaoEndereco[0];

            Form1.encerrarThread = true;
        }

        private void PreencherFormEnd()
        {
            if (infoEnd != null)
            {
                textBoxBairro.Text = infoEnd.endBairro;
                maskedTextBoxCep.Text = infoEnd.Cep;
                textBoxCidade.Text = infoEnd.endCidade;
                textBoxComplemento.Text = infoEnd.Complemento;
                textBoxPontoReferencia.Text = infoEnd.PontoReferencia;
                textBoxLogradouro.Text = infoEnd.endLogradouro;
                textBoxUF.Text = infoEnd.endUf;
            }
            else
            {
                FormEnderecoLista formEnderecoLista = new FormEnderecoLista(infoCliente);
                formEnderecoLista.ShowDialog(this);
                formEnderecoLista.Dispose();
            }
        }

        private void PreencherFormClienteLuizFernando()
        {
            textBoxId.Text = "0";
            maskedTextBoxCpf.Text = "03195308509";
            textBoxEmail.Text = "nandolevit2012@gmail.com";
            textBoxNome.Text = "luiz fernando silva dos santos liberato";
            textBoxNiver.Text = "06/12/1987";

            maskedTextBoxTel1.Text = "71992776512";
            maskedTextBoxTel2.Text = "71986270119";

            textBoxBairro.Text = "tancredo neves";
            maskedTextBoxCep.Text = "41205270";
            textBoxCidade.Text = "salvador";
            textBoxComplemento.Text = "ed lua bela apto202 n85";
            textBoxPontoReferencia.Text = "conj novo arvoredo";
            textBoxLogradouro.Text = "alameda lua branca";
            textBoxUF.Text = "ba";
        }

        private void PreencherFormCliente()
        {
            thread = new Thread(ConsultarEndCliente);
            form1.ExecutarThread(thread);
            this.Activate();

            textBoxId.Text = string.Format("{0:000000}", infoCliente.cliid);
            maskedTextBoxCpf.Text = infoCliente.clicpf;
            textBoxEmail.Text = infoCliente.cliemail;
            textBoxNome.Text = infoCliente.clinome;
            textBoxNiver.Text = infoCliente.cliniver.ToString("ddd, dd 'de' MMMM 'de' yyyy").ToUpper();

            if (infoCliente.clitel.IndexOf('/') > 0)
            {
                string[] tel = infoCliente.clitel.Split('/');
                maskedTextBoxTel1.Text = tel[0];
                maskedTextBoxTel2.Text = tel[1];
            }
            else
                maskedTextBoxTel1.Text = infoCliente.clitel;

            PreencherFormEnd();

            groupBoxEnd.Enabled = false;
            maskedTextBoxCpf.Enabled = false;
            buttonAlterar.Visible = true;
        }

        private void SalvarUser(FuncInfo func)
        {
            UserNegocio userNegocio = new UserNegocio(Form1.Empresa.empconexao);
            UserInfo userInfo = new UserInfo
            {
                useidfuncionario = func.funId,
                uselogin = func.funCpf,
                usesenha = func.funCpf
            };

            userNegocio.InsertUser(userInfo);
        }

        private void SalvarFornecedor()
        {
            if (!string.IsNullOrEmpty(textBoxNome.Text))
            {
                PreencherFornecedorInfo();
                SalvarThread();
            }
            else
                FormMessage.ShowMessegeWarning("Insira no mínimo o nome do fornecedor!");
        }

        private void SalvarFunc()
        {
            if (!(string.IsNullOrEmpty(textBoxNome.Text) || string.IsNullOrEmpty(maskedTextBoxCpf.Text)))
            {
                PreencherFuncInfo();
                SalvarThread();

                //if (idSave > 0)
                //{
                //    if (modSave == 4)
                //    {
                //        FornecedorInfo forn = new FornecedorInfo
                //        {
                //            forNome = "PADRAO",
                //            forIdFunc = idSave,
                //            forpadrao = 1
                //        };

                //        fornecedorNegocios.InsertFornecedor(forn);
                //    }

                //    FormMessage.ShowMessegeInfo("Registro salvo com sucesso!");
                //    FormMessage.ShowMessegeInfo("Ao logar pela primeira vez, deverá inserir o proprio CPF, como LOGIN E SENHA!");
                //    funcInfo.funId = idSave;
                //    SalvarUser(funcInfo);
                //    buttonSalvar.Enabled = false;
                //    return true;
                //}
                //else
                //    return false;
            }
            else
            {
                FormMessage.ShowMessegeWarning("Insira no mínimo o nome e o cpf do funcionário e selecione uma unidade!");
                //return false;
            }
        }

        private void SalvarCliente()
        {
            if (CamposObrigatorios())
            {
                if (infoCliente.cliid == 0)
                {
                    PreencherClienteInfo();
                    SalvarThread();
                    
                    if (idSave > 0)
                    {

                        FormEnderecoLista formEnderecoLista = new FormEnderecoLista(infoCliente);
                        if (MessageBox.Show("Deseja adicionar outro endereço?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            formEnderecoLista.ShowDialog(this);


                        FormCadEletro formCadEletro = new FormCadEletro(infoCliente);
                        formCadEletro.ShowDialog(this);

                        //FormProdutoDefeito formProdutoDefeito = new FormProdutoDefeito(infoCliente);
                        //if (formCadEletro.DialogResult == DialogResult.Yes)
                        //    formProdutoDefeito.ShowDialog(this);

                        FrmServico frmServico = new FrmServico(infoCliente);
                        if (formCadEletro.DialogResult == DialogResult.Yes)
                        frmServico.ShowDialog(this);

                        frmServico.Dispose();
                        formCadEletro.Dispose();
                        formEnderecoLista.Dispose();
                        //formProdutoDefeito.Dispose();
                    }

                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    if (FormMessage.ShowMessegeQuestion("Deseja salvar as alterações?") == DialogResult.Yes)
                    {
                        int id = infoCliente.cliid;

                        PreencherClienteInfo();
                        infoCliente.cliid = id;
                        if (clienteNegocios.Alterar(infoCliente))
                        {
                            FormMessage.ShowMessegeInfo("Registro alterado com sucesso!");
                            this.DialogResult = DialogResult.Yes;
                        }
                        else
                            FormMessage.ShowMessegeWarning("Falha ao tentar salvar!");
                    }
                }
            }
        }

        private bool CamposObrigatorios()
        {
            string Nome, Tel, Email, Cep, Logradouro, Referencia, Complemento, Cidade, Bairro, Uf;
            Nome = textBoxNome.Text.Trim();
            Tel = maskedTextBoxTel1.Text.Trim();
            Email = textBoxEmail.Text.Trim();
            Cep = maskedTextBoxCep.Text.Trim();
            Logradouro = textBoxLogradouro.Text.Trim();
            Referencia = textBoxPontoReferencia.Text.Trim();
            Complemento  = textBoxComplemento.Text.Trim();
            Cidade = textBoxCidade.Text.Trim();
            Bairro = textBoxBairro.Text.Trim();
            Uf = textBoxUF.Text.Trim();


            if (String.IsNullOrEmpty(Nome) || String.IsNullOrEmpty(Tel) || String.IsNullOrEmpty(Email) || 
                String.IsNullOrEmpty(Cep) || String.IsNullOrEmpty(Logradouro) || String.IsNullOrEmpty(Referencia) ||
                String.IsNullOrEmpty(Complemento) || String.IsNullOrEmpty(Bairro) || String.IsNullOrEmpty(Cidade) ||
                String.IsNullOrEmpty(Uf))
            {
                if (String.IsNullOrEmpty(Nome))
                    labelNome.ForeColor = Color.Red;

                if (String.IsNullOrEmpty(Tel))
                    labelTel.ForeColor = Color.Red;

                if (String.IsNullOrEmpty(Email))
                    labelEmail.ForeColor = Color.Red;

                if (String.IsNullOrEmpty(Cep))
                    labelCep.ForeColor = Color.Red;

                if (String.IsNullOrEmpty(Logradouro))
                    labelLogradouro.ForeColor = Color.Red;

                if (String.IsNullOrEmpty(Referencia))
                    labelPontoReferencia.ForeColor = Color.Red;

                if (String.IsNullOrEmpty(Complemento))
                    labelComplemento.ForeColor = Color.Red;

                if (String.IsNullOrEmpty(Bairro))
                    labelBairro.ForeColor = Color.Red;

                if (String.IsNullOrEmpty(Cidade))
                    labelCidade.ForeColor = Color.Red;

                if (String.IsNullOrEmpty(Uf))
                    labelUf.ForeColor = Color.Red;

                MessageBox.Show("Todos os campos, em vermelho, devem ser preenchidos!", "ADVERTÊNCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else
                return true;
        }

        private void SalvarAutorizada()
        {
            if (!string.IsNullOrEmpty(textBoxNome.Text))
            {
                PreencherAutorizadaInfo();
                SalvarThread();
            }
            else
                FormMessage.ShowMessegeWarning("Insira no mínimo o nome da a autorizada!");
        }

        private void PreencherFornecedorInfo()
        {
            infoFornecedor = new FornecedorInfo
            {
                forBairro = textBoxBairro.Text,
                forCep = maskedTextBoxCep.Text,
                forCidade = textBoxCidade.Text,
                forCnpj = maskedTextBoxCpf.Text,
                forComplemento = textBoxComplemento.Text,
                forEmail = textBoxEmail.Text,
                forLogradouro = textBoxLogradouro.Text,
                forNome = textBoxNome.Text,
                forTelefone = maskedTextBoxTel1.Text + (string.IsNullOrEmpty(maskedTextBoxTel2.Text) ? "" : "/" + maskedTextBoxTel2.Text),
                forUf = textBoxUF.Text,
                forIdFunc = Form1.User.useidfuncionario,
            };
        }

        private void PreencherFuncInfo()
        {
            UnidadeColecao unidadeColecao = empresaNegocios.ConsultarUnidade();
            infoFunc = new FuncInfo
            {
                funBairro = textBoxBairro.Text,
                funCep = maskedTextBoxCep.Text,
                funCidade = textBoxCidade.Text,
                funCpf = maskedTextBoxCpf.Text,
                funComplemento = textBoxComplemento.Text,
                funEmail = textBoxEmail.Text,
                funLogradouro = textBoxLogradouro.Text,
                funNome = textBoxNome.Text,
                funTelefone = maskedTextBoxTel1.Text + (string.IsNullOrEmpty(maskedTextBoxTel2.Text) ? "" : "/" + maskedTextBoxTel2.Text),
                funUf = textBoxUF.Text,
                funNiver = string.IsNullOrEmpty(textBoxNiver.Text) ? DateTime.Now.Date : Convert.ToDateTime(textBoxNiver.Text).Date,
                funIdUnidade = Form1.Unidade.uniid,
                funidcargo = codCargo
            };
        }

        private void PreencherClienteInfo()
        {
            infoCliente = new ClienteInfo
            {
                clicpf = maskedTextBoxCpf.Text,
                cliemail = textBoxEmail.Text,
                cliiduser = Form1.User.useidfuncionario,
                cliniver = string.IsNullOrEmpty(textBoxNiver.Text) ? DateTime.Now.Date : Convert.ToDateTime(textBoxNiver.Text).Date,
                clinome = textBoxNome.Text,
                clitel = maskedTextBoxTel1.Text + (string.IsNullOrEmpty(maskedTextBoxTel2.Text) ? "" : "/" + maskedTextBoxTel2.Text)
            };

            infoEnd = new EnderecoInfo
            {
                Cep = maskedTextBoxCep.Text,
                Complemento = textBoxComplemento.Text,
                endBairro = textBoxBairro.Text,
                endCidade = textBoxCidade.Text,
                endLogradouro = textBoxLogradouro.Text,
                endUf = textBoxUF.Text,
                IdCliente = idSave,
                PontoReferencia = textBoxPontoReferencia.Text,
                endpadrao = true
            };
        }

        private void PreencherAutorizadaInfo()
        {
            infoAutorizada = new AutorizadaInfo
            {
                autbairro = textBoxBairro.Text,
                autcep = maskedTextBoxCep.Text,
                autcidade = textBoxCidade.Text,
                autcnpj = maskedTextBoxCpf.Text,
                autcomplemento = textBoxComplemento.Text,
                autemail = textBoxEmail.Text,
                autlogradouro = textBoxLogradouro.Text,
                autnome = textBoxNome.Text,
                auttelefone = maskedTextBoxTel1.Text + (string.IsNullOrEmpty(maskedTextBoxTel2.Text) ? "" : "/" + maskedTextBoxTel2.Text),
                autuf = textBoxUF.Text,
                autautorizada = 1,
            };
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            switch (modSave)
            {
                case 0:
                    SalvarCliente();
                    break;
                case 1:
                    SalvarAutorizada();
                    break;
                case 2:
                    SalvarFunc();
                    break;
                case 3:
                    SalvarFornecedor();
                    break;
                case 4:

                    break;
                default:
                    break;
            }
        }

        private void SalvarThread()
        {
            thread = new Thread(Salvar);
            form1.ExecutarThread(thread);
            this.Activate();
            
        }

        private void Salvar()
        {
            switch (modSave)
            {
                case 0:
                    idSave = clienteNegocios.Inserir(infoCliente);

                    if (idSave > 0)
                    {
                        infoCliente.cliid = idSave;
                        infoEnd.IdCliente = idSave;
                        clienteNegocios.InserirEndereco(infoEnd);
                    }
                    break;
                case 1:
                    idSave = autorizadaNegocios.InsertAutorizada(infoAutorizada);
                    break;
                case 2:
                    idSave = funcNegocios.InsertFunc(infoFunc);
                    break;
                case 3:
                    idSave = fornecedorNegocios.InsertFornecedor(infoFornecedor);
                    break;
                case 4:
                    break;
                default:
                    break;
            }

            Form1.encerrarThread = true;

            //if (idSave > 0)
            //    FormMessage.ShowMessegeInfo("Registro salvo com sucesso!");
        }

        private void Alterar()
        {
            switch (modSave)
            {
                case 0:
                    idSave = clienteNegocios.Inserir(infoCliente);

                    if (idSave > 0)
                    {
                        infoCliente.cliid = idSave;
                        infoEnd.IdCliente = idSave;
                        clienteNegocios.InserirEndereco(infoEnd);
                    }
                    break;
                case 1:
                    idSave = autorizadaNegocios.InsertAutorizada(infoAutorizada);
                    break;
                case 2:
                    idSave = funcNegocios.InsertFunc(infoFunc);
                    break;
                case 3:
                    idSave = fornecedorNegocios.InsertFornecedor(infoFornecedor);
                    break;
                case 4:
                    break;
                default:
                    break;
            }

            Form1.encerrarThread = true;

            //if (idSave > 0)
            //    FormMessage.ShowMessegeInfo("Registro salvo com sucesso!");
        }

        private void linkLabelCep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Process.Start("http://www.buscacep.correios.com.br/sistemas/buscacep/");
        }

        private void maskedTextBoxCpf_Leave(object sender, EventArgs e)
        {

            cpf = maskedTextBoxCpf.Text;


            //preencher o formulário com os meus dados para testes
            if (cpf == "71992776512")
            {
                PreencherFormClienteLuizFernando();
                return;
            }

            ValidarCpfCnpj validarCpfCnpj = new ValidarCpfCnpj(cpf);

            if (cpf != "00000000000")
            {
                if (cpf.Length >= 11)
                {
                    if (cpf.Length > 11)
                    {
                        if (validarCpfCnpj.CpfCpnjValido())
                        {
                            maskedTextBoxCpf.Mask = "00,000,000/0000-00";
                            ConsultarCpf();
                        }
                        else
                        {
                            FormMessage.ShowMessegeWarning("CNPJ inválido! Tente novamente...");
                            maskedTextBoxCpf.Clear();
                            maskedTextBoxCpf.Focus();
                        }
                    }
                    else
                    {
                        if (validarCpfCnpj.CpfCpnjValido())
                        {
                            maskedTextBoxCpf.Mask = "000,000,000-00";
                            ConsultarCpf();
                        }
                        else
                        {
                            FormMessage.ShowMessegeWarning("CPF inválido! Tente novamente...");
                            maskedTextBoxCpf.Clear();
                            maskedTextBoxCpf.Focus();
                        }
                    }

                }
                else
                    maskedTextBoxCpf.Clear();
            }
        }
        private void ConsultarCpf()
        {
            if (modSave == 0)
            {
                colecaoCliente = negocioCliente.ConsultarPorCpf(cpf);

                if (colecaoCliente != null)
                {
                    infoCliente = colecaoCliente[0];
                    PreencherFormCliente();
                }
            }
        }

        private void maskedTextBoxCpf_Enter(object sender, EventArgs e)
        {
            maskedTextBoxCpf.Mask = null;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            if (config)
                Application.Exit();
            else
                this.Close();
        }

        private void pictureBoxBuscarUnidade_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            CepInfo cepInfo = new CepInfo();

            cepInfo = clienteNegocios.ConsultarCep(maskedTextBoxCep.Text);

            if (cepInfo != null)
            {
                textBoxLogradouro.Text = cepInfo.Logradouro;
                textBoxBairro.Text = cepInfo.Bairro;
                textBoxCidade.Text = cepInfo.Cidade;
                textBoxUF.Text = cepInfo.Uf;
                textBoxComplemento.Select();
            }
            else
            {
                FormMessage.ShowMessegeWarning("CEP não encontrado, tente outro CEP!");
            }
        }

        private void buttonBuscarUnidade_Click(object sender, EventArgs e)
        {
            CodDescricaoColecao codDescricaoColecao = funcNegocios.ConsultarCargos();
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

            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, "Unidades");
            formConsultar_Cod_Descricao.ShowDialog(this);

            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
            {
                codCargo = Convert.ToInt32(formConsultar_Cod_Descricao.Selecionado.Cod);
                labelUnidadeDescricao.Text = formConsultar_Cod_Descricao.Selecionado.Descricao;
            }
        }

        private void buttonAddNiver_Click(object sender, EventArgs e)
        {
            FormAddData formAddData = new FormAddData();
            formAddData.ShowDialog(this);
            formAddData.Dispose();

            if (formAddData.DialogResult == DialogResult.Yes)
            {
                DateTime data = Convert.ToDateTime(formAddData.textoData);
                textBoxNiver.Text = data.ToString("ddd, dd 'de' MMMM 'de' yyyy").ToUpper();
                maskedTextBoxCep.Select();
            }

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            FormEnderecoLista formEnderecoLista = new FormEnderecoLista(infoCliente);
            formEnderecoLista.ShowDialog(this);
            formEnderecoLista.Dispose();

            if (formEnderecoLista.DialogResult == DialogResult.Yes)
            {
                infoEnd = formEnderecoLista.SelecionandoEnd;
                PreencherFormEnd();
            }
        }

        private void TextBoxNiver_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastroPessoa_Load(object sender, EventArgs e)
        {
            maskedTextBoxCpf.Select();
        }
    }
}

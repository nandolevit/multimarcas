using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Negocios;
using ObjTransfer;

namespace WinForms
{
    public partial class FormEmpresa : Form
    {
        EmpresaNegocios empresaNegocios = new EmpresaNegocios();
        public EmpresaInfo infoEmpresa;
        ComputerColecao colecaoComp;
        ComputerInfo infoComp;
        UnidadeInfo infoUnid;
        UnidadeColecao colecaoUnid;
        SerializarNegocios serializarNegocios = new SerializarNegocios(Form1.Caminho);
        bool Ativo;
        string diretorio = @"C:\Users\Public\LevitSoft\";

        public FormEmpresa(EmpresaInfo empresa)
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            infoEmpresa = empresa;
            Ativo = true;
            textBoxId.ReadOnly = true;
            textBoxId.TabStop = false;
            buttonBuscar.Visible = false;
            buttonInserir.Visible = false;
            buttonSair.Text = "&Fechar";
            this.Text = "Sobre a Empresa";
            PreencherForm();
        }

        public FormEmpresa()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            textBoxId.Select();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            PreencherForm();
        }

        private void PreencherForm()
        {
            
            if (Ativo)
            {
                textBoxId.Text = infoEmpresa.empcod;
                buttonUnid.Enabled = false;
                buttonUnid.ForeColor = Color.Gray;
            }
            else
                infoEmpresa = empresaNegocios.ConsultarEmpresaSysId(textBoxId.Text);

            if (infoEmpresa != null)
            {
                textBoxCnpj.Text = infoEmpresa.empcnpj;
                textBoxCep.Text = infoEmpresa.empcep;
                textBoxEmail.Text = infoEmpresa.empemail;
                textBoxComplemento.Text = infoEmpresa.empcomplemento;
                textBoxRef.Text = infoEmpresa.empreferencia;
                textBoxEnd.Text = infoEmpresa.empcomplemento;
                textBoxFantasia.Text = infoEmpresa.empfantasia;
                textBoxEnd.Text = infoEmpresa.emplogradouro + "/" + infoEmpresa.empbairro +" ("+ infoEmpresa.empcidade + "-" + infoEmpresa.empuf + ")";
                textBoxRazao.Text = infoEmpresa.emprazaosocial;
                textBoxTel.Text = infoEmpresa.emptelefone;

                empresaNegocios = new EmpresaNegocios(infoEmpresa.empconexao);
                colecaoUnid = empresaNegocios.ConsultarUnidade();

                Form1.Computer = new ComputerInfo();
                Form1.ConfiguracaoRede();
                textBoxComputer.Text = Form1.Computer.comphostname;
                textBoxIp.Text = Form1.Computer.compip;
                textBoxAdapter.Text = Form1.Computer.compadaptador;
                maskedTextBoxMac.Text = Form1.Computer.compmac;

                if (colecaoUnid != null)
                {
                    infoUnid = colecaoUnid[0];

                    colecaoComp = empresaNegocios.ConsultarComputadorIdUnid(infoUnid.uniid);

                    if (colecaoComp != null)
                        foreach (ComputerInfo comp in colecaoComp)
                        {
                            if (comp.compserver)
                            {
                                Form1.Server = comp;
                                groupBoxServer.Enabled = false;
                                radioButtonNao.Checked = true;
                            }

                            if (Form1.Computer.compmac == comp.compmac)
                                infoComp = comp;
                        }

                    textBoxUnidNome.Text = colecaoUnid[0].uniunidade;
                    textBoxServer.Text = (Form1.Server == null) ? "" : Form1.Server.comphostname;
                }

                dataGridViewUnid.DataSource = colecaoUnid;

                buttonInserir.Enabled = true;
            }
            else
                FormMessage.ShowMessegeInfo("Registro não encontrado!");
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            if (Ativo)
                Close();
            else
                Application.Exit();
        }

        private void PreencherComputador()
        {
            infoComp = new ComputerInfo
            {
                comphostname = textBoxComputer.Text,
                compadaptador = textBoxAdapter.Text,
                compidunid = infoUnid.uniid,
                compmac = maskedTextBoxMac.Text,
                compserver = radioButtonSim.Checked
            };
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            Inserir();
        }

        private void Inserir()
        {
            if (FormMessage.ShowMessegeQuestion("Deseja inserir a nova empresa?") == DialogResult.Yes)
            {
                if (serializarNegocios.SerializarObjeto(infoEmpresa, Form1.FileNameEmp))
                {
                    Form1.Empresa = (serializarNegocios.DesserializarObjeto(Form1.FileNameEmp) as EmpresaInfo);
                    empresaNegocios = new EmpresaNegocios(Form1.Empresa.empconexao);
                    UnidadeInfo uni = empresaNegocios.ConsultarUnidadeSede();

                    if (uni == null)
                    {
                        infoUnid = new UnidadeInfo
                        {
                            unibairro = infoEmpresa.empbairro,
                            unicep = infoEmpresa.empcep,
                            unicidade = infoEmpresa.empcidade,
                            unicnpj = infoEmpresa.empcnpj,
                            unicomplemento = infoEmpresa.empcomplemento,
                            uniemail = infoEmpresa.empemail,
                            unifantasia = infoEmpresa.empfantasia,
                            uniidEmpresa = infoEmpresa.empcod,
                            unilogradouro = infoEmpresa.emplogradouro,
                            unirazaoSocial = infoEmpresa.emprazaosocial,
                            unireferencia = infoEmpresa.empreferencia,
                            unisite = infoEmpresa.empsite,
                            unitelefone = infoEmpresa.emptelefone,
                            uniuf = infoEmpresa.empuf,
                            uniunidade = " " + infoEmpresa.empbairro + "(SEDE)",
                            unifundada = infoEmpresa.empfundada
                        };
                        int cod = empresaNegocios.InsertUnidade(infoUnid, true);
                        if (cod > 0)
                        {
                            textBoxUnidNome.Text = infoUnid.uniunidade;
                            infoUnid.uniid = cod;

                            FormMessage.ShowMessegeWarning("Cadastro realizado com sucesso!");
                            this.DialogResult = DialogResult.Yes;
                        }
                    }
                    else
                    {
                        FormMessage.ShowMessegeWarning("Cadastro realizado com sucesso!");
                        this.DialogResult = DialogResult.Yes;
                    }

                    InserirUnid();
                }
                else
                    FormMessage.ShowMessegeWarning("Falha, tente novamente!");
            }
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (FormMessage.ShowMessegeQuestion("Delete o registro desta empresa?") == DialogResult.Yes)
            {
                EmpresaNegocios empresaNegocios = new EmpresaNegocios(Form1.Empresa.empconexao);

                FormMessage.ShowMessegeInfo("O sistema será encerrado...");
                Application.Exit();
            }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonBuscar.Enabled = true;
        }

        private void buttonDeleteDB_Click(object sender, EventArgs e)
        {
            if (FormMessage.ShowMessegeQuestion("Deseja apagar a pasta \"LevitSoft\"?") == DialogResult.Yes)
            {
                if (Directory.Exists(diretorio))
                {
                    Directory.Delete(diretorio, true);
                    FormMessage.ShowMessegeWarning("Pasta deletada com sucesso! Agora o sistema será encerrado...");
                    Application.Exit();
                }
            }
        }

        private void ButtonUnid_Click(object sender, EventArgs e)
        {
            Inserir();

        }

        private void InserirUnid()
        {
            if (infoComp == null)
            {
                PreencherComputador();
                infoComp.compid = empresaNegocios.InsertComputador(infoComp);
            }

            serializarNegocios.SerializarObjeto(infoUnid, Form1.FileNameUnid);
            serializarNegocios.SerializarObjeto(infoComp, Form1.FileNameComp);
        }

        private void FormEmpresa_Load(object sender, EventArgs e)
        {

            if (Directory.Exists(diretorio))
                Directory.Delete(diretorio, true);
        }
    }
}

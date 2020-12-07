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
using System.IO;

namespace WinForms
{
    public partial class FormLogin : Form
    {
        EmpresaNegocios empresaNegocios = new EmpresaNegocios(Form1.Empresa.empconexao);
        UserNegocio userNegocio = new UserNegocio(Form1.Empresa.empconexao);
        SerializarNegocios serializarNegocios = new SerializarNegocios(Form1.Caminho);
        AccessLogin accessLogin = new AccessLogin(Form1.Empresa.empconexao);

        private string FileNameLogin { get { return "log.lvt"; } }
        string[] login = new string[3];
        string senha = string.Empty;
        int unidade = 0;

        public FormLogin()
        {
            InitializeComponent();
            
            if (serializarNegocios.ArquivoExiste(FileNameLogin))
            {
                UserInfo user = (serializarNegocios.DesserializarObjeto(FileNameLogin) as UserInfo);

                if(user != null)
                {
                    textBoxLogin.Text = user.uselogin;
                    maskedTextBoxSenha.Text = user.usesenha;
                    checkBoxSalvarLogin.Checked = true;
                }

            }
        }
        
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Logar()
        {
            if (!(string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(maskedTextBoxSenha.Text)))
            {
                if (!string.IsNullOrEmpty(labelUnidadeDescricao.Text))
                {
                    login[0] = textBoxLogin.Text;
                    login[1] = maskedTextBoxSenha.Text;
                    login[2] = unidade.ToString();
                    Login();
                }
                else
                    FormMessage.ShowMessegeWarning("Selecione uma unidade!");
            }
            else
                FormMessage.ShowMessegeWarning("Digite o seu LOGIN E SENHA!");
        }

        private void Login()
        {
            int log = accessLogin.LoginAutentic(login);

            switch (log)
            {
                case 0:
                    FormMessage.ShowMessegeWarning("Senha ou login incorreto!");
                    break;
                case 1:
                    if (checkBoxSalvarLogin.Checked)
                        serializarNegocios.SerializarObjeto(Form1.User, FileNameLogin);
                    else
                        serializarNegocios.ExcluirArquivo(FileNameLogin);

                    this.DialogResult = DialogResult.Yes;
                    break;
                case 2:
                    FormMessage.ShowMessegeWarning("Senha ou login incorreto!");
                    break;
                case 3:
                    FormMessage.ShowMessegeWarning("Você está bloqueado!");
                    break;
                default:
                    break;
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }
        }
        
        private void FormLogin_Load(object sender, EventArgs e)
        {
            unidade = Form1.Unidade.uniid;
            labelUnidadeDescricao.Text = Form1.Unidade.uniunidade;
            textBoxLogin.Select();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
            Logar();
            
        }
        
        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            UnidadeColecao unidadeColecao = empresaNegocios.ConsultarUnidade();
            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();

            if (unidadeColecao != null)
            {
                foreach (UnidadeInfo uni in unidadeColecao)
                {
                    Form_Consultar form_Consultar = new Form_Consultar
                    {
                        Cod = string.Format("{0:000}", uni.uniid),
                        Descricao = uni.uniunidade
                    };

                    form_ConsultarColecao.Add(form_Consultar);
                }
            }

            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, "Unidades");
            formConsultar_Cod_Descricao.ShowDialog(this);

            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
            {
                unidade = Convert.ToInt32(formConsultar_Cod_Descricao.Selecionado.Cod);
                labelUnidadeDescricao.Text = formConsultar_Cod_Descricao.Selecionado.Descricao;
                textBoxLogin.Select();
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            checkBoxSalvarLogin.Checked = false;
        }

        private void maskedTextBoxSenha_TextChanged(object sender, EventArgs e)
        {
            checkBoxSalvarLogin.Checked = false;
        }
    }
}

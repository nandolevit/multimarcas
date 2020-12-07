using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjTransfer;

namespace WinForms
{
    public partial class FormAlterarSenha : Form
    {
        UserNegocio userNegocio = new UserNegocio(Form1.Empresa.empconexao);
        UserInfo userInfo = new UserInfo();
        bool ativado;
        bool userExiste;

        public FormAlterarSenha(UserInfo user)
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            userInfo = user;
            labelLoginMensagem.Visible = true;
            ativado = false;
        }

        public FormAlterarSenha(bool Ativado)
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            textBoxNovoLogin.Enabled = false;
            textBoxNovoLogin.Text = Form1.User.uselogin;
            userInfo = Form1.User;

            if (!Ativado)
                buttonFechar.Text = "Sair";

            ativado = Ativado;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            if (ativado)
                Close();
            else
                Application.Exit();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (!ativado)
            {
                if (userExiste)
                {
                    FormMessage.ShowMessegeWarning("Usuário já existe, defina outro!");
                    textBoxNovoLogin.Clear();
                    textBoxNovoLogin.Select();
                    return;
                }
            }
            
            if (string.Compare(Form1.User.usesenha, maskedTextBoxAtual.Text) == 0)
            {
                labelSenhaNova.ForeColor = Color.Black;
                labelSenhaConfirmar.ForeColor = Color.Black;

                if (!string.IsNullOrEmpty(textBoxNovoLogin.Text))
                {
                    if (string.Compare(maskedTextBoxNova.Text, maskedTextBoxAtual.Text) != 0)
                    {
                        if (string.Compare(maskedTextBoxNova.Text, maskedTextBoxConfirmar.Text) == 0)
                        {
                            if (maskedTextBoxConfirmar.Text.Length > 3)
                            {
                                UserInfo user = new UserInfo
                                {
                                    usesenha = maskedTextBoxConfirmar.Text,
                                    uselogin = textBoxNovoLogin.Text.ToUpper(),
                                    useid = userInfo.useid
                                };

                                int cod = userNegocio.UpdateUser(user);
                                if (cod > 0)
                                {
                                    FormMessage.ShowMessegeWarning("Novo login e senha atualizados com sucesso!");
                                    this.DialogResult = DialogResult.Yes;
                                }
                                else
                                    FormMessage.ShowMessegeWarning("Falha ao tentar salvar!");
                            }
                            else
                                FormMessage.ShowMessegeWarning("A nova senha precisa ter no mínimo 4 dígitos!");
                        }
                        else
                        {
                            labelSenhaNova.ForeColor = Color.Red;
                            labelSenhaConfirmar.ForeColor = Color.Red;
                            maskedTextBoxNova.Clear();
                            maskedTextBoxConfirmar.Clear();
                            maskedTextBoxNova.Select();
                            FormMessage.ShowMessegeWarning("As senhas não coincidem!");
                        }
                    }
                    else
                        FormMessage.ShowMessegeWarning("A nova senha precisa ser diferente da senha atual!");
                }
                else
                    FormMessage.ShowMessegeWarning("Informe o novo login!");
            }
            else
            {
                maskedTextBoxAtual.Select();
                FormMessage.ShowMessegeWarning("A senha atual está incorreta!");
            }

        }

        private void FormAlterarSenha_Load(object sender, EventArgs e)
        {
            textBoxNovoLogin.MaxLength = 10;
        }

        private void textBoxNovoLogin_Leave(object sender, EventArgs e)
        {
            UserInfo user = userNegocio.ConsultarLogin(textBoxNovoLogin.Text);

            if (user == null)
                userExiste = false;
            else
                userExiste = true;
        }
    }
}

using Negocios;
using ObjTransfer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FormOnline : Form
    {
        UserNegocio userNegocio = new UserNegocio(Form1.Empresa.empconexao);
        UserInfo userConversa;
        DateTime tempo = DateTime.Now;
        DateTime tempo1;
        ChatOnlineInfo chat;
        ChatOnlineColecao colecaoChat;
        ChatOnlineColecao chatOnlineColecao;
        int idLogado;
        int idchat;
        bool chatAbeto;

        public FormOnline()
        {
            InitializeComponent();
            Form1.Login = userNegocio.ConsultarUserLogin(Form1.Login.loginid);
            idLogado = Form1.Login.loginiduser;
        }


        private void OnlineUserLogin()
        {
            tempo1 = DateTime.Now;
            TimeSpan min = tempo1 - tempo;

            if (chatAbeto)
            {
                if (min.Seconds > 1)
                {
                    if (userConversa != null)
                    {
                        NovaMensagemChat();
                    }
                }
            }

            if (min.Seconds > 10)
            {
                tempo = DateTime.Now;

                VerOnline();
                PreencherGridNovaMessage();
            }
        }

        private void NovaMensagemChat()
        {
            ChatOnlineInfo chatOn = new ChatOnlineInfo
            {
                chatident = ChatIdent(idchat, idLogado),
                chatidrecebe = idLogado
            };
             ChatOnlineColecao chat = userNegocio.ConsultarChatNova(chatOn);

            if (chat != null)
            {
                dataGridViewChat.DataSource = userNegocio.ConsultarChatOnline(ChatIdent(idchat, idLogado));
                dataGridViewChat.ClearSelection();
                userNegocio.UpdateChatMessageLida(ChatIdent(idchat, idLogado), idLogado);
            }
        }

        private void VerOnline()
        {
            UserLoginColecao userOnlineColecao = userNegocio.ConsultarUserOnline();
            UserLoginColecao loginColecao = new UserLoginColecao();

            if (userOnlineColecao != null)
            {
                foreach (UserLoginInfo log in userOnlineColecao)
                {
                    if (log.loginiduser != idLogado)
                        loginColecao.Add(log);
                }
                dataGridViewOnline.DataSource = loginColecao;
                dataGridViewChat.Refresh();
                dataGridViewOnline.ClearSelection();
            }
            else
                dataGridViewOnline.DataSource = null;
        }
        private void PreencherGridNovaMessage()
        {
            chatOnlineColecao = userNegocio.ConsultarChatMensagemNova(idLogado);

            if (chatOnlineColecao != null)
            {
                dataGridViewChatNovaMessage.DataSource = chatOnlineColecao;
                dataGridViewChatNovaMessage.ClearSelection();
            }
            else
                dataGridViewChatNovaMessage.DataSource = null;
        }
        private void timerOnline_Tick(object sender, EventArgs e)
        {

            if (Form1.ConectedSystem)
                OnlineUserLogin();

        }

        private void FormOnline_Load(object sender, EventArgs e)
        {
            dataGridViewOnline.AutoGenerateColumns = false;
            dataGridViewChat.AutoGenerateColumns = false;
            dataGridViewChatNovaMessage.AutoGenerateColumns = false;
            VerOnline();
        }

        

        private void GridChat()
        {
            dataGridViewChat.DataSource = colecaoChat;
            dataGridViewChat.ClearSelection();

            userNegocio.UpdateChatMessageLida(ChatIdent(idchat,idLogado), idLogado);
        }

        private string ChatIdent(int um, int dois)
        {
            int result = um.CompareTo(dois);

            switch (result)
            {
                case -1:
                    return um + "." + dois;
                case 1:
                    return dois + "." + um;
                default:
                    return um + "." + dois;
            }
            
        }

        private void dataGridViewOnline_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOnline.SelectedRows.Count > 0)
                ItemSelecionado(dataGridViewOnline.SelectedRows[0].DataBoundItem, false);
        }

        private void ItemSelecionado(object row, bool verdade)
        {
            if (verdade)
            {
                ChatOnlineInfo chat = (ChatOnlineInfo)row;
                idchat = chat.chatidenvio;
            }
            else
            {
                UserLoginInfo user = (UserLoginInfo)row;
                idchat = user.loginiduser;
            }
            
            NovaMensagem();
        }

        private void NovaMensagem()
        {
            userConversa = userNegocio.ConsultarUsuarioId(idchat);
            labelNome.Text = userConversa.usenome;
            colecaoChat = userNegocio.ConsultarChatOnline(ChatIdent(idLogado, userConversa.useid));
            GridChat();
            chat = null;
            textBoxMessage.Clear();
            textBoxMessage.Select();
            AbrirChat();
        }

        private void AbrirChat()
        {
            Parent.Width = 900;
            this.Width = 900;

            chatAbeto = true;
            VisualizarChat(true);
        }

        private void VisualizarChat(bool ativar)
        {
            textBoxMessage.Enabled = ativar;
            buttonEnviar.Enabled = ativar;

            textBoxMessage.Clear();
            textBoxMessage.Select();

            if (!ativar)
            {
                userConversa = null;
                colecaoChat = null;
                dataGridViewChat.DataSource = null;
            }
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            EnviarMensagem();
        }

        private void EnviarMensagem()
        {
            if (!string.IsNullOrEmpty(textBoxMessage.Text))
            {
                chat = new ChatOnlineInfo
                {
                    chatident = ChatIdent(idLogado, userConversa.useid),
                    chatidenvio = idLogado,
                    chatidrecebe = userConversa.useid,
                    chatmessage = textBoxMessage.Text,
                };

                if (chat != null)
                    userNegocio.InsertChat(chat);

                colecaoChat = userNegocio.ConsultarChatOnline(ChatIdent(idLogado,userConversa.useid));
                GridChat();
                chat = null;
                textBoxMessage.Clear();
                textBoxMessage.Select();
            }
        }

        private void FormOnline_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    EnviarMensagem();
                    break;
                case Keys.F12:
                    break;
                case Keys.Escape:
                    FecharChat();
                    break;
                default:
                    break;
            }
        }

        private void dataGridViewChatNovaMessage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewChatNovaMessage.SelectedRows.Count > 0)
                ItemSelecionado(dataGridViewChatNovaMessage.SelectedRows[0].DataBoundItem, true);
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            FecharChat();
        }

        private void FecharChat()
        {
            if (this.Width > 215)
            {
                VisualizarChat(false);
                Parent.Width = 215;
                this.Width = 215;
            }

            chatAbeto = false;
            VisualizarChat(false);
        }

        private void buttonNovaMensagem_Click(object sender, EventArgs e)
        {
            IniciarNovaMensagem();
        }

        private void IniciarNovaMensagem()
        {
            UserColecao user = userNegocio.ConsultarTodosLogins();

            if (user != null)
            {
                Form_ConsultarColecao form = new Form_ConsultarColecao();
                foreach (UserInfo login in user)
                {
                    if (login.useid != idLogado)
                    {
                        Form_Consultar consultar = new Form_Consultar
                        {
                            Cod = string.Format("{0:000}", login.useid),
                            Descricao = login.uselogin
                        };

                        form.Add(consultar);
                    }
                }

                FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form, "Usuários");
                formConsultar_Cod_Descricao.ShowDialog(this);
                formConsultar_Cod_Descricao.Dispose();

                if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
                {
                    idchat = Convert.ToInt32(formConsultar_Cod_Descricao.Selecionado.Cod);
                    NovaMensagem();

                }
            }
        }

        private void FormOnline_Leave(object sender, EventArgs e)
        {
            //if (this.Width > 1000)
            //{
            //    this.Hide();
            //    this.Show(this);

            //    if (dataGridViewChat.Visible == true)
            //        this.Width = 930;
            //}
        }

        private void dataGridViewChat_Click(object sender, EventArgs e)
        {
            dataGridViewChat.ClearSelection();
        }

        private void DataGridViewChat_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (colecaoChat != null)
            {
                int num;
                num = e.RowIndex;

                if (Convert.ToInt32(dataGridViewChat[2, num].Value) == userConversa.useid)
                {
                    DataGridViewRow row = dataGridViewChat.Rows[num];
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.FromArgb(255, 245, 238);
                        cell.Style.ForeColor = Color.Red;
                    }
                }
                else if (Convert.ToInt32(dataGridViewChat[2, num].Value) == Form1.Login.loginiduser)
                {
                    DataGridViewRow row = dataGridViewChat.Rows[num];
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.FromArgb(224, 255, 255);
                        cell.Style.ForeColor = Color.Green;
                    }
                }
            }
        }
    }
}

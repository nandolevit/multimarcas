using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjTransfer;
using AccessDB;
using System.Data;

namespace Negocios
{
    public class UserNegocio
    {
        private static string EmpConexao { get; set; }

        public UserNegocio(){}

        public UserNegocio(string conexao)
        {
            EmpConexao = conexao;
        }

        AccessDbMySql accessDbMySql = new AccessDbMySql();

        public bool TestarConexaoSemPersistencia(string access)
        {
            bool teste = accessDbMySql.ConectarSemPersistencia(access);
            accessDbMySql.FecharConexao();
            return teste;
        }

        public bool TestarConexaoSemPersistencia()
        {
            bool teste = accessDbMySql.ConectarSemPersistencia(DadosDB.ConexaoSys);
            accessDbMySql.FecharConexao();
            return teste;
        }

        public bool TestarConexao()
        {
            bool teste = accessDbMySql.ConectarSys();
            accessDbMySql.FecharConexao();
            return teste;
        }

        public ChatOnlineColecao ConsultarChatMensagemNova(int chatOn)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@recebe", chatOn);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarChatMensagemNova");

                if (dataTable != null)
                {
                    ChatOnlineColecao colecao = new ChatOnlineColecao();
                    foreach (DataRow chat in dataTable.Rows)
                    {
                        ChatOnlineInfo chatInfo = new ChatOnlineInfo
                        {
                            chatid = Convert.ToInt32(chat["quant"]),
                            chatmessage = Convert.ToString(chat["uselogin"]) + " (" + Convert.ToInt32(chat["quant"]) + ")",
                            chatidenvio = Convert.ToInt32(chat["chatidenvio"]),
                        };

                        colecao.Add(chatInfo);
                    }

                    return colecao;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public ChatOnlineColecao ConsultarChatNova(ChatOnlineInfo chatOn)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@ident", chatOn.chatident);
                accessDbMySql.AddParametrosMySql("@recebe", chatOn.chatidrecebe);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarChatNova");

                if (dataTable != null)
                    return PreencherChatOnline(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public int UpdateChatMessageLida(string ident, int recebe)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@ident", ident);
                accessDbMySql.AddParametrosMySql("@recebe", recebe);

                return accessDbMySql.ExecutarScalarMySql("spUpdateChatMessageLida");
            }
            return 0;
        }

        public ChatOnlineColecao ConsultarChatOnline(string ident)
        {
            if (true)
            {
                accessDbMySql.AddParametrosMySql("@ident", ident);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarChat");

                if (dataTable != null)
                    return PreencherChatOnline(dataTable);
                else
                    return null;
            }
        }

        private ChatOnlineColecao PreencherChatOnline(DataTable dataTable)
        {
            ChatOnlineColecao chatcolecao = new ChatOnlineColecao();
            foreach (DataRow chat in dataTable.Rows)
            {
                ChatOnlineInfo onlineInfo = new ChatOnlineInfo
                {
                    chatdata = Convert.ToDateTime(chat["chatdata"]),
                    chatid = Convert.ToInt32(chat["chatid"]),
                    chatident = Convert.ToString(chat["chatident"]),
                    chatidenvio = Convert.ToInt32(chat["chatidenvio"]),
                    chatidrecebe = Convert.ToInt32(chat["chatidrecebe"]),
                    chatlida = Convert.ToBoolean(chat["chatlida"]),
                    chatmessage = Convert.ToString(chat["chatmessage"])
                };

                chatcolecao.Add(onlineInfo);
            }

            return chatcolecao;
        }

        public int InsertChat(ChatOnlineInfo chat)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@envio", chat.chatidenvio);
                accessDbMySql.AddParametrosMySql("@recebe", chat.chatidrecebe);
                accessDbMySql.AddParametrosMySql("@message", chat.chatmessage);
                accessDbMySql.AddParametrosMySql("@ident", chat.chatident);

                return accessDbMySql.ExecutarScalarMySql("spInsertChat");
            }
            else
                return 0;
        }

        public UserLoginColecao ConsultarUserOnline()
        {
            //esse método é exclusivo para o chat online, possui um método de conexão exclusiva
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarUserOnline");
                if (dataTable != null)
                    return PreencherUserLoginColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public int InsertUserLogin(UserInfo userInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", userInfo.useid);

                return accessDbMySql.ExecutarScalarMySql("spInsertUserLogin");
            }
            else
                return 0;
        }

        public int UpdateUserLogin(int userLogin)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", userLogin);
                return accessDbMySql.ExecutarScalarMySql("spUpdateUserLogin");
            }
            else
                return 0;
        }

        private UserLoginColecao PreencherUserLoginColecao(DataTable dataTable)
        {
            UserLoginColecao colecao = new UserLoginColecao();
            foreach (DataRow row in dataTable.Rows)
            {
                UserLoginInfo user = new UserLoginInfo
                {
                    logindatadeslog = Convert.ToDateTime(row["logindatadeslog"]),
                    logindatalog = Convert.ToDateTime(row["logindatalog"]),
                    loginid = Convert.ToInt32(row["loginid"]),
                    loginiduser = Convert.ToInt32(row["loginiduser"]),
                    loginnome = Convert.ToString(row["uselogin"])
                };

                colecao.Add(user);
            }

            return colecao;
        }

        public UserLoginInfo ConsultarUserLogin(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);
                DataTable dataTable = dataTable = accessDbMySql.dataTableMySql("spConsultarUserLogin");
                if (dataTable != null)
                    return PreencherUserLoginColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public UserColecao ConsultarTodosLogins()
        {

            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarCadastroTodosLogins");
                if (dataTable != null)
                    return PreencherUserColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public int UpdateUser(UserInfo userInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@login", userInfo.uselogin);
                accessDbMySql.AddParametrosMySql("@id", userInfo.useid);
                accessDbMySql.AddParametrosMySql("@senha", userInfo.usesenha);
                
                return accessDbMySql.ExecutarScalarMySql("spUpdateLogin");
            }
            else
                return 0;
        }

        public UserInfo ConsultarUsuarioId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DeletarUserLogin();
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarUsuarioId");
                if (dataTable != null)
                    return PreencherUserColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public UserInfo ConsultarLogin(string login)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@login", login);

                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarLogin");
                if (dataTable != null)
                    return PreencherUserColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        private void DeletarUserLogin()
        {
            if (accessDbMySql.Conectar(EmpConexao))
                accessDbMySql.ExecutarScalarMySql("spDeletarUserLogin");
        }

        public int InsertUser(UserInfo userInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@funcionario", userInfo.useidfuncionario);
                accessDbMySql.AddParametrosMySql("@login", userInfo.uselogin);
                accessDbMySql.AddParametrosMySql("@senha", userInfo.usesenha);

                return accessDbMySql.ExecutarScalarMySql("spInsertUser");
            }
            else
                return 0;
        }

        private UserColecao PreencherUserColecao(DataTable dataTable)
        {
            UserColecao userColecao = new UserColecao();
            foreach (DataRow row in dataTable.Rows)
            {
                UserInfo userInfo = new UserInfo
                {
                    useativo = Convert.ToInt32(row["useativo"]),
                    useid = Convert.ToInt32(row["useid"]),
                    useidfuncionario = Convert.ToInt32(row["useidfuncionario"]),
                    uselogin = Convert.ToString(row["uselogin"]),
                    usenovologin = Convert.ToInt32(row["usenovologin"]),
                    usenome = Convert.ToString(row["funnome"]),
                    usesenha = Convert.ToString(row["usesenha"])
                };

                userColecao.Add(userInfo);
            }

            return userColecao;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjTransfer;
using Negocios;

namespace WinForms
{
    public class AccessLogin
    {
        private static string EmpConexao { get; set; }
        UserNegocio userNegocio = new UserNegocio(Form1.Empresa.empconexao);
        EmpresaNegocios empresaNegocios = new EmpresaNegocios(Form1.Empresa.empconexao);
        UnidadeColecao unidadeColecao = new UnidadeColecao();

        public AccessLogin(string empacess)
        {
            EmpConexao = empacess;
        }


        public int LoginAutentic(string[] log)
        {
            UserInfo userInfo = userNegocio.ConsultarLogin(log[0]);

            if (userInfo != null)
            {

                if (userInfo.useativo == 1)
                {
                    if (string.Compare(log[1], userInfo.usesenha) == 0)
                    {
                        Form1.Login = new UserLoginInfo();
                        Form1.User = userInfo;
                        Form1.Unidade = empresaNegocios.ConsultarUnidadeId(Convert.ToInt32(log[2]));

                        if (Form1.Offline == false)
                        {
                            Form1.Login.loginid = userNegocio.InsertUserLogin(userInfo);
                        }

                        return 1;
                    }
                    else
                        return 2;
                }
                else
                    return 3;
            }
            else
                return 0;
        }

        public UnidadeInfo VerificarUnidade()
        {
            unidadeColecao = empresaNegocios.ConsultarUnidade();

            if (unidadeColecao.Count == 1)
            {
                return unidadeColecao[0];
            }
            else
                return null;
        }

        public bool UserExist()
        {
            if (userNegocio.ConsultarTodosLogins() != null)
                return true;
            else
                return false;
        }
    }
}

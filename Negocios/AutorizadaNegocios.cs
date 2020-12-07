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
    public class AutorizadaNegocios
    {
        private static string EmpConexao { get; set; }

        public AutorizadaNegocios(string empacess)
        {
            EmpConexao = empacess;
        }

        AccessDbMySql accessDbMySql = new AccessDbMySql();

        public AutorizadaInfo ConsultarAutorizadaConfirmId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);
                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarAutorizadaConfirmId");

                if (dataTable != null)
                    return PreencherAutorizadaColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public AutorizadaColecao ConsultarAutorizadaConfirm()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarAutorizadaConfirm");

                if (dataTable != null)
                    return PreencherAutorizadaColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public AutorizadaInfo ConsultarAutorizadaId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);
                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarAutorizadaId");

                if (dataTable != null)
                    return PreencherAutorizadaColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public AutorizadaColecao ConsultarAutorizada()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarAutorizada");

                if (dataTable != null)
                    return PreencherAutorizadaColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public int InsertAutorizada(AutorizadaInfo autorizada)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@bairro", autorizada.autbairro);
                accessDbMySql.AddParametrosMySql("@cep", autorizada.autcep);
                accessDbMySql.AddParametrosMySql("@cidade", autorizada.autcidade);
                accessDbMySql.AddParametrosMySql("@cnpj", autorizada.autcnpj);
                accessDbMySql.AddParametrosMySql("@complemento", autorizada.autcomplemento);
                accessDbMySql.AddParametrosMySql("@email", autorizada.autemail);
                accessDbMySql.AddParametrosMySql("@logradouro", autorizada.autlogradouro);
                accessDbMySql.AddParametrosMySql("@nome", autorizada.autnome);
                accessDbMySql.AddParametrosMySql("@telefone", autorizada.auttelefone);
                accessDbMySql.AddParametrosMySql("@uf", autorizada.autuf);
                accessDbMySql.AddParametrosMySql("@aut", autorizada.autautorizada);

                return accessDbMySql.ExecutarScalarMySql("spInsertAutorizada");
            }
            else
                return 0;
        }

        private AutorizadaColecao PreencherAutorizadaColecao(DataTable dataTable)
        {
            AutorizadaColecao autorizadaColecao = new AutorizadaColecao();
            foreach (DataRow row in dataTable.Rows)
            {
                AutorizadaInfo autorizadaInfo = new AutorizadaInfo
                {
                    autautorizada = Convert.ToInt32(row["autautorizada"]),
                    autbairro = Convert.ToString(row["autbairro"]),
                    autcep = Convert.ToString(row["autcep"]),
                    autcidade = Convert.ToString(row["autautorizada"]),
                    autcnpj = Convert.ToString(row["autcidade"]),
                    autcomplemento = Convert.ToString(row["autcomplemento"]),
                    autemail = Convert.ToString(row["autemail"]),
                    autid = Convert.ToInt32(row["autid"]),
                    autlogradouro = Convert.ToString(row["autlogradouro"]),
                    autnome = Convert.ToString(row["autnome"]).Trim(),
                    auttelefone = Convert.ToString(row["auttelefone"]),
                    autuf = Convert.ToString(row["autuf"])
                };

                autorizadaColecao.Add(autorizadaInfo);
            }

            return autorizadaColecao;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccessDB;
using ObjTransfer;
using System.Data;

namespace Negocios
{
    public class FornecedorNegocios
    {
        public static string EmpConexao { get; set; }

        public FornecedorNegocios(string conexao)
        {
            EmpConexao = conexao;
        }

        AccessDbMySql accessDbMySql = new AccessDbMySql();

        public FornecedorInfo ConsultarForncedorPadrao()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();

                dataTable = accessDbMySql.dataTableMySql("spConsultarFornecedorPadrao");

                if (dataTable != null)
                    return PreencherColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public int InsertFornecedor(FornecedorInfo fornecedorInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@bairro", fornecedorInfo.forBairro);
                accessDbMySql.AddParametrosMySql("@cep", fornecedorInfo.forCep);
                accessDbMySql.AddParametrosMySql("@cidade", fornecedorInfo.forCidade);
                accessDbMySql.AddParametrosMySql("@cnpj", fornecedorInfo.forCnpj);
                accessDbMySql.AddParametrosMySql("@complemento", fornecedorInfo.forComplemento);
                accessDbMySql.AddParametrosMySql("@email", fornecedorInfo.forEmail);
                accessDbMySql.AddParametrosMySql("@logradouro", fornecedorInfo.forLogradouro);
                accessDbMySql.AddParametrosMySql("@nome", fornecedorInfo.forNome);
                accessDbMySql.AddParametrosMySql("@telefone", fornecedorInfo.forTelefone);
                accessDbMySql.AddParametrosMySql("@uf", fornecedorInfo.forUf);
                accessDbMySql.AddParametrosMySql("@func", fornecedorInfo.forIdFunc);
                accessDbMySql.AddParametrosMySql("@padrao", fornecedorInfo.forpadrao);

                return accessDbMySql.ExecutarScalarMySql("spInsertFornecedor");
            }
            else
                return 0;
        }

        public FornecedorInfo ConsultarForncedorId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("id", id);
                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarFornecedorId");

                if (dataTable != null)
                {
                    return PreencherColecao(dataTable)[0];
                }
                else
                    return null;
            }
            else
                return null;
        }

        public FornecedorColecao ConsultarForncedor()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();

                dataTable = accessDbMySql.dataTableMySql("spConsultarFornecedor");

                if (dataTable != null)
                {
                    return PreencherColecao(dataTable);
                }
                else
                    return null;
            }
            else
                return null;
        }

        private FornecedorColecao PreencherColecao(DataTable tab)
        {
            FornecedorColecao colecao = new FornecedorColecao();

            foreach (DataRow row in tab.Rows)
            {
                FornecedorInfo forn = new FornecedorInfo
                {
                    forCep = Convert.ToString(row["forCep"]),
                    forCnpj = Convert.ToString(row["forCnpj"]),
                    forComplemento = Convert.ToString(row["forComplemento"]),
                    forEmail = Convert.ToString(row["forEmail"]),
                    forId = Convert.ToInt32(row["forId"]),
                    forTelefone = Convert.ToString(row["forTelefone"]),
                    forBairro = Convert.ToString(row["forBairro"]),
                    forCidade = Convert.ToString(row["forCidade"]),
                    forLogradouro = Convert.ToString(row["forLogradouro"]),
                    forNome = Convert.ToString(row["forNome"]),
                    forUf = Convert.ToString(row["forUf"]),
                    forIdFunc = Convert.ToInt32(row["forIdFunc"])
                };

                colecao.Add(forn);
            }

            return colecao;
        }
    }
}

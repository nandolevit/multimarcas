using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccessDB;
using ObjTransfer;

namespace Negocios
{
    public class FuncNegocios
    {
        private static string EmpConexao { get; set; }

        public FuncNegocios(string conexao)
        {
            EmpConexao = conexao;
        }

        AccessDbMySql accessDbMySql = new AccessDbMySql();

        public CodDescricaoColecao ConsultarCargos()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();

                dataTable = accessDbMySql.dataTableMySql("spConsultarCargo");

                if (dataTable != null)
                {
                    CodDescricaoColecao codDescricaoColecao = new CodDescricaoColecao();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        CodDescricaoInfo cod = new CodDescricaoInfo
                        {
                            cod = Convert.ToInt32(row["cargoid"]),
                            descricao = Convert.ToString(row["cargodescricao"])
                        };

                        codDescricaoColecao.Add(cod);
                    }

                    return codDescricaoColecao;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public FuncColecao ConsultarFuncTecnico()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();

                dataTable = accessDbMySql.dataTableMySql("spConsultarFucTecnico");

                if (dataTable != null)
                    return PreencherFuncColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public int InsertFunc(FuncInfo funcInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@niver", funcInfo.funNiver);
                accessDbMySql.AddParametrosMySql("@nome", funcInfo.funNome);
                accessDbMySql.AddParametrosMySql("@telefone", funcInfo.funTelefone);
                accessDbMySql.AddParametrosMySql("@cpf", funcInfo.funCpf);
                accessDbMySql.AddParametrosMySql("@email", funcInfo.funEmail);
                accessDbMySql.AddParametrosMySql("@cep", funcInfo.funCep);
                accessDbMySql.AddParametrosMySql("@complemento", funcInfo.funComplemento);
                accessDbMySql.AddParametrosMySql("@unidade", funcInfo.funIdUnidade);
                accessDbMySql.AddParametrosMySql("@logradouro", funcInfo.funLogradouro);
                accessDbMySql.AddParametrosMySql("@bairro", funcInfo.funBairro);
                accessDbMySql.AddParametrosMySql("@cidade", funcInfo.funCidade);
                accessDbMySql.AddParametrosMySql("@uf", funcInfo.funUf);
                accessDbMySql.AddParametrosMySql("@login", funcInfo.funLogin);
                accessDbMySql.AddParametrosMySql("@senha", funcInfo.funSenha);
                accessDbMySql.AddParametrosMySql("@cargo", funcInfo.funidcargo);

                return accessDbMySql.ExecutarScalarMySql("spInsertFunc");
            }
            else
                return 0;
        }

        public bool UpdateFunc(FuncInfo funcInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", funcInfo.funId);
                accessDbMySql.AddParametrosMySql("@niver", funcInfo.funNiver);
                accessDbMySql.AddParametrosMySql("@nome", funcInfo.funNome);
                accessDbMySql.AddParametrosMySql("@telefone", funcInfo.funTelefone);
                accessDbMySql.AddParametrosMySql("@cpf", funcInfo.funCpf);
                accessDbMySql.AddParametrosMySql("@email", funcInfo.funEmail);
                accessDbMySql.AddParametrosMySql("@cep", funcInfo.funCep);
                accessDbMySql.AddParametrosMySql("@complemento", funcInfo.funComplemento);
                accessDbMySql.AddParametrosMySql("@unidade", funcInfo.funIdUnidade);
                accessDbMySql.AddParametrosMySql("@logradouro", funcInfo.funLogradouro);
                accessDbMySql.AddParametrosMySql("@bairro", funcInfo.funBairro);
                accessDbMySql.AddParametrosMySql("@cidade", funcInfo.funCidade);
                accessDbMySql.AddParametrosMySql("@uf", funcInfo.funUf);
                accessDbMySql.AddParametrosMySql("@login", funcInfo.funLogin);
                accessDbMySql.AddParametrosMySql("@senha", funcInfo.funSenha);

                return accessDbMySql.ExecutarComandoMySql("spUpdateFunc");
            }
            else
                return false;
        }

        public FuncInfo ConsultarFuncPorId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);
                
                DataTable dataTable = new DataTable();

                dataTable = accessDbMySql.dataTableMySql("spConsultarFuncPorId");

                if (dataTable != null)
                    return PreencherFuncColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        private FuncColecao PreencherFuncColecao(DataTable dataTable)
        {
            FuncColecao funcColecao = new FuncColecao();

            if (dataTable != null)
            {
                foreach (DataRow linhas in dataTable.Rows)
                {
                    FuncInfo funcInfo = new FuncInfo
                    {
                        funBairro = Convert.ToString(linhas["funBairro"]),
                        funCep = Convert.ToString(linhas["funCep"]),
                        funCidade = Convert.ToString(linhas["funCidade"]),
                        funComplemento = Convert.ToString(linhas["funComplemento"]),
                        funSenha = Convert.ToString(linhas["funSenha"]),
                        funLogin = Convert.ToString(linhas["funLogin"]),
                        funUf = Convert.ToString(linhas["funUf"]),
                        funLogradouro = Convert.ToString(linhas["funLogradouro"]),
                        funIdUnidade = Convert.ToInt32(linhas["funIdUnidade"]),
                        funEmail = Convert.ToString(linhas["funEmail"]),
                        funControleDataCad = Convert.ToDateTime(linhas["funControleDataCad"]),
                        funCpf = Convert.ToString(linhas["funCpf"]),
                        funId = Convert.ToInt32(linhas["funId"]),
                        funNiver = DBNull.Value.Equals(linhas["funNiver"]) ? DateTime.Now.Date : Convert.ToDateTime(linhas["funNiver"]),
                        funNome = Convert.ToString(linhas["funNome"]),
                        funTelefone = Convert.ToString(linhas["funTelefone"]),
                        funidcargo = Convert.ToInt32(linhas["funidcargo"]),
                    };

                    funcColecao.Add(funcInfo);
                }

                return funcColecao;
            }
            else
                return null;
        }

        public FuncColecao ConsultatFuncTotal()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                return PreencherFuncColecao(accessDbMySql.dataTableMySql("spConsultarFuncTotal"));
            }
            else
                return null;

            
        }
    }
}

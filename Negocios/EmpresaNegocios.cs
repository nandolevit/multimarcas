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
    public class EmpresaNegocios
    {
        private static string EmpConexao { get; set; }

        public EmpresaNegocios(){} //esse construtor serve para compatibilidade

        public EmpresaNegocios(string conexao)
        {
            EmpConexao = conexao;
        }

        AccessDbMySql accessDbMySql = new AccessDbMySql();
        EmpresaAccessDB empresaAccessDB = new EmpresaAccessDB();

        public int UpdateComputadorLog(ComputerInfo comp)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", comp.compid);
                accessDbMySql.AddParametrosMySql("@ip", comp.compip);
                accessDbMySql.AddParametrosMySql("@compuser", comp.compuser);

                return accessDbMySql.ExecutarScalarMySql("spUpdateComputadorLog");
            }
            else
                return 0;
        }

        public ComputerColecao ConsultarComputadorIdUnid(int unid)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@unid", unid);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarComputadorIdUnid");
                if (dataTable != null)
                    return PreencherComp(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public int InsertComputador(ComputerInfo comp)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@adaptador", comp.compadaptador);
                accessDbMySql.AddParametrosMySql("@hostname", comp.comphostname);
                accessDbMySql.AddParametrosMySql("@unid", comp.compidunid);
                accessDbMySql.AddParametrosMySql("@mac", comp.compmac);
                accessDbMySql.AddParametrosMySql("@compserver", comp.compserver);

                return accessDbMySql.ExecutarScalarMySql("spInsertComputador");
            }
            else
                return 0;
        }

        public EmpresaInfo ConsultarEmpresaSysIdOffline(string id)
        {

            if (accessDbMySql.ConectarOffline(EmpConexao))
            {
                DataTable dataTable = new DataTable();
                accessDbMySql.AddParametrosMySql("@cod", id);
                dataTable = accessDbMySql.dataTableMySql(empresaAccessDB.conexaoSys);

                if (dataTable != null)
                    return PreencherEmpresaColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public EmpresaInfo ConsultarEmpresaSysId(string id)
        {
            if (accessDbMySql.ConectarSys())
            {
                DataTable dataTable = new DataTable();
                accessDbMySql.AddParametrosMySql("@cod", id);
                dataTable = accessDbMySql.dataTableMySql(empresaAccessDB.conexaoSys);

                if (dataTable != null)
                    return PreencherEmpresaColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }
        
        public UnidadeInfo ConsultarUnidadeId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);
                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarUnidadeId");

                if (dataTable != null)
                    return PreencherUnidadeColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public UnidadeInfo ConsultarUnidadeSede()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();

                dataTable = accessDbMySql.dataTableMySql("spConsultarUnidadeSede");

                if (dataTable != null)
                    return PreencherUnidadeColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public UnidadeColecao ConsultarUnidade()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();

                dataTable = accessDbMySql.dataTableMySql("spConsultarUnidade");

                if (dataTable != null)
                    return PreencherUnidadeColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }
        
        public int InsertUnidade(UnidadeInfo unidadeInfo, bool sede = false)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@bairro", unidadeInfo.unibairro);
                accessDbMySql.AddParametrosMySql("@cep", unidadeInfo.unicep);
                accessDbMySql.AddParametrosMySql("@cidade", unidadeInfo.unicidade);
                accessDbMySql.AddParametrosMySql("@cnpj", unidadeInfo.unicnpj);
                accessDbMySql.AddParametrosMySql("@complemento", unidadeInfo.unicomplemento);
                accessDbMySql.AddParametrosMySql("@email", unidadeInfo.uniemail);
                accessDbMySql.AddParametrosMySql("@fantasia", unidadeInfo.unifantasia);
                accessDbMySql.AddParametrosMySql("@cod", unidadeInfo.uniidEmpresa);
                accessDbMySql.AddParametrosMySql("@logradouro", unidadeInfo.unilogradouro);
                accessDbMySql.AddParametrosMySql("@razaoSocial", unidadeInfo.unirazaoSocial);
                accessDbMySql.AddParametrosMySql("@referencia", unidadeInfo.unireferencia);
                accessDbMySql.AddParametrosMySql("@site", unidadeInfo.unisite);
                accessDbMySql.AddParametrosMySql("@telefone", unidadeInfo.unitelefone);
                accessDbMySql.AddParametrosMySql("@uf", unidadeInfo.uniuf);
                accessDbMySql.AddParametrosMySql("@unidade", unidadeInfo.uniunidade);
                accessDbMySql.AddParametrosMySql("@fundada", unidadeInfo.unifundada);

                if (sede)
                    return accessDbMySql.ExecutarScalarMySql("spInsertUnidadeSede");
                else
                    return accessDbMySql.ExecutarScalarMySql("spInsertUnidade");
            }
            else
                return 0;
        }

        public EmpresaColecao ConsultarEmpresa(string conexao)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarEmpresa");

                if (dataTable != null)
                    return PreencherEmpresaColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public EmpresaInfo ConsultarEmpresaId(string id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();
                accessDbMySql.AddParametrosMySql("@cod", id);
                dataTable = accessDbMySql.dataTableMySql("spConsultarEmpresaId");

                if (dataTable != null)
                    return PreencherEmpresaColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        private ComputerColecao PreencherComp(DataTable dataTable)
        {
            ComputerColecao colecao = new ComputerColecao();
            foreach (DataRow row in dataTable.Rows)
            {
                ComputerInfo computerInfo = new ComputerInfo
                {
                    compadaptador = Convert.ToString(row["compadaptador"]),
                    compativo = Convert.ToBoolean(row["compativo"]),
                    comphostname = Convert.ToString(row["comphostname"]),
                    compid = Convert.ToInt32(row["compid"]),
                    compidunid = Convert.ToInt32(row["compidunid"]),
                    compmac = Convert.ToString(row["compmac"]),
                    compserver = Convert.ToBoolean(row["compserver"]),
                };

                colecao.Add(computerInfo);
            }

            return colecao;
        }

        public EmpresaColecao PreencherEmpresaColecao(DataTable dataTable)
        {
            EmpresaColecao empresaColecao = new EmpresaColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                EmpresaInfo empresaInfo = new EmpresaInfo
                {
                    empbairro = Convert.ToString(row["empbairro"]),
                    empcep = Convert.ToString(row["empcep"]),
                    empcidade = Convert.ToString(row["empcidade"]),
                    empcnpj = Convert.ToString(row["empcnpj"]),
                    empcod = Convert.ToString(row["empcod"]),
                    empcomplemento = Convert.ToString(row["empcomplemento"]),
                    empemail = Convert.ToString(row["empemail"]),
                    empfantasia = Convert.ToString(row["empfantasia"]),
                    emplogradouro = Convert.ToString(row["emplogradouro"]),
                    emprazaosocial = Convert.ToString(row["emprazaosocial"]),
                    empreferencia = Convert.ToString(row["empreferencia"]),
                    empsite = Convert.ToString(row["empsite"]),
                    emptelefone = Convert.ToString(row["emptelefone"]),
                    empuf = Convert.ToString(row["empuf"]),
                    empdatacad = Convert.ToDateTime(row["empdatacad"]),
                    empfundada = Convert.ToDateTime(row["empfundada"]),
                    empconexao = Convert.ToString(row["empconexao"]),
                    empativada = Convert.ToInt32(row["empativada"]),
                    empdataativo = Convert.ToDateTime(row["empdataativo"]),
                    empobs = Convert.ToString(row["empobs"])
                };

                empresaColecao.Add(empresaInfo);
            }

            return empresaColecao;
        }

        public UnidadeColecao PreencherUnidadeColecao(DataTable dataTable)
        {
            UnidadeColecao unidadeColecao = new UnidadeColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                UnidadeInfo unidadeInfo = new UnidadeInfo
                {
                    uniativa = Convert.ToInt32(row["uniativa"]),
                    unibairro = Convert.ToString(row["unibairro"]),
                    unicep = Convert.ToString(row["unicep"]),
                    unicidade = Convert.ToString(row["unicidade"]),
                    unicnpj = Convert.ToString(row["unicnpj"]),
                    unicomplemento = Convert.ToString(row["unicomplemento"]),
                    uniemail = Convert.ToString(row["uniemail"]),
                    unifantasia = Convert.ToString(row["unifantasia"]),
                    unifundada = Convert.ToDateTime(row["unifundada"]),
                    uniid = Convert.ToInt32(row["uniid"]),
                    uniidEmpresa = Convert.ToString(row["uniidEmpresa"]),
                    unilogradouro = Convert.ToString(row["unilogradouro"]),
                    unirazaoSocial = Convert.ToString(row["unirazaoSocial"]),
                    unireferencia = Convert.ToString(row["unireferencia"]),
                    unisite = Convert.ToString(row["unisite"]),
                    unitelefone = Convert.ToString(row["unitelefone"]),
                    uniuf = Convert.ToString(row["uniuf"]),
                    uniunidade = Convert.ToString(row["uniunidade"]).Trim(),
                };

                unidadeColecao.Add(unidadeInfo);
            }

            return unidadeColecao;
        }
    }
}

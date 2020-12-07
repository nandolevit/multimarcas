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
    public class PagamentoNegocios
    {
        public static string EmpConexao { get; set; }

        public PagamentoNegocios(string conexao)
        {
            EmpConexao = conexao;
        }
        AccessDbMySql accessDbMySql = new AccessDbMySql();

        public int InsertPagamentoDetalhes(PagamentoDetalhesInfo pagamentoDetalhesInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@maq", pagamentoDetalhesInfo.pagdetalhesidmaquineta);
                accessDbMySql.AddParametrosMySql("@tipo", pagamentoDetalhesInfo.pagdetalhesidtipopag);
                accessDbMySql.AddParametrosMySql("@parc", pagamentoDetalhesInfo.pagdetalhesnumparcelas);
                accessDbMySql.AddParametrosMySql("@pag", pagamentoDetalhesInfo.pagdetalhesidpag);
                accessDbMySql.AddParametrosMySql("@valor", pagamentoDetalhesInfo.pagdetalhesvalor);
                accessDbMySql.AddParametrosMySql("@form", pagamentoDetalhesInfo.pagdetalhesidform);

                return accessDbMySql.ExecutarScalarMySql("spInsertPagamentoDetalhes");
            }
            else
                return 0;
        }

        public int InsertPagamento(PagamentoInfo pagamentoInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@venda", pagamentoInfo.pagamentoidvenda);
                accessDbMySql.AddParametrosMySql("@quant", pagamentoInfo.pagamentoquantforma);
                accessDbMySql.AddParametrosMySql("@valor", pagamentoInfo.pagamentovalor);
                accessDbMySql.AddParametrosMySql("@troco", pagamentoInfo.pagamentotroco);

                return accessDbMySql.ExecutarScalarMySql("spInsertPagamento");
            }
            else
                return 0;
        }

        public CodDescricaoColecao ConsultarPagamentoTipo()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarPagamentoTipo");

                if (dataTable != null)
                    return PreencherCodDescricaoPagTipo(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public CodDescricaoColecao ConsultarMaquineta()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarMaquineta");

                if (dataTable != null)
                    return PreencherCodDescricaoMaquineta(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        private CodDescricaoColecao PreencherCodDescricaoPagTipo(DataTable dataTable)
        {
            CodDescricaoColecao codDescricaoColecao = new CodDescricaoColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                CodDescricaoInfo codDescricaoInfo = new CodDescricaoInfo
                {
                    cod = Convert.ToInt32(row["formapagamentotipoid"]),
                    descricao = Convert.ToString(row["formapagamentotipodescricao"])
                };

                codDescricaoColecao.Add(codDescricaoInfo);
            }

            return codDescricaoColecao;
        }

        private CodDescricaoColecao PreencherCodDescricaoMaquineta(DataTable dataTable)
        {
            CodDescricaoColecao codDescricaoColecao = new CodDescricaoColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                CodDescricaoInfo codDescricaoInfo = new CodDescricaoInfo
                {
                    cod = Convert.ToInt32(row["maquinetaid"]),
                    descricao = Convert.ToString(row["maquinetadescricao"])
                };

                codDescricaoColecao.Add(codDescricaoInfo);
            }

            return codDescricaoColecao;
        }
    }
}

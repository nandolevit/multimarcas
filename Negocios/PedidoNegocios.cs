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
    public class PedidoNegocios
    {
        private static string EmpConexao { get; set; }

        public PedidoNegocios(string conexao)
        {
            EmpConexao = conexao;
        }

        AccessDbMySql accessDbMySql = new AccessDbMySql();

        public int DeletePedidoDetalhes(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);
                return accessDbMySql.ExecutarScalarMySql("spDeletePedidoDetalhes");
            }
            else
                return 0;
        }

        public PedidoDetalhesColecao ConsultarPedidoDetalhesPedId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarPedidoDetalhesPedId");

                if (dataTable != null)
                    return PreencherPedidoDetalhesColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public PedidoInfo ConsultarPedidoCod(string cod)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@cod", cod);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarPedidoCod");

                if (dataTable != null)
                    return PreencherPedidoColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public PedidoColecao ConsultarPedidoOs(int os)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@os", os);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarPedidoOs");

                if (dataTable != null)
                    return PreencherPedidoColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public bool InsertPedidoDetalhes(PedidoDetalhesInfo pedidoDetalhesInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@prod", pedidoDetalhesInfo.peddetalhesidprod);
                accessDbMySql.AddParametrosMySql("@quant", pedidoDetalhesInfo.peddetalhesquant);
                accessDbMySql.AddParametrosMySql("@peddesc", pedidoDetalhesInfo.peddetalhesvalordesc);
                accessDbMySql.AddParametrosMySql("@unit", pedidoDetalhesInfo.peddetalhesvalorunit);
                accessDbMySql.AddParametrosMySql("@pedido", pedidoDetalhesInfo.peddetalhesidpedido);

                return accessDbMySql.ExecutarComandoMySql("spInsertPedidoDetalhes");
            }
            return false;
        }

        public int InsertPedido(PedidoInfo pedidoInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@peddata", pedidoInfo.pedidodata);
                accessDbMySql.AddParametrosMySql("@func", pedidoInfo.pedidoidfunc);
                accessDbMySql.AddParametrosMySql("@serv", pedidoInfo.pedidoidserv);
                accessDbMySql.AddParametrosMySql("@pedstatus", pedidoInfo.pedidoidstatus);
                accessDbMySql.AddParametrosMySql("@item", pedidoInfo.pedidototalitem);
                accessDbMySql.AddParametrosMySql("@valor", pedidoInfo.pedidototalvalor);
                accessDbMySql.AddParametrosMySql("@unid", pedidoInfo.pedidoidunid);

                return (int)accessDbMySql.ExecutarScalarMySql("spInsertPedido");
            }
            else
                return 0;
        }

        public int UpdatePedidoCod(int id, string cod)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);
                accessDbMySql.AddParametrosMySql("@cod", cod);

                return accessDbMySql.ExecutarScalarMySql("spUpadatePedidoCod");
            }
            else
                return 0;
        }

        private PedidoColecao PreencherPedidoColecao(DataTable dataTable)
        {
            PedidoColecao pedidoColecao = new PedidoColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                PedidoInfo pedidoInfo = new PedidoInfo
                {
                    pedidocod =  Convert.ToString( row["pedidocod"]),
                    pedidodata = Convert.ToDateTime(row["pedidodata"]),
                    pedidoid = Convert.ToInt32(row["pedidoid"]),
                    pedidoidfunc = Convert.ToInt32(row["pedidoidfunc"]),
                    pedidoidserv = Convert.ToInt32(row["pedidoidserv"]),
                    pedidoidstatus = Convert.ToInt32(row["pedidoidstatus"]),
                    pedidototalitem = Convert.ToInt32(row["pedidototalitem"]),
                    pedidototalvalor = Convert.ToDecimal(row["pedidototalvalor"]),
                    pedidoidunid = Convert.ToInt32(row["pedidoidunid"]),
                    status = Convert.ToString(row["pedstatusdescricao"])
                };

                pedidoColecao.Add(pedidoInfo);
            }

            return pedidoColecao;
        }

        private PedidoDetalhesColecao PreencherPedidoDetalhesColecao(DataTable dataTable)
        {
            PedidoDetalhesColecao pedidoDetalhesColecao = new PedidoDetalhesColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                PedidoDetalhesInfo pedidoDetalhesInfo = new PedidoDetalhesInfo
                {
                    peddetalhesid = Convert.ToInt32(row["peddetalhesid"]),
                    peddetalhesidpedido = Convert.ToInt32(row["peddetalhesidpedido"]),
                    peddetalhesidprod = Convert.ToInt32(row["peddetalhesidprod"]),
                    peddetalhesquant = Convert.ToInt32(row["peddetalhesquant"]),
                    peddetalhesvalordesc = Convert.ToDecimal(row["peddetalhesvalordesc"]),
                    peddetalhesvalorunit = Convert.ToDecimal(row["peddetalhesvalorunit"])
                };

                pedidoDetalhesColecao.Add(pedidoDetalhesInfo);
            }

            return pedidoDetalhesColecao;
        }
    }
}

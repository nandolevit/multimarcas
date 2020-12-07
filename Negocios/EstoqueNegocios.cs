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
    public class EstoqueNegocios
    {
        public static string EmpConexao { get; set; }

        public EstoqueNegocios(string conexao)
        {
            EmpConexao = conexao;
        }

        AccessDbMySql accessDbMySql = new AccessDbMySql();

        public GridFormProdutoEstoqueColecao ConsultarEstoqueProdutosDescricao(string descricao)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@descricao", descricao);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarEstoqueProdutoDescricao");

                if (dataTable != null)
                    return PreencherGridFormEstoque(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public GridFormProdutoEstoqueColecao ConsultarEstoqueProdutos()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarEstoqueProdutos");

                if (dataTable != null)
                    return PreencherGridFormEstoque(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public EstoqueLancamentoInfo ConsultarEstoqueLancamento(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarEstoqueLancamento");

                if (dataTable != null)
                    return PreencherEstoqueLancamento(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public int UpdateProdEstoqueZerar(int unid, int contar)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@unid", unid);
                accessDbMySql.AddParametrosMySql("@contar", contar);

                return accessDbMySql.ExecutarScalarMySql("spUpdateProdEstoqueZerar");
            }
            else
                return 0;
        }

        public int UpdateEstoqueContarId(EstoqueContarInfo estoqueContarInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", estoqueContarInfo.estoquecontarid);
                accessDbMySql.AddParametrosMySql("@conf", estoqueContarInfo.estoquecontarconfirmado);
                accessDbMySql.AddParametrosMySql("@valor", estoqueContarInfo.estoquecontarvalor);
                accessDbMySql.AddParametrosMySql("@quant", estoqueContarInfo.estoquecontarquant);

                return accessDbMySql.ExecutarScalarMySql("spUpdateEstoqueContarId");
            }
            else
                return 0;
        }

        public EstoqueContarInfo ConstularEstoqueContarId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarEstoqueContarId");

                if (dataTable != null)
                    return PreencherEstoqueContar(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public int DeleteEstoqueContar(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                return accessDbMySql.ExecutarScalarMySql("spDeleteEstoqueContar");
            }
            else
                return 0;
        }

        public EstoqueContarDetalhesInfo ConsultarEstoqueContarDetalhesIdProd(int idprod, int idcontar)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@idprod", idprod);
                accessDbMySql.AddParametrosMySql("@idcontar", idcontar);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarEstoqueContarDetalhesIdProd");

                if (dataTable != null)
                    return PreencherEstoqueContarDetalhes(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public EstoqueContarDetalhesColecao ConsultarEstoqueContarDetalhesIdContar(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarEstoqueContarDetalhesId");

                if (dataTable != null)
                    return PreencherEstoqueContarDetalhes(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public int UpdateEstoqueContarDetalhes(EstoqueContarDetalhesInfo estoqueContarDetalhesInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", estoqueContarDetalhesInfo.estoquecontardetalhesid);
                accessDbMySql.AddParametrosMySql("@quant", estoqueContarDetalhesInfo.estoquecontardetalhesquant);
                accessDbMySql.AddParametrosMySql("@valor", estoqueContarDetalhesInfo.estoquecontardetalhesvalor);

                return accessDbMySql.ExecutarScalarMySql("spUpdateEstoqueContarDetalhes");
            }
            else
                return 0;
        }

        public int InsertEstoqueContarDetalhes(EstoqueContarDetalhesInfo estoqueContarDetalhesInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@contar", estoqueContarDetalhesInfo.estoquecontardetalhesidcontar);
                accessDbMySql.AddParametrosMySql("@prod", estoqueContarDetalhesInfo.estoquecontardetalhesidproduto);
                accessDbMySql.AddParametrosMySql("@quant", estoqueContarDetalhesInfo.estoquecontardetalhesquant);
                accessDbMySql.AddParametrosMySql("@valor", estoqueContarDetalhesInfo.estoquecontardetalhesvalor);

                return accessDbMySql.ExecutarScalarMySql("spInsertEstoqueContarDetalhes");
            }
            else
                return 0;
        }

        public int InsertEstoqueContar(EstoqueContarInfo estoqueContarInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@func", estoqueContarInfo.estoquecontaridfunc);
                accessDbMySql.AddParametrosMySql("@unid", estoqueContarInfo.estoquecontaridunidade);
                accessDbMySql.AddParametrosMySql("@contardata", estoqueContarInfo.estoquecontardata);

                return accessDbMySql.ExecutarScalarMySql("spInsertEstoqueContar");
            }
            else
                return 0;
        }

        public int UpdateEstoqueLancamentoStatus(int idlanc, int idstatus)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("id", idlanc);
                accessDbMySql.AddParametrosMySql("idstatus", idstatus);

                return accessDbMySql.ExecutarScalarMySql("spUpdateEstoqueLancamentoStatus");
            }
            else
                return 0;
        }

        public int InsertEstoqueLancamentoDetalhes(EstoqueLancamentoDetalhesInfo estoqueLancamentoDetalhesInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@lanc", estoqueLancamentoDetalhesInfo.estoquedetalhesidlancamento);
                accessDbMySql.AddParametrosMySql("@prod", estoqueLancamentoDetalhesInfo.estoquedetalhesidprod);
                accessDbMySql.AddParametrosMySql("@quant", estoqueLancamentoDetalhesInfo.estoquedetalhesquant);
                accessDbMySql.AddParametrosMySql("@valor", estoqueLancamentoDetalhesInfo.estoquedetalhesvalor);

                return accessDbMySql.ExecutarScalarMySql("spInsertEstoqueDetalhes");
            }
            else
                return 0;
        }

        public int UpdateEstoqueLancamentoId(EstoqueLancamentoInfo estoqueLancamentoInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", estoqueLancamentoInfo.estoquelancamentoid);
                accessDbMySql.AddParametrosMySql("@valor", estoqueLancamentoInfo.estoquelancamentovalor);
                accessDbMySql.AddParametrosMySql("@quant", estoqueLancamentoInfo.estoquelancamentoquant);

                return accessDbMySql.ExecutarScalarMySql("spUpdateEstoqueLancamentoId");
            }
            else
                return 0;
        }

        public bool InsertMovEstoque(MovEstoqueInfo movEstoqueInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@prod", movEstoqueInfo.movestoqueidproduto);
                accessDbMySql.AddParametrosMySql("@tipo", movEstoqueInfo.movestoqueidtipomovimento);
                accessDbMySql.AddParametrosMySql("@quant", movEstoqueInfo.movestoquequant);
                accessDbMySql.AddParametrosMySql("@valor", movEstoqueInfo.movestoquevalor);

                return accessDbMySql.ExecutarComandoMySql("spInsertMovEstoque");
            }
            else
                return false;
        }

        public int UpdateEstoqueId(ProdutoEstoqueInfo produtoEstoqueInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", produtoEstoqueInfo.prodestoqueid);
                accessDbMySql.AddParametrosMySql("@quant", produtoEstoqueInfo.prodestoquequant);

                return accessDbMySql.ExecutarScalarMySql("spUpdateEstoqueId");
            }
            else
                return 0;
        }

        public int InsertEstoqueLancamento(EstoqueLancamentoInfo estoqueLancamentoInfo, int unid)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@dataadd", estoqueLancamentoInfo.estoquelancamentodatahora);
                accessDbMySql.AddParametrosMySql("@unid", unid);

                return accessDbMySql.ExecutarScalarMySql("spInsertEstoqueLancamento");
            }
            else
                return 0;
        }

        public bool UpdateEstoqueUnidade(ProdutoEstoqueInfo prod)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@prod", prod.prodestoqueid);
                accessDbMySql.AddParametrosMySql("@quant", prod.prodestoquequant);
                accessDbMySql.AddParametrosMySql("@unid", prod.prodestoqueidunidade);

                return accessDbMySql.ExecutarComandoMySql("spUpdateProdutoEstoqueUnidade");
            }
            return false;
        }
        public int InsertProdutoEstoque(int prod, int unid)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@prod", prod);
                accessDbMySql.AddParametrosMySql("@unid", unid);

                return accessDbMySql.ExecutarScalarMySql("spInsertProdutoEstoque");
            }
            else
                return 0;
        }

        public ProdutoInfo ConsultarEstoqueIdProdutoUnid(int prod, int unid)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@prod", prod);
                accessDbMySql.AddParametrosMySql("@unid", unid);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarEstoqueIdProdutoUnid");

                if (dataTable != null)
                    return PreencherProdColecao(dataTable)[0];
                else
                    return CadProdUnidade(prod, unid);
            }
            else
                return null;
        }

        private ProdutoInfo CadProdUnidade(int prod, int unid)
        {
            ProdutoNegocios produtoNegocios = new ProdutoNegocios(EmpConexao);
            ProdutoInfo produtoInfo = produtoNegocios.ConsultarProdutosId(prod);

            if (produtoInfo.proControleEstoque == true)
            {
                if (InsertProdutoEstoque(prod, unid) > 0)
                    return ConsultarEstoqueIdProdutoUnid(prod, unid);
                else
                    return null;
            }
            else
                return null;
        }

        private GridFormProdutoEstoqueColecao PreencherGridFormEstoque(DataTable tab)
        {
            GridFormProdutoEstoqueColecao colecao = new GridFormProdutoEstoqueColecao();

            foreach (DataRow row in tab.Rows)
            {
                GridFormProdutoEstoqueInfo estoque = new GridFormProdutoEstoqueInfo
                {
                    autnome = Convert.ToString(row["autnome"]),
                    fornome = Convert.ToString(row["fornome"]),
                    procodbarras = Convert.ToString(row["procodbarras"]),
                    prodcatnome = Convert.ToString(row["prodcatnome"]),
                    prodescricao = Convert.ToString(row["prodescricao"]),
                    prodestoqueid = Convert.ToInt32(row["prodestoqueid"]),
                    prodestoquequant = Convert.ToInt32(row["prodestoquequant"]),
                    prodsubcatnome = Convert.ToString(row["prodsubcatnome"]),
                    proid = Convert.ToInt32(row["proid"]),
                    proidfornecedor = Convert.ToInt32(row["proidfornecedor"]),
                    proidmarca = Convert.ToInt32(row["proidmarca"]),
                    proidsubcategoria = Convert.ToInt32(row["proidsubcategoria"]),
                    proquantminima = Convert.ToInt32(row["proquantminima"]),
                    provaloratacado = Convert.ToDecimal(row["provaloratacado"]),
                    provalorcompra = Convert.ToDecimal(row["provalorcompra"]),
                    provalorvarejo = Convert.ToDecimal(row["provalorvarejo"])
                };

                colecao.Add(estoque);
            }

            return colecao;
        }

        private EstoqueLancamentoColecao PreencherEstoqueLancamento(DataTable tab)
        {
            EstoqueLancamentoColecao colecao = new EstoqueLancamentoColecao();

            foreach (DataRow row in tab.Rows)
            {
                EstoqueLancamentoInfo estoqueLancamentoInfo = new EstoqueLancamentoInfo
                {
                    estoquelancamentodatahora = Convert.ToDateTime(row["estoquelancamentodatahora"]),
                    estoquelancamentoid = Convert.ToInt32(row["estoquelancamentoid"]),
                    estoquelancamentoidtipo = Convert.ToInt32(row["estoquelancamentoidtipo"]),
                    estoquelancamentoquant = Convert.ToInt32(row["estoquelancamentoquant"]),
                    estoquelancamentostatus = Convert.ToInt32(row["estoquelancamentostatus"]),
                    estoquelancamentovalor = Convert.ToDecimal(row["estoquelancamentovalor"]),
                    estoquelancamentoidunid = Convert.ToInt32(row["estoquelancamentoidunid"])
                };

                colecao.Add(estoqueLancamentoInfo);
            }

            return colecao;
        }

        private ProdutoEstoqueColecao PreencherEstoqueColecao(DataTable tab)
        {
            ProdutoEstoqueColecao colecao = new ProdutoEstoqueColecao();

            foreach (DataRow row in tab.Rows)
            {
                ProdutoEstoqueInfo prodEstoqueInfo = new ProdutoEstoqueInfo
                {
                    prodestoqueidproduto = Convert.ToInt32(row["prodestoqueidproduto"]),
                    prodestoqueidunidade = Convert.ToInt32(row["prodestoqueidunidade"]),
                    prodestoqueid = Convert.ToInt32(row["prodestoqueid"]),
                    prodestoquequant = Convert.ToInt32(row["prodestoquequant"]),
                    prodestoquedatacad = Convert.ToDateTime(row["prodestoquedatacad"]),
                };

                colecao.Add(prodEstoqueInfo);
            }

            return colecao;
        }

        private EstoqueContarColecao PreencherEstoqueContar(DataTable dataTable)
        {
            EstoqueContarColecao estoqueContarColecao = new EstoqueContarColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                EstoqueContarInfo contar = new EstoqueContarInfo
                {
                    estoquecontarconfirmado = Convert.ToInt32(row["estoquecontarconfirmado"]),
                    estoquecontardata = Convert.ToDateTime(row["estoquecontardata"]),
                    estoquecontarid = Convert.ToInt32(row["estoquecontarid"]),
                    estoquecontaridfunc = Convert.ToInt32(row["estoquecontaridfunc"]),
                    estoquecontaridunidade = Convert.ToInt32(row["estoquecontaridunidade"]),
                    estoquecontarquant = Convert.ToInt32(row["estoquecontarquant"]),
                    estoquecontarvalor = Convert.ToInt32(row["estoquecontarvalor"]),
                };

                estoqueContarColecao.Add(contar);
            }

            return estoqueContarColecao;
        }

        private EstoqueContarDetalhesColecao PreencherEstoqueContarDetalhes(DataTable dataTable)
        {
            EstoqueContarDetalhesColecao estoqueContarDetalhesColecao = new EstoqueContarDetalhesColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                EstoqueContarDetalhesInfo estoqueContarDetalhesInfo = new EstoqueContarDetalhesInfo
                {
                    estoquecontardetalhesid = Convert.ToInt32(row["estoquecontardetalhesid"]),
                    estoquecontardetalhesidcontar = Convert.ToInt32(row["estoquecontardetalhesidcontar"]),
                    estoquecontardetalhesidproduto = Convert.ToInt32(row["estoquecontardetalhesidproduto"]),
                    estoquecontardetalhesquant = Convert.ToInt32(row["estoquecontardetalhesquant"]),
                    estoquecontardetalhesvalor = Convert.ToDecimal(row["estoquecontardetalhesvalor"]),
                };

                estoqueContarDetalhesColecao.Add(estoqueContarDetalhesInfo);
            }

            return estoqueContarDetalhesColecao;
        }

        private ProdutoColecao PreencherProdColecao(DataTable tab)
        {
            ProdutoColecao colecao = new ProdutoColecao();

            foreach (DataRow row in tab.Rows)
            {
                ProdutoInfo produtosInfo = new ProdutoInfo
                {
                    proCodBarras = Convert.ToString(row["proCodBarras"]),
                    proControleEstoque = Convert.ToBoolean(row["proControleEstoque"]),
                    proDescricao = Convert.ToString(row["proDescricao"]),
                    proId = Convert.ToInt32(row["proId"]),
                    proQuantMinima = Convert.ToInt32(row["proQuantMinima"]),
                    proidUser = Convert.ToInt32(row["proidUser"]),
                    proValorAtacado = Convert.ToDecimal(row["proValorAtacado"]),
                    proValorCompra = Convert.ToDecimal(row["proValorCompra"]),
                    proValorVarejo = Convert.ToDecimal(row["proValorVarejo"]),
                    Desativado = Convert.ToInt32(row["proidstatus"]) == 1 ? "ATIVADO" : "DESATIVADO",
                    proidstatus = Convert.ToInt32(row["proidstatus"]),
                    proidsubcategoria = Convert.ToInt32(row["proidsubcategoria"]),
                    proidmarca = Convert.ToInt32(row["autid"]),
                    proidfornecedor = Convert.ToInt32(row["proidfornecedor"]),
                    proDataCad = Convert.ToDateTime(row["proDataCad"]),
                    procodkit = Convert.ToString(row["procodkit"]),
                    prodetalhes = Convert.ToString(row["proDescricao"]) + "/" + Convert.ToString(row["autnome"]) + " (" + Convert.ToString(row["prodcatnome"]) + "/" + Convert.ToString(row["prodsubcatnome"]) + ")",
                    prodestoquedatacad = Convert.ToDateTime(row["prodestoquedatacad"]),
                    prodestoqueidproduto = Convert.ToInt32(row["prodestoqueidproduto"]),
                    prodestoqueidunidade = Convert.ToInt32(row["prodestoqueidunidade"]),
                    prodestoquequant = Convert.ToInt32(row["prodestoquequant"]),
                    prodestoqueid = Convert.ToInt32(row["prodestoqueid"]),
                };

                colecao.Add(produtosInfo);
            }

            return colecao;
        }
    }
}

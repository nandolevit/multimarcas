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
    public class VendaNegocios : PagamentoNegocios
    {
        public VendaNegocios(string conexao) : base(conexao) { }

        AccessDbMySql accessDbMySql = new AccessDbMySql();

        public GridViewComissaoColecao ConsultarVendaDetalhesTodosFunc(DateTime dataini, DateTime datafim)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("dataini", dataini);
                accessDbMySql.AddParametrosMySql("datafim", datafim);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarVendaDetalhesTodosFunc");

                if (dataTable != null)
                {
                    GridViewComissaoColecao gridViewComissaoColecao = new GridViewComissaoColecao();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        GridViewComissaoInfo comissao = new GridViewComissaoInfo
                        {
                            DescricaoProduto = Convert.ToString(row["funnome"]),
                            IdProduto = Convert.ToInt32(row["funid"]),
                            Quant = Convert.ToDecimal(row["vendetalhesquant"]),
                            Valor = Convert.ToDecimal(row["vendetalhessaldo"]),
                        };

                        gridViewComissaoColecao.Add(comissao);
                    }

                    return gridViewComissaoColecao;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public GridViewComissaoColecao ConsultarVendaDetalhesIdFunc(int idfunc, DateTime dataini, DateTime datafim)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("idfunc", idfunc);
                accessDbMySql.AddParametrosMySql("dataini", dataini);
                accessDbMySql.AddParametrosMySql("datafim", datafim);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarVendaDetalhesIdFunc");

                if (dataTable != null)
                {
                    GridViewComissaoColecao gridViewComissaoColecao = new GridViewComissaoColecao();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        GridViewComissaoInfo comissao = new GridViewComissaoInfo
                        {
                            CategoriaSub = Convert.ToString(row["prodcatnome"]) + "/" + Convert.ToString(row["prodsubcatnome"]),
                            DataVenda = Convert.ToDateTime(row["vendata"]),
                            DescricaoProduto = Convert.ToString(row["prodescricao"]),
                            IdProduto = Convert.ToInt32(row["proid"]),
                            IdVenda = Convert.ToInt32(row["venid"]),
                            Marca = Convert.ToString(row["autnome"]),
                            Quant = Convert.ToDecimal(row["vendetalhesquant"]),
                            Valor = Convert.ToDecimal(row["vendetalhessaldo"]),
                            ValorUnit = Convert.ToDecimal(row["vendetalhesvalordesc"])
                        };

                        gridViewComissaoColecao.Add(comissao);
                    }

                    return gridViewComissaoColecao;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public VendaCanceladaInfo ConsultarVendaCanceladaIdVenda(int idvenda)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@idvenda", idvenda);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarVendaCanceladaIdVenda");

                if (dataTable != null)
                {
                    VendaCanceladaInfo vendaCanceladaInfo = new VendaCanceladaInfo();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        vendaCanceladaInfo = new VendaCanceladaInfo
                        {
                            vendacanceladadatacad = Convert.ToDateTime(row["vendacanceladadatacad"]),
                            vendacanceladadescricao = Convert.ToString(row["vendacanceladadescricao"]),
                            vendacanceladaid = Convert.ToInt32(row["vendacanceladaid"]),
                            vendacanceladaidfunc = Convert.ToInt32(row["vendacanceladaidfunc"]),
                            vendacanceladaidvenda = Convert.ToInt32(row["vendacanceladaidvenda"])
                        };
                    }

                    return vendaCanceladaInfo;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public int InsertVendaCancelada(int func, int venda, string descricao)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@func", func);
                accessDbMySql.AddParametrosMySql("@venda", venda);
                accessDbMySql.AddParametrosMySql("@descricao", descricao);

                return accessDbMySql.ExecutarScalarMySql("spInsertVendaCancelada");
            }
            else
                return 0;
        }

        public FormaPagamentoPorVendaColecao ConsultarFormaPagamentoPorVenda(int idvenda)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@idvenda", idvenda);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarFormaPagamentoIdVenda");

                if (dataTable != null)
                {
                    FormaPagamentoPorVendaColecao colecao = new FormaPagamentoPorVendaColecao();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        FormaPagamentoPorVendaInfo forma = new FormaPagamentoPorVendaInfo
                        {
                            formpagdescricao = Convert.ToString(row["formpagdescricao"]),
                            pagdetalhesvalor = Convert.ToDecimal(row["pagdetalhesvalor"])
                        };

                        colecao.Add(forma);
                    }

                    return colecao;
                }
                else
                    return null;
            }
            else
                return null;
        }
        
        public VendaColecao ConsultarVendaPeriodo(DateTime ini, DateTime final, int idstatus)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@datainicial", ini);
                accessDbMySql.AddParametrosMySql("@datafinal", final);
                accessDbMySql.AddParametrosMySql("@idstatus", idstatus);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarVendaPeriodo");

                if (dataTable != null)
                    return PreencherVendaColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public PagamentoInfo ConsultarPagamentoIdVenda(int idvenda)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@idvenda", idvenda);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarVFormapagporvendaId");

                if (dataTable != null)
                    return PreencherPagamentoColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public VFormaPagPorVendaColecao ConsultarVFormaPagPorVendaColecao(int idvenda)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@idvenda", idvenda);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarVFormapagporvendaId");

                if (dataTable != null)
                    return PreencherVFormaPagPorVendaColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public VendaDetalhesColecao ConsultarVendaDetalhesIdVenda(int idvenda)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@idvenda", idvenda);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarVendaDetalhesIdVenda");

                if (dataTable != null)
                    return PreencherVendaDetalhesColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public VendaInfo ConsultarVendaId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarVendaId");

                if (dataTable != null)
                    return PreencherVendaColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public FormaPagamentoInfo ConsultarFormaPagamentoId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarFormaPagamentoId");

                if (dataTable != null)
                    return PreencherTabelaFormaPagamento(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public int InsertVendaDetalhes(VendaDetalhesInfo vendaDetalhesInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@venda", vendaDetalhesInfo.vendetalhesidvenda);
                accessDbMySql.AddParametrosMySql("@prod", vendaDetalhesInfo.vendetalhesidprod);
                accessDbMySql.AddParametrosMySql("@quant", vendaDetalhesInfo.vendetalhesquant);
                accessDbMySql.AddParametrosMySql("@unit", vendaDetalhesInfo.vendetalhesvalorunit);
                accessDbMySql.AddParametrosMySql("@valordesc", vendaDetalhesInfo.vendetalhesvalordesc);
                accessDbMySql.AddParametrosMySql("@func", vendaDetalhesInfo.vendetalhesidfunc);

                return accessDbMySql.ExecutarScalarMySql("spInsertVendaDetalhes");
            }
            return 0;
        }

        public int InsertVenda(VendaInfo vendaInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@dta", vendaInfo.vendata);
                accessDbMySql.AddParametrosMySql("@cliente", vendaInfo.venidcliente);
                accessDbMySql.AddParametrosMySql("@unid", vendaInfo.venidunidade);
                accessDbMySql.AddParametrosMySql("@func", vendaInfo.venidfunc);
                accessDbMySql.AddParametrosMySql("@valor", vendaInfo.venvalor);
                accessDbMySql.AddParametrosMySql("@quant", vendaInfo.venquant);
                accessDbMySql.AddParametrosMySql("@idstatus", vendaInfo.venidstatus);
                accessDbMySql.AddParametrosMySql("@vip", vendaInfo.venvip);
                accessDbMySql.AddParametrosMySql("@modo", vendaInfo.venmodo);
                accessDbMySql.AddParametrosMySql("@turno", vendaInfo.venidturno);

                return accessDbMySql.ExecutarScalarMySql("spInsertVenda");
            }
            else
                return 0;
        }

        public FormaPagamentoColecao ConsultarFormaPagamento()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarFormaPagamento");

                if (dataTable != null)
                    return PreencherTabelaFormaPagamento(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        private PagamentoColecao PreencherPagamentoColecao(DataTable dataTable)
        {
            PagamentoColecao pagamentoColecao = new PagamentoColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                PagamentoInfo pagamentoInfo = new PagamentoInfo
                {
                    pagamentoid = Convert.ToInt32(row["pagamentoid"]),
                    pagamentoidvenda = Convert.ToInt32(row["pagamentoidvenda"]),
                    pagamentoquantforma = Convert.ToInt32(row["pagamentoquantforma"]),
                    pagamentotroco = Convert.ToDecimal(row["pagamentotroco"]),
                    pagamentovalor = Convert.ToDecimal(row["pagamentovalor"])
                };

                pagamentoColecao.Add(pagamentoInfo);
            }

            return pagamentoColecao;
        }

        private VendaDetalhesColecao PreencherVendaDetalhesColecao(DataTable dataTable)
        {
            VendaDetalhesColecao vendaDetalhesColecao = new VendaDetalhesColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                VendaDetalhesInfo vendaDetalhesInfo = new VendaDetalhesInfo
                {
                    vendetalhesid = Convert.ToInt32(row["vendetalhesid"]),
                    vendetalhesidprod = Convert.ToInt32(row["vendetalhesidprod"]),
                    vendetalhesidvenda = Convert.ToInt32(row["vendetalhesidvenda"]),
                    vendetalhesquant = Convert.ToDecimal(row["vendetalhesquant"]),
                    vendetalhesvalordesc = Convert.ToDecimal(row["vendetalhesvalordesc"]),
                    vendetalhesvalorunit = Convert.ToDecimal(row["vendetalhesvalorunit"]),
                    vendetalhesidfunc = Convert.ToInt32(row["vendetalhesidfunc"])
                };

                vendaDetalhesColecao.Add(vendaDetalhesInfo);
            }

            return vendaDetalhesColecao;
        }

        private VFormaPagPorVendaColecao PreencherVFormaPagPorVendaColecao(DataTable dataTable)
        {
            VFormaPagPorVendaColecao vFormaPagPorVendaColecao = new VFormaPagPorVendaColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                VFormaPagPorVendaInfo vFormaPagPorVendaInfo = new VFormaPagPorVendaInfo
                {
                    formpagdescricao = Convert.ToString(row["formpagdescricao"]),
                    pagamentoid = Convert.ToInt32(row["pagamentoid"]),
                    pagamentoidvenda = Convert.ToInt32(row["pagamentoidvenda"]),
                    pagdetalhesnumparcelas = Convert.ToInt32(row["pagdetalhesnumparcelas"]),
                    pagdetalhesvalor = Convert.ToDecimal(row["pagdetalhesvalor"]),
                    formpagid = Convert.ToInt32(row["formpagid"])
                };

                vFormaPagPorVendaColecao.Add(vFormaPagPorVendaInfo);
            }

            return vFormaPagPorVendaColecao;
        }

        private VendaColecao PreencherVendaColecao(DataTable dataTable)
        {
            VendaColecao vendaColacao = new VendaColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                VendaInfo vendaInfo = new VendaInfo
                {
                    vendata = Convert.ToDateTime(row["vendata"]),
                    vendatacad = Convert.ToDateTime(row["vendatacad"]),
                    venid = Convert.ToInt32(row["venid"]),
                    venidcliente = Convert.ToInt32(row["venidcliente"]),
                    venidfunc = Convert.ToInt32(row["venidfunc"]),
                    venidstatus = Convert.ToInt32(row["venidstatus"]),
                    venidtipoentrada = Convert.ToInt32(row["venidtipoentrada"]),
                    venidunidade = Convert.ToInt32(row["venidunidade"]),
                    venquant = Convert.ToInt32(row["venquant"]),
                    venvalor = Convert.ToDecimal(row["venvalor"]),
                    venvip = Convert.ToInt32(row["venvip"]),
                    venmodo = Convert.ToInt32(row["venmodo"]),
                    venidturno = Convert.ToInt32(row["venidturno"])
                };

                vendaColacao.Add(vendaInfo);
            }

            return vendaColacao;
        }

        private FormaPagamentoColecao PreencherTabelaFormaPagamento(DataTable table)
        {
            FormaPagamentoColecao formaPagamentoColecao = new FormaPagamentoColecao();

            foreach (DataRow row in table.Rows)
            {
                FormaPagamentoInfo formaPagamentoInfo = new FormaPagamentoInfo
                {
                    formpagdescricao = Convert.ToString(row["formpagdescricao"]),
                    formpagid = Convert.ToInt32(row["formpagid"])
                };

                formaPagamentoColecao.Add(formaPagamentoInfo);
            }

            return formaPagamentoColecao;
        }
    }
}

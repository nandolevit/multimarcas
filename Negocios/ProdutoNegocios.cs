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
    public class ProdutoNegocios : EstoqueNegocios
    {
        //private static string EmpConexao { get; set; }

        public ProdutoNegocios(string conexao) : base(conexao)
        {
            //EmpConexao = conexao;
        }

        AccessDbMySql accessDbMySql = new AccessDbMySql();

        public ProdutoInfo ConsultarProdutosTaxa()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarProdutoTaxa");

                if (dataTable != null)
                    return PreencherProdColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public int UpdateProdutoConfirmarLancEstoqueId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                return accessDbMySql.ExecutarScalarMySql("spUpdateProdutoConfirmarLancEstoqueId");
            }
            else
                return 0;
        }

        public ProdutoColecao ConsultarProdutoEstoqueFornecedorId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@fornecedor", id);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarProdutoIdFornecedor");
                if (dataTable != null)
                    return PreencherProdColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }
        
        public ProdutoColecao ConsultarProdutosTodos()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarProdutoTodos");

                if (dataTable != null)
                    return PreencherProdColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public ProdStatusColecao ConsultarProdStatus()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarProdStatus");
                if (dataTable != null)
                    return PreencherDataTableProdStatus(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        private ProdStatusColecao PreencherDataTableProdStatus(DataTable dataTable)
        {
            ProdStatusColecao prodStatusColecao = new ProdStatusColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                ProdStatusInfo status = new ProdStatusInfo
                {
                    prodstadescricao = Convert.ToString(row["prodstadescricao"]),
                    prodstaid = Convert.ToInt32(row["prodstaid"])
                };

                prodStatusColecao.Add(status);
            }

            return prodStatusColecao;
        }

        public int InsertProdSubCategoria(ProdSubCategoriaInfo prodSubCategoriaInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@nome", prodSubCategoriaInfo.Prodsubcatnome);
                accessDbMySql.AddParametrosMySql("@categoria", prodSubCategoriaInfo.prodsubcatidcategoria);

                return accessDbMySql.ExecutarScalarMySql("spInsertProdSubCategoria");
            }
            else
                return 0;
        }

        public int InsertProdCategoria(ProdCategoriaInfo prodCategoriaInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@nome", prodCategoriaInfo.prodcatnome);

                return accessDbMySql.ExecutarScalarMySql("spInsertProdCategoria");
            }
            else
                return 0;
        }

        public ProdCategoriaInfo ConsultarProdCategoriaId(int cat)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();
                accessDbMySql.AddParametrosMySql("@categoria", cat);
                dataTable = accessDbMySql.dataTableMySql("spConsultarProdCategoriaId");

                if (dataTable != null)
                    return PreencherProdCategoria(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public ProdSubCategoriaInfo ConsultarProdSubCategoriaId(int sub)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();
                accessDbMySql.AddParametrosMySql("@sub", sub);
                dataTable = accessDbMySql.dataTableMySql("spConsultarProdSubCategoriaId");

                if (dataTable != null)
                    return PreencherProdSubCategoria(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public ProdSubCategoriaColecao ConsultarProdSubCategoria(int cat)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();
                accessDbMySql.AddParametrosMySql("@categoria", cat);
                dataTable = accessDbMySql.dataTableMySql("spConsultarProdSubCategoria");

                if (dataTable != null)
                    return PreencherProdSubCategoria(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        private ProdCategoriaColecao PreencherProdCategoria(DataTable dataTable)
        {
            ProdCategoriaColecao colecao = new ProdCategoriaColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                ProdCategoriaInfo categoriaProdutoInfo = new ProdCategoriaInfo
                {
                    prodcatnome = Convert.ToString(row["prodcatnome"]).Trim(),
                    prodcatid = Convert.ToInt16(row["prodcatid"])
                };

                colecao.Add(categoriaProdutoInfo);
            }

            return colecao;
        }

        private ProdSubCategoriaColecao PreencherProdSubCategoria(DataTable dataTable)
        {
            ProdSubCategoriaColecao colecao = new ProdSubCategoriaColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                ProdSubCategoriaInfo ProdSubCategoriaInfo = new ProdSubCategoriaInfo
                {
                    Prodsubcatnome = Convert.ToString(row["Prodsubcatnome"]).Trim(),
                    prodsubcatidcategoria = Convert.ToInt16(row["prodsubcatidcategoria"]),
                    Prodsubcatid = Convert.ToInt16(row["Prodsubcatid"])
                };

                colecao.Add(ProdSubCategoriaInfo);
            }

            return colecao;
        }

        public ProdutoColecao ConsultarProdutosDescricao(string descricao)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@descricao", string.Concat( "%", descricao, "%"));

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarProdutosDescricao");

                if (dataTable != null)
                    return PreencherProdColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public bool UpdateProduto(ProdutoInfo prod)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@barras", prod.proCodBarras);
                accessDbMySql.AddParametrosMySql("@estoque", prod.proControleEstoque);
                accessDbMySql.AddParametrosMySql("@descricao", prod.proDescricao);
                accessDbMySql.AddParametrosMySql("@quant", prod.proQuantMinima);
                accessDbMySql.AddParametrosMySql("@atacado", prod.proValorAtacado);
                accessDbMySql.AddParametrosMySql("@compra", prod.proValorCompra);
                accessDbMySql.AddParametrosMySql("@varejo", prod.proValorVarejo);
                accessDbMySql.AddParametrosMySql("@fornecedor", prod.proidfornecedor);
                accessDbMySql.AddParametrosMySql("@marca", prod.proidmarca);
                accessDbMySql.AddParametrosMySql("@subcategoria", prod.proidsubcategoria);
                accessDbMySql.AddParametrosMySql("@id", prod.proId);
                accessDbMySql.AddParametrosMySql("@idstatus", prod.proidstatus);
                accessDbMySql.AddParametrosMySql("@kit", prod.procodkit);

                return accessDbMySql.ExecutarComandoMySql("spUpdateProduto");
            }
            else
                return false;
        }
        
        public ProdutoInfo ConsultarProdutosId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarProdutoId");

                if (dataTable != null)
                    return PreencherProdColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }
        
        public ProdutoInfo ConsultarProdutoCodBarras(string barras)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@barras", barras);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarProdutoCodBarras");

                if (dataTable != null)
                    return PreencherProdColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public int InsertProduto(ProdutoInfo prod)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@barras", prod.proCodBarras);
                accessDbMySql.AddParametrosMySql("@estoque", prod.proControleEstoque);
                accessDbMySql.AddParametrosMySql("@descricao", prod.proDescricao);
                accessDbMySql.AddParametrosMySql("@quant", prod.proQuantMinima);
                accessDbMySql.AddParametrosMySql("@atacado", prod.proValorAtacado);
                accessDbMySql.AddParametrosMySql("@compra", prod.proValorCompra);
                accessDbMySql.AddParametrosMySql("@varejo", prod.proValorVarejo);
                accessDbMySql.AddParametrosMySql("@fornecedor", prod.proidfornecedor);
                accessDbMySql.AddParametrosMySql("@marca", prod.proidmarca);
                accessDbMySql.AddParametrosMySql("@subcategoria", prod.proidsubcategoria);
                accessDbMySql.AddParametrosMySql("@iduser", prod.proidUser);
                accessDbMySql.AddParametrosMySql("@idstatus", prod.proidstatus);
                accessDbMySql.AddParametrosMySql("@kit", prod.procodkit);
                accessDbMySql.AddParametrosMySql("@taxa", prod.protaxa);

                return accessDbMySql.ExecutarScalarMySql("spInsertProduto");
            }
            else
                return 0;
        }

        public ProdCategoriaColecao ConsultarProdCategoria()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarProdCategoria");

                if (dataTable != null)
                    return PreencherProdCategoria(dataTable);
                else
                    return null;
            }
            else
                return null;
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
                    proidmarca = Convert.ToInt32(row["proidmarca"]),
                    proidfornecedor = Convert.ToInt32(row["proidfornecedor"]),
                    proDataCad = Convert.ToDateTime(row["proDataCad"]),
                    procodkit = Convert.ToString(row["procodkit"]),
                    prodetalhes = Convert.ToString(row["proDescricao"]) + "/" + Convert.ToString(row["autnome"]) + " (" + Convert.ToString(row["prodcatnome"]) + "/" + Convert.ToString(row["prodsubcatnome"]) + ")",
                    protaxa = Convert.ToBoolean(row["protaxa"]),
                };

                colecao.Add(produtosInfo);
            }

            return colecao;
        }
        
    }
}

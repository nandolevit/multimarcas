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
    public class CaixaNegocios
    {
        private static string EmpConexao { get; set; }
        
        public CaixaNegocios(string conexao)
        {
            EmpConexao = conexao;
        }

        AccessDbMySql accessDbMySql = new AccessDbMySql();

        public CaixaTurnoInfo ConsultarCaixaTurnoId(int idturno)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", idturno);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarCaixaTurnoIdTurno");

                if (dataTable != null)
                    return PreencherCaixaTurno(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public CaixaAbrirInfo ConsultarCaixaPorId(int idcaixa)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@idcaixa", idcaixa);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarCaixaPorId");
                if (dataTable != null)
                    return PreencherCaixaAbrir(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public int UpdateFechamentoTurno(CaixaTurnoInfo caixaTurnoInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", caixaTurnoInfo.caixaturnoid);
                accessDbMySql.AddParametrosMySql("@carne", caixaTurnoInfo.caixaturnovalorcarne);
                accessDbMySql.AddParametrosMySql("@credito", caixaTurnoInfo.caixaturnovalorcartaocredito);
                accessDbMySql.AddParametrosMySql("@debito", caixaTurnoInfo.caixaturnovalorcartaodebito);
                accessDbMySql.AddParametrosMySql("@cheque", caixaTurnoInfo.caixaturnovalorcheque);
                accessDbMySql.AddParametrosMySql("@deposito", caixaTurnoInfo.caixaturnovalordeposito);
                accessDbMySql.AddParametrosMySql("@dinheiro", caixaTurnoInfo.caixaturnovalordinheiro);
                accessDbMySql.AddParametrosMySql("@pagamentos", caixaTurnoInfo.caixaturnovalorpagamentos);
                accessDbMySql.AddParametrosMySql("@recebimentos", caixaTurnoInfo.caixaturnovalorrecebimentos);
                accessDbMySql.AddParametrosMySql("@especie", caixaTurnoInfo.caixaturnovalorsaldoespecie);
                accessDbMySql.AddParametrosMySql("@sangria", caixaTurnoInfo.caixaturnovalorsangria);
                accessDbMySql.AddParametrosMySql("@total", caixaTurnoInfo.caixaturnovalortotal);
                accessDbMySql.AddParametrosMySql("@funcfechar", caixaTurnoInfo.caixaturnoidfuncfechar);
                accessDbMySql.AddParametrosMySql("@datafechar", caixaTurnoInfo.caixaturnodatafechamento);

                return accessDbMySql.ExecutarScalarMySql("spUpdateFechamentoTurno");
            }
            else
                return 0;
        }

        public CaixaAbrirInfo ConsultarCaixaAbrirUltimoAberto(int unid)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@unid", unid);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarCaixaAbrirUltimoAberto");

                if (dataTable != null)
                    return PreencherCaixaAbrir(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }


        public int InsertCaixaTurno(CaixaTurnoInfo caixaTurnoInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@num", caixaTurnoInfo.caixaturnonum);
                accessDbMySql.AddParametrosMySql("@func", caixaTurnoInfo.caixaturnoidfuncabrir);
                accessDbMySql.AddParametrosMySql("@idcaixa", caixaTurnoInfo.caixaturnoidabrir);
                accessDbMySql.AddParametrosMySql("@caixa", caixaTurnoInfo.caixaturnovalorabrir);

                return accessDbMySql.ExecutarScalarMySql("spInsertCaixaTurno");
            }
            else
                return 0;
        }

        public decimal ConsultarSangriaSaldoIdCaixa(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarSangriaSaldoIdCaixa");

                if (dataTable != null)
                {
                    decimal sangria = 0;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (!DBNull.Value.Equals(row["sangriavalor"]))
                            sangria += Convert.ToDecimal(row["sangriavalor"]);
                    }

                    return sangria;
                }
                else
                    return 0;
            }
            else
                return 0;
        }

        public decimal ConsultarSangriaSaldoIdTurno(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarSangriaSaldoIdTurno");

                if (dataTable != null)
                {
                    decimal sangria = 0;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (!DBNull.Value.Equals(row["sangriavalor"]))
                            sangria += Convert.ToDecimal(row["sangriavalor"]);
                    }

                    return sangria;
                }
                else
                    return 0;
            }
            else
                return 0;
        }

        public CodDescricaoColecao ConsultarSangriaTipo()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarSangriaTipo");

                if (dataTable != null)
                    return PreencherSangriaTipo(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public SangriaInfo ConsultarSangriaId(int idcaixa)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", idcaixa);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarSangriaId");

                if (dataTable != null)
                    return PreencherSangria(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public SangriaColecao ConsultarSangriaIdCaixa(int idcaixa)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", idcaixa);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarSangriaIdCaixa");

                if (dataTable != null)
                    return PreencherSangria(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public int InsertSangriaTipo(CodDescricaoInfo descricao)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@descricao", descricao.descricao);

                return accessDbMySql.ExecutarScalarMySql("spInsertSangriaTipo");
            }
            else
                return 0;
        }

        public int InsertSangria(SangriaInfo sangriaInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@func", sangriaInfo.sangriaidfunc);
                accessDbMySql.AddParametrosMySql("@tipo", sangriaInfo.sangriaidtipo);
                accessDbMySql.AddParametrosMySql("@unid", sangriaInfo.sangriaidunidade);
                accessDbMySql.AddParametrosMySql("@obs", sangriaInfo.sangriaobs);
                accessDbMySql.AddParametrosMySql("@valor", sangriaInfo.sangriavalor);
                accessDbMySql.AddParametrosMySql("@turno", sangriaInfo.sangriaidturno);

                return accessDbMySql.ExecutarScalarMySql("spInsertSangria");
            }
            else
                return 0;
        }

        public CaixaTurnoInfo ConsutarCaixaTurnoAnterior(int idcaixa)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@idcaixa", idcaixa);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsutarCaixaTurnoAnterior");
                if (dataTable != null)
                    return PreencherCaixaTurno(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public CaixaTurnoColecao ConsultarCaixaTurnoIdCaixa(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@caixa", id);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarCaixaTurnoIdCaixa");
                if (dataTable != null)
                    return PreencherCaixaTurno(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public CaixaDiaColecao ConsultarCaixaDiaTotal(int idcaixa)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", idcaixa);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarCaixaDiaTotal");
                if (dataTable != null)
                    return PreencherCaixaDiaTotal(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public CaixaDiaColecao ConsultarCaixaDiaTurno(int idturno)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", idturno);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarCaixaDiaTurno");
                if (dataTable != null)
                    return PreencherCaixaDiaTotal(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public CaixaAbrirInfo ConsultarCaixaAberto(int idunid)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@unid", idunid);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarCaixaAberto");
                if (dataTable != null)
                    return PreencherCaixaAbrir(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public int InsertCaixaAbrir(CaixaAbrirInfo caixaAbrirInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@func", caixaAbrirInfo.caixaabriridfunc);
                accessDbMySql.AddParametrosMySql("@valor", caixaAbrirInfo.caixaabrirvalor);
                accessDbMySql.AddParametrosMySql("@unid", caixaAbrirInfo.caixaabriridunidade);

                return accessDbMySql.ExecutarScalarMySql("spInsertCaixaAbrir");
            }
            else
                return 0;
        }

        public int UpdateCaixaFechar(CaixaAbrirInfo caixaFecharInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", caixaFecharInfo.caixaabririd);
                accessDbMySql.AddParametrosMySql("@dataf", caixaFecharInfo.caixafechardata);
                accessDbMySql.AddParametrosMySql("@carne", caixaFecharInfo.caixafecharvalorcarne);
                accessDbMySql.AddParametrosMySql("@credito", caixaFecharInfo.caixafecharvalorcartaocredito);
                accessDbMySql.AddParametrosMySql("@debito", caixaFecharInfo.caixafecharvalorcartaodebito);
                accessDbMySql.AddParametrosMySql("@cheque", caixaFecharInfo.caixafecharvalorcheque);
                accessDbMySql.AddParametrosMySql("@deposito", caixaFecharInfo.caixafecharvalordeposito);
                accessDbMySql.AddParametrosMySql("@dinheiro", caixaFecharInfo.caixafecharvalordinheiro);
                accessDbMySql.AddParametrosMySql("@total", caixaFecharInfo.caixafecharvalortotal);
                accessDbMySql.AddParametrosMySql("@pag", caixaFecharInfo.caixafecharvalorpagamentos);
                accessDbMySql.AddParametrosMySql("@receb", caixaFecharInfo.caixafecharvalorrecebimentos);
                accessDbMySql.AddParametrosMySql("@especie", caixaFecharInfo.caixafecharvalorsaldoespecie);
                accessDbMySql.AddParametrosMySql("@sangria", caixaFecharInfo.caixafecharvalorsangria);
                accessDbMySql.AddParametrosMySql("@func", caixaFecharInfo.caixafecharidfunc);

                return accessDbMySql.ExecutarScalarMySql("spUpdateCaixaFechar");
            }
            else
                return 0;
        }

        private CaixaAbrirColecao PreencherCaixaAbrir(DataTable dataTable)
        {
            CaixaAbrirColecao caixaAbrirColecao = new CaixaAbrirColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                CaixaAbrirInfo caixaAbrirInfo = new CaixaAbrirInfo
                {
                    caixaabrirdata = Convert.ToDateTime(row["caixaabrirdata"]),
                    caixaabririd = Convert.ToInt32(row["caixaabririd"]),
                    caixaabriridfunc = Convert.ToInt32(row["caixaabriridfunc"]),
                    caixaabrirvalor = Convert.ToDecimal(row["caixaabrirvalor"]),
                    caixaabrirfechado = Convert.ToBoolean(row["caixaabrirfechado"]),
                    caixaabriridunidade = Convert.ToInt32(row["caixaabriridunidade"]),

                    caixafechardata = Convert.ToDateTime(row["caixafechardata"]),
                    caixafecharidfunc = Convert.ToInt32(row["caixafecharidfunc"]),
                    caixafecharvalorcarne = Convert.ToDecimal(row["caixafecharvalorcarne"]),
                    caixafecharvalorcartaocredito = Convert.ToDecimal(row["caixafecharvalorcartaocredito"]),
                    caixafecharvalorcartaodebito = Convert.ToDecimal(row["caixafecharvalorcartaodebito"]),
                    caixafecharvalorcheque = Convert.ToDecimal(row["caixafecharvalorcheque"]),
                    caixafecharvalordeposito = Convert.ToDecimal(row["caixafecharvalordeposito"]),
                    caixafecharvalordinheiro = Convert.ToDecimal(row["caixafecharvalordinheiro"]),
                    caixafecharvalorpagamentos = Convert.ToDecimal(row["caixafecharvalorpagamentos"]),
                    caixafecharvalorrecebimentos = Convert.ToDecimal(row["caixafecharvalorrecebimentos"]),
                    caixafecharvalorsaldoespecie = Convert.ToDecimal(row["caixafecharvalorsaldoespecie"]),
                    caixafecharvalorsangria = Convert.ToDecimal(row["caixafecharvalorsangria"]),
                    caixafecharvalortotal = Convert.ToDecimal(row["caixafecharvalortotal"])
                };

                caixaAbrirColecao.Add(caixaAbrirInfo);
            }

            return caixaAbrirColecao;
        }
        
        private CaixaTurnoColecao PreencherCaixaTurno(DataTable dataTable)
        {
            CaixaTurnoColecao caixaTurnoColecao = new CaixaTurnoColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                CaixaTurnoInfo caixaTurnoInfo = new CaixaTurnoInfo
                {
                    caixaturnodata = Convert.ToDateTime(row["caixaturnodata"]),
                    caixaturnoid = Convert.ToInt32(row["caixaturnoid"]),
                    caixaturnoidabrir = Convert.ToInt32(row["caixaturnoidabrir"]),
                    caixaturnoidfuncabrir = Convert.ToInt32(row["caixaturnoidfuncabrir"]),
                    caixaturnonum = Convert.ToInt32(row["caixaturnonum"]),
                    caixaturnovalorcarne = Convert.ToDecimal(row["caixaturnovalorcarne"]),
                    caixaturnovalorcartaocredito = Convert.ToDecimal(row["caixaturnovalorcartaocredito"]),
                    caixaturnovalorcartaodebito = Convert.ToDecimal(row["caixaturnovalorcartaodebito"]),
                    caixaturnovalorcheque = Convert.ToDecimal(row["caixaturnovalorcheque"]),
                    caixaturnovalordeposito = Convert.ToDecimal(row["caixaturnovalordeposito"]),
                    caixaturnovalordinheiro = Convert.ToDecimal(row["caixaturnovalordinheiro"]),
                    caixaturnovalorpagamentos = Convert.ToDecimal(row["caixaturnovalorpagamentos"]),
                    caixaturnovalorrecebimentos = Convert.ToDecimal(row["caixaturnovalorrecebimentos"]),
                    caixaturnovalorsaldoespecie = Convert.ToDecimal(row["caixaturnovalorsaldoespecie"]),
                    caixaturnovalorsangria = Convert.ToDecimal(row["caixaturnovalorsangria"]),
                    caixaturnofechado = Convert.ToBoolean(row["caixaturnofechado"]),
                    caixaturnovalorabrir = Convert.ToDecimal(row["caixaturnovalorabrir"]),
                    caixaturnovalortotal = Convert.ToDecimal(row["caixaturnovalortotal"]),
                    caixaturnodatafechamento = Convert.ToDateTime(row["caixaturnodatafechamento"]),
                    caixaturnoidfuncfechar = Convert.ToInt32(row["caixaturnoidfuncfechar"])
                };

                caixaTurnoColecao.Add(caixaTurnoInfo);
            }

            return caixaTurnoColecao;
        }

        private CodDescricaoColecao PreencherSangriaTipo(DataTable dataTable)
        {
            CodDescricaoColecao codDescricaoColecao = new CodDescricaoColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                CodDescricaoInfo codDescricaoInfo = new CodDescricaoInfo
                {
                    cod = Convert.ToInt32(row["sangriatipoid"]),
                    descricao = Convert.ToString(row["sangriatipodescricao"])
                };

                codDescricaoColecao.Add(codDescricaoInfo);
            }

            return codDescricaoColecao;
        }

        private SangriaColecao PreencherSangria(DataTable dataTable)
        {
            SangriaColecao sangriaColecao = new SangriaColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                SangriaInfo sangriaInfo = new SangriaInfo
                {
                    sangriadatacad = Convert.ToDateTime(row["sangriadatacad"]),
                    sangriaid = Convert.ToInt32(row["sangriaid"]),
                    sangriaidcaixa = Convert.ToInt32(row["sangriaidcaixa"]),
                    sangriaidfunc = Convert.ToInt32(row["sangriaidfunc"]),
                    sangriaidtipo = Convert.ToInt32(row["sangriaidtipo"]),
                    sangriaidunidade = Convert.ToInt32(row["sangriaidunidade"]),
                    sangriaobs = Convert.ToString(row["sangriaobs"]),
                    sangriavalor = Convert.ToDecimal(row["sangriavalor"])
                };

                sangriaColecao.Add(sangriaInfo);
            }

            return sangriaColecao;
        }

        private CaixaDiaColecao PreencherCaixaDiaTotal(DataTable dataTable)
        {
            CaixaDiaColecao caixaDiaColecao = new CaixaDiaColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                CaixaDiaInfo caixaDiaInfo = new CaixaDiaInfo
                {
                    venidturno = Convert.ToInt32(row["caixaturnoidabrir"]),
                    formpagdescricao = Convert.ToString(row["formpagdescricao"]),
                    valor = Convert.ToDecimal(row["pagdetalhesvalor"])
                };

                caixaDiaColecao.Add(caixaDiaInfo);
            }

            return caixaDiaColecao;
        }

        //private CaixaDiaColecao PreencherCaixaDiaTurno(DataTable dataTable)
        //{
        //    CaixaDiaColecao caixaDiaColecao = new CaixaDiaColecao();

        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        CaixaDiaInfo caixaDiaInfo = new CaixaDiaInfo
        //        {
        //            venidturno = Convert.ToInt32(row["venidturno"]),
        //            formpagdescricao = Convert.ToString(row["formpagdescricao"]),
        //            valor = Convert.ToDecimal(row["valor"])
        //        };

        //        caixaDiaColecao.Add(caixaDiaInfo);
        //    }

        //    return caixaDiaColecao;
        //}
    }
}

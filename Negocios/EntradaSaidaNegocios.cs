using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using AccessDB;
using ObjTransfer;

namespace Negocios
{
    public class EntradaSaidaNegocios
    {
        public static string EmpConexao { get; set; }

        public EntradaSaidaNegocios(string conexao)
        {
            EmpConexao = conexao;
        }

        AccessDbMySql accessDbMySql = new AccessDbMySql();


        public int InsertEntradaDiversos(EntradaDiversosInfo diversos)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@entrada", diversos.diversosidentrada);
                accessDbMySql.AddParametrosMySql("@turno", diversos.diversosidturno);

                return accessDbMySql.ExecutarScalarMySql("spInsertEntradaDiversos");
            }
            else
                return 0;
        }

        public int InsertEntradaSaidaCategoria(TipoEntradaSaidaInfo tipoEntradaSaidaInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@descricao", tipoEntradaSaidaInfo.TipoDescricao);
                accessDbMySql.AddParametrosMySql("@tipo", tipoEntradaSaidaInfo.TipoEntSai);

                return accessDbMySql.ExecutarScalarMySql("spInsertEntradaSaidaCategoria");
            }
            else
                return 0;
        }
        
        public int UpdateEntradaSaidaLancamentoConfirmar(EntradaSaidaInfo entradaSaidaInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@pago", entradaSaidaInfo.entravalorpago);
                accessDbMySql.AddParametrosMySql("@venc", entradaSaidaInfo.entradatavenc);
                accessDbMySql.AddParametrosMySql("@id", entradaSaidaInfo.entraid);
                accessDbMySql.AddParametrosMySql("@Confirm", entradaSaidaInfo.entraconfirmada);

                return accessDbMySql.ExecutarScalarMySql("spUpdateEntraLancamentoConfirmar");
            }
            else
                return 0;
        }

        public int UpdateEntradaSaidaLancamentoParcelas(EntradaSaidaInfo entradaSaidaInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@total", entradaSaidaInfo.entranumtotalparcelas);
                accessDbMySql.AddParametrosMySql("@id", entradaSaidaInfo.entraid);

                return accessDbMySql.ExecutarScalarMySql("spUpadateEntradaLancamentoParcelas");
            }
            else
                return 0;
        }

        public int UpdateEntradaSaidaLancamento(EntradaSaidaInfo entradaSaidaInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@venc", entradaSaidaInfo.entradatavenc);
                accessDbMySql.AddParametrosMySql("@obs", entradaSaidaInfo.entraobs);
                accessDbMySql.AddParametrosMySql("@categoria", entradaSaidaInfo.entratipoidcat);
                accessDbMySql.AddParametrosMySql("@valor", entradaSaidaInfo.entravalor);
                accessDbMySql.AddParametrosMySql("@pago", entradaSaidaInfo.entravalorpago);
                accessDbMySql.AddParametrosMySql("@id", entradaSaidaInfo.entraid);

                return accessDbMySql.ExecutarScalarMySql("spUpdateEntradaLancamento");
            }
            else
                return 0;
        }

        public CodDescricaoInfo ConsultarEntradaSaidaPorIdCategoria(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarCategoriaEntradaSaidaIdCat");

                if (dataTable != null)
                    return PreencherEntradaSaidaPorCategoria(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public EntradaSaidaInfo ConsultarEntradaSaidaId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarEntradaSaidaId");

                if (dataTable != null)
                    return PreencherEntradaSaida(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public int UpdateEntradaSaidaLancamentoCodParcelas(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                return accessDbMySql.ExecutarScalarMySql("spUpdateEntradaSaidaLancamentoCodParcela");
            }
            else
                return 0;
        }

        public int InsertEntradaSaidaLancamento(EntradaSaidaInfo entradaSaidaInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@unid", entradaSaidaInfo.entraidunidade);
                accessDbMySql.AddParametrosMySql("@func", entradaSaidaInfo.entraidfunc);
                accessDbMySql.AddParametrosMySql("@venc", entradaSaidaInfo.entradatavenc);
                accessDbMySql.AddParametrosMySql("@numparcela", entradaSaidaInfo.entranumparcela);
                accessDbMySql.AddParametrosMySql("@totalparcela", entradaSaidaInfo.entranumtotalparcelas);
                accessDbMySql.AddParametrosMySql("@obs", entradaSaidaInfo.entraobs);
                accessDbMySql.AddParametrosMySql("@categoria", entradaSaidaInfo.entratipoidcat);
                accessDbMySql.AddParametrosMySql("@valor", entradaSaidaInfo.entravalor);
                accessDbMySql.AddParametrosMySql("@pago", entradaSaidaInfo.entravalorpago);
                accessDbMySql.AddParametrosMySql("@parcelado", entradaSaidaInfo.entraparcelado);
                accessDbMySql.AddParametrosMySql("@confirmada", entradaSaidaInfo.entraconfirmada);
                accessDbMySql.AddParametrosMySql("@doc", entradaSaidaInfo.entradocumento);
                accessDbMySql.AddParametrosMySql("@entrada", entradaSaidaInfo.entraidtipoentrada);

                return accessDbMySql.ExecutarScalarMySql("spInsertEntradaSaidaLancamento");
            }
            else
                return 0;
        }

        public CodDescricaoInfo ConsultarEntradaSaidaCategoriaId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarEntradaSaidaCategoriaId");

                if (dataTable != null)
                    return PreencherCategoria(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public int DesativarEntradaSaidaLancamento(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                return accessDbMySql.ExecutarScalarMySql("spUpdateEntradaLancamentoDesativarId");
            }
            else
                return 0;
        }

        public EntradaSaidaColecao ConsultarEntradaDiversosSaldoIdCaixa(int idcaixa)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", idcaixa);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarEntradaDiversosSaldoIdCaixa");

                if (dataTable != null)
                    return PreencherLancamentoDiversos(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public EntradaSaidaColecao ConsultarEntradaDiversosSaldoIdTurno(int idturno)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", idturno);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarEntradaDiversosSaldoIdTurno");

                if (dataTable != null)
                    return PreencherLancamentoDiversos(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public EntradaSaidaColecao ConsultarEntradaLancamento(EntradaSaidaPesquisar entradaSaidaPesquisar)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@conf", entradaSaidaPesquisar.Confirmado);
                accessDbMySql.AddParametrosMySql("@cat", entradaSaidaPesquisar.Categoria);
                accessDbMySql.AddParametrosMySql("@dataini", entradaSaidaPesquisar.DataInicial);
                accessDbMySql.AddParametrosMySql("@datafim", entradaSaidaPesquisar.DataFinal);
                accessDbMySql.AddParametrosMySql("@tipo", entradaSaidaPesquisar.Tipo);
                accessDbMySql.AddParametrosMySql("@unid", entradaSaidaPesquisar.Unidade);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarEntradaLancamento");

                if (dataTable != null)
                    return PreencherEntradaSaida(dataTable);
                else
                    return null;
            }
            else
                return null;
        }
        
        public CodDescricaoColecao ConsultarCategoriaEntradaSaidaId(string id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarCategoriaEntradaSaidaId");

                if (dataTable != null)
                    return PreencherCategoria(dataTable);
                else
                    return null;
            }
            else
                return null;
        }
        
        private EntradaSaidaColecao PreencherLancamentoDiversos(DataTable dataTable)
        {
            EntradaSaidaColecao entradaSaidaColecao = new EntradaSaidaColecao();
            foreach (DataRow row in dataTable.Rows)
            {
                EntradaSaidaInfo entradaSaidaInfo = new EntradaSaidaInfo
                {
                    entravalorpago = Convert.ToDecimal(row["entravalorpago"]),
                    entraidtipoentrada = Convert.ToInt32(row["entradasaidaid"])
                };

                entradaSaidaColecao.Add(entradaSaidaInfo);
            }

            return entradaSaidaColecao;
        }

        private EntradaSaidaColecao PreencherEntradaSaida(DataTable dataTable)
        {
            EntradaSaidaColecao entradaSaidaColecao = new EntradaSaidaColecao();
            foreach (DataRow row in dataTable.Rows)
            {
                EntradaSaidaInfo entradaSaidaInfo = new EntradaSaidaInfo
                {
                    entracodtodasparcelas = Convert.ToInt32(row["entracodtodasparcelas"]),
                    entraconfirmada = Convert.ToInt32(row["entraconfirmada"]) == 1 ? true: false,
                    entradatalancamento = Convert.ToDateTime(row["entradatalancamento"]),
                    entradatavenc = Convert.ToDateTime(row["entradatavenc"]),
                    entradocumento = Convert.ToString(row["entradocumento"]),
                    entraidfunc = Convert.ToInt32(row["entraidfunc"]),
                    entraid = Convert.ToInt32(row["entraid"]),
                    entranumparcela = Convert.ToInt32(row["entranumparcela"]),
                    entranumtotalparcelas = Convert.ToInt32(row["entranumtotalparcelas"]),
                    entraobs = Convert.ToString(row["entraobs"]),
                    entratipoidcat = Convert.ToInt32(row["entratipoidcat"]),
                    entravalor = Convert.ToDecimal(row["entravalor"]),
                    entravalorpago = Convert.ToDecimal(row["entravalorpago"]),
                    entratipocatdecricao = Convert.ToString(row["entcatdescricao"]),
                    entraidtipoentrada = Convert.ToInt32(row["entraidtipoentrada"]),
                    entraidunidade = Convert.ToInt32(row["entraidunidade"]),
                    entraparcelado = Convert.ToInt32(row["entraparcelado"]) == 1 ? true : false,
                    identradasaida = Convert.ToInt32(row["entradasaidaid"])
                };

                entradaSaidaColecao.Add(entradaSaidaInfo);
            }

            return entradaSaidaColecao;
        }

        private CodDescricaoColecao PreencherEntradaSaidaPorCategoria(DataTable dataTable)
        {
            CodDescricaoColecao codDescricaoColecao = new CodDescricaoColecao();
            foreach (DataRow row in dataTable.Rows)
            {
                CodDescricaoInfo codDescricaoInfo = new CodDescricaoInfo
                {
                    cod = Convert.ToInt32(row["entradasaidaid"]),
                    descricao = Convert.ToString(row["entradasiadadescricao"]).Trim()
                };

                codDescricaoColecao.Add(codDescricaoInfo);
            }

            return codDescricaoColecao;
        }

        private CodDescricaoColecao PreencherCategoria(DataTable dataTable)
        {
            CodDescricaoColecao codDescricaoColecao = new CodDescricaoColecao();
            foreach (DataRow row in dataTable.Rows)
            {
                CodDescricaoInfo codDescricaoInfo = new CodDescricaoInfo
                {
                    cod = Convert.ToInt32(row["entcatid"]),
                    descricao = Convert.ToString(row["entcatdescricao"]).Trim()
                };

                codDescricaoColecao.Add(codDescricaoInfo);
            }

            return codDescricaoColecao;
        }
    }
}

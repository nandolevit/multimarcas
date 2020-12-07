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
    public class ServicoNegocio
    {
        private static string EmpConexao { get; set; }

        public ServicoNegocio(string conexao)
        {
            EmpConexao = conexao;
        }

        AccessDbMySql accessDbMySql = new AccessDbMySql();

        public bool UpdateTaxa(decimal v)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@taxa", v);
                return accessDbMySql.ExecutarComandoMySql("spUpdateTaxa");
            }
            else
                return false;
        }

        public decimal ConsultarTaxa()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dt = accessDbMySql.dataTableMySql("spConsultarTaxa");
                if (dt != null)
                {
                    return Convert.ToDecimal(dt.Rows[0][1]);
                }
                else
                    return 0;
            }
            else
                return 0;
        }

        public int InsertLoja(string loja)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@loja", loja);
                return accessDbMySql.ExecutarScalarMySql("spInsertLoja");
            }
            else
                return 0;
        }

        public int UpdateServicoConfirmVenda(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);
                return accessDbMySql.ExecutarScalarMySql("spUpdateServicoConfirmVenda");
            }
            else
                return 0;
        }

        public ServicoOrcamentoColecao ConsultarServicoOrcamentoOsProd(ServicoOrcamentoInfo orc)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {

                accessDbMySql.AddParametrosMySql("@id", orc.servicoorcamentoidserv);
                accessDbMySql.AddParametrosMySql("@idprod", orc.servicoorcamentoidprod);

                DataTable dataTable = new DataTable();

                dataTable = accessDbMySql.dataTableMySql("spConsultarServicoOrcamentoOsProd");

                if (dataTable != null)
                    return PreencherServicoOrcamento(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public int UpdateServicoTaxa(ServicoOrcamentoInfo orc)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@os", orc.servicoorcamentoidserv);
                accessDbMySql.AddParametrosMySql("@taxa", orc.servicoorcamentovalordesc);
                return accessDbMySql.ExecutarScalarMySql("spUpdateServicoTaxa");
            }
            else
                return 0;
        }

        public int DeleteServOrcamento(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);
                return accessDbMySql.ExecutarScalarMySql("spDeleteServOrcamento");
            }
            else
                return 0;
        }

        public int InsertServicoOrcamento(ServicoOrcamentoInfo serorcamento)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@prod", serorcamento.servicoorcamentoidprod);
                accessDbMySql.AddParametrosMySql("@serv", serorcamento.servicoorcamentoidserv);
                accessDbMySql.AddParametrosMySql("@quant", serorcamento.servicoorcamentoquant);
                accessDbMySql.AddParametrosMySql("@valordesc", serorcamento.servicoorcamentovalordesc);
                accessDbMySql.AddParametrosMySql("@unit", serorcamento.servicoorcamentovalorunit);
                accessDbMySql.AddParametrosMySql("@ativo", serorcamento.servicoorcamentotaxaativo);

                return accessDbMySql.ExecutarScalarMySql("spInsertServicoOrcamento");
            }
            else
                return 0;
        }

        public ServicoOrcamentoColecao ConsultarServicoOrcamento(int os)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {

                accessDbMySql.AddParametrosMySql("@id", os);

                DataTable dataTable = new DataTable();

                dataTable = accessDbMySql.dataTableMySql("spConsultarServicoOrcamentoOs");

                if (dataTable != null)
                    return PreencherServicoOrcamento(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        private ServicoOrcamentoColecao PreencherServicoOrcamento(DataTable dataTable)
        {
            ServicoOrcamentoColecao colecao = new ServicoOrcamentoColecao();
            foreach (DataRow row in dataTable.Rows)
            {
                ServicoOrcamentoInfo taxa = new ServicoOrcamentoInfo
                {
                    servicoorcamentoid = Convert.ToInt32(row["servicoorcamentoid"]),
                    servicoorcamentoidprod = Convert.ToInt32(row["servicoorcamentoidprod"]),
                    servicoorcamentoidserv = Convert.ToInt32(row["servicoorcamentoidserv"]),
                    servicoorcamentoquant = Convert.ToDecimal(row["servicoorcamentoquant"]),
                    servicoorcamentovalordesc = Convert.ToDecimal(row["servicoorcamentovalordesc"]),
                    servicoorcamentovalorunit = Convert.ToDecimal(row["servicoorcamentovalorunit"]),
                    servicoorcamentotaxaativo = Convert.ToBoolean(row["servicoorcamentotaxaativo"])
                };
                colecao.Add(taxa);
            }

            return colecao;
        }
        
        public GridConsultarServicoListaColecao ConsultarServicoPeriodo(string garantia, string atend, string status, DateTime dataini, DateTime datafim)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("func", atend);
                accessDbMySql.AddParametrosMySql("stat", status);
                accessDbMySql.AddParametrosMySql("dataini", dataini);
                accessDbMySql.AddParametrosMySql("datafim", datafim);
                accessDbMySql.AddParametrosMySql("garantia", garantia);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarServicoPeriodo");

                if (dataTable != null)
                    return PreencherServicoLista(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public int UpdateServicoStatus(int os, int status, DateTime final)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", os);
                accessDbMySql.AddParametrosMySql("@stat", status);
                accessDbMySql.AddParametrosMySql("@final", final);
                return accessDbMySql.ExecutarScalarMySql("spUpdateServicoStatus");
            }
            else
                return 0;
        }

        public int UpdateServicoAlter(ServicoInfo servico)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", servico.serid);
                accessDbMySql.AddParametrosMySql("@stat", servico.seridstatus);
                accessDbMySql.AddParametrosMySql("@taxa", servico.sertaxa);
                accessDbMySql.AddParametrosMySql("@obs", servico.serobs);
                accessDbMySql.AddParametrosMySql("@agend", servico.serdataagend);
                accessDbMySql.AddParametrosMySql("@resp", servico.seridtecresp);
                accessDbMySql.AddParametrosMySql("@defeito", servico.serdefeitodescricao);

                return accessDbMySql.ExecutarScalarMySql("spUpdateServicoAlter");
            }
            else
                return 0;
        }

        public GridConsultarServicoListaColecao ConsultarOsPorNomeCliente(string nome)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@nome", nome);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarOsPorNomeCliente");

                if (dataTable != null)
                    return PreencherServicoLista(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public CodDescricaoColecao ConsultarStatus()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarStatus");

                if (dataTable != null)
                {
                    CodDescricaoColecao colecao = new CodDescricaoColecao();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        CodDescricaoInfo codDescricaoInfo = new CodDescricaoInfo
                        {
                            cod = Convert.ToInt32(row["statusid"]),
                            descricao = Convert.ToString(row["statusdescricao"])
                        };

                        colecao.Add(codDescricaoInfo);
                    }

                    return colecao;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public GridConsultarServicoListaColecao ConsultarServicoListaOs(int os)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@os", os);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarViewServicoPorOs");

                if (dataTable != null)
                    return PreencherServicoLista(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public GridConsultarServicoListaColecao ConsultarServico3meses()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarServico3meses");

                if (dataTable != null)
                    return PreencherServicoLista(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public ProdEletroInfo ConsultarEletroId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@eletro", id);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarEletroId");

                if (dataTable != null)
                    return PreencherEletro(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public int InsertTipoEletro(string nome)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@nome", nome);

                return accessDbMySql.ExecutarScalarMySql("spInsertTipoEletro");
            }
            else
                return 0;
        }

        public NotaColecao ConsultarNotaClienteId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarNotaClienteId");

                if (dataTable != null)
                    return PreencherDataTableNota(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public NotaInfo ConsultarvNotaEletroId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarvNotaEletroId");

                if (dataTable != null)
                    return PreencherDataTableNota(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public ProdEletroColecao ConsultarvEletroNotaId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarvEletroNotaId");

                if (dataTable != null)
                    return PreencherEletro(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public NotaInfo ConsultarNotaId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarNotaId");

                if (dataTable != null)
                    return PreencherDataTableNota(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        private NotaColecao PreencherDataTableNota(DataTable dataTable)
        {
            NotaColecao notaColecao = new NotaColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                TimeSpan timeSpan = new TimeSpan();
                timeSpan = DateTime.Now.Date - Convert.ToDateTime(row["notEmissao"]);

                NotaInfo notaInfo = new NotaInfo
                {
                    notEmissao = Convert.ToDateTime(row["notEmissao"]),
                    notId = Convert.ToInt32(row["notId"]),
                    notIdAutorizada = Convert.ToInt32(row["notIdAutorizada"]),
                    notIdCliente = Convert.ToInt32(row["notIdCliente"]),
                    notIdFunc = Convert.ToInt32(row["notIdFunc"]),
                    notIdloja = Convert.ToInt32(row["notIdloja"]),
                    notNome = Convert.ToString(row["notNome"]),
                    notNumSerie = Convert.ToString(row["notNumSerie"]),
                    notObs = Convert.ToString(row["notObs"]),
                    notNum = Convert.ToString(row["notNum"]),
                    notVencimento = timeSpan.Days + " dias corridos!",
                    notideletro = Convert.ToInt32(row["notaeletroId"]),
                };

                notaColecao.Add(notaInfo);
            }

            return notaColecao;
        }

        public int UpdateNota(NotaInfo nota)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@cli", nota.notIdCliente);
                accessDbMySql.AddParametrosMySql("@auto", nota.notIdAutorizada);
                accessDbMySql.AddParametrosMySql("@loja", nota.notIdloja);
                accessDbMySql.AddParametrosMySql("@nome", nota.notNome);
                accessDbMySql.AddParametrosMySql("@serie", nota.notNumSerie);
                accessDbMySql.AddParametrosMySql("@emissao", nota.notEmissao);
                accessDbMySql.AddParametrosMySql("@obs", nota.notObs);
                accessDbMySql.AddParametrosMySql("@func", nota.notIdFunc);
                accessDbMySql.AddParametrosMySql("@num", nota.notNum);
                accessDbMySql.AddParametrosMySql("@id", nota.notId);

                return accessDbMySql.ExecutarScalarMySql("spUpdateNota");
            }
            else
                return 0;
        }

        public int InsertNota(NotaInfo nota)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@cli", nota.notIdCliente);
                accessDbMySql.AddParametrosMySql("@auto", nota.notIdAutorizada);
                accessDbMySql.AddParametrosMySql("@loja", nota.notIdloja);
                accessDbMySql.AddParametrosMySql("@nome", nota.notNome);
                accessDbMySql.AddParametrosMySql("@serie", nota.notNumSerie);
                accessDbMySql.AddParametrosMySql("@emissao", nota.notEmissao);
                accessDbMySql.AddParametrosMySql("@obs", nota.notObs);
                accessDbMySql.AddParametrosMySql("@func", nota.notIdFunc);
                accessDbMySql.AddParametrosMySql("@num", nota.notNum);

                return accessDbMySql.ExecutarScalarMySql("spInsertNota");
            }
            else
                return 0;
        }

        public int UpdateNotaEletro(int prod, int nota)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@prod", prod);
                accessDbMySql.AddParametrosMySql("@nota", nota);

                return accessDbMySql.ExecutarScalarMySql("spUpdateNotaEletro");
            }
            else
                return 0;
        }

        public int InsertNotaEletro(int prod, int nota)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@prod", prod);
                accessDbMySql.AddParametrosMySql("@nota", nota);

                return accessDbMySql.ExecutarScalarMySql("spInsertNotaEletro");
            }
            else
                return 0;
        }

        public AutorizadaInfo ConsultarAutorizadaConfirmada()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();
                
                dataTable = accessDbMySql.dataTableMySql("spConsultarAutorizadaConfirm");

                if (dataTable != null)
                {
                    return PreencherDataTableAutorizada(dataTable)[0];
                }
                else
                    return null;
            }
            else
                return null;
        }

        public AutorizadaInfo ConsultarAutorizadaId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();

                accessDbMySql.AddParametrosMySql("@id", id);
                dataTable = accessDbMySql.dataTableMySql("spConsultarAutorizadaConfirmId");

                if (dataTable != null)
                {
                    return PreencherDataTableAutorizada(dataTable)[0];
                }
                else
                    return null;
            }
            else
                return null;
        }

        public AutorizadaColecao ConsultarAutorizada()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();

                dataTable = accessDbMySql.dataTableMySql("spConsultarAutorizada");

                if (dataTable != null)
                {
                    return PreencherDataTableAutorizada(dataTable);
                }
                else
                    return null;
            }
            else
                return null;
        }

        private AutorizadaColecao PreencherDataTableAutorizada(DataTable dataTable)
        {
            AutorizadaColecao autorizadaColecao = new AutorizadaColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                AutorizadaInfo autorizadaInfo = new AutorizadaInfo
                {
                    autbairro = Convert.ToString(row["autbairro"]),
                    autcep = Convert.ToString(row["autcep"]),
                    autcidade = Convert.ToString(row["autcidade"]),
                    autcnpj = Convert.ToString(row["autcnpj"]),
                    autcomplemento = Convert.ToString(row["autcomplemento"]),
                    autcontroleDataHora = Convert.ToDateTime(row["autcontroleDataHora"]),
                    autemail = Convert.ToString(row["autemail"]),
                    autid = Convert.ToInt32(row["autid"]),
                    autlogradouro = Convert.ToString(row["autlogradouro"]),
                    autnome = Convert.ToString(row["autnome"]),
                    auttelefone = Convert.ToString(row["auttelefone"]),
                    autuf = Convert.ToString(row["autuf"])
                };

                autorizadaColecao.Add(autorizadaInfo);
            }

            return autorizadaColecao;
        }

        public EletroLojaInfo ConsultarEletroLojaId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();

                accessDbMySql.AddParametrosMySql("@id", id);
                dataTable = accessDbMySql.dataTableMySql("spConsultarEletroLojaId");

                if (dataTable != null)
                {
                    return PreencherDataTableEletroLoja(dataTable)[0];
                }
                else
                    return null;
            }
            else
                return null;
        }

        public EletroLojaColecao ConsultarEletroLoja()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarEletroLoja");

                if (dataTable != null)
                {
                    return PreencherDataTableEletroLoja(dataTable);
                }
                else
                    return null;
            }
            else
                return null;
        }

        private EletroLojaColecao PreencherDataTableEletroLoja(DataTable dataTable)
        {
            EletroLojaColecao eletroLojaColecao = new EletroLojaColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                EletroLojaInfo eletroLojaInfo = new EletroLojaInfo
                {
                    LojDescricao = Convert.ToString(row["LojDescricao"]).Trim(),
                    LojId = Convert.ToInt32(row["LojId"])
                };

                eletroLojaColecao.Add(eletroLojaInfo);
            }

            return eletroLojaColecao;
        }

        public TipoServInfo ConsultarTipoServId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarTipoServId");

                if (dataTable != null)
                {
                    return PreencherDataTableTipoServ(dataTable)[0];
                }
                else
                    return null;
            }
            else
                return null;
        }

        public TipoServColecao ConsultarTipoServ()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {

                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarTipoServ");

                if (dataTable != null)
                {
                    return PreencherDataTableTipoServ(dataTable);
                }
                else
                    return null;
            }
            else
                return null;
        }

        private TipoServColecao PreencherDataTableTipoServ(DataTable dataTable)
        {
            TipoServColecao tipoServColecao = new TipoServColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                TipoServInfo tipoServInfo = new TipoServInfo
                {
                    TipDescricao = Convert.ToString(row["tipDescricao"]),
                    TipId = Convert.ToInt32(row["tipId"])
                };

                tipoServColecao.Add(tipoServInfo);
            }

            return tipoServColecao;
        }

        public int UpdateProdEletro(ProdEletroInfo prodEletroInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", prodEletroInfo.idCadEle);
                accessDbMySql.AddParametrosMySql("@eletro", prodEletroInfo.ideletrocad);
                accessDbMySql.AddParametrosMySql("@marca", prodEletroInfo.idmarcacad);
                accessDbMySql.AddParametrosMySql("@serie", prodEletroInfo.cadeleserie);
                accessDbMySql.AddParametrosMySql("@modelo", prodEletroInfo.cadelemodelo);
                accessDbMySql.AddParametrosMySql("@pnc", prodEletroInfo.cadelepnc);
                accessDbMySql.AddParametrosMySql("@obs", prodEletroInfo.cadeleobs);
                accessDbMySql.AddParametrosMySql("@chamado", prodEletroInfo.cadelechamado);

                return accessDbMySql.ExecutarScalarMySql("spUpdateProdEletro");
            }
            else
                return 0;
        }

        public ProdEletroInfo ConsultarEletroNotaId(int nota)
        {
            ProdEletroColecao prodEletroColecao = new ProdEletroColecao();
            DataTable dataTable = new DataTable();

            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@nota", nota);
                dataTable = accessDbMySql.dataTableMySql("spConsultarProdNotaId");

                if (dataTable != null)
                {
                    return PreencherEletro(dataTable)[0];
                }
                else
                    return null;
            }
            else
                return null;
        }

        public ProdEletroInfo ConsultarEletroClienteId(int cli, int ele)
        {
            ProdEletroColecao prodEletroColecao = new ProdEletroColecao();
            DataTable dataTable = new DataTable();

            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@idCliente", cli);
                accessDbMySql.AddParametrosMySql("@id", ele);
                dataTable = accessDbMySql.dataTableMySql("spConsultarProdClienteId");

                if (dataTable != null)
                {
                    return PreencherEletro(dataTable)[0];
                }
                else
                    return null;
            }
            else
                return null;
        }

        public ProdEletroColecao ConsultarEletroCliente(int id)
        {
            ProdEletroColecao prodEletroColecao = new ProdEletroColecao();
            DataTable dataTable = new DataTable();

            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@idCliente", id);
                dataTable = accessDbMySql.dataTableMySql("spConsultarProdCliente");

                if (dataTable != null)
                {
                   return PreencherEletro(dataTable);
                }
                else
                    return null;
            }
            else
                return null;
        }

        private ProdEletroColecao PreencherEletro(DataTable dataTable)
        {
            ProdEletroColecao prodEletroColecao = new ProdEletroColecao();

            foreach (DataRow row in dataTable.Rows)
            {
                ProdEletroInfo prodEletroInfo = new ProdEletroInfo
                {
                    cadelemodelo = Convert.ToString(row["cadelemodelo"]),
                    cadeleobs = Convert.ToString(row["cadeleobs"]),
                    cadelepnc = Convert.ToString(row["cadelepnc"]),
                    cadeleserie = Convert.ToString(row["cadeleserie"]),
                    idCadEle = Convert.ToInt32(row["idCadEle"]),
                    idclientecad = Convert.ToInt32(row["idclientecad"]),
                    ideletrocad = Convert.ToInt32(row["ideletrocad"]),
                    idmarcacad = Convert.ToInt32(row["autid"]),
                    eletrocad = Convert.ToString(row["elenome"]),
                    marcacad = Convert.ToString(row["autnome"]),
                    descricao = (Convert.ToString(row["elenome"])) + "/" + (Convert.ToString(row["autnome"])) + " Mod: " + (Convert.ToString(row["cadelemodelo"])) +
                    " Série: " + (Convert.ToString(row["cadeleserie"])) + " PNC: " + (Convert.ToString(row["cadelepnc"])) +
                    " Obs: " + (Convert.ToString(row["cadeleobs"])),
                    cadelechamado = Convert.ToString(row["cadelechamado"])
                };

                prodEletroColecao.Add(prodEletroInfo);
            }

            return prodEletroColecao;
        }

        public EletroTipoInfo ConsultarEletroTipoId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("id", id);

                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarProdEletroId");
                
                if (dataTable != null)
                    return PreencherProdEletroTipo(dataTable)[0];
                else
                    return null;
            }
            else
                return null;

        }

        public int InsertProdEletro(ProdEletroInfo prodEletroInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@eletro", prodEletroInfo.ideletrocad);
                accessDbMySql.AddParametrosMySql("@marca", prodEletroInfo.idmarcacad);
                accessDbMySql.AddParametrosMySql("@modelo", prodEletroInfo.cadelemodelo);
                accessDbMySql.AddParametrosMySql("@serie", prodEletroInfo.cadeleserie);
                accessDbMySql.AddParametrosMySql("@pnc", prodEletroInfo.cadelepnc);
                accessDbMySql.AddParametrosMySql("@obs", prodEletroInfo.cadeleobs);
                accessDbMySql.AddParametrosMySql("@cliente", prodEletroInfo.idclientecad);
                accessDbMySql.AddParametrosMySql("@chamado", prodEletroInfo.cadelechamado);

                return accessDbMySql.ExecutarScalarMySql("spInsertProdEletro");
            }
            else
                return 0;
        }

        public EletroTipoColecao ConsultarEletroTipo()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarEletro");
                return PreencherProdEletroTipo(dataTable);
            }
            else
                return null; 
        }

        private EletroTipoColecao PreencherProdEletroTipo(DataTable dataTable)
        {
            if (dataTable != null)
            {
                EletroTipoColecao eletroTipoColecao = new EletroTipoColecao();

                foreach (DataRow linhas in dataTable.Rows)
                {
                    EletroTipoInfo eletroTipoInfo = new EletroTipoInfo();
                    eletroTipoInfo.Cod = Convert.ToInt32(linhas["ideletro"]);
                    eletroTipoInfo.Descricao = Convert.ToString(linhas["eleNome"]).Trim();

                    eletroTipoColecao.Add(eletroTipoInfo);
                }

                return eletroTipoColecao;
            }
            else
                return null;
            
        }

        public int InsertServico(ServicoInfo servicoInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@idCliente", servicoInfo.seridcliente);
                accessDbMySql.AddParametrosMySql("@idEnd", servicoInfo.seridend);
                accessDbMySql.AddParametrosMySql("@Obs", servicoInfo.serobs);
                accessDbMySql.AddParametrosMySql("@taxa", servicoInfo.sertaxa);
                accessDbMySql.AddParametrosMySql("@func", servicoInfo.seridfunc);
                accessDbMySql.AddParametrosMySql("@dataAgend", servicoInfo.serdataagend);
                accessDbMySql.AddParametrosMySql("@unidade", servicoInfo.seridunid);
                accessDbMySql.AddParametrosMySql("@eletro", servicoInfo.serideletro);
                accessDbMySql.AddParametrosMySql("@garantia", servicoInfo.sergarantia);
                accessDbMySql.AddParametrosMySql("@tipo", servicoInfo.seridtipo);
                accessDbMySql.AddParametrosMySql("@stus", servicoInfo.seridstatus);
                accessDbMySql.AddParametrosMySql("@resp", servicoInfo.seridtecresp);
                accessDbMySql.AddParametrosMySql("@defeito", servicoInfo.serdefeitodescricao);

                return accessDbMySql.ExecutarScalarMySql("spInsertServico");
            }
            else
                return 0;
        }

        public ServicoInfo ConsultarServicoPorOs(int Os)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@os", Os);

                DataTable dataTable = new DataTable();
                ServicoColecao servicoColecao = new ServicoColecao();
                dataTable = accessDbMySql.dataTableMySql("spConsultarViewServicoPorOs");
                servicoColecao = PreencherServicoColecao(dataTable);

                if (servicoColecao != null)
                {
                    ServicoInfo servicoInfo = new ServicoInfo
                    {
                        serid = servicoColecao[0].serid,
                        seridcliente = servicoColecao[0].seridcliente,
                        seridend = servicoColecao[0].seridend,
                        serdescricao = servicoColecao[0].serdescricao,
                        serobs = servicoColecao[0].serobs,
                        serdataagend = servicoColecao[0].serdataagend,
                        serdatacad = servicoColecao[0].serdatacad,
                        seridfunc = servicoColecao[0].seridfunc,
                        sertaxa = servicoColecao[0].sertaxa,
                        seridunid = servicoColecao[0].seridunid,
                        seridstatus = servicoColecao[0].seridstatus,
                        sernomefunc = servicoColecao[0].sernomefunc,
                        sergarantia = servicoColecao[0].sergarantia,
                        serideletro = servicoColecao[0].serideletro,
                        serstatusdescricao = servicoColecao[0].serstatusdescricao,
                        seridtecresp = servicoColecao[0].seridtecresp,
                        serdefeitodescricao = servicoColecao[0].serdefeitodescricao,
                        servendaconfirm = servicoColecao[0].servendaconfirm,
                        serdatafinalizada = servicoColecao[0].serdatafinalizada,
                    };

                    return servicoInfo;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public ServicoColecao ConsultarOsPorIdEletro(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@eletro", id);

                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarServEletroId");

                return PreencherServicoColecao(dataTable);
            }
            else
                return null;
        }

        private GridConsultarServicoListaColecao PreencherServicoLista(DataTable dataTable)
        {
            FuncNegocios funcNegocios = new FuncNegocios(EmpConexao);
            GridConsultarServicoListaColecao colecao = new GridConsultarServicoListaColecao();
            ClienteNegocios clienteNegocios = new ClienteNegocios(EmpConexao);

            if (dataTable != null)
            {
                ServicoColecao servico = PreencherServicoColecao(dataTable);

                foreach (ServicoInfo linhas in servico)
                {
                    GridConsultarServicoLista gridConsultarServicoLista = new GridConsultarServicoLista
                    {
                        Os = string.Format("{0:0000000}", linhas.serid),
                        Atendente  = linhas.sernomefunc,
                        Cliente = clienteNegocios.ConsultarClientePorId(linhas.seridcliente).clinome,
                        Eletro = linhas.serdescricao,
                        Entrada = string.Format("{0:ddd, dd/MM/yyyy}", linhas.serdataagend).ToUpper(),
                        Status = linhas.serstatusdescricao,
                        Tecnico = funcNegocios.ConsultarFuncPorId(linhas.seridtecresp).funNome,
                    };

                    colecao.Add(gridConsultarServicoLista);
                }

                return colecao;
            }
            else
                return colecao;
        }

        private ServicoColecao PreencherServicoColecao(DataTable dataTable)
        {
            ServicoColecao servicoColecao = new ServicoColecao();
            
            if (dataTable != null)
            {
                foreach (DataRow linhas in dataTable.Rows)
                {
                    ServicoInfo servicoInfo = new ServicoInfo
                    {
                        serid = Convert.ToInt32(linhas["serOS"]),
                        seridcliente = Convert.ToInt32(linhas["serIdCliente"]),
                        seridend = Convert.ToInt32(linhas["serIdEnd"]),
                        serdescricao = (Convert.ToString(linhas["elenome"])) + "/" + (Convert.ToString(linhas["autnome"])) + " Mod: " + (Convert.ToString(linhas["cadelemodelo"])) +
                    " Série: " + (Convert.ToString(linhas["cadeleserie"])) + " PNC: " + (Convert.ToString(linhas["cadelepnc"])) +
                    " Obs: " + (Convert.ToString(linhas["cadeleobs"])),
                        sertaxa = Convert.ToDecimal(linhas["serTaxa"]),
                        serobs = linhas["serObs"].ToString(),
                        serdataagend = (DateTime)linhas["serDataAgend"],
                        serdatacad = (DateTime)linhas["serDataCad"],
                        seridfunc = Convert.ToInt32(linhas["serIdFunc"]),
                        seridunid = Convert.ToInt32(linhas["serIdUnidade"]),
                        serideletro = Convert.ToInt32(linhas["serIdEletro"]),
                        sergarantia = Convert.ToBoolean(linhas["serGarantia"]),
                        sergarantiadescricao = Convert.ToInt32(linhas["serGarantia"]) == 0 ? "NÃO": "SIM",
                        sertipodescricao = Convert.ToString(linhas["tipDescricao"]),
                        seridtipo = Convert.ToInt32(linhas["serTipo"]),
                        sernomefunc = Convert.ToString(linhas["funNome"]),
                        serstatusdescricao = Convert.ToString(linhas["statusdescricao"]),
                        seridstatus = Convert.ToInt32(linhas["serStatus"]),
                        seridtecresp = Convert.ToInt32(linhas["serTecResponsavel"]),
                        serdefeitodescricao = Convert.ToString(linhas["serdefeito"]),
                        servendaconfirm = Convert.ToBoolean(linhas["servendaconfirm"]),
                        serdatafinalizada = (DateTime)linhas["serdatafinalizada"],
                    };

                    servicoColecao.Add(servicoInfo);
                }

                return servicoColecao;
            }
            else
                return null;
        }

        public bool InserirObsTec(ServicoObsTecInfo servicoObsTecInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@fun", servicoObsTecInfo.IdFunc);
                accessDbMySql.AddParametrosMySql("@os", servicoObsTecInfo.IdOs);
                accessDbMySql.AddParametrosMySql("@tec", servicoObsTecInfo.ObsTec);

                return accessDbMySql.ExecutarComandoMySql("spInsertObsTec");
            }
            else
                return false;
        }

        public ServicoObsTecColecao ConsultarObsTecPorIdOs(int IdOs)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@os", IdOs);

                UserInfo userInfo = new UserInfo();
                DataTable dataTable = new DataTable();
                ServicoObsTecColecao servicoObsTecColecao = new ServicoObsTecColecao();

                dataTable = accessDbMySql.dataTableMySql("spConsultarServicoObsTecPorOs");

                if (dataTable != null)
                {
                    foreach (DataRow linhas in dataTable.Rows)
                    {
                        ServicoObsTecInfo servicoObsTecInfo = new ServicoObsTecInfo();

                        servicoObsTecInfo.IdObs = Convert.ToInt32(linhas["obsId"]);
                        servicoObsTecInfo.IdFunc = Convert.ToInt32(linhas["obsIdFun"]);
                        servicoObsTecInfo.IdOs = Convert.ToInt32(linhas["obsIdOs"]);
                        servicoObsTecInfo.ObsTec = Convert.ToString(linhas["obsTec"]);
                        servicoObsTecInfo.ControleTemp = Convert.ToDateTime(linhas["obsControleTemp"]);
                        servicoObsTecInfo.NomeFunc = Convert.ToString(linhas["funNome"]);

                        servicoObsTecColecao.Add(servicoObsTecInfo);
                    }

                    return servicoObsTecColecao;
                }
                else
                    return null;
            }
            else
                return null;
        }


    }
}

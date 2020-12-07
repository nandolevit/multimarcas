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
    public class ClienteNegocios
    {
        enum Tipo { Id, Cpf, Nome, Email, Telefone }
        private static string EmpConexao { get; set; }

        public ClienteNegocios(string conexao)
        {
            EmpConexao = conexao;
        }

        AccessDbMySql accessDbMySql = new AccessDbMySql();

        public int UpdateDefinirEnderecoPadrao(EnderecoInfo enderecoInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@endereco", enderecoInfo.IdEnd);
                accessDbMySql.AddParametrosMySql("@cliente", enderecoInfo.IdCliente);

                return accessDbMySql.ExecutarScalarMySql("spUpdateDefinirEnderecoPadrao");
            }
            else
                return 0;
        }

        public ClienteInfo ConsultarClientePadrao()
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarClientePadrao");

                if (dataTable != null)
                    return PreencherClienteColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public int Inserir(ClienteInfo clienteInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@nome", clienteInfo.clinome);
                accessDbMySql.AddParametrosMySql("@cpf", clienteInfo.clicpf);
                accessDbMySql.AddParametrosMySql("@niver", clienteInfo.cliniver);
                accessDbMySql.AddParametrosMySql("@email", clienteInfo.cliemail);
                accessDbMySql.AddParametrosMySql("@tel", clienteInfo.clitel);
                accessDbMySql.AddParametrosMySql("@user", clienteInfo.cliiduser);
                accessDbMySql.AddParametrosMySql("@padrao", clienteInfo.clipadrao);

                return Convert.ToInt32(accessDbMySql.ExecutarScalarMySql("spInsertCliente"));
            }
            else
                return 0;
        }

        public int UpdateEndereco(EnderecoInfo enderecoInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@idEndereco", enderecoInfo.IdEnd);
                accessDbMySql.AddParametrosMySql("@cep", enderecoInfo.Cep);
                accessDbMySql.AddParametrosMySql("@complemento", enderecoInfo.Complemento);
                accessDbMySql.AddParametrosMySql("@referencia", enderecoInfo.PontoReferencia);
                accessDbMySql.AddParametrosMySql("@logradouro", enderecoInfo.endLogradouro);
                accessDbMySql.AddParametrosMySql("@bairro", enderecoInfo.endBairro);
                accessDbMySql.AddParametrosMySql("@cidade", enderecoInfo.endCidade);
                accessDbMySql.AddParametrosMySql("@uf", enderecoInfo.endUf);

                return accessDbMySql.ExecutarScalarMySql("spUpdateEndCliente");
            }
            else
                return 0;
        }

        public int InserirEndereco(EnderecoInfo enderecoInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@cep", enderecoInfo.Cep);
                accessDbMySql.AddParametrosMySql("@complemento", enderecoInfo.Complemento);
                accessDbMySql.AddParametrosMySql("@referencia", enderecoInfo.PontoReferencia);
                accessDbMySql.AddParametrosMySql("@cliente", enderecoInfo.IdCliente);
                accessDbMySql.AddParametrosMySql("@logradouro", enderecoInfo.endLogradouro);
                accessDbMySql.AddParametrosMySql("@bairro", enderecoInfo.endBairro);
                accessDbMySql.AddParametrosMySql("@cidade", enderecoInfo.endCidade);
                accessDbMySql.AddParametrosMySql("@uf", enderecoInfo.endUf);
                accessDbMySql.AddParametrosMySql("@padrao", enderecoInfo.endpadrao);

                return accessDbMySql.ExecutarScalarMySql("spInsertEndCliente");
            }
            else
                return 0;
        }

        public bool Alterar(ClienteInfo clienteInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", clienteInfo.cliid);
                accessDbMySql.AddParametrosMySql("@nome", clienteInfo.clinome);
                accessDbMySql.AddParametrosMySql("@cpf", clienteInfo.clicpf);
                accessDbMySql.AddParametrosMySql("@niver", clienteInfo.cliniver);
                accessDbMySql.AddParametrosMySql("@email", clienteInfo.cliemail);
                accessDbMySql.AddParametrosMySql("@tel", clienteInfo.clitel);

                accessDbMySql.ExecutarComandoMySql("spUpdateCliente");

                return true;
            }
            else
                return false;
        }

        private EnderecoColecao PreencherColecaoEnd(DataTable dataTable)
        {
            EnderecoColecao enderecoColecao = new EnderecoColecao();

            if (dataTable != null)
            {
                foreach (DataRow linhas in dataTable.Rows)
                {
                    EnderecoInfo enderecoInfo = new EnderecoInfo
                    {
                        IdEnd = Convert.ToInt32(linhas["idEnd"]),
                        IdCliente = Convert.ToInt32(linhas["endIdCliente"]),
                        Cep = Convert.ToString(linhas["endCep"]),
                        Complemento = Convert.ToString(linhas["endComplemento"]),
                        PontoReferencia = Convert.ToString(linhas["endreferencia"]),
                        endLogradouro = Convert.ToString(linhas["endLogradouro"]),
                        endBairro = Convert.ToString(linhas["endBairro"]),
                        endCidade = Convert.ToString(linhas["endCidade"]),
                        endUf = Convert.ToString(linhas["endUf"]),
                        endpadrao = Convert.ToBoolean(linhas["endpadrao"])
                    };

                    enderecoColecao.Add(enderecoInfo);
                }
                return enderecoColecao;
            }
            else
                return null;
        }

        public EnderecoInfo ConsultarEnderecoPorIdEnd(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);
                DataTable dataTable = new DataTable();
                EnderecoColecao enderecoColecao = new EnderecoColecao();
                dataTable = accessDbMySql.dataTableMySql("spConsultarEnderecoPorIdEnd");

                if (dataTable != null)
                    return PreencherColecaoEnd(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public EnderecoColecao ConsultarEnderecoPorIdCliente(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);
                DataTable dataTable;
                dataTable = accessDbMySql.dataTableMySql("spConsultarEndereco");

                return PreencherColecaoEnd(dataTable);
            }
            else
                return null;
        }

        public ClienteInfo ConsultarClientePorId(int id)
        {

            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = accessDbMySql.dataTableMySql(TipoPesquisaCliente(Tipo.Id));

                if (dataTable != null)
                    return PreencherClienteColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public ClienteColecao ConsultarPorNome(string nome)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@nome", nome);

                DataTable dataTable = accessDbMySql.dataTableMySql(TipoPesquisaCliente(Tipo.Nome));

                if (dataTable != null)
                    return PreencherClienteColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
            
        }

        public ClienteColecao ConsultarPorCpf(string cpf)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@Cpf", cpf);

                DataTable dataTable = accessDbMySql.dataTableMySql(TipoPesquisaCliente(Tipo.Cpf));

                if (dataTable != null)
                    return PreencherClienteColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        //public ClienteColecao ConsultarPorEmail(ClienteInfo clienteInfo)
        //{
        //    if (accessDbMySql.Conectar(EmpConexao))
        //    {
        //        accessDbMySql.AddParametrosMySql("@email", clienteInfo.Email);

        //        DataTable dataTable = accessDbMySql.dataTableMySql(TipoPesquisaCliente(Tipo.Email));

        //        if (dataTable != null)
        //            return PreencherClienteColecao(dataTable);
        //        else
        //            return null;
        //    }
        //    else
        //        return null;
        //}

        public ClienteColecao ConsultarPorTelefone(ClienteInfo clienteInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@tel", clienteInfo.clitel);

                DataTable dataTable = accessDbMySql.dataTableMySql(TipoPesquisaCliente(Tipo.Telefone));

                if (dataTable != null)
                    return PreencherClienteColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }
        
        private string TipoPesquisaCliente(Tipo tipo)
        {
            
            string Consulta = string.Empty;

            switch (tipo)
            {
                case Tipo.Id:
                    Consulta = "spConsultarViewClienteId";
                    break;
                case Tipo.Cpf:
                    Consulta = "spConsultarViewClienteCpf";
                    break;
                case Tipo.Nome:
                    Consulta = "spConsultarViewClienteNome";
                    break;
                case Tipo.Email:
                    Consulta = "spConsultarViewClienteEmail";
                    break;
                case Tipo.Telefone:
                    Consulta = "spConsultarViewClienteTel";
                    break;
                default:
                    break;
            }

            return Consulta;
        }

        private ClienteColecao PreencherClienteColecao(DataTable dataTable)
        {
            ClienteColecao clienteColecao = new ClienteColecao();

            if (dataTable != null)
            {
                foreach (DataRow linhas in dataTable.Rows)
                {
                    ClienteInfo cliente = new ClienteInfo();

                    cliente.cliid =  Convert.ToInt32(linhas["idCliente"]);
                    cliente.clicpf = Convert.ToString(linhas["cliCpf"]);
                    cliente.clinome = Convert.ToString(linhas["cliNome"]);
                    cliente.clitel = Convert.ToString(linhas["cliTelefone"]);
                    cliente.cliniver = Convert.ToDateTime(linhas["cliNiver"]);
                    cliente.cliemail = Convert.ToString(linhas["cliEmail"]);
                    cliente.cliiduser = Convert.ToInt32(linhas["cliIdUser"]);
                    cliente.clicontroledata = Convert.ToDateTime(linhas["cliControleDataHoraCliente"]);
                    cliente.clipadrao = Convert.ToInt32(linhas["clipadrao"]);

                    clienteColecao.Add(cliente);
                }

                return clienteColecao;
            }
            else
                return null;
        }
        public CepInfo ConsultarCep(string cepArg)
        {
            CepDB cepDB = new CepDB(cepArg);
            return cepDB.BuscarCorreios();
        }

        public bool ExcluirEnd(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                return accessDbMySql.ExecutarComandoMySql("spExcluirEnd");
            }
            else
                return false;
        }
    }
}

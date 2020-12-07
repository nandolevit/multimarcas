using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Negocios;
using ObjTransfer;

namespace WinForms
{
    public class Cupom
    {
        ClienteNegocios clienteNegocios = new ClienteNegocios(Form1.Empresa.empconexao);
        ProdutoNegocios produtoNegocios = new ProdutoNegocios(Form1.Empresa.empconexao);
        FuncNegocios funcNegocios = new FuncNegocios(Form1.Empresa.empconexao);
        VendaNegocios vendaNegocios = new VendaNegocios(Form1.Empresa.empconexao);

        CaixaNegocios caixaNegocios = new CaixaNegocios(Form1.Empresa.empconexao);
        int tam = 52;

        public string CriarCupomCaixa(CaixaAbrirInfo caixa)
        {
            CaixaFecharInfo caixaFecharInfo = caixaNegocios.ConsultarCaixaFecharUltimo(caixa.caixaabririd);
            CaixaTurnoColecao caixaTurnoColecao = caixaNegocios.ConsultarCaixaTurnoIdCaixa(caixa.caixaabririd);
            
            string caixaDia = "CAIXA DO DIA " + caixa.caixaabrirdata.ToShortDateString();
            string a = caixaDia.Substring(0, caixaDia.Length / 2).PadLeft(tam / 2);
            string b = caixaDia.Substring(caixaDia.Length / 2).PadRight(tam / 2);
            string titulo = a + b;

            string dadosCaixa = string.Empty;
            FuncInfo funcCaixa = funcNegocios.ConsultarFuncPorId(caixa.caixaabriridfunc);
            dadosCaixa += "ABERTO POR: " + funcCaixa.funNome + Environment.NewLine;
            dadosCaixa += "VALOR DE ABERTURA: " + caixa.caixaabrirvalor.ToString("C2") + Environment.NewLine;
            dadosCaixa += "HORA DE ABERTURA: " + caixa.caixaabrirdata.ToShortTimeString() + Environment.NewLine;
            dadosCaixa += "QUANT TURNOS: " + caixaTurnoColecao.Count.ToString() + Environment.NewLine;

            string dadosCaixaFechar = string.Empty;
            if (caixaFecharInfo != null)
            {
                FuncInfo funcFechar = funcNegocios.ConsultarFuncPorId(caixaFecharInfo.caixafecharidfunc);
                dadosCaixaFechar += "FECHADO POR: " + funcFechar.funNome + Environment.NewLine;
                dadosCaixaFechar += "DATA/HORA FECHAMENTO: " + caixaFecharInfo.caixafechardata.ToString(@"ddd, dd\/MM\/yyyy - hh:mm") + Environment.NewLine;
                dadosCaixaFechar += "".PadLeft(tam, '.') + Environment.NewLine;
                dadosCaixaFechar += Environment.NewLine;
                dadosCaixaFechar += "VALOR EM DINHEIRO: " + caixaFecharInfo.caixafecharvalordinheiro.ToString("C2").PadLeft(tam - 19) + Environment.NewLine;
                dadosCaixaFechar += "VALOR EM DÉBITO: " + caixaFecharInfo.caixafecharvalorcartaodebito.ToString("C2").PadLeft(tam - 17) + Environment.NewLine;
                dadosCaixaFechar += "VALOR EM CRÉDITO: " + caixaFecharInfo.caixafecharvalorcartaocredito.ToString("C2").PadLeft(tam - 18) + Environment.NewLine;
                dadosCaixaFechar += "VALOR EM CHEQUE: " + caixaFecharInfo.caixafecharvalorcheque.ToString("C2").PadLeft(tam - 17) + Environment.NewLine;
                dadosCaixaFechar += "VALOR EM DEPÓSITO: " + caixaFecharInfo.caixafecharvalordeposito.ToString("C2").PadLeft(tam - 19) + Environment.NewLine;
                dadosCaixaFechar += Environment.NewLine;
                dadosCaixaFechar += "VALOR EM PAGAMENTOS: " + caixaFecharInfo.caixafecharvalorpagamentos.ToString("C2").PadLeft(tam - 21) + Environment.NewLine;
                dadosCaixaFechar += "VALOR EM RECEBIMENTOS: " + caixaFecharInfo.caixafecharvalorrecebimentos.ToString("C2").PadLeft(tam - 23) + Environment.NewLine;
                dadosCaixaFechar += Environment.NewLine;
                dadosCaixaFechar += "VALOR EM SANGRIA: " + caixaFecharInfo.caixafecharvalorsangria.ToString("C2").PadLeft(tam - 18) + Environment.NewLine;
                dadosCaixaFechar += "".PadLeft(tam, '.') + Environment.NewLine;
                dadosCaixaFechar += "SALDO EM ESPÉCIE EM CAIXA: " + caixaFecharInfo.caixafecharvalorsaldoespecie.ToString("C2").PadLeft(tam - 27) + Environment.NewLine;
                dadosCaixaFechar += "SALDO TOTAL DE VENDAS: " + caixaFecharInfo.caixafecharvalortotal.ToString("C2").PadLeft(tam - 23) + Environment.NewLine;
                dadosCaixaFechar += Environment.NewLine;
                dadosCaixaFechar += Environment.NewLine;
            }

            string dadosTurno = string.Empty;
            foreach (CaixaTurnoInfo turno in caixaTurnoColecao)
            {
                FuncInfo funTurno = funcNegocios.ConsultarFuncPorId(turno.caixaturnoidfunc);
                string tituloTurno = "TURNO " + string.Format("{0:00}", turno.caixaturnonum);
                string aturno = tituloTurno.Substring(0, tituloTurno.Length / 2).PadLeft(tam / 2);
                string bturno = tituloTurno.Substring(tituloTurno.Length / 2).PadRight(tam / 2);
                tituloTurno = aturno + bturno;

                dadosTurno += tituloTurno + Environment.NewLine;
                dadosTurno += "FECHADO POR: " + funTurno.funNome + Environment.NewLine;
                dadosTurno += "DATA/HORA FECHAMENTO: " + turno.caixaturnodata.ToString(@"ddd, dd\/MM\/yyyy - hh:mm") + Environment.NewLine;
                dadosTurno += "TURNO ABERTO COM: " + turno.caixaturnovalorabrir.ToString("C2").PadLeft(tam - 18);
                dadosTurno += "".PadLeft(tam, '.') + Environment.NewLine;
                dadosTurno += Environment.NewLine;
                dadosTurno += "VALOR EM DINHEIRO: " + turno.caixaturnovalordinheiro.ToString("C2").PadLeft(tam - 19) + Environment.NewLine;
                dadosTurno += "VALOR EM DÉBITO: " + turno.caixaturnovalorcartaodebito.ToString("C2").PadLeft(tam - 17) + Environment.NewLine;
                dadosTurno += "VALOR EM CRÉDITO: " + turno.caixaturnovalorcartaocredito.ToString("C2").PadLeft(tam - 18) + Environment.NewLine;
                dadosTurno += "VALOR EM CHEQUE: " + turno.caixaturnovalorcheque.ToString("C2").PadLeft(tam - 17) + Environment.NewLine;
                dadosTurno += "VALOR EM DEPÓSITO: " + turno.caixaturnovalordeposito.ToString("C2").PadLeft(tam - 19) + Environment.NewLine;
                dadosTurno += Environment.NewLine;
                dadosTurno += "VALOR EM PAGAMENTOS: " + turno.caixaturnovalorpagamentos.ToString("C2").PadLeft(tam - 21) + Environment.NewLine;
                dadosTurno += "VALOR EM RECEBIMENTOS: " + turno.caixaturnovalorrecebimentos.ToString("C2").PadLeft(tam - 23) + Environment.NewLine;
                dadosTurno += Environment.NewLine;
                dadosTurno += "VALOR EM SANGRIA: " + turno.caixaturnovalorsangria.ToString("C2").PadLeft(tam - 18) + Environment.NewLine;
                dadosTurno += "".PadLeft(tam, '.') + Environment.NewLine;
                dadosTurno += "SALDO EM ESPÉCIE EM CAIXA: " + turno.caixaturnovalorsaldoespecie.ToString("C2").PadLeft(tam - 27) + Environment.NewLine;
                dadosTurno += "SALDO TOTAL DE VENDAS: " + turno.caixaturnovalortotal.ToString("C2").PadLeft(tam - 23) + Environment.NewLine;
                dadosTurno += Environment.NewLine;

                if (caixaTurnoColecao.Count > 1 && turno.caixaturnonum < caixaTurnoColecao.Count)
                    dadosTurno += "".PadLeft(tam, '*') + Environment.NewLine;

                dadosTurno += Environment.NewLine;
            }

            string texto = string.Empty;

            texto += titulo;
            texto += "".PadLeft(tam, '=') + Environment.NewLine;
            texto += Environment.NewLine;
            texto += dadosCaixa;
            texto += "".PadLeft(tam, '=') + Environment.NewLine;
            texto += Environment.NewLine;
            texto += dadosTurno;
            texto += "".PadLeft(tam, '=') + Environment.NewLine;
            texto += Environment.NewLine;
            texto += dadosCaixaFechar;

            return texto;
        }

        public string[] CriarCupom(VendaInfo venda)
        {
            string cupom = string.Empty;
            
            string fiscal = "CUPOM NÃO FISCAL";
            string a = fiscal.Substring(0, fiscal.Length / 2).PadLeft(tam / 2, '=');
            string b = fiscal.Substring(fiscal.Length / 2).PadRight(tam / 2, '=');
            string titulo = a + b;
            decimal desconto = 0;
            string nomTitulo = string.Empty;

            //dados da venda.
            if (venda != null)
            {
                switch (venda.venmodo)
                {
                    case 0:
                        nomTitulo = "ORÇAMENTO";
                        break;
                    case 1:
                        nomTitulo = "VENDA";
                        break;
                    case 2:
                        nomTitulo = "PRÉ-VENDA";
                        break;
                    default:
                        break;
                }

                string nomA = nomTitulo.Substring(0, nomTitulo.Length / 2).PadLeft(tam / 2);
                string nomB = nomTitulo.Substring(nomTitulo.Length / 2).PadRight(tam / 2);
                nomTitulo = nomA + nomB;

                FuncInfo funcInfo = funcNegocios.ConsultarFuncPorId(venda.venidfunc);
                string dadosvenda = string.Empty;
                dadosvenda += "CONTROLE: " + string.Format("{0:000000}", venda.venid) + Environment.NewLine;
                dadosvenda += "VENDEDOR: " + funcInfo.funNome + Environment.NewLine;
                dadosvenda += "DATA/HORA: " + venda.vendatacad + Environment.NewLine;

                string dadositem = string.Empty;
                VendaDetalhesColecao venDetalhesColecao = vendaNegocios.ConsultarVendaDetalhesIdVenda(venda.venid);
                
                //dados da empresa
                string empresa = "EMPRESA";
                string empA = string.Empty;
                string empB = string.Empty;

                empA = empresa.Substring(0, empresa.Length / 2).PadLeft(tam / 2);
                empB = empresa.Substring(empresa.Length / 2).PadRight(tam / 2);
                empresa = empA + empB;

                EmpresaNegocios empresaNegocios = new EmpresaNegocios(Form1.Empresa.empconexao);
                UnidadeInfo unidade = empresaNegocios.ConsultarUnidadeId(venda.venidunidade);
                string dadosemp = string.Empty;
                dadosemp += empresa + Environment.NewLine;
                dadosemp += unidade.unifantasia + Environment.NewLine;
                dadosemp += "Cnpj: " + string.Format(@"{0:00\.000\.000\/0000\-00}", Convert.ToDouble(unidade.unicnpj)) + Environment.NewLine;
                dadosemp += "End.: " + unidade.unicomplemento + ", " + Environment.NewLine;
                dadosemp += unidade.unilogradouro + Environment.NewLine;
                dadosemp += unidade.unibairro + ", " + unidade.unicidade + "-" + unidade.uniuf + Environment.NewLine;
                dadosemp += "Ref.: " + unidade.unireferencia + Environment.NewLine;
                dadosemp += "Telefone: " + unidade.unitelefone + Environment.NewLine;
                dadosemp += "Site: " + unidade.unisite.ToLower() + Environment.NewLine;
                dadosemp += "Email: " + unidade.uniemail.ToLower() + Environment.NewLine;

                //dados do cliente
                ClienteInfo clienteInfo = clienteNegocios.ConsultarPorId(venda.venidcliente);
                EnderecoInfo enderecoInfo = new EnderecoInfo();
                string cliente = "CLIENTE";
                string cliA = string.Empty;
                string cliB = string.Empty;

                cliA = cliente.Substring(0, cliente.Length / 2).PadLeft(tam / 2);
                cliB = cliente.Substring(cliente.Length / 2).PadRight(tam / 2);
                cliente = cliA + cliB;

                if (clienteInfo == null)
                    clienteInfo = clienteNegocios.ConsultarClientePadrao();
                else
                    enderecoInfo = clienteNegocios.ConsultarEnderecoPorIdCliente(venda.venidcliente)[0];

                string dadoscliente = string.Empty;
                dadoscliente += cliente + Environment.NewLine;
                dadoscliente += clienteInfo.Nome + Environment.NewLine;

                if (clienteInfo.clipadrao == 0)
                {
                    dadoscliente += "End.: " + enderecoInfo.Complemento + ", " + Environment.NewLine
                        + enderecoInfo.endLogradouro + Environment.NewLine;
                    dadoscliente += enderecoInfo.endBairro + ", " + enderecoInfo.endCidade + "-" + enderecoInfo.endUf + Environment.NewLine + "Ref.: " + enderecoInfo.PontoReferencia + Environment.NewLine;
                }
                else
                    dadoscliente += "End.: " + Environment.NewLine;

                dadoscliente += "Telefone: " + clienteInfo.Tel + Environment.NewLine;
                dadoscliente += "Email: " + clienteInfo.Email + Environment.NewLine;

                //produtos
                int item = 1;
                foreach (VendaDetalhesInfo detalhes in venDetalhesColecao)
                {
                    ProdutoInfo produtoInfo = produtoNegocios.ConsultarProdutosId(detalhes.vendetalhesidprod);

                    decimal calc = (detalhes.vendetalhesvalorunit - detalhes.vendetalhesvalordesc) * detalhes.vendetalhesquant;
                    string desc = string.Empty;
                    string prod = string.Empty;

                    dadositem += string.Format("{0:00}", item++) + "   ";

                    if (calc > 0)
                    {
                        desc = (-calc).ToString("C2");
                        prod += desc;
                    }

                    prod += (detalhes.vendetalhesquant + " UN x " + detalhes.vendetalhesvalordesc.ToString("C2") + " = " + (detalhes.vendetalhesquant * detalhes.vendetalhesvalordesc).ToString("C2")).PadLeft(tam - desc.Length);

                    dadositem += string.Format("{0:00000}", produtoInfo.proId) + " " + produtoInfo.proDescricao + Environment.NewLine;
                    dadositem += prod.PadLeft(tam) + Environment.NewLine;
                    desconto += (detalhes.vendetalhesvalorunit - detalhes.vendetalhesvalordesc) * detalhes.vendetalhesquant;
                }

                //formas de pagamentos
                string dadosformapag = string.Empty;
                string troco = string.Empty;
                
                if (venda.venmodo > 0)
                {
                    string pagamento = "FORMA DE PAGAMENTO";
                    string pagA = string.Empty;
                    string pagB = string.Empty;

                    pagA = pagamento.Substring(0, pagamento.Length / 2).PadLeft(tam / 2);
                    pagB = pagamento.Substring(pagamento.Length / 2).PadRight(tam / 2);
                    pagamento = pagA + pagB;

                    dadosformapag = pagamento + Environment.NewLine;
                    VFormaPagPorVendaColecao forma = vendaNegocios.ConsultarVFormaPagPorVendaColecao(venda.venid);
                    PagamentoInfo pagamentoInfo = vendaNegocios.ConsultarPagamentoIdVenda(venda.venid);

                    foreach (VFormaPagPorVendaInfo pag in forma)
                    {
                        string descricao = pag.formpagdescricao;

                        if (pag.pagdetalhesnumparcelas > 1)
                        {
                            decimal valor = pag.pagdetalhesvalor / pag.pagdetalhesnumparcelas;
                            descricao += " " + pag.pagdetalhesnumparcelas + "x " + valor.ToString("C2");
                        }
                        else
                            descricao += " À VISTA";

                        if (pag.formpagid == 1 && pagamentoInfo.pagamentotroco > 0)
                        {
                            descricao = descricao.Replace(" À VISTA", "");
                            descricao += ", Recebido = " + (pag.pagdetalhesvalor + pagamentoInfo.pagamentotroco).ToString("C2");
                        }

                        dadosformapag += descricao + pag.pagdetalhesvalor.ToString("C2").PadLeft(tam - descricao.Length) + Environment.NewLine;
                    }
                    
                    troco += Environment.NewLine;

                    if (desconto > 0)
                    {
                        string totalDesconto = "(" + string.Format("{0:0.00}", ((desconto * 100) / (venda.venvalor + desconto))) + "%) " + (-desconto).ToString("C2");
                        troco += "DESCONTO TOTAL: " + totalDesconto.PadLeft(tam - 16) + Environment.NewLine;
                    }

                    if (pagamentoInfo.pagamentotroco > 0)
                        troco += "TROCO: " + (-pagamentoInfo.pagamentotroco).ToString("C2").PadLeft(tam - 7) + Environment.NewLine;
                }

                string total = "SUBTOTAL: " + (venda.venvalor + desconto).ToString("C2").PadLeft(tam - 10) + Environment.NewLine;
                total += "VALOR A PAGAR: " + venda.venvalor.ToString("C2").PadLeft(tam - "VALOR A PAGAR: ".Length);

                cupom += titulo + Environment.NewLine;
                cupom += "" + Environment.NewLine;
                cupom += nomTitulo + Environment.NewLine;
                cupom += dadosvenda;
                cupom += "".PadLeft(tam, '=') + Environment.NewLine;
                cupom += dadosemp;
                cupom += "".PadLeft(tam, '=') + Environment.NewLine;
                cupom += dadoscliente;
                cupom += "".PadLeft(tam, '-') + Environment.NewLine;
                cupom += "ITEM COD.  DESCRICAO" + Environment.NewLine;
                cupom += "".PadLeft(tam, '-') + Environment.NewLine;
                cupom += dadositem + Environment.NewLine;
                cupom += "".PadLeft(tam, '*') + Environment.NewLine;
                cupom += "QUANT DE ITENS: " + string.Format("{0:00}", venda.venquant).PadLeft(tam - 16) + Environment.NewLine;
                cupom += total;
                cupom += "" + Environment.NewLine;
                cupom += "" + Environment.NewLine;
                cupom += dadosformapag;
                cupom += troco;

                string corpo = cupom;
                string rodape = string.Empty;

                if (venda.venmodo > 0)
                {
                    rodape += "".PadLeft(tam, '.') + Environment.NewLine;
                    rodape += "" + Environment.NewLine;
                    rodape += nomTitulo + Environment.NewLine;
                    rodape += dadosvenda;
                    rodape += "UNIDADE: " + unidade.uniunidade + Environment.NewLine;
                    rodape += "" + Environment.NewLine;
                    rodape += dadoscliente;
                    rodape += "" + Environment.NewLine;
                    rodape += total;
                    rodape += "" + Environment.NewLine;
                    rodape += "" + Environment.NewLine;
                    rodape += dadosformapag;
                    rodape += troco;
                    rodape += "".PadLeft(tam, '.') + Environment.NewLine;
                }

                string[] ArrCupom = new string[2];

                ArrCupom[0] = corpo;
                ArrCupom[1] = rodape;

                return ArrCupom;
            }
            else
            {
                FormMessage.ShowMessegeWarning("Nada foi encontrado!");
                return null;
            }
        }
    }
}

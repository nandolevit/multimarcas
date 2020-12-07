using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjTransfer;
using Negocios;
using System.Windows.Forms;

namespace WinForms
{
    public class Caixa
    {
        CaixaNegocios caixaNegocios = new CaixaNegocios(Form1.Empresa.empconexao);
        FuncNegocios funcNegocios = new FuncNegocios(Form1.Empresa.empconexao);
        EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios(Form1.Empresa.empconexao);
        CaixaAbrirInfo caixaAbrirInfo = new CaixaAbrirInfo();
        CaixaTurnoInfo caixaTurnoInfo = new CaixaTurnoInfo();

        decimal dinheiro = 0;
        decimal debito = 0;
        decimal credito = 0;
        decimal cheque = 0;
        decimal deposito = 0;
        decimal outras = 0;
        decimal total = 0;
        decimal recebimento = 0;
        decimal pagamento = 0;

        public Caixa()
        {
            caixaAbrirInfo = caixaNegocios.ConsultarCaixaAberto(Form1.Unidade.uniid);

            /*if (caixaAbrirInfo == null)
                caixaAbrirInfo = caixaNegocios.ConsultarCaixaAbrirUltimoAberto(Form1.Unidade.uniid);*/

            caixaTurnoInfo = ConsultarTurnoAberto();
        }

        public CaixaFecharInfo PreencherCaixaTotal()
        {
            CalcularSaldoVendaCaixaTotal();

            total = dinheiro + debito + credito + cheque + deposito + outras;

            CaixaFecharInfo caixaFecharInfo = new CaixaFecharInfo
            {
                caixafecharvalorcarne = outras,
                caixafecharvalorcartaocredito = credito,
                caixafecharvalorcartaodebito = debito,
                caixafecharvalorcheque = cheque,
                caixafecharvalordinheiro = dinheiro,
                caixafecharvalordeposito = deposito,
                caixafecharvalortotal = total
            };

            return caixaFecharInfo;
        }

        public CaixaFecharInfo PreencherTurno()
        {
            CalcularSaldoVendaTurno(); 
                
            total = dinheiro + debito + credito + cheque + deposito + outras;

            CaixaFecharInfo caixaFecharInfo = new CaixaFecharInfo
            {
                caixafecharvalorcarne = outras,
                caixafecharvalorcartaocredito = credito,
                caixafecharvalorcartaodebito = debito,
                caixafecharvalorcheque = cheque,
                caixafecharvalordinheiro = dinheiro,
                caixafecharvalordeposito = deposito,
                caixafecharvalortotal = total
            };

            return caixaFecharInfo;
        }

        public CaixaAbrirInfo CaixaAberto()
        {
            return caixaAbrirInfo;
        }

        public void ConsultarCaixaStatus()
        {
            if (caixaAbrirInfo != null)
            {
                if (caixaAbrirInfo.caixaabrirdata.Date != DateTime.Now.Date)
                {
                    FormMessage.ShowMessegeWarning("O caixa do dia " + caixaAbrirInfo.caixaabrirdata.Date.ToShortDateString() + " não foi fechado, é necessário fechar para abrir caixa de hoje!");
                    AbrirFormCaixa();
                }
                else
                {
                    if (caixaTurnoInfo == null)
                    {
                        FormAbrirCaixa formAbrirCaixa = new FormAbrirCaixa(EnumCaixa.Turno);
                        formAbrirCaixa.ShowDialog();
                        formAbrirCaixa.Dispose();
                    }
                }
            }
            else
            {
                caixaAbrirInfo = caixaNegocios.ConsultarCaixaAbrirUltimoAberto(Form1.Unidade.uniid);
                if (caixaAbrirInfo.caixaabrirdata.Date != DateTime.Now.Date)
                {
                    FormMessage.ShowMessegeWarning("O caixa não foi aberto ainda! É necessário abrir o caixa!");
                    FormAbrirCaixa formAbrirCaixa = new FormAbrirCaixa(EnumCaixa.Caixa);
                    formAbrirCaixa.ShowDialog();

                    if (formAbrirCaixa.DialogResult == DialogResult.Yes)
                        AbrirFormCaixa();

                    formAbrirCaixa.Dispose();
                }
                else
                {
                    FormMessage.ShowMessegeWarning("O caixa de hoje já foi encerrado, um novo caixa só poderá ser aberto na próxima data " + DateTime.Now.Date.AddDays(1).ToShortDateString());
                    caixaAbrirInfo = null;
                }
            }
        }

        private void AbrirFormCaixa()
        {
            FormCaixa formCaixa = new FormCaixa(EnumCaixa.Caixa);
            formCaixa.ShowDialog();
            formCaixa.Dispose();
        }

        public CaixaTurnoColecao ConsultarTurnoColecaoIdCaixa()
        {
            return caixaNegocios.ConsultarCaixaTurnoIdCaixa(caixaAbrirInfo.caixaabririd);
        }

        public CaixaTurnoInfo ConsultarTurnoUltimoFechado()
        {
            CaixaTurnoColecao caixaTurnoColecao = caixaNegocios.ConsultarCaixaTurnoIdCaixa(caixaAbrirInfo.caixaabririd);

            if (caixaTurnoColecao != null)
            {
                return caixaTurnoColecao[0];
            }
            else
                return null;
        }

        public CaixaTurnoInfo ConsultarTurnoAberto()
        {
            if (caixaAbrirInfo != null)
            {
                CaixaTurnoColecao caixaTurnoColecao = caixaNegocios.ConsultarCaixaTurnoIdCaixa(caixaAbrirInfo.caixaabririd);

                if (caixaTurnoColecao != null)
                {
                    foreach (CaixaTurnoInfo turno in caixaTurnoColecao)
                    {
                        if (turno.caixaturnofechado == false)
                            return turno;
                    }

                    return null;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public decimal CalcularSaldoVendaCaixaTotal()
        {
            if (caixaAbrirInfo != null)
            {
                CaixaDiaColecao colecao = caixaNegocios.ConsultarCaixaDiaTotal(caixaAbrirInfo.caixaabririd);

                if (colecao != null)
                {
                    foreach (CaixaDiaInfo diaInfo in colecao)
                    {
                        switch (diaInfo.formpagdescricao)
                        {
                            case "DINHEIRO":
                                dinheiro = diaInfo.valor;
                                break;
                            case "CARTAO DE DEBITO":
                                debito = diaInfo.valor;
                                break;
                            case "CARTAO DE CREDITO":
                                credito = diaInfo.valor;
                                break;
                            case "CHEQUE":
                                cheque = diaInfo.valor;
                                break;
                            case "DEPOSITO BANCARIO":
                                deposito = diaInfo.valor;
                                break;
                            default:
                                outras = diaInfo.valor;
                                break;
                        }
                    }

                    total = dinheiro + debito + credito + cheque + deposito + outras;

                    return total;
                }
                else
                    return 0;
            }
            else
                return 0;
        }

        public decimal CalcularSaldoVendaTurno()
        {
            if (caixaTurnoInfo != null)
            {
                CaixaDiaColecao colecao = caixaNegocios.ConsultarCaixaDiaTurno(caixaTurnoInfo.caixaturnoid);

                if (colecao != null)
                {
                    foreach (CaixaDiaInfo diaInfo in colecao)
                    {
                        switch (diaInfo.formpagdescricao)
                        {
                            case "DINHEIRO":
                                dinheiro = diaInfo.valor;
                                break;
                            case "CARTAO DE DEBITO":
                                debito = diaInfo.valor;
                                break;
                            case "CARTAO DE CREDITO":
                                credito = diaInfo.valor;
                                break;
                            case "CHEQUE":
                                cheque = diaInfo.valor;
                                break;
                            case "DEPOSITO BANCARIO":
                                deposito = diaInfo.valor;
                                break;
                            default:
                                outras = diaInfo.valor;
                                break;
                        }
                    }

                    total = dinheiro + debito + credito + cheque + deposito + outras;

                    return total;
                }
                else
                    return 0;
            }
            else
                return 0;
        }

        public decimal[] CalcularSaldoRecebimentoPagamentoCaixa(int idcaixa)
        {
            EntradaSaidaColecao entradaSaidaColecao = entradaSaidaNegocios.spConsultarEntradaDiversosSaldoIdCaixa(idcaixa);
            decimal[] saldo = new decimal[2];
            if (entradaSaidaColecao != null)
            {
                foreach (EntradaSaidaInfo entra in entradaSaidaColecao)
                {
                    switch (entra.entsaitipoidentradasaida)
                    {
                        case 1:
                            recebimento = entra.entravalorpago;
                            break;
                        case 2:
                            pagamento = entra.entravalorpago;
                            break;
                        default:
                            break;
                    }
                }

                saldo[0] = recebimento;
                saldo[1] = pagamento;

                return saldo;
            }
            else
                return saldo;
        }

        public decimal[] CalcularSaldoRecebimentoPagamentoTurno(int idturno)
        {
            EntradaSaidaColecao entradaSaidaColecao = entradaSaidaNegocios.spConsultarEntradaDiversosSaldoIdTurno(idturno);
            decimal[] saldo = new decimal[2];
            if (entradaSaidaColecao != null)
            {
                foreach (EntradaSaidaInfo entra in entradaSaidaColecao)
                {
                    switch (entra.entsaitipoidentradasaida)
                    {
                        case 1:
                            recebimento = entra.entravalorpago;
                            break;
                        case 2:
                            pagamento = entra.entravalorpago;
                            break;
                        default:
                            break;
                    }
                }

                saldo[0] = recebimento;
                saldo[1] = pagamento;

                return saldo;
            }
            else
                return saldo;
        }

        public decimal SaldoEspecieCaixa()
        {
            CalcularSaldoVendaCaixaTotal();
            CalcularSaldoRecebimentoPagamentoCaixa(caixaAbrirInfo.caixaabririd);

            decimal venda = dinheiro;
            decimal diversos = recebimento - pagamento;
            decimal caixaAberto = caixaAbrirInfo.caixaabrirvalor;
            decimal sangriaSaldo = caixaNegocios.ConsultarSangriaSaldoIdCaixa(caixaAbrirInfo.caixaabririd);

            return (venda + diversos + caixaAberto) - sangriaSaldo;
        }

        public decimal SaldoEspecieCaixaTurno()
        {
            CalcularSaldoVendaTurno();
            CalcularSaldoRecebimentoPagamentoTurno(caixaTurnoInfo.caixaturnoid);

            decimal venda = dinheiro;
            decimal diversos = recebimento - pagamento;
            decimal caixaAberto = caixaTurnoInfo.caixaturnovalorabrir;
            decimal sangriaSaldo = caixaNegocios.ConsultarSangriaSaldoIdTurno(caixaTurnoInfo.caixaturnoid);

            return (venda + diversos + caixaAberto) - sangriaSaldo;
        }
    }
}

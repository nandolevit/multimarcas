using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
        CaixaAbrirInfo caixaFechado = new CaixaAbrirInfo();
        CaixaTurnoInfo caixaTurnoInfo = new CaixaTurnoInfo();

        decimal dinheiro = 0;
        decimal debito = 0;
        decimal credito = 0;
        decimal cheque = 0;
        decimal deposito = 0;
        decimal outras = 0;
        decimal total = 0;
        decimal especie = 0;
        decimal sangria = 0;
        decimal recebimento = 0;
        decimal pagamento = 0;
        decimal abertura = 0;
        decimal diversos = 0;

        public Caixa()
        {
            caixaAbrirInfo = caixaNegocios.ConsultarCaixaAberto(Form1.Unidade.uniid);

            if (caixaAbrirInfo == null)
                caixaFechado = caixaNegocios.ConsultarCaixaAbrirUltimoAberto(Form1.Unidade.uniid);
            else
            {
                caixaTurnoInfo = ConsultarTurnoAberto();

                if (caixaTurnoInfo == null)
                {
                    ////
                }
            }
        }

        public CaixaAbrirInfo PreencherCaixaTotal(EnumCaixa enumCaixa)
        {
            dinheiro = 0;
            debito = 0;
            credito = 0;
            cheque = 0;
            deposito = 0;
            outras = 0;
            total = 0;
            especie = 0;
            sangria = 0;
            recebimento = 0;
            pagamento = 0;
            abertura = 0;
            diversos = 0;

            CaixaDiaColecao colecao = new CaixaDiaColecao();
            EntradaSaidaColecao entradaSaidaColecao = new EntradaSaidaColecao();

            if (enumCaixa == EnumCaixa.Turno)
            {
                colecao = caixaNegocios.ConsultarCaixaDiaTurno(caixaTurnoInfo.caixaturnoid);
                entradaSaidaColecao = entradaSaidaNegocios.ConsultarEntradaDiversosSaldoIdTurno(caixaTurnoInfo.caixaturnoid);
                sangria = caixaNegocios.ConsultarSangriaSaldoIdTurno(caixaTurnoInfo.caixaturnoid);
                abertura = caixaTurnoInfo.caixaturnovalorabrir;
            }
            else
            {
                colecao = caixaNegocios.ConsultarCaixaDiaTotal(caixaAbrirInfo.caixaabririd);
                entradaSaidaColecao = entradaSaidaNegocios.ConsultarEntradaDiversosSaldoIdCaixa(caixaAbrirInfo.caixaabririd);
                sangria = caixaNegocios.ConsultarSangriaSaldoIdCaixa(caixaAbrirInfo.caixaabririd);
                abertura = caixaAbrirInfo.caixaabrirvalor;
            }

            if (entradaSaidaColecao != null)
                CalcularSaldoRecebimentoPagamentoCaixa(entradaSaidaColecao);

            if (colecao != null)
                CalcularSaldoVendaCaixaTotal(colecao);

            diversos = recebimento - pagamento;
            especie = (dinheiro + abertura + diversos) - sangria;

            CaixaAbrirInfo caixaFecharInfo = new CaixaAbrirInfo
            {
                caixafecharvalorcarne = outras,
                caixafecharvalorcartaocredito = credito,
                caixafecharvalorcartaodebito = debito,
                caixafecharvalorcheque = cheque,
                caixafecharvalordinheiro = dinheiro,
                caixafecharvalordeposito = deposito,
                caixafecharvalortotal = total,
                caixafecharvalorsaldoespecie = especie,
                caixafecharvalorpagamentos = pagamento,
                caixafecharvalorrecebimentos = recebimento,
                caixafecharvalorsangria = sangria,
                caixafechardata = DateTime.Now
            };

            return caixaFecharInfo;
        }

        public bool VerificarCaixa()
        {
            if (ConsultarCaixaStatus())
            {
                if (ConsultarTurnoAberto() != null)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public CaixaAbrirInfo CaixaAberto()
        {
            return caixaAbrirInfo;
        }

        private bool ConsultarCaixaStatus()
        {
            if (caixaAbrirInfo != null)
            {
                if (caixaAbrirInfo.caixaabrirdata.Date != DateTime.Now.Date)
                {
                    FormMessage.ShowMessegeWarning("O caixa do dia " + caixaAbrirInfo.caixaabrirdata.Date.ToShortDateString() + " não foi fechado, é necessário fechar para abrir caixa de hoje!");
                    return AbrirFormCaixa();
                    
                }
                else
                {
                    if (caixaTurnoInfo == null)
                    {
                        CaixaTurnoColecao caixaTurnoColecao = caixaNegocios.ConsultarCaixaTurnoIdCaixa(caixaAbrirInfo.caixaabririd);

                        if (caixaTurnoColecao != null)
                        {
                            if (caixaTurnoColecao.Count < 3)
                            {
                                FormMessage.ShowMessegeWarning("O turno foi fechado e um novo precisa ser aberto!");
                                FormAbrirCaixa formAbrirCaixa = new FormAbrirCaixa(EnumCaixa.Turno);
                                formAbrirCaixa.ShowDialog();
                                formAbrirCaixa.Dispose();

                                if (formAbrirCaixa.DialogResult == DialogResult.Yes)
                                    return true;
                                else
                                    return false;
                            }
                            else
                            {
                                FormMessage.ShowMessegeWarning("O limite de caixa que poderá ser aberto por dia já foi excedido, um novo turno só poderá ser aberto com a abertura do novo caixa!");
                                return false;
                            }
                        }
                        else
                        {
                            FormMessage.ShowMessegeWarning("O turno foi fechado e um novo precisa ser aberto!");
                            FormAbrirCaixa formAbrirCaixa = new FormAbrirCaixa(EnumCaixa.Turno);
                            formAbrirCaixa.ShowDialog();
                            formAbrirCaixa.Dispose();

                            if (formAbrirCaixa.DialogResult == DialogResult.Yes)
                                return true;
                            else
                                return false;
                        }
                    }
                    else
                        return true;
                }
            }
            else
            {
                caixaAbrirInfo = caixaNegocios.ConsultarCaixaAbrirUltimoAberto(Form1.Unidade.uniid);

                if (caixaAbrirInfo != null)
                {
                    if (caixaAbrirInfo.caixaabrirdata.Date != DateTime.Now.Date)
                    {
                        FormMessage.ShowMessegeWarning("O caixa não foi aberto ainda! É necessário abrir o caixa!");
                        FormAbrirCaixa formAbrirCaixa = new FormAbrirCaixa(EnumCaixa.Caixa);
                        formAbrirCaixa.ShowDialog();
                        formAbrirCaixa.Dispose();
                        
                        if (formAbrirCaixa.DialogResult == DialogResult.Yes)
                            return AbrirFormCaixa();
                        
                    }
                    else
                    {
                        FormMessage.ShowMessegeWarning("O caixa de hoje já foi encerrado, um novo caixa só poderá ser aberto na próxima data " + DateTime.Now.Date.AddDays(1).ToShortDateString());
                        caixaAbrirInfo = null;
                        return false;
                    }
                }
                else
                {
                    FormMessage.ShowMessegeWarning("O caixa não foi aberto ainda! É necessário abrir o caixa!");
                    FormAbrirCaixa formAbrirCaixa = new FormAbrirCaixa(EnumCaixa.Caixa);
                    formAbrirCaixa.ShowDialog();
                    formAbrirCaixa.Dispose();

                    if (formAbrirCaixa.DialogResult == DialogResult.Yes)
                        return true;
                    else
                        return false;
                }
            }

            return false;
        }

        private bool AbrirFormCaixa()
        {
            FormCaixa formCaixa = new FormCaixa(EnumCaixa.Caixa);
            formCaixa.ShowDialog();
            formCaixa.Dispose();

            if (formCaixa.DialogResult == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public CaixaTurnoColecao ConsultarTurnoColecaoIdCaixa()
        {
            return caixaNegocios.ConsultarCaixaTurnoIdCaixa(caixaAbrirInfo.caixaabririd);
        }

        public CaixaTurnoInfo ConsultarTurnoUltimoFechado()
        {
            return caixaNegocios.ConsutarCaixaTurnoAnterior(caixaAbrirInfo.caixaabririd);
            
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

        private void CalcularSaldoVendaCaixaTotal(CaixaDiaColecao colecao)
        {
            foreach (CaixaDiaInfo diaInfo in colecao)
            {
                switch (diaInfo.formpagdescricao)
                {
                    case "DINHEIRO":
                        dinheiro += diaInfo.valor;
                        break;
                    case "CARTAO DE DEBITO":
                        debito += diaInfo.valor;
                        break;
                    case "CARTAO DE CREDITO":
                        credito += diaInfo.valor;
                        break;
                    case "CHEQUE":
                        cheque += diaInfo.valor;
                        break;
                    case "DEPOSITO BANCARIO":
                        deposito += diaInfo.valor;
                        break;
                    default:
                        outras += diaInfo.valor;
                        break;
                }
            }

            total = dinheiro + debito + credito + cheque + deposito + outras;
        }
        
        private void CalcularSaldoRecebimentoPagamentoCaixa(EntradaSaidaColecao entradaSaidaColecao)
        {
            if (entradaSaidaColecao != null)
            {
                foreach (EntradaSaidaInfo entra in entradaSaidaColecao)
                {
                    switch (entra.entraidtipoentrada)
                    {
                        case 1:
                            recebimento += entra.entravalorpago;
                            break;
                        case 2:
                            pagamento += entra.entravalorpago;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}

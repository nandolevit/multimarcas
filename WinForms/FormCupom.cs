using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using ObjTransfer;
using Negocios;

namespace WinForms
{
    public enum EnumCupom { Rodape, SemRodape}

    public partial class FormCupom : Form
    {
        Form1 form1 = new Form1();
        Thread thread;
        public int Ident { get; set; }
        public string Servico { get; set; }
        EnumCaixa enumCaixa;


        Cupom cupom = new Cupom();
        VendaNegocios vendaNegocios = new VendaNegocios(Form1.Empresa.empconexao);
        string[] ArrCupom = new string[2];
        EnumCupom enumCupom = new EnumCupom();

        public FormCupom(int id, EnumCupom cupom, string servico)
        {
            Inicializar();
            enumCupom = cupom;
            Ident = id;
            Servico = servico;
            Consultar();
        }

        public FormCupom(int id, EnumCupom cupom, EnumCaixa caixa)
        {
            Inicializar();
            enumCupom = cupom;
            Ident = id;
            enumCaixa = caixa;
            CriarCaixa();
        }

        public void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            buttonTeste.Visible = false;
            textBoxTeste.Visible = false;
            labelTeste.Visible = false;
            buttonImprimir.Enabled = true;
            buttonImprimir.Select();
        }

        public FormCupom()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void Consultar()
        {
            if (enumCupom == EnumCupom.Rodape)
            {
                thread = new Thread(CriarCupom);
                form1.ExecutarThread(thread);
                this.Activate();
                PreencherForm(ArrCupom[0] + ArrCupom[1]);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTeste.Text, out int cod))
            {
                Ident = cod;
                Consultar();
            }
            else
                FormMessage.ShowMessegeWarning("Insira um código válido!");

        }

        
        private void CriarCaixa()
        {
            thread = new Thread(PreencherCaixaThread);
            form1.ExecutarThread(thread);
            this.Activate();
            PreencherForm(ArrCupom[0]);
        }

        private void PreencherCaixaThread()
        {
            CaixaNegocios caixaNegocios = new CaixaNegocios(Form1.Empresa.empconexao);
            CaixaAbrirInfo caixaAbrirInfo = caixaNegocios.ConsultarCaixaPorId(Ident);
            ArrCupom[0] = cupom.CriarCupomCaixa(caixaAbrirInfo, enumCaixa);
            Form1.encerrarThread = true;  
        }

        private void CriarCupom()
        {
            VendaInfo vendaInfo = vendaNegocios.ConsultarVendaId(Ident);

            if (vendaInfo != null)
            {
                ArrCupom = cupom.CriarCupom(vendaInfo, Servico);
                Form1.encerrarThread = true;
            }
            else
            {
                Form1.encerrarThread = true;
                FormMessage.ShowMessegeWarning("Nada foi encontrado!");
            }
        }

        private void PreencherForm(string texto)
        {
            textBoxCupom.Text = texto;
            buttonImprimir.Enabled = true;
            buttonImprimir.Select();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            if (enumCupom == EnumCupom.Rodape)
            {
                FormReportVenda formReportVenda = new FormReportVenda(ArrCupom);
                formReportVenda.Show(this);
            }
            else
            {
                FormReportViewerCupomSemRodape formReportViewerCupomSemRodape = new FormReportViewerCupomSemRodape(ArrCupom[0]);
                formReportViewerCupomSemRodape.Show(this);
            }
        }

        private void textBoxTeste_TextChanged(object sender, EventArgs e)
        {
            buttonImprimir.Enabled = false;
            textBoxCupom.Clear();
        }

        private void FormCupom_Load(object sender, EventArgs e)
        {
            
        }
    }
}

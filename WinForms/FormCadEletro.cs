using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjTransfer;
using Negocios;

namespace WinForms
{
    public partial class FormCadEletro : Form
    {
        ClienteInfo infoCliente;
        ClienteNegocios negociosCliente = new ClienteNegocios(Form1.Empresa.empconexao);
        ServicoNegocio negocioServ = new ServicoNegocio(Form1.Empresa.empconexao);
        AutorizadaNegocios negociosAut = new AutorizadaNegocios(Form1.Empresa.empconexao);
        ProdEletroInfo infoEletro;
        AutorizadaColecao colecaoAut;

        public ProdEletroInfo SelecionadoEletro { get; set; }
        public int Cod { get; set; }
        bool insert;

        public FormCadEletro(ClienteInfo cliente)
        {
            Inicializar();
            infoCliente = cliente;
            insert = true;
        }
        public FormCadEletro(ProdEletroInfo eletro)
        {
            Inicializar();
            infoEletro = eletro;
            PreencherForm();
            insert = false;
        }
        public FormCadEletro(int cod)
        {
            Inicializar();
            Cod = cod;
            ConsultarProdutoEletroId();
            insert = false;
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.AcceptButton = buttonSalvar;
            buttonBuscarProduto.Select();

            if (Form1.Offline)
            {
                buttonAddMarca.Visible = false;
                buttonAddProduto.Visible = false;
            }
        }

        private void ConsultarCliente()
        {
            infoCliente = negociosCliente.ConsultarClientePorId(infoEletro.idclientecad);
        }

        private void ConsultarProdutoEletroId()
        {
             infoEletro = negocioServ.ConsultarEletroId(Cod);
            ConsultarCliente();
            PreencherForm();
        }

        private void PreencherForm()
        {
            textBoxCodProd.Text = string.Format("{0:000}", infoEletro.ideletrocad);
            textBoxCodMarca.Text = string.Format("{0:000}", infoEletro.idmarcacad);
            textBoxModelo.Text = infoEletro.cadelemodelo;
            textBoxSerie.Text = infoEletro.cadeleserie;
            textBoxPnc.Text = infoEletro.cadelepnc;
            textBoxObs.Text = infoEletro.cadeleobs;

            ConsultarNomeProdEletro();
            ConsultarNomeMarca();
        }

        private void ConsultarAutorizadaConfirmada()
        {
            colecaoAut = negociosAut.ConsultarAutorizadaConfirm();
            textBoxCodMarca.Enabled = false;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBoxCodProd.Text) || string.IsNullOrEmpty(textBoxCodMarca.Text)))
            {
                SelecionadoEletro = PreencherObjEletro();

                if (insert)
                {
                    SelecionadoEletro.idCadEle = negocioServ.InsertProdEletro(SelecionadoEletro);
                    SelecionadoEletro = negocioServ.ConsultarEletroId(SelecionadoEletro.idCadEle);

                    if (SelecionadoEletro.idCadEle > 0)
                    {
                        FormMessage.ShowMessegeInfo("Salvo com sucesso!");
                        this.DialogResult = DialogResult.Yes;
                    }
                }
                else
                {
                    if (FormMessage.ShowMessegeQuestion("Deseja salvar as alterações?") == DialogResult.Yes)
                    {
                        int num = 0;

                        num = negocioServ.UpdateProdEletro(SelecionadoEletro);
                        if (num > 0)
                        {
                            FormMessage.ShowMessegeInfo("Alterações foram salvas com sucesso!");
                            this.DialogResult = DialogResult.Yes;
                        }
                        else
                            FormMessage.ShowMessegeWarning("As alterações não puderam ser salvas!");
                    }
                }
            }
            else
                FormMessage.ShowMessegeWarning("Selecione o produto e a marca!");
        }

        private ProdEletroInfo PreencherObjEletro()
        {
            ProdEletroInfo prodEletroInfo = new ProdEletroInfo
            {
                cadelemodelo = textBoxModelo.Text,
                cadeleobs = textBoxObs.Text,
                cadelepnc = textBoxPnc.Text,
                cadeleserie = textBoxSerie.Text,
                ideletrocad = Convert.ToInt32(textBoxCodProd.Text),
                idmarcacad = Convert.ToInt32(textBoxCodMarca.Text),
                idclientecad = infoCliente.cliid,
                cadelechamado = textBoxChamado.Text,
            };

            if (!insert)
                prodEletroInfo.idCadEle = infoEletro.idCadEle;

            return prodEletroInfo;
        }

        private void textBoxCodProd_Leave(object sender, EventArgs e)
        {
            ConsultarNomeProdEletro();
        }

        private void ConsultarNomeProdEletro()
        {
            

            if (!string.IsNullOrEmpty(textBoxCodProd.Text))
            {
                if (int.TryParse(textBoxCodProd.Text, out int cod))
                {
                    EletroTipoInfo eletroTipoInfo = negocioServ.ConsultarEletroTipoId(cod);

                    if (eletroTipoInfo != null)
                    {
                        textBoxCodProd.Text = string.Format("{0:000}", eletroTipoInfo.Cod);
                        labelProdDescricao.Text = eletroTipoInfo.Descricao;
                        textBoxCodMarca.Select();
                    }
                    else
                    {
                        textBoxCodProd.Clear();
                        labelProdDescricao.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Insira um valor numérico!");
                    textBoxCodProd.Select();
                }
            }
        }

        private void ConsultarNomeMarca()
        {
           AutorizadaInfo autorizadaInfo = new AutorizadaInfo();

            if (!string.IsNullOrEmpty(textBoxCodMarca.Text))
            {
                if (int.TryParse(textBoxCodMarca.Text, out int cod))
                {
                    autorizadaInfo = negociosAut.ConsultarAutorizadaId(cod);

                    if (autorizadaInfo != null)
                    {
                        textBoxCodMarca.Text = string.Format("{0:000}", autorizadaInfo.autid);
                        labelMarcaDescricao.Text = autorizadaInfo.autnome;
                        textBoxModelo.Select();
                    }
                    else
                    {
                        textBoxCodMarca.Text = string.Format("{0:000}", 0);
                        labelMarcaDescricao.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Insira um valor numérico!");
                    textBoxCodProd.Select();
                }
            }
        }

        private void textBoxCodMarca_Leave(object sender, EventArgs e)
        {
            ConsultarNomeMarca();
        }

        private void buttonBuscarProduto_Click(object sender, EventArgs e)
        {
            EletroTipoColecao eletroTipoColecao = negocioServ.ConsultarEletroTipo();
            ConsultarTipoEletro(eletroTipoColecao);
        }

        private void ConsultarAutorizada()
        {
           
            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();
            AutorizadaColecao autorizadaColecao = negociosAut.ConsultarAutorizada();
            if (autorizadaColecao != null)
            {
                foreach (AutorizadaInfo aut in autorizadaColecao)
                {
                    Form_Consultar form_Consultar = new Form_Consultar
                    {
                        Cod = string.Format("{0:000}", aut.autid),
                        Descricao = aut.autnome
                    };

                    form_ConsultarColecao.Add(form_Consultar);
                }
            }

            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, "Marcas");
            formConsultar_Cod_Descricao.ShowDialog(this);

            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
            {
                textBoxCodMarca.Text = formConsultar_Cod_Descricao.Selecionado.Cod;
                labelMarcaDescricao.Text = formConsultar_Cod_Descricao.Selecionado.Descricao;
                textBoxModelo.Select();
            }
        }

        private void ConsultarTipoEletro(EletroTipoColecao eletroTipoColecao)
        {
            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();

            foreach (EletroTipoInfo prod in eletroTipoColecao)
            {
                Form_Consultar form_Consultar = new Form_Consultar
                {
                    Cod = string.Format("{0:000}", prod.Cod),
                    Descricao = prod.Descricao
                };

                form_ConsultarColecao.Add(form_Consultar);
            }

            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, "Produtos");
            formConsultar_Cod_Descricao.ShowDialog(this);

            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
            {
                textBoxCodProd.Text = formConsultar_Cod_Descricao.Selecionado.Cod;
                labelProdDescricao.Text = formConsultar_Cod_Descricao.Selecionado.Descricao;
                buttonBuscarMarca.Select();
            }
        }

        private void buttonAddProduto_Click(object sender, EventArgs e)
        {
            ProdutoInfo produtoInfo = new ProdutoInfo();
            FormCadTexto formCadTexto = new FormCadTexto(produtoInfo);
            formCadTexto.ShowDialog(this);
            formCadTexto.Dispose();
        }

        private void buttonBuscarMarca_Click(object sender, EventArgs e)
        {
            ConsultarAutorizada();
        }

        private void buttonAddMarca_Click(object sender, EventArgs e)
        {
            AutorizadaInfo autorizadaInfo = new AutorizadaInfo();
            FormCadTexto formCadTexto = new FormCadTexto(autorizadaInfo);
            formCadTexto.ShowDialog(this);
            formCadTexto.Dispose();
        }
    }
}

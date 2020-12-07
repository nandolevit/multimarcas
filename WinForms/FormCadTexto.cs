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
    public partial class FormCadTexto : Form
    {
        int modSave;
        int idcategoria;
        ServicoNegocio servicoNegocio = new ServicoNegocio(Form1.Empresa.empconexao);
        AutorizadaNegocios autorizadaNegocios = new AutorizadaNegocios(Form1.Empresa.empconexao);
        ProdutoNegocios produtoNegocios = new ProdutoNegocios(Form1.Empresa.empconexao);
        CaixaNegocios caixaNegocios = new CaixaNegocios(Form1.Empresa.empconexao);

        public FormCadTexto()
        {
            Inicializar();
        }

        public FormCadTexto(ProdutoInfo produto)
        {
            Inicializar();
            this.Text = "Tipo de produto";
            modSave = 1;
        }

        public FormCadTexto(AutorizadaInfo autorizada)
        {
            Inicializar();
            this.Text = "Nome da marca";
            modSave = 2;
        }

        public FormCadTexto(ProdCategoriaInfo categoria)
        {
            Inicializar();
            this.Text = "Nome da categoria";
            modSave = 3;
        }

        public FormCadTexto(ProdSubCategoriaInfo subcategoria, int cod)
        {
            Inicializar();
            this.Text = "Nome da subcategoria";
            modSave = 4;
            idcategoria = cod;
        }

        public FormCadTexto(EletroLojaInfo loja)
        {
            Inicializar();
            this.Text = "Nome da loja";
            modSave = 5;
        }

        public FormCadTexto(SangriaInfo sangria)
        {
            Inicializar();
            this.Text = "Nome do Tipo de Sangria";
            modSave = 6;
        }

        private void SavarProdSubCategoria()
        {
            ProdSubCategoriaInfo prodSubCategoriaInfo = new ProdSubCategoriaInfo
            {
                prodsubcatidcategoria = idcategoria,
                Prodsubcatnome = textBoxNome.Text
            };
            
            Mensagem(produtoNegocios.InsertProdSubCategoria(prodSubCategoriaInfo));
        }

        private void SalvarSangria()
        {
            CodDescricaoInfo codDescricaoInfo = new CodDescricaoInfo
            {
                descricao = textBoxNome.Text
            };

            Mensagem(caixaNegocios.InsertSangriaTipo(codDescricaoInfo));
        }

        private void SalvarProdCategoria()
        {
            ProdCategoriaInfo prodCategoriaInfo = new ProdCategoriaInfo
            {
                prodcatnome = textBoxNome.Text
            };

            int cod = produtoNegocios.InsertProdCategoria(prodCategoriaInfo);

            if (cod > 0)
            {
                ProdSubCategoriaInfo prodSubCategoriaInfo = new ProdSubCategoriaInfo
                {
                    prodsubcatidcategoria = cod,
                    Prodsubcatnome = " PADRAO"
                };

                Mensagem(produtoNegocios.InsertProdSubCategoria(prodSubCategoriaInfo));
            }
        }

        private void SavarMarcaEletro()
        {
            AutorizadaInfo autorizadaInfo = new AutorizadaInfo
            {
                autnome = textBoxNome.Text,
            };

            Mensagem(autorizadaNegocios.InsertAutorizada(autorizadaInfo)) ;
        }

        private void SavarTipoProd()
        {
            Mensagem(servicoNegocio.InsertTipoEletro(textBoxNome.Text));
               
        }

        private void Mensagem(int num)
        {
            if (num > 0)
                FormMessage.ShowMessegeInfo("Salvo com sucesso!");
            else
                FormMessage.ShowMessegeInfo("Não foi possível salvar!");
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.AcceptButton = buttonSalvar;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalvarLoja()
        {
            Mensagem(servicoNegocio.InsertLoja(textBoxNome.Text));
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNome.Text))
                FormMessage.ShowMessegeWarning("Insira o novo nome!");
            else
            {
                switch (modSave)
                {
                    case 1:
                        SavarTipoProd();
                        break;
                    case 2:
                        SavarMarcaEletro();
                        break;
                    case 3:
                        SalvarProdCategoria();
                        break;
                    case 4:
                        SavarProdSubCategoria();
                        break;
                    case 5:
                        SalvarLoja();
                        break;
                    case 6:
                        SalvarSangria();
                        break;
                    default:
                        break;
                }

                this.Close();
            }
        }
    }
}

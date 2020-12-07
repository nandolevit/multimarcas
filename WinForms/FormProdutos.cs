using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjTransfer;

namespace WinForms
{
    public partial class FormProdutos : Form
    {
        ProdutoNegocios produtoNegocios = new ProdutoNegocios(Form1.Empresa.empconexao);
        EstoqueNegocios estoque = new EstoqueNegocios(Form1.Empresa.empconexao);
        public ProdutoInfo produtosInfo;
        FornecedorNegocios fornecedorNegocios = new FornecedorNegocios(Form1.Empresa.empconexao);
        FornecedorInfo fornecedorInfo = new FornecedorInfo();
        AutorizadaNegocios autorizadaNegocios = new AutorizadaNegocios(Form1.Empresa.empconexao);

        //bool addEstoque = false;
        bool alterar = false;
        int categoria = 0;
        bool pedido = false;
        //int subCat = 0;

        public FormProdutos()
        {
            FormProdutosInicializar();
        }

        public FormProdutos(ProdEnum prodEnum)
        {
            FormProdutosInicializar();
            

            switch (prodEnum)
            {
                case ProdEnum.Prod:
                    break;
                case ProdEnum.Pedido:
                    pedido = true;
                    break;
                case ProdEnum.Venda:
                    break;
                case ProdEnum.Estoque:
                    radioButtonSim.Checked = true;
                    groupBoxEstoque.Enabled = false;
                    textBoxBarras.Select();
                    textBoxBarras.Text = FormEstoqueContagem.CodBarras;
                    break;
                default:
                    break;
            }
        }

        public FormProdutos(FornecedorInfo fornecedor)
        {
            FormProdutosInicializar();
            groupBoxEstoque.Enabled = false;
            radioButtonSim.Checked = true;
            textBoxCodFornecedor.Text = Convert.ToString(fornecedor.forId);
            LostFocus_Fornecedor();
            textBoxCodFornecedor.Enabled = false;
            buttonAddFornecedor.Enabled = false;
            buttonBuscarFornecedor.Enabled = false;
        }

        public FormProdutos(string barras)
        {
            FormProdutosInicializar();
            textBoxBarras.Text = barras;
            groupBoxEstoque.Enabled = false;
        }

        public FormProdutos(int cod)
        {
            FormProdutosInicializar();
            ConsultarProduto(cod);
            alterar = true;
            buttonBuscarStatus.Enabled = true;
        }

        public void FormProdutosInicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            //this.AcceptButton = buttonSalvar;
            
            textBoxCompra.Text = string.Format("{0:C}", 1.00);
            PreencherPreco();
            
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            //ao receber o foco
            this.textBoxCompra.GotFocus += new System.EventHandler(this.textBoxValor_GotFocus);
            this.textBoxVarejo.GotFocus += new System.EventHandler(this.textBoxValor_GotFocus);
            this.textBoxAtacado.GotFocus += new System.EventHandler(this.textBoxValor_GotFocus);

            //ao perder o foco
            this.textBoxCompra.LostFocus += new System.EventHandler(this.textBoxCompra_LostFocus);
            this.textBoxCompra.LostFocus += new System.EventHandler(this.textBoxValor_LostFocus);
            this.textBoxVarejo.LostFocus += new System.EventHandler(this.textBoxValor_LostFocus);
            this.textBoxAtacado.LostFocus += new System.EventHandler(this.textBoxValor_LostFocus);
            this.textBoxCategoria.LostFocus += new System.EventHandler(this.textBoxCategoria_LostFocus);
            this.textBoxSub.LostFocus += new System.EventHandler(this.textBoxSub_LostFocus);
            this.textBoxMarca.LostFocus += new System.EventHandler(this.textBoxMarca_LostFocus);
            this.textBoxCodFornecedor.LostFocus += new System.EventHandler(this.textBoxCodFornecedor_LostFocus);

            //ao ser alterado
            this.textBoxSub.TextChanged += new System.EventHandler(this.LimparTextBoxAoAlterar);
            this.textBoxCategoria.TextChanged += new System.EventHandler(this.LimparTextBoxAoAlterar);
            this.textBoxMarca.TextChanged += new System.EventHandler(this.LimparTextBoxAoAlterar);
            this.textBoxCodFornecedor.TextChanged += new System.EventHandler(this.LimparTextBoxAoAlterar);
            this.textBoxStatus.TextChanged += new System.EventHandler(this.LimparTextBoxAoAlterar);

            textBoxDescricao.Select();
        }

        private void LimparTextBoxAoAlterar(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            string nome = box.Name;

            switch (nome)
            {
                case "textBoxSub":
                    LimparLabelAoAlterar(labelValorSub, e);
                    break;
                case "textBoxCategoria":
                    LimparLabelAoAlterar(labelValorCategoria, e);
                    break;
                case "textBoxMarca":
                    LimparLabelAoAlterar(labelValorMarca, e);
                    break;
                case "textBoxCodFornecedor":
                    LimparLabelAoAlterar(labelValorFornecedor, e);
                    break;
                case "textBoxStatus":
                    LimparLabelAoAlterar(labelValorStatus, e);
                    break;
                default:
                    break;
            }
        }

        private void LimparLabelAoAlterar(object sender, EventArgs e)
        {
            Label box = (Label)sender;
            box.Text = "";
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxCompra_LostFocus(object sender, EventArgs e)
        {
            PreencherPreco();
        }

        private void PreencherPreco()
        {
            if (decimal.TryParse(textBoxCompra.Text, out decimal compra))
            {
                textBoxVarejo.Text = Math.Round((compra * 2), 2).ToString();
                textBoxAtacado.Text = Math.Round((((compra / 4) * 3) + compra), 2).ToString();
            }
        }

        private void textBoxValor_LostFocus(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (decimal.TryParse(box.Text, out decimal compra))
            {
                box.Text = compra.ToString();
            }
        }

        private void textBoxValor_GotFocus(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.Text = box.Text.Replace("R$", "");
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (CamposObrigatorio())
            {
                string novoBarras = "1";
                int fornecedor, marca, status, categoria;
                int id;

                fornecedor = Convert.ToInt32(textBoxCodFornecedor.Text);
                marca = Convert.ToInt32(textBoxMarca.Text);
                status = Convert.ToInt32(textBoxStatus.Text);
                categoria = Convert.ToInt32(textBoxSub.Text);

                if (string.IsNullOrEmpty(textBoxCod.Text))
                    id = 0;
                else
                    id = Convert.ToInt32(textBoxCod.Text);
                
                produtosInfo = new ProdutoInfo
                {
                    proId = id,
                    proCodBarras = textBoxBarras.Text,
                    proControleEstoque = radioButtonSim.Checked,
                    proDescricao = textBoxDescricao.Text,
                    proQuantMinima = Convert.ToInt32(textBoxQuant.Text),
                    proValorAtacado = Convert.ToDecimal(textBoxAtacado.Text.Replace("R$", "")),
                    proValorCompra = Convert.ToDecimal(textBoxCompra.Text.Replace("R$", "")),
                    proValorVarejo = Convert.ToDecimal(textBoxVarejo.Text.Replace("R$", "")),
                    proidfornecedor = fornecedor,
                    proidmarca = marca,
                    proidstatus = status,
                    proidsubcategoria = categoria,
                    proidUser = Form1.User.useidfuncionario,
                    procodkit = textBoxCodKit.Text
                };

                //opção para salvar ou alterar o produto
                if (!alterar)
                {//salvar o produto
                    int cod = produtoNegocios.InsertProduto(produtosInfo);

                    if (radioButtonSim.Checked)
                        produtoNegocios.InsertProdutoEstoque(cod, Form1.Unidade.uniid);

                    if (cod > 0)
                    {
                        if (string.IsNullOrEmpty(textBoxBarras.Text))
                        {
                            novoBarras += string.Format("{0:00}", marca).Substring(0, 2);
                            novoBarras += string.Format("{0:00}", fornecedor).Substring(0, 2);
                            novoBarras += string.Format("{0:00}", categoria).Substring(0, 2);
                            novoBarras += string.Format("{0:000000}", cod);
                            textBoxBarras.Text = novoBarras;
                            produtosInfo.proId = cod;
                            produtosInfo.proCodBarras = novoBarras;
                            produtoNegocios.UpdateProduto(produtosInfo);
                        }

                        if (pedido)
                        {
                            this.DialogResult = DialogResult.Yes;
                        }
                        else
                        {
                            textBoxCod.Text = cod.ToString();
                            if (FormMessage.ShowMessegeQuestion("Salvo com sucesso! Deseja cadastrar um novo produto?") == DialogResult.Yes)
                                LimparForm();
                            else
                                Close();
                        }
                    }
                    else
                        FormMessage.ShowMessegeInfo("Falha na tentativa!");
                }
                else
                {//alterar o produto
                    if (FormMessage.ShowMessegeQuestion("Deseja salvar as alterações?") == DialogResult.Yes)
                    {
                        if (produtoNegocios.UpdateProduto(produtosInfo))
                        {
                            FormMessage.ShowMessegeInfo("Informações alterado com sucesso.");
                            this.DialogResult = DialogResult.Yes;
                        }
                        else
                        {
                            FormMessage.ShowMessegeWarning("Houve falha na tentativa de reparo!");
                        }
                    }
                }
            }
            else
                FormMessage.ShowMessegeWarning("Preencher todos os campos obrigatório!");
        }

        private void LimparForm(bool b = true)
        {
            textBoxCod.Clear();
            textBoxDescricao.Clear();

            if (b)
                textBoxBarras.Clear();

            textBoxCompra.Text = string.Format("{0:C}", 1.00);
            PreencherPreco();
            textBoxQuant.Text = "1";
            radioButtonSim.Checked = true;
            textBoxBarras.Select();

        }

        private void FormProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxBarras.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ProdutoInfo produtosInfo = produtoNegocios.ConsultarProdutoCodBarras(textBoxBarras.Text);

                    if (produtosInfo != null)
                        PreencherForm(produtosInfo);
                    else
                        textBoxDescricao.Select();
                }
            }
        }

        private void BuscarporCod()
        {
            LostFocus_Categoria();
            LostFocus_Fornecedor();
            LostFocus_Subcategoria();
            LostFocus_Marca();
        }

        private void PreencherForm(ProdutoInfo produtosInfo, bool b = false)
        {
            if (produtosInfo != null)
            {
                ProdCategoriaInfo cat = new ProdCategoriaInfo();
                FornecedorInfo forn = new FornecedorInfo();

                textBoxCod.Text = string.Format("{0:000000}", produtosInfo.proId);
                textBoxDescricao.Text = produtosInfo.proDescricao;
                textBoxBarras.Text = produtosInfo.proCodBarras;
                textBoxCodKit.Text = produtosInfo.procodkit;
                textBoxCompra.Text = string.Format("{0}", produtosInfo.proValorCompra);
                textBoxVarejo.Text = string.Format("{0}", produtosInfo.proValorVarejo);
                textBoxAtacado.Text = string.Format("{0}", produtosInfo.proValorAtacado);
                textBoxQuant.Text = produtosInfo.proQuantMinima.ToString();

                if (produtosInfo.proControleEstoque == true)
                {
                    ProdutoInfo contar =  estoque.ConsultarEstoqueIdProdutoUnid(produtosInfo.proId, Form1.Unidade.uniid);
                    radioButtonSim.Checked = true;
                    labelEstoque.Visible = true;
                    labelEstoqueValor.Visible = true;
                    labelEstoqueValor.Text = string.Format("{0:0000}", contar.prodestoquequant);
                }
                else
                    radioButtonNao.Checked = true;
                
                textBoxSub.Text = Convert.ToString(produtosInfo.proidsubcategoria);
                textBoxMarca.Text = Convert.ToString(produtosInfo.proidmarca);
                textBoxCodFornecedor.Text = Convert.ToString(produtosInfo.proidfornecedor);
                textBoxStatus.Text = string.Format("{0:000}", produtosInfo.proidstatus);
                labelValorStatus.Text = produtosInfo.Desativado;
                BuscarporCod();
                textBoxStatus.Enabled = true;
                buttonSalvar.Text = "Alterar";
            }
            else
            {
                LimparForm(b);
                buttonSalvar.Enabled = true;
            }
        }

        private void radioButtonSim_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSim.Checked)
            {
                textBoxQuant.Enabled = true;
                textBoxQuant.Text = "1";
            }
            else
            {
                textBoxQuant.Enabled = false;
                textBoxQuant.Text = "0";
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBoxCod.Text))
            {
                if (int.TryParse(textBoxCod.Text, out int cod))
                {
                    ConsultarProduto(cod);
                }
                else
                    FormMessage.ShowMessegeInfo("Insira um código válido!");
            }
        }

        private void ConsultarProduto(int cod)
        {
            ProdutoInfo produtosInfo = new ProdutoInfo();
            produtosInfo = produtoNegocios.ConsultarProdutosId(cod);
            PreencherForm(produtosInfo, true);
        }

        private void CamposObrigatorioRed()
        {
            if (string.IsNullOrEmpty(textBoxDescricao.Text))
                labelDescricao.ForeColor = Color.Red;
            else
                labelDescricao.ForeColor = Color.Black;

            if (string.IsNullOrEmpty(textBoxCompra.Text))
                labelCompra.ForeColor = Color.Red;
            else
                labelCompra.ForeColor = Color.Black;

            if (string.IsNullOrEmpty(textBoxAtacado.Text))
                labelAtacado.ForeColor = Color.Red;
            else
                labelAtacado.ForeColor = Color.Black;

            if (string.IsNullOrEmpty(textBoxVarejo.Text))
                labelVarejo.ForeColor = Color.Red;
            else
                labelVarejo.ForeColor = Color.Black;

            if (string.IsNullOrEmpty(textBoxQuant.Text))
                labelQuantidade.ForeColor = Color.Red;
            else
                labelQuantidade.ForeColor = Color.Black;
        }

        private bool CamposObrigatorio()
        {
            CamposObrigatorioRed();

            if (string.IsNullOrEmpty(textBoxDescricao.Text))
                return false;
            if (string.IsNullOrEmpty(textBoxCompra.Text))
                return false;
            if (string.IsNullOrEmpty(textBoxAtacado.Text))
                return false;
            if (string.IsNullOrEmpty(textBoxVarejo.Text))
                return false;
            if (string.IsNullOrEmpty(textBoxQuant.Text))
                return false;
            if (string.IsNullOrEmpty(textBoxCategoria.Text))
                return false;
            if (string.IsNullOrEmpty(textBoxSub.Text))
                return false;
            if (string.IsNullOrEmpty(textBoxCodFornecedor.Text))
                return false;
            if (string.IsNullOrEmpty(textBoxMarca.Text))
                return false;

            return true;
        }

        private void pictureBoxBuscarCat_Click(object sender, EventArgs e)
        {
            
        }

        private void BusarCategoria()
        {
            ProdCategoriaColecao prodCategoriaColecao = new ProdCategoriaColecao();
            prodCategoriaColecao = produtoNegocios.ConsultarProdCategoria();
            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();

            if (prodCategoriaColecao != null)
            {
                foreach (ProdCategoriaInfo cat in prodCategoriaColecao)
                {
                    Form_Consultar consult = new Form_Consultar
                    {
                        Cod = string.Format("{0:000}", cat.prodcatid),
                        Descricao = cat.prodcatnome
                    };

                    form_ConsultarColecao.Add(consult);
                }
            }

            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, "Categoria");
            formConsultar_Cod_Descricao.ShowDialog(this);

            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
            {
                categoria = Convert.ToInt16(formConsultar_Cod_Descricao.Selecionado.Cod);
                textBoxCategoria.Text = formConsultar_Cod_Descricao.Selecionado.Cod;
                labelValorCategoria.Text = formConsultar_Cod_Descricao.Selecionado.Descricao;
                textBoxSub.Clear();
                labelValorSub.Text = "";
                buttonBuscarSubCategoria.Select();
            }

            formConsultar_Cod_Descricao.Dispose();
        }

        private void pictureBoxBuscarSub_Click(object sender, EventArgs e)
        {
            
        }

        private void BuscarSubcategoria()
        {
            ProdSubCategoriaColecao prodSubCategoriaColecao = produtoNegocios.ConsultarProdSubCategoria(categoria);
            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();

            if (prodSubCategoriaColecao != null)
            {
                foreach (ProdSubCategoriaInfo categoria in prodSubCategoriaColecao)
                {
                    Form_Consultar form_Consultar = new Form_Consultar
                    {
                        Cod = string.Format("{0:000}", categoria.Prodsubcatid),
                        Descricao = categoria.Prodsubcatnome
                    };

                    form_ConsultarColecao.Add(form_Consultar);
                }
            }

            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, "Sub-Categoria");
            formConsultar_Cod_Descricao.ShowDialog(this);

            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
            {
                categoria = Convert.ToInt16(formConsultar_Cod_Descricao.Selecionado.Cod);
                textBoxSub.Text = string.Format("{0:000}", Convert.ToInt32(formConsultar_Cod_Descricao.Selecionado.Cod));
                labelValorSub.Text = formConsultar_Cod_Descricao.Selecionado.Descricao;
                buttonBuscarMarca.Select();
            }
            formConsultar_Cod_Descricao.Dispose();
        }

        private void pictureBoxMarca_Click(object sender, EventArgs e)
        {
            
        }

        private void BuscarMarcar()
        {
            AutorizadaColecao autorizadaColecao = autorizadaNegocios.ConsultarAutorizada();
            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();

            if (autorizadaColecao != null)
            {
                foreach (AutorizadaInfo autorizadaInfo in autorizadaColecao)
                {
                    Form_Consultar form_Consultar = new Form_Consultar
                    {
                        Cod = string.Format("{0:000}", autorizadaInfo.autid),
                        Descricao = autorizadaInfo.autnome
                    };

                    form_ConsultarColecao.Add(form_Consultar);
                }
            }

            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, "Sub-Categoria");
            formConsultar_Cod_Descricao.ShowDialog(this);

            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
            {
                textBoxMarca.Text = string.Format("{0:000}", Convert.ToInt32(formConsultar_Cod_Descricao.Selecionado.Cod));
                labelValorMarca.Text = formConsultar_Cod_Descricao.Selecionado.Descricao;
                buttonBuscarFornecedor.Select();
            }
            formConsultar_Cod_Descricao.Dispose();
        }

        private void pictureBoxBuscarFornecedor_Click(object sender, EventArgs e)
        {
            
        }

        private void BuscarFornecedor()
        {
            FornecedorColecao fornecedorColecao = fornecedorNegocios.ConsultarForncedor();
            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();

            if (fornecedorColecao != null)
            {
                foreach (FornecedorInfo info in fornecedorColecao)
                {
                    Form_Consultar form_Consultar = new Form_Consultar
                    {
                        Cod = string.Format("{0:000}", info.forId),
                        Descricao = info.forNome
                    };

                    form_ConsultarColecao.Add(form_Consultar);
                }
            }

            Form_Consultar formConsultar = AbrirForm(form_ConsultarColecao, "Fornecedores");

            if (formConsultar != null)
            {
                textBoxCodFornecedor.Text = formConsultar.Cod;
                labelValorFornecedor.Text = formConsultar.Descricao;
                buttonSalvar.Select();
            }
        }

        private void pictureBoxBuscarStatus_Click(object sender, EventArgs e)
        {
            
        }

        private void LostFocus_Marca()
        {
            if (!string.IsNullOrEmpty(textBoxMarca.Text))
            {
                if (int.TryParse(textBoxMarca.Text, out int cod))
                {
                    AutorizadaInfo autorizadaInfo = autorizadaNegocios.ConsultarAutorizadaId(cod);

                    if (autorizadaInfo != null)
                    {
                        textBoxMarca.Text = string.Format("{0:000}", autorizadaInfo.autid);
                        labelValorMarca.Text = autorizadaInfo.autnome;
                    }
                    else
                    {
                        FormMessage.ShowMessegeWarning("Não foi encontrado, digite outro código!");
                        textBoxMarca.Select();
                        textBoxMarca.Clear();
                    }
                }
            }
        }

        private void textBoxMarca_LostFocus(object sender, EventArgs e)
        {
            LostFocus_Marca();
        }

        private void LostFocus_Fornecedor()
        {
            if (!string.IsNullOrEmpty(textBoxCodFornecedor.Text))
            {
                if (int.TryParse(textBoxCodFornecedor.Text, out int cod))
                {
                    FornecedorInfo fornecedor = fornecedorNegocios.ConsultarForncedorId(cod);

                    if (fornecedor != null)
                    {
                        textBoxCodFornecedor.Text = string.Format("{0:000}", fornecedor.forId);
                        labelValorFornecedor.Text = fornecedor.forNome;
                    }
                    else
                    {
                        FormMessage.ShowMessegeWarning("Não foi encontrado, digite outro código!");
                        textBoxCodFornecedor.Select();
                        textBoxCodFornecedor.Clear();
                    }
                }
            }
        }

        private void textBoxCodFornecedor_LostFocus(object sender, EventArgs e)
        {
            
        }

        private void LostFocus_Subcategoria()
        {
            if (!string.IsNullOrEmpty(textBoxSub.Text))
            {
                if (int.TryParse(textBoxSub.Text, out int cod))
                {
                    ProdSubCategoriaInfo prodSubCategoriaInfo = produtoNegocios.ConsultarProdSubCategoriaId(cod);

                    if (prodSubCategoriaInfo != null)
                    {
                        textBoxSub.Text = string.Format("{0:000}", prodSubCategoriaInfo.Prodsubcatid);
                        labelValorSub.Text = prodSubCategoriaInfo.Prodsubcatnome;

                        ProdCategoriaInfo prodCategoriaInfo = produtoNegocios.ConsultarProdCategoriaId(prodSubCategoriaInfo.prodsubcatidcategoria);
                        textBoxCategoria.Text = string.Format("{0:000}", prodCategoriaInfo.prodcatid);
                        labelValorCategoria.Text = prodCategoriaInfo.prodcatnome;
                    }
                    else
                    {
                        FormMessage.ShowMessegeWarning("Não foi encontrado, digite outro código!");
                        textBoxSub.Select();
                        textBoxSub.Clear();
                    }
                }
            }
        }

        private void textBoxSub_LostFocus(object sender, EventArgs e)
        {
            
        }

        private void LostFocus_Categoria()
        {
            if (!string.IsNullOrEmpty(textBoxCategoria.Text))
            {
                if (int.TryParse(textBoxCategoria.Text, out int cod))
                {
                    ProdCategoriaInfo prodCategoriaInfo = produtoNegocios.ConsultarProdCategoriaId(cod);

                    if (prodCategoriaInfo != null)
                    {
                        textBoxCategoria.Text = string.Format("{0:000}", prodCategoriaInfo.prodcatid);
                        labelValorCategoria.Text = prodCategoriaInfo.prodcatnome;
                    }
                    else
                    {
                        FormMessage.ShowMessegeWarning("Não foi encontrado, digite outro código!");
                        textBoxCategoria.Select();
                        textBoxCategoria.Clear();
                    }
                }
            }
        }

        private void textBoxCategoria_LostFocus(object sender, EventArgs e)
        {
            LostFocus_Categoria();
        }

        private void pictureBoxFornecedor_Click(object sender, EventArgs e)
        {
            
        }

        private Form_Consultar AbrirForm(Form_ConsultarColecao form_Consultar, string titulo)
        {
            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_Consultar, titulo);
            formConsultar_Cod_Descricao.ShowDialog(this);

            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
                return formConsultar_Cod_Descricao.Selecionado;
            else
            {
                formConsultar_Cod_Descricao.Dispose();
                return null;
            }

        }

        private void buttonBuscarCategoria_Click(object sender, EventArgs e)
        {
            BusarCategoria();
        }

        private void buttonAddCategoria_Click(object sender, EventArgs e)
        {
            ProdCategoriaInfo prodCategoriaInfo = new ProdCategoriaInfo();
            FormCadTexto formCadTexto = new FormCadTexto(prodCategoriaInfo);
            formCadTexto.ShowDialog(this);
            formCadTexto.Dispose();
        }

        private void buttonBuscarSubCategoria_Click(object sender, EventArgs e)
        {
            BuscarSubcategoria();
        }

        private void buttonAddSubCategoria_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCategoria.Text))
            {
                ProdSubCategoriaInfo prodSubCategoriaInfo = new ProdSubCategoriaInfo();
                FormCadTexto formCadTexto = new FormCadTexto(prodSubCategoriaInfo, Convert.ToInt32(textBoxCategoria.Text));
                formCadTexto.ShowDialog(this);
                formCadTexto.Dispose();
            }
            else
            {
                FormMessage.ShowMessegeWarning("Selecione uma categoria");
                textBoxCategoria.Select();
            }
        }

        private void buttonBuscarMarca_Click(object sender, EventArgs e)
        {
            BuscarMarcar();
        }

        private void buttonAddMarca_Click(object sender, EventArgs e)
        {
            AutorizadaInfo autorizadaInfo = new AutorizadaInfo();
            FormCadTexto formCadTexto = new FormCadTexto(autorizadaInfo);
            formCadTexto.ShowDialog(this);
            formCadTexto.Dispose();

        }

        private void buttonBuscarFornecedor_Click(object sender, EventArgs e)
        {
            BuscarFornecedor();
        }

        private void buttonAddFornecedor_Click(object sender, EventArgs e)
        {
            FormCadastroPessoa formCadastroPessoa = new FormCadastroPessoa(fornecedorInfo);
            formCadastroPessoa.ShowDialog(this);
            formCadastroPessoa.Dispose();
        }

        private void buttonBuscarStatus_Click(object sender, EventArgs e)
        {
            ProdStatusColecao prodStatusColecao = produtoNegocios.ConsultarProdStatus();
            Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();

            if (prodStatusColecao != null)
            {
                foreach (ProdStatusInfo status in prodStatusColecao)
                {
                    Form_Consultar form_Consultar = new Form_Consultar
                    {
                        Cod = string.Format("{0:000}", status.prodstaid),
                        Descricao = status.prodstadescricao
                    };

                    form_ConsultarColecao.Add(form_Consultar);
                }
            }

            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, "Status do Produto");
            formConsultar_Cod_Descricao.ShowDialog(this);
            if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
            {
                textBoxStatus.Text = string.Format("{0:000}", Convert.ToInt32(formConsultar_Cod_Descricao.Selecionado.Cod));
                labelValorStatus.Text = formConsultar_Cod_Descricao.Selecionado.Descricao;
            }

            formConsultar_Cod_Descricao.Dispose();
        }

        private void textBoxCompra_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat((TextBox)sender);
        }

        private void textBoxVarejo_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat((TextBox)sender);
        }

        private void textBoxAtacado_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat((TextBox)sender);
        }
    }
}

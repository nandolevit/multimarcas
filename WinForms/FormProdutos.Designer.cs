namespace WinForms
{
    partial class FormProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelCompra = new System.Windows.Forms.Label();
            this.textBoxCompra = new System.Windows.Forms.TextBox();
            this.labelVarejo = new System.Windows.Forms.Label();
            this.textBoxVarejo = new System.Windows.Forms.TextBox();
            this.labelBarras = new System.Windows.Forms.Label();
            this.textBoxBarras = new System.Windows.Forms.TextBox();
            this.labelAtacado = new System.Windows.Forms.Label();
            this.textBoxAtacado = new System.Windows.Forms.TextBox();
            this.groupBoxEstoque = new System.Windows.Forms.GroupBox();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.textBoxQuant = new System.Windows.Forms.TextBox();
            this.labelCod = new System.Windows.Forms.Label();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.labelValorCategoria = new System.Windows.Forms.Label();
            this.labelGrupo = new System.Windows.Forms.Label();
            this.labelSub = new System.Windows.Forms.Label();
            this.labelValorSub = new System.Windows.Forms.Label();
            this.textBoxSub = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelValorMarca = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.labelValorFornecedor = new System.Windows.Forms.Label();
            this.textBoxCodFornecedor = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelValorStatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.groupBoxClasse = new System.Windows.Forms.GroupBox();
            this.labelEstoque = new System.Windows.Forms.Label();
            this.labelEstoqueValor = new System.Windows.Forms.Label();
            this.buttonAddStatus = new System.Windows.Forms.Button();
            this.buttonBuscarStatus = new System.Windows.Forms.Button();
            this.buttonAddFornecedor = new System.Windows.Forms.Button();
            this.buttonBuscarFornecedor = new System.Windows.Forms.Button();
            this.buttonAddMarca = new System.Windows.Forms.Button();
            this.buttonBuscarMarca = new System.Windows.Forms.Button();
            this.buttonAddSubCategoria = new System.Windows.Forms.Button();
            this.buttonBuscarSubCategoria = new System.Windows.Forms.Button();
            this.buttonAddCategoria = new System.Windows.Forms.Button();
            this.buttonBuscarCategoria = new System.Windows.Forms.Button();
            this.labelCodKit = new System.Windows.Forms.Label();
            this.textBoxCodKit = new System.Windows.Forms.TextBox();
            this.groupBoxEstoque.SuspendLayout();
            this.groupBoxClasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(12, 66);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(514, 20);
            this.textBoxDescricao.TabIndex = 7;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(12, 53);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(116, 13);
            this.labelDescricao.TabIndex = 6;
            this.labelDescricao.Text = "Descrição do produto:*";
            // 
            // labelCompra
            // 
            this.labelCompra.AutoSize = true;
            this.labelCompra.Location = new System.Drawing.Point(13, 87);
            this.labelCompra.Name = "labelCompra";
            this.labelCompra.Size = new System.Drawing.Size(77, 13);
            this.labelCompra.TabIndex = 8;
            this.labelCompra.Text = "V. de compra:*";
            // 
            // textBoxCompra
            // 
            this.textBoxCompra.Location = new System.Drawing.Point(12, 100);
            this.textBoxCompra.Name = "textBoxCompra";
            this.textBoxCompra.Size = new System.Drawing.Size(74, 20);
            this.textBoxCompra.TabIndex = 9;
            this.textBoxCompra.TextChanged += new System.EventHandler(this.textBoxCompra_TextChanged);
            // 
            // labelVarejo
            // 
            this.labelVarejo.AutoSize = true;
            this.labelVarejo.Location = new System.Drawing.Point(92, 87);
            this.labelVarejo.Name = "labelVarejo";
            this.labelVarejo.Size = new System.Drawing.Size(71, 13);
            this.labelVarejo.TabIndex = 10;
            this.labelVarejo.Text = "V. de varejo:*";
            // 
            // textBoxVarejo
            // 
            this.textBoxVarejo.Location = new System.Drawing.Point(91, 100);
            this.textBoxVarejo.Name = "textBoxVarejo";
            this.textBoxVarejo.Size = new System.Drawing.Size(74, 20);
            this.textBoxVarejo.TabIndex = 11;
            this.textBoxVarejo.TextChanged += new System.EventHandler(this.textBoxVarejo_TextChanged);
            // 
            // labelBarras
            // 
            this.labelBarras.AutoSize = true;
            this.labelBarras.Location = new System.Drawing.Point(186, 17);
            this.labelBarras.Name = "labelBarras";
            this.labelBarras.Size = new System.Drawing.Size(139, 13);
            this.labelBarras.TabIndex = 2;
            this.labelBarras.Text = "Código de barras (opcional):";
            // 
            // textBoxBarras
            // 
            this.textBoxBarras.Location = new System.Drawing.Point(186, 30);
            this.textBoxBarras.Name = "textBoxBarras";
            this.textBoxBarras.Size = new System.Drawing.Size(195, 20);
            this.textBoxBarras.TabIndex = 3;
            // 
            // labelAtacado
            // 
            this.labelAtacado.AutoSize = true;
            this.labelAtacado.Location = new System.Drawing.Point(171, 87);
            this.labelAtacado.Name = "labelAtacado";
            this.labelAtacado.Size = new System.Drawing.Size(81, 13);
            this.labelAtacado.TabIndex = 12;
            this.labelAtacado.Text = "V. de atacado:*";
            // 
            // textBoxAtacado
            // 
            this.textBoxAtacado.Location = new System.Drawing.Point(171, 100);
            this.textBoxAtacado.Name = "textBoxAtacado";
            this.textBoxAtacado.Size = new System.Drawing.Size(75, 20);
            this.textBoxAtacado.TabIndex = 13;
            this.textBoxAtacado.TextChanged += new System.EventHandler(this.textBoxAtacado_TextChanged);
            // 
            // groupBoxEstoque
            // 
            this.groupBoxEstoque.Controls.Add(this.radioButtonNao);
            this.groupBoxEstoque.Controls.Add(this.radioButtonSim);
            this.groupBoxEstoque.Location = new System.Drawing.Point(398, 87);
            this.groupBoxEstoque.Name = "groupBoxEstoque";
            this.groupBoxEstoque.Size = new System.Drawing.Size(129, 43);
            this.groupBoxEstoque.TabIndex = 16;
            this.groupBoxEstoque.TabStop = false;
            this.groupBoxEstoque.Text = "Controle de estoque?";
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Checked = true;
            this.radioButtonNao.Location = new System.Drawing.Point(65, 19);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(45, 17);
            this.radioButtonNao.TabIndex = 1;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Location = new System.Drawing.Point(6, 19);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(42, 17);
            this.radioButtonSim.TabIndex = 0;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            this.radioButtonSim.CheckedChanged += new System.EventHandler(this.radioButtonSim_CheckedChanged);
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(253, 87);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(47, 13);
            this.labelQuantidade.TabIndex = 14;
            this.labelQuantidade.Text = "Q. Mín.*";
            // 
            // textBoxQuant
            // 
            this.textBoxQuant.Location = new System.Drawing.Point(252, 100);
            this.textBoxQuant.Name = "textBoxQuant";
            this.textBoxQuant.Size = new System.Drawing.Size(44, 20);
            this.textBoxQuant.TabIndex = 15;
            this.textBoxQuant.Text = "1";
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(12, 17);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(43, 13);
            this.labelCod.TabIndex = 0;
            this.labelCod.Text = "Código:";
            // 
            // textBoxCod
            // 
            this.textBoxCod.Enabled = false;
            this.textBoxCod.Location = new System.Drawing.Point(12, 30);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(110, 20);
            this.textBoxCod.TabIndex = 1;
            // 
            // labelValorCategoria
            // 
            this.labelValorCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelValorCategoria.Location = new System.Drawing.Point(89, 32);
            this.labelValorCategoria.Name = "labelValorCategoria";
            this.labelValorCategoria.Size = new System.Drawing.Size(416, 20);
            this.labelValorCategoria.TabIndex = 4;
            this.labelValorCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGrupo
            // 
            this.labelGrupo.AutoSize = true;
            this.labelGrupo.Location = new System.Drawing.Point(89, 19);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(36, 13);
            this.labelGrupo.TabIndex = 3;
            this.labelGrupo.Text = "Grupo";
            // 
            // labelSub
            // 
            this.labelSub.AutoSize = true;
            this.labelSub.Location = new System.Drawing.Point(89, 55);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(56, 13);
            this.labelSub.TabIndex = 8;
            this.labelSub.Text = "Sub-grupo";
            // 
            // labelValorSub
            // 
            this.labelValorSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelValorSub.Location = new System.Drawing.Point(89, 68);
            this.labelValorSub.Name = "labelValorSub";
            this.labelValorSub.Size = new System.Drawing.Size(416, 20);
            this.labelValorSub.TabIndex = 9;
            this.labelValorSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSub
            // 
            this.textBoxSub.Location = new System.Drawing.Point(9, 68);
            this.textBoxSub.Name = "textBoxSub";
            this.textBoxSub.Size = new System.Drawing.Size(30, 20);
            this.textBoxSub.TabIndex = 5;
            this.textBoxSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(89, 91);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 13;
            this.labelMarca.Text = "Marca:";
            // 
            // labelValorMarca
            // 
            this.labelValorMarca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelValorMarca.Location = new System.Drawing.Point(89, 104);
            this.labelValorMarca.Name = "labelValorMarca";
            this.labelValorMarca.Size = new System.Drawing.Size(416, 20);
            this.labelValorMarca.TabIndex = 14;
            this.labelValorMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(9, 104);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(30, 20);
            this.textBoxMarca.TabIndex = 10;
            this.textBoxMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Location = new System.Drawing.Point(89, 127);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(64, 13);
            this.labelFornecedor.TabIndex = 18;
            this.labelFornecedor.Text = "Fornecedor:";
            // 
            // labelValorFornecedor
            // 
            this.labelValorFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelValorFornecedor.Location = new System.Drawing.Point(89, 140);
            this.labelValorFornecedor.Name = "labelValorFornecedor";
            this.labelValorFornecedor.Size = new System.Drawing.Size(416, 20);
            this.labelValorFornecedor.TabIndex = 19;
            this.labelValorFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCodFornecedor
            // 
            this.textBoxCodFornecedor.Location = new System.Drawing.Point(9, 140);
            this.textBoxCodFornecedor.Name = "textBoxCodFornecedor";
            this.textBoxCodFornecedor.Size = new System.Drawing.Size(30, 20);
            this.textBoxCodFornecedor.TabIndex = 15;
            this.textBoxCodFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(89, 163);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 23;
            this.labelStatus.Text = "Status:";
            // 
            // labelValorStatus
            // 
            this.labelValorStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelValorStatus.Location = new System.Drawing.Point(89, 176);
            this.labelValorStatus.Name = "labelValorStatus";
            this.labelValorStatus.Size = new System.Drawing.Size(224, 20);
            this.labelValorStatus.TabIndex = 24;
            this.labelValorStatus.Text = "ATIVADO";
            this.labelValorStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Enabled = false;
            this.textBoxStatus.Location = new System.Drawing.Point(9, 176);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(30, 20);
            this.textBoxStatus.TabIndex = 20;
            this.textBoxStatus.Text = "001";
            this.textBoxStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(9, 32);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(30, 20);
            this.textBoxCategoria.TabIndex = 0;
            this.textBoxCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(350, 339);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 40);
            this.buttonSalvar.TabIndex = 17;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(442, 339);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 18;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // groupBoxClasse
            // 
            this.groupBoxClasse.Controls.Add(this.labelEstoque);
            this.groupBoxClasse.Controls.Add(this.labelEstoqueValor);
            this.groupBoxClasse.Controls.Add(this.buttonAddStatus);
            this.groupBoxClasse.Controls.Add(this.buttonBuscarStatus);
            this.groupBoxClasse.Controls.Add(this.buttonAddFornecedor);
            this.groupBoxClasse.Controls.Add(this.buttonBuscarFornecedor);
            this.groupBoxClasse.Controls.Add(this.buttonAddMarca);
            this.groupBoxClasse.Controls.Add(this.buttonBuscarMarca);
            this.groupBoxClasse.Controls.Add(this.buttonAddSubCategoria);
            this.groupBoxClasse.Controls.Add(this.buttonBuscarSubCategoria);
            this.groupBoxClasse.Controls.Add(this.buttonAddCategoria);
            this.groupBoxClasse.Controls.Add(this.buttonBuscarCategoria);
            this.groupBoxClasse.Controls.Add(this.textBoxCategoria);
            this.groupBoxClasse.Controls.Add(this.labelValorCategoria);
            this.groupBoxClasse.Controls.Add(this.labelStatus);
            this.groupBoxClasse.Controls.Add(this.labelGrupo);
            this.groupBoxClasse.Controls.Add(this.textBoxSub);
            this.groupBoxClasse.Controls.Add(this.labelValorStatus);
            this.groupBoxClasse.Controls.Add(this.labelValorSub);
            this.groupBoxClasse.Controls.Add(this.textBoxStatus);
            this.groupBoxClasse.Controls.Add(this.labelFornecedor);
            this.groupBoxClasse.Controls.Add(this.labelSub);
            this.groupBoxClasse.Controls.Add(this.textBoxMarca);
            this.groupBoxClasse.Controls.Add(this.labelValorFornecedor);
            this.groupBoxClasse.Controls.Add(this.labelValorMarca);
            this.groupBoxClasse.Controls.Add(this.textBoxCodFornecedor);
            this.groupBoxClasse.Controls.Add(this.labelMarca);
            this.groupBoxClasse.Location = new System.Drawing.Point(12, 129);
            this.groupBoxClasse.Name = "groupBoxClasse";
            this.groupBoxClasse.Size = new System.Drawing.Size(515, 204);
            this.groupBoxClasse.TabIndex = 17;
            this.groupBoxClasse.TabStop = false;
            this.groupBoxClasse.Text = "Classificação do produto:";
            // 
            // labelEstoque
            // 
            this.labelEstoque.AutoSize = true;
            this.labelEstoque.Location = new System.Drawing.Point(431, 163);
            this.labelEstoque.Name = "labelEstoque";
            this.labelEstoque.Size = new System.Drawing.Size(49, 13);
            this.labelEstoque.TabIndex = 19;
            this.labelEstoque.Text = "Estoque:";
            this.labelEstoque.Visible = false;
            // 
            // labelEstoqueValor
            // 
            this.labelEstoqueValor.BackColor = System.Drawing.Color.Salmon;
            this.labelEstoqueValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstoqueValor.ForeColor = System.Drawing.Color.Maroon;
            this.labelEstoqueValor.Location = new System.Drawing.Point(431, 176);
            this.labelEstoqueValor.Name = "labelEstoqueValor";
            this.labelEstoqueValor.Size = new System.Drawing.Size(74, 20);
            this.labelEstoqueValor.TabIndex = 19;
            this.labelEstoqueValor.Text = "0000";
            this.labelEstoqueValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEstoqueValor.Visible = false;
            // 
            // buttonAddStatus
            // 
            this.buttonAddStatus.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddStatus.Enabled = false;
            this.buttonAddStatus.FlatAppearance.BorderSize = 0;
            this.buttonAddStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStatus.Location = new System.Drawing.Point(64, 176);
            this.buttonAddStatus.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddStatus.Name = "buttonAddStatus";
            this.buttonAddStatus.Size = new System.Drawing.Size(20, 20);
            this.buttonAddStatus.TabIndex = 22;
            this.buttonAddStatus.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarStatus
            // 
            this.buttonBuscarStatus.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscarStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarStatus.Enabled = false;
            this.buttonBuscarStatus.FlatAppearance.BorderSize = 0;
            this.buttonBuscarStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarStatus.Location = new System.Drawing.Point(42, 176);
            this.buttonBuscarStatus.Name = "buttonBuscarStatus";
            this.buttonBuscarStatus.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarStatus.TabIndex = 21;
            this.buttonBuscarStatus.UseVisualStyleBackColor = true;
            this.buttonBuscarStatus.Click += new System.EventHandler(this.buttonBuscarStatus_Click);
            // 
            // buttonAddFornecedor
            // 
            this.buttonAddFornecedor.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddFornecedor.FlatAppearance.BorderSize = 0;
            this.buttonAddFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFornecedor.Location = new System.Drawing.Point(64, 139);
            this.buttonAddFornecedor.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddFornecedor.Name = "buttonAddFornecedor";
            this.buttonAddFornecedor.Size = new System.Drawing.Size(20, 20);
            this.buttonAddFornecedor.TabIndex = 17;
            this.buttonAddFornecedor.UseVisualStyleBackColor = true;
            this.buttonAddFornecedor.Click += new System.EventHandler(this.buttonAddFornecedor_Click);
            // 
            // buttonBuscarFornecedor
            // 
            this.buttonBuscarFornecedor.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarFornecedor.FlatAppearance.BorderSize = 0;
            this.buttonBuscarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarFornecedor.Location = new System.Drawing.Point(42, 139);
            this.buttonBuscarFornecedor.Name = "buttonBuscarFornecedor";
            this.buttonBuscarFornecedor.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarFornecedor.TabIndex = 16;
            this.buttonBuscarFornecedor.UseVisualStyleBackColor = true;
            this.buttonBuscarFornecedor.Click += new System.EventHandler(this.buttonBuscarFornecedor_Click);
            // 
            // buttonAddMarca
            // 
            this.buttonAddMarca.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddMarca.FlatAppearance.BorderSize = 0;
            this.buttonAddMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMarca.Location = new System.Drawing.Point(64, 104);
            this.buttonAddMarca.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddMarca.Name = "buttonAddMarca";
            this.buttonAddMarca.Size = new System.Drawing.Size(20, 20);
            this.buttonAddMarca.TabIndex = 12;
            this.buttonAddMarca.UseVisualStyleBackColor = true;
            this.buttonAddMarca.Click += new System.EventHandler(this.buttonAddMarca_Click);
            // 
            // buttonBuscarMarca
            // 
            this.buttonBuscarMarca.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarMarca.FlatAppearance.BorderSize = 0;
            this.buttonBuscarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarMarca.Location = new System.Drawing.Point(42, 104);
            this.buttonBuscarMarca.Name = "buttonBuscarMarca";
            this.buttonBuscarMarca.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarMarca.TabIndex = 11;
            this.buttonBuscarMarca.UseVisualStyleBackColor = true;
            this.buttonBuscarMarca.Click += new System.EventHandler(this.buttonBuscarMarca_Click);
            // 
            // buttonAddSubCategoria
            // 
            this.buttonAddSubCategoria.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddSubCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddSubCategoria.FlatAppearance.BorderSize = 0;
            this.buttonAddSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSubCategoria.Location = new System.Drawing.Point(64, 68);
            this.buttonAddSubCategoria.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddSubCategoria.Name = "buttonAddSubCategoria";
            this.buttonAddSubCategoria.Size = new System.Drawing.Size(20, 20);
            this.buttonAddSubCategoria.TabIndex = 7;
            this.buttonAddSubCategoria.UseVisualStyleBackColor = true;
            this.buttonAddSubCategoria.Click += new System.EventHandler(this.buttonAddSubCategoria_Click);
            // 
            // buttonBuscarSubCategoria
            // 
            this.buttonBuscarSubCategoria.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscarSubCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarSubCategoria.FlatAppearance.BorderSize = 0;
            this.buttonBuscarSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarSubCategoria.Location = new System.Drawing.Point(42, 68);
            this.buttonBuscarSubCategoria.Name = "buttonBuscarSubCategoria";
            this.buttonBuscarSubCategoria.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarSubCategoria.TabIndex = 6;
            this.buttonBuscarSubCategoria.UseVisualStyleBackColor = true;
            this.buttonBuscarSubCategoria.Click += new System.EventHandler(this.buttonBuscarSubCategoria_Click);
            // 
            // buttonAddCategoria
            // 
            this.buttonAddCategoria.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddCategoria.Enabled = false;
            this.buttonAddCategoria.FlatAppearance.BorderSize = 0;
            this.buttonAddCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCategoria.Location = new System.Drawing.Point(64, 32);
            this.buttonAddCategoria.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddCategoria.Name = "buttonAddCategoria";
            this.buttonAddCategoria.Size = new System.Drawing.Size(20, 20);
            this.buttonAddCategoria.TabIndex = 2;
            this.buttonAddCategoria.UseVisualStyleBackColor = true;
            this.buttonAddCategoria.Click += new System.EventHandler(this.buttonAddCategoria_Click);
            // 
            // buttonBuscarCategoria
            // 
            this.buttonBuscarCategoria.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarCategoria.FlatAppearance.BorderSize = 0;
            this.buttonBuscarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarCategoria.Location = new System.Drawing.Point(42, 32);
            this.buttonBuscarCategoria.Name = "buttonBuscarCategoria";
            this.buttonBuscarCategoria.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarCategoria.TabIndex = 1;
            this.buttonBuscarCategoria.UseVisualStyleBackColor = true;
            this.buttonBuscarCategoria.Click += new System.EventHandler(this.buttonBuscarCategoria_Click);
            // 
            // labelCodKit
            // 
            this.labelCodKit.AutoSize = true;
            this.labelCodKit.Location = new System.Drawing.Point(387, 17);
            this.labelCodKit.Name = "labelCodKit";
            this.labelCodKit.Size = new System.Drawing.Size(122, 13);
            this.labelCodKit.TabIndex = 4;
            this.labelCodKit.Text = "Código do Kit (opcional):";
            // 
            // textBoxCodKit
            // 
            this.textBoxCodKit.Location = new System.Drawing.Point(387, 30);
            this.textBoxCodKit.Name = "textBoxCodKit";
            this.textBoxCodKit.Size = new System.Drawing.Size(139, 20);
            this.textBoxCodKit.TabIndex = 5;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 393);
            this.Controls.Add(this.labelCodKit);
            this.Controls.Add(this.textBoxCodKit);
            this.Controls.Add(this.groupBoxClasse);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.labelCod);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.textBoxQuant);
            this.Controls.Add(this.groupBoxEstoque);
            this.Controls.Add(this.labelAtacado);
            this.Controls.Add(this.textBoxAtacado);
            this.Controls.Add(this.labelBarras);
            this.Controls.Add(this.textBoxBarras);
            this.Controls.Add(this.labelVarejo);
            this.Controls.Add(this.textBoxVarejo);
            this.Controls.Add(this.labelCompra);
            this.Controls.Add(this.textBoxCompra);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.textBoxDescricao);
            this.KeyPreview = true;
            this.Name = "FormProdutos";
            this.Text = "Cadastrar Produtos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProdutos_KeyDown);
            this.groupBoxEstoque.ResumeLayout(false);
            this.groupBoxEstoque.PerformLayout();
            this.groupBoxClasse.ResumeLayout(false);
            this.groupBoxClasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelCompra;
        private System.Windows.Forms.TextBox textBoxCompra;
        private System.Windows.Forms.Label labelVarejo;
        private System.Windows.Forms.TextBox textBoxVarejo;
        private System.Windows.Forms.Label labelBarras;
        private System.Windows.Forms.TextBox textBoxBarras;
        private System.Windows.Forms.Label labelAtacado;
        private System.Windows.Forms.TextBox textBoxAtacado;
        private System.Windows.Forms.GroupBox groupBoxEstoque;
        private System.Windows.Forms.RadioButton radioButtonNao;
        private System.Windows.Forms.RadioButton radioButtonSim;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.TextBox textBoxQuant;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.Label labelValorCategoria;
        private System.Windows.Forms.Label labelGrupo;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.Label labelValorSub;
        private System.Windows.Forms.TextBox textBoxSub;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelValorMarca;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.Label labelValorFornecedor;
        private System.Windows.Forms.TextBox textBoxCodFornecedor;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelValorStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.GroupBox groupBoxClasse;
        private System.Windows.Forms.Button buttonAddCategoria;
        private System.Windows.Forms.Button buttonBuscarCategoria;
        private System.Windows.Forms.Button buttonAddSubCategoria;
        private System.Windows.Forms.Button buttonBuscarSubCategoria;
        private System.Windows.Forms.Button buttonAddMarca;
        private System.Windows.Forms.Button buttonBuscarMarca;
        private System.Windows.Forms.Button buttonAddFornecedor;
        private System.Windows.Forms.Button buttonBuscarFornecedor;
        private System.Windows.Forms.Button buttonAddStatus;
        private System.Windows.Forms.Button buttonBuscarStatus;
        private System.Windows.Forms.Label labelCodKit;
        private System.Windows.Forms.TextBox textBoxCodKit;
        private System.Windows.Forms.Label labelEstoque;
        private System.Windows.Forms.Label labelEstoqueValor;
    }
}
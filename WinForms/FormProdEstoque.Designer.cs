namespace WinForms
{
    partial class FormProdEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdEstoque));
            this.buttonInicializar = new System.Windows.Forms.Button();
            this.buttonProdutoAdd = new System.Windows.Forms.Button();
            this.labelValorUnit = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxQuant = new System.Windows.Forms.TextBox();
            this.labelQuant = new System.Windows.Forms.Label();
            this.buttonProdutoBuscar = new System.Windows.Forms.Button();
            this.textBoxProdutoCod = new System.Windows.Forms.TextBox();
            this.labelProdutoCod = new System.Windows.Forms.Label();
            this.groupBoxPesquisar = new System.Windows.Forms.GroupBox();
            this.radioButtonCod = new System.Windows.Forms.RadioButton();
            this.radioButtonBarras = new System.Windows.Forms.RadioButton();
            this.labelProdutoDescricao = new System.Windows.Forms.Label();
            this.labelProduto = new System.Windows.Forms.Label();
            this.dataGridViewLancarEstoqueDetalhes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelValorData = new System.Windows.Forms.Label();
            this.labelFornecedorDescricao = new System.Windows.Forms.Label();
            this.labelValorCod = new System.Windows.Forms.Label();
            this.labelForncedorNome = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelCod = new System.Windows.Forms.Label();
            this.labelEstoque = new System.Windows.Forms.Label();
            this.labelQuantEstoque = new System.Windows.Forms.Label();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonAddFornecedor = new System.Windows.Forms.Button();
            this.buttonBuscarFornecedor = new System.Windows.Forms.Button();
            this.textBoxFornecedorCod = new System.Windows.Forms.TextBox();
            this.labelFornecedorCod = new System.Windows.Forms.Label();
            this.buttonProdutoInfo = new System.Windows.Forms.Button();
            this.groupBoxItem = new System.Windows.Forms.GroupBox();
            this.labelRemover = new System.Windows.Forms.Label();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.labelValorTotalQuant = new System.Windows.Forms.Label();
            this.labelTotalQuant = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.groupBoxPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLancarEstoqueDetalhes)).BeginInit();
            this.groupBoxItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInicializar
            // 
            this.buttonInicializar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Product_32;
            this.buttonInicializar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonInicializar.Enabled = false;
            this.buttonInicializar.FlatAppearance.BorderSize = 0;
            this.buttonInicializar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicializar.Location = new System.Drawing.Point(872, 22);
            this.buttonInicializar.Name = "buttonInicializar";
            this.buttonInicializar.Size = new System.Drawing.Size(30, 23);
            this.buttonInicializar.TabIndex = 10;
            this.buttonInicializar.UseVisualStyleBackColor = true;
            this.buttonInicializar.Click += new System.EventHandler(this.buttonInicializar_Click);
            // 
            // buttonProdutoAdd
            // 
            this.buttonProdutoAdd.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonProdutoAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProdutoAdd.FlatAppearance.BorderSize = 0;
            this.buttonProdutoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProdutoAdd.Location = new System.Drawing.Point(208, 29);
            this.buttonProdutoAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonProdutoAdd.Name = "buttonProdutoAdd";
            this.buttonProdutoAdd.Size = new System.Drawing.Size(20, 20);
            this.buttonProdutoAdd.TabIndex = 4;
            this.buttonProdutoAdd.UseVisualStyleBackColor = true;
            this.buttonProdutoAdd.Click += new System.EventHandler(this.buttonProdutoAdd_Click);
            // 
            // labelValorUnit
            // 
            this.labelValorUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorUnit.Location = new System.Drawing.Point(707, 30);
            this.labelValorUnit.Name = "labelValorUnit";
            this.labelValorUnit.Size = new System.Drawing.Size(83, 20);
            this.labelValorUnit.TabIndex = 11;
            this.labelValorUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(707, 17);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(79, 13);
            this.labelUnit.TabIndex = 10;
            this.labelUnit.Text = "Vlr. de Compra:";
            // 
            // textBoxQuant
            // 
            this.textBoxQuant.Location = new System.Drawing.Point(642, 30);
            this.textBoxQuant.Name = "textBoxQuant";
            this.textBoxQuant.Size = new System.Drawing.Size(59, 20);
            this.textBoxQuant.TabIndex = 9;
            this.textBoxQuant.Text = "1,000";
            this.textBoxQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxQuant.TextChanged += new System.EventHandler(this.textBoxQuant_TextChanged);
            // 
            // labelQuant
            // 
            this.labelQuant.AutoSize = true;
            this.labelQuant.Location = new System.Drawing.Point(642, 17);
            this.labelQuant.Name = "labelQuant";
            this.labelQuant.Size = new System.Drawing.Size(39, 13);
            this.labelQuant.TabIndex = 8;
            this.labelQuant.Text = "Quant:";
            // 
            // buttonProdutoBuscar
            // 
            this.buttonProdutoBuscar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonProdutoBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProdutoBuscar.FlatAppearance.BorderSize = 0;
            this.buttonProdutoBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProdutoBuscar.Location = new System.Drawing.Point(188, 29);
            this.buttonProdutoBuscar.Name = "buttonProdutoBuscar";
            this.buttonProdutoBuscar.Size = new System.Drawing.Size(20, 20);
            this.buttonProdutoBuscar.TabIndex = 3;
            this.buttonProdutoBuscar.UseVisualStyleBackColor = true;
            this.buttonProdutoBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxProdutoCod
            // 
            this.textBoxProdutoCod.Location = new System.Drawing.Point(147, 29);
            this.textBoxProdutoCod.Name = "textBoxProdutoCod";
            this.textBoxProdutoCod.Size = new System.Drawing.Size(35, 20);
            this.textBoxProdutoCod.TabIndex = 2;
            this.textBoxProdutoCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxProdutoCod.TextChanged += new System.EventHandler(this.textBoxProdutoCod_TextChanged);
            // 
            // labelProdutoCod
            // 
            this.labelProdutoCod.AutoSize = true;
            this.labelProdutoCod.Location = new System.Drawing.Point(147, 15);
            this.labelProdutoCod.Name = "labelProdutoCod";
            this.labelProdutoCod.Size = new System.Drawing.Size(29, 13);
            this.labelProdutoCod.TabIndex = 1;
            this.labelProdutoCod.Text = "Cód:";
            // 
            // groupBoxPesquisar
            // 
            this.groupBoxPesquisar.Controls.Add(this.radioButtonCod);
            this.groupBoxPesquisar.Controls.Add(this.radioButtonBarras);
            this.groupBoxPesquisar.Location = new System.Drawing.Point(6, 20);
            this.groupBoxPesquisar.Name = "groupBoxPesquisar";
            this.groupBoxPesquisar.Size = new System.Drawing.Size(134, 33);
            this.groupBoxPesquisar.TabIndex = 0;
            this.groupBoxPesquisar.TabStop = false;
            this.groupBoxPesquisar.Text = "Pesquisar Por:";
            // 
            // radioButtonCod
            // 
            this.radioButtonCod.AutoSize = true;
            this.radioButtonCod.Checked = true;
            this.radioButtonCod.Location = new System.Drawing.Point(67, 13);
            this.radioButtonCod.Name = "radioButtonCod";
            this.radioButtonCod.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCod.TabIndex = 1;
            this.radioButtonCod.TabStop = true;
            this.radioButtonCod.Text = "&Código";
            this.radioButtonCod.UseVisualStyleBackColor = true;
            this.radioButtonCod.CheckedChanged += new System.EventHandler(this.radioButtonCod_CheckedChanged);
            // 
            // radioButtonBarras
            // 
            this.radioButtonBarras.AutoSize = true;
            this.radioButtonBarras.Location = new System.Drawing.Point(6, 13);
            this.radioButtonBarras.Name = "radioButtonBarras";
            this.radioButtonBarras.Size = new System.Drawing.Size(55, 17);
            this.radioButtonBarras.TabIndex = 0;
            this.radioButtonBarras.Text = "&Barras";
            this.radioButtonBarras.UseVisualStyleBackColor = true;
            // 
            // labelProdutoDescricao
            // 
            this.labelProdutoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProdutoDescricao.Location = new System.Drawing.Point(231, 30);
            this.labelProdutoDescricao.Name = "labelProdutoDescricao";
            this.labelProdutoDescricao.Size = new System.Drawing.Size(379, 20);
            this.labelProdutoDescricao.TabIndex = 6;
            this.labelProdutoDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Location = new System.Drawing.Point(231, 17);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(44, 13);
            this.labelProduto.TabIndex = 5;
            this.labelProduto.Text = "Produto";
            // 
            // dataGridViewLancarEstoqueDetalhes
            // 
            this.dataGridViewLancarEstoqueDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLancarEstoqueDetalhes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colProdDescricao,
            this.colQuant,
            this.colUnitario,
            this.colTotal});
            this.dataGridViewLancarEstoqueDetalhes.Location = new System.Drawing.Point(6, 59);
            this.dataGridViewLancarEstoqueDetalhes.Name = "dataGridViewLancarEstoqueDetalhes";
            this.dataGridViewLancarEstoqueDetalhes.RowHeadersWidth = 20;
            this.dataGridViewLancarEstoqueDetalhes.Size = new System.Drawing.Size(878, 145);
            this.dataGridViewLancarEstoqueDetalhes.TabIndex = 15;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "idproduto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "0000";
            dataGridViewCellStyle1.NullValue = null;
            this.colId.DefaultCellStyle = dataGridViewCellStyle1;
            this.colId.HeaderText = "Cod.:";
            this.colId.Name = "colId";
            this.colId.Width = 65;
            // 
            // colProdDescricao
            // 
            this.colProdDescricao.DataPropertyName = "descricao";
            this.colProdDescricao.HeaderText = "Produto:";
            this.colProdDescricao.Name = "colProdDescricao";
            this.colProdDescricao.Width = 560;
            // 
            // colQuant
            // 
            this.colQuant.DataPropertyName = "quant";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "0.000";
            dataGridViewCellStyle2.NullValue = null;
            this.colQuant.DefaultCellStyle = dataGridViewCellStyle2;
            this.colQuant.HeaderText = "Quant:";
            this.colQuant.Name = "colQuant";
            this.colQuant.Width = 60;
            // 
            // colUnitario
            // 
            this.colUnitario.DataPropertyName = "valorUnit";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.colUnitario.DefaultCellStyle = dataGridViewCellStyle3;
            this.colUnitario.HeaderText = "Valor unit.:";
            this.colUnitario.Name = "colUnitario";
            this.colUnitario.Width = 75;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "valorTotal";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTotal.HeaderText = "Valor total:";
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 80;
            // 
            // labelValorData
            // 
            this.labelValorData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorData.Location = new System.Drawing.Point(86, 23);
            this.labelValorData.Name = "labelValorData";
            this.labelValorData.Size = new System.Drawing.Size(225, 20);
            this.labelValorData.TabIndex = 3;
            this.labelValorData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFornecedorDescricao
            // 
            this.labelFornecedorDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFornecedorDescricao.Location = new System.Drawing.Point(396, 23);
            this.labelFornecedorDescricao.Name = "labelFornecedorDescricao";
            this.labelFornecedorDescricao.Size = new System.Drawing.Size(470, 20);
            this.labelFornecedorDescricao.TabIndex = 9;
            this.labelFornecedorDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelValorCod
            // 
            this.labelValorCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorCod.Location = new System.Drawing.Point(12, 23);
            this.labelValorCod.Name = "labelValorCod";
            this.labelValorCod.Size = new System.Drawing.Size(68, 20);
            this.labelValorCod.TabIndex = 1;
            this.labelValorCod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelForncedorNome
            // 
            this.labelForncedorNome.AutoSize = true;
            this.labelForncedorNome.Location = new System.Drawing.Point(396, 9);
            this.labelForncedorNome.Name = "labelForncedorNome";
            this.labelForncedorNome.Size = new System.Drawing.Size(64, 13);
            this.labelForncedorNome.TabIndex = 8;
            this.labelForncedorNome.Text = "Fornecedor:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(86, 9);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Data:";
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(12, 9);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(43, 13);
            this.labelCod.TabIndex = 0;
            this.labelCod.Text = "Código:";
            // 
            // labelEstoque
            // 
            this.labelEstoque.AutoSize = true;
            this.labelEstoque.Location = new System.Drawing.Point(796, 17);
            this.labelEstoque.Name = "labelEstoque";
            this.labelEstoque.Size = new System.Drawing.Size(66, 13);
            this.labelEstoque.TabIndex = 12;
            this.labelEstoque.Text = "Qt. Estoque:";
            // 
            // labelQuantEstoque
            // 
            this.labelQuantEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelQuantEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuantEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelQuantEstoque.Location = new System.Drawing.Point(796, 30);
            this.labelQuantEstoque.Name = "labelQuantEstoque";
            this.labelQuantEstoque.Size = new System.Drawing.Size(62, 20);
            this.labelQuantEstoque.TabIndex = 13;
            this.labelQuantEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddItem.Enabled = false;
            this.buttonAddItem.FlatAppearance.BorderSize = 0;
            this.buttonAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddItem.Location = new System.Drawing.Point(864, 30);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(20, 20);
            this.buttonAddItem.TabIndex = 14;
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonAddFornecedor
            // 
            this.buttonAddFornecedor.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddFornecedor.FlatAppearance.BorderSize = 0;
            this.buttonAddFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFornecedor.Location = new System.Drawing.Point(373, 23);
            this.buttonAddFornecedor.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddFornecedor.Name = "buttonAddFornecedor";
            this.buttonAddFornecedor.Size = new System.Drawing.Size(20, 20);
            this.buttonAddFornecedor.TabIndex = 7;
            this.buttonAddFornecedor.UseVisualStyleBackColor = true;
            this.buttonAddFornecedor.Click += new System.EventHandler(this.buttonAddFornecedor_Click);
            // 
            // buttonBuscarFornecedor
            // 
            this.buttonBuscarFornecedor.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarFornecedor.FlatAppearance.BorderSize = 0;
            this.buttonBuscarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarFornecedor.Location = new System.Drawing.Point(353, 23);
            this.buttonBuscarFornecedor.Name = "buttonBuscarFornecedor";
            this.buttonBuscarFornecedor.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarFornecedor.TabIndex = 6;
            this.buttonBuscarFornecedor.UseVisualStyleBackColor = true;
            this.buttonBuscarFornecedor.Click += new System.EventHandler(this.buttonBuscarFornecedor_Click);
            // 
            // textBoxFornecedorCod
            // 
            this.textBoxFornecedorCod.Location = new System.Drawing.Point(317, 23);
            this.textBoxFornecedorCod.Name = "textBoxFornecedorCod";
            this.textBoxFornecedorCod.Size = new System.Drawing.Size(30, 20);
            this.textBoxFornecedorCod.TabIndex = 5;
            this.textBoxFornecedorCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFornecedorCod.TextChanged += new System.EventHandler(this.textBoxFornecedorCod_TextChanged);
            this.textBoxFornecedorCod.Leave += new System.EventHandler(this.textBoxFornecedorCod_Leave);
            // 
            // labelFornecedorCod
            // 
            this.labelFornecedorCod.AutoSize = true;
            this.labelFornecedorCod.Location = new System.Drawing.Point(317, 9);
            this.labelFornecedorCod.Name = "labelFornecedorCod";
            this.labelFornecedorCod.Size = new System.Drawing.Size(29, 13);
            this.labelFornecedorCod.TabIndex = 4;
            this.labelFornecedorCod.Text = "Có&d:";
            // 
            // buttonProdutoInfo
            // 
            this.buttonProdutoInfo.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonProdutoInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProdutoInfo.Enabled = false;
            this.buttonProdutoInfo.FlatAppearance.BorderSize = 0;
            this.buttonProdutoInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProdutoInfo.Location = new System.Drawing.Point(616, 30);
            this.buttonProdutoInfo.Name = "buttonProdutoInfo";
            this.buttonProdutoInfo.Size = new System.Drawing.Size(20, 20);
            this.buttonProdutoInfo.TabIndex = 7;
            this.buttonProdutoInfo.UseVisualStyleBackColor = true;
            this.buttonProdutoInfo.Click += new System.EventHandler(this.buttonProdutoInfo_Click);
            // 
            // groupBoxItem
            // 
            this.groupBoxItem.Controls.Add(this.labelRemover);
            this.groupBoxItem.Controls.Add(this.buttonRemover);
            this.groupBoxItem.Controls.Add(this.labelValorTotalQuant);
            this.groupBoxItem.Controls.Add(this.labelTotalQuant);
            this.groupBoxItem.Controls.Add(this.labelValorTotal);
            this.groupBoxItem.Controls.Add(this.labelTotal);
            this.groupBoxItem.Controls.Add(this.groupBoxPesquisar);
            this.groupBoxItem.Controls.Add(this.buttonProdutoInfo);
            this.groupBoxItem.Controls.Add(this.dataGridViewLancarEstoqueDetalhes);
            this.groupBoxItem.Controls.Add(this.labelProduto);
            this.groupBoxItem.Controls.Add(this.labelProdutoDescricao);
            this.groupBoxItem.Controls.Add(this.labelProdutoCod);
            this.groupBoxItem.Controls.Add(this.textBoxProdutoCod);
            this.groupBoxItem.Controls.Add(this.buttonProdutoBuscar);
            this.groupBoxItem.Controls.Add(this.labelQuant);
            this.groupBoxItem.Controls.Add(this.textBoxQuant);
            this.groupBoxItem.Controls.Add(this.buttonProdutoAdd);
            this.groupBoxItem.Controls.Add(this.labelUnit);
            this.groupBoxItem.Controls.Add(this.buttonAddItem);
            this.groupBoxItem.Controls.Add(this.labelValorUnit);
            this.groupBoxItem.Controls.Add(this.labelQuantEstoque);
            this.groupBoxItem.Controls.Add(this.labelEstoque);
            this.groupBoxItem.Enabled = false;
            this.groupBoxItem.Location = new System.Drawing.Point(12, 46);
            this.groupBoxItem.Name = "groupBoxItem";
            this.groupBoxItem.Size = new System.Drawing.Size(893, 251);
            this.groupBoxItem.TabIndex = 11;
            this.groupBoxItem.TabStop = false;
            this.groupBoxItem.Text = "Lançar Produto no Estoque:";
            // 
            // labelRemover
            // 
            this.labelRemover.AutoSize = true;
            this.labelRemover.Location = new System.Drawing.Point(26, 214);
            this.labelRemover.Name = "labelRemover";
            this.labelRemover.Size = new System.Drawing.Size(73, 13);
            this.labelRemover.TabIndex = 17;
            this.labelRemover.Text = "Remover Item";
            // 
            // buttonRemover
            // 
            this.buttonRemover.BackgroundImage = global::WinForms.Properties.Resources.icons8_Trash_Can_32;
            this.buttonRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRemover.Enabled = false;
            this.buttonRemover.FlatAppearance.BorderSize = 0;
            this.buttonRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemover.Location = new System.Drawing.Point(6, 210);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(20, 20);
            this.buttonRemover.TabIndex = 16;
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // labelValorTotalQuant
            // 
            this.labelValorTotalQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorTotalQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotalQuant.ForeColor = System.Drawing.Color.Maroon;
            this.labelValorTotalQuant.Location = new System.Drawing.Point(710, 221);
            this.labelValorTotalQuant.Name = "labelValorTotalQuant";
            this.labelValorTotalQuant.Size = new System.Drawing.Size(49, 20);
            this.labelValorTotalQuant.TabIndex = 19;
            this.labelValorTotalQuant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalQuant
            // 
            this.labelTotalQuant.AutoSize = true;
            this.labelTotalQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalQuant.Location = new System.Drawing.Point(710, 207);
            this.labelTotalQuant.Name = "labelTotalQuant";
            this.labelTotalQuant.Size = new System.Drawing.Size(49, 13);
            this.labelTotalQuant.TabIndex = 18;
            this.labelTotalQuant.Text = "Quant.:";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotal.ForeColor = System.Drawing.Color.Maroon;
            this.labelValorTotal.Location = new System.Drawing.Point(765, 221);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(119, 20);
            this.labelValorTotal.TabIndex = 21;
            this.labelValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(765, 207);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(73, 13);
            this.labelTotal.TabIndex = 20;
            this.labelTotal.Text = "Valor Total:";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfirmar.Image")));
            this.buttonConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonConfirmar.Location = new System.Drawing.Point(728, 303);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(85, 40);
            this.buttonConfirmar.TabIndex = 12;
            this.buttonConfirmar.Text = "&Salvar";
            this.buttonConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = ((System.Drawing.Image)(resources.GetObject("buttonFechar.Image")));
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(820, 303);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 13;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormProdEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 352);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.groupBoxItem);
            this.Controls.Add(this.buttonAddFornecedor);
            this.Controls.Add(this.buttonBuscarFornecedor);
            this.Controls.Add(this.textBoxFornecedorCod);
            this.Controls.Add(this.labelFornecedorCod);
            this.Controls.Add(this.buttonInicializar);
            this.Controls.Add(this.labelValorData);
            this.Controls.Add(this.labelFornecedorDescricao);
            this.Controls.Add(this.labelValorCod);
            this.Controls.Add(this.labelForncedorNome);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelCod);
            this.KeyPreview = true;
            this.Name = "FormProdEstoque";
            this.Text = "Lançar Estoque";
            this.Load += new System.EventHandler(this.FormProdEstoque_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProdEstoque_KeyDown);
            this.groupBoxPesquisar.ResumeLayout(false);
            this.groupBoxPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLancarEstoqueDetalhes)).EndInit();
            this.groupBoxItem.ResumeLayout(false);
            this.groupBoxItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInicializar;
        private System.Windows.Forms.Button buttonProdutoAdd;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Label labelValorUnit;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.TextBox textBoxQuant;
        private System.Windows.Forms.Label labelQuant;
        private System.Windows.Forms.Button buttonProdutoBuscar;
        private System.Windows.Forms.TextBox textBoxProdutoCod;
        private System.Windows.Forms.Label labelProdutoCod;
        private System.Windows.Forms.GroupBox groupBoxPesquisar;
        private System.Windows.Forms.RadioButton radioButtonCod;
        private System.Windows.Forms.RadioButton radioButtonBarras;
        private System.Windows.Forms.Label labelProdutoDescricao;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.DataGridView dataGridViewLancarEstoqueDetalhes;
        private System.Windows.Forms.Label labelValorData;
        private System.Windows.Forms.Label labelFornecedorDescricao;
        private System.Windows.Forms.Label labelValorCod;
        private System.Windows.Forms.Label labelForncedorNome;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.Label labelEstoque;
        private System.Windows.Forms.Label labelQuantEstoque;
        private System.Windows.Forms.Button buttonAddFornecedor;
        private System.Windows.Forms.Button buttonBuscarFornecedor;
        private System.Windows.Forms.TextBox textBoxFornecedorCod;
        private System.Windows.Forms.Label labelFornecedorCod;
        private System.Windows.Forms.Button buttonProdutoInfo;
        private System.Windows.Forms.GroupBox groupBoxItem;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Label labelRemover;
        private System.Windows.Forms.Label labelValorTotalQuant;
        private System.Windows.Forms.Label labelTotalQuant;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}
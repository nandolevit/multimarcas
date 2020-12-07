namespace WinForms
{
    partial class FormEstoqueContagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstoqueContagem));
            this.labelRemover = new System.Windows.Forms.Label();
            this.groupBoxItem = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelValorTotalQuant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonProdutoConsultar = new System.Windows.Forms.Button();
            this.groupBoxPesquisar = new System.Windows.Forms.GroupBox();
            this.radioButtonCod = new System.Windows.Forms.RadioButton();
            this.radioButtonBarras = new System.Windows.Forms.RadioButton();
            this.dataGridViewLancarEstoqueDetalhes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelProduto = new System.Windows.Forms.Label();
            this.labelProdutoDescricao = new System.Windows.Forms.Label();
            this.labelProdutoCod = new System.Windows.Forms.Label();
            this.textBoxProdutoCod = new System.Windows.Forms.TextBox();
            this.buttonProdutoBuscar = new System.Windows.Forms.Button();
            this.labelQuant = new System.Windows.Forms.Label();
            this.textBoxQuant = new System.Windows.Forms.TextBox();
            this.buttonProdutoAdd = new System.Windows.Forms.Button();
            this.labelUnit = new System.Windows.Forms.Label();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.labelValorUnit = new System.Windows.Forms.Label();
            this.labelQuantEstoque = new System.Windows.Forms.Label();
            this.labelEstoque = new System.Windows.Forms.Label();
            this.labelValorData = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelCod = new System.Windows.Forms.Label();
            this.textBoxValorCod = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonInicializar = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBoxItem.SuspendLayout();
            this.groupBoxPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLancarEstoqueDetalhes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRemover
            // 
            this.labelRemover.AutoSize = true;
            this.labelRemover.Location = new System.Drawing.Point(26, 348);
            this.labelRemover.Name = "labelRemover";
            this.labelRemover.Size = new System.Drawing.Size(73, 13);
            this.labelRemover.TabIndex = 17;
            this.labelRemover.Text = "Remover Item";
            // 
            // groupBoxItem
            // 
            this.groupBoxItem.Controls.Add(this.label3);
            this.groupBoxItem.Controls.Add(this.labelValorTotalQuant);
            this.groupBoxItem.Controls.Add(this.label1);
            this.groupBoxItem.Controls.Add(this.labelValorTotal);
            this.groupBoxItem.Controls.Add(this.labelRemover);
            this.groupBoxItem.Controls.Add(this.buttonRemover);
            this.groupBoxItem.Controls.Add(this.buttonProdutoConsultar);
            this.groupBoxItem.Controls.Add(this.groupBoxPesquisar);
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
            this.groupBoxItem.Location = new System.Drawing.Point(12, 73);
            this.groupBoxItem.Name = "groupBoxItem";
            this.groupBoxItem.Size = new System.Drawing.Size(1195, 377);
            this.groupBoxItem.TabIndex = 5;
            this.groupBoxItem.TabStop = false;
            this.groupBoxItem.Text = "Lançar Produto no Estoque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1012, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Quant.";
            // 
            // labelValorTotalQuant
            // 
            this.labelValorTotalQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorTotalQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotalQuant.ForeColor = System.Drawing.Color.Maroon;
            this.labelValorTotalQuant.Location = new System.Drawing.Point(1012, 344);
            this.labelValorTotalQuant.Name = "labelValorTotalQuant";
            this.labelValorTotalQuant.Size = new System.Drawing.Size(49, 20);
            this.labelValorTotalQuant.TabIndex = 19;
            this.labelValorTotalQuant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1070, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Valor Total:";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotal.ForeColor = System.Drawing.Color.Maroon;
            this.labelValorTotal.Location = new System.Drawing.Point(1070, 344);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(119, 20);
            this.labelValorTotal.TabIndex = 21;
            this.labelValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRemover
            // 
            this.buttonRemover.BackgroundImage = global::WinForms.Properties.Resources.exit_red;
            this.buttonRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRemover.Enabled = false;
            this.buttonRemover.FlatAppearance.BorderSize = 0;
            this.buttonRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemover.Location = new System.Drawing.Point(6, 344);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(20, 20);
            this.buttonRemover.TabIndex = 16;
            this.buttonRemover.UseVisualStyleBackColor = true;
            // 
            // buttonProdutoConsultar
            // 
            this.buttonProdutoConsultar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonProdutoConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProdutoConsultar.FlatAppearance.BorderSize = 0;
            this.buttonProdutoConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProdutoConsultar.Location = new System.Drawing.Point(422, 32);
            this.buttonProdutoConsultar.Name = "buttonProdutoConsultar";
            this.buttonProdutoConsultar.Size = new System.Drawing.Size(20, 20);
            this.buttonProdutoConsultar.TabIndex = 7;
            this.buttonProdutoConsultar.UseVisualStyleBackColor = true;
            this.buttonProdutoConsultar.Click += new System.EventHandler(this.buttonProdutoConsultar_Click);
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
            this.radioButtonCod.Location = new System.Drawing.Point(67, 13);
            this.radioButtonCod.Name = "radioButtonCod";
            this.radioButtonCod.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCod.TabIndex = 1;
            this.radioButtonCod.Text = "&Código";
            this.radioButtonCod.UseVisualStyleBackColor = true;
            // 
            // radioButtonBarras
            // 
            this.radioButtonBarras.AutoSize = true;
            this.radioButtonBarras.Checked = true;
            this.radioButtonBarras.Location = new System.Drawing.Point(6, 13);
            this.radioButtonBarras.Name = "radioButtonBarras";
            this.radioButtonBarras.Size = new System.Drawing.Size(55, 17);
            this.radioButtonBarras.TabIndex = 0;
            this.radioButtonBarras.TabStop = true;
            this.radioButtonBarras.Text = "&Barras";
            this.radioButtonBarras.UseVisualStyleBackColor = true;
            this.radioButtonBarras.CheckedChanged += new System.EventHandler(this.radioButtonBarras_CheckedChanged);
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
            this.dataGridViewLancarEstoqueDetalhes.Size = new System.Drawing.Size(1183, 268);
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
            this.colId.Width = 50;
            // 
            // colProdDescricao
            // 
            this.colProdDescricao.DataPropertyName = "descricao";
            this.colProdDescricao.HeaderText = "Produto:";
            this.colProdDescricao.Name = "colProdDescricao";
            this.colProdDescricao.Width = 850;
            // 
            // colQuant
            // 
            this.colQuant.DataPropertyName = "quant";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "00";
            dataGridViewCellStyle2.NullValue = null;
            this.colQuant.DefaultCellStyle = dataGridViewCellStyle2;
            this.colQuant.HeaderText = "Quant:";
            this.colQuant.Name = "colQuant";
            this.colQuant.Width = 41;
            // 
            // colUnitario
            // 
            this.colUnitario.DataPropertyName = "valorUnit";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.colUnitario.DefaultCellStyle = dataGridViewCellStyle3;
            this.colUnitario.HeaderText = "Valor unit.:";
            this.colUnitario.Name = "colUnitario";
            this.colUnitario.Width = 80;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "valorTotal";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTotal.HeaderText = "Valor total:";
            this.colTotal.Name = "colTotal";
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Location = new System.Drawing.Point(448, 18);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(44, 13);
            this.labelProduto.TabIndex = 8;
            this.labelProduto.Text = "Produto";
            // 
            // labelProdutoDescricao
            // 
            this.labelProdutoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProdutoDescricao.Location = new System.Drawing.Point(448, 32);
            this.labelProdutoDescricao.Name = "labelProdutoDescricao";
            this.labelProdutoDescricao.Size = new System.Drawing.Size(558, 20);
            this.labelProdutoDescricao.TabIndex = 9;
            this.labelProdutoDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProdutoCod
            // 
            this.labelProdutoCod.AutoSize = true;
            this.labelProdutoCod.Location = new System.Drawing.Point(189, 18);
            this.labelProdutoCod.Name = "labelProdutoCod";
            this.labelProdutoCod.Size = new System.Drawing.Size(29, 13);
            this.labelProdutoCod.TabIndex = 3;
            this.labelProdutoCod.Text = "Cód:";
            // 
            // textBoxProdutoCod
            // 
            this.textBoxProdutoCod.Location = new System.Drawing.Point(189, 32);
            this.textBoxProdutoCod.Name = "textBoxProdutoCod";
            this.textBoxProdutoCod.Size = new System.Drawing.Size(165, 20);
            this.textBoxProdutoCod.TabIndex = 4;
            this.textBoxProdutoCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxProdutoCod.Leave += new System.EventHandler(this.textBoxProdutoCod_Leave);
            // 
            // buttonProdutoBuscar
            // 
            this.buttonProdutoBuscar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonProdutoBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProdutoBuscar.FlatAppearance.BorderSize = 0;
            this.buttonProdutoBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProdutoBuscar.Location = new System.Drawing.Point(146, 32);
            this.buttonProdutoBuscar.Name = "buttonProdutoBuscar";
            this.buttonProdutoBuscar.Size = new System.Drawing.Size(20, 20);
            this.buttonProdutoBuscar.TabIndex = 1;
            this.buttonProdutoBuscar.UseVisualStyleBackColor = true;
            this.buttonProdutoBuscar.Click += new System.EventHandler(this.buttonProdutoBuscar_Click);
            // 
            // labelQuant
            // 
            this.labelQuant.AutoSize = true;
            this.labelQuant.Location = new System.Drawing.Point(360, 18);
            this.labelQuant.Name = "labelQuant";
            this.labelQuant.Size = new System.Drawing.Size(39, 13);
            this.labelQuant.TabIndex = 5;
            this.labelQuant.Text = "Quant:";
            // 
            // textBoxQuant
            // 
            this.textBoxQuant.Location = new System.Drawing.Point(360, 32);
            this.textBoxQuant.Name = "textBoxQuant";
            this.textBoxQuant.Size = new System.Drawing.Size(56, 20);
            this.textBoxQuant.TabIndex = 6;
            this.textBoxQuant.Text = "1";
            this.textBoxQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonProdutoAdd
            // 
            this.buttonProdutoAdd.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonProdutoAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProdutoAdd.FlatAppearance.BorderSize = 0;
            this.buttonProdutoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProdutoAdd.Location = new System.Drawing.Point(166, 32);
            this.buttonProdutoAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonProdutoAdd.Name = "buttonProdutoAdd";
            this.buttonProdutoAdd.Size = new System.Drawing.Size(20, 20);
            this.buttonProdutoAdd.TabIndex = 2;
            this.buttonProdutoAdd.UseVisualStyleBackColor = true;
            this.buttonProdutoAdd.Click += new System.EventHandler(this.buttonProdutoAdd_Click);
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(1012, 18);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(64, 13);
            this.labelUnit.TabIndex = 10;
            this.labelUnit.Text = "Vlr. Compra:";
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddItem.Enabled = false;
            this.buttonAddItem.FlatAppearance.BorderSize = 0;
            this.buttonAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddItem.Location = new System.Drawing.Point(1168, 32);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(20, 20);
            this.buttonAddItem.TabIndex = 14;
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // labelValorUnit
            // 
            this.labelValorUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorUnit.Location = new System.Drawing.Point(1012, 32);
            this.labelValorUnit.Name = "labelValorUnit";
            this.labelValorUnit.Size = new System.Drawing.Size(83, 20);
            this.labelValorUnit.TabIndex = 11;
            this.labelValorUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQuantEstoque
            // 
            this.labelQuantEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelQuantEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuantEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelQuantEstoque.Location = new System.Drawing.Point(1101, 32);
            this.labelQuantEstoque.Name = "labelQuantEstoque";
            this.labelQuantEstoque.Size = new System.Drawing.Size(62, 20);
            this.labelQuantEstoque.TabIndex = 13;
            this.labelQuantEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEstoque
            // 
            this.labelEstoque.AutoSize = true;
            this.labelEstoque.Location = new System.Drawing.Point(1101, 18);
            this.labelEstoque.Name = "labelEstoque";
            this.labelEstoque.Size = new System.Drawing.Size(66, 13);
            this.labelEstoque.TabIndex = 12;
            this.labelEstoque.Text = "Qt. Estoque:";
            // 
            // labelValorData
            // 
            this.labelValorData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorData.Location = new System.Drawing.Point(86, 50);
            this.labelValorData.Name = "labelValorData";
            this.labelValorData.Size = new System.Drawing.Size(225, 20);
            this.labelValorData.TabIndex = 3;
            this.labelValorData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(86, 36);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Data:";
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(12, 36);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(43, 13);
            this.labelCod.TabIndex = 0;
            this.labelCod.Text = "Código:";
            // 
            // textBoxValorCod
            // 
            this.textBoxValorCod.Location = new System.Drawing.Point(15, 50);
            this.textBoxValorCod.Name = "textBoxValorCod";
            this.textBoxValorCod.Size = new System.Drawing.Size(68, 20);
            this.textBoxValorCod.TabIndex = 1;
            this.textBoxValorCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonConfirmar.Location = new System.Drawing.Point(1024, 454);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(91, 40);
            this.buttonConfirmar.TabIndex = 6;
            this.buttonConfirmar.Text = "&Concluir";
            this.buttonConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(1122, 454);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 7;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonInicializar
            // 
            this.buttonInicializar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Product_32;
            this.buttonInicializar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInicializar.FlatAppearance.BorderSize = 0;
            this.buttonInicializar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicializar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInicializar.Location = new System.Drawing.Point(317, 49);
            this.buttonInicializar.Name = "buttonInicializar";
            this.buttonInicializar.Size = new System.Drawing.Size(30, 23);
            this.buttonInicializar.TabIndex = 4;
            this.buttonInicializar.UseVisualStyleBackColor = true;
            this.buttonInicializar.Click += new System.EventHandler(this.buttonInicializar_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Maroon;
            this.labelTitle.Location = new System.Drawing.Point(12, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1195, 36);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(384, 47);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(599, 23);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Visible = false;
            // 
            // FormEstoqueContagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 505);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxValorCod);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.groupBoxItem);
            this.Controls.Add(this.buttonInicializar);
            this.Controls.Add(this.labelValorData);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelCod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormEstoqueContagem";
            this.Text = "Contagem do Estoque";
            this.Load += new System.EventHandler(this.FormEstoqueContagem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEstoqueContagem_KeyDown);
            this.groupBoxItem.ResumeLayout(false);
            this.groupBoxItem.PerformLayout();
            this.groupBoxPesquisar.ResumeLayout(false);
            this.groupBoxPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLancarEstoqueDetalhes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRemover;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.GroupBox groupBoxItem;
        private System.Windows.Forms.GroupBox groupBoxPesquisar;
        private System.Windows.Forms.RadioButton radioButtonCod;
        private System.Windows.Forms.RadioButton radioButtonBarras;
        private System.Windows.Forms.DataGridView dataGridViewLancarEstoqueDetalhes;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.Label labelProdutoDescricao;
        private System.Windows.Forms.Label labelProdutoCod;
        private System.Windows.Forms.TextBox textBoxProdutoCod;
        private System.Windows.Forms.Button buttonProdutoBuscar;
        private System.Windows.Forms.Label labelQuant;
        private System.Windows.Forms.TextBox textBoxQuant;
        private System.Windows.Forms.Button buttonProdutoAdd;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonInicializar;
        private System.Windows.Forms.Label labelValorData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.Button buttonProdutoConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelValorTotalQuant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label labelValorUnit;
        private System.Windows.Forms.Label labelQuantEstoque;
        private System.Windows.Forms.Label labelEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.TextBox textBoxValorCod;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
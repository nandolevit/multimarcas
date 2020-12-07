namespace WinForms
{
    partial class FormPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelRemover = new System.Windows.Forms.Label();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.groupBoxItem = new System.Windows.Forms.GroupBox();
            this.labelItensDescricao = new System.Windows.Forms.Label();
            this.labelItens = new System.Windows.Forms.Label();
            this.labelTotalDescricao = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonDesconto = new System.Windows.Forms.Button();
            this.labelDesconto = new System.Windows.Forms.Label();
            this.labelValorDesc = new System.Windows.Forms.Label();
            this.buttonProdutoInfo = new System.Windows.Forms.Button();
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.buttonClienteBuscar = new System.Windows.Forms.Button();
            this.textBoxOsCod = new System.Windows.Forms.TextBox();
            this.labelOs = new System.Windows.Forms.Label();
            this.labelClienteNome = new System.Windows.Forms.Label();
            this.labelProdEletroDescricao = new System.Windows.Forms.Label();
            this.labelPedidoCod = new System.Windows.Forms.Label();
            this.labelEletro = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelCod = new System.Windows.Forms.Label();
            this.buttonEletroBuscar = new System.Windows.Forms.Button();
            this.labelDataPedido = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonLancar = new System.Windows.Forms.Button();
            this.buttonOsBuscar = new System.Windows.Forms.Button();
            this.labelProdEletroId = new System.Windows.Forms.Label();
            this.labelProdEletroCod = new System.Windows.Forms.Label();
            this.groupBoxOs = new System.Windows.Forms.GroupBox();
            this.labelAgend = new System.Windows.Forms.Label();
            this.labelDataAgend = new System.Windows.Forms.Label();
            this.labelStatusDescricao = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBoxItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            this.groupBoxOs.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRemover
            // 
            this.labelRemover.AutoSize = true;
            this.labelRemover.Location = new System.Drawing.Point(26, 219);
            this.labelRemover.Name = "labelRemover";
            this.labelRemover.Size = new System.Drawing.Size(73, 13);
            this.labelRemover.TabIndex = 18;
            this.labelRemover.Text = "Remover Item";
            // 
            // buttonRemover
            // 
            this.buttonRemover.BackgroundImage = global::WinForms.Properties.Resources.exit_red;
            this.buttonRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRemover.Enabled = false;
            this.buttonRemover.FlatAppearance.BorderSize = 0;
            this.buttonRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemover.Location = new System.Drawing.Point(6, 215);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(20, 20);
            this.buttonRemover.TabIndex = 17;
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonConfirmar.Location = new System.Drawing.Point(731, 409);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(85, 40);
            this.buttonConfirmar.TabIndex = 8;
            this.buttonConfirmar.Text = "&Salvar";
            this.buttonConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(823, 409);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 9;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // groupBoxItem
            // 
            this.groupBoxItem.Controls.Add(this.labelItensDescricao);
            this.groupBoxItem.Controls.Add(this.labelItens);
            this.groupBoxItem.Controls.Add(this.labelTotalDescricao);
            this.groupBoxItem.Controls.Add(this.labelTotal);
            this.groupBoxItem.Controls.Add(this.buttonDesconto);
            this.groupBoxItem.Controls.Add(this.labelRemover);
            this.groupBoxItem.Controls.Add(this.buttonRemover);
            this.groupBoxItem.Controls.Add(this.labelDesconto);
            this.groupBoxItem.Controls.Add(this.labelValorDesc);
            this.groupBoxItem.Controls.Add(this.buttonProdutoInfo);
            this.groupBoxItem.Controls.Add(this.dataGridViewPedido);
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
            this.groupBoxItem.Location = new System.Drawing.Point(12, 149);
            this.groupBoxItem.Name = "groupBoxItem";
            this.groupBoxItem.Size = new System.Drawing.Size(896, 254);
            this.groupBoxItem.TabIndex = 7;
            this.groupBoxItem.TabStop = false;
            this.groupBoxItem.Text = "Lista de Pedido:";
            // 
            // labelItensDescricao
            // 
            this.labelItensDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelItensDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItensDescricao.Location = new System.Drawing.Point(701, 226);
            this.labelItensDescricao.Name = "labelItensDescricao";
            this.labelItensDescricao.Size = new System.Drawing.Size(60, 20);
            this.labelItensDescricao.TabIndex = 20;
            this.labelItensDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelItens
            // 
            this.labelItens.AutoSize = true;
            this.labelItens.Location = new System.Drawing.Point(701, 212);
            this.labelItens.Name = "labelItens";
            this.labelItens.Size = new System.Drawing.Size(33, 13);
            this.labelItens.TabIndex = 19;
            this.labelItens.Text = "Itens:";
            // 
            // labelTotalDescricao
            // 
            this.labelTotalDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDescricao.Location = new System.Drawing.Point(767, 226);
            this.labelTotalDescricao.Name = "labelTotalDescricao";
            this.labelTotalDescricao.Size = new System.Drawing.Size(117, 20);
            this.labelTotalDescricao.TabIndex = 22;
            this.labelTotalDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(767, 212);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(34, 13);
            this.labelTotal.TabIndex = 21;
            this.labelTotal.Text = "Total:";
            // 
            // buttonDesconto
            // 
            this.buttonDesconto.BackgroundImage = global::WinForms.Properties.Resources.icons8_Price_Tag_32;
            this.buttonDesconto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDesconto.Enabled = false;
            this.buttonDesconto.FlatAppearance.BorderSize = 0;
            this.buttonDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesconto.Location = new System.Drawing.Point(770, 31);
            this.buttonDesconto.Name = "buttonDesconto";
            this.buttonDesconto.Size = new System.Drawing.Size(20, 20);
            this.buttonDesconto.TabIndex = 13;
            this.buttonDesconto.UseVisualStyleBackColor = true;
            this.buttonDesconto.Click += new System.EventHandler(this.buttonDesconto_Click);
            // 
            // labelDesconto
            // 
            this.labelDesconto.AutoSize = true;
            this.labelDesconto.Location = new System.Drawing.Point(681, 18);
            this.labelDesconto.Name = "labelDesconto";
            this.labelDesconto.Size = new System.Drawing.Size(95, 13);
            this.labelDesconto.TabIndex = 11;
            this.labelDesconto.Text = "Vlr. com desconto:";
            // 
            // labelValorDesc
            // 
            this.labelValorDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorDesc.Location = new System.Drawing.Point(681, 31);
            this.labelValorDesc.Name = "labelValorDesc";
            this.labelValorDesc.Size = new System.Drawing.Size(83, 20);
            this.labelValorDesc.TabIndex = 12;
            this.labelValorDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonProdutoInfo
            // 
            this.buttonProdutoInfo.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonProdutoInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProdutoInfo.Enabled = false;
            this.buttonProdutoInfo.FlatAppearance.BorderSize = 0;
            this.buttonProdutoInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProdutoInfo.Location = new System.Drawing.Point(519, 31);
            this.buttonProdutoInfo.Name = "buttonProdutoInfo";
            this.buttonProdutoInfo.Size = new System.Drawing.Size(20, 20);
            this.buttonProdutoInfo.TabIndex = 6;
            this.buttonProdutoInfo.UseVisualStyleBackColor = true;
            this.buttonProdutoInfo.Click += new System.EventHandler(this.buttonProdutoInfo_Click);
            // 
            // dataGridViewPedido
            // 
            this.dataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colProdDescricao,
            this.colQuant,
            this.colUnitario,
            this.colDesconto,
            this.colTotal});
            this.dataGridViewPedido.Location = new System.Drawing.Point(6, 59);
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.RowHeadersWidth = 20;
            this.dataGridViewPedido.Size = new System.Drawing.Size(878, 150);
            this.dataGridViewPedido.TabIndex = 23;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "cod";
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
            this.colProdDescricao.Width = 500;
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
            this.colUnitario.HeaderText = "Vlr. unit.:";
            this.colUnitario.Name = "colUnitario";
            this.colUnitario.Width = 80;
            // 
            // colDesconto
            // 
            this.colDesconto.DataPropertyName = "valorDesc";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.colDesconto.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDesconto.HeaderText = "Vlr. Desconto:";
            this.colDesconto.Name = "colDesconto";
            this.colDesconto.Width = 80;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "valorTotal";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTotal.HeaderText = "Valor total:";
            this.colTotal.Name = "colTotal";
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Location = new System.Drawing.Point(90, 19);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(76, 13);
            this.labelProduto.TabIndex = 4;
            this.labelProduto.Text = "Peça/Serviço:";
            // 
            // labelProdutoDescricao
            // 
            this.labelProdutoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProdutoDescricao.Location = new System.Drawing.Point(90, 32);
            this.labelProdutoDescricao.Name = "labelProdutoDescricao";
            this.labelProdutoDescricao.Size = new System.Drawing.Size(423, 20);
            this.labelProdutoDescricao.TabIndex = 5;
            this.labelProdutoDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProdutoCod
            // 
            this.labelProdutoCod.AutoSize = true;
            this.labelProdutoCod.Location = new System.Drawing.Point(6, 17);
            this.labelProdutoCod.Name = "labelProdutoCod";
            this.labelProdutoCod.Size = new System.Drawing.Size(29, 13);
            this.labelProdutoCod.TabIndex = 0;
            this.labelProdutoCod.Text = "Cód:";
            // 
            // textBoxProdutoCod
            // 
            this.textBoxProdutoCod.Location = new System.Drawing.Point(6, 31);
            this.textBoxProdutoCod.Name = "textBoxProdutoCod";
            this.textBoxProdutoCod.Size = new System.Drawing.Size(35, 20);
            this.textBoxProdutoCod.TabIndex = 1;
            this.textBoxProdutoCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxProdutoCod.TextChanged += new System.EventHandler(this.textBoxProdutoCod_TextChanged);
            this.textBoxProdutoCod.Leave += new System.EventHandler(this.textBoxProdutoCod_Leave);
            // 
            // buttonProdutoBuscar
            // 
            this.buttonProdutoBuscar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonProdutoBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProdutoBuscar.FlatAppearance.BorderSize = 0;
            this.buttonProdutoBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProdutoBuscar.Location = new System.Drawing.Point(47, 31);
            this.buttonProdutoBuscar.Name = "buttonProdutoBuscar";
            this.buttonProdutoBuscar.Size = new System.Drawing.Size(20, 20);
            this.buttonProdutoBuscar.TabIndex = 2;
            this.buttonProdutoBuscar.UseVisualStyleBackColor = true;
            this.buttonProdutoBuscar.Click += new System.EventHandler(this.buttonProdutoBuscar_Click);
            // 
            // labelQuant
            // 
            this.labelQuant.AutoSize = true;
            this.labelQuant.Location = new System.Drawing.Point(545, 18);
            this.labelQuant.Name = "labelQuant";
            this.labelQuant.Size = new System.Drawing.Size(39, 13);
            this.labelQuant.TabIndex = 7;
            this.labelQuant.Text = "Quant:";
            // 
            // textBoxQuant
            // 
            this.textBoxQuant.Enabled = false;
            this.textBoxQuant.Location = new System.Drawing.Point(545, 31);
            this.textBoxQuant.Name = "textBoxQuant";
            this.textBoxQuant.Size = new System.Drawing.Size(41, 20);
            this.textBoxQuant.TabIndex = 8;
            this.textBoxQuant.Text = "1";
            this.textBoxQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxQuant.Leave += new System.EventHandler(this.textBoxQuant_Leave);
            // 
            // buttonProdutoAdd
            // 
            this.buttonProdutoAdd.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonProdutoAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProdutoAdd.FlatAppearance.BorderSize = 0;
            this.buttonProdutoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProdutoAdd.Location = new System.Drawing.Point(67, 31);
            this.buttonProdutoAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonProdutoAdd.Name = "buttonProdutoAdd";
            this.buttonProdutoAdd.Size = new System.Drawing.Size(20, 20);
            this.buttonProdutoAdd.TabIndex = 3;
            this.buttonProdutoAdd.UseVisualStyleBackColor = true;
            this.buttonProdutoAdd.Click += new System.EventHandler(this.buttonProdutoAdd_Click);
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(592, 18);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(62, 13);
            this.labelUnit.TabIndex = 9;
            this.labelUnit.Text = "Vlr. unitário:";
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
            this.buttonAddItem.TabIndex = 16;
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // labelValorUnit
            // 
            this.labelValorUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorUnit.Location = new System.Drawing.Point(592, 31);
            this.labelValorUnit.Name = "labelValorUnit";
            this.labelValorUnit.Size = new System.Drawing.Size(83, 20);
            this.labelValorUnit.TabIndex = 10;
            this.labelValorUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.labelQuantEstoque.TabIndex = 15;
            this.labelQuantEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEstoque
            // 
            this.labelEstoque.AutoSize = true;
            this.labelEstoque.Location = new System.Drawing.Point(796, 17);
            this.labelEstoque.Name = "labelEstoque";
            this.labelEstoque.Size = new System.Drawing.Size(66, 13);
            this.labelEstoque.TabIndex = 14;
            this.labelEstoque.Text = "Qt. Estoque:";
            // 
            // buttonClienteBuscar
            // 
            this.buttonClienteBuscar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonClienteBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClienteBuscar.Enabled = false;
            this.buttonClienteBuscar.FlatAppearance.BorderSize = 0;
            this.buttonClienteBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClienteBuscar.Location = new System.Drawing.Point(870, 29);
            this.buttonClienteBuscar.Name = "buttonClienteBuscar";
            this.buttonClienteBuscar.Size = new System.Drawing.Size(20, 20);
            this.buttonClienteBuscar.TabIndex = 7;
            this.buttonClienteBuscar.UseVisualStyleBackColor = true;
            this.buttonClienteBuscar.Click += new System.EventHandler(this.buttonClienteBuscar_Click);
            // 
            // textBoxOsCod
            // 
            this.textBoxOsCod.Location = new System.Drawing.Point(6, 30);
            this.textBoxOsCod.Name = "textBoxOsCod";
            this.textBoxOsCod.Size = new System.Drawing.Size(69, 20);
            this.textBoxOsCod.TabIndex = 1;
            this.textBoxOsCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOsCod.TextChanged += new System.EventHandler(this.textBoxOsCod_TextChanged);
            this.textBoxOsCod.Leave += new System.EventHandler(this.textBoxOsCod_Leave);
            // 
            // labelOs
            // 
            this.labelOs.AutoSize = true;
            this.labelOs.Location = new System.Drawing.Point(6, 16);
            this.labelOs.Name = "labelOs";
            this.labelOs.Size = new System.Drawing.Size(69, 13);
            this.labelOs.TabIndex = 0;
            this.labelOs.Text = "Ord. Serviço:";
            // 
            // labelClienteNome
            // 
            this.labelClienteNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelClienteNome.Location = new System.Drawing.Point(442, 29);
            this.labelClienteNome.Name = "labelClienteNome";
            this.labelClienteNome.Size = new System.Drawing.Size(422, 20);
            this.labelClienteNome.TabIndex = 6;
            this.labelClienteNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProdEletroDescricao
            // 
            this.labelProdEletroDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProdEletroDescricao.Location = new System.Drawing.Point(47, 66);
            this.labelProdEletroDescricao.Name = "labelProdEletroDescricao";
            this.labelProdEletroDescricao.Size = new System.Drawing.Size(736, 20);
            this.labelProdEletroDescricao.TabIndex = 11;
            this.labelProdEletroDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPedidoCod
            // 
            this.labelPedidoCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPedidoCod.Location = new System.Drawing.Point(12, 126);
            this.labelPedidoCod.Name = "labelPedidoCod";
            this.labelPedidoCod.Size = new System.Drawing.Size(68, 20);
            this.labelPedidoCod.TabIndex = 2;
            this.labelPedidoCod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEletro
            // 
            this.labelEletro.AutoSize = true;
            this.labelEletro.Location = new System.Drawing.Point(47, 53);
            this.labelEletro.Name = "labelEletro";
            this.labelEletro.Size = new System.Drawing.Size(117, 13);
            this.labelEletro.TabIndex = 10;
            this.labelEletro.Text = "Descrição do aparelho:";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(442, 15);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(88, 13);
            this.labelCliente.TabIndex = 5;
            this.labelCliente.Text = "Nome do Cliente:";
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(12, 112);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(43, 13);
            this.labelCod.TabIndex = 1;
            this.labelCod.Text = "Pedido:";
            // 
            // buttonEletroBuscar
            // 
            this.buttonEletroBuscar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonEletroBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEletroBuscar.Enabled = false;
            this.buttonEletroBuscar.FlatAppearance.BorderSize = 0;
            this.buttonEletroBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEletroBuscar.Location = new System.Drawing.Point(789, 66);
            this.buttonEletroBuscar.Name = "buttonEletroBuscar";
            this.buttonEletroBuscar.Size = new System.Drawing.Size(20, 20);
            this.buttonEletroBuscar.TabIndex = 12;
            this.buttonEletroBuscar.UseVisualStyleBackColor = true;
            this.buttonEletroBuscar.Click += new System.EventHandler(this.buttonEletroBuscar_Click);
            // 
            // labelDataPedido
            // 
            this.labelDataPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDataPedido.Location = new System.Drawing.Point(86, 126);
            this.labelDataPedido.Name = "labelDataPedido";
            this.labelDataPedido.Size = new System.Drawing.Size(225, 20);
            this.labelDataPedido.TabIndex = 4;
            this.labelDataPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(86, 112);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(84, 13);
            this.labelData.TabIndex = 3;
            this.labelData.Text = "Data do Pedido:";
            // 
            // buttonLancar
            // 
            this.buttonLancar.Enabled = false;
            this.buttonLancar.Location = new System.Drawing.Point(815, 63);
            this.buttonLancar.Name = "buttonLancar";
            this.buttonLancar.Size = new System.Drawing.Size(75, 23);
            this.buttonLancar.TabIndex = 13;
            this.buttonLancar.Text = "Lançar";
            this.buttonLancar.UseVisualStyleBackColor = true;
            this.buttonLancar.Click += new System.EventHandler(this.buttonLancar_Click);
            // 
            // buttonOsBuscar
            // 
            this.buttonOsBuscar.BackgroundImage = global::WinForms.Properties.Resources.abrir;
            this.buttonOsBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOsBuscar.FlatAppearance.BorderSize = 0;
            this.buttonOsBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOsBuscar.Location = new System.Drawing.Point(81, 30);
            this.buttonOsBuscar.Name = "buttonOsBuscar";
            this.buttonOsBuscar.Size = new System.Drawing.Size(20, 20);
            this.buttonOsBuscar.TabIndex = 2;
            this.buttonOsBuscar.UseVisualStyleBackColor = true;
            this.buttonOsBuscar.Click += new System.EventHandler(this.buttonOsBuscar_Click);
            // 
            // labelProdEletroId
            // 
            this.labelProdEletroId.AutoSize = true;
            this.labelProdEletroId.Location = new System.Drawing.Point(6, 53);
            this.labelProdEletroId.Name = "labelProdEletroId";
            this.labelProdEletroId.Size = new System.Drawing.Size(29, 13);
            this.labelProdEletroId.TabIndex = 8;
            this.labelProdEletroId.Text = "Cód:";
            // 
            // labelProdEletroCod
            // 
            this.labelProdEletroCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProdEletroCod.Location = new System.Drawing.Point(6, 66);
            this.labelProdEletroCod.Name = "labelProdEletroCod";
            this.labelProdEletroCod.Size = new System.Drawing.Size(35, 20);
            this.labelProdEletroCod.TabIndex = 9;
            this.labelProdEletroCod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxOs
            // 
            this.groupBoxOs.Controls.Add(this.labelAgend);
            this.groupBoxOs.Controls.Add(this.labelDataAgend);
            this.groupBoxOs.Controls.Add(this.textBoxOsCod);
            this.groupBoxOs.Controls.Add(this.labelProdEletroCod);
            this.groupBoxOs.Controls.Add(this.labelCliente);
            this.groupBoxOs.Controls.Add(this.labelProdEletroId);
            this.groupBoxOs.Controls.Add(this.labelClienteNome);
            this.groupBoxOs.Controls.Add(this.buttonLancar);
            this.groupBoxOs.Controls.Add(this.buttonOsBuscar);
            this.groupBoxOs.Controls.Add(this.labelOs);
            this.groupBoxOs.Controls.Add(this.buttonClienteBuscar);
            this.groupBoxOs.Controls.Add(this.buttonEletroBuscar);
            this.groupBoxOs.Controls.Add(this.labelProdEletroDescricao);
            this.groupBoxOs.Controls.Add(this.labelEletro);
            this.groupBoxOs.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOs.Name = "groupBoxOs";
            this.groupBoxOs.Size = new System.Drawing.Size(896, 93);
            this.groupBoxOs.TabIndex = 0;
            this.groupBoxOs.TabStop = false;
            this.groupBoxOs.Text = "Detalhes da OS:";
            // 
            // labelAgend
            // 
            this.labelAgend.AutoSize = true;
            this.labelAgend.Location = new System.Drawing.Point(110, 15);
            this.labelAgend.Name = "labelAgend";
            this.labelAgend.Size = new System.Drawing.Size(116, 13);
            this.labelAgend.TabIndex = 3;
            this.labelAgend.Text = "Data do agendamento:";
            // 
            // labelDataAgend
            // 
            this.labelDataAgend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDataAgend.Location = new System.Drawing.Point(110, 29);
            this.labelDataAgend.Name = "labelDataAgend";
            this.labelDataAgend.Size = new System.Drawing.Size(326, 20);
            this.labelDataAgend.TabIndex = 4;
            this.labelDataAgend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStatusDescricao
            // 
            this.labelStatusDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStatusDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusDescricao.Location = new System.Drawing.Point(683, 126);
            this.labelStatusDescricao.Name = "labelStatusDescricao";
            this.labelStatusDescricao.Size = new System.Drawing.Size(225, 20);
            this.labelStatusDescricao.TabIndex = 6;
            this.labelStatusDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(683, 112);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status:";
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 457);
            this.Controls.Add(this.labelStatusDescricao);
            this.Controls.Add(this.groupBoxOs);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.groupBoxItem);
            this.Controls.Add(this.labelDataPedido);
            this.Controls.Add(this.labelPedidoCod);
            this.Controls.Add(this.labelCod);
            this.Controls.Add(this.labelData);
            this.KeyPreview = true;
            this.Name = "FormPedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.FormPedido_Load);
            this.groupBoxItem.ResumeLayout(false);
            this.groupBoxItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            this.groupBoxOs.ResumeLayout(false);
            this.groupBoxOs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRemover;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.GroupBox groupBoxItem;
        private System.Windows.Forms.Button buttonProdutoInfo;
        private System.Windows.Forms.DataGridView dataGridViewPedido;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.Label labelProdutoDescricao;
        private System.Windows.Forms.Label labelProdutoCod;
        private System.Windows.Forms.TextBox textBoxProdutoCod;
        private System.Windows.Forms.Label labelQuant;
        private System.Windows.Forms.TextBox textBoxQuant;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Label labelValorUnit;
        private System.Windows.Forms.Label labelQuantEstoque;
        private System.Windows.Forms.Label labelEstoque;
        private System.Windows.Forms.Button buttonClienteBuscar;
        private System.Windows.Forms.TextBox textBoxOsCod;
        private System.Windows.Forms.Label labelOs;
        private System.Windows.Forms.Label labelClienteNome;
        private System.Windows.Forms.Label labelProdEletroDescricao;
        private System.Windows.Forms.Label labelPedidoCod;
        private System.Windows.Forms.Label labelEletro;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.Button buttonDesconto;
        private System.Windows.Forms.Label labelDesconto;
        private System.Windows.Forms.Label labelValorDesc;
        private System.Windows.Forms.Button buttonEletroBuscar;
        private System.Windows.Forms.Label labelDataPedido;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button buttonLancar;
        private System.Windows.Forms.Button buttonOsBuscar;
        private System.Windows.Forms.Label labelProdEletroId;
        private System.Windows.Forms.Button buttonProdutoBuscar;
        private System.Windows.Forms.Button buttonProdutoAdd;
        private System.Windows.Forms.Label labelProdEletroCod;
        private System.Windows.Forms.GroupBox groupBoxOs;
        private System.Windows.Forms.Label labelAgend;
        private System.Windows.Forms.Label labelDataAgend;
        private System.Windows.Forms.Label labelItensDescricao;
        private System.Windows.Forms.Label labelItens;
        private System.Windows.Forms.Label labelTotalDescricao;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Label labelStatusDescricao;
        private System.Windows.Forms.Label labelStatus;
    }
}
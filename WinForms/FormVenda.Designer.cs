namespace WinForms
{
    partial class FormVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelProd = new System.Windows.Forms.Label();
            this.dataGridViewItens = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxBarras = new System.Windows.Forms.TextBox();
            this.labelBarras = new System.Windows.Forms.Label();
            this.labelQuant = new System.Windows.Forms.Label();
            this.labelTotalProd = new System.Windows.Forms.Label();
            this.labelValorTotalProd = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelValorVolume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOperacao = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelProdBarras = new System.Windows.Forms.Label();
            this.labelValorProdBarras = new System.Windows.Forms.Label();
            this.labelProdCod = new System.Windows.Forms.Label();
            this.labelValorProdCod = new System.Windows.Forms.Label();
            this.labelValorProdQuant = new System.Windows.Forms.Label();
            this.labelProdPreco = new System.Windows.Forms.Label();
            this.labelValorProdPreco = new System.Windows.Forms.Label();
            this.labelProdQuant = new System.Windows.Forms.Label();
            this.textBoxQuant = new System.Windows.Forms.TextBox();
            this.labelValorEstoque = new System.Windows.Forms.Label();
            this.labelEstoque = new System.Windows.Forms.Label();
            this.labelRemover = new System.Windows.Forms.Label();
            this.pictureBoxConcluido = new System.Windows.Forms.PictureBox();
            this.pictureBoxCancel = new System.Windows.Forms.PictureBox();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonDesconto = new System.Windows.Forms.Button();
            this.buttonProd = new System.Windows.Forms.Button();
            this.buttonResponsavel = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonConcluir = new System.Windows.Forms.Button();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConcluido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescricao
            // 
            this.labelDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDescricao.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(11, 428);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(1308, 41);
            this.labelDescricao.TabIndex = 0;
            this.labelDescricao.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelProd
            // 
            this.labelProd.AutoSize = true;
            this.labelProd.Location = new System.Drawing.Point(15, 429);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(47, 13);
            this.labelProd.TabIndex = 19;
            this.labelProd.Text = "Produto:";
            // 
            // dataGridViewItens
            // 
            this.dataGridViewItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colId,
            this.colCod,
            this.colProduto,
            this.colQuant,
            this.colValorUnit,
            this.colDesconto,
            this.colSubTotal,
            this.colFunc});
            this.dataGridViewItens.Location = new System.Drawing.Point(162, 31);
            this.dataGridViewItens.Name = "dataGridViewItens";
            this.dataGridViewItens.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewItens.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewItens.Size = new System.Drawing.Size(1157, 394);
            this.dataGridViewItens.TabIndex = 7;
            this.dataGridViewItens.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridViewItens_RowPostPaint);
            this.dataGridViewItens.SelectionChanged += new System.EventHandler(this.dataGridViewItens_SelectionChanged);
            // 
            // colItem
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItem.DefaultCellStyle = dataGridViewCellStyle1;
            this.colItem.HeaderText = "Item:";
            this.colItem.Name = "colItem";
            this.colItem.Width = 35;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colId.DefaultCellStyle = dataGridViewCellStyle2;
            this.colId.HeaderText = "Id:";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colCod
            // 
            this.colCod.DataPropertyName = "Barras";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCod.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCod.HeaderText = "Código:";
            this.colCod.Name = "colCod";
            this.colCod.Width = 90;
            // 
            // colProduto
            // 
            this.colProduto.DataPropertyName = "Descricao";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colProduto.DefaultCellStyle = dataGridViewCellStyle4;
            this.colProduto.HeaderText = "Produto:";
            this.colProduto.Name = "colProduto";
            this.colProduto.Width = 480;
            // 
            // colQuant
            // 
            this.colQuant.DataPropertyName = "Quant";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = null;
            this.colQuant.DefaultCellStyle = dataGridViewCellStyle5;
            this.colQuant.HeaderText = "Qtd:";
            this.colQuant.Name = "colQuant";
            this.colQuant.Width = 50;
            // 
            // colValorUnit
            // 
            this.colValorUnit.DataPropertyName = "ValorUnit";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.colValorUnit.DefaultCellStyle = dataGridViewCellStyle6;
            this.colValorUnit.HeaderText = "Valor(Unit)";
            this.colValorUnit.Name = "colValorUnit";
            this.colValorUnit.Width = 70;
            // 
            // colDesconto
            // 
            this.colDesconto.DataPropertyName = "ValorDesc";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.colDesconto.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDesconto.HeaderText = "Desc (%):";
            this.colDesconto.Name = "colDesconto";
            this.colDesconto.Width = 70;
            // 
            // colSubTotal
            // 
            this.colSubTotal.DataPropertyName = "Total";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.colSubTotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.colSubTotal.HeaderText = "Subtotal:";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Width = 80;
            // 
            // colFunc
            // 
            this.colFunc.DataPropertyName = "funnome";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFunc.DefaultCellStyle = dataGridViewCellStyle9;
            this.colFunc.HeaderText = "Responsável:";
            this.colFunc.Name = "colFunc";
            this.colFunc.Width = 250;
            // 
            // textBoxBarras
            // 
            this.textBoxBarras.Enabled = false;
            this.textBoxBarras.Location = new System.Drawing.Point(11, 44);
            this.textBoxBarras.Name = "textBoxBarras";
            this.textBoxBarras.Size = new System.Drawing.Size(145, 20);
            this.textBoxBarras.TabIndex = 4;
            this.textBoxBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBarras
            // 
            this.labelBarras.AutoSize = true;
            this.labelBarras.Location = new System.Drawing.Point(11, 31);
            this.labelBarras.Name = "labelBarras";
            this.labelBarras.Size = new System.Drawing.Size(111, 13);
            this.labelBarras.TabIndex = 3;
            this.labelBarras.Text = "Código de barras: (F7)";
            // 
            // labelQuant
            // 
            this.labelQuant.AutoSize = true;
            this.labelQuant.Location = new System.Drawing.Point(11, 68);
            this.labelQuant.Name = "labelQuant";
            this.labelQuant.Size = new System.Drawing.Size(63, 13);
            this.labelQuant.TabIndex = 5;
            this.labelQuant.Text = "Quant.: (F6)";
            // 
            // labelTotalProd
            // 
            this.labelTotalProd.AutoSize = true;
            this.labelTotalProd.Location = new System.Drawing.Point(13, 388);
            this.labelTotalProd.Name = "labelTotalProd";
            this.labelTotalProd.Size = new System.Drawing.Size(49, 13);
            this.labelTotalProd.TabIndex = 18;
            this.labelTotalProd.Text = "Subtotal:";
            // 
            // labelValorTotalProd
            // 
            this.labelValorTotalProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorTotalProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotalProd.Location = new System.Drawing.Point(11, 386);
            this.labelValorTotalProd.Name = "labelValorTotalProd";
            this.labelValorTotalProd.Size = new System.Drawing.Size(145, 39);
            this.labelValorTotalProd.TabIndex = 11;
            this.labelValorTotalProd.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(1137, 478);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(57, 13);
            this.labelTotal.TabIndex = 23;
            this.labelTotal.Text = "Valor total:";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotal.Location = new System.Drawing.Point(1134, 476);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(185, 39);
            this.labelValorTotal.TabIndex = 15;
            this.labelValorTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(1035, 478);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(45, 13);
            this.labelVolume.TabIndex = 22;
            this.labelVolume.Text = "Volume:";
            // 
            // labelValorVolume
            // 
            this.labelValorVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorVolume.Location = new System.Drawing.Point(1032, 476);
            this.labelValorVolume.Name = "labelValorVolume";
            this.labelValorVolume.Size = new System.Drawing.Size(96, 39);
            this.labelValorVolume.TabIndex = 17;
            this.labelValorVolume.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1306, 20);
            this.label1.TabIndex = 19;
            // 
            // labelOperacao
            // 
            this.labelOperacao.AutoSize = true;
            this.labelOperacao.Location = new System.Drawing.Point(18, 13);
            this.labelOperacao.Name = "labelOperacao";
            this.labelOperacao.Size = new System.Drawing.Size(49, 13);
            this.labelOperacao.TabIndex = 0;
            this.labelOperacao.Text = "Controle:";
            this.labelOperacao.Click += new System.EventHandler(this.labelOperacao_Click);
            // 
            // labelCliente
            // 
            this.labelCliente.Location = new System.Drawing.Point(208, 13);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(536, 13);
            this.labelCliente.TabIndex = 1;
            this.labelCliente.Text = "Cliente: ";
            // 
            // labelVendedor
            // 
            this.labelVendedor.Location = new System.Drawing.Point(750, 13);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(426, 13);
            this.labelVendedor.TabIndex = 2;
            this.labelVendedor.Text = "Vendedor: ";
            // 
            // labelProdBarras
            // 
            this.labelProdBarras.AutoSize = true;
            this.labelProdBarras.Location = new System.Drawing.Point(11, 273);
            this.labelProdBarras.Name = "labelProdBarras";
            this.labelProdBarras.Size = new System.Drawing.Size(90, 13);
            this.labelProdBarras.TabIndex = 8;
            this.labelProdBarras.Text = "Código de barras:";
            // 
            // labelValorProdBarras
            // 
            this.labelValorProdBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorProdBarras.Location = new System.Drawing.Point(11, 286);
            this.labelValorProdBarras.Name = "labelValorProdBarras";
            this.labelValorProdBarras.Size = new System.Drawing.Size(145, 20);
            this.labelValorProdBarras.TabIndex = 9;
            this.labelValorProdBarras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProdCod
            // 
            this.labelProdCod.AutoSize = true;
            this.labelProdCod.Location = new System.Drawing.Point(11, 307);
            this.labelProdCod.Name = "labelProdCod";
            this.labelProdCod.Size = new System.Drawing.Size(32, 13);
            this.labelProdCod.TabIndex = 10;
            this.labelProdCod.Text = "Cód.:";
            // 
            // labelValorProdCod
            // 
            this.labelValorProdCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorProdCod.Location = new System.Drawing.Point(11, 320);
            this.labelValorProdCod.Name = "labelValorProdCod";
            this.labelValorProdCod.Size = new System.Drawing.Size(90, 20);
            this.labelValorProdCod.TabIndex = 11;
            this.labelValorProdCod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValorProdQuant
            // 
            this.labelValorProdQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorProdQuant.Location = new System.Drawing.Point(11, 357);
            this.labelValorProdQuant.Name = "labelValorProdQuant";
            this.labelValorProdQuant.Size = new System.Drawing.Size(49, 20);
            this.labelValorProdQuant.TabIndex = 15;
            this.labelValorProdQuant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProdPreco
            // 
            this.labelProdPreco.AutoSize = true;
            this.labelProdPreco.Location = new System.Drawing.Point(66, 344);
            this.labelProdPreco.Name = "labelProdPreco";
            this.labelProdPreco.Size = new System.Drawing.Size(75, 13);
            this.labelProdPreco.TabIndex = 16;
            this.labelProdPreco.Text = "Preço unitário:";
            // 
            // labelValorProdPreco
            // 
            this.labelValorProdPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorProdPreco.Location = new System.Drawing.Point(66, 357);
            this.labelValorProdPreco.Name = "labelValorProdPreco";
            this.labelValorProdPreco.Size = new System.Drawing.Size(90, 20);
            this.labelValorProdPreco.TabIndex = 17;
            this.labelValorProdPreco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProdQuant
            // 
            this.labelProdQuant.AutoSize = true;
            this.labelProdQuant.Location = new System.Drawing.Point(11, 344);
            this.labelProdQuant.Name = "labelProdQuant";
            this.labelProdQuant.Size = new System.Drawing.Size(39, 13);
            this.labelProdQuant.TabIndex = 14;
            this.labelProdQuant.Text = "Quant:";
            // 
            // textBoxQuant
            // 
            this.textBoxQuant.Enabled = false;
            this.textBoxQuant.Location = new System.Drawing.Point(11, 84);
            this.textBoxQuant.Name = "textBoxQuant";
            this.textBoxQuant.Size = new System.Drawing.Size(145, 20);
            this.textBoxQuant.TabIndex = 6;
            this.textBoxQuant.Text = "1,000";
            this.textBoxQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxQuant.TextChanged += new System.EventHandler(this.textBoxQuant_TextChanged);
            // 
            // labelValorEstoque
            // 
            this.labelValorEstoque.BackColor = System.Drawing.Color.MistyRose;
            this.labelValorEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorEstoque.ForeColor = System.Drawing.Color.Maroon;
            this.labelValorEstoque.Location = new System.Drawing.Point(107, 320);
            this.labelValorEstoque.Name = "labelValorEstoque";
            this.labelValorEstoque.Size = new System.Drawing.Size(49, 20);
            this.labelValorEstoque.TabIndex = 13;
            this.labelValorEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEstoque
            // 
            this.labelEstoque.AutoSize = true;
            this.labelEstoque.Location = new System.Drawing.Point(107, 307);
            this.labelEstoque.Name = "labelEstoque";
            this.labelEstoque.Size = new System.Drawing.Size(49, 13);
            this.labelEstoque.TabIndex = 12;
            this.labelEstoque.Text = "Estoque:";
            // 
            // labelRemover
            // 
            this.labelRemover.AutoSize = true;
            this.labelRemover.Location = new System.Drawing.Point(31, 476);
            this.labelRemover.Name = "labelRemover";
            this.labelRemover.Size = new System.Drawing.Size(73, 13);
            this.labelRemover.TabIndex = 21;
            this.labelRemover.Text = "Remover Item";
            // 
            // pictureBoxConcluido
            // 
            this.pictureBoxConcluido.Image = global::WinForms.Properties.Resources.concluido;
            this.pictureBoxConcluido.Location = new System.Drawing.Point(35, 157);
            this.pictureBoxConcluido.Name = "pictureBoxConcluido";
            this.pictureBoxConcluido.Size = new System.Drawing.Size(95, 67);
            this.pictureBoxConcluido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConcluido.TabIndex = 32;
            this.pictureBoxConcluido.TabStop = false;
            this.pictureBoxConcluido.Visible = false;
            // 
            // pictureBoxCancel
            // 
            this.pictureBoxCancel.Image = global::WinForms.Properties.Resources.cancelado;
            this.pictureBoxCancel.Location = new System.Drawing.Point(11, 33);
            this.pictureBoxCancel.Name = "pictureBoxCancel";
            this.pictureBoxCancel.Size = new System.Drawing.Size(145, 71);
            this.pictureBoxCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCancel.TabIndex = 31;
            this.pictureBoxCancel.TabStop = false;
            this.pictureBoxCancel.Visible = false;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackColor = System.Drawing.Color.Transparent;
            this.buttonImprimir.FlatAppearance.BorderSize = 0;
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Image = global::WinForms.Properties.Resources.PhotoPrint_63141;
            this.buttonImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonImprimir.Location = new System.Drawing.Point(357, 515);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(85, 60);
            this.buttonImprimir.TabIndex = 30;
            this.buttonImprimir.Text = "&Imprimir";
            this.buttonImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonImprimir.UseVisualStyleBackColor = false;
            this.buttonImprimir.Visible = false;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.BackgroundImage = global::WinForms.Properties.Resources.exit_red;
            this.buttonRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRemover.Enabled = false;
            this.buttonRemover.FlatAppearance.BorderSize = 0;
            this.buttonRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemover.Location = new System.Drawing.Point(11, 472);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(20, 20);
            this.buttonRemover.TabIndex = 20;
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.Transparent;
            this.buttonFechar.FlatAppearance.BorderSize = 0;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFechar.Location = new System.Drawing.Point(1143, 517);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 60);
            this.buttonFechar.TabIndex = 29;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonDesconto
            // 
            this.buttonDesconto.BackColor = System.Drawing.Color.Transparent;
            this.buttonDesconto.Enabled = false;
            this.buttonDesconto.FlatAppearance.BorderSize = 0;
            this.buttonDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesconto.Image = global::WinForms.Properties.Resources.desconto1;
            this.buttonDesconto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDesconto.Location = new System.Drawing.Point(266, 515);
            this.buttonDesconto.Name = "buttonDesconto";
            this.buttonDesconto.Size = new System.Drawing.Size(85, 60);
            this.buttonDesconto.TabIndex = 27;
            this.buttonDesconto.Text = "&Desconto";
            this.buttonDesconto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDesconto.UseVisualStyleBackColor = false;
            this.buttonDesconto.Click += new System.EventHandler(this.buttonDesconto_Click);
            // 
            // buttonProd
            // 
            this.buttonProd.BackColor = System.Drawing.Color.Transparent;
            this.buttonProd.Enabled = false;
            this.buttonProd.FlatAppearance.BorderSize = 0;
            this.buttonProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProd.Image = global::WinForms.Properties.Resources.produto;
            this.buttonProd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonProd.Location = new System.Drawing.Point(181, 515);
            this.buttonProd.Name = "buttonProd";
            this.buttonProd.Size = new System.Drawing.Size(85, 60);
            this.buttonProd.TabIndex = 26;
            this.buttonProd.Text = "&Produto";
            this.buttonProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonProd.UseVisualStyleBackColor = false;
            this.buttonProd.Click += new System.EventHandler(this.buttonProd_Click);
            // 
            // buttonResponsavel
            // 
            this.buttonResponsavel.BackColor = System.Drawing.Color.Transparent;
            this.buttonResponsavel.Enabled = false;
            this.buttonResponsavel.FlatAppearance.BorderSize = 0;
            this.buttonResponsavel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResponsavel.Image = global::WinForms.Properties.Resources.employee;
            this.buttonResponsavel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonResponsavel.Location = new System.Drawing.Point(96, 515);
            this.buttonResponsavel.Name = "buttonResponsavel";
            this.buttonResponsavel.Size = new System.Drawing.Size(85, 60);
            this.buttonResponsavel.TabIndex = 25;
            this.buttonResponsavel.Text = "&Resp.";
            this.buttonResponsavel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonResponsavel.UseVisualStyleBackColor = false;
            this.buttonResponsavel.Click += new System.EventHandler(this.buttonVendedor_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackColor = System.Drawing.Color.Transparent;
            this.buttonCliente.FlatAppearance.BorderSize = 0;
            this.buttonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCliente.Image = global::WinForms.Properties.Resources.cliente;
            this.buttonCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCliente.Location = new System.Drawing.Point(11, 515);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(85, 60);
            this.buttonCliente.TabIndex = 24;
            this.buttonCliente.Text = "Clie&nte";
            this.buttonCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCliente.UseVisualStyleBackColor = false;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonConcluir
            // 
            this.buttonConcluir.BackColor = System.Drawing.SystemColors.Control;
            this.buttonConcluir.Enabled = false;
            this.buttonConcluir.FlatAppearance.BorderSize = 0;
            this.buttonConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConcluir.ForeColor = System.Drawing.Color.Black;
            this.buttonConcluir.Image = global::WinForms.Properties.Resources.money1;
            this.buttonConcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonConcluir.Location = new System.Drawing.Point(1234, 517);
            this.buttonConcluir.Name = "buttonConcluir";
            this.buttonConcluir.Size = new System.Drawing.Size(85, 60);
            this.buttonConcluir.TabIndex = 28;
            this.buttonConcluir.Text = "&Concluir (F12)";
            this.buttonConcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonConcluir.UseVisualStyleBackColor = false;
            this.buttonConcluir.Click += new System.EventHandler(this.buttonConcluir_Click);
            // 
            // textBoxObs
            // 
            this.textBoxObs.Location = new System.Drawing.Point(11, 110);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.ReadOnly = true;
            this.textBoxObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxObs.Size = new System.Drawing.Size(145, 315);
            this.textBoxObs.TabIndex = 33;
            this.textBoxObs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxObs.Visible = false;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 585);
            this.Controls.Add(this.textBoxObs);
            this.Controls.Add(this.pictureBoxConcluido);
            this.Controls.Add(this.pictureBoxCancel);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.labelRemover);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.labelValorEstoque);
            this.Controls.Add(this.labelEstoque);
            this.Controls.Add(this.textBoxQuant);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonDesconto);
            this.Controls.Add(this.labelValorProdQuant);
            this.Controls.Add(this.labelProdPreco);
            this.Controls.Add(this.labelValorProdPreco);
            this.Controls.Add(this.labelProdQuant);
            this.Controls.Add(this.labelProdCod);
            this.Controls.Add(this.labelValorProdCod);
            this.Controls.Add(this.labelProdBarras);
            this.Controls.Add(this.labelValorProdBarras);
            this.Controls.Add(this.buttonProd);
            this.Controls.Add(this.buttonResponsavel);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.buttonConcluir);
            this.Controls.Add(this.labelVendedor);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelOperacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelValorVolume);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.labelTotalProd);
            this.Controls.Add(this.labelValorTotalProd);
            this.Controls.Add(this.labelQuant);
            this.Controls.Add(this.labelBarras);
            this.Controls.Add(this.textBoxBarras);
            this.Controls.Add(this.dataGridViewItens);
            this.Controls.Add(this.labelProd);
            this.Controls.Add(this.labelDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FormVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ponto de venda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVenda_FormClosing);
            this.Load += new System.EventHandler(this.FormVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConcluido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.DataGridView dataGridViewItens;
        private System.Windows.Forms.TextBox textBoxBarras;
        private System.Windows.Forms.Label labelBarras;
        private System.Windows.Forms.Label labelQuant;
        private System.Windows.Forms.Label labelTotalProd;
        private System.Windows.Forms.Label labelValorTotalProd;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelValorVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOperacao;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Button buttonConcluir;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonResponsavel;
        private System.Windows.Forms.Button buttonProd;
        private System.Windows.Forms.Label labelProdBarras;
        private System.Windows.Forms.Label labelValorProdBarras;
        private System.Windows.Forms.Label labelProdCod;
        private System.Windows.Forms.Label labelValorProdCod;
        private System.Windows.Forms.Label labelValorProdQuant;
        private System.Windows.Forms.Label labelProdPreco;
        private System.Windows.Forms.Label labelValorProdPreco;
        private System.Windows.Forms.Label labelProdQuant;
        private System.Windows.Forms.Button buttonDesconto;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.TextBox textBoxQuant;
        private System.Windows.Forms.Label labelValorEstoque;
        private System.Windows.Forms.Label labelEstoque;
        private System.Windows.Forms.Label labelRemover;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.PictureBox pictureBoxCancel;
        private System.Windows.Forms.PictureBox pictureBoxConcluido;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFunc;
    }
}
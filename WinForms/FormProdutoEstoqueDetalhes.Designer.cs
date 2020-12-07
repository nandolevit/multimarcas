namespace WinForms
{
    partial class FormProdutoEstoqueDetalhes
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
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorVarejo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelLista = new System.Windows.Forms.Label();
            this.labelCompra = new System.Windows.Forms.Label();
            this.labelVarejo = new System.Windows.Forms.Label();
            this.labelEstoque = new System.Windows.Forms.Label();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.radioButtonCod = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDescricao = new System.Windows.Forms.RadioButton();
            this.radioButtonBarras = new System.Windows.Forms.RadioButton();
            this.buttonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.colCodBarras,
            this.colProd,
            this.colMarca,
            this.colSubCat,
            this.colValorCompra,
            this.colValorVarejo,
            this.colQuant});
            this.dataGridViewProdutos.Location = new System.Drawing.Point(12, 65);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.RowHeadersVisible = false;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(1315, 500);
            this.dataGridViewProdutos.TabIndex = 3;
            this.dataGridViewProdutos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellContentDoubleClick);
            // 
            // colCod
            // 
            this.colCod.DataPropertyName = "proid";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "00000";
            this.colCod.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCod.HeaderText = "ID:";
            this.colCod.Name = "colCod";
            this.colCod.Width = 60;
            // 
            // colCodBarras
            // 
            this.colCodBarras.DataPropertyName = "procodbarras";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCodBarras.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCodBarras.HeaderText = "Cod. Barras:";
            this.colCodBarras.Name = "colCodBarras";
            this.colCodBarras.Width = 110;
            // 
            // colProd
            // 
            this.colProd.DataPropertyName = "prodescricao";
            this.colProd.HeaderText = "Produto:";
            this.colProd.Name = "colProd";
            this.colProd.Width = 600;
            // 
            // colMarca
            // 
            this.colMarca.DataPropertyName = "autnome";
            this.colMarca.HeaderText = "Marca:";
            this.colMarca.Name = "colMarca";
            this.colMarca.Width = 150;
            // 
            // colSubCat
            // 
            this.colSubCat.DataPropertyName = "prodsubcatnome";
            this.colSubCat.HeaderText = "Subcategoria";
            this.colSubCat.Name = "colSubCat";
            this.colSubCat.Width = 150;
            // 
            // colValorCompra
            // 
            this.colValorCompra.DataPropertyName = "provalorcompra";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            this.colValorCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.colValorCompra.HeaderText = "Vlr. Compra:";
            this.colValorCompra.Name = "colValorCompra";
            this.colValorCompra.Width = 75;
            // 
            // colValorVarejo
            // 
            this.colValorVarejo.DataPropertyName = "provalorvarejo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            this.colValorVarejo.DefaultCellStyle = dataGridViewCellStyle4;
            this.colValorVarejo.HeaderText = "Vlr Varejo:";
            this.colValorVarejo.Name = "colValorVarejo";
            this.colValorVarejo.Width = 75;
            // 
            // colQuant
            // 
            this.colQuant.DataPropertyName = "prodestoquequant";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "0000";
            this.colQuant.DefaultCellStyle = dataGridViewCellStyle5;
            this.colQuant.HeaderText = "Estoque:";
            this.colQuant.Name = "colQuant";
            this.colQuant.Width = 60;
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLista.Location = new System.Drawing.Point(534, 578);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(34, 13);
            this.labelLista.TabIndex = 4;
            this.labelLista.Text = "Lista";
            // 
            // labelCompra
            // 
            this.labelCompra.AutoSize = true;
            this.labelCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompra.Location = new System.Drawing.Point(711, 578);
            this.labelCompra.Name = "labelCompra";
            this.labelCompra.Size = new System.Drawing.Size(49, 13);
            this.labelCompra.TabIndex = 5;
            this.labelCompra.Text = "Compra";
            // 
            // labelVarejo
            // 
            this.labelVarejo.AutoSize = true;
            this.labelVarejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVarejo.Location = new System.Drawing.Point(941, 578);
            this.labelVarejo.Name = "labelVarejo";
            this.labelVarejo.Size = new System.Drawing.Size(43, 13);
            this.labelVarejo.TabIndex = 6;
            this.labelVarejo.Text = "Varejo";
            // 
            // labelEstoque
            // 
            this.labelEstoque.AutoSize = true;
            this.labelEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstoque.Location = new System.Drawing.Point(1163, 578);
            this.labelEstoque.Name = "labelEstoque";
            this.labelEstoque.Size = new System.Drawing.Size(53, 13);
            this.labelEstoque.TabIndex = 7;
            this.labelEstoque.Text = "Estoque";
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(257, 31);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(616, 20);
            this.textBoxPesquisar.TabIndex = 1;
            // 
            // radioButtonCod
            // 
            this.radioButtonCod.AutoSize = true;
            this.radioButtonCod.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCod.Name = "radioButtonCod";
            this.radioButtonCod.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCod.TabIndex = 0;
            this.radioButtonCod.Text = "Código";
            this.radioButtonCod.UseVisualStyleBackColor = true;
            this.radioButtonCod.CheckedChanged += new System.EventHandler(this.radioButtonCod_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDescricao);
            this.groupBox1.Controls.Add(this.radioButtonBarras);
            this.groupBox1.Controls.Add(this.radioButtonCod);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por:";
            // 
            // radioButtonDescricao
            // 
            this.radioButtonDescricao.AutoSize = true;
            this.radioButtonDescricao.Checked = true;
            this.radioButtonDescricao.Location = new System.Drawing.Point(150, 19);
            this.radioButtonDescricao.Name = "radioButtonDescricao";
            this.radioButtonDescricao.Size = new System.Drawing.Size(73, 17);
            this.radioButtonDescricao.TabIndex = 2;
            this.radioButtonDescricao.TabStop = true;
            this.radioButtonDescricao.Text = "Descricao";
            this.radioButtonDescricao.UseVisualStyleBackColor = true;
            this.radioButtonDescricao.CheckedChanged += new System.EventHandler(this.radioButtonDescricao_CheckedChanged);
            // 
            // radioButtonBarras
            // 
            this.radioButtonBarras.AutoSize = true;
            this.radioButtonBarras.Location = new System.Drawing.Point(70, 19);
            this.radioButtonBarras.Name = "radioButtonBarras";
            this.radioButtonBarras.Size = new System.Drawing.Size(74, 17);
            this.radioButtonBarras.TabIndex = 1;
            this.radioButtonBarras.Text = "CodBarras";
            this.radioButtonBarras.UseVisualStyleBackColor = true;
            this.radioButtonBarras.CheckedChanged += new System.EventHandler(this.radioButtonBarras_CheckedChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Location = new System.Drawing.Point(879, 29);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(30, 23);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // FormProdutoEstoqueDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 609);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxPesquisar);
            this.Controls.Add(this.labelEstoque);
            this.Controls.Add(this.labelVarejo);
            this.Controls.Add(this.labelCompra);
            this.Controls.Add(this.labelLista);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Name = "FormProdutoEstoqueDetalhes";
            this.Text = "Lista de produtos";
            this.Load += new System.EventHandler(this.FormProdutoEstoqueDetalhes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProdutoEstoqueDetalhes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.Label labelLista;
        private System.Windows.Forms.Label labelCompra;
        private System.Windows.Forms.Label labelVarejo;
        private System.Windows.Forms.Label labelEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorVarejo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuant;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.RadioButton radioButtonCod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDescricao;
        private System.Windows.Forms.RadioButton radioButtonBarras;
        private System.Windows.Forms.Button buttonBuscar;
    }
}
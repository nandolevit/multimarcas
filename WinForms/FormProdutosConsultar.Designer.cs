namespace WinForms
{
    partial class FormProdutosConsultar
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
            this.dataGridViewProd = new System.Windows.Forms.DataGridView();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtacado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.radioButtonBarras = new System.Windows.Forms.RadioButton();
            this.radioButtonId = new System.Windows.Forms.RadioButton();
            this.radioButtonProd = new System.Windows.Forms.RadioButton();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.labelPesquisar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).BeginInit();
            this.groupBoxTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProd
            // 
            this.dataGridViewProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.colBarras,
            this.colProd,
            this.colPreco,
            this.colAtacado,
            this.colStatus});
            this.dataGridViewProd.Location = new System.Drawing.Point(12, 82);
            this.dataGridViewProd.Name = "dataGridViewProd";
            this.dataGridViewProd.RowHeadersVisible = false;
            this.dataGridViewProd.Size = new System.Drawing.Size(1094, 410);
            this.dataGridViewProd.TabIndex = 0;
            this.dataGridViewProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProd_CellDoubleClick);
            // 
            // colCod
            // 
            this.colCod.DataPropertyName = "proId";
            dataGridViewCellStyle1.Format = "000000";
            dataGridViewCellStyle1.NullValue = null;
            this.colCod.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCod.HeaderText = "Código:";
            this.colCod.Name = "colCod";
            this.colCod.Width = 50;
            // 
            // colBarras
            // 
            this.colBarras.DataPropertyName = "proCodBarras";
            this.colBarras.HeaderText = "Cód. de barras:";
            this.colBarras.Name = "colBarras";
            this.colBarras.Width = 120;
            // 
            // colProd
            // 
            this.colProd.DataPropertyName = "prodetalhes";
            this.colProd.HeaderText = "Produto:";
            this.colProd.Name = "colProd";
            this.colProd.Width = 630;
            // 
            // colPreco
            // 
            this.colPreco.DataPropertyName = "proValorVarejo";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.colPreco.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPreco.HeaderText = "Preço:";
            this.colPreco.Name = "colPreco";
            this.colPreco.Width = 80;
            // 
            // colAtacado
            // 
            this.colAtacado.DataPropertyName = "proValorAtacado";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.colAtacado.DefaultCellStyle = dataGridViewCellStyle3;
            this.colAtacado.HeaderText = "Atacado:";
            this.colAtacado.Name = "colAtacado";
            this.colAtacado.Width = 80;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Desativado";
            this.colStatus.HeaderText = "Status:";
            this.colStatus.Name = "colStatus";
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(358, 40);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(558, 20);
            this.textBoxPesquisar.TabIndex = 2;
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.radioButtonBarras);
            this.groupBoxTipo.Controls.Add(this.radioButtonId);
            this.groupBoxTipo.Controls.Add(this.radioButtonProd);
            this.groupBoxTipo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(340, 48);
            this.groupBoxTipo.TabIndex = 1;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Pesquisar por:";
            // 
            // radioButtonBarras
            // 
            this.radioButtonBarras.AutoSize = true;
            this.radioButtonBarras.Location = new System.Drawing.Point(200, 19);
            this.radioButtonBarras.Name = "radioButtonBarras";
            this.radioButtonBarras.Size = new System.Drawing.Size(105, 17);
            this.radioButtonBarras.TabIndex = 2;
            this.radioButtonBarras.Text = "Código de barras";
            this.radioButtonBarras.UseVisualStyleBackColor = true;
            this.radioButtonBarras.CheckedChanged += new System.EventHandler(this.radioButtonBarras_CheckedChanged);
            // 
            // radioButtonId
            // 
            this.radioButtonId.AutoSize = true;
            this.radioButtonId.Location = new System.Drawing.Point(105, 19);
            this.radioButtonId.Name = "radioButtonId";
            this.radioButtonId.Size = new System.Drawing.Size(58, 17);
            this.radioButtonId.TabIndex = 1;
            this.radioButtonId.Text = "Código";
            this.radioButtonId.UseVisualStyleBackColor = true;
            this.radioButtonId.CheckedChanged += new System.EventHandler(this.radioButtonId_CheckedChanged);
            // 
            // radioButtonProd
            // 
            this.radioButtonProd.AutoSize = true;
            this.radioButtonProd.Checked = true;
            this.radioButtonProd.Location = new System.Drawing.Point(6, 19);
            this.radioButtonProd.Name = "radioButtonProd";
            this.radioButtonProd.Size = new System.Drawing.Size(62, 17);
            this.radioButtonProd.TabIndex = 0;
            this.radioButtonProd.TabStop = true;
            this.radioButtonProd.Text = "Produto";
            this.radioButtonProd.UseVisualStyleBackColor = true;
            this.radioButtonProd.CheckedChanged += new System.EventHandler(this.radioButtonProd_CheckedChanged);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPesquisar.FlatAppearance.BorderSize = 0;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Location = new System.Drawing.Point(922, 40);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(20, 20);
            this.buttonPesquisar.TabIndex = 3;
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // labelPesquisar
            // 
            this.labelPesquisar.AutoSize = true;
            this.labelPesquisar.Location = new System.Drawing.Point(358, 24);
            this.labelPesquisar.Name = "labelPesquisar";
            this.labelPesquisar.Size = new System.Drawing.Size(56, 13);
            this.labelPesquisar.TabIndex = 4;
            this.labelPesquisar.Text = "Pesquisar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista de produtos:";
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(1021, 498);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 7;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormProdutosConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 550);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPesquisar);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.textBoxPesquisar);
            this.Controls.Add(this.dataGridViewProd);
            this.KeyPreview = true;
            this.Name = "FormProdutosConsultar";
            this.Text = "Consultar produtos";
            this.Load += new System.EventHandler(this.FormProdutosConsultar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProdutosConsultar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).EndInit();
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProd;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.RadioButton radioButtonId;
        private System.Windows.Forms.RadioButton radioButtonProd;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.RadioButton radioButtonBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtacado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Label labelPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFechar;
    }
}
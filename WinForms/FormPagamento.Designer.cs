namespace WinForms
{
    partial class FormPagamento
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
            this.dataGridViewFormaPag = new System.Windows.Forms.DataGridView();
            this.colIdForma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colForma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaquineta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelValorCompra = new System.Windows.Forms.Label();
            this.labelForma = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxForma = new System.Windows.Forms.TextBox();
            this.labelValorForma = new System.Windows.Forms.Label();
            this.labelValorTroco = new System.Windows.Forms.Label();
            this.labelTroco = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxBandeira = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxParcela = new System.Windows.Forms.ComboBox();
            this.labelTotalPag = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelRemover = new System.Windows.Forms.Label();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonConcluir = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.groupBoxPag = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormaPag)).BeginInit();
            this.groupBoxPag.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFormaPag
            // 
            this.dataGridViewFormaPag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormaPag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdForma,
            this.colForma,
            this.colValor,
            this.colMaquineta,
            this.colParcelas});
            this.dataGridViewFormaPag.Location = new System.Drawing.Point(12, 108);
            this.dataGridViewFormaPag.Name = "dataGridViewFormaPag";
            this.dataGridViewFormaPag.RowHeadersWidth = 15;
            this.dataGridViewFormaPag.Size = new System.Drawing.Size(657, 89);
            this.dataGridViewFormaPag.TabIndex = 2;
            // 
            // colIdForma
            // 
            this.colIdForma.DataPropertyName = "pagid";
            this.colIdForma.HeaderText = "Id";
            this.colIdForma.Name = "colIdForma";
            this.colIdForma.Visible = false;
            // 
            // colForma
            // 
            this.colForma.DataPropertyName = "pagdescricao";
            this.colForma.HeaderText = "Forma de pagamento:";
            this.colForma.Name = "colForma";
            this.colForma.Width = 225;
            // 
            // colValor
            // 
            this.colValor.DataPropertyName = "pagvalor";
            dataGridViewCellStyle1.Format = "C2";
            this.colValor.DefaultCellStyle = dataGridViewCellStyle1;
            this.colValor.HeaderText = "Valor:";
            this.colValor.Name = "colValor";
            this.colValor.Width = 150;
            // 
            // colMaquineta
            // 
            this.colMaquineta.DataPropertyName = "pagbanddescricao";
            this.colMaquineta.HeaderText = "Bandeira:";
            this.colMaquineta.Name = "colMaquineta";
            // 
            // colParcelas
            // 
            this.colParcelas.DataPropertyName = "parcela";
            this.colParcelas.HeaderText = "Parcelas:";
            this.colParcelas.Name = "colParcelas";
            this.colParcelas.Width = 150;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(259, 34);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(83, 20);
            this.textBoxValor.TabIndex = 5;
            this.textBoxValor.TextChanged += new System.EventHandler(this.textBoxValor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor da compra:";
            // 
            // labelValorCompra
            // 
            this.labelValorCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorCompra.Location = new System.Drawing.Point(353, 245);
            this.labelValorCompra.Name = "labelValorCompra";
            this.labelValorCompra.Size = new System.Drawing.Size(155, 39);
            this.labelValorCompra.TabIndex = 8;
            this.labelValorCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelForma
            // 
            this.labelForma.AutoSize = true;
            this.labelForma.Location = new System.Drawing.Point(67, 19);
            this.labelForma.Name = "labelForma";
            this.labelForma.Size = new System.Drawing.Size(134, 13);
            this.labelForma.TabIndex = 2;
            this.labelForma.Text = "Forma de pagamento: (F1) ";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(259, 20);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(55, 13);
            this.labelValor.TabIndex = 4;
            this.labelValor.Text = "Valor (F2):";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(657, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "FINALIZAR VENDA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxForma
            // 
            this.textBoxForma.Location = new System.Drawing.Point(6, 34);
            this.textBoxForma.Name = "textBoxForma";
            this.textBoxForma.Size = new System.Drawing.Size(29, 20);
            this.textBoxForma.TabIndex = 0;
            this.textBoxForma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxForma.TextChanged += new System.EventHandler(this.textBoxForma_TextChanged);
            this.textBoxForma.Leave += new System.EventHandler(this.textBoxForma_Leave);
            // 
            // labelValorForma
            // 
            this.labelValorForma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelValorForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorForma.Location = new System.Drawing.Point(67, 34);
            this.labelValorForma.Name = "labelValorForma";
            this.labelValorForma.Size = new System.Drawing.Size(186, 21);
            this.labelValorForma.TabIndex = 3;
            this.labelValorForma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelValorTroco
            // 
            this.labelValorTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTroco.Location = new System.Drawing.Point(514, 245);
            this.labelValorTroco.Name = "labelValorTroco";
            this.labelValorTroco.Size = new System.Drawing.Size(155, 39);
            this.labelValorTroco.TabIndex = 10;
            this.labelValorTroco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTroco
            // 
            this.labelTroco.AutoSize = true;
            this.labelTroco.Location = new System.Drawing.Point(514, 232);
            this.labelTroco.Name = "labelTroco";
            this.labelTroco.Size = new System.Drawing.Size(38, 13);
            this.labelTroco.TabIndex = 9;
            this.labelTroco.Text = "Troco:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Location = new System.Drawing.Point(41, 35);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(603, 33);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(20, 20);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxBandeira
            // 
            this.comboBoxBandeira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBandeira.Enabled = false;
            this.comboBoxBandeira.FormattingEnabled = true;
            this.comboBoxBandeira.Location = new System.Drawing.Point(349, 33);
            this.comboBoxBandeira.Name = "comboBoxBandeira";
            this.comboBoxBandeira.Size = new System.Drawing.Size(97, 21);
            this.comboBoxBandeira.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bandeira:";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(452, 20);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(31, 13);
            this.labelTipo.TabIndex = 8;
            this.labelTipo.Text = "Tipo:";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.Enabled = false;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(452, 33);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(97, 21);
            this.comboBoxTipo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Parc.:";
            // 
            // comboBoxParcela
            // 
            this.comboBoxParcela.DisplayMember = "1";
            this.comboBoxParcela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParcela.Enabled = false;
            this.comboBoxParcela.FormattingEnabled = true;
            this.comboBoxParcela.Items.AddRange(new object[] {
            "1x",
            "2x",
            "3x",
            "4x",
            "5x",
            "6x",
            "7x",
            "8x",
            "9x",
            "10x",
            "11x",
            "12x"});
            this.comboBoxParcela.Location = new System.Drawing.Point(555, 33);
            this.comboBoxParcela.Name = "comboBoxParcela";
            this.comboBoxParcela.Size = new System.Drawing.Size(42, 21);
            this.comboBoxParcela.TabIndex = 11;
            this.comboBoxParcela.ValueMember = "1";
            // 
            // labelTotalPag
            // 
            this.labelTotalPag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPag.Location = new System.Drawing.Point(12, 245);
            this.labelTotalPag.Name = "labelTotalPag";
            this.labelTotalPag.Size = new System.Drawing.Size(110, 20);
            this.labelTotalPag.TabIndex = 6;
            this.labelTotalPag.Text = "R$ 0,00";
            this.labelTotalPag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(11, 230);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(34, 13);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Valor:";
            // 
            // labelRemover
            // 
            this.labelRemover.AutoSize = true;
            this.labelRemover.Location = new System.Drawing.Point(32, 207);
            this.labelRemover.Name = "labelRemover";
            this.labelRemover.Size = new System.Drawing.Size(73, 13);
            this.labelRemover.TabIndex = 4;
            this.labelRemover.Text = "Remover Item";
            // 
            // buttonRemover
            // 
            this.buttonRemover.BackgroundImage = global::WinForms.Properties.Resources.icons8_Trash_Can_32;
            this.buttonRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRemover.Enabled = false;
            this.buttonRemover.FlatAppearance.BorderSize = 0;
            this.buttonRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemover.Location = new System.Drawing.Point(12, 203);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(20, 20);
            this.buttonRemover.TabIndex = 3;
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
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
            this.buttonConcluir.Location = new System.Drawing.Point(584, 287);
            this.buttonConcluir.Name = "buttonConcluir";
            this.buttonConcluir.Size = new System.Drawing.Size(85, 60);
            this.buttonConcluir.TabIndex = 12;
            this.buttonConcluir.Text = "&Concluir (F12)";
            this.buttonConcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonConcluir.UseVisualStyleBackColor = false;
            this.buttonConcluir.Click += new System.EventHandler(this.buttonConcluir_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.Transparent;
            this.buttonFechar.FlatAppearance.BorderSize = 0;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFechar.Location = new System.Drawing.Point(493, 287);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 60);
            this.buttonFechar.TabIndex = 11;
            this.buttonFechar.Text = "&Fechar (F11)";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // groupBoxPag
            // 
            this.groupBoxPag.Controls.Add(this.label2);
            this.groupBoxPag.Controls.Add(this.textBoxForma);
            this.groupBoxPag.Controls.Add(this.textBoxValor);
            this.groupBoxPag.Controls.Add(this.labelForma);
            this.groupBoxPag.Controls.Add(this.labelValor);
            this.groupBoxPag.Controls.Add(this.labelValorForma);
            this.groupBoxPag.Controls.Add(this.buttonBuscar);
            this.groupBoxPag.Controls.Add(this.buttonAdd);
            this.groupBoxPag.Controls.Add(this.label5);
            this.groupBoxPag.Controls.Add(this.comboBoxBandeira);
            this.groupBoxPag.Controls.Add(this.comboBoxParcela);
            this.groupBoxPag.Controls.Add(this.label4);
            this.groupBoxPag.Controls.Add(this.labelTipo);
            this.groupBoxPag.Controls.Add(this.comboBoxTipo);
            this.groupBoxPag.Location = new System.Drawing.Point(12, 39);
            this.groupBoxPag.Name = "groupBoxPag";
            this.groupBoxPag.Size = new System.Drawing.Size(657, 63);
            this.groupBoxPag.TabIndex = 1;
            this.groupBoxPag.TabStop = false;
            this.groupBoxPag.Text = "Pagamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Add (F3):";
            // 
            // FormPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 357);
            this.Controls.Add(this.groupBoxPag);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonConcluir);
            this.Controls.Add(this.labelRemover);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.labelTotalPag);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelValorTroco);
            this.Controls.Add(this.labelTroco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelValorCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFormaPag);
            this.KeyPreview = true;
            this.Name = "FormPagamento";
            this.Text = "Formas de pagamentos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPagamento_FormClosed);
            this.Load += new System.EventHandler(this.FormPagamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPagamento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormaPag)).EndInit();
            this.groupBoxPag.ResumeLayout(false);
            this.groupBoxPag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFormaPag;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelValorCompra;
        private System.Windows.Forms.Label labelForma;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxForma;
        private System.Windows.Forms.Label labelValorForma;
        private System.Windows.Forms.Label labelValorTroco;
        private System.Windows.Forms.Label labelTroco;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxBandeira;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdForma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colForma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaquineta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParcelas;
        private System.Windows.Forms.Label labelTotalPag;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelRemover;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonConcluir;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.GroupBox groupBoxPag;
        private System.Windows.Forms.Label label2;
    }
}
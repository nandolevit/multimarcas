namespace WinForms
{
    partial class FormParcelas
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
            this.textBoxParcelas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCorrido = new System.Windows.Forms.RadioButton();
            this.radioButtonFixo = new System.Windows.Forms.RadioButton();
            this.textBoxCorridos = new System.Windows.Forms.TextBox();
            this.labelDia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonParcelas = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.dataGridViewParcelas = new System.Windows.Forms.DataGridView();
            this.colParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxParcelas
            // 
            this.textBoxParcelas.Location = new System.Drawing.Point(12, 26);
            this.textBoxParcelas.Name = "textBoxParcelas";
            this.textBoxParcelas.Size = new System.Drawing.Size(69, 20);
            this.textBoxParcelas.TabIndex = 1;
            this.textBoxParcelas.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parcelas adic.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCorrido);
            this.groupBox1.Controls.Add(this.radioButtonFixo);
            this.groupBox1.Location = new System.Drawing.Point(89, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 42);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de vencimento:";
            // 
            // radioButtonCorrido
            // 
            this.radioButtonCorrido.AutoSize = true;
            this.radioButtonCorrido.Location = new System.Drawing.Point(82, 17);
            this.radioButtonCorrido.Name = "radioButtonCorrido";
            this.radioButtonCorrido.Size = new System.Drawing.Size(86, 17);
            this.radioButtonCorrido.TabIndex = 1;
            this.radioButtonCorrido.Text = "Dias corridos";
            this.radioButtonCorrido.UseVisualStyleBackColor = true;
            // 
            // radioButtonFixo
            // 
            this.radioButtonFixo.AutoSize = true;
            this.radioButtonFixo.Checked = true;
            this.radioButtonFixo.Location = new System.Drawing.Point(6, 17);
            this.radioButtonFixo.Name = "radioButtonFixo";
            this.radioButtonFixo.Size = new System.Drawing.Size(70, 17);
            this.radioButtonFixo.TabIndex = 0;
            this.radioButtonFixo.TabStop = true;
            this.radioButtonFixo.Text = "Dias fixos";
            this.radioButtonFixo.UseVisualStyleBackColor = true;
            this.radioButtonFixo.CheckedChanged += new System.EventHandler(this.radioButtonFixo_CheckedChanged);
            // 
            // textBoxCorridos
            // 
            this.textBoxCorridos.Enabled = false;
            this.textBoxCorridos.Location = new System.Drawing.Point(273, 26);
            this.textBoxCorridos.Name = "textBoxCorridos";
            this.textBoxCorridos.Size = new System.Drawing.Size(40, 20);
            this.textBoxCorridos.TabIndex = 4;
            this.textBoxCorridos.Text = "30";
            // 
            // labelDia
            // 
            this.labelDia.AutoSize = true;
            this.labelDia.Location = new System.Drawing.Point(319, 31);
            this.labelDia.Name = "labelDia";
            this.labelDia.Size = new System.Drawing.Size(29, 13);
            this.labelDia.TabIndex = 5;
            this.labelDia.Text = "dias.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dias corridos...";
            // 
            // buttonParcelas
            // 
            this.buttonParcelas.Location = new System.Drawing.Point(356, 12);
            this.buttonParcelas.Name = "buttonParcelas";
            this.buttonParcelas.Size = new System.Drawing.Size(75, 23);
            this.buttonParcelas.TabIndex = 6;
            this.buttonParcelas.Text = "Parcelas";
            this.buttonParcelas.UseVisualStyleBackColor = true;
            this.buttonParcelas.Click += new System.EventHandler(this.buttonParcelas_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(431, 12);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 8;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(431, 35);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 9;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Enabled = false;
            this.buttonSalvar.Location = new System.Drawing.Point(356, 35);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // dataGridViewParcelas
            // 
            this.dataGridViewParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colParcela,
            this.colVencimento,
            this.colValor,
            this.colDescricao});
            this.dataGridViewParcelas.Location = new System.Drawing.Point(13, 73);
            this.dataGridViewParcelas.Name = "dataGridViewParcelas";
            this.dataGridViewParcelas.Size = new System.Drawing.Size(501, 259);
            this.dataGridViewParcelas.TabIndex = 10;
            // 
            // colParcela
            // 
            this.colParcela.DataPropertyName = "entranumparcela";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "00";
            this.colParcela.DefaultCellStyle = dataGridViewCellStyle1;
            this.colParcela.HeaderText = "Parcelas";
            this.colParcela.Name = "colParcela";
            this.colParcela.Width = 50;
            // 
            // colVencimento
            // 
            this.colVencimento.DataPropertyName = "entradatavenc";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.colVencimento.DefaultCellStyle = dataGridViewCellStyle2;
            this.colVencimento.HeaderText = "Vencimento";
            this.colVencimento.Name = "colVencimento";
            this.colVencimento.Width = 80;
            // 
            // colValor
            // 
            this.colValor.DataPropertyName = "entravalorpago";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            this.colValor.DefaultCellStyle = dataGridViewCellStyle3;
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Width = 80;
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "entraobs";
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Width = 280;
            // 
            // FormParcelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 344);
            this.Controls.Add(this.dataGridViewParcelas);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonParcelas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDia);
            this.Controls.Add(this.textBoxCorridos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxParcelas);
            this.Name = "FormParcelas";
            this.Text = "FormParcelas";
            this.Load += new System.EventHandler(this.FormParcelas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParcelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCorrido;
        private System.Windows.Forms.RadioButton radioButtonFixo;
        private System.Windows.Forms.TextBox textBoxCorridos;
        private System.Windows.Forms.Label labelDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonParcelas;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.DataGridView dataGridViewParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
    }
}
namespace WinForms
{
    partial class FormRelatorioVendaVendedor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxNome = new System.Windows.Forms.ComboBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelDataFinal = new System.Windows.Forms.Label();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.labelInicial = new System.Windows.Forms.Label();
            this.dateTimePickerIni = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewComissao = new System.Windows.Forms.DataGridView();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.textBoxPorcento = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxComissao = new System.Windows.Forms.GroupBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelComissao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.labelQuantValor = new System.Windows.Forms.Label();
            this.labelQuant = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComissao)).BeginInit();
            this.groupBoxComissao.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxNome);
            this.groupBox1.Controls.Add(this.buttonBuscar);
            this.groupBox1.Controls.Add(this.labelDataFinal);
            this.groupBox1.Controls.Add(this.dateTimePickerFinal);
            this.groupBox1.Controls.Add(this.labelInicial);
            this.groupBox1.Controls.Add(this.dateTimePickerIni);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1272, 63);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por período:";
            // 
            // comboBoxNome
            // 
            this.comboBoxNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNome.FormattingEnabled = true;
            this.comboBoxNome.Location = new System.Drawing.Point(521, 31);
            this.comboBoxNome.Name = "comboBoxNome";
            this.comboBoxNome.Size = new System.Drawing.Size(719, 21);
            this.comboBoxNome.TabIndex = 12;
            this.comboBoxNome.SelectedIndexChanged += new System.EventHandler(this.comboBoxNome_SelectedIndexChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Location = new System.Drawing.Point(1246, 32);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelDataFinal
            // 
            this.labelDataFinal.AutoSize = true;
            this.labelDataFinal.Location = new System.Drawing.Point(262, 16);
            this.labelDataFinal.Name = "labelDataFinal";
            this.labelDataFinal.Size = new System.Drawing.Size(58, 13);
            this.labelDataFinal.TabIndex = 3;
            this.labelDataFinal.Text = "Data Final:";
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Location = new System.Drawing.Point(265, 32);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerFinal.TabIndex = 2;
            // 
            // labelInicial
            // 
            this.labelInicial.AutoSize = true;
            this.labelInicial.Location = new System.Drawing.Point(6, 16);
            this.labelInicial.Name = "labelInicial";
            this.labelInicial.Size = new System.Drawing.Size(69, 13);
            this.labelInicial.TabIndex = 1;
            this.labelInicial.Text = "Data Inicical:";
            // 
            // dateTimePickerIni
            // 
            this.dateTimePickerIni.Location = new System.Drawing.Point(9, 32);
            this.dateTimePickerIni.Name = "dateTimePickerIni";
            this.dateTimePickerIni.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerIni.TabIndex = 0;
            // 
            // dataGridViewComissao
            // 
            this.dataGridViewComissao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComissao.Location = new System.Drawing.Point(12, 81);
            this.dataGridViewComissao.Name = "dataGridViewComissao";
            this.dataGridViewComissao.Size = new System.Drawing.Size(1272, 436);
            this.dataGridViewComissao.TabIndex = 3;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(1071, 520);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(110, 16);
            this.labelValor.TabIndex = 4;
            this.labelValor.Text = "Total Vendido:";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.BackColor = System.Drawing.Color.LightGreen;
            this.labelValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorTotal.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotal.ForeColor = System.Drawing.Color.Green;
            this.labelValorTotal.Location = new System.Drawing.Point(1074, 536);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(209, 41);
            this.labelValorTotal.TabIndex = 5;
            this.labelValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPorcento
            // 
            this.textBoxPorcento.Location = new System.Drawing.Point(6, 32);
            this.textBoxPorcento.Name = "textBoxPorcento";
            this.textBoxPorcento.Size = new System.Drawing.Size(70, 20);
            this.textBoxPorcento.TabIndex = 6;
            this.textBoxPorcento.TextChanged += new System.EventHandler(this.textBoxPorcento_TextChanged);
            // 
            // groupBoxComissao
            // 
            this.groupBoxComissao.Controls.Add(this.buttonCalcular);
            this.groupBoxComissao.Controls.Add(this.label3);
            this.groupBoxComissao.Controls.Add(this.labelComissao);
            this.groupBoxComissao.Controls.Add(this.label2);
            this.groupBoxComissao.Controls.Add(this.label1);
            this.groupBoxComissao.Controls.Add(this.textBoxPorcento);
            this.groupBoxComissao.Location = new System.Drawing.Point(11, 523);
            this.groupBoxComissao.Name = "groupBoxComissao";
            this.groupBoxComissao.Size = new System.Drawing.Size(329, 60);
            this.groupBoxComissao.TabIndex = 7;
            this.groupBoxComissao.TabStop = false;
            this.groupBoxComissao.Text = "Calcular Comissão:";
            this.groupBoxComissao.Visible = false;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackgroundImage = global::WinForms.Properties.Resources.money1;
            this.buttonCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCalcular.FlatAppearance.BorderSize = 0;
            this.buttonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalcular.Location = new System.Drawing.Point(293, 34);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(20, 20);
            this.buttonCalcular.TabIndex = 13;
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Comissão Valor:";
            // 
            // labelComissao
            // 
            this.labelComissao.BackColor = System.Drawing.Color.MistyRose;
            this.labelComissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComissao.ForeColor = System.Drawing.Color.Maroon;
            this.labelComissao.Location = new System.Drawing.Point(163, 32);
            this.labelComissao.Name = "labelComissao";
            this.labelComissao.Size = new System.Drawing.Size(124, 20);
            this.labelComissao.TabIndex = 15;
            this.labelComissao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(82, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ex.: 1% = 1,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Porcento (%):";
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(1198, 580);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 8;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.BackColor = System.Drawing.Color.Transparent;
            this.buttonAbrir.Enabled = false;
            this.buttonAbrir.FlatAppearance.BorderSize = 0;
            this.buttonAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbrir.Image = global::WinForms.Properties.Resources.open_file_40455;
            this.buttonAbrir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAbrir.Location = new System.Drawing.Point(346, 523);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(85, 60);
            this.buttonAbrir.TabIndex = 47;
            this.buttonAbrir.Text = "Abrir";
            this.buttonAbrir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAbrir.UseVisualStyleBackColor = false;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // labelQuantValor
            // 
            this.labelQuantValor.BackColor = System.Drawing.Color.Salmon;
            this.labelQuantValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuantValor.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantValor.ForeColor = System.Drawing.Color.Maroon;
            this.labelQuantValor.Location = new System.Drawing.Point(943, 536);
            this.labelQuantValor.Name = "labelQuantValor";
            this.labelQuantValor.Size = new System.Drawing.Size(122, 41);
            this.labelQuantValor.TabIndex = 49;
            this.labelQuantValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQuant
            // 
            this.labelQuant.AutoSize = true;
            this.labelQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuant.Location = new System.Drawing.Point(940, 520);
            this.labelQuant.Name = "labelQuant";
            this.labelQuant.Size = new System.Drawing.Size(107, 16);
            this.labelQuant.TabIndex = 48;
            this.labelQuant.Text = "Total de itens:";
            // 
            // FormRelatorioVendaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 631);
            this.Controls.Add(this.labelQuantValor);
            this.Controls.Add(this.labelQuant);
            this.Controls.Add(this.buttonAbrir);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.groupBoxComissao);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.dataGridViewComissao);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRelatorioVendaVendedor";
            this.Load += new System.EventHandler(this.FormRelatorioVendaVendedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRelatorioVendaVendedor_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComissao)).EndInit();
            this.groupBoxComissao.ResumeLayout(false);
            this.groupBoxComissao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxNome;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelDataFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.Label labelInicial;
        private System.Windows.Forms.DateTimePicker dateTimePickerIni;
        private System.Windows.Forms.DataGridView dataGridViewComissao;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.TextBox textBoxPorcento;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxComissao;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelComissao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.Label labelQuantValor;
        private System.Windows.Forms.Label labelQuant;
    }
}
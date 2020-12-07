namespace WinForms
{
    partial class FormConsultarServico
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
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.checkBoxDetalhada = new System.Windows.Forms.CheckBox();
            this.groupBoxDetalhada = new System.Windows.Forms.GroupBox();
            this.checkBoxGarantia = new System.Windows.Forms.CheckBox();
            this.buttonPesquisarDetalhada = new System.Windows.Forms.Button();
            this.labelAtendente = new System.Windows.Forms.Label();
            this.comboBoxAtendente = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelDataFim = new System.Windows.Forms.Label();
            this.labelDataIni = new System.Windows.Forms.Label();
            this.dateTimePickerFim = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIni = new System.Windows.Forms.DateTimePicker();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.radioButtonOs = new System.Windows.Forms.RadioButton();
            this.labelCountLista = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.dataGridViewConsultar = new System.Windows.Forms.DataGridView();
            this.colEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEletro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBoxDetalhada.SuspendLayout();
            this.groupBoxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdicionar);
            this.groupBox1.Controls.Add(this.buttonSelecionar);
            this.groupBox1.Controls.Add(this.checkBoxDetalhada);
            this.groupBox1.Controls.Add(this.groupBoxDetalhada);
            this.groupBox1.Controls.Add(this.groupBoxTipo);
            this.groupBox1.Controls.Add(this.labelCountLista);
            this.groupBox1.Controls.Add(this.buttonFechar);
            this.groupBox1.Controls.Add(this.dataGridViewConsultar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1362, 598);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Image = global::WinForms.Properties.Resources.add_green;
            this.buttonAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAdicionar.Location = new System.Drawing.Point(748, 19);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(149, 40);
            this.buttonAdicionar.TabIndex = 1;
            this.buttonAdicionar.Text = "&Adicionar Serviço";
            this.buttonAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.ButtonAdicionar_Click);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSelecionar.Location = new System.Drawing.Point(1142, 535);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(108, 40);
            this.buttonSelecionar.TabIndex = 6;
            this.buttonSelecionar.Text = "&Selecionar";
            this.buttonSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // checkBoxDetalhada
            // 
            this.checkBoxDetalhada.AutoSize = true;
            this.checkBoxDetalhada.Location = new System.Drawing.Point(6, 65);
            this.checkBoxDetalhada.Name = "checkBoxDetalhada";
            this.checkBoxDetalhada.Size = new System.Drawing.Size(121, 17);
            this.checkBoxDetalhada.TabIndex = 2;
            this.checkBoxDetalhada.Text = "Pesquisa Detalhada";
            this.checkBoxDetalhada.UseVisualStyleBackColor = true;
            this.checkBoxDetalhada.CheckedChanged += new System.EventHandler(this.checkBoxDetalhada_CheckedChanged);
            // 
            // groupBoxDetalhada
            // 
            this.groupBoxDetalhada.Controls.Add(this.checkBoxGarantia);
            this.groupBoxDetalhada.Controls.Add(this.buttonPesquisarDetalhada);
            this.groupBoxDetalhada.Controls.Add(this.labelAtendente);
            this.groupBoxDetalhada.Controls.Add(this.comboBoxAtendente);
            this.groupBoxDetalhada.Controls.Add(this.labelStatus);
            this.groupBoxDetalhada.Controls.Add(this.comboBoxStatus);
            this.groupBoxDetalhada.Controls.Add(this.labelDataFim);
            this.groupBoxDetalhada.Controls.Add(this.labelDataIni);
            this.groupBoxDetalhada.Controls.Add(this.dateTimePickerFim);
            this.groupBoxDetalhada.Controls.Add(this.dateTimePickerIni);
            this.groupBoxDetalhada.Enabled = false;
            this.groupBoxDetalhada.Location = new System.Drawing.Point(6, 85);
            this.groupBoxDetalhada.Name = "groupBoxDetalhada";
            this.groupBoxDetalhada.Size = new System.Drawing.Size(1156, 55);
            this.groupBoxDetalhada.TabIndex = 3;
            this.groupBoxDetalhada.TabStop = false;
            this.groupBoxDetalhada.Text = "Detalhes:";
            // 
            // checkBoxGarantia
            // 
            this.checkBoxGarantia.AutoSize = true;
            this.checkBoxGarantia.Location = new System.Drawing.Point(1052, 29);
            this.checkBoxGarantia.Name = "checkBoxGarantia";
            this.checkBoxGarantia.Size = new System.Drawing.Size(66, 17);
            this.checkBoxGarantia.TabIndex = 8;
            this.checkBoxGarantia.Text = "Garantia";
            this.checkBoxGarantia.UseVisualStyleBackColor = true;
            this.checkBoxGarantia.CheckedChanged += new System.EventHandler(this.checkBoxGarantia_CheckedChanged);
            // 
            // buttonPesquisarDetalhada
            // 
            this.buttonPesquisarDetalhada.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonPesquisarDetalhada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPesquisarDetalhada.FlatAppearance.BorderSize = 0;
            this.buttonPesquisarDetalhada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisarDetalhada.Location = new System.Drawing.Point(1124, 26);
            this.buttonPesquisarDetalhada.Name = "buttonPesquisarDetalhada";
            this.buttonPesquisarDetalhada.Size = new System.Drawing.Size(20, 20);
            this.buttonPesquisarDetalhada.TabIndex = 9;
            this.buttonPesquisarDetalhada.UseVisualStyleBackColor = true;
            this.buttonPesquisarDetalhada.Click += new System.EventHandler(this.buttonPesquisarDetalhada_Click);
            // 
            // labelAtendente
            // 
            this.labelAtendente.AutoSize = true;
            this.labelAtendente.Location = new System.Drawing.Point(701, 14);
            this.labelAtendente.Name = "labelAtendente";
            this.labelAtendente.Size = new System.Drawing.Size(59, 13);
            this.labelAtendente.TabIndex = 6;
            this.labelAtendente.Text = "Atendente:";
            // 
            // comboBoxAtendente
            // 
            this.comboBoxAtendente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAtendente.FormattingEnabled = true;
            this.comboBoxAtendente.Location = new System.Drawing.Point(701, 27);
            this.comboBoxAtendente.Name = "comboBoxAtendente";
            this.comboBoxAtendente.Size = new System.Drawing.Size(344, 21);
            this.comboBoxAtendente.TabIndex = 7;
            this.comboBoxAtendente.SelectedIndexChanged += new System.EventHandler(this.comboBoxAtendente_SelectedIndexChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(510, 14);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(510, 27);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(185, 21);
            this.comboBoxStatus.TabIndex = 5;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // labelDataFim
            // 
            this.labelDataFim.AutoSize = true;
            this.labelDataFim.Location = new System.Drawing.Point(265, 14);
            this.labelDataFim.Name = "labelDataFim";
            this.labelDataFim.Size = new System.Drawing.Size(58, 13);
            this.labelDataFim.TabIndex = 2;
            this.labelDataFim.Text = "Data Final:";
            // 
            // labelDataIni
            // 
            this.labelDataIni.AutoSize = true;
            this.labelDataIni.Location = new System.Drawing.Point(20, 14);
            this.labelDataIni.Name = "labelDataIni";
            this.labelDataIni.Size = new System.Drawing.Size(63, 13);
            this.labelDataIni.TabIndex = 0;
            this.labelDataIni.Text = "Data Inicial:";
            // 
            // dateTimePickerFim
            // 
            this.dateTimePickerFim.Location = new System.Drawing.Point(265, 27);
            this.dateTimePickerFim.Name = "dateTimePickerFim";
            this.dateTimePickerFim.Size = new System.Drawing.Size(239, 20);
            this.dateTimePickerFim.TabIndex = 3;
            this.dateTimePickerFim.ValueChanged += new System.EventHandler(this.dateTimePickerFim_ValueChanged);
            // 
            // dateTimePickerIni
            // 
            this.dateTimePickerIni.Location = new System.Drawing.Point(20, 27);
            this.dateTimePickerIni.Name = "dateTimePickerIni";
            this.dateTimePickerIni.Size = new System.Drawing.Size(239, 20);
            this.dateTimePickerIni.TabIndex = 1;
            this.dateTimePickerIni.ValueChanged += new System.EventHandler(this.dateTimePickerIni_ValueChanged);
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.textBoxPesquisar);
            this.groupBoxTipo.Controls.Add(this.radioButtonNome);
            this.groupBoxTipo.Controls.Add(this.buttonPesquisar);
            this.groupBoxTipo.Controls.Add(this.radioButtonOs);
            this.groupBoxTipo.Location = new System.Drawing.Point(6, 19);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(736, 40);
            this.groupBoxTipo.TabIndex = 0;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Pesquisar por (Enter):";
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(129, 14);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(566, 20);
            this.textBoxPesquisar.TabIndex = 2;
            this.textBoxPesquisar.TextChanged += new System.EventHandler(this.textBoxPesquisar_TextChanged);
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.Checked = true;
            this.radioButtonNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNome.Location = new System.Drawing.Point(59, 19);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(64, 17);
            this.radioButtonNome.TabIndex = 1;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Cliente";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            this.radioButtonNome.CheckedChanged += new System.EventHandler(this.radioButtonNome_CheckedChanged);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPesquisar.FlatAppearance.BorderSize = 0;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Location = new System.Drawing.Point(701, 14);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(20, 20);
            this.buttonPesquisar.TabIndex = 3;
            this.buttonPesquisar.TabStop = false;
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // radioButtonOs
            // 
            this.radioButtonOs.AutoSize = true;
            this.radioButtonOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOs.Location = new System.Drawing.Point(7, 19);
            this.radioButtonOs.Name = "radioButtonOs";
            this.radioButtonOs.Size = new System.Drawing.Size(46, 17);
            this.radioButtonOs.TabIndex = 0;
            this.radioButtonOs.Text = "OS:";
            this.radioButtonOs.UseVisualStyleBackColor = true;
            this.radioButtonOs.CheckedChanged += new System.EventHandler(this.radioButtonOs_CheckedChanged);
            // 
            // labelCountLista
            // 
            this.labelCountLista.AutoSize = true;
            this.labelCountLista.Location = new System.Drawing.Point(12, 566);
            this.labelCountLista.Name = "labelCountLista";
            this.labelCountLista.Size = new System.Drawing.Size(71, 13);
            this.labelCountLista.TabIndex = 5;
            this.labelCountLista.Text = "Itens listados:";
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(1256, 534);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 7;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // dataGridViewConsultar
            // 
            this.dataGridViewConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEntrada,
            this.colOs,
            this.colStatus,
            this.colEletro,
            this.colCliente,
            this.colTecnico,
            this.colAtendente});
            this.dataGridViewConsultar.Location = new System.Drawing.Point(3, 153);
            this.dataGridViewConsultar.Name = "dataGridViewConsultar";
            this.dataGridViewConsultar.RowHeadersVisible = false;
            this.dataGridViewConsultar.Size = new System.Drawing.Size(1338, 375);
            this.dataGridViewConsultar.TabIndex = 4;
            this.dataGridViewConsultar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsultar_CellDoubleClick);
            // 
            // colEntrada
            // 
            this.colEntrada.DataPropertyName = "Entrada";
            this.colEntrada.HeaderText = "Entrada:";
            this.colEntrada.Name = "colEntrada";
            // 
            // colOs
            // 
            this.colOs.DataPropertyName = "Os";
            this.colOs.HeaderText = "OS:";
            this.colOs.Name = "colOs";
            this.colOs.Width = 50;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status:";
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 175;
            // 
            // colEletro
            // 
            this.colEletro.DataPropertyName = "Eletro";
            this.colEletro.HeaderText = "Eletro:";
            this.colEletro.Name = "colEletro";
            this.colEletro.Width = 500;
            // 
            // colCliente
            // 
            this.colCliente.DataPropertyName = "Cliente";
            this.colCliente.HeaderText = "Cliente:";
            this.colCliente.Name = "colCliente";
            this.colCliente.Width = 275;
            // 
            // colTecnico
            // 
            this.colTecnico.DataPropertyName = "Tecnico";
            this.colTecnico.HeaderText = "Técnico:";
            this.colTecnico.Name = "colTecnico";
            this.colTecnico.Visible = false;
            this.colTecnico.Width = 200;
            // 
            // colAtendente
            // 
            this.colAtendente.DataPropertyName = "Atendente";
            this.colAtendente.HeaderText = "Atendente:";
            this.colAtendente.Name = "colAtendente";
            this.colAtendente.Width = 200;
            // 
            // FormConsultarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 598);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "FormConsultarServico";
            this.Load += new System.EventHandler(this.FormConsultarServico_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultarServico_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDetalhada.ResumeLayout(false);
            this.groupBoxDetalhada.PerformLayout();
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewConsultar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Label labelCountLista;
        private System.Windows.Forms.GroupBox groupBoxDetalhada;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelDataFim;
        private System.Windows.Forms.Label labelDataIni;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
        private System.Windows.Forms.DateTimePicker dateTimePickerIni;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.RadioButton radioButtonOs;
        private System.Windows.Forms.CheckBox checkBoxDetalhada;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Label labelAtendente;
        private System.Windows.Forms.ComboBox comboBoxAtendente;
        private System.Windows.Forms.Button buttonPesquisarDetalhada;
        private System.Windows.Forms.CheckBox checkBoxGarantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEletro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtendente;
        private System.Windows.Forms.Button buttonAdicionar;
    }
}
namespace WinForms
{
    partial class FormEntradaSaida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewEntradaSaida = new System.Windows.Forms.DataGridView();
            this.colConfirmado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntSai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelEntrada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSomaSaida = new System.Windows.Forms.Label();
            this.labelSomaEntrada = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelSomaSaldo = new System.Windows.Forms.Label();
            this.groupBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.buttonCategoriaBuscar = new System.Windows.Forms.Button();
            this.labelCategoriaDescricao = new System.Windows.Forms.Label();
            this.textBoxCategoriaCod = new System.Windows.Forms.TextBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelTipo = new System.Windows.Forms.Label();
            this.comboBoxEntSai = new System.Windows.Forms.ComboBox();
            this.labelDataFim = new System.Windows.Forms.Label();
            this.labelDataIni = new System.Windows.Forms.Label();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicial = new System.Windows.Forms.DateTimePicker();
            this.groupBoxLanc = new System.Windows.Forms.GroupBox();
            this.radioButtonAmbos = new System.Windows.Forms.RadioButton();
            this.radioButtonNotConfirmado = new System.Windows.Forms.RadioButton();
            this.radioButtonConfirmado = new System.Windows.Forms.RadioButton();
            this.labelItem = new System.Windows.Forms.Label();
            this.labelTotalItem = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonAbrir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntradaSaida)).BeginInit();
            this.groupBoxPesquisa.SuspendLayout();
            this.groupBoxLanc.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEntradaSaida
            // 
            this.dataGridViewEntradaSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntradaSaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConfirmado,
            this.colEntSai,
            this.colVenc,
            this.colValor,
            this.colParcelas,
            this.colDescricao,
            this.colObs});
            this.dataGridViewEntradaSaida.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEntradaSaida.Name = "dataGridViewEntradaSaida";
            this.dataGridViewEntradaSaida.RowHeadersVisible = false;
            this.dataGridViewEntradaSaida.Size = new System.Drawing.Size(1299, 407);
            this.dataGridViewEntradaSaida.TabIndex = 0;
            this.dataGridViewEntradaSaida.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEntradaSaida_CellClick);
            this.dataGridViewEntradaSaida.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewEntradaSaida_CellFormatting);
            this.dataGridViewEntradaSaida.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEntradaSaida_RowEnter);
            // 
            // colConfirmado
            // 
            this.colConfirmado.DataPropertyName = "strConfirmado";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colConfirmado.DefaultCellStyle = dataGridViewCellStyle1;
            this.colConfirmado.HeaderText = "Conf.";
            this.colConfirmado.Name = "colConfirmado";
            this.colConfirmado.Width = 40;
            // 
            // colEntSai
            // 
            this.colEntSai.DataPropertyName = "strEntradaSaida";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEntSai.DefaultCellStyle = dataGridViewCellStyle2;
            this.colEntSai.HeaderText = "E/S";
            this.colEntSai.Name = "colEntSai";
            this.colEntSai.Width = 30;
            // 
            // colVenc
            // 
            this.colVenc.DataPropertyName = "datapagamento";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colVenc.DefaultCellStyle = dataGridViewCellStyle3;
            this.colVenc.HeaderText = "Pagamento";
            this.colVenc.Name = "colVenc";
            this.colVenc.Width = 80;
            // 
            // colValor
            // 
            this.colValor.DataPropertyName = "valor";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.colValor.DefaultCellStyle = dataGridViewCellStyle4;
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Width = 150;
            // 
            // colParcelas
            // 
            this.colParcelas.DataPropertyName = "parcelas";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colParcelas.DefaultCellStyle = dataGridViewCellStyle5;
            this.colParcelas.HeaderText = "Parcelas";
            this.colParcelas.Name = "colParcelas";
            this.colParcelas.Width = 60;
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "categoria";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDescricao.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDescricao.HeaderText = "Categoria";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Width = 300;
            // 
            // colObs
            // 
            this.colObs.DataPropertyName = "obs";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colObs.DefaultCellStyle = dataGridViewCellStyle7;
            this.colObs.HeaderText = "Observações";
            this.colObs.Name = "colObs";
            this.colObs.Width = 600;
            // 
            // labelEntrada
            // 
            this.labelEntrada.AutoSize = true;
            this.labelEntrada.Location = new System.Drawing.Point(17, 422);
            this.labelEntrada.Name = "labelEntrada";
            this.labelEntrada.Size = new System.Drawing.Size(96, 13);
            this.labelEntrada.TabIndex = 1;
            this.labelEntrada.Text = "Soma de entradas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Soma de saídas:";
            // 
            // labelSomaSaida
            // 
            this.labelSomaSaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSomaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSomaSaida.ForeColor = System.Drawing.Color.Red;
            this.labelSomaSaida.Location = new System.Drawing.Point(180, 429);
            this.labelSomaSaida.Name = "labelSomaSaida";
            this.labelSomaSaida.Size = new System.Drawing.Size(162, 40);
            this.labelSomaSaida.TabIndex = 4;
            this.labelSomaSaida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSomaEntrada
            // 
            this.labelSomaEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSomaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSomaEntrada.ForeColor = System.Drawing.Color.Green;
            this.labelSomaEntrada.Location = new System.Drawing.Point(12, 429);
            this.labelSomaEntrada.Name = "labelSomaEntrada";
            this.labelSomaEntrada.Size = new System.Drawing.Size(162, 40);
            this.labelSomaEntrada.TabIndex = 2;
            this.labelSomaEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(353, 422);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(93, 13);
            this.labelSaldo.TabIndex = 5;
            this.labelSaldo.Text = "Saldo da listagem:";
            // 
            // labelSomaSaldo
            // 
            this.labelSomaSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSomaSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSomaSaldo.ForeColor = System.Drawing.Color.Black;
            this.labelSomaSaldo.Location = new System.Drawing.Point(348, 429);
            this.labelSomaSaldo.Name = "labelSomaSaldo";
            this.labelSomaSaldo.Size = new System.Drawing.Size(162, 40);
            this.labelSomaSaldo.TabIndex = 6;
            this.labelSomaSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxPesquisa
            // 
            this.groupBoxPesquisa.Controls.Add(this.buttonCategoriaBuscar);
            this.groupBoxPesquisa.Controls.Add(this.labelCategoriaDescricao);
            this.groupBoxPesquisa.Controls.Add(this.textBoxCategoriaCod);
            this.groupBoxPesquisa.Controls.Add(this.labelCategoria);
            this.groupBoxPesquisa.Controls.Add(this.buttonBuscar);
            this.groupBoxPesquisa.Controls.Add(this.labelTipo);
            this.groupBoxPesquisa.Controls.Add(this.comboBoxEntSai);
            this.groupBoxPesquisa.Controls.Add(this.labelDataFim);
            this.groupBoxPesquisa.Controls.Add(this.labelDataIni);
            this.groupBoxPesquisa.Controls.Add(this.dateTimePickerFinal);
            this.groupBoxPesquisa.Controls.Add(this.dateTimePickerInicial);
            this.groupBoxPesquisa.Location = new System.Drawing.Point(13, 475);
            this.groupBoxPesquisa.Name = "groupBoxPesquisa";
            this.groupBoxPesquisa.Size = new System.Drawing.Size(959, 60);
            this.groupBoxPesquisa.TabIndex = 11;
            this.groupBoxPesquisa.TabStop = false;
            this.groupBoxPesquisa.Text = "Informe os dados para a busca dos lançamentos:";
            // 
            // buttonCategoriaBuscar
            // 
            this.buttonCategoriaBuscar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonCategoriaBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCategoriaBuscar.FlatAppearance.BorderSize = 0;
            this.buttonCategoriaBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategoriaBuscar.Location = new System.Drawing.Point(455, 30);
            this.buttonCategoriaBuscar.Name = "buttonCategoriaBuscar";
            this.buttonCategoriaBuscar.Size = new System.Drawing.Size(20, 20);
            this.buttonCategoriaBuscar.TabIndex = 7;
            this.buttonCategoriaBuscar.UseVisualStyleBackColor = true;
            this.buttonCategoriaBuscar.Click += new System.EventHandler(this.buttonCategoriaBuscar_Click);
            // 
            // labelCategoriaDescricao
            // 
            this.labelCategoriaDescricao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCategoriaDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoriaDescricao.Location = new System.Drawing.Point(481, 29);
            this.labelCategoriaDescricao.Name = "labelCategoriaDescricao";
            this.labelCategoriaDescricao.Size = new System.Drawing.Size(441, 21);
            this.labelCategoriaDescricao.TabIndex = 9;
            this.labelCategoriaDescricao.Text = "Todas as categorias";
            this.labelCategoriaDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCategoriaCod
            // 
            this.textBoxCategoriaCod.Location = new System.Drawing.Point(421, 30);
            this.textBoxCategoriaCod.Name = "textBoxCategoriaCod";
            this.textBoxCategoriaCod.Size = new System.Drawing.Size(30, 20);
            this.textBoxCategoriaCod.TabIndex = 6;
            this.textBoxCategoriaCod.Text = "000";
            this.textBoxCategoriaCod.TextChanged += new System.EventHandler(this.textBoxCategoriaCod_TextChanged);
            this.textBoxCategoriaCod.Leave += new System.EventHandler(this.textBoxCategoriaCod_Leave);
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(481, 16);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(55, 13);
            this.labelCategoria.TabIndex = 8;
            this.labelCategoria.Text = "Categoria:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Location = new System.Drawing.Point(928, 29);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscar.TabIndex = 10;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(247, 13);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(31, 13);
            this.labelTipo.TabIndex = 4;
            this.labelTipo.Text = "&Tipo:";
            // 
            // comboBoxEntSai
            // 
            this.comboBoxEntSai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEntSai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEntSai.FormattingEnabled = true;
            this.comboBoxEntSai.Items.AddRange(new object[] {
            "Entradas/Saídas",
            "Entradas",
            "Saídas"});
            this.comboBoxEntSai.Location = new System.Drawing.Point(247, 29);
            this.comboBoxEntSai.Name = "comboBoxEntSai";
            this.comboBoxEntSai.Size = new System.Drawing.Size(168, 21);
            this.comboBoxEntSai.TabIndex = 5;
            this.comboBoxEntSai.SelectedIndexChanged += new System.EventHandler(this.comboBoxEntSai_SelectedIndexChanged);
            // 
            // labelDataFim
            // 
            this.labelDataFim.AutoSize = true;
            this.labelDataFim.Location = new System.Drawing.Point(133, 16);
            this.labelDataFim.Name = "labelDataFim";
            this.labelDataFim.Size = new System.Drawing.Size(55, 13);
            this.labelDataFim.TabIndex = 2;
            this.labelDataFim.Text = "Data fi&nal;";
            // 
            // labelDataIni
            // 
            this.labelDataIni.AutoSize = true;
            this.labelDataIni.Location = new System.Drawing.Point(16, 16);
            this.labelDataIni.Name = "labelDataIni";
            this.labelDataIni.Size = new System.Drawing.Size(62, 13);
            this.labelDataIni.TabIndex = 0;
            this.labelDataIni.Text = "Data &inicial:";
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinal.Location = new System.Drawing.Point(133, 29);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(108, 20);
            this.dateTimePickerFinal.TabIndex = 3;
            // 
            // dateTimePickerInicial
            // 
            this.dateTimePickerInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicial.Location = new System.Drawing.Point(16, 29);
            this.dateTimePickerInicial.Name = "dateTimePickerInicial";
            this.dateTimePickerInicial.Size = new System.Drawing.Size(108, 20);
            this.dateTimePickerInicial.TabIndex = 1;
            // 
            // groupBoxLanc
            // 
            this.groupBoxLanc.Controls.Add(this.radioButtonAmbos);
            this.groupBoxLanc.Controls.Add(this.radioButtonNotConfirmado);
            this.groupBoxLanc.Controls.Add(this.radioButtonConfirmado);
            this.groupBoxLanc.Location = new System.Drawing.Point(13, 541);
            this.groupBoxLanc.Name = "groupBoxLanc";
            this.groupBoxLanc.Size = new System.Drawing.Size(295, 42);
            this.groupBoxLanc.TabIndex = 12;
            this.groupBoxLanc.TabStop = false;
            this.groupBoxLanc.Text = "Lançamentos:";
            // 
            // radioButtonAmbos
            // 
            this.radioButtonAmbos.AutoSize = true;
            this.radioButtonAmbos.Checked = true;
            this.radioButtonAmbos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAmbos.Location = new System.Drawing.Point(227, 17);
            this.radioButtonAmbos.Name = "radioButtonAmbos";
            this.radioButtonAmbos.Size = new System.Drawing.Size(62, 17);
            this.radioButtonAmbos.TabIndex = 2;
            this.radioButtonAmbos.TabStop = true;
            this.radioButtonAmbos.Text = "Am&bos";
            this.radioButtonAmbos.UseVisualStyleBackColor = true;
            // 
            // radioButtonNotConfirmado
            // 
            this.radioButtonNotConfirmado.AutoSize = true;
            this.radioButtonNotConfirmado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNotConfirmado.Location = new System.Drawing.Point(106, 17);
            this.radioButtonNotConfirmado.Name = "radioButtonNotConfirmado";
            this.radioButtonNotConfirmado.Size = new System.Drawing.Size(120, 17);
            this.radioButtonNotConfirmado.TabIndex = 1;
            this.radioButtonNotConfirmado.Text = "Não c&onfirmados";
            this.radioButtonNotConfirmado.UseVisualStyleBackColor = true;
            // 
            // radioButtonConfirmado
            // 
            this.radioButtonConfirmado.AutoSize = true;
            this.radioButtonConfirmado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonConfirmado.Location = new System.Drawing.Point(7, 17);
            this.radioButtonConfirmado.Name = "radioButtonConfirmado";
            this.radioButtonConfirmado.Size = new System.Drawing.Size(94, 17);
            this.radioButtonConfirmado.TabIndex = 0;
            this.radioButtonConfirmado.Text = "Confir&mados";
            this.radioButtonConfirmado.UseVisualStyleBackColor = true;
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(316, 553);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(112, 13);
            this.labelItem.TabIndex = 13;
            this.labelItem.Text = "Total de itens listados:";
            // 
            // labelTotalItem
            // 
            this.labelTotalItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalItem.ForeColor = System.Drawing.Color.Black;
            this.labelTotalItem.Location = new System.Drawing.Point(314, 560);
            this.labelTotalItem.Name = "labelTotalItem";
            this.labelTotalItem.Size = new System.Drawing.Size(125, 23);
            this.labelTotalItem.TabIndex = 14;
            this.labelTotalItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(1226, 543);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 15;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Enabled = false;
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonExcluir.Location = new System.Drawing.Point(1211, 429);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(100, 40);
            this.buttonExcluir.TabIndex = 10;
            this.buttonExcluir.Text = "&Cancelar";
            this.buttonExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovo.Image = global::WinForms.Properties.Resources.add_blue;
            this.buttonNovo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonNovo.Location = new System.Drawing.Point(893, 429);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(100, 40);
            this.buttonNovo.TabIndex = 7;
            this.buttonNovo.Text = "&Novo";
            this.buttonNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Enabled = false;
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonConfirmar.Location = new System.Drawing.Point(1105, 429);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(100, 40);
            this.buttonConfirmar.TabIndex = 8;
            this.buttonConfirmar.Text = "&Confirmar";
            this.buttonConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Enabled = false;
            this.buttonAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbrir.Image = global::WinForms.Properties.Resources.abrir;
            this.buttonAbrir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAbrir.Location = new System.Drawing.Point(999, 429);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(100, 40);
            this.buttonAbrir.TabIndex = 9;
            this.buttonAbrir.Text = "&Abrir";
            this.buttonAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // FormEntradaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 595);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.groupBoxLanc);
            this.Controls.Add(this.labelTotalItem);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.groupBoxPesquisa);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.buttonAbrir);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.labelSomaSaldo);
            this.Controls.Add(this.labelEntrada);
            this.Controls.Add(this.labelSomaEntrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSomaSaida);
            this.Controls.Add(this.dataGridViewEntradaSaida);
            this.KeyPreview = true;
            this.Name = "FormEntradaSaida";
            this.Text = "Entradas/Saídas";
            this.Load += new System.EventHandler(this.FormEntradaSaida_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEntradaSaida_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntradaSaida)).EndInit();
            this.groupBoxPesquisa.ResumeLayout(false);
            this.groupBoxPesquisa.PerformLayout();
            this.groupBoxLanc.ResumeLayout(false);
            this.groupBoxLanc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEntradaSaida;
        private System.Windows.Forms.Label labelEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSomaSaida;
        private System.Windows.Forms.Label labelSomaEntrada;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label labelSomaSaldo;
        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.GroupBox groupBoxPesquisa;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicial;
        private System.Windows.Forms.Label labelDataIni;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.Label labelDataFim;
        private System.Windows.Forms.ComboBox comboBoxEntSai;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.GroupBox groupBoxLanc;
        private System.Windows.Forms.RadioButton radioButtonAmbos;
        private System.Windows.Forms.RadioButton radioButtonNotConfirmado;
        private System.Windows.Forms.RadioButton radioButtonConfirmado;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label labelTotalItem;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonCategoriaBuscar;
        private System.Windows.Forms.Label labelCategoriaDescricao;
        private System.Windows.Forms.TextBox textBoxCategoriaCod;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntSai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObs;
    }
}
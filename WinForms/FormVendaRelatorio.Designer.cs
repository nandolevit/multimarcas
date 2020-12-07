namespace WinForms
{
    partial class FormVendaRelatorio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewVendaPeriodo = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDinheiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonAberta = new System.Windows.Forms.RadioButton();
            this.radioButtonCancelada = new System.Windows.Forms.RadioButton();
            this.radioButtonConcluida = new System.Windows.Forms.RadioButton();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelDataFinal = new System.Windows.Forms.Label();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.labelInicial = new System.Windows.Forms.Label();
            this.dateTimePickerIni = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.labelValorDebito = new System.Windows.Forms.Label();
            this.labelValorCredito = new System.Windows.Forms.Label();
            this.labelValorCheque = new System.Windows.Forms.Label();
            this.labelValorOutras = new System.Windows.Forms.Label();
            this.labelValorDinheiro = new System.Windows.Forms.Label();
            this.labelValorDeposito = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendaPeriodo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVendaPeriodo
            // 
            this.dataGridViewVendaPeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendaPeriodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDat,
            this.colCliente,
            this.colDinheiro,
            this.colDebito,
            this.colCredito,
            this.colCheque,
            this.colDeposito,
            this.colOutras,
            this.colTotal,
            this.colTurno});
            this.dataGridViewVendaPeriodo.Location = new System.Drawing.Point(13, 94);
            this.dataGridViewVendaPeriodo.Name = "dataGridViewVendaPeriodo";
            this.dataGridViewVendaPeriodo.RowHeadersVisible = false;
            this.dataGridViewVendaPeriodo.RowHeadersWidth = 20;
            this.dataGridViewVendaPeriodo.Size = new System.Drawing.Size(1161, 388);
            this.dataGridViewVendaPeriodo.TabIndex = 0;
            this.dataGridViewVendaPeriodo.DoubleClick += new System.EventHandler(this.dataGridViewVendaPeriodo_DoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "ID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "000000";
            dataGridViewCellStyle1.NullValue = null;
            this.colId.DefaultCellStyle = dataGridViewCellStyle1;
            this.colId.HeaderText = "ID:";
            this.colId.Name = "colId";
            this.colId.Width = 70;
            // 
            // colDat
            // 
            this.colDat.DataPropertyName = "Data";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDat.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDat.HeaderText = "Data:";
            this.colDat.Name = "colDat";
            this.colDat.Width = 80;
            // 
            // colCliente
            // 
            this.colCliente.DataPropertyName = "Cliente";
            this.colCliente.HeaderText = "Cliente:";
            this.colCliente.Name = "colCliente";
            this.colCliente.Width = 320;
            // 
            // colDinheiro
            // 
            this.colDinheiro.DataPropertyName = "Dinheiro";
            dataGridViewCellStyle3.Format = "C2";
            this.colDinheiro.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDinheiro.HeaderText = "Dinheiro:";
            this.colDinheiro.Name = "colDinheiro";
            this.colDinheiro.Width = 85;
            // 
            // colDebito
            // 
            this.colDebito.DataPropertyName = "Debito";
            dataGridViewCellStyle4.Format = "C2";
            this.colDebito.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDebito.HeaderText = "Débito:";
            this.colDebito.Name = "colDebito";
            this.colDebito.Width = 85;
            // 
            // colCredito
            // 
            this.colCredito.DataPropertyName = "Credito";
            dataGridViewCellStyle5.Format = "C2";
            this.colCredito.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCredito.HeaderText = "Crédito:";
            this.colCredito.Name = "colCredito";
            this.colCredito.Width = 85;
            // 
            // colCheque
            // 
            this.colCheque.DataPropertyName = "Cheque";
            dataGridViewCellStyle6.Format = "C2";
            this.colCheque.DefaultCellStyle = dataGridViewCellStyle6;
            this.colCheque.HeaderText = "Cheque:";
            this.colCheque.Name = "colCheque";
            this.colCheque.Width = 85;
            // 
            // colDeposito
            // 
            this.colDeposito.DataPropertyName = "Deposito";
            dataGridViewCellStyle7.Format = "C2";
            this.colDeposito.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDeposito.HeaderText = "Depósito:";
            this.colDeposito.Name = "colDeposito";
            this.colDeposito.Width = 85;
            // 
            // colOutras
            // 
            this.colOutras.DataPropertyName = "Outras";
            dataGridViewCellStyle8.Format = "C2";
            this.colOutras.DefaultCellStyle = dataGridViewCellStyle8;
            this.colOutras.HeaderText = "Outras:";
            this.colOutras.Name = "colOutras";
            this.colOutras.Width = 85;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "Total";
            dataGridViewCellStyle9.Format = "C2";
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle9;
            this.colTotal.HeaderText = "Total:";
            this.colTotal.Name = "colTotal";
            // 
            // colTurno
            // 
            this.colTurno.DataPropertyName = "Turno";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "00";
            dataGridViewCellStyle10.NullValue = null;
            this.colTurno.DefaultCellStyle = dataGridViewCellStyle10;
            this.colTurno.HeaderText = "Turno:";
            this.colTurno.Name = "colTurno";
            this.colTurno.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.comboBoxTurno);
            this.groupBox1.Controls.Add(this.buttonBuscar);
            this.groupBox1.Controls.Add(this.labelDataFinal);
            this.groupBox1.Controls.Add(this.dateTimePickerFinal);
            this.groupBox1.Controls.Add(this.labelInicial);
            this.groupBox1.Controls.Add(this.dateTimePickerIni);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1162, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por período:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonAberta);
            this.groupBox2.Controls.Add(this.radioButtonCancelada);
            this.groupBox2.Controls.Add(this.radioButtonConcluida);
            this.groupBox2.Location = new System.Drawing.Point(715, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 37);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status da venda:";
            // 
            // radioButtonAberta
            // 
            this.radioButtonAberta.AutoSize = true;
            this.radioButtonAberta.Location = new System.Drawing.Point(9, 13);
            this.radioButtonAberta.Name = "radioButtonAberta";
            this.radioButtonAberta.Size = new System.Drawing.Size(77, 17);
            this.radioButtonAberta.TabIndex = 2;
            this.radioButtonAberta.Text = "Orçamento";
            this.radioButtonAberta.UseVisualStyleBackColor = true;
            this.radioButtonAberta.CheckedChanged += new System.EventHandler(this.radioButtonAberta_CheckedChanged);
            // 
            // radioButtonCancelada
            // 
            this.radioButtonCancelada.AutoSize = true;
            this.radioButtonCancelada.Location = new System.Drawing.Point(97, 13);
            this.radioButtonCancelada.Name = "radioButtonCancelada";
            this.radioButtonCancelada.Size = new System.Drawing.Size(76, 17);
            this.radioButtonCancelada.TabIndex = 1;
            this.radioButtonCancelada.Text = "Cancelada";
            this.radioButtonCancelada.UseVisualStyleBackColor = true;
            this.radioButtonCancelada.CheckedChanged += new System.EventHandler(this.radioButtonCancelada_CheckedChanged);
            // 
            // radioButtonConcluida
            // 
            this.radioButtonConcluida.AutoSize = true;
            this.radioButtonConcluida.Checked = true;
            this.radioButtonConcluida.Location = new System.Drawing.Point(189, 13);
            this.radioButtonConcluida.Name = "radioButtonConcluida";
            this.radioButtonConcluida.Size = new System.Drawing.Size(74, 17);
            this.radioButtonConcluida.TabIndex = 0;
            this.radioButtonConcluida.TabStop = true;
            this.radioButtonConcluida.Text = "Concluída";
            this.radioButtonConcluida.UseVisualStyleBackColor = true;
            this.radioButtonConcluida.CheckedChanged += new System.EventHandler(this.radioButtonConcluida_CheckedChanged);
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.Items.AddRange(new object[] {
            "Todos Turnos",
            "Turno 1",
            "Turno 2",
            "Turno 3"});
            this.comboBoxTurno.Location = new System.Drawing.Point(564, 35);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTurno.TabIndex = 12;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Location = new System.Drawing.Point(1022, 23);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(34, 34);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelDataFinal
            // 
            this.labelDataFinal.AutoSize = true;
            this.labelDataFinal.Location = new System.Drawing.Point(285, 20);
            this.labelDataFinal.Name = "labelDataFinal";
            this.labelDataFinal.Size = new System.Drawing.Size(58, 13);
            this.labelDataFinal.TabIndex = 3;
            this.labelDataFinal.Text = "Data Final:";
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Location = new System.Drawing.Point(288, 36);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerFinal.TabIndex = 2;
            // 
            // labelInicial
            // 
            this.labelInicial.AutoSize = true;
            this.labelInicial.Location = new System.Drawing.Point(6, 20);
            this.labelInicial.Name = "labelInicial";
            this.labelInicial.Size = new System.Drawing.Size(69, 13);
            this.labelInicial.TabIndex = 1;
            this.labelInicial.Text = "Data Inicical:";
            // 
            // dateTimePickerIni
            // 
            this.dateTimePickerIni.Location = new System.Drawing.Point(9, 36);
            this.dateTimePickerIni.Name = "dateTimePickerIni";
            this.dateTimePickerIni.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerIni.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lista de vendas:";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorTotal.Location = new System.Drawing.Point(1074, 498);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(100, 20);
            this.labelValorTotal.TabIndex = 32;
            this.labelValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelValorDebito
            // 
            this.labelValorDebito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorDebito.Location = new System.Drawing.Point(534, 498);
            this.labelValorDebito.Name = "labelValorDebito";
            this.labelValorDebito.Size = new System.Drawing.Size(100, 20);
            this.labelValorDebito.TabIndex = 33;
            this.labelValorDebito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelValorCredito
            // 
            this.labelValorCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorCredito.Location = new System.Drawing.Point(642, 498);
            this.labelValorCredito.Name = "labelValorCredito";
            this.labelValorCredito.Size = new System.Drawing.Size(100, 20);
            this.labelValorCredito.TabIndex = 34;
            this.labelValorCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelValorCheque
            // 
            this.labelValorCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorCheque.Location = new System.Drawing.Point(750, 498);
            this.labelValorCheque.Name = "labelValorCheque";
            this.labelValorCheque.Size = new System.Drawing.Size(100, 20);
            this.labelValorCheque.TabIndex = 35;
            this.labelValorCheque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelValorOutras
            // 
            this.labelValorOutras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorOutras.Location = new System.Drawing.Point(966, 498);
            this.labelValorOutras.Name = "labelValorOutras";
            this.labelValorOutras.Size = new System.Drawing.Size(100, 20);
            this.labelValorOutras.TabIndex = 36;
            this.labelValorOutras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelValorDinheiro
            // 
            this.labelValorDinheiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorDinheiro.Location = new System.Drawing.Point(426, 498);
            this.labelValorDinheiro.Name = "labelValorDinheiro";
            this.labelValorDinheiro.Size = new System.Drawing.Size(100, 20);
            this.labelValorDinheiro.TabIndex = 37;
            this.labelValorDinheiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelValorDeposito
            // 
            this.labelValorDeposito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorDeposito.Location = new System.Drawing.Point(858, 498);
            this.labelValorDeposito.Name = "labelValorDeposito";
            this.labelValorDeposito.Size = new System.Drawing.Size(100, 20);
            this.labelValorDeposito.TabIndex = 38;
            this.labelValorDeposito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Total dinheiro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Total débito:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(642, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Total crédito:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(750, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Total cheque:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(858, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Total depósito:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(966, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Total outras:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1074, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Total:";
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.BackColor = System.Drawing.Color.Transparent;
            this.buttonAbrir.FlatAppearance.BorderSize = 0;
            this.buttonAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbrir.Image = global::WinForms.Properties.Resources.open_file_40455;
            this.buttonAbrir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAbrir.Location = new System.Drawing.Point(13, 521);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(85, 60);
            this.buttonAbrir.TabIndex = 46;
            this.buttonAbrir.Text = "Abrir";
            this.buttonAbrir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAbrir.UseVisualStyleBackColor = false;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.Transparent;
            this.buttonFechar.FlatAppearance.BorderSize = 0;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFechar.Location = new System.Drawing.Point(1089, 521);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 60);
            this.buttonFechar.TabIndex = 31;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Image = global::WinForms.Properties.Resources.cancelar;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancelar.Location = new System.Drawing.Point(104, 521);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(85, 60);
            this.buttonCancelar.TabIndex = 30;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormVendaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 593);
            this.Controls.Add(this.buttonAbrir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelValorDeposito);
            this.Controls.Add(this.labelValorDinheiro);
            this.Controls.Add(this.labelValorOutras);
            this.Controls.Add(this.labelValorCheque);
            this.Controls.Add(this.labelValorCredito);
            this.Controls.Add(this.labelValorDebito);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewVendaPeriodo);
            this.Name = "FormVendaRelatorio";
            this.Text = "Venda por periodo";
            this.Load += new System.EventHandler(this.FormVendaRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendaPeriodo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVendaPeriodo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDataFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.Label labelInicial;
        private System.Windows.Forms.DateTimePicker dateTimePickerIni;
        private System.Windows.Forms.ComboBox comboBoxTurno;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDinheiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurno;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Label labelValorDebito;
        private System.Windows.Forms.Label labelValorCredito;
        private System.Windows.Forms.Label labelValorCheque;
        private System.Windows.Forms.Label labelValorOutras;
        private System.Windows.Forms.Label labelValorDinheiro;
        private System.Windows.Forms.Label labelValorDeposito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonAberta;
        private System.Windows.Forms.RadioButton radioButtonCancelada;
        private System.Windows.Forms.RadioButton radioButtonConcluida;
    }
}
namespace WinForms
{
    partial class FormEmpresa
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
            this.textBoxCnpj = new System.Windows.Forms.TextBox();
            this.labelCnpj = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelFantasia = new System.Windows.Forms.Label();
            this.textBoxFantasia = new System.Windows.Forms.TextBox();
            this.labelRazao = new System.Windows.Forms.Label();
            this.textBoxRazao = new System.Windows.Forms.TextBox();
            this.labelCep = new System.Windows.Forms.Label();
            this.textBoxCep = new System.Windows.Forms.TextBox();
            this.labelEnd = new System.Windows.Forms.Label();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonAtual = new System.Windows.Forms.Button();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.labelRef = new System.Windows.Forms.Label();
            this.textBoxRef = new System.Windows.Forms.TextBox();
            this.buttonDeleteDB = new System.Windows.Forms.Button();
            this.tabControlEmp = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageUnid = new System.Windows.Forms.TabPage();
            this.buttonUnid = new System.Windows.Forms.Button();
            this.groupBoxRede = new System.Windows.Forms.GroupBox();
            this.textBoxAdapter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxComputer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxMac = new System.Windows.Forms.MaskedTextBox();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxServer = new System.Windows.Forms.GroupBox();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUnidNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUnid = new System.Windows.Forms.DataGridView();
            this.colUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlEmp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageUnid.SuspendLayout();
            this.groupBoxRede.SuspendLayout();
            this.groupBoxServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCnpj
            // 
            this.textBoxCnpj.Location = new System.Drawing.Point(104, 43);
            this.textBoxCnpj.Name = "textBoxCnpj";
            this.textBoxCnpj.ReadOnly = true;
            this.textBoxCnpj.Size = new System.Drawing.Size(425, 20);
            this.textBoxCnpj.TabIndex = 7;
            this.textBoxCnpj.TabStop = false;
            // 
            // labelCnpj
            // 
            this.labelCnpj.AutoSize = true;
            this.labelCnpj.Location = new System.Drawing.Point(63, 47);
            this.labelCnpj.Name = "labelCnpj";
            this.labelCnpj.Size = new System.Drawing.Size(37, 13);
            this.labelCnpj.TabIndex = 6;
            this.labelCnpj.Text = "CNPJ:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(62, 129);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "E-mail:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(104, 125);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(425, 20);
            this.textBoxEmail.TabIndex = 15;
            this.textBoxEmail.TabStop = false;
            // 
            // labelFantasia
            // 
            this.labelFantasia.AutoSize = true;
            this.labelFantasia.Location = new System.Drawing.Point(19, 101);
            this.labelFantasia.Name = "labelFantasia";
            this.labelFantasia.Size = new System.Drawing.Size(81, 13);
            this.labelFantasia.TabIndex = 12;
            this.labelFantasia.Text = "Nome Fantasia:";
            // 
            // textBoxFantasia
            // 
            this.textBoxFantasia.Location = new System.Drawing.Point(104, 97);
            this.textBoxFantasia.Name = "textBoxFantasia";
            this.textBoxFantasia.ReadOnly = true;
            this.textBoxFantasia.Size = new System.Drawing.Size(425, 20);
            this.textBoxFantasia.TabIndex = 13;
            this.textBoxFantasia.TabStop = false;
            // 
            // labelRazao
            // 
            this.labelRazao.AutoSize = true;
            this.labelRazao.Location = new System.Drawing.Point(27, 73);
            this.labelRazao.Name = "labelRazao";
            this.labelRazao.Size = new System.Drawing.Size(73, 13);
            this.labelRazao.TabIndex = 10;
            this.labelRazao.Text = "Razão Social:";
            // 
            // textBoxRazao
            // 
            this.textBoxRazao.Location = new System.Drawing.Point(104, 69);
            this.textBoxRazao.Name = "textBoxRazao";
            this.textBoxRazao.ReadOnly = true;
            this.textBoxRazao.Size = new System.Drawing.Size(425, 20);
            this.textBoxRazao.TabIndex = 11;
            this.textBoxRazao.TabStop = false;
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(71, 264);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(29, 13);
            this.labelCep.TabIndex = 20;
            this.labelCep.Text = "Cep:";
            // 
            // textBoxCep
            // 
            this.textBoxCep.Location = new System.Drawing.Point(104, 262);
            this.textBoxCep.Name = "textBoxCep";
            this.textBoxCep.ReadOnly = true;
            this.textBoxCep.Size = new System.Drawing.Size(425, 20);
            this.textBoxCep.TabIndex = 21;
            this.textBoxCep.TabStop = false;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(44, 236);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(56, 13);
            this.labelEnd.TabIndex = 18;
            this.labelEnd.Text = "Endereço:";
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(104, 234);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.ReadOnly = true;
            this.textBoxEnd.Size = new System.Drawing.Size(425, 20);
            this.textBoxEnd.TabIndex = 19;
            this.textBoxEnd.TabStop = false;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(48, 157);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(52, 13);
            this.labelTelefone.TabIndex = 16;
            this.labelTelefone.Text = "Telefone:";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(104, 153);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.ReadOnly = true;
            this.textBoxTel.Size = new System.Drawing.Size(425, 20);
            this.textBoxTel.TabIndex = 17;
            this.textBoxTel.TabStop = false;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(81, 21);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(104, 17);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(87, 20);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Enabled = false;
            this.buttonBuscar.Location = new System.Drawing.Point(205, 16);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "&Buscar:";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(454, 315);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 19;
            this.buttonSair.Text = "&Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Enabled = false;
            this.buttonInserir.Location = new System.Drawing.Point(288, 16);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 3;
            this.buttonInserir.Text = "&Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Visible = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Location = new System.Drawing.Point(454, 15);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletar.TabIndex = 5;
            this.buttonDeletar.Text = "&Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Visible = false;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // buttonAtual
            // 
            this.buttonAtual.Location = new System.Drawing.Point(371, 16);
            this.buttonAtual.Name = "buttonAtual";
            this.buttonAtual.Size = new System.Drawing.Size(75, 23);
            this.buttonAtual.TabIndex = 4;
            this.buttonAtual.Text = "&Atualizar";
            this.buttonAtual.UseVisualStyleBackColor = true;
            this.buttonAtual.Visible = false;
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Location = new System.Drawing.Point(26, 182);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(74, 13);
            this.labelComplemento.TabIndex = 22;
            this.labelComplemento.Text = "Complemento:";
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Location = new System.Drawing.Point(104, 180);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.ReadOnly = true;
            this.textBoxComplemento.Size = new System.Drawing.Size(425, 20);
            this.textBoxComplemento.TabIndex = 23;
            this.textBoxComplemento.TabStop = false;
            // 
            // labelRef
            // 
            this.labelRef.AutoSize = true;
            this.labelRef.Location = new System.Drawing.Point(24, 210);
            this.labelRef.Name = "labelRef";
            this.labelRef.Size = new System.Drawing.Size(76, 13);
            this.labelRef.TabIndex = 24;
            this.labelRef.Text = "Ponto de Ref.:";
            // 
            // textBoxRef
            // 
            this.textBoxRef.Location = new System.Drawing.Point(104, 208);
            this.textBoxRef.Name = "textBoxRef";
            this.textBoxRef.ReadOnly = true;
            this.textBoxRef.Size = new System.Drawing.Size(425, 20);
            this.textBoxRef.TabIndex = 25;
            this.textBoxRef.TabStop = false;
            // 
            // buttonDeleteDB
            // 
            this.buttonDeleteDB.Location = new System.Drawing.Point(104, 315);
            this.buttonDeleteDB.Name = "buttonDeleteDB";
            this.buttonDeleteDB.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteDB.TabIndex = 26;
            this.buttonDeleteDB.Text = "&Deletar";
            this.buttonDeleteDB.UseVisualStyleBackColor = true;
            this.buttonDeleteDB.Click += new System.EventHandler(this.buttonDeleteDB_Click);
            // 
            // tabControlEmp
            // 
            this.tabControlEmp.Controls.Add(this.tabPage1);
            this.tabControlEmp.Controls.Add(this.tabPageUnid);
            this.tabControlEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEmp.Location = new System.Drawing.Point(0, 0);
            this.tabControlEmp.Name = "tabControlEmp";
            this.tabControlEmp.SelectedIndex = 0;
            this.tabControlEmp.Size = new System.Drawing.Size(571, 374);
            this.tabControlEmp.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxFantasia);
            this.tabPage1.Controls.Add(this.textBoxCnpj);
            this.tabPage1.Controls.Add(this.labelCnpj);
            this.tabPage1.Controls.Add(this.textBoxEmail);
            this.tabPage1.Controls.Add(this.labelEmail);
            this.tabPage1.Controls.Add(this.buttonDeleteDB);
            this.tabPage1.Controls.Add(this.labelFantasia);
            this.tabPage1.Controls.Add(this.labelComplemento);
            this.tabPage1.Controls.Add(this.textBoxRazao);
            this.tabPage1.Controls.Add(this.textBoxComplemento);
            this.tabPage1.Controls.Add(this.labelRazao);
            this.tabPage1.Controls.Add(this.labelRef);
            this.tabPage1.Controls.Add(this.textBoxCep);
            this.tabPage1.Controls.Add(this.textBoxRef);
            this.tabPage1.Controls.Add(this.labelCep);
            this.tabPage1.Controls.Add(this.buttonAtual);
            this.tabPage1.Controls.Add(this.textBoxEnd);
            this.tabPage1.Controls.Add(this.buttonDeletar);
            this.tabPage1.Controls.Add(this.labelEnd);
            this.tabPage1.Controls.Add(this.buttonInserir);
            this.tabPage1.Controls.Add(this.textBoxTel);
            this.tabPage1.Controls.Add(this.buttonSair);
            this.tabPage1.Controls.Add(this.labelTelefone);
            this.tabPage1.Controls.Add(this.buttonBuscar);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.labelId);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(563, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empresa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPageUnid
            // 
            this.tabPageUnid.Controls.Add(this.buttonUnid);
            this.tabPageUnid.Controls.Add(this.groupBoxRede);
            this.tabPageUnid.Controls.Add(this.groupBoxServer);
            this.tabPageUnid.Controls.Add(this.textBoxServer);
            this.tabPageUnid.Controls.Add(this.label2);
            this.tabPageUnid.Controls.Add(this.textBoxUnidNome);
            this.tabPageUnid.Controls.Add(this.label1);
            this.tabPageUnid.Controls.Add(this.dataGridViewUnid);
            this.tabPageUnid.Location = new System.Drawing.Point(4, 22);
            this.tabPageUnid.Name = "tabPageUnid";
            this.tabPageUnid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUnid.Size = new System.Drawing.Size(563, 348);
            this.tabPageUnid.TabIndex = 1;
            this.tabPageUnid.Text = "Unidade";
            this.tabPageUnid.UseVisualStyleBackColor = true;
            // 
            // buttonUnid
            // 
            this.buttonUnid.BackColor = System.Drawing.Color.Green;
            this.buttonUnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnid.ForeColor = System.Drawing.Color.Lime;
            this.buttonUnid.Location = new System.Drawing.Point(443, 280);
            this.buttonUnid.Name = "buttonUnid";
            this.buttonUnid.Size = new System.Drawing.Size(112, 60);
            this.buttonUnid.TabIndex = 45;
            this.buttonUnid.Text = "Unidade";
            this.buttonUnid.UseVisualStyleBackColor = false;
            this.buttonUnid.Click += new System.EventHandler(this.ButtonUnid_Click);
            // 
            // groupBoxRede
            // 
            this.groupBoxRede.Controls.Add(this.textBoxAdapter);
            this.groupBoxRede.Controls.Add(this.label6);
            this.groupBoxRede.Controls.Add(this.textBoxComputer);
            this.groupBoxRede.Controls.Add(this.label5);
            this.groupBoxRede.Controls.Add(this.label3);
            this.groupBoxRede.Controls.Add(this.maskedTextBoxMac);
            this.groupBoxRede.Controls.Add(this.textBoxIp);
            this.groupBoxRede.Controls.Add(this.label4);
            this.groupBoxRede.Location = new System.Drawing.Point(6, 164);
            this.groupBoxRede.Name = "groupBoxRede";
            this.groupBoxRede.Size = new System.Drawing.Size(549, 110);
            this.groupBoxRede.TabIndex = 44;
            this.groupBoxRede.TabStop = false;
            this.groupBoxRede.Text = "Configurações de rede:";
            // 
            // textBoxAdapter
            // 
            this.textBoxAdapter.Location = new System.Drawing.Point(6, 79);
            this.textBoxAdapter.Name = "textBoxAdapter";
            this.textBoxAdapter.ReadOnly = true;
            this.textBoxAdapter.Size = new System.Drawing.Size(537, 20);
            this.textBoxAdapter.TabIndex = 45;
            this.textBoxAdapter.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Adaptador de rede:";
            // 
            // textBoxComputer
            // 
            this.textBoxComputer.Location = new System.Drawing.Point(6, 40);
            this.textBoxComputer.Name = "textBoxComputer";
            this.textBoxComputer.ReadOnly = true;
            this.textBoxComputer.Size = new System.Drawing.Size(289, 20);
            this.textBoxComputer.TabIndex = 38;
            this.textBoxComputer.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Mac Adress:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nome deste computador";
            // 
            // maskedTextBoxMac
            // 
            this.maskedTextBoxMac.Location = new System.Drawing.Point(428, 40);
            this.maskedTextBoxMac.Mask = "AA-AA-AA-AA-AA-AA";
            this.maskedTextBoxMac.Name = "maskedTextBoxMac";
            this.maskedTextBoxMac.ReadOnly = true;
            this.maskedTextBoxMac.Size = new System.Drawing.Size(115, 20);
            this.maskedTextBoxMac.TabIndex = 42;
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(301, 40);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.ReadOnly = true;
            this.textBoxIp.Size = new System.Drawing.Size(121, 20);
            this.textBoxIp.TabIndex = 40;
            this.textBoxIp.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Endereço de IP:";
            // 
            // groupBoxServer
            // 
            this.groupBoxServer.Controls.Add(this.radioButtonNao);
            this.groupBoxServer.Controls.Add(this.radioButtonSim);
            this.groupBoxServer.Location = new System.Drawing.Point(325, 280);
            this.groupBoxServer.Name = "groupBoxServer";
            this.groupBoxServer.Size = new System.Drawing.Size(112, 44);
            this.groupBoxServer.TabIndex = 41;
            this.groupBoxServer.TabStop = false;
            this.groupBoxServer.Text = "Este é o servidor?";
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Checked = true;
            this.radioButtonNao.Location = new System.Drawing.Point(57, 19);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(45, 17);
            this.radioButtonNao.TabIndex = 43;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Location = new System.Drawing.Point(9, 19);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(42, 17);
            this.radioButtonSim.TabIndex = 42;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(348, 136);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.ReadOnly = true;
            this.textBoxServer.Size = new System.Drawing.Size(207, 20);
            this.textBoxServer.TabIndex = 36;
            this.textBoxServer.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Servidor:";
            // 
            // textBoxUnidNome
            // 
            this.textBoxUnidNome.Location = new System.Drawing.Point(6, 136);
            this.textBoxUnidNome.Name = "textBoxUnidNome";
            this.textBoxUnidNome.ReadOnly = true;
            this.textBoxUnidNome.Size = new System.Drawing.Size(336, 20);
            this.textBoxUnidNome.TabIndex = 33;
            this.textBoxUnidNome.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Unid.:";
            // 
            // dataGridViewUnid
            // 
            this.dataGridViewUnid.AllowUserToAddRows = false;
            this.dataGridViewUnid.AllowUserToDeleteRows = false;
            this.dataGridViewUnid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUnidade});
            this.dataGridViewUnid.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewUnid.Name = "dataGridViewUnid";
            this.dataGridViewUnid.ReadOnly = true;
            this.dataGridViewUnid.RowHeadersVisible = false;
            this.dataGridViewUnid.Size = new System.Drawing.Size(549, 109);
            this.dataGridViewUnid.TabIndex = 0;
            // 
            // colUnidade
            // 
            this.colUnidade.DataPropertyName = "uniunidade";
            this.colUnidade.HeaderText = "Unidade:";
            this.colUnidade.Name = "colUnidade";
            this.colUnidade.ReadOnly = true;
            this.colUnidade.Width = 530;
            // 
            // FormEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 374);
            this.ControlBox = false;
            this.Controls.Add(this.tabControlEmp);
            this.Name = "FormEmpresa";
            this.Text = "Ativar Empresa";
            this.Load += new System.EventHandler(this.FormEmpresa_Load);
            this.tabControlEmp.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageUnid.ResumeLayout(false);
            this.tabPageUnid.PerformLayout();
            this.groupBoxRede.ResumeLayout(false);
            this.groupBoxRede.PerformLayout();
            this.groupBoxServer.ResumeLayout(false);
            this.groupBoxServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCnpj;
        private System.Windows.Forms.Label labelCnpj;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelFantasia;
        private System.Windows.Forms.TextBox textBoxFantasia;
        private System.Windows.Forms.Label labelRazao;
        private System.Windows.Forms.TextBox textBoxRazao;
        private System.Windows.Forms.Label labelCep;
        private System.Windows.Forms.TextBox textBoxCep;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Button buttonAtual;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.TextBox textBoxComplemento;
        private System.Windows.Forms.Label labelRef;
        private System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.Button buttonDeleteDB;
        private System.Windows.Forms.TabControl tabControlEmp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageUnid;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxComputer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUnidNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUnid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidade;
        private System.Windows.Forms.GroupBox groupBoxServer;
        private System.Windows.Forms.RadioButton radioButtonNao;
        private System.Windows.Forms.RadioButton radioButtonSim;
        private System.Windows.Forms.GroupBox groupBoxRede;
        private System.Windows.Forms.TextBox textBoxAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMac;
        private System.Windows.Forms.Button buttonUnid;
    }
}
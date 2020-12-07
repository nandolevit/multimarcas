namespace WinForms
{
    partial class FormUnidade
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
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.groupBoxEnd = new System.Windows.Forms.GroupBox();
            this.labelIdent = new System.Windows.Forms.Label();
            this.textBoxIdent = new System.Windows.Forms.TextBox();
            this.linkLabelCep = new System.Windows.Forms.LinkLabel();
            this.textBoxUF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.textBoxLogradouro = new System.Windows.Forms.TextBox();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.textBoxPontoReferencia = new System.Windows.Forms.TextBox();
            this.labelPontoReferencia = new System.Windows.Forms.Label();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.labelCep = new System.Windows.Forms.Label();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.groupBoxDadosPessoais = new System.Windows.Forms.GroupBox();
            this.labelSite = new System.Windows.Forms.Label();
            this.textBoxSite = new System.Windows.Forms.TextBox();
            this.labelRazao = new System.Windows.Forms.Label();
            this.textBoxRazao = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.labelNiver = new System.Windows.Forms.Label();
            this.dateTimePickerFundacao = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxTel2 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTel1 = new System.Windows.Forms.MaskedTextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.groupBoxEnd.SuspendLayout();
            this.groupBoxDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(359, 425);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 40);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(451, 425);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 3;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // groupBoxEnd
            // 
            this.groupBoxEnd.Controls.Add(this.labelIdent);
            this.groupBoxEnd.Controls.Add(this.textBoxIdent);
            this.groupBoxEnd.Controls.Add(this.linkLabelCep);
            this.groupBoxEnd.Controls.Add(this.textBoxUF);
            this.groupBoxEnd.Controls.Add(this.label1);
            this.groupBoxEnd.Controls.Add(this.textBoxCidade);
            this.groupBoxEnd.Controls.Add(this.labelCidade);
            this.groupBoxEnd.Controls.Add(this.textBoxBairro);
            this.groupBoxEnd.Controls.Add(this.labelBairro);
            this.groupBoxEnd.Controls.Add(this.textBoxLogradouro);
            this.groupBoxEnd.Controls.Add(this.labelLogradouro);
            this.groupBoxEnd.Controls.Add(this.textBoxPontoReferencia);
            this.groupBoxEnd.Controls.Add(this.labelPontoReferencia);
            this.groupBoxEnd.Controls.Add(this.maskedTextBoxCep);
            this.groupBoxEnd.Controls.Add(this.labelCep);
            this.groupBoxEnd.Controls.Add(this.textBoxComplemento);
            this.groupBoxEnd.Controls.Add(this.labelComplemento);
            this.groupBoxEnd.Location = new System.Drawing.Point(12, 196);
            this.groupBoxEnd.Name = "groupBoxEnd";
            this.groupBoxEnd.Size = new System.Drawing.Size(524, 223);
            this.groupBoxEnd.TabIndex = 1;
            this.groupBoxEnd.TabStop = false;
            this.groupBoxEnd.Text = "Endereço:";
            // 
            // labelIdent
            // 
            this.labelIdent.AutoSize = true;
            this.labelIdent.Location = new System.Drawing.Point(226, 14);
            this.labelIdent.Name = "labelIdent";
            this.labelIdent.Size = new System.Drawing.Size(117, 13);
            this.labelIdent.TabIndex = 3;
            this.labelIdent.Text = "Nome de Identificação:";
            // 
            // textBoxIdent
            // 
            this.textBoxIdent.Enabled = false;
            this.textBoxIdent.Location = new System.Drawing.Point(225, 30);
            this.textBoxIdent.Name = "textBoxIdent";
            this.textBoxIdent.Size = new System.Drawing.Size(293, 20);
            this.textBoxIdent.TabIndex = 4;
            // 
            // linkLabelCep
            // 
            this.linkLabelCep.AutoSize = true;
            this.linkLabelCep.Location = new System.Drawing.Point(103, 33);
            this.linkLabelCep.Name = "linkLabelCep";
            this.linkLabelCep.Size = new System.Drawing.Size(62, 13);
            this.linkLabelCep.TabIndex = 2;
            this.linkLabelCep.TabStop = true;
            this.linkLabelCep.Text = "Buscar Cep";
            this.linkLabelCep.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCep_LinkClicked);
            // 
            // textBoxUF
            // 
            this.textBoxUF.Location = new System.Drawing.Point(422, 195);
            this.textBoxUF.Name = "textBoxUF";
            this.textBoxUF.ReadOnly = true;
            this.textBoxUF.Size = new System.Drawing.Size(96, 20);
            this.textBoxUF.TabIndex = 16;
            this.textBoxUF.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "UF:";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(14, 195);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.ReadOnly = true;
            this.textBoxCidade.Size = new System.Drawing.Size(402, 20);
            this.textBoxCidade.TabIndex = 14;
            this.textBoxCidade.TabStop = false;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(14, 182);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(43, 13);
            this.labelCidade.TabIndex = 13;
            this.labelCidade.Text = "Cidade:";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(14, 162);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.ReadOnly = true;
            this.textBoxBairro.Size = new System.Drawing.Size(504, 20);
            this.textBoxBairro.TabIndex = 12;
            this.textBoxBairro.TabStop = false;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(14, 149);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(37, 13);
            this.labelBairro.TabIndex = 11;
            this.labelBairro.Text = "Bairro:";
            // 
            // textBoxLogradouro
            // 
            this.textBoxLogradouro.Location = new System.Drawing.Point(14, 129);
            this.textBoxLogradouro.Name = "textBoxLogradouro";
            this.textBoxLogradouro.ReadOnly = true;
            this.textBoxLogradouro.Size = new System.Drawing.Size(504, 20);
            this.textBoxLogradouro.TabIndex = 10;
            this.textBoxLogradouro.TabStop = false;
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(14, 116);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(64, 13);
            this.labelLogradouro.TabIndex = 9;
            this.labelLogradouro.Text = "Logradouro:";
            // 
            // textBoxPontoReferencia
            // 
            this.textBoxPontoReferencia.Location = new System.Drawing.Point(14, 96);
            this.textBoxPontoReferencia.Name = "textBoxPontoReferencia";
            this.textBoxPontoReferencia.Size = new System.Drawing.Size(504, 20);
            this.textBoxPontoReferencia.TabIndex = 7;
            // 
            // labelPontoReferencia
            // 
            this.labelPontoReferencia.AutoSize = true;
            this.labelPontoReferencia.Location = new System.Drawing.Point(14, 83);
            this.labelPontoReferencia.Name = "labelPontoReferencia";
            this.labelPontoReferencia.Size = new System.Drawing.Size(108, 13);
            this.labelPontoReferencia.TabIndex = 8;
            this.labelPontoReferencia.Text = "Ponto de Referência:";
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(14, 30);
            this.maskedTextBoxCep.Mask = "00,000-000";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(83, 20);
            this.maskedTextBoxCep.TabIndex = 1;
            this.maskedTextBoxCep.TextChanged += new System.EventHandler(this.maskedTextBoxCep_TextChanged);
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(14, 17);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(31, 13);
            this.labelCep.TabIndex = 0;
            this.labelCep.Text = "CEP:";
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Location = new System.Drawing.Point(14, 63);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(504, 20);
            this.textBoxComplemento.TabIndex = 5;
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Location = new System.Drawing.Point(14, 50);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(74, 13);
            this.labelComplemento.TabIndex = 6;
            this.labelComplemento.Text = "Complemento:";
            // 
            // groupBoxDadosPessoais
            // 
            this.groupBoxDadosPessoais.Controls.Add(this.labelSite);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxSite);
            this.groupBoxDadosPessoais.Controls.Add(this.labelRazao);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxRazao);
            this.groupBoxDadosPessoais.Controls.Add(this.maskedTextBoxCpf);
            this.groupBoxDadosPessoais.Controls.Add(this.labelNiver);
            this.groupBoxDadosPessoais.Controls.Add(this.dateTimePickerFundacao);
            this.groupBoxDadosPessoais.Controls.Add(this.maskedTextBoxTel2);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxId);
            this.groupBoxDadosPessoais.Controls.Add(this.maskedTextBoxTel1);
            this.groupBoxDadosPessoais.Controls.Add(this.labelCpf);
            this.groupBoxDadosPessoais.Controls.Add(this.labelTel);
            this.groupBoxDadosPessoais.Controls.Add(this.labelNome);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxNome);
            this.groupBoxDadosPessoais.Controls.Add(this.labelId);
            this.groupBoxDadosPessoais.Controls.Add(this.labelEmail);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxEmail);
            this.groupBoxDadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDadosPessoais.Name = "groupBoxDadosPessoais";
            this.groupBoxDadosPessoais.Size = new System.Drawing.Size(524, 178);
            this.groupBoxDadosPessoais.TabIndex = 0;
            this.groupBoxDadosPessoais.TabStop = false;
            this.groupBoxDadosPessoais.Text = "Dados Pessoais";
            // 
            // labelSite
            // 
            this.labelSite.AutoSize = true;
            this.labelSite.Location = new System.Drawing.Point(200, 94);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(28, 13);
            this.labelSite.TabIndex = 10;
            this.labelSite.Text = "Site:";
            // 
            // textBoxSite
            // 
            this.textBoxSite.Location = new System.Drawing.Point(200, 110);
            this.textBoxSite.Name = "textBoxSite";
            this.textBoxSite.Size = new System.Drawing.Size(318, 20);
            this.textBoxSite.TabIndex = 11;
            // 
            // labelRazao
            // 
            this.labelRazao.AutoSize = true;
            this.labelRazao.Location = new System.Drawing.Point(223, 17);
            this.labelRazao.Name = "labelRazao";
            this.labelRazao.Size = new System.Drawing.Size(73, 13);
            this.labelRazao.TabIndex = 4;
            this.labelRazao.Text = "Razão Social:";
            // 
            // textBoxRazao
            // 
            this.textBoxRazao.Location = new System.Drawing.Point(222, 33);
            this.textBoxRazao.Name = "textBoxRazao";
            this.textBoxRazao.Size = new System.Drawing.Size(296, 20);
            this.textBoxRazao.TabIndex = 5;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(101, 33);
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(115, 20);
            this.maskedTextBoxCpf.TabIndex = 3;
            this.maskedTextBoxCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBoxCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelNiver
            // 
            this.labelNiver.AutoSize = true;
            this.labelNiver.Location = new System.Drawing.Point(270, 133);
            this.labelNiver.Name = "labelNiver";
            this.labelNiver.Size = new System.Drawing.Size(99, 13);
            this.labelNiver.TabIndex = 15;
            this.labelNiver.Text = "Data de Fundação:";
            // 
            // dateTimePickerFundacao
            // 
            this.dateTimePickerFundacao.Location = new System.Drawing.Point(273, 149);
            this.dateTimePickerFundacao.Name = "dateTimePickerFundacao";
            this.dateTimePickerFundacao.Size = new System.Drawing.Size(245, 20);
            this.dateTimePickerFundacao.TabIndex = 16;
            this.dateTimePickerFundacao.Value = new System.DateTime(2018, 1, 27, 0, 0, 0, 0);
            // 
            // maskedTextBoxTel2
            // 
            this.maskedTextBoxTel2.Location = new System.Drawing.Point(135, 149);
            this.maskedTextBoxTel2.Mask = "(00) 0 0000-0000";
            this.maskedTextBoxTel2.Name = "maskedTextBoxTel2";
            this.maskedTextBoxTel2.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBoxTel2.TabIndex = 14;
            this.maskedTextBoxTel2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(13, 33);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(82, 20);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.TabStop = false;
            this.textBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maskedTextBoxTel1
            // 
            this.maskedTextBoxTel1.Location = new System.Drawing.Point(13, 149);
            this.maskedTextBoxTel1.Mask = "(00) 0 0000-0000";
            this.maskedTextBoxTel1.Name = "maskedTextBoxTel1";
            this.maskedTextBoxTel1.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBoxTel1.TabIndex = 13;
            this.maskedTextBoxTel1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(102, 17);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(37, 13);
            this.labelCpf.TabIndex = 2;
            this.labelCpf.Text = "CNPJ:";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(13, 133);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(57, 13);
            this.labelTel.TabIndex = 12;
            this.labelTel.Text = "Telefones:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(14, 56);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(81, 13);
            this.labelNome.TabIndex = 6;
            this.labelNome.Text = "Nome Fantasia:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(13, 72);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(505, 20);
            this.textBoxNome.TabIndex = 7;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(13, 17);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 13);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(13, 94);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(13, 110);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(181, 20);
            this.textBoxEmail.TabIndex = 9;
            this.textBoxEmail.Text = "sem@email.com";
            // 
            // FormUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 472);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.groupBoxEnd);
            this.Controls.Add(this.groupBoxDadosPessoais);
            this.Name = "FormUnidade";
            this.Text = "Unidade";
            this.groupBoxEnd.ResumeLayout(false);
            this.groupBoxEnd.PerformLayout();
            this.groupBoxDadosPessoais.ResumeLayout(false);
            this.groupBoxDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.GroupBox groupBoxEnd;
        private System.Windows.Forms.LinkLabel linkLabelCep;
        private System.Windows.Forms.TextBox textBoxUF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.TextBox textBoxLogradouro;
        private System.Windows.Forms.Label labelLogradouro;
        private System.Windows.Forms.TextBox textBoxPontoReferencia;
        private System.Windows.Forms.Label labelPontoReferencia;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCep;
        private System.Windows.Forms.Label labelCep;
        private System.Windows.Forms.TextBox textBoxComplemento;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.GroupBox groupBoxDadosPessoais;
        private System.Windows.Forms.Label labelSite;
        private System.Windows.Forms.TextBox textBoxSite;
        private System.Windows.Forms.Label labelRazao;
        private System.Windows.Forms.TextBox textBoxRazao;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.Label labelNiver;
        private System.Windows.Forms.DateTimePicker dateTimePickerFundacao;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel1;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelIdent;
        private System.Windows.Forms.TextBox textBoxIdent;
    }
}
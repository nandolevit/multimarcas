namespace WinForms
{
    partial class FormNotaFiscal
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
            this.components = new System.ComponentModel.Container();
            this.labelAutorizadaDescricao = new System.Windows.Forms.Label();
            this.textBoxCodAutorizada = new System.Windows.Forms.TextBox();
            this.labelAutorizada = new System.Windows.Forms.Label();
            this.labelLojaDescricao = new System.Windows.Forms.Label();
            this.textBoxCodLoja = new System.Windows.Forms.TextBox();
            this.labelLoja = new System.Windows.Forms.Label();
            this.labelEletroDescricao = new System.Windows.Forms.Label();
            this.textBoxCodEletro = new System.Windows.Forms.TextBox();
            this.labelEletro = new System.Windows.Forms.Label();
            this.groupBoxSelecionar = new System.Windows.Forms.GroupBox();
            this.buttonAddEletro = new System.Windows.Forms.Button();
            this.buttonBuscarEletro = new System.Windows.Forms.Button();
            this.buttonAddAutorizada = new System.Windows.Forms.Button();
            this.buttonBuscarAutorizada = new System.Windows.Forms.Button();
            this.buttonAddLoja = new System.Windows.Forms.Button();
            this.buttonBuscarLoja = new System.Windows.Forms.Button();
            this.groupBoxNota = new System.Windows.Forms.GroupBox();
            this.buttonAddNiver = new System.Windows.Forms.Button();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.labelEmissao = new System.Windows.Forms.Label();
            this.labelNotaS = new System.Windows.Forms.Label();
            this.textBoxNotaS = new System.Windows.Forms.TextBox();
            this.labelNotaNome = new System.Windows.Forms.Label();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.textBoxNotaNome = new System.Windows.Forms.TextBox();
            this.labelObs = new System.Windows.Forms.Label();
            this.labelNotaN = new System.Windows.Forms.Label();
            this.textBoxNotaN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxSelecionar.SuspendLayout();
            this.groupBoxNota.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAutorizadaDescricao
            // 
            this.labelAutorizadaDescricao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAutorizadaDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutorizadaDescricao.Location = new System.Drawing.Point(89, 64);
            this.labelAutorizadaDescricao.Name = "labelAutorizadaDescricao";
            this.labelAutorizadaDescricao.Size = new System.Drawing.Size(465, 21);
            this.labelAutorizadaDescricao.TabIndex = 9;
            this.labelAutorizadaDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCodAutorizada
            // 
            this.textBoxCodAutorizada.Location = new System.Drawing.Point(6, 65);
            this.textBoxCodAutorizada.Name = "textBoxCodAutorizada";
            this.textBoxCodAutorizada.Size = new System.Drawing.Size(30, 20);
            this.textBoxCodAutorizada.TabIndex = 5;
            this.textBoxCodAutorizada.Leave += new System.EventHandler(this.textBoxCodAutorizada_Leave);
            // 
            // labelAutorizada
            // 
            this.labelAutorizada.AutoSize = true;
            this.labelAutorizada.Location = new System.Drawing.Point(89, 48);
            this.labelAutorizada.Name = "labelAutorizada";
            this.labelAutorizada.Size = new System.Drawing.Size(60, 13);
            this.labelAutorizada.TabIndex = 8;
            this.labelAutorizada.Text = "Autorizada:";
            // 
            // labelLojaDescricao
            // 
            this.labelLojaDescricao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLojaDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLojaDescricao.Location = new System.Drawing.Point(89, 28);
            this.labelLojaDescricao.Name = "labelLojaDescricao";
            this.labelLojaDescricao.Size = new System.Drawing.Size(465, 21);
            this.labelLojaDescricao.TabIndex = 4;
            this.labelLojaDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCodLoja
            // 
            this.textBoxCodLoja.Location = new System.Drawing.Point(6, 29);
            this.textBoxCodLoja.Name = "textBoxCodLoja";
            this.textBoxCodLoja.Size = new System.Drawing.Size(30, 20);
            this.textBoxCodLoja.TabIndex = 0;
            this.textBoxCodLoja.Leave += new System.EventHandler(this.textBoxCodLoja_Leave);
            // 
            // labelLoja
            // 
            this.labelLoja.AutoSize = true;
            this.labelLoja.Location = new System.Drawing.Point(89, 11);
            this.labelLoja.Name = "labelLoja";
            this.labelLoja.Size = new System.Drawing.Size(30, 13);
            this.labelLoja.TabIndex = 3;
            this.labelLoja.Text = "Loja:";
            // 
            // labelEletroDescricao
            // 
            this.labelEletroDescricao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEletroDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEletroDescricao.Location = new System.Drawing.Point(89, 100);
            this.labelEletroDescricao.Name = "labelEletroDescricao";
            this.labelEletroDescricao.Size = new System.Drawing.Size(465, 21);
            this.labelEletroDescricao.TabIndex = 13;
            this.labelEletroDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCodEletro
            // 
            this.textBoxCodEletro.Location = new System.Drawing.Point(6, 101);
            this.textBoxCodEletro.Name = "textBoxCodEletro";
            this.textBoxCodEletro.Size = new System.Drawing.Size(30, 20);
            this.textBoxCodEletro.TabIndex = 10;
            this.textBoxCodEletro.Leave += new System.EventHandler(this.textBoxCodEletro_Leave);
            // 
            // labelEletro
            // 
            this.labelEletro.AutoSize = true;
            this.labelEletro.Location = new System.Drawing.Point(89, 85);
            this.labelEletro.Name = "labelEletro";
            this.labelEletro.Size = new System.Drawing.Size(37, 13);
            this.labelEletro.TabIndex = 14;
            this.labelEletro.Text = "Eletro:";
            // 
            // groupBoxSelecionar
            // 
            this.groupBoxSelecionar.Controls.Add(this.buttonAddEletro);
            this.groupBoxSelecionar.Controls.Add(this.buttonBuscarEletro);
            this.groupBoxSelecionar.Controls.Add(this.buttonAddAutorizada);
            this.groupBoxSelecionar.Controls.Add(this.buttonBuscarAutorizada);
            this.groupBoxSelecionar.Controls.Add(this.buttonAddLoja);
            this.groupBoxSelecionar.Controls.Add(this.labelLojaDescricao);
            this.groupBoxSelecionar.Controls.Add(this.buttonBuscarLoja);
            this.groupBoxSelecionar.Controls.Add(this.labelEletroDescricao);
            this.groupBoxSelecionar.Controls.Add(this.labelAutorizada);
            this.groupBoxSelecionar.Controls.Add(this.textBoxCodEletro);
            this.groupBoxSelecionar.Controls.Add(this.textBoxCodAutorizada);
            this.groupBoxSelecionar.Controls.Add(this.labelEletro);
            this.groupBoxSelecionar.Controls.Add(this.labelAutorizadaDescricao);
            this.groupBoxSelecionar.Controls.Add(this.labelLoja);
            this.groupBoxSelecionar.Controls.Add(this.textBoxCodLoja);
            this.groupBoxSelecionar.Enabled = false;
            this.groupBoxSelecionar.Location = new System.Drawing.Point(12, 49);
            this.groupBoxSelecionar.Name = "groupBoxSelecionar";
            this.groupBoxSelecionar.Size = new System.Drawing.Size(560, 133);
            this.groupBoxSelecionar.TabIndex = 2;
            this.groupBoxSelecionar.TabStop = false;
            this.groupBoxSelecionar.Text = "Selecionar:";
            // 
            // buttonAddEletro
            // 
            this.buttonAddEletro.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddEletro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddEletro.FlatAppearance.BorderSize = 0;
            this.buttonAddEletro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEletro.Location = new System.Drawing.Point(60, 101);
            this.buttonAddEletro.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddEletro.Name = "buttonAddEletro";
            this.buttonAddEletro.Size = new System.Drawing.Size(20, 20);
            this.buttonAddEletro.TabIndex = 12;
            this.toolTip1.SetToolTip(this.buttonAddEletro, "Adicionar um eletrodoméstico.");
            this.buttonAddEletro.UseVisualStyleBackColor = true;
            this.buttonAddEletro.Click += new System.EventHandler(this.buttonAddEletro_Click);
            // 
            // buttonBuscarEletro
            // 
            this.buttonBuscarEletro.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscarEletro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarEletro.FlatAppearance.BorderSize = 0;
            this.buttonBuscarEletro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarEletro.Location = new System.Drawing.Point(40, 101);
            this.buttonBuscarEletro.Name = "buttonBuscarEletro";
            this.buttonBuscarEletro.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarEletro.TabIndex = 11;
            this.toolTip1.SetToolTip(this.buttonBuscarEletro, "Selecionar um eletrodoméstico.");
            this.buttonBuscarEletro.UseVisualStyleBackColor = true;
            this.buttonBuscarEletro.Click += new System.EventHandler(this.buttonBuscarEletro_Click);
            // 
            // buttonAddAutorizada
            // 
            this.buttonAddAutorizada.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddAutorizada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddAutorizada.FlatAppearance.BorderSize = 0;
            this.buttonAddAutorizada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAutorizada.Location = new System.Drawing.Point(60, 65);
            this.buttonAddAutorizada.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddAutorizada.Name = "buttonAddAutorizada";
            this.buttonAddAutorizada.Size = new System.Drawing.Size(20, 20);
            this.buttonAddAutorizada.TabIndex = 7;
            this.toolTip1.SetToolTip(this.buttonAddAutorizada, "Adicionar uma nova autorizada.");
            this.buttonAddAutorizada.UseVisualStyleBackColor = true;
            this.buttonAddAutorizada.Click += new System.EventHandler(this.buttonAddAutorizada_Click);
            // 
            // buttonBuscarAutorizada
            // 
            this.buttonBuscarAutorizada.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscarAutorizada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarAutorizada.FlatAppearance.BorderSize = 0;
            this.buttonBuscarAutorizada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarAutorizada.Location = new System.Drawing.Point(40, 65);
            this.buttonBuscarAutorizada.Name = "buttonBuscarAutorizada";
            this.buttonBuscarAutorizada.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarAutorizada.TabIndex = 6;
            this.toolTip1.SetToolTip(this.buttonBuscarAutorizada, "Selecionar uma autorizada.");
            this.buttonBuscarAutorizada.UseVisualStyleBackColor = true;
            this.buttonBuscarAutorizada.Click += new System.EventHandler(this.buttonBuscarAutorizada_Click);
            // 
            // buttonAddLoja
            // 
            this.buttonAddLoja.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddLoja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddLoja.FlatAppearance.BorderSize = 0;
            this.buttonAddLoja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddLoja.Location = new System.Drawing.Point(60, 29);
            this.buttonAddLoja.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddLoja.Name = "buttonAddLoja";
            this.buttonAddLoja.Size = new System.Drawing.Size(20, 20);
            this.buttonAddLoja.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonAddLoja, "Adicionar uma nova loja.");
            this.buttonAddLoja.UseVisualStyleBackColor = true;
            this.buttonAddLoja.Click += new System.EventHandler(this.buttonAddLoja_Click);
            // 
            // buttonBuscarLoja
            // 
            this.buttonBuscarLoja.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscarLoja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarLoja.FlatAppearance.BorderSize = 0;
            this.buttonBuscarLoja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarLoja.Location = new System.Drawing.Point(40, 29);
            this.buttonBuscarLoja.Name = "buttonBuscarLoja";
            this.buttonBuscarLoja.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarLoja.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonBuscarLoja, "Selecionar uma loja.");
            this.buttonBuscarLoja.UseVisualStyleBackColor = true;
            this.buttonBuscarLoja.Click += new System.EventHandler(this.buttonBuscarLoja_Click);
            // 
            // groupBoxNota
            // 
            this.groupBoxNota.Controls.Add(this.buttonAddNiver);
            this.groupBoxNota.Controls.Add(this.textBoxData);
            this.groupBoxNota.Controls.Add(this.labelEmissao);
            this.groupBoxNota.Controls.Add(this.labelNotaS);
            this.groupBoxNota.Controls.Add(this.textBoxNotaS);
            this.groupBoxNota.Controls.Add(this.labelNotaNome);
            this.groupBoxNota.Controls.Add(this.textBoxObs);
            this.groupBoxNota.Controls.Add(this.textBoxNotaNome);
            this.groupBoxNota.Controls.Add(this.labelObs);
            this.groupBoxNota.Controls.Add(this.labelNotaN);
            this.groupBoxNota.Controls.Add(this.textBoxNotaN);
            this.groupBoxNota.Enabled = false;
            this.groupBoxNota.Location = new System.Drawing.Point(12, 188);
            this.groupBoxNota.Name = "groupBoxNota";
            this.groupBoxNota.Size = new System.Drawing.Size(560, 142);
            this.groupBoxNota.TabIndex = 3;
            this.groupBoxNota.TabStop = false;
            this.groupBoxNota.Text = "Detalhes da Nota Fiscal:";
            // 
            // buttonAddNiver
            // 
            this.buttonAddNiver.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddNiver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddNiver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNiver.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddNiver.Location = new System.Drawing.Point(530, 67);
            this.buttonAddNiver.Name = "buttonAddNiver";
            this.buttonAddNiver.Size = new System.Drawing.Size(24, 23);
            this.buttonAddNiver.TabIndex = 8;
            this.toolTip1.SetToolTip(this.buttonAddNiver, "Adicionar data de emissão.");
            this.buttonAddNiver.UseVisualStyleBackColor = true;
            this.buttonAddNiver.Click += new System.EventHandler(this.ButtonAddNiver_Click);
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(297, 69);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.Size = new System.Drawing.Size(227, 20);
            this.textBoxData.TabIndex = 7;
            this.textBoxData.TabStop = false;
            // 
            // labelEmissao
            // 
            this.labelEmissao.AutoSize = true;
            this.labelEmissao.Location = new System.Drawing.Point(297, 55);
            this.labelEmissao.Name = "labelEmissao";
            this.labelEmissao.Size = new System.Drawing.Size(90, 13);
            this.labelEmissao.TabIndex = 6;
            this.labelEmissao.Text = "Data de Emissão:";
            // 
            // labelNotaS
            // 
            this.labelNotaS.AutoSize = true;
            this.labelNotaS.Location = new System.Drawing.Point(192, 55);
            this.labelNotaS.Name = "labelNotaS";
            this.labelNotaS.Size = new System.Drawing.Size(72, 13);
            this.labelNotaS.TabIndex = 4;
            this.labelNotaS.Text = "Série da Nota";
            // 
            // textBoxNotaS
            // 
            this.textBoxNotaS.Location = new System.Drawing.Point(192, 69);
            this.textBoxNotaS.Name = "textBoxNotaS";
            this.textBoxNotaS.Size = new System.Drawing.Size(99, 20);
            this.textBoxNotaS.TabIndex = 5;
            // 
            // labelNotaNome
            // 
            this.labelNotaNome.AutoSize = true;
            this.labelNotaNome.Location = new System.Drawing.Point(6, 17);
            this.labelNotaNome.Name = "labelNotaNome";
            this.labelNotaNome.Size = new System.Drawing.Size(38, 13);
            this.labelNotaNome.TabIndex = 0;
            this.labelNotaNome.Text = "Nome:";
            // 
            // textBoxObs
            // 
            this.textBoxObs.Location = new System.Drawing.Point(6, 107);
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(548, 20);
            this.textBoxObs.TabIndex = 10;
            // 
            // textBoxNotaNome
            // 
            this.textBoxNotaNome.Location = new System.Drawing.Point(6, 31);
            this.textBoxNotaNome.Name = "textBoxNotaNome";
            this.textBoxNotaNome.Size = new System.Drawing.Size(548, 20);
            this.textBoxNotaNome.TabIndex = 1;
            // 
            // labelObs
            // 
            this.labelObs.AutoSize = true;
            this.labelObs.Location = new System.Drawing.Point(6, 93);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(29, 13);
            this.labelObs.TabIndex = 9;
            this.labelObs.Text = "Obs:";
            // 
            // labelNotaN
            // 
            this.labelNotaN.AutoSize = true;
            this.labelNotaN.Location = new System.Drawing.Point(6, 55);
            this.labelNotaN.Name = "labelNotaN";
            this.labelNotaN.Size = new System.Drawing.Size(60, 13);
            this.labelNotaN.TabIndex = 2;
            this.labelNotaN.Text = "Nº da Nota";
            // 
            // textBoxNotaN
            // 
            this.textBoxNotaN.Location = new System.Drawing.Point(6, 69);
            this.textBoxNotaN.Name = "textBoxNotaN";
            this.textBoxNotaN.Size = new System.Drawing.Size(180, 20);
            this.textBoxNotaN.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nome do Cliente:";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeCliente.Location = new System.Drawing.Point(12, 23);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.ReadOnly = true;
            this.textBoxNomeCliente.Size = new System.Drawing.Size(560, 20);
            this.textBoxNomeCliente.TabIndex = 1;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Enabled = false;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(395, 336);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 40);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonSalvar, "Salvar registro.");
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(487, 336);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 5;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonFechar, "Fechar o formulário");
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormNotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 388);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxNomeCliente);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.groupBoxNota);
            this.Controls.Add(this.groupBoxSelecionar);
            this.Name = "FormNotaFiscal";
            this.Text = "Nota Fiscal";
            this.Load += new System.EventHandler(this.FormNotaFiscal_Load);
            this.groupBoxSelecionar.ResumeLayout(false);
            this.groupBoxSelecionar.PerformLayout();
            this.groupBoxNota.ResumeLayout(false);
            this.groupBoxNota.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAutorizadaDescricao;
        private System.Windows.Forms.TextBox textBoxCodAutorizada;
        private System.Windows.Forms.Label labelAutorizada;
        private System.Windows.Forms.Label labelLojaDescricao;
        private System.Windows.Forms.TextBox textBoxCodLoja;
        private System.Windows.Forms.Label labelLoja;
        private System.Windows.Forms.Label labelEletroDescricao;
        private System.Windows.Forms.TextBox textBoxCodEletro;
        private System.Windows.Forms.Label labelEletro;
        private System.Windows.Forms.GroupBox groupBoxSelecionar;
        private System.Windows.Forms.GroupBox groupBoxNota;
        private System.Windows.Forms.Label labelEmissao;
        private System.Windows.Forms.Label labelNotaS;
        private System.Windows.Forms.TextBox textBoxNotaS;
        private System.Windows.Forms.Label labelNotaNome;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.TextBox textBoxNotaNome;
        private System.Windows.Forms.Label labelObs;
        private System.Windows.Forms.Label labelNotaN;
        private System.Windows.Forms.TextBox textBoxNotaN;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.Button buttonAddLoja;
        private System.Windows.Forms.Button buttonBuscarLoja;
        private System.Windows.Forms.Button buttonAddAutorizada;
        private System.Windows.Forms.Button buttonBuscarAutorizada;
        private System.Windows.Forms.Button buttonAddEletro;
        private System.Windows.Forms.Button buttonBuscarEletro;
        private System.Windows.Forms.Button buttonAddNiver;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
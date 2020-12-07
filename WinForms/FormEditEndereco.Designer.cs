namespace WinForms
{
    partial class FormEditEndereco
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
            this.buttonEnd = new System.Windows.Forms.Button();
            this.linkLabelCep = new System.Windows.Forms.LinkLabel();
            this.textBoxUF = new System.Windows.Forms.TextBox();
            this.labelUf = new System.Windows.Forms.Label();
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
            this.groupBoxEnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(361, 247);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 40);
            this.buttonSalvar.TabIndex = 1;
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
            this.buttonFechar.Location = new System.Drawing.Point(452, 247);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 2;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // groupBoxEnd
            // 
            this.groupBoxEnd.Controls.Add(this.buttonEnd);
            this.groupBoxEnd.Controls.Add(this.linkLabelCep);
            this.groupBoxEnd.Controls.Add(this.textBoxUF);
            this.groupBoxEnd.Controls.Add(this.labelUf);
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
            this.groupBoxEnd.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEnd.Name = "groupBoxEnd";
            this.groupBoxEnd.Size = new System.Drawing.Size(524, 229);
            this.groupBoxEnd.TabIndex = 0;
            this.groupBoxEnd.TabStop = false;
            this.groupBoxEnd.Text = "Endereço:";
            // 
            // buttonEnd
            // 
            this.buttonEnd.BackgroundImage = global::WinForms.Properties.Resources.consultar_cep;
            this.buttonEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEnd.FlatAppearance.BorderSize = 0;
            this.buttonEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnd.Location = new System.Drawing.Point(103, 21);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(93, 37);
            this.buttonEnd.TabIndex = 2;
            this.buttonEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // linkLabelCep
            // 
            this.linkLabelCep.AutoSize = true;
            this.linkLabelCep.Location = new System.Drawing.Point(453, 37);
            this.linkLabelCep.Name = "linkLabelCep";
            this.linkLabelCep.Size = new System.Drawing.Size(62, 13);
            this.linkLabelCep.TabIndex = 15;
            this.linkLabelCep.TabStop = true;
            this.linkLabelCep.Text = "Buscar Cep";
            // 
            // textBoxUF
            // 
            this.textBoxUF.Location = new System.Drawing.Point(422, 195);
            this.textBoxUF.MaxLength = 2;
            this.textBoxUF.Name = "textBoxUF";
            this.textBoxUF.Size = new System.Drawing.Size(93, 20);
            this.textBoxUF.TabIndex = 14;
            this.textBoxUF.TabStop = false;
            // 
            // labelUf
            // 
            this.labelUf.AutoSize = true;
            this.labelUf.Location = new System.Drawing.Point(422, 182);
            this.labelUf.Name = "labelUf";
            this.labelUf.Size = new System.Drawing.Size(24, 13);
            this.labelUf.TabIndex = 13;
            this.labelUf.Text = "UF:";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(14, 195);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(402, 20);
            this.textBoxCidade.TabIndex = 12;
            this.textBoxCidade.TabStop = false;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(14, 182);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(43, 13);
            this.labelCidade.TabIndex = 11;
            this.labelCidade.Text = "Cidade:";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(14, 162);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(501, 20);
            this.textBoxBairro.TabIndex = 10;
            this.textBoxBairro.TabStop = false;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(14, 149);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(37, 13);
            this.labelBairro.TabIndex = 9;
            this.labelBairro.Text = "Bairro:";
            // 
            // textBoxLogradouro
            // 
            this.textBoxLogradouro.Location = new System.Drawing.Point(14, 129);
            this.textBoxLogradouro.Name = "textBoxLogradouro";
            this.textBoxLogradouro.Size = new System.Drawing.Size(501, 20);
            this.textBoxLogradouro.TabIndex = 8;
            this.textBoxLogradouro.TabStop = false;
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(14, 116);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(64, 13);
            this.labelLogradouro.TabIndex = 7;
            this.labelLogradouro.Text = "Logradouro:";
            // 
            // textBoxPontoReferencia
            // 
            this.textBoxPontoReferencia.Location = new System.Drawing.Point(14, 96);
            this.textBoxPontoReferencia.Name = "textBoxPontoReferencia";
            this.textBoxPontoReferencia.Size = new System.Drawing.Size(501, 20);
            this.textBoxPontoReferencia.TabIndex = 6;
            // 
            // labelPontoReferencia
            // 
            this.labelPontoReferencia.AutoSize = true;
            this.labelPontoReferencia.Location = new System.Drawing.Point(14, 83);
            this.labelPontoReferencia.Name = "labelPontoReferencia";
            this.labelPontoReferencia.Size = new System.Drawing.Size(108, 13);
            this.labelPontoReferencia.TabIndex = 5;
            this.labelPontoReferencia.Text = "Ponto de Referência:";
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(14, 30);
            this.maskedTextBoxCep.Mask = "00,000-000";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(83, 20);
            this.maskedTextBoxCep.TabIndex = 1;
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
            this.textBoxComplemento.Size = new System.Drawing.Size(501, 20);
            this.textBoxComplemento.TabIndex = 4;
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Location = new System.Drawing.Point(14, 50);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(74, 13);
            this.labelComplemento.TabIndex = 3;
            this.labelComplemento.Text = "Complemento:";
            // 
            // FormEditEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 296);
            this.Controls.Add(this.groupBoxEnd);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonFechar);
            this.Name = "FormEditEndereco";
            this.Text = "Alterar Endereço";
            this.groupBoxEnd.ResumeLayout(false);
            this.groupBoxEnd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.GroupBox groupBoxEnd;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.LinkLabel linkLabelCep;
        private System.Windows.Forms.TextBox textBoxUF;
        private System.Windows.Forms.Label labelUf;
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
    }
}
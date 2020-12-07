namespace WinForms
{
    partial class FormSangria
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
            this.buttonContaAdd = new System.Windows.Forms.Button();
            this.buttonContaBuscar = new System.Windows.Forms.Button();
            this.labelContaDescricao = new System.Windows.Forms.Label();
            this.textBoxContaCod = new System.Windows.Forms.TextBox();
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelPagamento = new System.Windows.Forms.Label();
            this.labelDinheiro = new System.Windows.Forms.Label();
            this.labelCaixa = new System.Windows.Forms.Label();
            this.labelDinh = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelRS = new System.Windows.Forms.Label();
            this.labelSangria = new System.Windows.Forms.Label();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.labelObs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonContaAdd
            // 
            this.buttonContaAdd.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonContaAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonContaAdd.FlatAppearance.BorderSize = 0;
            this.buttonContaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContaAdd.Location = new System.Drawing.Point(66, 40);
            this.buttonContaAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonContaAdd.Name = "buttonContaAdd";
            this.buttonContaAdd.Size = new System.Drawing.Size(20, 20);
            this.buttonContaAdd.TabIndex = 2;
            this.buttonContaAdd.UseVisualStyleBackColor = true;
            this.buttonContaAdd.Click += new System.EventHandler(this.buttonContaAdd_Click);
            // 
            // buttonContaBuscar
            // 
            this.buttonContaBuscar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonContaBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonContaBuscar.FlatAppearance.BorderSize = 0;
            this.buttonContaBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContaBuscar.Location = new System.Drawing.Point(46, 40);
            this.buttonContaBuscar.Name = "buttonContaBuscar";
            this.buttonContaBuscar.Size = new System.Drawing.Size(20, 20);
            this.buttonContaBuscar.TabIndex = 1;
            this.buttonContaBuscar.UseVisualStyleBackColor = true;
            this.buttonContaBuscar.Click += new System.EventHandler(this.buttonContaBuscar_Click);
            // 
            // labelContaDescricao
            // 
            this.labelContaDescricao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelContaDescricao.Location = new System.Drawing.Point(95, 39);
            this.labelContaDescricao.Name = "labelContaDescricao";
            this.labelContaDescricao.Size = new System.Drawing.Size(327, 21);
            this.labelContaDescricao.TabIndex = 4;
            this.labelContaDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxContaCod
            // 
            this.textBoxContaCod.Location = new System.Drawing.Point(12, 40);
            this.textBoxContaCod.Name = "textBoxContaCod";
            this.textBoxContaCod.Size = new System.Drawing.Size(30, 20);
            this.textBoxContaCod.TabIndex = 0;
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(92, 26);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(148, 13);
            this.labelDestino.TabIndex = 3;
            this.labelDestino.Text = "Selecione a conta de destino:";
            // 
            // labelPagamento
            // 
            this.labelPagamento.AutoSize = true;
            this.labelPagamento.Location = new System.Drawing.Point(12, 77);
            this.labelPagamento.Name = "labelPagamento";
            this.labelPagamento.Size = new System.Drawing.Size(110, 13);
            this.labelPagamento.TabIndex = 5;
            this.labelPagamento.Text = "Forma de pagamento:";
            // 
            // labelDinheiro
            // 
            this.labelDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDinheiro.Location = new System.Drawing.Point(12, 91);
            this.labelDinheiro.Name = "labelDinheiro";
            this.labelDinheiro.Size = new System.Drawing.Size(110, 21);
            this.labelDinheiro.TabIndex = 6;
            this.labelDinheiro.Text = "DINHEIRO";
            this.labelDinheiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCaixa
            // 
            this.labelCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaixa.ForeColor = System.Drawing.Color.Maroon;
            this.labelCaixa.Location = new System.Drawing.Point(130, 91);
            this.labelCaixa.Name = "labelCaixa";
            this.labelCaixa.Size = new System.Drawing.Size(160, 21);
            this.labelCaixa.TabIndex = 8;
            this.labelCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDinh
            // 
            this.labelDinh.AutoSize = true;
            this.labelDinh.Location = new System.Drawing.Point(130, 77);
            this.labelDinh.Name = "labelDinh";
            this.labelDinh.Size = new System.Drawing.Size(53, 13);
            this.labelDinh.TabIndex = 7;
            this.labelDinh.Text = "Em caixa:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(319, 91);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(103, 20);
            this.textBoxValor.TabIndex = 11;
            this.textBoxValor.TextChanged += new System.EventHandler(this.textBoxValor_TextChanged);
            // 
            // labelRS
            // 
            this.labelRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRS.Location = new System.Drawing.Point(296, 91);
            this.labelRS.Name = "labelRS";
            this.labelRS.Size = new System.Drawing.Size(23, 20);
            this.labelRS.TabIndex = 10;
            this.labelRS.Text = "R$";
            this.labelRS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSangria
            // 
            this.labelSangria.AutoSize = true;
            this.labelSangria.Location = new System.Drawing.Point(296, 75);
            this.labelSangria.Name = "labelSangria";
            this.labelSangria.Size = new System.Drawing.Size(86, 13);
            this.labelSangria.TabIndex = 9;
            this.labelSangria.Text = "Valor da sangria:";
            // 
            // textBoxObs
            // 
            this.textBoxObs.Location = new System.Drawing.Point(12, 128);
            this.textBoxObs.MaxLength = 255;
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(410, 40);
            this.textBoxObs.TabIndex = 12;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(245, 174);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 40);
            this.buttonSalvar.TabIndex = 13;
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
            this.buttonFechar.Location = new System.Drawing.Point(337, 174);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 14;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // labelObs
            // 
            this.labelObs.AutoSize = true;
            this.labelObs.Location = new System.Drawing.Point(12, 112);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(73, 13);
            this.labelObs.TabIndex = 15;
            this.labelObs.Text = "Observações:";
            // 
            // FormSangria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 224);
            this.Controls.Add(this.labelObs);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.textBoxObs);
            this.Controls.Add(this.labelSangria);
            this.Controls.Add(this.labelRS);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.labelCaixa);
            this.Controls.Add(this.labelDinh);
            this.Controls.Add(this.labelDinheiro);
            this.Controls.Add(this.labelPagamento);
            this.Controls.Add(this.labelDestino);
            this.Controls.Add(this.buttonContaAdd);
            this.Controls.Add(this.buttonContaBuscar);
            this.Controls.Add(this.labelContaDescricao);
            this.Controls.Add(this.textBoxContaCod);
            this.Name = "FormSangria";
            this.Text = "Sangria";
            this.Load += new System.EventHandler(this.FormSangria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonContaAdd;
        private System.Windows.Forms.Button buttonContaBuscar;
        private System.Windows.Forms.Label labelContaDescricao;
        private System.Windows.Forms.TextBox textBoxContaCod;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Label labelPagamento;
        private System.Windows.Forms.Label labelDinheiro;
        private System.Windows.Forms.Label labelCaixa;
        private System.Windows.Forms.Label labelDinh;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label labelRS;
        private System.Windows.Forms.Label labelSangria;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Label labelObs;
    }
}
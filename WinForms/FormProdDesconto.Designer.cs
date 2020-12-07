namespace WinForms
{
    partial class FormProdDesconto
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
            this.radioButtonPorcento = new System.Windows.Forms.RadioButton();
            this.radioButtonValor = new System.Windows.Forms.RadioButton();
            this.groupBoxAcresc = new System.Windows.Forms.GroupBox();
            this.radioButtonAcres = new System.Windows.Forms.RadioButton();
            this.radioButtonDecresc = new System.Windows.Forms.RadioButton();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDesconto = new System.Windows.Forms.TextBox();
            this.labelValorAtual = new System.Windows.Forms.Label();
            this.labelAtual = new System.Windows.Forms.Label();
            this.labelDescricaoProd = new System.Windows.Forms.Label();
            this.labelDef = new System.Windows.Forms.Label();
            this.labelDesconto = new System.Windows.Forms.Label();
            this.labelValorDesconto = new System.Windows.Forms.Label();
            this.groupBoxDesconto = new System.Windows.Forms.GroupBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxAcresc.SuspendLayout();
            this.groupBoxDesconto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPorcento);
            this.groupBox1.Controls.Add(this.radioButtonValor);
            this.groupBox1.Location = new System.Drawing.Point(226, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 38);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Como será aplicado?";
            // 
            // radioButtonPorcento
            // 
            this.radioButtonPorcento.AutoSize = true;
            this.radioButtonPorcento.Location = new System.Drawing.Point(6, 15);
            this.radioButtonPorcento.Name = "radioButtonPorcento";
            this.radioButtonPorcento.Size = new System.Drawing.Size(82, 17);
            this.radioButtonPorcento.TabIndex = 0;
            this.radioButtonPorcento.Text = "&Porcento %:";
            this.radioButtonPorcento.UseVisualStyleBackColor = true;
            this.radioButtonPorcento.CheckedChanged += new System.EventHandler(this.radioButtonPorcento_CheckedChanged);
            // 
            // radioButtonValor
            // 
            this.radioButtonValor.AutoSize = true;
            this.radioButtonValor.Checked = true;
            this.radioButtonValor.Location = new System.Drawing.Point(94, 15);
            this.radioButtonValor.Name = "radioButtonValor";
            this.radioButtonValor.Size = new System.Drawing.Size(61, 17);
            this.radioButtonValor.TabIndex = 1;
            this.radioButtonValor.TabStop = true;
            this.radioButtonValor.Text = "&Valor $:";
            this.radioButtonValor.UseVisualStyleBackColor = true;
            // 
            // groupBoxAcresc
            // 
            this.groupBoxAcresc.Controls.Add(this.radioButtonAcres);
            this.groupBoxAcresc.Controls.Add(this.radioButtonDecresc);
            this.groupBoxAcresc.Location = new System.Drawing.Point(40, 19);
            this.groupBoxAcresc.Name = "groupBoxAcresc";
            this.groupBoxAcresc.Size = new System.Drawing.Size(180, 38);
            this.groupBoxAcresc.TabIndex = 2;
            this.groupBoxAcresc.TabStop = false;
            this.groupBoxAcresc.Text = "O que deseja conceder?";
            // 
            // radioButtonAcres
            // 
            this.radioButtonAcres.AutoSize = true;
            this.radioButtonAcres.Location = new System.Drawing.Point(96, 15);
            this.radioButtonAcres.Name = "radioButtonAcres";
            this.radioButtonAcres.Size = new System.Drawing.Size(77, 17);
            this.radioButtonAcres.TabIndex = 1;
            this.radioButtonAcres.Text = "&Acréscimo:";
            this.radioButtonAcres.UseVisualStyleBackColor = true;
            // 
            // radioButtonDecresc
            // 
            this.radioButtonDecresc.AutoSize = true;
            this.radioButtonDecresc.Checked = true;
            this.radioButtonDecresc.Location = new System.Drawing.Point(6, 15);
            this.radioButtonDecresc.Name = "radioButtonDecresc";
            this.radioButtonDecresc.Size = new System.Drawing.Size(74, 17);
            this.radioButtonDecresc.TabIndex = 0;
            this.radioButtonDecresc.TabStop = true;
            this.radioButtonDecresc.Text = "&Desconto:";
            this.radioButtonDecresc.UseVisualStyleBackColor = true;
            this.radioButtonDecresc.CheckedChanged += new System.EventHandler(this.radioButtonDecresc_CheckedChanged);
            // 
            // labelDescricao
            // 
            this.labelDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(13, 22);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(449, 23);
            this.labelDescricao.TabIndex = 1;
            this.labelDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDesconto
            // 
            this.textBoxDesconto.Location = new System.Drawing.Point(162, 72);
            this.textBoxDesconto.Name = "textBoxDesconto";
            this.textBoxDesconto.Size = new System.Drawing.Size(120, 20);
            this.textBoxDesconto.TabIndex = 7;
            this.textBoxDesconto.TextChanged += new System.EventHandler(this.textBoxDesconto_TextChanged);
            // 
            // labelValorAtual
            // 
            this.labelValorAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorAtual.Location = new System.Drawing.Point(34, 72);
            this.labelValorAtual.Name = "labelValorAtual";
            this.labelValorAtual.Size = new System.Drawing.Size(120, 20);
            this.labelValorAtual.TabIndex = 5;
            this.labelValorAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAtual
            // 
            this.labelAtual.AutoSize = true;
            this.labelAtual.Location = new System.Drawing.Point(34, 59);
            this.labelAtual.Name = "labelAtual";
            this.labelAtual.Size = new System.Drawing.Size(60, 13);
            this.labelAtual.TabIndex = 4;
            this.labelAtual.Text = "Valor atual:";
            // 
            // labelDescricaoProd
            // 
            this.labelDescricaoProd.AutoSize = true;
            this.labelDescricaoProd.Location = new System.Drawing.Point(13, 9);
            this.labelDescricaoProd.Name = "labelDescricaoProd";
            this.labelDescricaoProd.Size = new System.Drawing.Size(112, 13);
            this.labelDescricaoProd.TabIndex = 0;
            this.labelDescricaoProd.Text = "Descrição do produto:";
            // 
            // labelDef
            // 
            this.labelDef.AutoSize = true;
            this.labelDef.Location = new System.Drawing.Point(162, 59);
            this.labelDef.Name = "labelDef";
            this.labelDef.Size = new System.Drawing.Size(96, 13);
            this.labelDef.TabIndex = 6;
            this.labelDef.Text = "Valor do de&sconto:";
            // 
            // labelDesconto
            // 
            this.labelDesconto.AutoSize = true;
            this.labelDesconto.Location = new System.Drawing.Point(290, 59);
            this.labelDesconto.Name = "labelDesconto";
            this.labelDesconto.Size = new System.Drawing.Size(60, 13);
            this.labelDesconto.TabIndex = 8;
            this.labelDesconto.Text = "Valor atual:";
            // 
            // labelValorDesconto
            // 
            this.labelValorDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorDesconto.Location = new System.Drawing.Point(290, 72);
            this.labelValorDesconto.Name = "labelValorDesconto";
            this.labelValorDesconto.Size = new System.Drawing.Size(120, 20);
            this.labelValorDesconto.TabIndex = 9;
            this.labelValorDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxDesconto
            // 
            this.groupBoxDesconto.Controls.Add(this.groupBoxAcresc);
            this.groupBoxDesconto.Controls.Add(this.labelDesconto);
            this.groupBoxDesconto.Controls.Add(this.groupBox1);
            this.groupBoxDesconto.Controls.Add(this.labelValorDesconto);
            this.groupBoxDesconto.Controls.Add(this.textBoxDesconto);
            this.groupBoxDesconto.Controls.Add(this.labelValorAtual);
            this.groupBoxDesconto.Controls.Add(this.labelAtual);
            this.groupBoxDesconto.Controls.Add(this.labelDef);
            this.groupBoxDesconto.Location = new System.Drawing.Point(12, 48);
            this.groupBoxDesconto.Name = "groupBoxDesconto";
            this.groupBoxDesconto.Size = new System.Drawing.Size(450, 106);
            this.groupBoxDesconto.TabIndex = 12;
            this.groupBoxDesconto.TabStop = false;
            this.groupBoxDesconto.Text = "Desconto/Acréscimo:";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonConfirmar.Location = new System.Drawing.Point(285, 160);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(85, 40);
            this.buttonConfirmar.TabIndex = 32;
            this.buttonConfirmar.Text = "&Salvar";
            this.buttonConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(377, 160);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 33;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormProdDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 210);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.groupBoxDesconto);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.labelDescricaoProd);
            this.Controls.Add(this.labelDescricao);
            this.KeyPreview = true;
            this.Name = "FormProdDesconto";
            this.Text = "Acréscimos/Descontos";
            this.Load += new System.EventHandler(this.FormProdDesconto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProdDesconto_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxAcresc.ResumeLayout(false);
            this.groupBoxAcresc.PerformLayout();
            this.groupBoxDesconto.ResumeLayout(false);
            this.groupBoxDesconto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPorcento;
        private System.Windows.Forms.RadioButton radioButtonValor;
        private System.Windows.Forms.GroupBox groupBoxAcresc;
        private System.Windows.Forms.RadioButton radioButtonAcres;
        private System.Windows.Forms.RadioButton radioButtonDecresc;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxDesconto;
        private System.Windows.Forms.Label labelValorAtual;
        private System.Windows.Forms.Label labelAtual;
        private System.Windows.Forms.Label labelDescricaoProd;
        private System.Windows.Forms.Label labelDef;
        private System.Windows.Forms.Label labelDesconto;
        private System.Windows.Forms.Label labelValorDesconto;
        private System.Windows.Forms.GroupBox groupBoxDesconto;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonFechar;
    }
}
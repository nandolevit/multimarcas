namespace WinForms
{
    partial class FormProdutoDefeito
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
            this.textBoxDefeito = new System.Windows.Forms.TextBox();
            this.labelDefeito = new System.Windows.Forms.Label();
            this.textBoxCodProd = new System.Windows.Forms.TextBox();
            this.labelProd = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.textBoxProdDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTipoDescricao = new System.Windows.Forms.Label();
            this.textBoxCodTipo = new System.Windows.Forms.TextBox();
            this.buttonAddEletro = new System.Windows.Forms.Button();
            this.buttonBuscarEletro = new System.Windows.Forms.Button();
            this.buttonBuscarTipo = new System.Windows.Forms.Button();
            this.groupBoxDecricao = new System.Windows.Forms.GroupBox();
            this.groupBoxDecricao.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDefeito
            // 
            this.textBoxDefeito.Location = new System.Drawing.Point(6, 82);
            this.textBoxDefeito.Name = "textBoxDefeito";
            this.textBoxDefeito.Size = new System.Drawing.Size(732, 20);
            this.textBoxDefeito.TabIndex = 10;
            // 
            // labelDefeito
            // 
            this.labelDefeito.AutoSize = true;
            this.labelDefeito.Location = new System.Drawing.Point(6, 67);
            this.labelDefeito.Name = "labelDefeito";
            this.labelDefeito.Size = new System.Drawing.Size(44, 13);
            this.labelDefeito.TabIndex = 9;
            this.labelDefeito.Text = "Defeito:";
            // 
            // textBoxCodProd
            // 
            this.textBoxCodProd.Location = new System.Drawing.Point(6, 43);
            this.textBoxCodProd.Name = "textBoxCodProd";
            this.textBoxCodProd.Size = new System.Drawing.Size(30, 20);
            this.textBoxCodProd.TabIndex = 4;
            // 
            // labelProd
            // 
            this.labelProd.AutoSize = true;
            this.labelProd.Location = new System.Drawing.Point(88, 27);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(47, 13);
            this.labelProd.TabIndex = 7;
            this.labelProd.Text = "Produto:";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(583, 126);
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
            this.buttonFechar.Location = new System.Drawing.Point(675, 126);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 2;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // textBoxProdDescricao
            // 
            this.textBoxProdDescricao.Location = new System.Drawing.Point(91, 43);
            this.textBoxProdDescricao.Multiline = true;
            this.textBoxProdDescricao.Name = "textBoxProdDescricao";
            this.textBoxProdDescricao.ReadOnly = true;
            this.textBoxProdDescricao.Size = new System.Drawing.Size(647, 21);
            this.textBoxProdDescricao.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de OS:";
            // 
            // labelTipoDescricao
            // 
            this.labelTipoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTipoDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoDescricao.Location = new System.Drawing.Point(503, 16);
            this.labelTipoDescricao.Name = "labelTipoDescricao";
            this.labelTipoDescricao.Size = new System.Drawing.Size(235, 21);
            this.labelTipoDescricao.TabIndex = 3;
            this.labelTipoDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCodTipo
            // 
            this.textBoxCodTipo.Location = new System.Drawing.Point(442, 17);
            this.textBoxCodTipo.Name = "textBoxCodTipo";
            this.textBoxCodTipo.Size = new System.Drawing.Size(30, 20);
            this.textBoxCodTipo.TabIndex = 1;
            this.textBoxCodTipo.Leave += new System.EventHandler(this.textBoxCodTipo_Leave);
            // 
            // buttonAddEletro
            // 
            this.buttonAddEletro.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddEletro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddEletro.FlatAppearance.BorderSize = 0;
            this.buttonAddEletro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEletro.Location = new System.Drawing.Point(65, 44);
            this.buttonAddEletro.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddEletro.Name = "buttonAddEletro";
            this.buttonAddEletro.Size = new System.Drawing.Size(20, 20);
            this.buttonAddEletro.TabIndex = 6;
            this.buttonAddEletro.UseVisualStyleBackColor = true;
            this.buttonAddEletro.Click += new System.EventHandler(this.buttonAddEletro_Click);
            // 
            // buttonBuscarEletro
            // 
            this.buttonBuscarEletro.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscarEletro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarEletro.FlatAppearance.BorderSize = 0;
            this.buttonBuscarEletro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarEletro.Location = new System.Drawing.Point(45, 44);
            this.buttonBuscarEletro.Name = "buttonBuscarEletro";
            this.buttonBuscarEletro.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarEletro.TabIndex = 5;
            this.buttonBuscarEletro.UseVisualStyleBackColor = true;
            this.buttonBuscarEletro.Click += new System.EventHandler(this.buttonBuscarEletro_Click);
            // 
            // buttonBuscarTipo
            // 
            this.buttonBuscarTipo.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscarTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarTipo.FlatAppearance.BorderSize = 0;
            this.buttonBuscarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarTipo.Location = new System.Drawing.Point(478, 17);
            this.buttonBuscarTipo.Name = "buttonBuscarTipo";
            this.buttonBuscarTipo.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarTipo.TabIndex = 2;
            this.buttonBuscarTipo.UseVisualStyleBackColor = true;
            this.buttonBuscarTipo.Click += new System.EventHandler(this.buttonBuscarTipo_Click);
            // 
            // groupBoxDecricao
            // 
            this.groupBoxDecricao.Controls.Add(this.textBoxDefeito);
            this.groupBoxDecricao.Controls.Add(this.buttonBuscarTipo);
            this.groupBoxDecricao.Controls.Add(this.labelDefeito);
            this.groupBoxDecricao.Controls.Add(this.buttonAddEletro);
            this.groupBoxDecricao.Controls.Add(this.labelProd);
            this.groupBoxDecricao.Controls.Add(this.buttonBuscarEletro);
            this.groupBoxDecricao.Controls.Add(this.textBoxCodProd);
            this.groupBoxDecricao.Controls.Add(this.label1);
            this.groupBoxDecricao.Controls.Add(this.textBoxProdDescricao);
            this.groupBoxDecricao.Controls.Add(this.labelTipoDescricao);
            this.groupBoxDecricao.Controls.Add(this.textBoxCodTipo);
            this.groupBoxDecricao.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDecricao.Name = "groupBoxDecricao";
            this.groupBoxDecricao.Size = new System.Drawing.Size(748, 108);
            this.groupBoxDecricao.TabIndex = 0;
            this.groupBoxDecricao.TabStop = false;
            this.groupBoxDecricao.Text = "Produto/Defeito:";
            // 
            // FormProdutoDefeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 178);
            this.Controls.Add(this.groupBoxDecricao);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonFechar);
            this.Name = "FormProdutoDefeito";
            this.Text = "Informe o produto e o defeito...";
            this.Load += new System.EventHandler(this.FormProdutoDefeito_Load);
            this.groupBoxDecricao.ResumeLayout(false);
            this.groupBoxDecricao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDefeito;
        private System.Windows.Forms.Label labelDefeito;
        private System.Windows.Forms.TextBox textBoxCodProd;
        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.TextBox textBoxProdDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTipoDescricao;
        private System.Windows.Forms.TextBox textBoxCodTipo;
        private System.Windows.Forms.Button buttonAddEletro;
        private System.Windows.Forms.Button buttonBuscarEletro;
        private System.Windows.Forms.Button buttonBuscarTipo;
        private System.Windows.Forms.GroupBox groupBoxDecricao;
    }
}
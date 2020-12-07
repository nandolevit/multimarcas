namespace WinForms
{
    partial class FormCadEletro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadEletro));
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelProduto = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.labelPnc = new System.Windows.Forms.Label();
            this.textBoxPnc = new System.Windows.Forms.TextBox();
            this.labelSerie = new System.Windows.Forms.Label();
            this.textBoxSerie = new System.Windows.Forms.TextBox();
            this.labelObs = new System.Windows.Forms.Label();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.labelProdDescricao = new System.Windows.Forms.Label();
            this.textBoxCodProd = new System.Windows.Forms.TextBox();
            this.labelMarcaDescricao = new System.Windows.Forms.Label();
            this.textBoxCodMarca = new System.Windows.Forms.TextBox();
            this.labelChamado = new System.Windows.Forms.Label();
            this.textBoxChamado = new System.Windows.Forms.TextBox();
            this.buttonAddMarca = new System.Windows.Forms.Button();
            this.buttonBuscarMarca = new System.Windows.Forms.Button();
            this.buttonAddProduto = new System.Windows.Forms.Button();
            this.buttonBuscarProduto = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(111, 84);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 10;
            this.labelMarca.Text = "Marca:";
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Location = new System.Drawing.Point(111, 50);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(47, 13);
            this.labelProduto.TabIndex = 5;
            this.labelProduto.Text = "Produto:";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(31, 124);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(45, 13);
            this.labelModelo.TabIndex = 12;
            this.labelModelo.Text = "Modelo:";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(31, 137);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(352, 20);
            this.textBoxModelo.TabIndex = 13;
            // 
            // labelPnc
            // 
            this.labelPnc.AutoSize = true;
            this.labelPnc.Location = new System.Drawing.Point(31, 194);
            this.labelPnc.Name = "labelPnc";
            this.labelPnc.Size = new System.Drawing.Size(32, 13);
            this.labelPnc.TabIndex = 16;
            this.labelPnc.Text = "PNC:";
            // 
            // textBoxPnc
            // 
            this.textBoxPnc.Location = new System.Drawing.Point(31, 207);
            this.textBoxPnc.Name = "textBoxPnc";
            this.textBoxPnc.Size = new System.Drawing.Size(169, 20);
            this.textBoxPnc.TabIndex = 17;
            // 
            // labelSerie
            // 
            this.labelSerie.AutoSize = true;
            this.labelSerie.Location = new System.Drawing.Point(31, 159);
            this.labelSerie.Name = "labelSerie";
            this.labelSerie.Size = new System.Drawing.Size(34, 13);
            this.labelSerie.TabIndex = 14;
            this.labelSerie.Text = "Série:";
            // 
            // textBoxSerie
            // 
            this.textBoxSerie.Location = new System.Drawing.Point(31, 172);
            this.textBoxSerie.Name = "textBoxSerie";
            this.textBoxSerie.Size = new System.Drawing.Size(352, 20);
            this.textBoxSerie.TabIndex = 15;
            // 
            // labelObs
            // 
            this.labelObs.AutoSize = true;
            this.labelObs.Location = new System.Drawing.Point(31, 229);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(29, 13);
            this.labelObs.TabIndex = 20;
            this.labelObs.Text = "Obs:";
            // 
            // textBoxObs
            // 
            this.textBoxObs.Location = new System.Drawing.Point(31, 242);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(352, 93);
            this.textBoxObs.TabIndex = 21;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(31, 16);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(42, 13);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "Cliente:";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Enabled = false;
            this.textBoxCliente.Location = new System.Drawing.Point(31, 29);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(352, 20);
            this.textBoxCliente.TabIndex = 1;
            // 
            // labelProdDescricao
            // 
            this.labelProdDescricao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelProdDescricao.Location = new System.Drawing.Point(114, 63);
            this.labelProdDescricao.Name = "labelProdDescricao";
            this.labelProdDescricao.Size = new System.Drawing.Size(269, 21);
            this.labelProdDescricao.TabIndex = 6;
            this.labelProdDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCodProd
            // 
            this.textBoxCodProd.Location = new System.Drawing.Point(31, 64);
            this.textBoxCodProd.Name = "textBoxCodProd";
            this.textBoxCodProd.Size = new System.Drawing.Size(30, 20);
            this.textBoxCodProd.TabIndex = 2;
            this.textBoxCodProd.Leave += new System.EventHandler(this.textBoxCodProd_Leave);
            // 
            // labelMarcaDescricao
            // 
            this.labelMarcaDescricao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMarcaDescricao.Location = new System.Drawing.Point(114, 100);
            this.labelMarcaDescricao.Name = "labelMarcaDescricao";
            this.labelMarcaDescricao.Size = new System.Drawing.Size(269, 21);
            this.labelMarcaDescricao.TabIndex = 11;
            this.labelMarcaDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCodMarca
            // 
            this.textBoxCodMarca.Location = new System.Drawing.Point(31, 101);
            this.textBoxCodMarca.Name = "textBoxCodMarca";
            this.textBoxCodMarca.Size = new System.Drawing.Size(30, 20);
            this.textBoxCodMarca.TabIndex = 7;
            this.textBoxCodMarca.Leave += new System.EventHandler(this.textBoxCodMarca_Leave);
            // 
            // labelChamado
            // 
            this.labelChamado.AutoSize = true;
            this.labelChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChamado.ForeColor = System.Drawing.Color.Maroon;
            this.labelChamado.Location = new System.Drawing.Point(206, 194);
            this.labelChamado.Name = "labelChamado";
            this.labelChamado.Size = new System.Drawing.Size(72, 13);
            this.labelChamado.TabIndex = 18;
            this.labelChamado.Text = "CHAMADO:";
            // 
            // textBoxChamado
            // 
            this.textBoxChamado.Location = new System.Drawing.Point(206, 207);
            this.textBoxChamado.Name = "textBoxChamado";
            this.textBoxChamado.Size = new System.Drawing.Size(177, 20);
            this.textBoxChamado.TabIndex = 19;
            // 
            // buttonAddMarca
            // 
            this.buttonAddMarca.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddMarca.FlatAppearance.BorderSize = 0;
            this.buttonAddMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMarca.Location = new System.Drawing.Point(85, 101);
            this.buttonAddMarca.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddMarca.Name = "buttonAddMarca";
            this.buttonAddMarca.Size = new System.Drawing.Size(20, 20);
            this.buttonAddMarca.TabIndex = 9;
            this.buttonAddMarca.UseVisualStyleBackColor = true;
            this.buttonAddMarca.Click += new System.EventHandler(this.buttonAddMarca_Click);
            // 
            // buttonBuscarMarca
            // 
            this.buttonBuscarMarca.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarMarca.FlatAppearance.BorderSize = 0;
            this.buttonBuscarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarMarca.Location = new System.Drawing.Point(65, 101);
            this.buttonBuscarMarca.Name = "buttonBuscarMarca";
            this.buttonBuscarMarca.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarMarca.TabIndex = 8;
            this.buttonBuscarMarca.UseVisualStyleBackColor = true;
            this.buttonBuscarMarca.Click += new System.EventHandler(this.buttonBuscarMarca_Click);
            // 
            // buttonAddProduto
            // 
            this.buttonAddProduto.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddProduto.FlatAppearance.BorderSize = 0;
            this.buttonAddProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProduto.Location = new System.Drawing.Point(85, 64);
            this.buttonAddProduto.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddProduto.Name = "buttonAddProduto";
            this.buttonAddProduto.Size = new System.Drawing.Size(20, 20);
            this.buttonAddProduto.TabIndex = 4;
            this.buttonAddProduto.UseVisualStyleBackColor = true;
            this.buttonAddProduto.Click += new System.EventHandler(this.buttonAddProduto_Click);
            // 
            // buttonBuscarProduto
            // 
            this.buttonBuscarProduto.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarProduto.FlatAppearance.BorderSize = 0;
            this.buttonBuscarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarProduto.Location = new System.Drawing.Point(65, 64);
            this.buttonBuscarProduto.Name = "buttonBuscarProduto";
            this.buttonBuscarProduto.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarProduto.TabIndex = 3;
            this.buttonBuscarProduto.UseVisualStyleBackColor = true;
            this.buttonBuscarProduto.Click += new System.EventHandler(this.buttonBuscarProduto_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(206, 341);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 40);
            this.buttonSalvar.TabIndex = 22;
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
            this.buttonFechar.Location = new System.Drawing.Point(298, 341);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 23;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormCadEletro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 396);
            this.Controls.Add(this.labelChamado);
            this.Controls.Add(this.textBoxChamado);
            this.Controls.Add(this.buttonAddMarca);
            this.Controls.Add(this.buttonBuscarMarca);
            this.Controls.Add(this.buttonAddProduto);
            this.Controls.Add(this.buttonBuscarProduto);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.labelMarcaDescricao);
            this.Controls.Add(this.textBoxCodMarca);
            this.Controls.Add(this.labelProdDescricao);
            this.Controls.Add(this.textBoxCodProd);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.labelObs);
            this.Controls.Add(this.textBoxObs);
            this.Controls.Add(this.labelSerie);
            this.Controls.Add(this.textBoxSerie);
            this.Controls.Add(this.labelPnc);
            this.Controls.Add(this.textBoxPnc);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelProduto);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.textBoxModelo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadEletro";
            this.Text = "Novo Produto...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label labelPnc;
        private System.Windows.Forms.TextBox textBoxPnc;
        private System.Windows.Forms.Label labelSerie;
        private System.Windows.Forms.TextBox textBoxSerie;
        private System.Windows.Forms.Label labelObs;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label labelProdDescricao;
        private System.Windows.Forms.TextBox textBoxCodProd;
        private System.Windows.Forms.Label labelMarcaDescricao;
        private System.Windows.Forms.TextBox textBoxCodMarca;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonAddProduto;
        private System.Windows.Forms.Button buttonBuscarProduto;
        private System.Windows.Forms.Button buttonAddMarca;
        private System.Windows.Forms.Button buttonBuscarMarca;
        private System.Windows.Forms.Label labelChamado;
        private System.Windows.Forms.TextBox textBoxChamado;
    }
}
namespace WinForms
{
    partial class FormLancamentos
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
            this.groupBoxLancamentos = new System.Windows.Forms.GroupBox();
            this.groupBoxCategoria = new System.Windows.Forms.GroupBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxCodCat = new System.Windows.Forms.TextBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.radioButtonSaidas = new System.Windows.Forms.RadioButton();
            this.radioButtonEntradas = new System.Windows.Forms.RadioButton();
            this.groupBoxGeral = new System.Windows.Forms.GroupBox();
            this.labelValorLancado = new System.Windows.Forms.Label();
            this.labelParcela = new System.Windows.Forms.Label();
            this.labelNumParcela = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelDataVenc = new System.Windows.Forms.Label();
            this.dateTimePickerVenc = new System.Windows.Forms.DateTimePicker();
            this.labelLanc = new System.Windows.Forms.Label();
            this.labelDataLanc = new System.Windows.Forms.Label();
            this.labelObs = new System.Windows.Forms.Label();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelValorRecebido = new System.Windows.Forms.Label();
            this.labelFunc = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonParcelas = new System.Windows.Forms.Button();
            this.buttonCategoriaAdd = new System.Windows.Forms.Button();
            this.buttonCategoriaBuscar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxLancamentos.SuspendLayout();
            this.groupBoxCategoria.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLancamentos
            // 
            this.groupBoxLancamentos.Controls.Add(this.groupBoxCategoria);
            this.groupBoxLancamentos.Controls.Add(this.groupBoxInfo);
            this.groupBoxLancamentos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLancamentos.Name = "groupBoxLancamentos";
            this.groupBoxLancamentos.Size = new System.Drawing.Size(636, 73);
            this.groupBoxLancamentos.TabIndex = 0;
            this.groupBoxLancamentos.TabStop = false;
            this.groupBoxLancamentos.Text = "Informações sobre o lançamento:";
            // 
            // groupBoxCategoria
            // 
            this.groupBoxCategoria.Controls.Add(this.buttonCategoriaAdd);
            this.groupBoxCategoria.Controls.Add(this.buttonCategoriaBuscar);
            this.groupBoxCategoria.Controls.Add(this.labelDescricao);
            this.groupBoxCategoria.Controls.Add(this.textBoxCodCat);
            this.groupBoxCategoria.Location = new System.Drawing.Point(259, 11);
            this.groupBoxCategoria.Name = "groupBoxCategoria";
            this.groupBoxCategoria.Size = new System.Drawing.Size(367, 50);
            this.groupBoxCategoria.TabIndex = 1;
            this.groupBoxCategoria.TabStop = false;
            this.groupBoxCategoria.Text = "Categoria";
            // 
            // labelDescricao
            // 
            this.labelDescricao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDescricao.Location = new System.Drawing.Point(89, 19);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(269, 21);
            this.labelDescricao.TabIndex = 1;
            this.labelDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCodCat
            // 
            this.textBoxCodCat.Location = new System.Drawing.Point(6, 20);
            this.textBoxCodCat.Name = "textBoxCodCat";
            this.textBoxCodCat.Size = new System.Drawing.Size(30, 20);
            this.textBoxCodCat.TabIndex = 0;
            this.textBoxCodCat.TextChanged += new System.EventHandler(this.textBoxCodCat_TextChanged);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.radioButtonSaidas);
            this.groupBoxInfo.Controls.Add(this.radioButtonEntradas);
            this.groupBoxInfo.Location = new System.Drawing.Point(9, 18);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(244, 36);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Tipo de transação:";
            // 
            // radioButtonSaidas
            // 
            this.radioButtonSaidas.AutoSize = true;
            this.radioButtonSaidas.Checked = true;
            this.radioButtonSaidas.Location = new System.Drawing.Point(126, 15);
            this.radioButtonSaidas.Name = "radioButtonSaidas";
            this.radioButtonSaidas.Size = new System.Drawing.Size(111, 17);
            this.radioButtonSaidas.TabIndex = 1;
            this.radioButtonSaidas.TabStop = true;
            this.radioButtonSaidas.Text = "&Saídas/Despesas";
            this.radioButtonSaidas.UseVisualStyleBackColor = true;
            // 
            // radioButtonEntradas
            // 
            this.radioButtonEntradas.AutoSize = true;
            this.radioButtonEntradas.Location = new System.Drawing.Point(6, 15);
            this.radioButtonEntradas.Name = "radioButtonEntradas";
            this.radioButtonEntradas.Size = new System.Drawing.Size(114, 17);
            this.radioButtonEntradas.TabIndex = 0;
            this.radioButtonEntradas.Text = "&Entradas/Receitas";
            this.radioButtonEntradas.UseVisualStyleBackColor = true;
            this.radioButtonEntradas.CheckedChanged += new System.EventHandler(this.radioButtonEntradas_CheckedChanged);
            // 
            // groupBoxGeral
            // 
            this.groupBoxGeral.Controls.Add(this.buttonParcelas);
            this.groupBoxGeral.Controls.Add(this.labelValorLancado);
            this.groupBoxGeral.Controls.Add(this.labelParcela);
            this.groupBoxGeral.Controls.Add(this.labelNumParcela);
            this.groupBoxGeral.Controls.Add(this.textBoxValor);
            this.groupBoxGeral.Controls.Add(this.labelDataVenc);
            this.groupBoxGeral.Controls.Add(this.dateTimePickerVenc);
            this.groupBoxGeral.Controls.Add(this.labelLanc);
            this.groupBoxGeral.Controls.Add(this.labelDataLanc);
            this.groupBoxGeral.Location = new System.Drawing.Point(13, 91);
            this.groupBoxGeral.Name = "groupBoxGeral";
            this.groupBoxGeral.Size = new System.Drawing.Size(635, 100);
            this.groupBoxGeral.TabIndex = 1;
            this.groupBoxGeral.TabStop = false;
            this.groupBoxGeral.Text = "Informações gerais:";
            // 
            // labelValorLancado
            // 
            this.labelValorLancado.AutoSize = true;
            this.labelValorLancado.Location = new System.Drawing.Point(399, 16);
            this.labelValorLancado.Name = "labelValorLancado";
            this.labelValorLancado.Size = new System.Drawing.Size(107, 13);
            this.labelValorLancado.TabIndex = 4;
            this.labelValorLancado.Text = "&Valor do lançamento:";
            // 
            // labelParcela
            // 
            this.labelParcela.AutoSize = true;
            this.labelParcela.Location = new System.Drawing.Point(533, 16);
            this.labelParcela.Name = "labelParcela";
            this.labelParcela.Size = new System.Drawing.Size(46, 13);
            this.labelParcela.TabIndex = 6;
            this.labelParcela.Text = "Parcela:";
            // 
            // labelNumParcela
            // 
            this.labelNumParcela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNumParcela.Location = new System.Drawing.Point(533, 30);
            this.labelNumParcela.Name = "labelNumParcela";
            this.labelNumParcela.Size = new System.Drawing.Size(56, 23);
            this.labelNumParcela.TabIndex = 7;
            this.labelNumParcela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValor.Location = new System.Drawing.Point(399, 31);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(128, 20);
            this.textBoxValor.TabIndex = 5;
            this.textBoxValor.TextChanged += new System.EventHandler(this.textBoxValor_TextChanged);
            this.textBoxValor.Leave += new System.EventHandler(this.textBoxValor_Leave);
            // 
            // labelDataVenc
            // 
            this.labelDataVenc.AutoSize = true;
            this.labelDataVenc.Location = new System.Drawing.Point(268, 16);
            this.labelDataVenc.Name = "labelDataVenc";
            this.labelDataVenc.Size = new System.Drawing.Size(107, 13);
            this.labelDataVenc.TabIndex = 2;
            this.labelDataVenc.Text = "&Data do Vencimento:";
            // 
            // dateTimePickerVenc
            // 
            this.dateTimePickerVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVenc.Location = new System.Drawing.Point(268, 31);
            this.dateTimePickerVenc.Name = "dateTimePickerVenc";
            this.dateTimePickerVenc.Size = new System.Drawing.Size(125, 20);
            this.dateTimePickerVenc.TabIndex = 3;
            // 
            // labelLanc
            // 
            this.labelLanc.AutoSize = true;
            this.labelLanc.Location = new System.Drawing.Point(11, 16);
            this.labelLanc.Name = "labelLanc";
            this.labelLanc.Size = new System.Drawing.Size(106, 13);
            this.labelLanc.TabIndex = 0;
            this.labelLanc.Text = "Data do lançamento:";
            // 
            // labelDataLanc
            // 
            this.labelDataLanc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDataLanc.Location = new System.Drawing.Point(11, 30);
            this.labelDataLanc.Name = "labelDataLanc";
            this.labelDataLanc.Size = new System.Drawing.Size(251, 23);
            this.labelDataLanc.TabIndex = 1;
            this.labelDataLanc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelObs
            // 
            this.labelObs.AutoSize = true;
            this.labelObs.Location = new System.Drawing.Point(21, 153);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(146, 13);
            this.labelObs.TabIndex = 2;
            this.labelObs.Text = "&Observações do lançamento:";
            // 
            // textBoxObs
            // 
            this.textBoxObs.Location = new System.Drawing.Point(21, 169);
            this.textBoxObs.MaxLength = 255;
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxObs.Size = new System.Drawing.Size(432, 76);
            this.textBoxObs.TabIndex = 3;
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(459, 191);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(61, 13);
            this.labelSaldo.TabIndex = 4;
            this.labelSaldo.Text = "Valor pago:";
            // 
            // labelValorRecebido
            // 
            this.labelValorRecebido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelValorRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorRecebido.Location = new System.Drawing.Point(462, 205);
            this.labelValorRecebido.Name = "labelValorRecebido";
            this.labelValorRecebido.Size = new System.Drawing.Size(186, 40);
            this.labelValorRecebido.TabIndex = 5;
            this.labelValorRecebido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFunc
            // 
            this.labelFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFunc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelFunc.Location = new System.Drawing.Point(13, 275);
            this.labelFunc.Name = "labelFunc";
            this.labelFunc.Size = new System.Drawing.Size(440, 23);
            this.labelFunc.TabIndex = 8;
            this.labelFunc.Text = "Lançado Por: ";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(471, 248);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 40);
            this.buttonSalvar.TabIndex = 6;
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
            this.buttonFechar.Location = new System.Drawing.Point(563, 248);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 7;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonParcelas
            // 
            this.buttonParcelas.BackgroundImage = global::WinForms.Properties.Resources.icons8_Split_Files_32;
            this.buttonParcelas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonParcelas.FlatAppearance.BorderSize = 0;
            this.buttonParcelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParcelas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonParcelas.Location = new System.Drawing.Point(602, 29);
            this.buttonParcelas.Name = "buttonParcelas";
            this.buttonParcelas.Size = new System.Drawing.Size(23, 23);
            this.buttonParcelas.TabIndex = 8;
            this.buttonParcelas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonParcelas, "Gerar parcelas.");
            this.buttonParcelas.UseVisualStyleBackColor = true;
            this.buttonParcelas.Click += new System.EventHandler(this.buttonParcelas_Click);
            // 
            // buttonCategoriaAdd
            // 
            this.buttonCategoriaAdd.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonCategoriaAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCategoriaAdd.FlatAppearance.BorderSize = 0;
            this.buttonCategoriaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategoriaAdd.Location = new System.Drawing.Point(62, 20);
            this.buttonCategoriaAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCategoriaAdd.Name = "buttonCategoriaAdd";
            this.buttonCategoriaAdd.Size = new System.Drawing.Size(20, 20);
            this.buttonCategoriaAdd.TabIndex = 12;
            this.toolTip1.SetToolTip(this.buttonCategoriaAdd, "Adicionar uma nova categoria.");
            this.buttonCategoriaAdd.UseVisualStyleBackColor = true;
            this.buttonCategoriaAdd.Click += new System.EventHandler(this.buttonCategoriaAdd_Click);
            // 
            // buttonCategoriaBuscar
            // 
            this.buttonCategoriaBuscar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonCategoriaBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCategoriaBuscar.FlatAppearance.BorderSize = 0;
            this.buttonCategoriaBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategoriaBuscar.Location = new System.Drawing.Point(42, 20);
            this.buttonCategoriaBuscar.Name = "buttonCategoriaBuscar";
            this.buttonCategoriaBuscar.Size = new System.Drawing.Size(20, 20);
            this.buttonCategoriaBuscar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.buttonCategoriaBuscar, "Selecionar uma categoria.");
            this.buttonCategoriaBuscar.UseVisualStyleBackColor = true;
            this.buttonCategoriaBuscar.Click += new System.EventHandler(this.buttonCategoriaBuscar_Click);
            // 
            // FormLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 300);
            this.Controls.Add(this.labelFunc);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.labelValorRecebido);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.textBoxObs);
            this.Controls.Add(this.labelObs);
            this.Controls.Add(this.groupBoxGeral);
            this.Controls.Add(this.groupBoxLancamentos);
            this.Name = "FormLancamentos";
            this.Text = "Lançamentos";
            this.Load += new System.EventHandler(this.FormLancamentos_Load);
            this.groupBoxLancamentos.ResumeLayout(false);
            this.groupBoxCategoria.ResumeLayout(false);
            this.groupBoxCategoria.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxGeral.ResumeLayout(false);
            this.groupBoxGeral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLancamentos;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.RadioButton radioButtonSaidas;
        private System.Windows.Forms.RadioButton radioButtonEntradas;
        private System.Windows.Forms.GroupBox groupBoxGeral;
        private System.Windows.Forms.Label labelDataVenc;
        private System.Windows.Forms.DateTimePicker dateTimePickerVenc;
        private System.Windows.Forms.Label labelLanc;
        private System.Windows.Forms.Label labelDataLanc;
        private System.Windows.Forms.Label labelValorLancado;
        private System.Windows.Forms.Label labelParcela;
        private System.Windows.Forms.Label labelNumParcela;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Button buttonParcelas;
        private System.Windows.Forms.Label labelObs;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label labelValorRecebido;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox textBoxCodCat;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.GroupBox groupBoxCategoria;
        private System.Windows.Forms.Button buttonCategoriaAdd;
        private System.Windows.Forms.Button buttonCategoriaBuscar;
        private System.Windows.Forms.Label labelFunc;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
namespace WinForms
{
    partial class FormCadTipoCategoria
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
            this.radioButtonEntrada = new System.Windows.Forms.RadioButton();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.radioButtonSaida = new System.Windows.Forms.RadioButton();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.groupBoxTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonEntrada
            // 
            this.radioButtonEntrada.AutoSize = true;
            this.radioButtonEntrada.Location = new System.Drawing.Point(6, 19);
            this.radioButtonEntrada.Name = "radioButtonEntrada";
            this.radioButtonEntrada.Size = new System.Drawing.Size(62, 17);
            this.radioButtonEntrada.TabIndex = 0;
            this.radioButtonEntrada.Text = "Entrada";
            this.radioButtonEntrada.UseVisualStyleBackColor = true;
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.radioButtonSaida);
            this.groupBoxTipo.Controls.Add(this.radioButtonEntrada);
            this.groupBoxTipo.Enabled = false;
            this.groupBoxTipo.Location = new System.Drawing.Point(13, 12);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(145, 44);
            this.groupBoxTipo.TabIndex = 0;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Categoria";
            // 
            // radioButtonSaida
            // 
            this.radioButtonSaida.AutoSize = true;
            this.radioButtonSaida.Checked = true;
            this.radioButtonSaida.Location = new System.Drawing.Point(74, 19);
            this.radioButtonSaida.Name = "radioButtonSaida";
            this.radioButtonSaida.Size = new System.Drawing.Size(54, 17);
            this.radioButtonSaida.TabIndex = 1;
            this.radioButtonSaida.TabStop = true;
            this.radioButtonSaida.Text = "Saída";
            this.radioButtonSaida.UseVisualStyleBackColor = true;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(13, 80);
            this.textBoxDescricao.MaxLength = 50;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(387, 20);
            this.textBoxDescricao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição:";
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(315, 106);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 4;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(224, 106);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 40);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // FormCadTipoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 159);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.groupBoxTipo);
            this.Name = "FormCadTipoCategoria";
            this.Text = "Categoria";
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonEntrada;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.RadioButton radioButtonSaida;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonSalvar;
    }
}
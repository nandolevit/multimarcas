namespace WinForms
{
    partial class FormLancamentosConfirmar
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
            this.buttonFechar = new System.Windows.Forms.Button();
            this.labelParc = new System.Windows.Forms.Label();
            this.labelValorParc = new System.Windows.Forms.Label();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.labelValorSaldo = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonJuros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(221, 154);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 10;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // labelParc
            // 
            this.labelParc.AutoSize = true;
            this.labelParc.Location = new System.Drawing.Point(12, 23);
            this.labelParc.Name = "labelParc";
            this.labelParc.Size = new System.Drawing.Size(87, 13);
            this.labelParc.TabIndex = 0;
            this.labelParc.Text = "Valor da parcela:";
            // 
            // labelValorParc
            // 
            this.labelValorParc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorParc.Location = new System.Drawing.Point(12, 37);
            this.labelValorParc.Name = "labelValorParc";
            this.labelValorParc.Size = new System.Drawing.Size(140, 20);
            this.labelValorParc.TabIndex = 1;
            this.labelValorParc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerData.Location = new System.Drawing.Point(187, 37);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(109, 20);
            this.dateTimePickerData.TabIndex = 3;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(187, 23);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(109, 13);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Data do recebimento:";
            // 
            // labelValorSaldo
            // 
            this.labelValorSaldo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelValorSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValorSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorSaldo.Location = new System.Drawing.Point(103, 97);
            this.labelValorSaldo.Name = "labelValorSaldo";
            this.labelValorSaldo.Size = new System.Drawing.Size(193, 44);
            this.labelValorSaldo.TabIndex = 8;
            this.labelValorSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(103, 83);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(78, 13);
            this.labelSaldo.TabIndex = 7;
            this.labelSaldo.Text = "Valor recebido:";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.ForeColor = System.Drawing.Color.Green;
            this.buttonConfirmar.Location = new System.Drawing.Point(12, 154);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(203, 23);
            this.buttonConfirmar.TabIndex = 9;
            this.buttonConfirmar.Text = "Confirmar lançamento";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonJuros
            // 
            this.buttonJuros.BackColor = System.Drawing.Color.Transparent;
            this.buttonJuros.FlatAppearance.BorderSize = 0;
            this.buttonJuros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJuros.ForeColor = System.Drawing.Color.Maroon;
            this.buttonJuros.Location = new System.Drawing.Point(221, 64);
            this.buttonJuros.Name = "buttonJuros";
            this.buttonJuros.Size = new System.Drawing.Size(75, 23);
            this.buttonJuros.TabIndex = 11;
            this.buttonJuros.Text = "Juros";
            this.buttonJuros.UseVisualStyleBackColor = false;
            this.buttonJuros.Click += new System.EventHandler(this.buttonJuros_Click);
            // 
            // FormLancamentosConfirmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 187);
            this.Controls.Add(this.buttonJuros);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.labelValorSaldo);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.labelValorParc);
            this.Controls.Add(this.labelParc);
            this.Controls.Add(this.buttonFechar);
            this.Name = "FormLancamentosConfirmar";
            this.Text = "Confirmar";
            this.Load += new System.EventHandler(this.FormLancamentosConfirmar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Label labelParc;
        private System.Windows.Forms.Label labelValorParc;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelValorSaldo;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonJuros;
    }
}
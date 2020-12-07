namespace WinForms
{
    partial class FormAbrirCaixa
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
            this.groupBoxCaixa = new System.Windows.Forms.GroupBox();
            this.labelTurnoDescricao = new System.Windows.Forms.Label();
            this.labelDataDescricao = new System.Windows.Forms.Label();
            this.labelTurno = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.groupBoxCaixa.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCaixa
            // 
            this.groupBoxCaixa.Controls.Add(this.labelTurnoDescricao);
            this.groupBoxCaixa.Controls.Add(this.labelDataDescricao);
            this.groupBoxCaixa.Controls.Add(this.labelTurno);
            this.groupBoxCaixa.Controls.Add(this.labelData);
            this.groupBoxCaixa.Controls.Add(this.textBoxValor);
            this.groupBoxCaixa.Controls.Add(this.labelValor);
            this.groupBoxCaixa.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCaixa.Name = "groupBoxCaixa";
            this.groupBoxCaixa.Size = new System.Drawing.Size(221, 102);
            this.groupBoxCaixa.TabIndex = 0;
            this.groupBoxCaixa.TabStop = false;
            this.groupBoxCaixa.Text = "Abertura de Caixa:";
            // 
            // labelTurnoDescricao
            // 
            this.labelTurnoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTurnoDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurnoDescricao.ForeColor = System.Drawing.Color.Maroon;
            this.labelTurnoDescricao.Location = new System.Drawing.Point(172, 71);
            this.labelTurnoDescricao.Name = "labelTurnoDescricao";
            this.labelTurnoDescricao.Size = new System.Drawing.Size(43, 20);
            this.labelTurnoDescricao.TabIndex = 5;
            this.labelTurnoDescricao.Text = "1";
            this.labelTurnoDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDataDescricao
            // 
            this.labelDataDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDataDescricao.Location = new System.Drawing.Point(9, 33);
            this.labelDataDescricao.Name = "labelDataDescricao";
            this.labelDataDescricao.Size = new System.Drawing.Size(206, 20);
            this.labelDataDescricao.TabIndex = 1;
            this.labelDataDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Location = new System.Drawing.Point(169, 54);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(38, 13);
            this.labelTurno.TabIndex = 4;
            this.labelTurno.Text = "Turno:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(6, 16);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(9, 71);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.ReadOnly = true;
            this.textBoxValor.Size = new System.Drawing.Size(157, 20);
            this.textBoxValor.TabIndex = 3;
            this.textBoxValor.Text = "0,00";
            this.textBoxValor.TextChanged += new System.EventHandler(this.textBoxValor_TextChanged);
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(6, 54);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(115, 13);
            this.labelValor.TabIndex = 2;
            this.labelValor.Text = "Valor do caixa anterior:";
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbrir.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonAbrir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAbrir.Location = new System.Drawing.Point(12, 120);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(130, 40);
            this.buttonAbrir.TabIndex = 1;
            this.buttonAbrir.Text = "&Abrir Caixa";
            this.buttonAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(148, 120);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 2;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormAbrirCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 170);
            this.Controls.Add(this.buttonAbrir);
            this.Controls.Add(this.groupBoxCaixa);
            this.Controls.Add(this.buttonFechar);
            this.Name = "FormAbrirCaixa";
            this.Text = "Abrir Caixa";
            this.Load += new System.EventHandler(this.FormAbrirCaixa_Load);
            this.groupBoxCaixa.ResumeLayout(false);
            this.groupBoxCaixa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCaixa;
        private System.Windows.Forms.Label labelTurnoDescricao;
        private System.Windows.Forms.Label labelDataDescricao;
        private System.Windows.Forms.Label labelTurno;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.Button buttonFechar;
    }
}
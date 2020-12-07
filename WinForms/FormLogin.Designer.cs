namespace WinForms
{
    partial class FormLogin
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxSenha = new System.Windows.Forms.MaskedTextBox();
            this.labelUnidade = new System.Windows.Forms.Label();
            this.labelUnidadeDescricao = new System.Windows.Forms.Label();
            this.checkBoxSalvarLogin = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLogar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.Gray;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.ForeColor = System.Drawing.Color.White;
            this.textBoxLogin.Location = new System.Drawing.Point(80, 8);
            this.textBoxLogin.MaxLength = 11;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(269, 15);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Senha:";
            // 
            // maskedTextBoxSenha
            // 
            this.maskedTextBoxSenha.BackColor = System.Drawing.Color.Gray;
            this.maskedTextBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxSenha.ForeColor = System.Drawing.Color.White;
            this.maskedTextBoxSenha.Location = new System.Drawing.Point(80, 9);
            this.maskedTextBoxSenha.Name = "maskedTextBoxSenha";
            this.maskedTextBoxSenha.PasswordChar = '*';
            this.maskedTextBoxSenha.Size = new System.Drawing.Size(269, 15);
            this.maskedTextBoxSenha.TabIndex = 1;
            this.maskedTextBoxSenha.TextChanged += new System.EventHandler(this.maskedTextBoxSenha_TextChanged);
            // 
            // labelUnidade
            // 
            this.labelUnidade.AutoSize = true;
            this.labelUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnidade.ForeColor = System.Drawing.Color.White;
            this.labelUnidade.Location = new System.Drawing.Point(9, 9);
            this.labelUnidade.Name = "labelUnidade";
            this.labelUnidade.Size = new System.Drawing.Size(58, 13);
            this.labelUnidade.TabIndex = 0;
            this.labelUnidade.Text = "Unidade:";
            // 
            // labelUnidadeDescricao
            // 
            this.labelUnidadeDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnidadeDescricao.ForeColor = System.Drawing.Color.White;
            this.labelUnidadeDescricao.Location = new System.Drawing.Point(80, 7);
            this.labelUnidadeDescricao.Name = "labelUnidadeDescricao";
            this.labelUnidadeDescricao.Size = new System.Drawing.Size(269, 17);
            this.labelUnidadeDescricao.TabIndex = 1;
            this.labelUnidadeDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxSalvarLogin
            // 
            this.checkBoxSalvarLogin.AutoSize = true;
            this.checkBoxSalvarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSalvarLogin.ForeColor = System.Drawing.Color.White;
            this.checkBoxSalvarLogin.Location = new System.Drawing.Point(407, 147);
            this.checkBoxSalvarLogin.Name = "checkBoxSalvarLogin";
            this.checkBoxSalvarLogin.Size = new System.Drawing.Size(97, 17);
            this.checkBoxSalvarLogin.TabIndex = 4;
            this.checkBoxSalvarLogin.Text = "Salvar Login";
            this.checkBoxSalvarLogin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Location = new System.Drawing.Point(141, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 31);
            this.panel1.TabIndex = 2;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(25, 8);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(42, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.maskedTextBoxSenha);
            this.panel2.Location = new System.Drawing.Point(141, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 31);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.labelUnidadeDescricao);
            this.panel3.Controls.Add(this.labelUnidade);
            this.panel3.Location = new System.Drawing.Point(141, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 31);
            this.panel3.TabIndex = 0;
            // 
            // buttonLogar
            // 
            this.buttonLogar.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonLogar.FlatAppearance.BorderSize = 0;
            this.buttonLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogar.ForeColor = System.Drawing.Color.PaleGreen;
            this.buttonLogar.Image = global::WinForms.Properties.Resources.icons8_Enter_16;
            this.buttonLogar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogar.Location = new System.Drawing.Point(141, 170);
            this.buttonLogar.Name = "buttonLogar";
            this.buttonLogar.Size = new System.Drawing.Size(260, 40);
            this.buttonLogar.TabIndex = 5;
            this.buttonLogar.Text = "&Logar";
            this.buttonLogar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogar.UseVisualStyleBackColor = false;
            this.buttonLogar.Click += new System.EventHandler(this.buttonLogar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.Maroon;
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.ForeColor = System.Drawing.Color.White;
            this.buttonFechar.Image = global::WinForms.Properties.Resources.icons8_Exit_16;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFechar.Location = new System.Drawing.Point(407, 170);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(97, 40);
            this.buttonFechar.TabIndex = 6;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(641, 245);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxSalvarLogin);
            this.Controls.Add(this.buttonLogar);
            this.Controls.Add(this.buttonFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSenha;
        private System.Windows.Forms.Label labelUnidade;
        private System.Windows.Forms.Label labelUnidadeDescricao;
        private System.Windows.Forms.Button buttonLogar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.CheckBox checkBoxSalvarLogin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
namespace WinForms
{
    partial class FormAlterarSenha
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
            this.labelSenhaAtual = new System.Windows.Forms.Label();
            this.maskedTextBoxAtual = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxConfirmar = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxNova = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSenhaNova = new System.Windows.Forms.Label();
            this.labelSenhaConfirmar = new System.Windows.Forms.Label();
            this.labelNovoLogin = new System.Windows.Forms.Label();
            this.labelLoginMensagem = new System.Windows.Forms.Label();
            this.textBoxNovoLogin = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSenhaAtual
            // 
            this.labelSenhaAtual.AutoSize = true;
            this.labelSenhaAtual.Location = new System.Drawing.Point(71, 141);
            this.labelSenhaAtual.Name = "labelSenhaAtual";
            this.labelSenhaAtual.Size = new System.Drawing.Size(68, 13);
            this.labelSenhaAtual.TabIndex = 3;
            this.labelSenhaAtual.Text = "Senha Atual:";
            // 
            // maskedTextBoxAtual
            // 
            this.maskedTextBoxAtual.Location = new System.Drawing.Point(145, 137);
            this.maskedTextBoxAtual.Name = "maskedTextBoxAtual";
            this.maskedTextBoxAtual.PasswordChar = '*';
            this.maskedTextBoxAtual.Size = new System.Drawing.Size(188, 20);
            this.maskedTextBoxAtual.TabIndex = 4;
            // 
            // maskedTextBoxConfirmar
            // 
            this.maskedTextBoxConfirmar.Location = new System.Drawing.Point(145, 189);
            this.maskedTextBoxConfirmar.Name = "maskedTextBoxConfirmar";
            this.maskedTextBoxConfirmar.PasswordChar = '*';
            this.maskedTextBoxConfirmar.Size = new System.Drawing.Size(188, 20);
            this.maskedTextBoxConfirmar.TabIndex = 8;
            // 
            // maskedTextBoxNova
            // 
            this.maskedTextBoxNova.Location = new System.Drawing.Point(145, 163);
            this.maskedTextBoxNova.Name = "maskedTextBoxNova";
            this.maskedTextBoxNova.PasswordChar = '*';
            this.maskedTextBoxNova.Size = new System.Drawing.Size(188, 20);
            this.maskedTextBoxNova.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinForms.Properties.Resources.senhas_post;
            this.pictureBox1.Location = new System.Drawing.Point(145, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelSenhaNova
            // 
            this.labelSenhaNova.AutoSize = true;
            this.labelSenhaNova.Location = new System.Drawing.Point(69, 167);
            this.labelSenhaNova.Name = "labelSenhaNova";
            this.labelSenhaNova.Size = new System.Drawing.Size(70, 13);
            this.labelSenhaNova.TabIndex = 5;
            this.labelSenhaNova.Text = "Senha Nova:";
            // 
            // labelSenhaConfirmar
            // 
            this.labelSenhaConfirmar.AutoSize = true;
            this.labelSenhaConfirmar.Location = new System.Drawing.Point(18, 192);
            this.labelSenhaConfirmar.Name = "labelSenhaConfirmar";
            this.labelSenhaConfirmar.Size = new System.Drawing.Size(121, 13);
            this.labelSenhaConfirmar.TabIndex = 7;
            this.labelSenhaConfirmar.Text = "Senha de Confirmarção:";
            // 
            // labelNovoLogin
            // 
            this.labelNovoLogin.AutoSize = true;
            this.labelNovoLogin.Location = new System.Drawing.Point(71, 115);
            this.labelNovoLogin.Name = "labelNovoLogin";
            this.labelNovoLogin.Size = new System.Drawing.Size(65, 13);
            this.labelNovoLogin.TabIndex = 1;
            this.labelNovoLogin.Text = "Novo Login:";
            // 
            // labelLoginMensagem
            // 
            this.labelLoginMensagem.AutoSize = true;
            this.labelLoginMensagem.ForeColor = System.Drawing.Color.Red;
            this.labelLoginMensagem.Location = new System.Drawing.Point(126, 95);
            this.labelLoginMensagem.Name = "labelLoginMensagem";
            this.labelLoginMensagem.Size = new System.Drawing.Size(226, 13);
            this.labelLoginMensagem.TabIndex = 0;
            this.labelLoginMensagem.Text = "Crie seu novo login com 10 dígitos no máximo:";
            this.labelLoginMensagem.Visible = false;
            // 
            // textBoxNovoLogin
            // 
            this.textBoxNovoLogin.Location = new System.Drawing.Point(145, 111);
            this.textBoxNovoLogin.MaxLength = 10;
            this.textBoxNovoLogin.Name = "textBoxNovoLogin";
            this.textBoxNovoLogin.Size = new System.Drawing.Size(188, 20);
            this.textBoxNovoLogin.TabIndex = 2;
            this.textBoxNovoLogin.Leave += new System.EventHandler(this.textBoxNovoLogin_Leave);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(145, 215);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 40);
            this.buttonSalvar.TabIndex = 9;
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
            this.buttonFechar.Location = new System.Drawing.Point(248, 215);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 10;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 268);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.textBoxNovoLogin);
            this.Controls.Add(this.labelLoginMensagem);
            this.Controls.Add(this.labelNovoLogin);
            this.Controls.Add(this.labelSenhaConfirmar);
            this.Controls.Add(this.labelSenhaNova);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maskedTextBoxNova);
            this.Controls.Add(this.maskedTextBoxConfirmar);
            this.Controls.Add(this.maskedTextBoxAtual);
            this.Controls.Add(this.labelSenhaAtual);
            this.Name = "FormAlterarSenha";
            this.Text = "Alterar Senha";
            this.Load += new System.EventHandler(this.FormAlterarSenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSenhaAtual;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAtual;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxConfirmar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNova;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSenhaNova;
        private System.Windows.Forms.Label labelSenhaConfirmar;
        private System.Windows.Forms.Label labelNovoLogin;
        private System.Windows.Forms.Label labelLoginMensagem;
        private System.Windows.Forms.TextBox textBoxNovoLogin;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonFechar;
    }
}
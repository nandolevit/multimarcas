namespace WinForms
{
    partial class FormFuncConsultar
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
            this.dataGridViewFunc = new System.Windows.Forms.DataGridView();
            this.colLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFunc
            // 
            this.dataGridViewFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLogin,
            this.colCpf,
            this.colNome,
            this.colTel,
            this.colEmail,
            this.colNiver,
            this.colCep,
            this.colEnd});
            this.dataGridViewFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFunc.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFunc.Name = "dataGridViewFunc";
            this.dataGridViewFunc.Size = new System.Drawing.Size(934, 349);
            this.dataGridViewFunc.TabIndex = 0;
            // 
            // colLogin
            // 
            this.colLogin.DataPropertyName = "funLogin";
            this.colLogin.HeaderText = "Login:";
            this.colLogin.Name = "colLogin";
            // 
            // colCpf
            // 
            this.colCpf.DataPropertyName = "funCpf";
            this.colCpf.HeaderText = "CPF:";
            this.colCpf.Name = "colCpf";
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "funNome";
            this.colNome.HeaderText = "Nome:";
            this.colNome.Name = "colNome";
            // 
            // colTel
            // 
            this.colTel.DataPropertyName = "funTelefone";
            this.colTel.HeaderText = "Telefone:";
            this.colTel.Name = "colTel";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "funEmail";
            this.colEmail.HeaderText = "E-mail:";
            this.colEmail.Name = "colEmail";
            // 
            // colNiver
            // 
            this.colNiver.DataPropertyName = "funNiver";
            this.colNiver.HeaderText = "Aniversário:";
            this.colNiver.Name = "colNiver";
            // 
            // colCep
            // 
            this.colCep.DataPropertyName = "funCep";
            this.colCep.HeaderText = "Cep:";
            this.colCep.Name = "colCep";
            // 
            // colEnd
            // 
            this.colEnd.DataPropertyName = "funComplemento";
            this.colEnd.HeaderText = "Endereço:";
            this.colEnd.Name = "colEnd";
            // 
            // FormFuncConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 349);
            this.Controls.Add(this.dataGridViewFunc);
            this.Name = "FormFuncConsultar";
            this.Text = "Consultar Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
    }
}
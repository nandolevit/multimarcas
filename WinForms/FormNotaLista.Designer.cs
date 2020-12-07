namespace WinForms
{
    partial class FormNotaLista
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
            this.groupBoxLista = new System.Windows.Forms.GroupBox();
            this.dataGridViewNota = new System.Windows.Forms.DataGridView();
            this.colNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.groupBoxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNota)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLista
            // 
            this.groupBoxLista.Controls.Add(this.dataGridViewNota);
            this.groupBoxLista.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLista.Name = "groupBoxLista";
            this.groupBoxLista.Size = new System.Drawing.Size(646, 141);
            this.groupBoxLista.TabIndex = 0;
            this.groupBoxLista.TabStop = false;
            this.groupBoxLista.Text = "Notas cadastradas para este cliente:";
            // 
            // dataGridViewNota
            // 
            this.dataGridViewNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNota,
            this.colSerie,
            this.colNome,
            this.colEmissao,
            this.colVencimento});
            this.dataGridViewNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNota.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewNota.Name = "dataGridViewNota";
            this.dataGridViewNota.RowHeadersVisible = false;
            this.dataGridViewNota.Size = new System.Drawing.Size(640, 122);
            this.dataGridViewNota.TabIndex = 0;
            // 
            // colNota
            // 
            this.colNota.DataPropertyName = "notNum";
            this.colNota.HeaderText = "Nº da Nota:";
            this.colNota.Name = "colNota";
            this.colNota.Width = 90;
            // 
            // colSerie
            // 
            this.colSerie.DataPropertyName = "notNumSerie";
            this.colSerie.HeaderText = "Série:";
            this.colSerie.Name = "colSerie";
            this.colSerie.Width = 70;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "notNome";
            this.colNome.HeaderText = "Nome:";
            this.colNome.Name = "colNome";
            this.colNome.Width = 280;
            // 
            // colEmissao
            // 
            this.colEmissao.DataPropertyName = "notEmissao";
            this.colEmissao.HeaderText = "Emissão:";
            this.colEmissao.Name = "colEmissao";
            this.colEmissao.Width = 75;
            // 
            // colVencimento
            // 
            this.colVencimento.DataPropertyName = "notVencimento";
            this.colVencimento.HeaderText = "Vencimento:";
            this.colVencimento.Name = "colVencimento";
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSelecionar.Location = new System.Drawing.Point(454, 159);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(113, 40);
            this.buttonSelecionar.TabIndex = 8;
            this.buttonSelecionar.Text = "&Selecionar";
            this.buttonSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.ButtonNovo_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(573, 159);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 7;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormNotaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 213);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.groupBoxLista);
            this.Name = "FormNotaLista";
            this.Text = "Lista de notas";
            this.groupBoxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLista;
        private System.Windows.Forms.DataGridView dataGridViewNota;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVencimento;
    }
}
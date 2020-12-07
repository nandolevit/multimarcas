namespace WinForms
{
    partial class FormEnderecoLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnderecoLista));
            this.dataGridViewEndereco = new System.Windows.Forms.DataGridView();
            this.ColComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPadrao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPontoRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPadrao = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEndereco
            // 
            this.dataGridViewEndereco.AllowUserToAddRows = false;
            this.dataGridViewEndereco.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewEndereco.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColComplemento,
            this.colPadrao,
            this.ColCep,
            this.ColPontoRef});
            this.dataGridViewEndereco.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEndereco.MultiSelect = false;
            this.dataGridViewEndereco.Name = "dataGridViewEndereco";
            this.dataGridViewEndereco.ReadOnly = true;
            this.dataGridViewEndereco.RowHeadersVisible = false;
            this.dataGridViewEndereco.RowHeadersWidth = 10;
            this.dataGridViewEndereco.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewEndereco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEndereco.Size = new System.Drawing.Size(872, 110);
            this.dataGridViewEndereco.TabIndex = 0;
            this.dataGridViewEndereco.TabStop = false;
            this.dataGridViewEndereco.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridViewEndereco_CellFormatting);
            this.dataGridViewEndereco.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEndereco_RowEnter);
            // 
            // ColComplemento
            // 
            this.ColComplemento.DataPropertyName = "Complemento";
            this.ColComplemento.HeaderText = "Endereço:";
            this.ColComplemento.Name = "ColComplemento";
            this.ColComplemento.ReadOnly = true;
            this.ColComplemento.Width = 850;
            // 
            // colPadrao
            // 
            this.colPadrao.DataPropertyName = "endpadrao";
            this.colPadrao.HeaderText = "Padrao:";
            this.colPadrao.Name = "colPadrao";
            this.colPadrao.ReadOnly = true;
            this.colPadrao.Visible = false;
            // 
            // ColCep
            // 
            this.ColCep.DataPropertyName = "Cep";
            this.ColCep.HeaderText = "CEP";
            this.ColCep.Name = "ColCep";
            this.ColCep.ReadOnly = true;
            this.ColCep.Visible = false;
            this.ColCep.Width = 75;
            // 
            // ColPontoRef
            // 
            this.ColPontoRef.DataPropertyName = "PontoReferencia";
            this.ColPontoRef.HeaderText = "Ponto de Referência";
            this.ColPontoRef.Name = "ColPontoRef";
            this.ColPontoRef.ReadOnly = true;
            this.ColPontoRef.Visible = false;
            this.ColPontoRef.Width = 400;
            // 
            // buttonPadrao
            // 
            this.buttonPadrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPadrao.Image = global::WinForms.Properties.Resources.mark;
            this.buttonPadrao.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonPadrao.Location = new System.Drawing.Point(220, 128);
            this.buttonPadrao.Name = "buttonPadrao";
            this.buttonPadrao.Size = new System.Drawing.Size(88, 40);
            this.buttonPadrao.TabIndex = 3;
            this.buttonPadrao.Text = "&Padrão";
            this.buttonPadrao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonPadrao, "Definir endereço como padrão...");
            this.buttonPadrao.UseVisualStyleBackColor = true;
            this.buttonPadrao.Click += new System.EventHandler(this.buttonPadrao_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Image = global::WinForms.Properties.Resources.edit;
            this.buttonAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAlterar.Location = new System.Drawing.Point(126, 128);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(88, 40);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonAlterar, "Alterar o endereço...");
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlter_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Image = global::WinForms.Properties.Resources.add_green;
            this.buttonAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAdicionar.Location = new System.Drawing.Point(12, 128);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(108, 40);
            this.buttonAdicionar.TabIndex = 1;
            this.buttonAdicionar.Text = "&Adicionar";
            this.buttonAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonAdicionar, "Adicionar novo endereço...");
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSelecionar.Location = new System.Drawing.Point(685, 129);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(108, 40);
            this.buttonSelecionar.TabIndex = 4;
            this.buttonSelecionar.Text = "&Selecionar";
            this.buttonSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonSelecionar, "Selecionar endereço...");
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(799, 128);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 5;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonFechar, "Fechar...");
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormEnderecoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 182);
            this.Controls.Add(this.buttonPadrao);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.dataGridViewEndereco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEnderecoLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Endereços";
            this.Load += new System.EventHandler(this.FormEnderecoLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEndereco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEndereco;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonPadrao;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPadrao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPontoRef;
    }
}
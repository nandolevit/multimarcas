namespace WinForms
{
    partial class FormConsultar_Cod_Descricao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewConsultar = new System.Windows.Forms.DataGridView();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultar)).BeginInit();
            this.groupBoxBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewConsultar
            // 
            this.dataGridViewConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.colDescricao});
            this.dataGridViewConsultar.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewConsultar.Name = "dataGridViewConsultar";
            this.dataGridViewConsultar.RowHeadersVisible = false;
            this.dataGridViewConsultar.RowHeadersWidth = 15;
            this.dataGridViewConsultar.Size = new System.Drawing.Size(530, 250);
            this.dataGridViewConsultar.TabIndex = 0;
            this.dataGridViewConsultar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewConsultar_CellContentClick);
            this.dataGridViewConsultar.DoubleClick += new System.EventHandler(this.dataGridViewConsultar_DoubleClick);
            // 
            // colCod
            // 
            this.colCod.DataPropertyName = "Cod";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCod.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCod.HeaderText = "Código";
            this.colCod.Name = "colCod";
            this.colCod.Width = 50;
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "Descricao";
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Width = 450;
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Controls.Add(this.dataGridViewConsultar);
            this.groupBoxBuscar.Location = new System.Drawing.Point(12, 13);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Size = new System.Drawing.Size(542, 278);
            this.groupBoxBuscar.TabIndex = 1;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "Buscar:";
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(464, 297);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(90, 40);
            this.buttonFechar.TabIndex = 4;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSelecionar.Location = new System.Drawing.Point(348, 297);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(110, 40);
            this.buttonSelecionar.TabIndex = 3;
            this.buttonSelecionar.Text = "Selecionar";
            this.buttonSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // FormConsultar_Cod_Descricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 345);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.groupBoxBuscar);
            this.KeyPreview = true;
            this.Name = "FormConsultar_Cod_Descricao";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.FormConsultar_Cod_Descricao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultar_Cod_Descricao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultar)).EndInit();
            this.groupBoxBuscar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewConsultar;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonSelecionar;
    }
}
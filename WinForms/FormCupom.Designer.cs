namespace WinForms
{
    partial class FormCupom
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
            this.textBoxCupom = new System.Windows.Forms.TextBox();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonTeste = new System.Windows.Forms.Button();
            this.textBoxTeste = new System.Windows.Forms.TextBox();
            this.labelTeste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCupom
            // 
            this.textBoxCupom.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCupom.Location = new System.Drawing.Point(12, 12);
            this.textBoxCupom.Multiline = true;
            this.textBoxCupom.Name = "textBoxCupom";
            this.textBoxCupom.ReadOnly = true;
            this.textBoxCupom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCupom.Size = new System.Drawing.Size(388, 515);
            this.textBoxCupom.TabIndex = 5;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Enabled = false;
            this.buttonImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimir.Image = global::WinForms.Properties.Resources.PhotoPrint_63141;
            this.buttonImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonImprimir.Location = new System.Drawing.Point(266, 531);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(40, 40);
            this.buttonImprimir.TabIndex = 3;
            this.buttonImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(315, 531);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 4;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonTeste
            // 
            this.buttonTeste.Location = new System.Drawing.Point(185, 548);
            this.buttonTeste.Name = "buttonTeste";
            this.buttonTeste.Size = new System.Drawing.Size(75, 23);
            this.buttonTeste.TabIndex = 2;
            this.buttonTeste.Text = "Buscar";
            this.buttonTeste.UseVisualStyleBackColor = true;
            this.buttonTeste.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTeste
            // 
            this.textBoxTeste.Location = new System.Drawing.Point(12, 550);
            this.textBoxTeste.Name = "textBoxTeste";
            this.textBoxTeste.Size = new System.Drawing.Size(167, 20);
            this.textBoxTeste.TabIndex = 1;
            this.textBoxTeste.TextChanged += new System.EventHandler(this.textBoxTeste_TextChanged);
            // 
            // labelTeste
            // 
            this.labelTeste.AutoSize = true;
            this.labelTeste.Location = new System.Drawing.Point(12, 537);
            this.labelTeste.Name = "labelTeste";
            this.labelTeste.Size = new System.Drawing.Size(138, 13);
            this.labelTeste.TabIndex = 0;
            this.labelTeste.Text = "Insira o número do controle:";
            // 
            // FormCupom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 583);
            this.Controls.Add(this.labelTeste);
            this.Controls.Add(this.buttonTeste);
            this.Controls.Add(this.textBoxTeste);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.textBoxCupom);
            this.Name = "FormCupom";
            this.Text = "Visualizando Impressão";
            this.Load += new System.EventHandler(this.FormCupom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCupom;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonTeste;
        private System.Windows.Forms.TextBox textBoxTeste;
        private System.Windows.Forms.Label labelTeste;
    }
}
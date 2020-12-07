namespace WinForms
{
    partial class FormTaxa
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
            this.textBoxTaxa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTaxa
            // 
            this.textBoxTaxa.Location = new System.Drawing.Point(72, 33);
            this.textBoxTaxa.Name = "textBoxTaxa";
            this.textBoxTaxa.Size = new System.Drawing.Size(100, 20);
            this.textBoxTaxa.TabIndex = 0;
            this.textBoxTaxa.TextChanged += new System.EventHandler(this.textBoxTaxa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Taxa:";
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(178, 32);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // FormTaxa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 87);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTaxa);
            this.Name = "FormTaxa";
            this.Text = "Taxa";
            this.Load += new System.EventHandler(this.FormTaxa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTaxa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAlterar;
    }
}
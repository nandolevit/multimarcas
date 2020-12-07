namespace WinForms
{
    partial class FormVendaVip
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
            this.buttonVip = new System.Windows.Forms.Button();
            this.buttonAvulso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVip
            // 
            this.buttonVip.BackColor = System.Drawing.Color.Transparent;
            this.buttonVip.FlatAppearance.BorderSize = 0;
            this.buttonVip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVip.Image = global::WinForms.Properties.Resources.vip;
            this.buttonVip.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonVip.Location = new System.Drawing.Point(122, 12);
            this.buttonVip.Name = "buttonVip";
            this.buttonVip.Size = new System.Drawing.Size(102, 60);
            this.buttonVip.TabIndex = 1;
            this.buttonVip.Text = "Venda VIP (F2)";
            this.buttonVip.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVip.UseVisualStyleBackColor = false;
            this.buttonVip.Click += new System.EventHandler(this.buttonVip_Click);
            // 
            // buttonAvulso
            // 
            this.buttonAvulso.BackColor = System.Drawing.Color.Transparent;
            this.buttonAvulso.FlatAppearance.BorderSize = 0;
            this.buttonAvulso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAvulso.Image = global::WinForms.Properties.Resources.clienteAvulso;
            this.buttonAvulso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAvulso.Location = new System.Drawing.Point(12, 12);
            this.buttonAvulso.Name = "buttonAvulso";
            this.buttonAvulso.Size = new System.Drawing.Size(102, 60);
            this.buttonAvulso.TabIndex = 0;
            this.buttonAvulso.Text = "Venda Avulsa (F1)";
            this.buttonAvulso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAvulso.UseVisualStyleBackColor = false;
            this.buttonAvulso.Click += new System.EventHandler(this.buttonAvulso_Click);
            // 
            // FormVendaVip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 90);
            this.Controls.Add(this.buttonVip);
            this.Controls.Add(this.buttonAvulso);
            this.KeyPreview = true;
            this.Name = "FormVendaVip";
            this.Text = "Tipo de Cliente";
            this.Load += new System.EventHandler(this.FormVendaVip_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormVendaVip_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVip;
        private System.Windows.Forms.Button buttonAvulso;
    }
}
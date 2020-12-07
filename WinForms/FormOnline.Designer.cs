namespace WinForms
{
    partial class FormOnline
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timerOnline = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewOnline = new System.Windows.Forms.DataGridView();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewChat = new System.Windows.Forms.DataGridView();
            this.colMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnviado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewChatNovaMessage = new System.Windows.Forms.DataGridView();
            this.colMensagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notifyIconChat = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBoxChat = new System.Windows.Forms.GroupBox();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonNovaMensagem = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChatNovaMessage)).BeginInit();
            this.groupBoxChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerOnline
            // 
            this.timerOnline.Enabled = true;
            this.timerOnline.Interval = 1500;
            this.timerOnline.Tick += new System.EventHandler(this.timerOnline_Tick);
            // 
            // dataGridViewOnline
            // 
            this.dataGridViewOnline.AllowUserToAddRows = false;
            this.dataGridViewOnline.AllowUserToDeleteRows = false;
            this.dataGridViewOnline.AllowUserToResizeColumns = false;
            this.dataGridViewOnline.AllowUserToResizeRows = false;
            this.dataGridViewOnline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOnline.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOnline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewOnline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNome});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOnline.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOnline.Location = new System.Drawing.Point(12, 35);
            this.dataGridViewOnline.MultiSelect = false;
            this.dataGridViewOnline.Name = "dataGridViewOnline";
            this.dataGridViewOnline.ReadOnly = true;
            this.dataGridViewOnline.RowHeadersVisible = false;
            this.dataGridViewOnline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOnline.ShowCellErrors = false;
            this.dataGridViewOnline.ShowCellToolTips = false;
            this.dataGridViewOnline.ShowEditingIcon = false;
            this.dataGridViewOnline.ShowRowErrors = false;
            this.dataGridViewOnline.Size = new System.Drawing.Size(192, 278);
            this.dataGridViewOnline.TabIndex = 1;
            this.dataGridViewOnline.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOnline_CellClick);
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "loginnome";
            this.colNome.HeaderText = "Usuários (Online):";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 170;
            // 
            // dataGridViewChat
            // 
            this.dataGridViewChat.AllowUserToAddRows = false;
            this.dataGridViewChat.AllowUserToDeleteRows = false;
            this.dataGridViewChat.AllowUserToResizeColumns = false;
            this.dataGridViewChat.AllowUserToResizeRows = false;
            this.dataGridViewChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewChat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMessage,
            this.colEnvio,
            this.colEnviado});
            this.dataGridViewChat.Location = new System.Drawing.Point(6, 85);
            this.dataGridViewChat.Name = "dataGridViewChat";
            this.dataGridViewChat.RowHeadersVisible = false;
            this.dataGridViewChat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChat.ShowCellErrors = false;
            this.dataGridViewChat.ShowCellToolTips = false;
            this.dataGridViewChat.ShowEditingIcon = false;
            this.dataGridViewChat.ShowRowErrors = false;
            this.dataGridViewChat.Size = new System.Drawing.Size(654, 507);
            this.dataGridViewChat.TabIndex = 4;
            this.dataGridViewChat.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridViewChat_RowPostPaint);
            this.dataGridViewChat.Click += new System.EventHandler(this.dataGridViewChat_Click);
            // 
            // colMessage
            // 
            this.colMessage.DataPropertyName = "chatmessage";
            this.colMessage.HeaderText = "Mensagem:";
            this.colMessage.Name = "colMessage";
            this.colMessage.Width = 520;
            // 
            // colEnvio
            // 
            this.colEnvio.DataPropertyName = "chatdata";
            dataGridViewCellStyle3.Format = "G";
            dataGridViewCellStyle3.NullValue = null;
            this.colEnvio.DefaultCellStyle = dataGridViewCellStyle3;
            this.colEnvio.HeaderText = "Envio:";
            this.colEnvio.Name = "colEnvio";
            this.colEnvio.Width = 115;
            // 
            // colEnviado
            // 
            this.colEnviado.DataPropertyName = "chatidenvio";
            this.colEnviado.HeaderText = "Enviado:";
            this.colEnviado.Name = "colEnviado";
            this.colEnviado.Visible = false;
            // 
            // dataGridViewChatNovaMessage
            // 
            this.dataGridViewChatNovaMessage.AllowUserToAddRows = false;
            this.dataGridViewChatNovaMessage.AllowUserToDeleteRows = false;
            this.dataGridViewChatNovaMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChatNovaMessage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewChatNovaMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChatNovaMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMensagem});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewChatNovaMessage.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewChatNovaMessage.Location = new System.Drawing.Point(12, 319);
            this.dataGridViewChatNovaMessage.MultiSelect = false;
            this.dataGridViewChatNovaMessage.Name = "dataGridViewChatNovaMessage";
            this.dataGridViewChatNovaMessage.ReadOnly = true;
            this.dataGridViewChatNovaMessage.RowHeadersVisible = false;
            this.dataGridViewChatNovaMessage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChatNovaMessage.ShowCellErrors = false;
            this.dataGridViewChatNovaMessage.ShowCellToolTips = false;
            this.dataGridViewChatNovaMessage.ShowEditingIcon = false;
            this.dataGridViewChatNovaMessage.ShowRowErrors = false;
            this.dataGridViewChatNovaMessage.Size = new System.Drawing.Size(192, 268);
            this.dataGridViewChatNovaMessage.TabIndex = 2;
            this.dataGridViewChatNovaMessage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChatNovaMessage_CellClick);
            // 
            // colMensagem
            // 
            this.colMensagem.DataPropertyName = "chatmessage";
            this.colMensagem.HeaderText = "Novas Mensagens:";
            this.colMensagem.Name = "colMensagem";
            this.colMensagem.ReadOnly = true;
            this.colMensagem.Width = 170;
            // 
            // notifyIconChat
            // 
            this.notifyIconChat.Visible = true;
            // 
            // groupBoxChat
            // 
            this.groupBoxChat.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxChat.Controls.Add(this.dataGridViewChat);
            this.groupBoxChat.Controls.Add(this.buttonFechar);
            this.groupBoxChat.Controls.Add(this.labelNome);
            this.groupBoxChat.Controls.Add(this.buttonEnviar);
            this.groupBoxChat.Controls.Add(this.textBoxMessage);
            this.groupBoxChat.Location = new System.Drawing.Point(222, 12);
            this.groupBoxChat.Name = "groupBoxChat";
            this.groupBoxChat.Size = new System.Drawing.Size(666, 598);
            this.groupBoxChat.TabIndex = 3;
            this.groupBoxChat.TabStop = false;
            this.groupBoxChat.Text = "Vamos conversar...";
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(620, 11);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(40, 40);
            this.buttonFechar.TabIndex = 1;
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // labelNome
            // 
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(6, 20);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(608, 23);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            this.labelNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonEnviar.Enabled = false;
            this.buttonEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnviar.ForeColor = System.Drawing.Color.Green;
            this.buttonEnviar.Location = new System.Drawing.Point(597, 57);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(63, 24);
            this.buttonEnviar.TabIndex = 3;
            this.buttonEnviar.Text = "Enter ->";
            this.buttonEnviar.UseVisualStyleBackColor = false;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Enabled = false;
            this.textBoxMessage.Location = new System.Drawing.Point(6, 59);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(585, 20);
            this.textBoxMessage.TabIndex = 2;
            // 
            // buttonNovaMensagem
            // 
            this.buttonNovaMensagem.BackgroundImage = global::WinForms.Properties.Resources.icons8_Chat_32;
            this.buttonNovaMensagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNovaMensagem.FlatAppearance.BorderSize = 0;
            this.buttonNovaMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovaMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovaMensagem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonNovaMensagem.Location = new System.Drawing.Point(173, 0);
            this.buttonNovaMensagem.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNovaMensagem.Name = "buttonNovaMensagem";
            this.buttonNovaMensagem.Size = new System.Drawing.Size(38, 29);
            this.buttonNovaMensagem.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonNovaMensagem, "Novo chat.");
            this.buttonNovaMensagem.UseVisualStyleBackColor = true;
            this.buttonNovaMensagem.Click += new System.EventHandler(this.buttonNovaMensagem_Click);
            // 
            // FormOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(215, 597);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxChat);
            this.Controls.Add(this.buttonNovaMensagem);
            this.Controls.Add(this.dataGridViewChatNovaMessage);
            this.Controls.Add(this.dataGridViewOnline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOnline";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormOnline";
            this.Load += new System.EventHandler(this.FormOnline_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormOnline_KeyDown);
            this.Leave += new System.EventHandler(this.FormOnline_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChatNovaMessage)).EndInit();
            this.groupBoxChat.ResumeLayout(false);
            this.groupBoxChat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewOnline;
        private System.Windows.Forms.Timer timerOnline;
        private System.Windows.Forms.DataGridView dataGridViewChatNovaMessage;
        private System.Windows.Forms.NotifyIcon notifyIconChat;
        private System.Windows.Forms.Button buttonNovaMensagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMensagem;
        private System.Windows.Forms.GroupBox groupBoxChat;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.DataGridView dataGridViewChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnviado;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
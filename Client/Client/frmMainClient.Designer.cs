namespace Client
{
    partial class frmMainClient
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
            this.contentList = new System.Windows.Forms.ListBox();
            this.labelUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelPort = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buttonGroupChat = new System.Windows.Forms.Button();
            this.buttonPrivateChat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contentList
            // 
            this.contentList.FormattingEnabled = true;
            this.contentList.ItemHeight = 17;
            this.contentList.Location = new System.Drawing.Point(33, 81);
            this.contentList.Name = "contentList";
            this.contentList.Size = new System.Drawing.Size(507, 293);
            this.contentList.TabIndex = 0;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(28, 22);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(100, 24);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "User name";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(576, 22);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(45, 24);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "Port";
            // 
            // buttonGroupChat
            // 
            this.buttonGroupChat.Location = new System.Drawing.Point(581, 81);
            this.buttonGroupChat.Name = "buttonGroupChat";
            this.buttonGroupChat.Size = new System.Drawing.Size(164, 51);
            this.buttonGroupChat.TabIndex = 3;
            this.buttonGroupChat.Text = "Group Chat";
            this.buttonGroupChat.UseVisualStyleBackColor = true;
            // 
            // buttonPrivateChat
            // 
            this.buttonPrivateChat.Location = new System.Drawing.Point(581, 162);
            this.buttonPrivateChat.Name = "buttonPrivateChat";
            this.buttonPrivateChat.Size = new System.Drawing.Size(164, 51);
            this.buttonPrivateChat.TabIndex = 4;
            this.buttonPrivateChat.Text = "Private Chat";
            this.buttonPrivateChat.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(115, 380);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(425, 44);
            this.messageBox.TabIndex = 6;
            this.messageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageBox_KeyDown);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(580, 380);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 44);
            this.btSend.TabIndex = 7;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            // 
            // frmMainClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 473);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonPrivateChat);
            this.Controls.Add(this.buttonGroupChat);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.contentList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainClient";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMainClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox contentList;
        private Bunifu.Framework.UI.BunifuCustomLabel labelUserName;
        private Bunifu.Framework.UI.BunifuCustomLabel labelPort;
        private System.Windows.Forms.Button buttonGroupChat;
        private System.Windows.Forms.Button buttonPrivateChat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button btSend;
    }
}


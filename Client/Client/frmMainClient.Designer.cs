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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelPort = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buttonGroupChat = new System.Windows.Forms.Button();
            this.buttonPrivateChat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(33, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(507, 329);
            this.listBox1.TabIndex = 0;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(28, 22);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(118, 29);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "User name";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(576, 22);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(54, 29);
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
            // frmMainClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 473);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonPrivateChat);
            this.Controls.Add(this.buttonGroupChat);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.listBox1);
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

        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel labelUserName;
        private Bunifu.Framework.UI.BunifuCustomLabel labelPort;
        private System.Windows.Forms.Button buttonGroupChat;
        private System.Windows.Forms.Button buttonPrivateChat;
        private System.Windows.Forms.Button button2;
    }
}


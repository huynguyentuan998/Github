namespace Client
{
    partial class frmPrivateChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrivateChat));
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lisbMessage = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbMessage
            // 
            this.txbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txbMessage.Location = new System.Drawing.Point(21, 328);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(355, 40);
            this.txbMessage.TabIndex = 23;
            // 
            // btnSend
            // 
            this.btnSend.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.BorderRadius = 0;
            this.btnSend.ButtonText = "Gửi";
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.DisabledColor = System.Drawing.Color.Gray;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSend.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSend.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSend.Iconimage")));
            this.btnSend.Iconimage_right = null;
            this.btnSend.Iconimage_right_Selected = null;
            this.btnSend.Iconimage_Selected = null;
            this.btnSend.IconMarginLeft = 0;
            this.btnSend.IconMarginRight = 0;
            this.btnSend.IconRightVisible = true;
            this.btnSend.IconRightZoom = 0D;
            this.btnSend.IconVisible = true;
            this.btnSend.IconZoom = 90D;
            this.btnSend.IsTab = false;
            this.btnSend.Location = new System.Drawing.Point(383, 328);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSend.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSend.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSend.selected = false;
            this.btnSend.Size = new System.Drawing.Size(92, 40);
            this.btnSend.TabIndex = 22;
            this.btnSend.Text = "Gửi";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Textcolor = System.Drawing.Color.White;
            this.btnSend.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lisbMessage
            // 
            this.lisbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lisbMessage.FormattingEnabled = true;
            this.lisbMessage.ItemHeight = 17;
            this.lisbMessage.Location = new System.Drawing.Point(21, 63);
            this.lisbMessage.Name = "lisbMessage";
            this.lisbMessage.Size = new System.Drawing.Size(454, 259);
            this.lisbMessage.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(256, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Friend IP";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Friend name";
            this.label1.Visible = false;
            // 
            // txbIP
            // 
            this.txbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txbIP.Location = new System.Drawing.Point(326, 23);
            this.txbIP.Name = "txbIP";
            this.txbIP.ReadOnly = true;
            this.txbIP.Size = new System.Drawing.Size(100, 23);
            this.txbIP.TabIndex = 18;
            this.txbIP.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox2.Location = new System.Drawing.Point(110, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 17;
            this.textBox2.Visible = false;
            // 
            // frmPrivateChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 390);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lisbMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbIP);
            this.Controls.Add(this.textBox2);
            this.Name = "frmPrivateChat";
            this.Text = "frmPrivateChat";
            this.Load += new System.EventHandler(this.frmPrivateChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMessage;
        private Bunifu.Framework.UI.BunifuFlatButton btnSend;
        private System.Windows.Forms.ListBox lisbMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.TextBox textBox2;
    }
}
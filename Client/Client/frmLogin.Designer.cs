namespace Client
{
    partial class frmLogin
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
            this.labelUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBoxUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxServerName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBoxPort = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buttonLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(45, 44);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(81, 19);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User Name";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUserName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.ForeColor = System.Drawing.Color.Black;
            this.textBoxUserName.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxUserName.HintText = "";
            this.textBoxUserName.isPassword = false;
            this.textBoxUserName.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxUserName.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxUserName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxUserName.LineThickness = 1;
            this.textBoxUserName.Location = new System.Drawing.Point(173, 35);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.textBoxUserName.Size = new System.Drawing.Size(205, 27);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxServerName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServerName.ForeColor = System.Drawing.Color.Black;
            this.textBoxServerName.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxServerName.HintText = "";
            this.textBoxServerName.isPassword = false;
            this.textBoxServerName.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxServerName.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxServerName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxServerName.LineThickness = 1;
            this.textBoxServerName.Location = new System.Drawing.Point(173, 92);
            this.textBoxServerName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(205, 27);
            this.textBoxServerName.TabIndex = 3;
            this.textBoxServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(45, 100);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(105, 19);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Server Address";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPort.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPort.ForeColor = System.Drawing.Color.Black;
            this.textBoxPort.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxPort.HintText = "";
            this.textBoxPort.isPassword = false;
            this.textBoxPort.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxPort.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxPort.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxPort.LineThickness = 1;
            this.textBoxPort.Location = new System.Drawing.Point(173, 148);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(205, 27);
            this.textBoxPort.TabIndex = 5;
            this.textBoxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(45, 157);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(35, 19);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Port";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Activecolor = System.Drawing.Color.Silver;
            this.buttonLogin.BackColor = System.Drawing.Color.Silver;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.BorderRadius = 0;
            this.buttonLogin.ButtonText = "Login";
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.DisabledColor = System.Drawing.Color.Gray;
            this.buttonLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonLogin.Iconimage = null;
            this.buttonLogin.Iconimage_right = null;
            this.buttonLogin.Iconimage_right_Selected = null;
            this.buttonLogin.Iconimage_Selected = null;
            this.buttonLogin.IconMarginLeft = 0;
            this.buttonLogin.IconMarginRight = 0;
            this.buttonLogin.IconRightVisible = true;
            this.buttonLogin.IconRightZoom = 0D;
            this.buttonLogin.IconVisible = true;
            this.buttonLogin.IconZoom = 90D;
            this.buttonLogin.IsTab = false;
            this.buttonLogin.Location = new System.Drawing.Point(307, 216);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Normalcolor = System.Drawing.Color.Silver;
            this.buttonLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonLogin.OnHoverTextColor = System.Drawing.Color.Silver;
            this.buttonLogin.selected = false;
            this.buttonLogin.Size = new System.Drawing.Size(165, 48);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonLogin.Textcolor = System.Drawing.Color.Black;
            this.buttonLogin.TextFont = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 288);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.textBoxServerName);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelUserName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel labelUserName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxUserName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxPort;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton buttonLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxServerName;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private string strUserName;
        private string strServerName;
        private string strPort;
  
        public string userName { get => strUserName;}
        public string serverName { get => strServerName;}
        public string port { get => strPort;}

        private bool chkUserName()
        {
            if (textBoxUserName.Text == "")
                return false;
            return true;
        }

        private bool chkServerName()
        {
            if (textBoxServerName.Text == "")
                return false;
            return true;
        }

        private bool chkPort()
        {
            if (textBoxPort.Text == "")
                return false;
            return true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (chkPort() || chkUserName() || chkServerName())
            {
                MessageBox.Show("dien du thong tin vao ii");
                return;
            }
            strUserName = textBoxUserName.Text;
            strServerName = textBoxServerName.Text;
            strPort = textBoxPort.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

    }
}

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
    public partial class frmMainClient : Form
    {
        public frmMainClient()
        {
            InitializeComponent();
        }

        private void frmMainClient_Load(object sender, EventArgs e)
        {
            DialogResult loginDialogResult;
            frmLogin frmlogin = new frmLogin();
            frmlogin.ShowDialog();
            loginDialogResult = frmlogin.DialogResult;
            if (loginDialogResult != System.Windows.Forms.DialogResult.OK)
                this.Close();
        }
    }
}

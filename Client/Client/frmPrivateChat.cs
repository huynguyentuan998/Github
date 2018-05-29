using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace Client
{
    public partial class frmPrivateChat : Form
    {
        IPEndPoint IpE;
        Socket Cli;
        public frmPrivateChat()
        {
            InitializeComponent();
        }

        private void frmPrivateChat_Load(object sender, EventArgs e)
        {

        }

        void Connect()
        {
            IpE = new IPEndPoint(IPAddress.Parse(txbIP.Text), 9999);
            Cli = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            Cli.Connect(IpE);
        }

        void CloseCli()
        {
            Cli.Close();
        }

        //void Send()
        //{
        //    if (txbMessage.Text != string.Empty)
        //        Cli.Send(Serialize(txbMessage.Text));
        //}

        //void Receive()
        //{
        //    byte[] data = new byte[1024 * 10000];
        //    Cli.Receive(data);
        //    String ViewMessage = (string)Deserialize(data);
        //}

        //byte[] Serialize(object obj)
        //{
        //    MemoryStream mem = new MemoryStream();

        //    Return mem.ToArray()
        //}

        //Object Deserialize(byte[] data)
        //{

        //}

    }
}

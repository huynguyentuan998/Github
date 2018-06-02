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
    public partial class frmMainClient : Form
    {
        public frmMainClient()
        {
            InitializeComponent();
            cAddress = Dns.GetHostName();
        }

        string cAddress;                                            //địa chỉ của Client
        const int Buffer_max_Size = 2550000;                        //hằng số quy định kích thước tối đa của mảng byte[]
        private byte[] Buffer = new byte[Buffer_max_Size];          //mảng byte[] dùng để lưu lại các thông tin được biên dịch từ luồng Stream có kích thước tối đa là buffer_max_size
                                                                    //TcpClient client dùng để lắng nghe các tín hiệu, các luồng được truyền tới qua nền tảng Sockets
        private TcpClient cListener;

        public string user;                                         //biến lưu username của người dùng / client
        public string port;                                         //biến lưu port của người dùng / client
        public string serverAddress;                                //biến lưu Address của server

        string str;                                                 //biến str lưu tạm các chuỗi string 
        public string private_chat_message;

        //Danh sách lưu lại các cửa sổ Private Chat đang được mở 
        //List<Private_chat> cPrivate_List = new List<Private_chat>();

        //Khai báo các biến, các cửa sổ dùng khi chơi game
        //biến boolean
        //public bool challenge = false;                                //biến boolean cho biết client có đang bị "thách thức" hay không[chỉ dùng khi chơi game]
        ///public bool accept = false;                                   //biến boolean cho biết client đã chấp nhận chơi game[chỉ dùng khi chơi game]
        //public string Rival;                                        //biến lưu lại tên username của client đối phương[chỉ dùng khi chơi game]
        //public bool be_gaming = false;                              //biến boolean lưu lại cho biết client đang chơi game[chỉ dùng khi chơi game]

        //public Be_challenge Passive_Player;                         //khai báo cửa sổ chơi game dành cho người chơi "thách thức"                             
        //public Challenge Active_Player;                             //khai báo cửa sổ chơi game dành cho người chơi "bị thách thức"

        //public int cScore = 0;                                      //biến cho biết điểm số hiện tại của client[chỉ dùng khi chơi game]

        //Khai báo một cửa sổ Nhận tệp tin được gửi đến
        //public Receive_file ReceiveFile_Window;

        private void frmMainClient_Load(object sender, EventArgs e)
        {
            DialogResult loginDialogResult;
            frmLogin frmlogin = new frmLogin();
            frmlogin.ShowDialog();
            loginDialogResult = frmlogin.DialogResult;
            if (loginDialogResult != System.Windows.Forms.DialogResult.OK)
                this.Close();
            this.user = frmlogin.userName;
            this.port = frmlogin.port;
            this.serverAddress = frmlogin.serverAddress;
            // Xử lý client kết nối server
            try
            {
                if (serverAddress.Trim() == "")
                //nếu phần textbox cho người dùng tự điền vào để trống thì tự động cấp phát theo địa chỉ của mạng đang dùng
                {
                    string hostname = Dns.GetHostName();
                    serverAddress = hostname;
                    
                    //cListener = new TcpClient(hostname, 2017);

                    //cListener.GetStream().BeginRead(Buffer, 0, Buffer_max_Size, new AsyncCallback(do_Reading), null);
                }
                if  (port.Trim() == "")
                    port = Convert.ToString(2017);
                //else
                //{
                    cListener = new TcpClient(serverAddress, int.Parse(port));
                    cListener.GetStream().BeginRead(Buffer, 0, Buffer_max_Size, new AsyncCallback(do_Reading), null);
                //}
                //this.Show();
                Send_data("Connect|" + user + "|" + cAddress); //gửi về báo cho server username mới
            }
            catch (Exception ex)
            {
                MessageBox.Show("can not connect to server " + ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
        }

        private void do_Reading(IAsyncResult ar)                    //hàm xử lí khi Client nhận được thông tin đến
        {
            int Buffer_lastIndex;
            string str_message;
            try
            {
                Buffer_lastIndex = cListener.GetStream().EndRead(ar);
                if (Buffer_lastIndex < 1)                           //nếu Buffer trống 
                {
                    return;
                }
                str_message = Encoding.UTF8.GetString(Buffer, 0, Buffer_lastIndex - 2);
                client_Handler(str_message);
                cListener.GetStream().BeginRead(Buffer, 0, Buffer_max_Size, new AsyncCallback(do_Reading), null);

            }
            catch (Exception e)
            {
                MessageBox.Show(user + " do_Reading error: " + e.ToString());
            }
        }

        private void client_Handler(string str_message)
        {
            string[] data_array;
            //sử dụng hàm Split('|') phân tách chuỗi data và chứa mỗi đoạn được ngăn cách bằng kí tự "|" vào một phần tử của mảng data_array
            data_array = str_message.Split('|');

            /*  Ý NGHĨA CỦA CHUỖI MESSAGE
            Một chuỗi message khi được gửi đi sẽ theo cú pháp và cấu trúc mà chương trình quy định, tương tự như : Command0|Command1|...|Commandn|data|sender.name (tùy vào
            yêu cầu thực thi mà cấu trúc có thể thay đổi). Phần Command0 sẽ quy định nhóm lệnh mà thông điệp Message thuộc về.
            Vì vậy để xác định nhóm lệnh mà Message thuộc về, ta sử dụng switch - case ( data_array[0] ) với data_array là Command0 đã được Split ra trước đó. 
            Tùy thuộc vào nhóm lệnh mà chúng ta xử lí và gọi các hàm liên quan tương ứng.
            */
            switch (data_array[0].Trim())
            {
                case "Join":                                        //Join|
                    //server đã đồng ý cho client tham gia vào hệ thống
                    {
                        Display_text("connect sucess" + (char)13 + (char)10);
                        break;
                    }
                //case "Chat":                                        //Chat|
                //    {
                //        //gửi yêu cầu cập nhật lại ds người dùng đến server
                //        Display_text("User list will be updated in few moment");
                //        cPrivate_List.Clear();
                //        Send_data("Request_users|");
                //        break;
                //    }
                //case "Refuse":                                      //Refuse
                //    {
                //        login_sceen();
                //        break;
                //    }
                ////mở lại màn hình login cho người dùng nhập lại username đã bị trùng trước đó
                //case "list_user":                                   //Update_User
                //    {
                //        //Xóa các danh sách Private_Chat đang có để cập nhật lại
                //        cPrivate_List.Clear();
                //        Online_Board.Items.Clear();
                //        break;
                //    }
                //case "Broad":                                       //Broad|thông điệp từ server
                //    {
                //        //Nhận thông điệp tin nhắn từ server
                //        Display_text("Admin: " + data_array[1] + (char)13 + (char)10);
                //        break;
                //    }
                //case "Private_chat_receive":                        //Private_Forward|Command1|thông điệp
                //    {
                //        //Nếu Command1 là "Game" (Private_Forward|Game
                //        if (data_array[1].Trim() == "Game")
                //        {
                //            Display_text("Gaming detected");
                //            get_game_data(str_message);             //hàm xử lí để nhận thông tin liên quan đến Game 
                //            return;
                //        }
                //        else //nếu không phải sẽ là chat private thông thường
                //        {
                //            Display_text("Private chat has been detected");
                //            Private_Chat_Handler(str_message);

                //        }
                //        break;
                //    }
                //case "Public_chat":
                //    {
                //        Display_text(data_array[1] + (char)13 + (char)10);
                //        break;
                //    }
                //case "Paint":
                //    {
                //        Paint_Handler(str_message);
                //        break;
                //    }
                //case "User_name":
                //    {
                //        List_user(str_message);
                //        break;
                //    }
                //case "File":
                //    {
                //        if (data_array[1].Trim() == "-Name")
                //        {
                //            update_name(data_array[2], data_array[4]);
                //        }
                //        else
                //        {
                //            worker.DoWork += view_receive_form_DoWork;
                //            worker.RunWorkerAsync();
                //        }
                //        break;
                //    }
                //case "Gaming":
                //    {
                //        button_gaming_control(data_array[1]);
                //        break;
                //    }
                default:
                    Display_text("no command 's detected ");
                    break;
            }

        }

        private void Display_text(string text)                      //hàm đưa chuỗi kí tự lên Message_Board
        {
            contentList.Items.Add(text);
        }

        private void messageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSend.PerformClick();
            }
        }

        public void Send_data(string data)
        {
            try
            {
                //tạo một đối tượng StreamWriter gắn với luồng Stream
                StreamWriter writer = new StreamWriter(cListener.GetStream());
                writer.Write(data + (char)13 + (char)10);
                //xóa dữ liệu tạm của Writer
                writer.Flush();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }                       //hàm gửi thông điệp từ client đến server 

    }
}

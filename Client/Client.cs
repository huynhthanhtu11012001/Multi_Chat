using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                Send();
                if (txt_message.Text != string.Empty)
                {
                    AddMessage("Me: " + txt_message.Text);
                }
            }
            catch
            {
                MessageBox.Show("Mất kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        IPEndPoint IP;
        Socket client;

        void Connect()
        {
            // IP: Địa chỉ máy làm Server
            IP = new IPEndPoint(IPAddress.Parse("192.168.1.8"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối với Server !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }



        // Đóng kết nối
        void Close()
        {
            client.Close();
        }



        // Gửi tin đi
        void Send()
        {
            if(txt_message.Text != string.Empty)
            {
                client.Send(Serialize("CLIENT: " + txt_message.Text));
            }
        }



        // Nhận tin
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);
                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }

        }



        //Đưa dữ liệu lên khung chat
        void AddMessage(string value)
        {

            listview_message.Items.Add(new ListViewItem() { Text = value });
            txt_message.Clear();
        }




        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }




        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }
        



        //Đóng kết nối khi đóng app
        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

    }
}

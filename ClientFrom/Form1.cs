using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientFrom
{
    public partial class Frm : Form
    {
        Socket client;
        byte[] data;
        IPEndPoint ipServer;
        public Frm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ipServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(ipServer);
                listBChat.Items.Add("Ket Noi Thanh Cong!");
            }
            catch (SocketException ex)
            {
                listBChat.Items.Add("Khong The Ket Noi Voi Server.");
                listBChat.Items.Add(ex.ToString());
                return;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            data = new byte[1024];
            data = Encoding.ASCII.GetBytes(txtMassage.Text);
            listBChat.Items.Add("Client: " + txtMassage.Text);
            txtMassage.Text = "";         
            client.Send(data);
            data = new byte[1024];
            client.Receive(data);
            txtMassage.Text = Encoding.ASCII.GetString(data);
            listBChat.Items.Add("Server: " + txtMassage.Text);
        }
    }
}

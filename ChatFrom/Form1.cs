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

namespace ChatFrom
{
    public partial class Frm : Form
    {
        Socket server, client;
        IPEndPoint ipClient;
        byte[] data;
        public Frm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string text = txtMassage.Text;
            listBChat.Items.Add("Server: " + text);
            txtMassage.Text = "";
            data = new byte[1024];
            data = Encoding.ASCII.GetBytes(text);
            client.Send(data);
            data = new byte[1024];
            client.Receive(data);
            listBChat.Items.Add("Client: " + Encoding.ASCII.GetString(data));
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            IPEndPoint ipServer = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipServer);
            server.Listen(5);
            listBChat.Items.Add("Cho Ket Noi Tu Client...!");
            client = server.Accept();
            IPEndPoint clientEP = (IPEndPoint)client.RemoteEndPoint;
            string lk = "Ket Noi Tu '" + clientEP.Address + "' Port '" + clientEP.Port + "'";
            listBChat.Items.Add(lk);
            data = new byte[1024];
            client.Receive(data);
            listBChat.Items.Add("Client: " + Encoding.ASCII.GetString(data));
        }
    }
}

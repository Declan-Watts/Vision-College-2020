using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment1_Client
{
    public partial class Form1 : Form
    {
        NetComm.Client client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new NetComm.Client();
            //Adding event handling methods for the client
            client.Connected += new NetComm.Client.ConnectedEventHandler(client_Connected);
            client.Disconnected += new NetComm.Client.DisconnectedEventHandler(client_Disconnected);
            client.DataReceived += new NetComm.Client.DataReceivedEventHandler(client_DataReceived);
        }

        void client_Connected()
        {
            Log.Items.Add("Connected successfully!" +
            Environment.NewLine); //Updates the log with the current connection state
        }

        void client_Disconnected()
        {
            Log.Items.Add("Disconnected from host!" +
            Environment.NewLine); //Updates the log with the current connection state
        }

        void client_DataReceived(byte[] Data, string ID)
        {
            Log.Items.Add(ID + ": " + ConvertBytesToString(Data) +
            Environment.NewLine); //Updates the log with the current connection state
        }

        string ConvertBytesToString(byte[] bytes)
        {
            return ASCIIEncoding.ASCII.GetString(bytes);
        }

        byte[] ConvertStringToBytes(string str)
        {
            return ASCIIEncoding.ASCII.GetBytes(str);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client.Connect("ddtuitions.com", 2020, "Jack"); //Connecting to the host 
                                                       //(on the same machine) with port 2020 and ID "Jack"
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            client.SendData(ConvertStringToBytes(txtChatMessage.Text), "Jack");
        }
    }
}

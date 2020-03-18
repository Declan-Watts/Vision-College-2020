using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment1
{
    public partial class Form1 : Form
    {
        NetComm.Host Server;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Server = new NetComm.Host(2020);    //Initialize the Server object, 
                                                //connection will use the 2020 port number
            Server.StartConnection();

            //Adding event handling methods, to handle the server messages
            Server.onConnection += new NetComm.Host.onConnectionEventHandler(Server_onConnection);
            Server.lostConnection += new NetComm.Host.lostConnectionEventHandler
                        (Server_lostConnection);
            Server.DataReceived += new NetComm.Host.DataReceivedEventHandler(Server_DataReceived);
        }

        void Server_onConnection(string id)
        {
            Log.Items.Add(id + " connected!" +
            Environment.NewLine); //Updates the log textbox when new user joined
        }

        void Server_lostConnection(string id)
        {
            Log.Items.Add(id + " disconnected" +
            Environment.NewLine); //Updates the log textbox when user leaves the room
        }

        void Server_DataReceived(string ID, byte[] Data)
        {
            Log.Items.Add(ID + ": " + ConvertBytesToString(Data) +
            Environment.NewLine);   //Updates the log when a new message arrived, 
                                    //converting the Data bytes to a string
        }

        string ConvertBytesToString(byte[] bytes)
        {
            return ASCIIEncoding.ASCII.GetString(bytes);
        }

        byte[] ConvertStringToBytes(string str)
        {
            return ASCIIEncoding.ASCII.GetBytes(str);
        }
    }
}

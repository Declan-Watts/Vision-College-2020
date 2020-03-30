using System;
using System.Text;

namespace Assessment1_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Defining Server...");
            NetComm.Host Server;

            Console.WriteLine("Creating Host...");
            Server = new NetComm.Host(2020);    //Initialize the Server object, 
                                                //connection will use the 2020 port number
            Console.WriteLine("Starting Server...");
            Server.StartConnection();
            Console.WriteLine("Server Started");

            while(true)
            {
                //Adding event handling methods, to handle the server messages
                Server.onConnection += new NetComm.Host.onConnectionEventHandler(Server_onConnection);
                Server.lostConnection += new NetComm.Host.lostConnectionEventHandler
                            (Server_lostConnection);
                Server.DataReceived += new NetComm.Host.DataReceivedEventHandler(Server_DataReceived);
            }
            
            
        }

        static void Server_onConnection(string id)
        {
            Console.WriteLine(id + " connected!" +
            Environment.NewLine); //Updates the log textbox when new user joined
        }

        static void Server_lostConnection(string id)
        {
            Console.WriteLine(id + " disconnected" +
            Environment.NewLine); //Updates the log textbox when user leaves the room
        }

        static void Server_DataReceived(string ID, byte[] Data)
        {
            Console.WriteLine(ID + ": " + ConvertBytesToString(Data) +
            Environment.NewLine);   //Updates the log when a new message arrived, 
                                    //converting the Data bytes to a string
        }

        static string ConvertBytesToString(byte[] bytes)
        {
            return ASCIIEncoding.ASCII.GetString(bytes);
        }

        static byte[] ConvertStringToBytes(string str)
        {
            return ASCIIEncoding.ASCII.GetBytes(str);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace TCP_IP_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string connectionline = "-------------------------------------------------------------------------------";
            int timer = 500;
            label_connectionline.Text = "";
            textBox_Connectionlog.Text = "";
            label_connectioninfo.Text = "Enstablishing connection";
            for (int i = 0; i < connectionline.Length; i++)
            {
                label_connectionline.Text = label_connectionline.Text + "-";
            }
            Thread.Sleep(timer);
            textBox_Connectionlog.Text = textBox_Connectionlog.Text + "Connection Log";
            textBox_Connectionlog.Text = textBox_Connectionlog.Text + Environment.NewLine;
            textBox_Connectionlog.Text = textBox_Connectionlog.Text + "<Enstablishing connection>";
            textBox_Connectionlog.Text = textBox_Connectionlog.Text + Environment.NewLine;
            textBox_Connectionlog.Text = textBox_Connectionlog.Text + "Trying to connect to: " + textBox_host.Text;
            try
            {
                // Establish the remote endpoint for the socket.
                // The name of the 
                // remote device is "Host".
                IPHostEntry ipHostInfo = Dns.GetHostEntry(textBox_host.Text);
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                textBox_Connectionlog.Text = textBox_Connectionlog.Text + Environment.NewLine;
                textBox_Connectionlog.Text = textBox_Connectionlog.Text + "Gathering info: ";
                textBox_Connectionlog.Text = textBox_Connectionlog.Text + Environment.NewLine;

                textBox_Connectionlog.Text = textBox_Connectionlog.Text + "IPv4: " + ipAddress;
                int port = 11000;
                textBox_Connectionlog.Text = textBox_Connectionlog.Text + Environment.NewLine;
                textBox_Connectionlog.Text = textBox_Connectionlog.Text + "Port: " + port;
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

                // Create a TCP/IP socket.
                Socket client = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
                // Connect to the remote endpoint.
                client.BeginConnect(remoteEP,
                    new AsyncCallback(ConnectCallback), client);
                textBox_Connectionlog.Text = textBox_Connectionlog.Text + Environment.NewLine;
                textBox_Connectionlog.Text = textBox_Connectionlog.Text + "<Connection Enstablished>";
                label_connectioninfo.Text = "Connection Enstablished";
                label_connectionline.ForeColor = Color.Green;
                textBox_Connectionlog.Text = textBox_Connectionlog.Text + Environment.NewLine;
                textBox_Connectionlog.Text = textBox_Connectionlog.Text + "Sending request";
                textBox_Connectionlog.Text = textBox_Connectionlog.Text + Environment.NewLine;
                textBox_Connectionlog.Text = textBox_Connectionlog.Text + "recieving respons";
                textBox_Connectionlog.Text = textBox_Connectionlog.Text + Environment.NewLine;
                textBox_Connectionlog.Text = textBox_Connectionlog.Text + "Simulation Successfull";
                // Send test data to the remote device.
                Send(client, "This is a test<EOF>");

                // Receive the response from the remote device.
                Receive(client);

                // Release the socket.
                client.Shutdown(SocketShutdown.Both);
                client.Close();

            }
            catch (Exception v)
            {
                textBox_Connectionlog.Text = textBox_Connectionlog.Text + Environment.NewLine;
                if (v.Message == "No such host is known")
                {
                    textBox_Connectionlog.Text = textBox_Connectionlog.Text + Environment.NewLine;
                    textBox_Connectionlog.Text = textBox_Connectionlog.Text + "<cannot enstablish connection>";
                    label_connectioninfo.Text = "Cannot enstablish Connection";
                    label_connectionline.ForeColor = Color.Red;
                    textBox_Connectionlog.Text = textBox_Connectionlog.Text + Environment.NewLine;
                    textBox_Connectionlog.Text = textBox_Connectionlog.Text + "Simulation Failed";
                }
            }



        }
        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)ar.AsyncState;

                // Complete the connection.
                client.EndConnect(ar);

                Console.WriteLine("Socket connected to {0}",
                    client.RemoteEndPoint.ToString());

                // Signal that the connection has been made.
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void Receive(Socket client)
        {
            try
            {
                // Create the state object.
                StateObject state = new StateObject();
                state.workSocket = client;

                // Begin receiving the data from the remote device.
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReceiveCallback), state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the state object and the client socket 
                // from the asynchronous state object.
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;

                // Read data from the remote device.
                int bytesRead = client.EndReceive(ar);

                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                    // Get the rest of the data.
                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(ReceiveCallback), state);
                }
                else {
                    // All the data has arrived; put it in response.
                    if (state.sb.Length > 1)
                    {
                    }
                    // Signal that all bytes have been received.
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void Send(Socket client, String data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.
            client.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), client);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = client.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to server.", bytesSent);

                // Signal that all bytes have been sent.
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            var HelpForm = new Form_help();
            HelpForm.Show();
        }
    }
    // State object for receiving data from remote device.
    public class StateObject
    {
        // Client socket.
        public Socket workSocket = null;
        // Size of receive buffer.
        public const int BufferSize = 256;
        // Receive buffer.
        public byte[] buffer = new byte[BufferSize];
        // Received data string.
        public StringBuilder sb = new StringBuilder();
    }

    public class AsynchronousClient
    {
        // The port number for the remote device.
        private const int port = 11000;

        // ManualResetEvent instances signal completion.
        private static ManualResetEvent connectDone =
            new ManualResetEvent(false);
        private static ManualResetEvent sendDone =
            new ManualResetEvent(false);
        private static ManualResetEvent receiveDone =
            new ManualResetEvent(false);

        // The response from the remote device.
        private static String response = String.Empty;
    }
    }

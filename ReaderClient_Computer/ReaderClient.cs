using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ReaderClient_Computer
{
    public partial class ReaderClient : Form
    {
        public ReaderClient()
        {
            InitializeComponent();
        }

        Socket server1;
        IPEndPoint ipep1;
        string a;
        private void ReaderClient_Load(object sender, EventArgs e)
        {
      
        }
        private void btn_Dinle_Click(object sender, EventArgs e)
        {
            try
            {
                server1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                ipep1 = new IPEndPoint(IPAddress.Parse(txtIpAdersi.Text), (Convert.ToInt32(txt_Port.Text) + 1));
                server1.Connect(ipep1);//servere bağlanma
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //while (true)
            //{   timer1.Start();
            //    NetworkStream NStream = new NetworkStream(server1);
            //    BinaryReader BReader = new BinaryReader(NStream);
            //    if (BReader.ReadString() == null && BReader.ReadString() == "")
            //    {
            //        txt_AlınanVeri.Items.Add("Şuan hiçbir Client veri göndermiyor... ");
            //        server1.Close();
            //    }
            //    else
            //    {
            //        txt_AlınanVeri.Items.Add(BReader.ReadString());
            //        a = BReader.ReadString();
            //        txt_AlınanVeri.Refresh();
            //    }
            //}
            while (true)
            {
                timer1.Start();
                byte[] data = new byte[1024];
                int alinanveriuzunlugu = server1.Receive(data);
                
                string veri = Encoding.ASCII.GetString(data, 0, alinanveriuzunlugu);
                txt_AlınanVeri.Items.Add(veri);
                txt_AlınanVeri.Refresh();
            }

        }
        private void btn_Durdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            server1.Close();// bağlantıyı kapatma
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_AlınanVeri.Items.Add(a);
            txt_AlınanVeri.Refresh();
        }

        private void txt_AlınanVeri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

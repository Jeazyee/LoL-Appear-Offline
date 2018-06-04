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

namespace LoL_AppearOffline
{
    public partial class LoL_AppearOffline : Form
    {


        /*
         * SERVERS
         */

        String BR = "chat.br.lol.riotgames.com";
        String EUNE = "chat.eun1.lol.riotgames.com";
        String EUW = "chat.euw1.lol.riotgames.com";
        String ID = "chatid.lol.garenanow.com";
        String KR = "chat.kr.lol.riotgames.com";
        String LAN = "chat.la1.lol.riotgames.com";
        String LAS = "chat.la2.lol.riotgames.com";
        String NA = "chat.na1.lol.riotgames.com";
        String NA2 = "chat.na2.lol.riotgames.com";
        String OCE = "chat.oc1.lol.riotgames.com";
        String PBE = "chat.pbe1.lol.riotgames.com";
        String PH = "chatph.lol.garenanow.com";
        String RU = "chat.ru.lol.riotgames.com";
        String SEA = "chat.lol.garenanow.com";
        String TH = "chatth.lol.garenanow.com";
        String TR = "chat.tr.lol.riotgames.com";
        String TW = "chattw.lol.garenanow.com";
        String VN = "chatvn.lol.garenanow.com";


        public LoL_AppearOffline()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void reenableServer()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "netsh";
            startInfo.Arguments = "advfirewall firewall delete rule name='lolchat'";
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            try
            {
                process.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: You must grant Admin priviledges! Lets try it again!");
            }
        }

        private void disableServer(String IP_DNS)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "netsh";
            startInfo.Arguments = "advfirewall firewall add rule name='lolchat' dir=out remoteip=" + GetIP(IP_DNS) + " protocol=TCP action=block";
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            try
            {
                process.Start();
                MessageBox.Show("SUCCESS: Good luck in inkognito mode!;)");
            }
            catch (Exception e) {
                MessageBox.Show("ERROR: You must grant Admin priviledges! Lets try it again!");
            }
        }

        private String GetIP(String hostString) {
                IPHostEntry hostInfo = Dns.Resolve(hostString);
                // Get the IP address list that resolves to the host names contained in the 
                // Alias property.
                IPAddress[] address = hostInfo.AddressList;
                // Get the alias names of the addresses in the IP address list.
                String[] alias = hostInfo.Aliases;

            string[] ips = address.Select(ip => ip.ToString()).ToArray();
            return ips[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            disableServer(RU);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reenableServer();
            MessageBox.Show("SUCCESS: You will now appear online again may you need to relogin in LoL!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            disableServer(TR);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            disableServer(TH);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            disableServer(ID);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            disableServer(KR);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            disableServer(EUW);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            disableServer(OCE);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NA has 2 Servers so don't wonder if you get asked twice :)");
            disableServer(NA);
            disableServer(NA2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            disableServer(PH);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            disableServer(BR);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            disableServer(SEA);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            disableServer(TW);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            disableServer(VN);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            disableServer(PBE);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            disableServer(LAN);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            disableServer(LAS);
        }
    }
}

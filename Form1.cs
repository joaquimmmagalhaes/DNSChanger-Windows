using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.Collections;

namespace DNSChanger
{
    public partial class Form1 : Form
    {
        RegistryKey key = Registry.LocalMachine.OpenSubKey("Software", true);
        private string Adapter_Selected = "";
        private string Server_Primary = "";
        private string Server_Secondary = "";
        private string Server_One_Name = "";
        private string Server_One_IP = "";
        private string Server_Two_Name = "";
        private string Server_Two_IP = "";
        private string Server_Three_Name = "";
        private string Server_Three_IP = "";
        private string Server_Four_Name = "";
        private string Server_Four_IP = "";

        public Form1()
        {
            InitializeComponent();
            Init_Program();
        }

        private void Init_Program()
        {
            key = key.OpenSubKey("DNSChanger", true);
            if (key == null)
            {
                key = Registry.LocalMachine.OpenSubKey("Software", true).CreateSubKey("DNSChanger");
            }
            key = key.OpenSubKey("Servers", true);
            if (key == null)
            {
                key = Registry.LocalMachine.OpenSubKey("Software", true).CreateSubKey("DNSChanger").CreateSubKey("Servers");
                key.SetValue("Servers", First_Run());
            }
            string Servers_JSON = (string) key.GetValue("Servers");
            List<Server> servers = JsonConvert.DeserializeObject<List<Server>>(Servers_JSON);
            Server Server_1 = Get_Server(servers, 0), Server_2 = Get_Server(servers, 1),
                Server_3 = Get_Server(servers, 2), Server_4 = Get_Server(servers, 3);
            if (Server_1 != null)
            {
                Server_One.Visible = true;
                Server_One_Name = Server_1.Name;
                Server_One_IP = Server_1.IP;
            }
            else
            {
                Server_One.Visible = false;
            }
       
            if (Server_2 != null)
            {
                Server_Two.Visible = true;
                Server_Two_Name = Server_2.Name;
                Server_Two_IP = Server_2.IP;
            }
            else
            {
                Server_Two.Visible = false;
            }

            if (Server_3 != null)
            {
                Server_Three.Visible = true;
                Server_Three_Name = Server_3.Name;
                Server_Three_IP = Server_3.IP;
            }
            else
            {
                Server_Three.Visible = false;
            }

            if (Server_4 != null)
            {
                Server_Four.Visible = true;
                Server_Four_Name = Server_4.Name;
                Server_Four_IP = Server_4.IP;
            }
            else
            {
                Server_Four.Visible = false;
            }




            Add_Info();
            Primary_Server_Label_Title.Visible = false;
            Secondary_Server_Label_Title.Visible = false;
            Adapters_ComboBox.SelectedIndex = 0;
        }


        private Server Get_Server(List<Server> Servers, int Pos)
        {
            int i = 0;
            foreach(Server Aux in Servers)
            {
                if (i++ == Pos)
                {
                    return Aux;
                }
            }
            return null;
        }


        private string First_Run()
        {
            List<Server> servers = new List<Server>();
            servers.Add(new Server("Google", "8.8.8.8"));
            servers.Add(new Server("OpenDNS", "208.67.222.222"));
            servers.Add(new Server("Comodo", "8.26.56.26"));
            servers.Add(new Server("SafeDNS", "195.46.39.39"));
        
            return JsonConvert.SerializeObject(servers);
        }

        private void Add_Info()
        {
            string DNS_Info = "";
            string DNS_Info_Aux = "";
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                Adapters_ComboBox.Items.Add(adapter.Name);
                IPAddressCollection dnsServers = adapter.GetIPProperties().DnsAddresses;
                DNS_Info = DNS_Info + "- " + adapter.Name + "\r\n";
                foreach (IPAddress dns in dnsServers)
                {
                    if (!dns.ToString().Contains("fec0:0:0:ffff::"))
                    {
                        DNS_Info_Aux = DNS_Info_Aux + dns.ToString() + "\r\n";
                    }
                    
                    if (DNS_Info_Aux.Count() == 0)
                    {
                        DNS_Info_Aux = "DHCP - Automatic" + "\r\n";
                    }
                }
                DNS_Info = DNS_Info + DNS_Info_Aux + "\r\n";
                DNS_Info_Aux = "";
            }
            DNS_Text_Box.Text = DNS_Info;
            Server_One.Text = Server_One_Name;
            Server_Two.Text = Server_Two_Name;
            Server_Three.Text = Server_Three_Name;
            Server_Four.Text = Server_Four_Name;
        }

        private void Server_One_Click(object sender, EventArgs e)
        {
            Selected_Server(Server_One_Name, Server_One_IP);
        }

        private void Server_Two_Click(object sender, EventArgs e)
        {
            Selected_Server(Server_Two_Name, Server_Two_IP);
        }

        private void Server_Three_Click(object sender, EventArgs e)
        {
            Selected_Server(Server_Three_Name, Server_Three_IP);
        }

        private void Server_Four_Click(object sender, EventArgs e)
        {
            Selected_Server(Server_Four_Name, Server_Four_IP);
        }

        private void Adapters_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Adapter_Selected = Adapters_ComboBox.SelectedItem.ToString();
        }

        private void Reset_DNS_Click(object sender, EventArgs e)
        {
            Run_Command("netsh interface ipv4 set dnsservers " + '"' + Adapter_Selected + '"' + " dhcp");
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            Apply.Enabled = false;
            if (Server_Secondary.CompareTo("") == 0)
            {
                Run_Command("netsh interface ipv4 set dnsservers " + '"' + Adapter_Selected + '"' + " static " + Server_Primary + " primary");
                Add_Info();
                Apply.Enabled = true;
                return;
            }
            Run_Command("netsh interface ipv4 set dnsservers " + '"' + Adapter_Selected + '"' + " static " + Server_Primary + " primary");
            Run_Command("netsh interface ipv4 add dnsserver " + '"' + Adapter_Selected + '"' + " address=" + Server_Secondary + " index=2");
            Add_Info();
            Apply.Enabled = true;
        }

        private void Run_Command(string command)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
        }

        private void Selected_Server(string Server_Name, string Server_IP)
        {
            if (Server_Primary.CompareTo("") == 0)
            {
                Server_Primary = Server_IP;
                Primary_Server_Label_Title.Visible = true;
                Primary_Server_Label_Name.Text = Server_Name;
            }
            else if (Server_Secondary.CompareTo("") == 0)
            {
                Server_Secondary = Server_IP;
                Secondary_Server_Label_Title.Visible = true;
                Secondary_Server_Label_Name.Text = Server_Name;
            }
        }

        private void Cancel_Selection_Click(object sender, EventArgs e)
        {
            Server_Primary = "";
            Primary_Server_Label_Title.Visible = false;
            Primary_Server_Label_Name.Text = "";
            Server_Secondary = "";
            Secondary_Server_Label_Title.Visible = false;
            Secondary_Server_Label_Name.Text = "";
        }

        private void Edit_Servers_Click(object sender, EventArgs e)
        {
            Servers form = new Servers();
            form.ShowDialog();
            Init_Program();
        }
    }
}

using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNSChanger
{
    public partial class Servers : Form
    {
        RegistryKey key = Registry.LocalMachine.OpenSubKey("Software", true).OpenSubKey("DNSChanger", true).OpenSubKey("Servers", true);

        public Servers()
        {
            InitializeComponent();
            Load_Info();
        }

        private void Load_Info()
        {
            string Servers_JSON = (string)key.GetValue("Servers");
            List<Server> servers = JsonConvert.DeserializeObject<List<Server>>(Servers_JSON);
            Server Server_1 = Get_Server(servers, 0), Server_2 = Get_Server(servers, 1),
                Server_3 = Get_Server(servers, 2), Server_4 = Get_Server(servers, 3);

            Server_One_Name.Text = "";
            Server_One_IP.Text = "";
            Server_Two_Name.Text = "";
            Server_Two_IP.Text = "";
            Server_Three_Name.Text = "";
            Server_Three_IP.Text = "";
            Server_Four_Name.Text = "";
            Server_Four_IP.Text = "";

            if (Server_1 != null)
            {
                Server_One_Name.Text = Server_1.Name;
                Server_One_IP.Text = Server_1.IP;
            }

            if (Server_2 != null)
            {
                Server_Two_Name.Text = Server_2.Name;
                Server_Two_IP.Text = Server_2.IP;
            }

            if (Server_3 != null)
            {
                Server_Three_Name.Text = Server_3.Name;
                Server_Three_IP.Text = Server_3.IP;
            }

            if (Server_4 != null)
            {
                Server_Four_Name.Text = Server_4.Name;
                Server_Four_IP.Text = Server_4.IP;
            }
        }

        private Server Get_Server(List<Server> Servers, int Pos)
        {
            int i = 0;
            foreach (Server Aux in Servers)
            {
                if (i++ == Pos)
                {
                    return Aux;
                }
            }
            return null;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            List<Server> servers = new List<Server>();
            if (Add_To_List(servers, Server_One_Name.Text, Server_One_IP.Text) && Add_To_List(servers, Server_Two_Name.Text, Server_Two_IP.Text) && 
                Add_To_List(servers, Server_Three_Name.Text, Server_Three_IP.Text) && Add_To_List(servers, Server_Four_Name.Text, Server_Four_IP.Text))
            {
                key.SetValue("Servers", JsonConvert.SerializeObject(servers));
                this.Close();
            }
            else if (!(Add_To_List(servers, Server_One_Name.Text, Server_One_IP.Text))){
                Server_One_Name.BackColor = Color.Red;
                Server_One_IP.BackColor = Color.Red;
            }else if (!(Add_To_List(servers, Server_Two_Name.Text, Server_Two_IP.Text))){
                Server_Two_Name.BackColor = Color.Red;
                Server_Two_IP.BackColor = Color.Red;
            }else if (!(Add_To_List(servers, Server_Three_Name.Text, Server_Three_IP.Text))){
                Server_Three_Name.BackColor = Color.Red;
                Server_Three_IP.BackColor = Color.Red;
            }else if (!(Add_To_List(servers, Server_Four_Name.Text, Server_Four_IP.Text))){
                Server_Four_Name.BackColor = Color.Red;
                Server_Four_IP.BackColor = Color.Red;
            }
        }

        private Boolean Add_To_List(List<Server> servers,string Name, string IP)
        {
            if (Name.CompareTo("") != 0 && IP.CompareTo("") != 0)
            {
                if (Check_IP_Address(IP))
                {
                    servers.Add(new Server(Name, IP));
                    return true;
                }
                return false;
            }
            return true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean Check_IP_Address(string IP)
        {
            IPAddress address;
            if (IPAddress.TryParse(IP, out address))
            {
                switch (address.AddressFamily)
                {
                    case System.Net.Sockets.AddressFamily.InterNetwork:
                        return true;
                    case System.Net.Sockets.AddressFamily.InterNetworkV6:
                        return false;
                    default:
                        return false;
                }
            }
            return false;
        }
    }
}

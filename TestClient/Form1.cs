using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.Service1Client myService = new TestClient.ServiceReference2.Service1Client();
            myService.ClientCredentials.UserName.UserName = "karl.bengtsson_gmail";
            myService.ClientCredentials.UserName.Password = "trustNo1";
            MessageBox.Show(myService.GetOrders().ToString());
            myService.Close();
        }
    }
}

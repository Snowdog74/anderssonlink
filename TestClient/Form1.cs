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
            OrderServiceReference.OrderServiceClient myService = new TestClient.OrderServiceReference.OrderServiceClient();
            myService.ClientCredentials.UserName.UserName = "karl.bengtsson_gmail";
            myService.ClientCredentials.UserName.Password = "trustNo1";
            DataSet orders = myService.GetOrders();
            dataGridView1.DataSource = orders.Tables[0];
            string XMLversion = orders.GetXml();
            textBox1.Text = XMLversion;
            myService.Close();
        }
    }
}

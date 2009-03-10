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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int orderToDeleteId = int.Parse(deleteValue.Text);
            OrderServiceReference.OrderServiceClient deleteservice = new TestClient.OrderServiceReference.OrderServiceClient();
            deleteservice.ClientCredentials.UserName.UserName = "karl.bengtsson_gmail";
            deleteservice.ClientCredentials.UserName.Password = "trustNo1";
            bool didItWork = deleteservice.DeleteOrder(orderToDeleteId);
            if (didItWork)
            {
                MessageBox.Show("Message " + orderToDeleteId + " was deleted successfully!");
            }
            else
            {
                MessageBox.Show("Message " + orderToDeleteId + " was NOT deleted successfully!");
            }
        }
    }
}

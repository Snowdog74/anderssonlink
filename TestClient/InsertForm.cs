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
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            OrderServiceReference.OrderServiceClient insertClient = new TestClient.OrderServiceReference.OrderServiceClient();
            insertClient.ClientCredentials.UserName.UserName = "karl.bengtsson_gmail";
            insertClient.ClientCredentials.UserName.Password = "trustNo1";
            bool didItWork = insertClient.InsertOrder(
                int.Parse(articleNoField.Text),
                descriptionField.Text,
                orderDatePicker.Value,
                deliveryDatePicker.Value,
                int.Parse(quantityField.Text),
                int.Parse(piecePriceField.Text),
                customerField.Text,
                int.Parse(customerNoField.Text),
                int.Parse(customerOrderNoField.Text),
                infoField.Text,
                currencyField.Text,
                recipientField.Text);
            if (didItWork)
            {
                MessageBox.Show("Order was successfully added.");
            }
            else
            {
                MessageBox.Show("Order was not added.");
            }
        }
    }
}

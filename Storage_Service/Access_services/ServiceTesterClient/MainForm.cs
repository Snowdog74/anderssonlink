using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServiceTesterClient.OrderServiceReference;
using ServiceTesterClient.InvoiceServiceReference;

namespace ServiceTesterClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void putOrderButton_Click(object sender, EventArgs e)
        {
            OrderMessage newOrder = new OrderMessage();
            newOrder.Currency = this.currencyTextBox.Text;
            newOrder.DeliveryDate = this.deliveryDateTimePicker.Value;
            newOrder.ItemDescription = this.itemDescriptionTextBox.Text;
            newOrder.ItemNumber = this.itemNumberTextBox.Text;
            newOrder.OrderDate = this.orderDateTimePicker.Value;
            newOrder.Price = int.Parse(this.priceTextBox.Text);
            newOrder.Quantity = int.Parse(this.quantityTextBox.Text);
            newOrder.Recipient = this.recipientTextBox.Text;
            newOrder.Sender = this.senderTextBox.Text;
            newOrder.Text = this.textTextBox.Text;
            OrderServiceClient proxy = new OrderServiceClient();
            proxy.ClientCredentials.UserName.UserName = "karl.bengtsson_gmail";
            proxy.ClientCredentials.UserName.Password = "trustNo1";
            bool success = proxy.PutOrder(newOrder);
            if (success)
                MessageBox.Show("PutOrder() call was successful.");
            else
                MessageBox.Show("PutOrder() call failed.");
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            int orderToDelete = int.Parse(this.orderToDeleteTextBox.Text);
            OrderServiceClient proxy = new OrderServiceClient();
            proxy.ClientCredentials.UserName.UserName = "karl.bengtsson_gmail";
            proxy.ClientCredentials.UserName.Password = "trustNo1";
            bool success = proxy.DeleteOrder(orderToDelete);
            if (success)
                MessageBox.Show("DeleteOrder() call was successful.");
            else
                MessageBox.Show("DeleteOrder() call failed.");
        }

        private void getOrdersButton_Click(object sender, EventArgs e)
        {
            this.responseTextBox.Text = "";
            OrderServiceClient proxy = new OrderServiceClient();
            proxy.ClientCredentials.UserName.UserName = "karl.bengtsson_gmail";
            proxy.ClientCredentials.UserName.Password = "trustNo1";
            OrderMessage[] orderMessages = proxy.GetOrders();
            foreach (OrderMessage orderMessage in orderMessages)
            {
                string orderString = string.Format(
                    "ID: {0}\r\nSender: {1}\r\nRecipient: {2}\r\nItemNumber: {3}\r\nItemDescription: {4}\r\n\r\n",
                    orderMessage.Id,
                    orderMessage.Sender,
                    orderMessage.Recipient,
                    orderMessage.ItemNumber,
                    orderMessage.ItemDescription);
                this.responseTextBox.Text += orderString;
            }
        }

        private void sendInvoiceButton_Click(object sender, EventArgs e)
        {
            INVOICMessage invoice = new INVOICMessage();
            invoice.Sender = invoiceSender.Text.ToUpper();
            invoice.Recipient = invoiceRecipient.Text.ToUpper();
            invoice.InvoiceNumber = invoiceNumber.Text.ToUpper();
            invoice.ItemDescription = invoiceItemDescription.Text.ToUpper();
            invoice.DueDate = invoiceDueDate.Value.ToString("yyMMdd");
            invoice.Reference = invoiceReference.Text.ToUpper();
            invoice.Amount = invoiceAmount.Text.ToUpper();
            invoice.Currency = invoiceCurrency.Text.ToUpper();
            INVOICMessageAdress adress = new INVOICMessageAdress();
            adress.Street = invoiceStreet.Text.ToUpper();
            adress.City = invoiceCity.Text.ToUpper();
            adress.Zipcode = invoiceZipcode.Text.ToUpper();
            adress.Country = invoiceCountry.Text.ToUpper();
            invoice.Adress = adress;
            DefaultClient proxy = new DefaultClient();
            proxy.ClientCredentials.UserName.UserName = "karl.bengtsson_gmail";
            proxy.ClientCredentials.UserName.Password = "trustNo1";
            InvoiceResult result = proxy.Operation_1(invoice);
            MessageBox.Show(result.Result);
        }
    }
}

//-----------------------------------------------------------------------
// <copyright file="InsertForm.cs" company="System Andersson AB">
//     Copyright (c) System Andersson AB 2009. All rights reserved.
// </copyright>
// <author>Karl Bengtsson</author>
// <summary>Insertion form for new orders in test client.</summary>
//-----------------------------------------------------------------------

namespace TestClient
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using TestClient.OrderServiceReference;

    /// <summary>
    /// Form for inserting new orders.
    /// </summary>
    public partial class InsertForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the InsertForm class.
        /// </summary>
        public InsertForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Event handler for the event that fires when the cancel button is clicked.
        /// </summary>
        /// <param name="sender">Sending object (cancelButton).</param>
        /// <param name="e">Event arguments.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event handler for the event that fires when the insert button is clicked.
        /// </summary>
        /// <param name="sender">Sending object (insertButton).</param>
        /// <param name="e">Event arguments.</param>
        private void InsertButton_Click(object sender, EventArgs e)
        {
            OrderServiceReference.OrderServiceClient insertClient = new TestClient.OrderServiceReference.OrderServiceClient();
            insertClient.ClientCredentials.UserName.UserName = "karl.bengtsson_gmail";
            insertClient.ClientCredentials.UserName.Password = "trustNo1";
            OrderMessage newOrder = new OrderMessage();
            newOrder.Sender = this.senderField.Text;
            newOrder.Recipient = this.recipientField.Text;
            newOrder.ItemNumber = this.itemNumberField.Text;
            newOrder.ItemDescription = this.itemDescriptionField.Text;
            newOrder.OrderDate = this.orderDatePicker.Value;
            newOrder.DeliveryDate = this.deliveryDatePicker.Value;
            newOrder.Quantity = int.Parse(this.quantityField.Text);
            newOrder.Price = int.Parse(this.priceField.Text);
            newOrder.Currency = this.currencyField.Text;
            newOrder.Text = this.textField.Text;
            bool didItWork = insertClient.PutOrder(newOrder);
            if (didItWork)
            {
                MessageBox.Show("Order was successfully added.");
            }
            else
            {
                MessageBox.Show("Order was not added.");
            }
        }

        private void DescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void InsertForm_Load(object sender, EventArgs e)
        {

        }
    }
}

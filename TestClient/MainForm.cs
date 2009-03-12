//-----------------------------------------------------------------------
// <copyright file="MainForm.cs" company="System Andersson AB">
//     Copyright (c) System Andersson AB 2009. All rights reserved.
// </copyright>
// <author>Karl Bengtsson</author>
// <summary>AnderssonLink test client main form methods.</summary>
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

    /// <summary>
    /// Partial class holding methods for the main form MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The insert form used in this instance of the application.
        /// </summary>
        private InsertForm insertForm = new InsertForm();

        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Event handler for the event that fires when button1 is pressed.
        /// </summary>
        /// <param name="sender">Sending object (button1).</param>
        /// <param name="e">Event arguments.</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            OrderServiceReference.OrderServiceClient myService = new TestClient.OrderServiceReference.OrderServiceClient();
            myService.ClientCredentials.UserName.UserName = "karl.bengtsson_gmail";
            myService.ClientCredentials.UserName.Password = "trustNo1";
            DataSet orders = myService.GetOrders();
            this.dataGridView1.DataSource = orders.Tables[0];
            string xmlVersion = orders.GetXml();
            this.textBox1.Text = xmlVersion;
            myService.Close();
        }

        /// <summary>
        /// Event handler for the event that fires when deleteButton is pressed.
        /// </summary>
        /// <param name="sender">Sending object (deleteButton).</param>
        /// <param name="e">Event arguments.</param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int orderToDeleteId = int.Parse(this.deleteValue.Text);
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

        /// <summary>
        /// Event handler for the event that happens when the insertFormButton is clicked.
        /// </summary>
        /// <param name="sender">Sending object (insertFormButton).</param>
        /// <param name="e">Event arguments.</param>
        private void InsertFormButton_Click(object sender, EventArgs e)
        {
            this.insertForm.Show();
        }
    }
}

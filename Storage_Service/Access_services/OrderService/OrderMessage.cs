//-----------------------------------------------------------------------
// <copyright file="OrderMessage.cs" company="System Andersson AB">
//     Copyright (c) System Andersson AB 2009. All rights reserved.
// </copyright>
// <author>Karl Bengtsson</author>
// <summary>Class definition for the OrderMessage class.</summary>
//-----------------------------------------------------------------------

namespace AnderssonLink.MessageDatabase.AccessServices.OrderService
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    /// <summary>
    /// This object represents an order message. 
    /// Each order is for exactly one product (at a given quantity).
    /// If the customer wishes to order multiple products, these must be input one at a time.
    /// Orders thus have more in common with the concept "production order" rather than
    /// "purchase order".
    /// </summary>
    [DataContract]
    public class OrderMessage
    {
        #region Private member fields
        private int id;
        private string sender;
        private string recipient;
        private string itemNumber;
        private string itemDescription;
        private DateTime orderDate;
        private DateTime deliveryDate;
        private int quantity;
        private int price;
        private string currency;
        private string text;
        #endregion

        #region Constructors
        public OrderMessage()
        {
        }

        public OrderMessage(string sender, string recipient, string itemNumber, string itemDescription, DateTime orderDate, DateTime deliveryDate, int quantity, int price, string currency, string text)
        {
            this.Sender = sender;
            this.Recipient = recipient;
            this.ItemNumber = itemNumber;
            this.ItemDescription = itemDescription;
            this.OrderDate = orderDate;
            this.DeliveryDate = deliveryDate;
            this.Quantity = quantity;
            this.Price = price;
            this.Currency = currency;
            this.Text = text;
        }

        public OrderMessage(
            int id, 
            string sender, 
            string recipient, 
            string itemNumber, 
            string itemDescription, 
            DateTime orderDate, 
            DateTime deliveryDate, 
            int quantity, 
            int price, 
            string currency, 
            string text) 
            : this(sender, recipient, itemNumber, itemDescription, orderDate, deliveryDate, quantity, price, currency, text)
        {
            this.Id = id;
        }

        public OrderMessage(DataRow order)
        {
            this.Id = int.Parse(order["Id"].ToString());
            this.Sender = order["Sender"].ToString();
            this.Recipient = order["Recipient"].ToString();
            this.ItemNumber = order["ItemNumber"].ToString();
            this.ItemDescription = order["ItemDescription"].ToString();
            this.OrderDate = DateTime.Parse(order["OrderDate"].ToString());
            this.DeliveryDate = DateTime.Parse(order["DeliveryDate"].ToString());
            this.Quantity = int.Parse(order["Quantity"].ToString());
            this.Price = int.Parse(order["Price"].ToString());
            this.Currency = order["Currency"].ToString();
            this.Text = order["Text"].ToString();
        }
        #endregion

        #region Publicly accessible properties
        [DataMember]
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        [DataMember]
        public string Sender
        {
            get { return this.sender; }
            set { this.sender = value; }
        }

        [DataMember]
        public string Recipient
        {
            get { return this.recipient; }
            set { this.recipient = value; }
        }

        [DataMember]
        public string ItemNumber
        {
            get { return this.itemNumber; }
            set { this.itemNumber = value; }
        }
        
        [DataMember]
        public string ItemDescription
        {
            get { return this.itemDescription; }
            set { this.itemDescription = value; }
        }
        
        [DataMember]
        public DateTime OrderDate
        {
            get { return this.orderDate; }
            set { this.orderDate = value; }
        }
        
        [DataMember]
        public DateTime DeliveryDate
        {
            get { return this.deliveryDate; }
            set { this.deliveryDate = value; }
        }
        
        [DataMember]
        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        [DataMember]
        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        [DataMember]
        public string Currency
        {
            get { return this.currency; }
            set { this.currency = value; }
        }

        [DataMember]
        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return String.Format(
                "{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",
                this.Id,
                this.Sender,
                this.Recipient,
                this.ItemNumber,
                this.ItemDescription,
                this.OrderDate,
                this.DeliveryDate,
                this.Quantity,
                this.Price,
                this.Currency,
                this.Text);
        }
        #endregion
    }
}

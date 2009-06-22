using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Data;

namespace AnderssonLink
{
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
        public OrderMessage()
        {
        }

        public OrderMessage(string sender, string recipient, string itemNumber, string itemDescription,
            DateTime orderDate, DateTime deliveryDate, int quantity, int price, string currency, string text)
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

        public OrderMessage(int id, string sender, string recipient, string itemNumber, string itemDescription, 
            DateTime orderDate, DateTime deliveryDate, int quantity, int price, string currency, string text) :
            this(sender, recipient, itemNumber, itemDescription, orderDate, deliveryDate, quantity, price, currency, text)
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

        // Private member fields
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

        // Publicly accessible properties
        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }

        [DataMember]
        public string Recipient
        {
            get { return recipient; }
            set { recipient = value; }
        }

        [DataMember]
        public string ItemNumber
        {
            get { return itemNumber; }
            set { itemNumber = value; }
        }
        
        [DataMember]
        public string ItemDescription
        {
            get { return itemDescription; }
            set { itemDescription = value; }
        }
        
        [DataMember]
        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
        
        [DataMember]
        public DateTime DeliveryDate
        {
            get { return deliveryDate; }
            set { deliveryDate = value; }
        }
        
        [DataMember]
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        [DataMember]
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        [DataMember]
        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        [DataMember]
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

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
    }
}

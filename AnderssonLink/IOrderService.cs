//-----------------------------------------------------------------------
// <copyright file="IOrderService.cs" company="System Andersson AB">
//     Copyright (c) System Andersson AB 2009. All rights reserved.
// </copyright>
// <author>Karl Bengtsson</author>
// <summary>Interface for the OrderService WCF service.</summary>
//-----------------------------------------------------------------------

namespace AnderssonLink
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;

    /// <summary>
    /// This interface defines the publically accessible methods used for manipuluating orders
    /// stored in the database. Changing the name of the interface neccesitates changing the
    /// contract parameter in the App.config file.
    /// </summary>
    [ServiceContract]
    public interface IOrderService
    {
        /// <summary>
        /// This method returns all manufacture orders in the system for the user in question.
        /// The orders are not purged from the system upon retrieval.
        /// </summary>
        /// <returns>A dataset containing the orders. This should be changed to a custom class defined
        /// elsewhere so that we ues a consistent schema.</returns>
        [OperationContract]
        DataSet GetOrders();

        /// <summary>
        /// Purges a given order from the database. Run this after retrieving the order.
        /// </summary>
        /// <param name="orderId">Identifier of the order to remove.</param>
        /// <returns>True if the order was removed, else false.</returns>
        [OperationContract]
        bool DeleteOrder(int orderId);

        /// <summary>
        /// This method inserts a new order into the database with the fields values given by
        /// the method parameters. Each order is for exactly one product (at a given quantity).
        /// If the customer wishes to order multiple products, these must be input one at a time.
        /// Orders thus have more in common with the concept "production order" rather than
        /// "purchase order".
        /// </summary>
        /// <param name="articleNo">Article number.</param>
        /// <param name="description">Article description.</param>
        /// <param name="orderDate">Order date.</param>
        /// <param name="deliveryDate">Requested delivery date.</param>
        /// <param name="quantity">Number of ordered items.</param>
        /// <param name="piecePrice">Price per item.</param>
        /// <param name="customer">Name of customer company.</param>
        /// <param name="customerNo">Customer company number.</param>
        /// <param name="customerOrderNo">Order number in the customers system.</param>
        /// <param name="info">Other descriptive text for the order.</param>
        /// <param name="currency">Currency that the order is to be paid in.</param>
        /// <param name="recipient">The company this order is intended for.</param>
        /// <returns>True if insert was successful, else false.</returns>
        [OperationContract]
        bool InsertOrder(
            int articleNo,
            string description,
            DateTime orderDate,
            DateTime deliveryDate,
            int quantity,
            int piecePrice,
            string customer,
            int customerNo,
            int customerOrderNo,
            string info,
            string currency,
            string recipient);

        [OperationContract]
        bool InsertOrderByObject(InsertOrderMessage message);
    }
}

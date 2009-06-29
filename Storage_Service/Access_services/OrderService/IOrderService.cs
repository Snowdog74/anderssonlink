//-----------------------------------------------------------------------
// <copyright file="IOrderService.cs" company="System Andersson AB">
//     Copyright (c) System Andersson AB 2009. All rights reserved.
// </copyright>
// <author>Karl Bengtsson</author>
// <summary>Interface for the OrderService WCF service.</summary>
//-----------------------------------------------------------------------

namespace AnderssonLink.MessageDatabase.AccessServices.OrderService
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
        OrderMessage[] GetOrders();

        /// <summary>
        /// Purges a given order from the database. Run this after retrieving the order.
        /// </summary>
        /// <param name="orderId">Identifier of the order to remove.</param>
        /// <returns>True if the order was removed, else false.</returns>
        [OperationContract]
        bool DeleteOrder(int orderId);

        /// <summary>
        /// This method inserts a new order into the database with the fields values given by
        /// the passed OrderMessage object. 
        /// </summary>
        /// <param name="newOrder">The order to insert into the database.</param>
        /// <returns>True if insert was successful, else false.</returns>
        [OperationContract]
        bool PutOrder(OrderMessage newOrder);
    }
}

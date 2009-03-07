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
        /// <param name="orderNumber">Identifier of the order to remove.</param>
        /// <returns>True if the order was removed, else false.</returns>
        [OperationContract]
        bool DeleteOrder(int orderNumber);

        /// <summary>
        /// Dummy method to display use of composite types. This will be removed.
        /// </summary>
        /// <param name="composite">input values</param>
        /// <returns>modified input with suffix added</returns>
        [Obsolete("Example code, will be removed")]
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
    }

    /// <summary>
    /// Composite type example. Will be removed.
    /// </summary>
    [Obsolete("Example code, will be removed")]
    [DataContract]
    public class CompositeType
    {
        /// <summary>
        /// Some private boolean example value.
        /// </summary>
        private bool boolValue = true;

        /// <summary>
        /// Some private string value for the example.
        /// </summary>
        private string stringValue = "Hello ";

        /// <summary>
        /// Gets or sets a value indicating whether the private attribute boolValue is set.
        /// </summary>
        [DataMember]
        public bool BoolValue
        {
            get { return this.boolValue; }
            set { this.boolValue = value; }
        }

        /// <summary>
        /// Gets or sets the private attribute stringValue
        /// </summary>
        [DataMember]
        public string StringValue
        {
            get { return this.stringValue; }
            set { this.stringValue = value; }
        }
    }
}

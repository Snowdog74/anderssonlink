//-----------------------------------------------------------------------
// <copyright file="OrderService.cs" company="System Andersson AB">
//     Copyright (c) System Andersson AB 2009. All rights reserved.
// </copyright>
// <author>Karl Bengtsson</author>
// <summary>Implementation of the IOrderService WCF service.</summary>
//-----------------------------------------------------------------------

namespace AnderssonLink
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Security.Permissions;
    using System.ServiceModel;
    using System.Text;
    using System.Threading;

    /// <summary>
    /// Implementation of the IOrderService interface. The methods in this class, which are used for
    /// manipulating orders in the database, are published via a WCF service.
    /// </summary>
    public class OrderService : IOrderService
    {
        /// <summary>
        /// This method returns all manufacture orders in the system for the user in question.
        /// The orders are not purged from the system upon retrieval.
        /// </summary>
        /// <returns>A dataset containing the orders. This should be changed to a custom class defined
        /// elsewhere so that we ues a consistent schema.</returns>
        [PrincipalPermission(SecurityAction.Demand, Role = "Subscribers")]
        public DataSet GetOrders()
        {
            // Logga begäran
            // Läs användarens ID
            // Fråga SQL-databasen
            // Transformera resultaten till dataset
            // Returnera
            string username = Thread.CurrentPrincipal.Identity.Name;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("Hello world table");
            DataColumn dc = new DataColumn("Hello world column", Type.GetType("System.String"));
            dt.Columns.Add(dc);
            ds.Tables.Add(dt);
            DataRow dr = ds.Tables[0].NewRow();
            dr[dc] = "hello world column content";
            ds.Tables[0].Rows.Add(dr);
            return ds;
        }

        /// <summary>
        /// Purges a given order from the database. Run this after retrieving the order.
        /// </summary>
        /// <param name="orderNumber">Identifier of the order to remove.</param>
        /// <returns>True if the order was removed, else false.</returns>
        [PrincipalPermission(SecurityAction.Demand, Role = "Subscribers")]
        public bool DeleteOrder(int orderNumber)
        {
            // Logga begäran
            // Läs användarens ID
            // Generera SQL-query
            // Exekvera SQL-query
            // Tolka resultat
            // Returnera resultat
            return true;
        }

        /// <summary>
        /// Dummy method to display use of composite types. This will be removed.
        /// </summary>
        /// <param name="composite">input values</param>
        /// <returns>modified input with suffix added</returns>
        [Obsolete("Example code, will be removed")]
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }

            return composite;
        }
    }
}

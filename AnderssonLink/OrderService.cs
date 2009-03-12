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
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
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
            // TODO: Wrappa alltihopa med try/catch och fixa ett FaultContract

            // TODO: Logga begäran

            // Läs användarens ID
            string userName = Thread.CurrentPrincipal.Identity.Name.Split('\\')[1];

            // Instantiera dataklasser
            SqlConnection databaseConnection = new SqlConnection("Server=localhost;database=AnderssonLink;Integrated Security=True");
            SqlParameter userNameParam = new SqlParameter("@userNameParam", SqlDbType.NVarChar, 50);
            userNameParam.Value = userName;
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM ORDERS WHERE Recipient = @userNameParam", databaseConnection);
            selectCommand.Parameters.Add(userNameParam);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
            DataSet orderDs = new DataSet();

            // Öppna databasen och hämta data
            databaseConnection.Open();
            dataAdapter.Fill(orderDs);

            // TODO: Logga lyckad databasåtkomst

            // Returnera dataset
            return orderDs;
        }

        /// <summary>
        /// Purges a given order from the database. Run this after retrieving the order.
        /// </summary>
        /// <param name="orderNumber">Identifier of the order to remove.</param>
        /// <returns>True if the order was removed, else false.</returns>
        [PrincipalPermission(SecurityAction.Demand, Role = "Subscribers")]
        public bool DeleteOrder(int orderNumber)
        {
            // TODO: Wrappa alltihopa med try/catch och fixa ett FaultContract
            // TODO: Logga begäran
            
            // Läs användarens ID
            string userName = Thread.CurrentPrincipal.Identity.Name.Split('\\')[1];

            // Generera SQL-query
            SqlConnection databaseConnection = new SqlConnection("Server=localhost;database=AnderssonLink;Integrated Security=True");
            SqlCommand deleteCommand = new SqlCommand("dbo.DeleteOrder", databaseConnection);
            deleteCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter orderId = new SqlParameter("@OrderId", DbType.Int32);
            orderId.Value = orderNumber;
            SqlParameter recipientParameter = new SqlParameter("@Recipient", DbType.String);
            recipientParameter.Value = userName;
            SqlParameter returnValue = new SqlParameter("@Return_Value", DbType.Boolean);
            returnValue.Direction = ParameterDirection.ReturnValue;
            deleteCommand.Parameters.Add(orderId);
            deleteCommand.Parameters.Add(returnValue);
            deleteCommand.Parameters.Add(recipientParameter);

            // TODO: Logga anrop till databas

            // Exekvera SQL-query
            databaseConnection.Open();
            deleteCommand.ExecuteNonQuery();

            // TODO: Logga success/failure

            // Tolka resultat
            int returnValueFromDB = int.Parse(returnValue.Value.ToString());

            // Returnera resultat
            if (returnValueFromDB == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
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
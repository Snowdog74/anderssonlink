//-----------------------------------------------------------------------
// <copyright file="OrderService.cs" company="System Andersson AB">
//     Copyright (c) System Andersson AB 2009. All rights reserved.
// </copyright>
// <author>Karl Bengtsson</author>
// <summary>Implementation of the IOrderService WCF service.</summary>
//-----------------------------------------------------------------------

namespace AnderssonLink.MessageDatabase.AccessServices.OrderService
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
    using BitFactory.Logging;

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
        /// <returns>An array of OrderMessages.</returns>
        [PrincipalPermission(SecurityAction.Demand, Role = "Subscribers")]
        public OrderMessage[] GetOrders()
        {
            Logger eventLog = new EventLogLogger();

            try
            {
                // Läs användarens ID
                string userName = Thread.CurrentPrincipal.Identity.Name.Split('\\')[1];

                // Logga begäran
                eventLog.LogInfo(String.Format("User: {0} is executing GetOrders()", userName));

                // Instantiera dataklasser
                SqlConnection databaseConnection = new SqlConnection("Server=localhost;database=AnderssonLink;Integrated Security=True");
                SqlParameter userNameParam = new SqlParameter("@userNameParam", SqlDbType.NVarChar, 50);
                userNameParam.Value = userName;
                SqlCommand selectCommand = new SqlCommand("SELECT * FROM ORDERS WHERE Recipient = @userNameParam", databaseConnection);
                selectCommand.Parameters.Add(userNameParam);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
                DataSet orderMessagesDataSet = new DataSet();

                // Logga anrop till databas
                eventLog.LogInfo(String.Format("Database call {0} is about to be executed.", selectCommand));

                // Öppna databasen och hämta data
                databaseConnection.Open();
                dataAdapter.Fill(orderMessagesDataSet);
                
                // Koppla ifrån databasen
                databaseConnection.Close();

                // Logga databasstängning
                eventLog.LogInfo(String.Format("Database connection has been closed."));

                // Read out all objects from database
                List<OrderMessage> orderMessages = new List<OrderMessage>();
                foreach (DataRow order in orderMessagesDataSet.Tables[0].Rows)
                {
                    orderMessages.Add(new OrderMessage(order));
                }

                // Returnera data
                return orderMessages.ToArray();
            }
            catch (Exception ex)
            {
                // Logga felet
                eventLog.LogError(String.Format("GetOrders() failed. Error message: {0}", ex.Message));

                return null;
            }
        }

        /// <summary>
        /// Purges a given order from the database. Run this after retrieving the order.
        /// </summary>
        /// <param name="orderId">Identifier of the order to remove.</param>
        /// <returns>True if the order was removed, else false.</returns>
        [PrincipalPermission(SecurityAction.Demand, Role = "Subscribers")]
        public bool DeleteOrder(int orderId)
        {
            Logger eventLog = new EventLogLogger();

            try
            {
                // Läs användarens ID
                string userName = Thread.CurrentPrincipal.Identity.Name.Split('\\')[1];

                // Logga begäran
                eventLog.LogInfo(String.Format("User: {0} is executing DeleteOrder({1})", userName, orderId));

                // Generera SQL-query
                SqlConnection databaseConnection = new SqlConnection("Server=localhost;database=AnderssonLink;Integrated Security=True");
                SqlCommand deleteCommand = new SqlCommand("dbo.DeleteOrder", databaseConnection);
                deleteCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter orderIdParameter = new SqlParameter("@OrderId", DbType.Int32);
                orderIdParameter.Value = orderId;
                SqlParameter recipientParameter = new SqlParameter("@Recipient", DbType.String);
                recipientParameter.Value = userName;
                SqlParameter returnValueParameter = new SqlParameter("@Return_Value", DbType.Boolean);
                returnValueParameter.Direction = ParameterDirection.ReturnValue;
                deleteCommand.Parameters.Add(orderIdParameter);
                deleteCommand.Parameters.Add(recipientParameter);
                deleteCommand.Parameters.Add(returnValueParameter);

                // Logga anrop till databas
                eventLog.LogInfo(String.Format("Database call {0} is about to be executed.", deleteCommand));

                // Exekvera SQL-query
                databaseConnection.Open();
                deleteCommand.ExecuteNonQuery();

                // Koppla ifrån databasen
                databaseConnection.Close();

                // Logga databasstängning
                eventLog.LogInfo(String.Format("Database connection has been closed."));

                // Hämta returkod / felkod
                int returnCode = (int)returnValueParameter.Value;

                // Hantera felkod
                if (returnCode != 0)
                {
                    throw new Exception("Database call failed.");
                }
                else
                {
                    // Logga success
                    eventLog.LogInfo(String.Format("DeleteOrder() successfully executed by user {0}", userName));

                    // Allt fungerade
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Logga felet
                eventLog.LogError(String.Format("DeleteOrder() failed. Error message: {0}", ex.Message));
                return false;
            }
        }

        /// <summary>
        /// This method inserts a new order into the database with the fields values given by
        /// the passed OrderMessage object. 
        /// The method requires that the user executing it be member of the role specificed in the
        /// annotation header.
        /// </summary>
        /// <param name="newOrder">The order to insert into the database.</param>
        /// <returns>True if insert was successful, else false.</returns>
        [PrincipalPermission(SecurityAction.Demand, Role = "Subscribers")]
        public bool PutOrder(OrderMessage newOrder)
        {
            Logger eventLog = new EventLogLogger();
            try
            {
                // Läs användarens ID
                string userName = Thread.CurrentPrincipal.Identity.Name.Split('\\')[1];

                // Logga begäran
                eventLog.LogInfo(String.Format("User: {0} is executing PutOrder()", userName));

                // Logga objektet (diagnostiskt)
                eventLog.LogInfo(String.Format("newOrder object: {0}", newOrder.ToString()));

                // Instantiera databasklasser och kommandon
                SqlConnection databaseConnection = new SqlConnection("Server=localhost;database=AnderssonLink;Integrated Security=True");
                SqlCommand insertCommand = new SqlCommand("dbo.InsertOrder", databaseConnection);
                insertCommand.CommandType = CommandType.StoredProcedure;

                // Sätt alla parametrar
                SqlParameter senderParameter = new SqlParameter("@Sender", DbType.String);
                senderParameter.Value = newOrder.Sender;
                SqlParameter recipientParameter = new SqlParameter("@Recipient", DbType.String);
                recipientParameter.Value = newOrder.Recipient;
                SqlParameter itemNumberParameter = new SqlParameter("@ItemNumber", DbType.String);
                itemNumberParameter.Value = newOrder.ItemNumber;
                SqlParameter itemDescriptionParameter = new SqlParameter("@ItemDescription", DbType.String);
                itemDescriptionParameter.Value = newOrder.ItemDescription;
                SqlParameter orderDateParameter = new SqlParameter("@OrderDate", DbType.Date);
                orderDateParameter.Value = newOrder.OrderDate;
                SqlParameter deliveryDateParameter = new SqlParameter("@DeliveryDate", DbType.Date);
                deliveryDateParameter.Value = newOrder.DeliveryDate;
                SqlParameter quantityParameter = new SqlParameter("@Quantity", DbType.Int32);
                quantityParameter.Value = newOrder.Quantity;
                SqlParameter priceParameter = new SqlParameter("@Price", DbType.Int32);
                priceParameter.Value = newOrder.Price;
                SqlParameter currencyParameter = new SqlParameter("@Currency", DbType.StringFixedLength);
                currencyParameter.Value = newOrder.Currency;
                SqlParameter textParameter = new SqlParameter("@Text", DbType.String);
                textParameter.Value = newOrder.Text;
                SqlParameter returnValueParameter = new SqlParameter("@Return_Value", DbType.Boolean);
                returnValueParameter.Direction = ParameterDirection.ReturnValue;

                // Lägg till parametrarna till kommandot
                insertCommand.Parameters.Add(senderParameter);
                insertCommand.Parameters.Add(recipientParameter);
                insertCommand.Parameters.Add(itemNumberParameter);
                insertCommand.Parameters.Add(itemDescriptionParameter);
                insertCommand.Parameters.Add(orderDateParameter);
                insertCommand.Parameters.Add(deliveryDateParameter);
                insertCommand.Parameters.Add(quantityParameter);
                insertCommand.Parameters.Add(priceParameter);
                insertCommand.Parameters.Add(currencyParameter);
                insertCommand.Parameters.Add(textParameter);
                insertCommand.Parameters.Add(returnValueParameter);

                // Logga anrop till databas
                eventLog.LogInfo(String.Format("Database call \"{0}\" is about to be executed.", insertCommand.CommandText));

                // Exekvera SQL-query
                databaseConnection.Open();
                insertCommand.ExecuteNonQuery();

                // Koppla ifrån databasen
                databaseConnection.Close();

                // Logga databasstängning
                eventLog.LogInfo(String.Format("Database connection has been closed."));

                // Hämta returkod / felkod
                int returnCode = (int)returnValueParameter.Value;

                // Hantera felkod
                if (returnCode != 0)
                {
                    throw new Exception("Database call failed.");
                }
                else
                {
                    // Logga success
                    eventLog.LogInfo(String.Format("PutOrder() successfully executed by user {0}", userName));
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Logga fel
                eventLog.LogError(String.Format("PutOrder() failed. Error message: {0}", ex.Message));
                return false;
            }
        }
    }
}
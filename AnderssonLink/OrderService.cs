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

            // Koppla ifrån databasen
            databaseConnection.Close();

            // TODO: Logga lyckad databasåtkomst

            // Returnera dataset
            return orderDs;
        }

        /// <summary>
        /// Purges a given order from the database. Run this after retrieving the order.
        /// </summary>
        /// <param name="orderId">Identifier of the order to remove.</param>
        /// <returns>True if the order was removed, else false.</returns>
        [PrincipalPermission(SecurityAction.Demand, Role = "Subscribers")]
        public bool DeleteOrder(int orderId)
        {
            // TODO: Wrappa alltihopa med try/catch och fixa ett FaultContract
            // TODO: Logga begäran
            
            // Läs användarens ID
            string userName = Thread.CurrentPrincipal.Identity.Name.Split('\\')[1];

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

            // TODO: Logga anrop till databas

            // Exekvera SQL-query
            databaseConnection.Open();
            deleteCommand.ExecuteNonQuery();

            // Koppla ifrån databasen
            databaseConnection.Close();

            // TODO: Logga success/failure

            // Hämta returkod / felkod
            int returnCode = (int)returnValueParameter.Value;

            // Hantera felkod
            if (returnCode != 0)
            {
                // TODO: Logga success/failure
                return false;
            }
            else
            {
                // Allt fungerade!
                return true;
            }
        }

        /// <summary>
        /// This method inserts a new order into the database with the fields values given by
        /// the method parameters. Each order is for exactly one product (at a given quantity).
        /// If the customer wishes to order multiple products, these must be input one at a time.
        /// Orders thus have more in common with the concept "production order" rather than
        /// "purchase order".
        /// The method requires that the user executing it be member of the role specificed in the
        /// annotation header.
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
        [PrincipalPermission(SecurityAction.Demand, Role = "Subscribers")]
        public bool InsertOrder(
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
            string recipient)
        {
            // TODO: Wrappa alltihopa med try/catch och fixa ett FaultContract

            // TODO: logga begäran

            // Instantiera databasklasser och kommandon
            SqlConnection databaseConnection = new SqlConnection("Server=localhost;database=AnderssonLink;Integrated Security=True");
            SqlCommand insertCommand = new SqlCommand("dbo.InsertOrder", databaseConnection);
            insertCommand.CommandType = CommandType.StoredProcedure;

            // Sätt alla parametrar
            SqlParameter articleNoParameter = new SqlParameter("@ArticleNo", DbType.Int32);
            articleNoParameter.Value = articleNo;
            SqlParameter descriptionParameter = new SqlParameter("@Description", DbType.String);
            descriptionParameter.Value = description;
            SqlParameter orderDateParameter = new SqlParameter("@OrderDate", DbType.Date);
            orderDateParameter.Value = orderDate;
            SqlParameter deliveryDateParameter = new SqlParameter("@DeliveryDate", DbType.Date);
            deliveryDateParameter.Value = deliveryDate;
            SqlParameter quantityParameter = new SqlParameter("@Quantity", DbType.Int32);
            quantityParameter.Value = quantity;
            SqlParameter piecePriceParameter = new SqlParameter("@PiecePrice", DbType.Int32);
            piecePriceParameter.Value = piecePrice;
            SqlParameter customerParameter = new SqlParameter("@Customer", DbType.String);
            customerParameter.Value = customer;
            SqlParameter customerNoParameter = new SqlParameter("@CustomerNo", DbType.Int32);
            customerNoParameter.Value = customerNo;
            SqlParameter customerOrderNoParameter = new SqlParameter("@CustomerOrderNo", DbType.Int32);
            customerOrderNoParameter.Value = customerOrderNo;
            SqlParameter infoParameter = new SqlParameter("@Info", DbType.String);
            infoParameter.Value = info;
            SqlParameter currencyParameter = new SqlParameter("@Currency", DbType.StringFixedLength);
            currencyParameter.Value = currency;
            SqlParameter recipientParameter = new SqlParameter("@Recipient", DbType.String);
            recipientParameter.Value = recipient;
            SqlParameter returnValueParameter = new SqlParameter("@Return_Value", DbType.Boolean);
            returnValueParameter.Direction = ParameterDirection.ReturnValue;

            // Lägg till parametrarna till kommandot
            insertCommand.Parameters.Add(articleNoParameter);
            insertCommand.Parameters.Add(descriptionParameter);
            insertCommand.Parameters.Add(orderDateParameter);
            insertCommand.Parameters.Add(deliveryDateParameter);
            insertCommand.Parameters.Add(quantityParameter);
            insertCommand.Parameters.Add(piecePriceParameter);
            insertCommand.Parameters.Add(customerParameter);
            insertCommand.Parameters.Add(customerNoParameter);
            insertCommand.Parameters.Add(customerOrderNoParameter);
            insertCommand.Parameters.Add(infoParameter);
            insertCommand.Parameters.Add(currencyParameter);
            insertCommand.Parameters.Add(recipientParameter);
            insertCommand.Parameters.Add(returnValueParameter);

            // TODO: Logga anrop till databas

            // Exekvera SQL-query
            databaseConnection.Open();
            insertCommand.ExecuteNonQuery();

            // Koppla ifrån databasen
            databaseConnection.Close();

            // Hämta returkod / felkod
            int returnCode = (int)returnValueParameter.Value;

            // Hantera felkod
            if (returnCode != 0)
            {
                // TODO: Logga success/failure
                return false;
            }
            else
            {
                // Allt fungerade!
                return true;
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
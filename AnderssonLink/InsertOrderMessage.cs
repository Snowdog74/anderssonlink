using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace AnderssonLink
{
    [DataContract]
    public class InsertOrderMessage
    {
        public InsertOrderMessage()
        {
            customer = "Karl";
        }

        [DataMember]
        public int articleNo;
        
        [DataMember]
        public string description;
        
        [DataMember]
        public DateTime orderDate;
        
        [DataMember]
        public DateTime deliveryDate;
        
        [DataMember] 
        public int quantity;
        [DataMember] 
        public int piecePrice;
        [DataMember]
        public string customer;
        [DataMember]
        public int customerNo;
        [DataMember]
        public int customerOrderNo;
        [DataMember]
        public string info;
        [DataMember]
        public string currency;
        [DataMember]
        public string recipient;

    }
}

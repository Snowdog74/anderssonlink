namespace ORDERS_Message {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ArrayOfOrderMessage", @"OrderMessage"})]
    public sealed class OrderService_07_AnderssonLink_MessageDatabase_AccessServices_OrderService : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""http://schemas.datacontract.org/2004/07/AnderssonLink.MessageDatabase.AccessServices.OrderService"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/AnderssonLink.MessageDatabase.AccessServices.OrderService"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:complexType name=""ArrayOfOrderMessage"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OrderMessage"" nillable=""true"" type=""tns:OrderMessage"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfOrderMessage"" nillable=""true"" type=""tns:ArrayOfOrderMessage"" />
  <xs:complexType name=""OrderMessage"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Currency"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""DeliveryDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""Id"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""ItemDescription"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ItemNumber"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""OrderDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""Price"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""Quantity"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""Recipient"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Sender"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Text"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""OrderMessage"" nillable=""true"" type=""tns:OrderMessage"" />
</xs:schema>";
        
        public OrderService_07_AnderssonLink_MessageDatabase_AccessServices_OrderService() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "ArrayOfOrderMessage";
                _RootElements[1] = "OrderMessage";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"http://schemas.datacontract.org/2004/07/AnderssonLink.MessageDatabase.AccessServices.OrderService",@"ArrayOfOrderMessage")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfOrderMessage"})]
        public sealed class ArrayOfOrderMessage : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfOrderMessage() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfOrderMessage";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://schemas.datacontract.org/2004/07/AnderssonLink.MessageDatabase.AccessServices.OrderService",@"OrderMessage")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrderMessage"})]
        public sealed class OrderMessage : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrderMessage() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrderMessage";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}

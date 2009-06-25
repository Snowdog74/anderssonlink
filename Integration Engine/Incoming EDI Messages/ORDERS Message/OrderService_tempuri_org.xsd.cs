namespace ORDERS_Message {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"GetOrders", @"GetOrdersResponse", @"DeleteOrder", @"DeleteOrderResponse", @"PutOrder", @"PutOrderResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ORDERS_Message.OrderService_07_AnderssonLink_MessageDatabase_AccessServices_OrderService", typeof(ORDERS_Message.OrderService_07_AnderssonLink_MessageDatabase_AccessServices_OrderService))]
    public sealed class OrderService_tempuri_org : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""http://tempuri.org/"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://tempuri.org/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""ORDERS_Message.OrderService_07_AnderssonLink_MessageDatabase_AccessServices_OrderService"" namespace=""http://schemas.datacontract.org/2004/07/AnderssonLink.MessageDatabase.AccessServices.OrderService"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://schemas.datacontract.org/2004/07/AnderssonLink.MessageDatabase.AccessServices.OrderService"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""GetOrders"">
    <xs:complexType>
      <xs:sequence />
    </xs:complexType>
  </xs:element>
  <xs:element name=""GetOrdersResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://schemas.datacontract.org/2004/07/AnderssonLink.MessageDatabase.AccessServices.OrderService"" minOccurs=""0"" name=""GetOrdersResult"" nillable=""true"" type=""q1:ArrayOfOrderMessage"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DeleteOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""orderId"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DeleteOrderResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""DeleteOrderResult"" type=""xs:boolean"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PutOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q2=""http://schemas.datacontract.org/2004/07/AnderssonLink.MessageDatabase.AccessServices.OrderService"" minOccurs=""0"" name=""newOrder"" nillable=""true"" type=""q2:OrderMessage"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PutOrderResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""PutOrderResult"" type=""xs:boolean"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public OrderService_tempuri_org() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [6];
                _RootElements[0] = "GetOrders";
                _RootElements[1] = "GetOrdersResponse";
                _RootElements[2] = "DeleteOrder";
                _RootElements[3] = "DeleteOrderResponse";
                _RootElements[4] = "PutOrder";
                _RootElements[5] = "PutOrderResponse";
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
        
        [Schema(@"http://tempuri.org/",@"GetOrders")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GetOrders"})]
        public sealed class GetOrders : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GetOrders() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GetOrders";
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
        
        [Schema(@"http://tempuri.org/",@"GetOrdersResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GetOrdersResponse"})]
        public sealed class GetOrdersResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GetOrdersResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GetOrdersResponse";
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
        
        [Schema(@"http://tempuri.org/",@"DeleteOrder")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DeleteOrder"})]
        public sealed class DeleteOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DeleteOrder() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DeleteOrder";
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
        
        [Schema(@"http://tempuri.org/",@"DeleteOrderResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DeleteOrderResponse"})]
        public sealed class DeleteOrderResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DeleteOrderResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DeleteOrderResponse";
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
        
        [Schema(@"http://tempuri.org/",@"PutOrder")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PutOrder"})]
        public sealed class PutOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PutOrder() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PutOrder";
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
        
        [Schema(@"http://tempuri.org/",@"PutOrderResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PutOrderResponse"})]
        public sealed class PutOrderResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PutOrderResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PutOrderResponse";
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

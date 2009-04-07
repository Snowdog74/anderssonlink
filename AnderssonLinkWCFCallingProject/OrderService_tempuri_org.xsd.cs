namespace AnderssonLinkWCFCallingProject {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"GetOrders", @"GetOrdersResponse", @"DeleteOrder", @"DeleteOrderResponse", @"InsertOrder", @"InsertOrderResponse", @"GetDataUsingDataContract", @"GetDataUsingDataContractResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AnderssonLinkWCFCallingProject.OrderService_schemas_datacontract_org_2004_07_AnderssonLink", typeof(AnderssonLinkWCFCallingProject.OrderService_schemas_datacontract_org_2004_07_AnderssonLink))]
    public sealed class OrderService_tempuri_org : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""http://tempuri.org/"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://tempuri.org/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""AnderssonLinkWCFCallingProject.OrderService_schemas_datacontract_org_2004_07_AnderssonLink"" namespace=""http://schemas.datacontract.org/2004/07/AnderssonLink"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://schemas.datacontract.org/2004/07/AnderssonLink"" />
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
        <xs:element minOccurs=""0"" name=""GetOrdersResult"" nillable=""true"">
          <xs:complexType>
            <xs:annotation>
              <xs:appinfo>
                <ActualType Name=""DataSet"" Namespace=""http://schemas.datacontract.org/2004/07/System.Data"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"" />
              </xs:appinfo>
            </xs:annotation>
            <xs:sequence>
              <xs:any />
              <xs:any />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
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
  <xs:element name=""InsertOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""articleNo"" type=""xs:int"" />
        <xs:element minOccurs=""0"" name=""description"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""orderDate"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" name=""deliveryDate"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" name=""quantity"" type=""xs:int"" />
        <xs:element minOccurs=""0"" name=""piecePrice"" type=""xs:int"" />
        <xs:element minOccurs=""0"" name=""customer"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""customerNo"" type=""xs:int"" />
        <xs:element minOccurs=""0"" name=""customerOrderNo"" type=""xs:int"" />
        <xs:element minOccurs=""0"" name=""info"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""currency"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""recipient"" nillable=""true"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InsertOrderResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""InsertOrderResult"" type=""xs:boolean"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GetDataUsingDataContract"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://schemas.datacontract.org/2004/07/AnderssonLink"" minOccurs=""0"" name=""composite"" nillable=""true"" type=""q1:CompositeType"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GetDataUsingDataContractResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q2=""http://schemas.datacontract.org/2004/07/AnderssonLink"" minOccurs=""0"" name=""GetDataUsingDataContractResult"" nillable=""true"" type=""q2:CompositeType"" />
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
                string[] _RootElements = new string [8];
                _RootElements[0] = "GetOrders";
                _RootElements[1] = "GetOrdersResponse";
                _RootElements[2] = "DeleteOrder";
                _RootElements[3] = "DeleteOrderResponse";
                _RootElements[4] = "InsertOrder";
                _RootElements[5] = "InsertOrderResponse";
                _RootElements[6] = "GetDataUsingDataContract";
                _RootElements[7] = "GetDataUsingDataContractResponse";
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
        
        [Schema(@"http://tempuri.org/",@"InsertOrder")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InsertOrder"})]
        public sealed class InsertOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InsertOrder() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InsertOrder";
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
        
        [Schema(@"http://tempuri.org/",@"InsertOrderResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InsertOrderResponse"})]
        public sealed class InsertOrderResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InsertOrderResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InsertOrderResponse";
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
        
        [Schema(@"http://tempuri.org/",@"GetDataUsingDataContract")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GetDataUsingDataContract"})]
        public sealed class GetDataUsingDataContract : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GetDataUsingDataContract() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GetDataUsingDataContract";
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
        
        [Schema(@"http://tempuri.org/",@"GetDataUsingDataContractResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GetDataUsingDataContractResponse"})]
        public sealed class GetDataUsingDataContractResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GetDataUsingDataContractResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GetDataUsingDataContractResponse";
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

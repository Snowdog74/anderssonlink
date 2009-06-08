namespace AnderssonLinkWCFCallingProject {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.datacontract.org/2004/07/AnderssonLink",@"InsertOrderMessage")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"InsertOrderMessage"})]
    public sealed class OrderService_schemas_datacontract_org_2004_07_AnderssonLink : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""http://schemas.datacontract.org/2004/07/AnderssonLink"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/AnderssonLink"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:complexType name=""InsertOrderMessage"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""articleNo"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""currency"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""customer"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""customerNo"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""customerOrderNo"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""deliveryDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""description"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""info"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""orderDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""piecePrice"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""quantity"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""recipient"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""InsertOrderMessage"" nillable=""true"" type=""tns:InsertOrderMessage"" />
</xs:schema>";
        
        public OrderService_schemas_datacontract_org_2004_07_AnderssonLink() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "InsertOrderMessage";
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

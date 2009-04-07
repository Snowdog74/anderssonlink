namespace AnderssonLinkWCFCallingProject {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.datacontract.org/2004/07/AnderssonLink",@"CompositeType")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CompositeType"})]
    public sealed class OrderService_schemas_datacontract_org_2004_07_AnderssonLink : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""http://schemas.datacontract.org/2004/07/AnderssonLink"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/AnderssonLink"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:complexType name=""CompositeType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""BoolValue"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""StringValue"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""CompositeType"" nillable=""true"" type=""tns:CompositeType"" />
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
                _RootElements[0] = "CompositeType";
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

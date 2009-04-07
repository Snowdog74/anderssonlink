namespace AnderssonLinkWCFCallingProject {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"DataSet")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"DataSet"})]
    public sealed class OrderService : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""DataSet"" nillable=""true"">
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
</xs:schema>";
        
        public OrderService() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "DataSet";
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

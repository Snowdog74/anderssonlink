namespace INVOIC_Message {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://INVOIC_Message.InvoiceResponse",@"InvoiceResult")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(INVOIC_Message.PropertySchema.Result), XPath = @"/*[local-name()='InvoiceResult' and namespace-uri()='http://INVOIC_Message.InvoiceResponse']/*[local-name()='Result' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Result", XPath = @"/*[local-name()='InvoiceResult' and namespace-uri()='http://INVOIC_Message.InvoiceResponse']/*[local-name()='Result' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"InvoiceResult"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"INVOIC_Message.PropertySchema.PropertySchema", typeof(INVOIC_Message.PropertySchema.PropertySchema))]
    public sealed class InvoiceResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns0=""https://INVOIC_Message.PropertySchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://INVOIC_Message.InvoiceResponse"" targetNamespace=""http://INVOIC_Message.InvoiceResponse"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://INVOIC_Message.PropertySchema"" location=""INVOIC_Message.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""InvoiceResult"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:Result"" xpath=""/*[local-name()='InvoiceResult' and namespace-uri()='http://INVOIC_Message.InvoiceResponse']/*[local-name()='Result' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='InvoiceResult' and namespace-uri()='http://INVOIC_Message.InvoiceResponse']/*[local-name()='Result' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Result"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public InvoiceResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "InvoiceResult";
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

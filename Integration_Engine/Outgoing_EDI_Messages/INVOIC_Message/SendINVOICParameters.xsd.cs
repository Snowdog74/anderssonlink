namespace INVOIC_Message {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://INVOIC_Message.SendINVOICParameters",@"INVOICMessage")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(INVOIC_Message.PropertySchema.Sender), XPath = @"/*[local-name()='INVOICMessage' and namespace-uri()='http://INVOIC_Message.SendINVOICParameters']/*[local-name()='Sender' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(INVOIC_Message.PropertySchema.Recipient), XPath = @"/*[local-name()='INVOICMessage' and namespace-uri()='http://INVOIC_Message.SendINVOICParameters']/*[local-name()='Recipient' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Sender", XPath = @"/*[local-name()='INVOICMessage' and namespace-uri()='http://INVOIC_Message.SendINVOICParameters']/*[local-name()='Sender' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Recipient", XPath = @"/*[local-name()='INVOICMessage' and namespace-uri()='http://INVOIC_Message.SendINVOICParameters']/*[local-name()='Recipient' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"INVOICMessage"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"INVOIC_Message.PropertySchema.PropertySchema", typeof(INVOIC_Message.PropertySchema.PropertySchema))]
    public sealed class SendINVOICParameters : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns0=""https://INVOIC_Message.PropertySchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://INVOIC_Message.SendINVOICParameters"" targetNamespace=""http://INVOIC_Message.SendINVOICParameters"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://INVOIC_Message.PropertySchema"" location=""INVOIC_Message.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""INVOICMessage"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:Sender"" xpath=""/*[local-name()='INVOICMessage' and namespace-uri()='http://INVOIC_Message.SendINVOICParameters']/*[local-name()='Sender' and namespace-uri()='']"" />
          <b:property name=""ns0:Recipient"" xpath=""/*[local-name()='INVOICMessage' and namespace-uri()='http://INVOIC_Message.SendINVOICParameters']/*[local-name()='Recipient' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='INVOICMessage' and namespace-uri()='http://INVOIC_Message.SendINVOICParameters']/*[local-name()='Sender' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='INVOICMessage' and namespace-uri()='http://INVOIC_Message.SendINVOICParameters']/*[local-name()='Recipient' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Sender"" type=""xs:string"" />
        <xs:element name=""Recipient"" type=""xs:string"" />
        <xs:element name=""InvoiceNumber"" type=""xs:string"" />
        <xs:element name=""DueDate"" type=""xs:string"" />
        <xs:element name=""Reference"" type=""xs:string"" />
        <xs:element name=""Adress"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Street"" type=""xs:string"" />
              <xs:element name=""City"" type=""xs:string"" />
              <xs:element name=""Zipcode"" type=""xs:string"" />
              <xs:element name=""Country"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""ItemDescription"" type=""xs:string"" />
        <xs:element name=""Amount"" type=""xs:integer"" />
        <xs:element name=""Currency"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SendINVOICParameters() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "INVOICMessage";
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

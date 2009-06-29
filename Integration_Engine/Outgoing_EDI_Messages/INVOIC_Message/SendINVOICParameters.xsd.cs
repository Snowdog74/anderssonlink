namespace INVOIC_Message {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://INVOIC_Message.SendINVOICParameters",@"INVOICMessage")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"INVOICMessage"})]
    public sealed class SendINVOICParameters : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://INVOIC_Message.SendINVOICParameters"" targetNamespace=""http://INVOIC_Message.SendINVOICParameters"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""INVOICMessage"">
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

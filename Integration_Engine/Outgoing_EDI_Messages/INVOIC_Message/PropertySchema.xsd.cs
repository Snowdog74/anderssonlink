namespace INVOIC_Message.PropertySchema {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Property)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Property1", @"Result"})]
    public sealed class PropertySchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://INVOIC_Message.PropertySchema"" targetNamespace=""https://INVOIC_Message.PropertySchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Property1"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""920b5b39-8783-4c51-982c-a65ff61d2b23"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Result"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""1f97ba38-c429-41fe-a7ba-751a508f6ddb"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public PropertySchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "Property1";
                _RootElements[1] = "Result";
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
    
    [System.SerializableAttribute()]
    [PropertyType(@"Property1",@"https://INVOIC_Message.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"920b5b39-8783-4c51-982c-a65ff61d2b23")]
    public sealed class Property1 : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"Property1", @"https://INVOIC_Message.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [System.SerializableAttribute()]
    [PropertyType(@"Result",@"https://INVOIC_Message.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"1f97ba38-c429-41fe-a7ba-751a508f6ddb")]
    public sealed class Result : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"Result", @"https://INVOIC_Message.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
}

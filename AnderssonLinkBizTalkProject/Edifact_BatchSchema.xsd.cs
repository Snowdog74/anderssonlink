namespace AnderssonLinkBizTalkProject {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.microsoft.com/Edi/tet",@"EdifactInterchangeXml")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"EdifactInterchangeXml"})]
    public sealed class Edifact_BatchSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://schemas.microsoft.com/Edi/tet"" targetNamespace=""http://schemas.microsoft.com/Edi/tet"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <schemaEditorExtension:schemaInfo namespaceAlias=""btsedi"" extensionClass=""Microsoft.BizTalk.Edi.SchemaEditorExtension.EdiSchemaExtension"" standardName=""EDI"" xmlns:schemaEditorExtension=""http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions"" />
      <b:schemaInfo standard=""EDI"" root_reference=""EdifactInterchangeXml"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""EdifactInterchangeXml"" type=""xs:anyType"" />
</xs:schema>";
        
        public Edifact_BatchSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "EdifactInterchangeXml";
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

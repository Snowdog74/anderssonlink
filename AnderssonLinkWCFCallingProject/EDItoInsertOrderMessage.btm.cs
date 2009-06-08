namespace AnderssonLinkWCFCallingProject {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AnderssonLinkWCFCallingProject.EFACT_D93A_ORDERS", typeof(AnderssonLinkWCFCallingProject.EFACT_D93A_ORDERS))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AnderssonLinkWCFCallingProject.OrderService_schemas_datacontract_org_2004_07_AnderssonLink", typeof(AnderssonLinkWCFCallingProject.OrderService_schemas_datacontract_org_2004_07_AnderssonLink))]
    public sealed class EDItoInsertOrderMessage : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://schemas.datacontract.org/2004/07/AnderssonLink"" xmlns:s0=""http://schemas.microsoft.com/BizTalk/EDI/EDIFACT/2006"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:EFACT_D93A_ORDERS"" />
  </xsl:template>
  <xsl:template match=""/s0:EFACT_D93A_ORDERS"">
    <ns0:InsertOrderMessage>
      <ns0:quantity>
        <xsl:value-of select=""s0:SCCLoop1/s0:QTYLoop1/s0:QTY/s0:C186/C18602/text()"" />
      </ns0:quantity>
    </ns0:InsertOrderMessage>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"AnderssonLinkWCFCallingProject.EFACT_D93A_ORDERS";
        
        private const string _strTrgSchemasList0 = @"AnderssonLinkWCFCallingProject.OrderService_schemas_datacontract_org_2004_07_AnderssonLink";
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"AnderssonLinkWCFCallingProject.EFACT_D93A_ORDERS";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"AnderssonLinkWCFCallingProject.OrderService_schemas_datacontract_org_2004_07_AnderssonLink";
                return _TrgSchemas;
            }
        }
    }
}

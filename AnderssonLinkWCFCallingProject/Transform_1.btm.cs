namespace AnderssonLinkWCFCallingProject {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AnderssonLinkWCFCallingProject.EFACT_D93A_ORDERS", typeof(AnderssonLinkWCFCallingProject.EFACT_D93A_ORDERS))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AnderssonLinkWCFCallingProject.OrderService_tempuri_org+InsertOrderByObject", typeof(AnderssonLinkWCFCallingProject.OrderService_tempuri_org.InsertOrderByObject))]
    public sealed class Transform_1 : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns1=""http://schemas.datacontract.org/2004/07/AnderssonLink"" xmlns:s0=""http://schemas.microsoft.com/BizTalk/EDI/EDIFACT/2006"" xmlns:ns0=""http://tempuri.org/"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:EFACT_D93A_ORDERS"" />
  </xsl:template>
  <xsl:template match=""/s0:EFACT_D93A_ORDERS"">
    <ns0:InsertOrderByObject>
      <xsl:for-each select=""s0:SCCLoop1"">
        <xsl:for-each select=""s0:QTYLoop1"">
          <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDateTime()"" />
          <ns0:message>
            <ns1:articleNo>
              <xsl:value-of select=""s0:QTY/s0:C186/C18602/text()"" />
            </ns1:articleNo>
            <ns1:currency>
              <xsl:value-of select=""s0:QTY/s0:C186/C18602/text()"" />
            </ns1:currency>
            <ns1:customer>
              <xsl:value-of select=""s0:QTY/s0:C186/C18602/text()"" />
            </ns1:customer>
            <ns1:customerNo>
              <xsl:value-of select=""s0:QTY/s0:C186/C18602/text()"" />
            </ns1:customerNo>
            <ns1:customerOrderNo>
              <xsl:value-of select=""s0:QTY/s0:C186/C18602/text()"" />
            </ns1:customerOrderNo>
            <ns1:deliveryDate>
              <xsl:value-of select=""$var:v1"" />
            </ns1:deliveryDate>
            <ns1:description>
              <xsl:value-of select=""s0:QTY/s0:C186/C18602/text()"" />
            </ns1:description>
            <ns1:info>
              <xsl:value-of select=""s0:QTY/s0:C186/C18602/text()"" />
            </ns1:info>
            <ns1:orderDate>
              <xsl:value-of select=""$var:v1"" />
            </ns1:orderDate>
            <ns1:piecePrice>
              <xsl:value-of select=""s0:QTY/s0:C186/C18602/text()"" />
            </ns1:piecePrice>
            <ns1:quantity>
              <xsl:value-of select=""s0:QTY/s0:C186/C18602/text()"" />
            </ns1:quantity>
            <ns1:recipient>
              <xsl:value-of select=""s0:QTY/s0:C186/C18602/text()"" />
            </ns1:recipient>
          </ns0:message>
        </xsl:for-each>
      </xsl:for-each>
    </ns0:InsertOrderByObject>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"AnderssonLinkWCFCallingProject.EFACT_D93A_ORDERS";
        
        private const string _strTrgSchemasList0 = @"AnderssonLinkWCFCallingProject.OrderService_tempuri_org+InsertOrderByObject";
        
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
                _TrgSchemas[0] = @"AnderssonLinkWCFCallingProject.OrderService_tempuri_org+InsertOrderByObject";
                return _TrgSchemas;
            }
        }
    }
}

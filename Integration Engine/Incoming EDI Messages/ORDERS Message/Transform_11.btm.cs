namespace ORDERS_Message {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ORDERS_Message.EFACT_D93A_ORDERS", typeof(ORDERS_Message.EFACT_D93A_ORDERS))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ORDERS_Message.OrderService_tempuri_org+PutOrder", typeof(ORDERS_Message.OrderService_tempuri_org.PutOrder))]
    public sealed class Transform_1 : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://tempuri.org/"" xmlns:ns1=""http://schemas.datacontract.org/2004/07/AnderssonLink.MessageDatabase.AccessServices.OrderService"" xmlns:s0=""http://schemas.microsoft.com/BizTalk/EDI/EDIFACT/2006"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:EFACT_D93A_ORDERS"" />
  </xsl:template>
  <xsl:template match=""/s0:EFACT_D93A_ORDERS"">
    <ns0:PutOrder>
      <xsl:for-each select=""s0:LINLoop1"">
        <xsl:for-each select=""s0:MOA_5"">
          <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDateTime()"" />
          <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(string(../s0:IMD_2/s0:C273_2/C27304/text()) , &quot;:&quot; , string(../s0:IMD_2/s0:C273_2/C27305/text()))"" />
          <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(string(../s0:LIN/s0:C212/C21201/text()) , &quot;:&quot; , string(../s0:LIN/s0:C212/C21202/text()))"" />
          <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;TEST&quot;)"" />
          <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(string(../s0:FTX_5/FTX01/text()) , &quot;:&quot; , string(../s0:FTX_5/s0:C108_5/C10801/text()) , string(../s0:FTX_5/s0:C108_5/C10802/text()) , string(../s0:FTX_5/s0:C108_5/C10803/text()) , string(../s0:FTX_5/s0:C108_5/C10804/text()) , string(../s0:FTX_5/s0:C108_5/C10805/text()))"" />
          <ns0:newOrder>
            <xsl:if test=""s0:C516_5/C51603"">
              <ns1:Currency>
                <xsl:value-of select=""s0:C516_5/C51603/text()"" />
              </ns1:Currency>
            </xsl:if>
            <ns1:DeliveryDate>
              <xsl:value-of select=""$var:v1"" />
            </ns1:DeliveryDate>
            <ns1:ItemDescription>
              <xsl:value-of select=""$var:v2"" />
            </ns1:ItemDescription>
            <ns1:ItemNumber>
              <xsl:value-of select=""$var:v3"" />
            </ns1:ItemNumber>
            <ns1:OrderDate>
              <xsl:value-of select=""$var:v1"" />
            </ns1:OrderDate>
            <xsl:if test=""s0:C516_5/C51602"">
              <ns1:Price>
                <xsl:value-of select=""s0:C516_5/C51602/text()"" />
              </ns1:Price>
            </xsl:if>
            <ns1:Quantity>
              <xsl:value-of select=""../s0:QTY_3/s0:C186_3/C18602/text()"" />
            </ns1:Quantity>
            <ns1:Recipient>
              <xsl:value-of select=""$var:v4"" />
            </ns1:Recipient>
            <ns1:Sender>
              <xsl:value-of select=""$var:v4"" />
            </ns1:Sender>
            <ns1:Text>
              <xsl:value-of select=""$var:v5"" />
            </ns1:Text>
          </ns0:newOrder>
        </xsl:for-each>
      </xsl:for-each>
    </ns0:PutOrder>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public string StringConcat(string param0, string param1, string param2, string param3, string param4, string param5, string param6)
{
   return param0 + param1 + param2 + param3 + param4 + param5 + param6;
}


public string StringConcat(string param0)
{
   return param0;
}


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
        
        private const string _strSrcSchemasList0 = @"ORDERS_Message.EFACT_D93A_ORDERS";
        
        private const string _strTrgSchemasList0 = @"ORDERS_Message.OrderService_tempuri_org+PutOrder";
        
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
                _SrcSchemas[0] = @"ORDERS_Message.EFACT_D93A_ORDERS";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"ORDERS_Message.OrderService_tempuri_org+PutOrder";
                return _TrgSchemas;
            }
        }
    }
}

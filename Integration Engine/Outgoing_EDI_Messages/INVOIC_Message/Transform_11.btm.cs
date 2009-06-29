namespace INVOIC_Message {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"INVOIC_Message.SendINVOICParameters", typeof(INVOIC_Message.SendINVOICParameters))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"INVOIC_Message.EFACT_D93A_INVOIC", typeof(INVOIC_Message.EFACT_D93A_INVOIC))]
    public sealed class Transform_11 : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/BizTalk/EDI/EDIFACT/2006"" xmlns:s0=""http://INVOIC_Message.SendINVOICParameters"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:INVOICMessage"" />
  </xsl:template>
  <xsl:template match=""/s0:INVOICMessage"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;123456789&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;INVOIC&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;D&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;93A&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;UN&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(&quot;380&quot;)"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:StringConcat(&quot;13&quot;)"" />
    <xsl:variable name=""var:v8"" select=""userCSharp:StringConcat(&quot;2&quot;)"" />
    <xsl:variable name=""var:v9"" select=""userCSharp:StringConcat(&quot;IV&quot;)"" />
    <xsl:variable name=""var:v10"" select=""userCSharp:StringConcat(&quot;AA&quot;)"" />
    <xsl:variable name=""var:v11"" select=""userCSharp:StringConcat(&quot;S&quot;)"" />
    <xsl:variable name=""var:v12"" select=""userCSharp:StringConcat(&quot;9&quot;)"" />
    <ns0:EFACT_D93A_INVOIC>
      <UNH>
        <UNH1>
          <xsl:value-of select=""$var:v1"" />
        </UNH1>
        <UNH2>
          <UNH2.1>
            <xsl:value-of select=""$var:v2"" />
          </UNH2.1>
          <UNH2.2>
            <xsl:value-of select=""$var:v3"" />
          </UNH2.2>
          <UNH2.3>
            <xsl:value-of select=""$var:v4"" />
          </UNH2.3>
          <UNH2.4>
            <xsl:value-of select=""$var:v5"" />
          </UNH2.4>
        </UNH2>
      </UNH>
      <ns0:BGM>
        <ns0:C002>
          <C00201>
            <xsl:value-of select=""$var:v6"" />
          </C00201>
        </ns0:C002>
      </ns0:BGM>
      <ns0:DTM>
        <ns0:C507>
          <C50701>
            <xsl:value-of select=""$var:v7"" />
          </C50701>
          <C50702>
            <xsl:value-of select=""DueDate/text()"" />
          </C50702>
          <C50703>
            <xsl:value-of select=""$var:v8"" />
          </C50703>
        </ns0:C507>
      </ns0:DTM>
      <ns0:IMD>
        <ns0:C273>
          <C27304>
            <xsl:value-of select=""ItemDescription/text()"" />
          </C27304>
        </ns0:C273>
      </ns0:IMD>
      <ns0:RFFLoop1>
        <ns0:RFF>
          <ns0:C506>
            <C50601>
              <xsl:value-of select=""$var:v9"" />
            </C50601>
            <C50602>
              <xsl:value-of select=""InvoiceNumber/text()"" />
            </C50602>
          </ns0:C506>
        </ns0:RFF>
      </ns0:RFFLoop1>
      <ns0:NADLoop1>
        <ns0:NAD>
          <NAD01>
            <xsl:value-of select=""$var:v10"" />
          </NAD01>
          <ns0:C058>
            <C05801>
              <xsl:value-of select=""Reference/text()"" />
            </C05801>
          </ns0:C058>
          <ns0:C059>
            <C05901>
              <xsl:value-of select=""Adress/Street/text()"" />
            </C05901>
          </ns0:C059>
          <NAD06>
            <xsl:value-of select=""Adress/City/text()"" />
          </NAD06>
          <NAD08>
            <xsl:value-of select=""Adress/Zipcode/text()"" />
          </NAD08>
          <NAD09>
            <xsl:value-of select=""Adress/Country/text()"" />
          </NAD09>
        </ns0:NAD>
      </ns0:NADLoop1>
      <ns0:UNS>
        <UNS01>
          <xsl:value-of select=""$var:v11"" />
        </UNS01>
      </ns0:UNS>
      <ns0:MOALoop4>
        <ns0:MOA_10>
          <ns0:C516_10>
            <C51601>
              <xsl:value-of select=""$var:v12"" />
            </C51601>
            <C51602>
              <xsl:value-of select=""Amount/text()"" />
            </C51602>
            <C51603>
              <xsl:value-of select=""Currency/text()"" />
            </C51603>
          </ns0:C516_10>
        </ns0:MOA_10>
      </ns0:MOALoop4>
    </ns0:EFACT_D93A_INVOIC>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"INVOIC_Message.SendINVOICParameters";
        
        private const string _strTrgSchemasList0 = @"INVOIC_Message.EFACT_D93A_INVOIC";
        
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
                _SrcSchemas[0] = @"INVOIC_Message.SendINVOICParameters";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"INVOIC_Message.EFACT_D93A_INVOIC";
                return _TrgSchemas;
            }
        }
    }
}

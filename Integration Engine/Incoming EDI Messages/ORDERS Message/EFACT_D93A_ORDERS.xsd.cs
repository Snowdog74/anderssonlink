namespace ORDERS_Message {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.microsoft.com/BizTalk/EDI/EDIFACT/2006",@"EFACT_D93A_ORDERS")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"EFACT_D93A_ORDERS"})]
    public sealed class EFACT_D93A_ORDERS : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:btsedi=""http://schemas.microsoft.com/BizTalk/2005/EdiSchemaEditorExtension"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://schemas.microsoft.com/BizTalk/EDI/EDIFACT/2006"" targetNamespace=""http://schemas.microsoft.com/BizTalk/EDI/EDIFACT/2006"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <schemaEditorExtension:schemaInfo namespaceAlias=""btsedi"" extensionClass=""Microsoft.BizTalk.Edi.SchemaEditorExtension.EdiSchemaExtension"" standardName=""EDI"" xmlns:schemaEditorExtension=""http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions"" />
      <b:schemaInfo is_envelope=""no"" version=""1.0"" document_type=""ORDERS"" standard=""EDI"" standards_version=""D93A"" root_reference=""EFACT_D93A_ORDERS"" displayroot_reference=""EFACT_D93A_ORDERS"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" EdifactDependencyRule_Check=""No"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:annotation>
    <xs:documentation xml:lang=""en"">copyright © Microsoft Corporation. All rights reserved.</xs:documentation>
  </xs:annotation>
  <xs:annotation>
    <xs:documentation>Schema name: EFACT_d93a_ORDERS</xs:documentation>
  </xs:annotation>
  <xs:element name=""EFACT_D93A_ORDERS"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""postfix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PURCHASE ORDER MESSAGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""UNH"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo notes=""Message Header"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""UNH1"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Message Reference Number_0062"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:simpleType>
                  <xs:restriction base=""EDIFACT_AN"">
                    <xs:minLength value=""1"" />
                    <xs:maxLength value=""14"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""UNH2"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo notes=""Message Identifier"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""UNH2.1"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Message Type Identifier_0065"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""6"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element name=""UNH2.2"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Message Type Version Number_0052"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""3"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element name=""UNH2.3"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Message Type Release Number_0054"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""3"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element name=""UNH2.4"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Controlling Agency_0051"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""3"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""UNH2.5"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Association Assigned Code_0057"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""6"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""UNH2.6"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Code List Directory Version Number_0110"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""6"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""UNH2.7"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Message Type Sub-function Identification"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""6"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""UNH3"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Common Access Reference_0068"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:simpleType>
                  <xs:restriction base=""EDIFACT_AN"">
                    <xs:minLength value=""1"" />
                    <xs:maxLength value=""35"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""UNH4"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo notes=""Status of the Transfer"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""UNH4.1"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Sequence Message Transfer Number_0070"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_N"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""2"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""UNH4.2"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""First/Last Sequence Message Transfer Indication_0073"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_A"">
                          <xs:length value=""1"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""UNH5"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo notes=""Message Subset Identification"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""UNH5.1"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Message Subset Identification_0115"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""14"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""UNH5.2"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Message Subset Version Number_0116"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""3"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""UNH5.3"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Message Subset Release Number_0118"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""3"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""UNH5.4"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Controlling Agency, Coded_0051"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""3"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""UNH6"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo notes=""Message Implementation Guideline Identification"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""UNH6.1"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Message Implementation Guideline Identification_0121"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""14"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""UNH6.2"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Message Implementation Guideline Version Number_0122"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""3"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""UNH6.3"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Message Implementation Guideline Release Number_0124"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""3"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""UNH6.4"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Controlling Agency, Coded_0051"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""3"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""UNH7"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo notes=""Scenario Identification"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""UNH7.1"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Scenario Identification_0127"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""14"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""UNH7.2"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Scenario Version Number_0128"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""3"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""UNH7.3"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Scenario Release Number_0130"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""3"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""UNH7.4"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo notes=""Controlling Agency, Coded_0051"" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base=""EDIFACT_AN"">
                          <xs:minLength value=""1"" />
                          <xs:maxLength value=""3"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element ref=""BGM"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""BGM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""BEGINNING OF MESSAGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""35"" ref=""DTM"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""PAI"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PAI"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PAYMENT INSTRUCTIONS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""ALI"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""ALI"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ADDITIONAL INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""IMD"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""IMD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM DESCRIPTION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""FTX"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FTX"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FREE TEXT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""RFFLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""20"" ref=""NADLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for NAME AND ADDRESS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""TAXLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for DUTY/TAX/FEE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""CUXLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for CURRENCIES"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""PATLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PAYMENT TERMS BASIS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""TDTLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for DETAILS OF TRANSPORT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""TODLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for TERMS OF DELIVERY"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""PACLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PACKAGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""EQDLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for EQUIPMENT DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""SCCLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for SCHEDULING CONDITIONS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""25"" ref=""APILoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for ADDITIONAL PRICE INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""15"" ref=""ALCLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for ALLOWANCE OR CHARGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""100"" ref=""RCSLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for REQUIREMENTS AND CONDITIONS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""200000"" ref=""LINLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for LINE ITEM"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""UNS"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""UNS"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""SECTION CONTROL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""12"" ref=""MOA_10"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""CNT"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""CNT"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CONTROL TOTAL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""ALCLoop3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for ALLOWANCE OR CHARGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""UNT"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo notes=""Message Trailer"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""UNT1"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Number of Segments in a Message_0074"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:simpleType>
                  <xs:restriction base=""EDIFACT_N"">
                    <xs:minLength value=""1"" />
                    <xs:maxLength value=""10"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""UNT2"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Message Reference Number_0062"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:simpleType>
                  <xs:restriction base=""EDIFACT_AN"">
                    <xs:minLength value=""1"" />
                    <xs:maxLength value=""14"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RFFLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""RFF"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RFFLoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""RFF_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DOCLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for DOCUMENT/MESSAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""DOC"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DOC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CTALoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for CONTACT INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""CTA"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""CTA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CONTACT INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""COM"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""COM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""COMMUNICATION CONTACT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""NADLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for NAME AND ADDRESS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""NAD"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""NAD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""NAME AND ADDRESS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""25"" ref=""LOC"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""FII"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FII"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FINANCIAL INSTITUTION INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""RFFLoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DOCLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for DOCUMENT/MESSAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""CTALoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for CONTACT INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TAXLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for DUTY/TAX/FEE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""TAX"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""TAX"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""MOA"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""LOC_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CUXLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for CURRENCIES"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""CUX"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""CUX"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CURRENCIES"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""PCD"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PCD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PATLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PAYMENT TERMS BASIS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""PAT"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PAT"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PAYMENT TERMS BASIS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""PCD_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PCD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""MOA_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LOCLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PLACE/LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""LOC_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TDTLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for DETAILS OF TRANSPORT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""TDT"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""TDT"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DETAILS OF TRANSPORT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""LOCLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PLACE/LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TODLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for TERMS OF DELIVERY"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""TOD"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""TOD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TERMS OF DELIVERY"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""2"" ref=""LOC_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PCILoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PACKAGE IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""PCI"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PCI"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGE IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""RFF_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_8"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""GIN"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""GIN"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""GOODS IDENTITY NUMBER"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PACLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PACKAGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""PAC"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PAC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""MEA"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MEA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENTS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""PCILoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PACKAGE IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""EQDLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for EQUIPMENT DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""EQD"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""EQD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""EQUIPMENT DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""HAN"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""HAN"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""HANDLING INSTRUCTIONS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""MEA_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MEA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENTS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""FTX_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FTX"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FREE TEXT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""QTYLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for QUANTITY"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""QTY"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QTY"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_9"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SCCLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for SCHEDULING CONDITIONS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""SCC"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""SCC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""SCHEDULING CONDITIONS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""FTX_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FTX"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FREE TEXT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""RFF_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""QTYLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for QUANTITY"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""APILoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for ADDITIONAL PRICE INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""API"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""API"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ADDITIONAL PRICE INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_10"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""RNG"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""QTYLoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for QUANTITY"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""QTY_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QTY"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""RNG_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PCDLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PERCENTAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""PCD_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PCD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""RNG_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MOALoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""MOA_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""RNG_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RTELoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for RATE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""RTE"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RTE"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RATE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""RNG_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TAXLoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for DUTY/TAX/FEE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""TAX_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""TAX"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""MOA_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ALCLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for ALLOWANCE OR CHARGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ALC"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""ALC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ALLOWANCE OR CHARGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""ALI_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""ALI"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ADDITIONAL INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_11"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""QTYLoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for QUANTITY"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""PCDLoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PERCENTAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""2"" ref=""MOALoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""RTELoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for RATE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""TAXLoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for DUTY/TAX/FEE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RCSLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for REQUIREMENTS AND CONDITIONS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""RCS"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RCS"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REQUIREMENTS AND CONDITIONS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""RFF_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_12"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""FTX_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FTX"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FREE TEXT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PATLoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PAYMENT TERMS BASIS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""PAT_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PAT"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PAYMENT TERMS BASIS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_14"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""PCD_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PCD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""MOA_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PRILoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PRICE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""PRI"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PRI"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PRICE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""CUX_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""CUX"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CURRENCIES"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""API_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""API"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ADDITIONAL PRICE INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""RNG_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_15"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RFFLoop3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""RFF_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_16"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RFFLoop4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""RFF_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_18"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PCILoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PACKAGE IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""PCI_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PCI"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGE IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""RFF_8"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_19"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""GIN_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""GIN"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""GOODS IDENTITY NUMBER"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PACLoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PACKAGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""PAC_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PAC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""MEA_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MEA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENTS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""QTY_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QTY"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_17"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""RFFLoop4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""PCILoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PACKAGE IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LOCLoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PLACE/LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""LOC_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""QTY_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QTY"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_20"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TAXLoop3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for DUTY/TAX/FEE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""TAX_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""TAX"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""MOA_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""LOC_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RFFLoop5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""RFF_9"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_21"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DOCLoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for DOCUMENT/MESSAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""DOC_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DOC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_22"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CTALoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for CONTACT INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""CTA_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""CTA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CONTACT INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""COM_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""COM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""COMMUNICATION CONTACT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""NADLoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for NAME AND ADDRESS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""NAD_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""NAD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""NAME AND ADDRESS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""LOC_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""RFFLoop5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DOCLoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for DOCUMENT/MESSAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""CTALoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for CONTACT INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""QTYLoop3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for QUANTITY"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""QTY_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QTY"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""RNG_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PCDLoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PERCENTAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""PCD_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PCD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""RNG_8"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MOALoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""MOA_8"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""RNG_9"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RTELoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for RATE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""RTE_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RTE"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RATE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""RNG_10"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TAXLoop4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for DUTY/TAX/FEE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""TAX_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""TAX"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""MOA_9"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ALCLoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for ALLOWANCE OR CHARGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ALC_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""ALC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ALLOWANCE OR CHARGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""ALI_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""ALI"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ADDITIONAL INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_23"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""QTYLoop3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for QUANTITY"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""PCDLoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PERCENTAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""2"" ref=""MOALoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""RTELoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for RATE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""TAXLoop4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for DUTY/TAX/FEE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LOCLoop3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PLACE/LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""LOC_8"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_24"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TDTLoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for DETAILS OF TRANSPORT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""TDT_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""TDT"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DETAILS OF TRANSPORT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""LOCLoop3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PLACE/LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TODLoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for TERMS OF DELIVERY"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""TOD_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""TOD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TERMS OF DELIVERY"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""2"" ref=""LOC_9"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""EQDLoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for EQUIPMENT DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""EQD_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""EQD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""EQUIPMENT DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""HAN_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""HAN"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""HANDLING INSTRUCTIONS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""MEA_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MEA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENTS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""FTX_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FTX"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FREE TEXT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""QTYLoop4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for QUANTITY"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""QTY_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QTY"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_25"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SCCLoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for SCHEDULING CONDITIONS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""SCC_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""SCC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""SCHEDULING CONDITIONS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""FTX_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FTX"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FREE TEXT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""RFF_10"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""QTYLoop4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for QUANTITY"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RCSLoop2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for REQUIREMENTS AND CONDITIONS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""RCS_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RCS"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REQUIREMENTS AND CONDITIONS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""RFF_11"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""DTM_26"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""FTX_8"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FTX"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FREE TEXT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LINLoop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for LINE ITEM"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""LIN"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LIN"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LINE ITEM"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""25"" ref=""PIA"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PIA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ADDITIONAL PRODUCT ID"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""IMD_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""IMD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM DESCRIPTION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""MEA_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MEA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENTS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""QTY_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QTY"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""PCD_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PCD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""ALI_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""ALI"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ADDITIONAL INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""35"" ref=""DTM_13"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""MOA_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1000"" ref=""GIN_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""GIN"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""GOODS IDENTITY NUMBER"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1000"" ref=""GIR"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""GIR"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED IDENTIFICATION NUMBERS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""QVA"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QVA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY VARIANCES"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""DOC_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DOC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""PAI_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PAI"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PAYMENT INSTRUCTIONS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""FTX_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FTX"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FREE TEXT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""PATLoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PAYMENT TERMS BASIS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""25"" ref=""PRILoop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PRICE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""RFFLoop3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""PACLoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PACKAGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""100"" ref=""LOCLoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for PLACE/LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""TAXLoop3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for DUTY/TAX/FEE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""NADLoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for NAME AND ADDRESS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""15"" ref=""ALCLoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for ALLOWANCE OR CHARGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""TDTLoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for DETAILS OF TRANSPORT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""5"" ref=""TODLoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for TERMS OF DELIVERY"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""10"" ref=""EQDLoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for EQUIPMENT DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""100"" ref=""SCCLoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for SCHEDULING CONDITIONS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""100"" ref=""RCSLoop2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for REQUIREMENTS AND CONDITIONS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ALCLoop3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for ALLOWANCE OR CHARGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ALC_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""ALC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ALLOWANCE OR CHARGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ALI_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""ALI"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ADDITIONAL INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""2"" ref=""MOA_11"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""BGM"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""BGM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""BEGINNING OF MESSAGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" ref=""C002"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE NAME"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""BGM02"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message number_1004"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""BGM03"" type=""EDIFACT_ID_1225"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Message function, coded_1225"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""BGM04"" type=""EDIFACT_ID_4343"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Response type, coded_4343"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PAI"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PAI"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PAYMENT INSTRUCTIONS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C534"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PAYMENT INSTRUCTION DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ALI"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""ALI"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ADDITIONAL INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""ALI01"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Country of origin, coded_3239"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI02"" type=""EDIFACT_ID_9213"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of duty regime, coded_9213"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI03"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI04"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI05"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI06"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI07"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""IMD"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""IMD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM DESCRIPTION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""IMD01"" type=""EDIFACT_ID_7077"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item description type, coded_7077"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""IMD02"" type=""EDIFACT_ID_7081"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item characteristic, coded_7081"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C273"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM DESCRIPTION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""IMD04"" type=""EDIFACT_ID_7383"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Surface/layer indicator, coded_7383"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""FTX"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FTX"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FREE TEXT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FTX01"" type=""EDIFACT_ID_4451"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Text subject qualifier_4451"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FTX02"" type=""EDIFACT_ID_4453"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Text function, coded_4453"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C107"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C108"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT LITERAL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FTX05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Language, coded_3453"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RFF"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C506"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""NAD"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""NAD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""NAME AND ADDRESS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""NAD01"" type=""EDIFACT_ID_3035"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party qualifier_3035"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C082"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PARTY IDENTIFICATION DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C058"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""NAME AND ADDRESS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C080"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PARTY NAME"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C059"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""STREET"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""NAD06"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""City name_3164"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""NAD07"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Country sub-entity identification_3229"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""9"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""NAD08"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Postcode identification_3251"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""9"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""NAD09"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Country, coded_3207"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LOC"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LOC01"" type=""EDIFACT_ID_3227"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location qualifier_3227"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C517"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C519"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C553"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LOC05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Relation, coded_5479"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""FII"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FII"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FINANCIAL INSTITUTION INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FII01"" type=""EDIFACT_ID_3035"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party qualifier_3035"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C078"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ACCOUNT IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C088"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""INSTITUTION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FII04"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Country, coded_3207"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RFF_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C506_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_3"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DOC"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DOC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C002_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE NAME"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C503"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""DOC03"" type=""EDIFACT_ID_3153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Communication channel identifier, coded_3153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""DOC04"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Number of copies of document required_1220"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""2"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""DOC05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Number of originals of document required_1218"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""2"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_4"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CTA"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""CTA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CONTACT INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""CTA01"" type=""EDIFACT_ID_3139"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Contact function, coded_3139"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C056"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DEPARTMENT OR EMPLOYEE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""COM"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""COM"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""COMMUNICATION CONTACT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C076"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""COMMUNICATION CONTACT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TAX"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""TAX"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""TAX01"" type=""EDIFACT_ID_5283"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee function qualifier_5283"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C241"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE TYPE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C533"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE ACCOUNT DETAIL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TAX04"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee assessment basis_5286"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C243"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE DETAIL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TAX06"" type=""EDIFACT_ID_5305"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee category, coded_5305"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TAX07"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party tax identification number_3446"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""20"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MOA"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C516"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LOC_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LOC01"" type=""EDIFACT_ID_3227"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location qualifier_3227"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C517_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C519_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C553_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LOC05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Relation, coded_5479"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CUX"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""CUX"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CURRENCIES"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" ref=""C504"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CURRENCY DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C504_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CURRENCY DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""CUX03"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Rate of exchange_5402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""12"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""CUX04"" type=""EDIFACT_ID_6341"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency market exchange, coded_6341"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PCD"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PCD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C501"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_5"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PAT"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PAT"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PAYMENT TERMS BASIS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PAT01"" type=""EDIFACT_ID_4279"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Payment terms type qualifier_4279"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C110"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PAYMENT TERMS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C112"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TERMS/TIME INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_6"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PCD_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PCD_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C501_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MOA_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C516_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TDT"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""TDT"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DETAILS OF TRANSPORT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""TDT01"" type=""EDIFACT_ID_8051"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Transport stage qualifier_8051"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TDT02"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Conveyance reference number_8028"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C220"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MODE OF TRANSPORT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C228"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TRANSPORT MEANS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C040"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CARRIER"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TDT06"" type=""EDIFACT_ID_8101"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Transit direction, coded_8101"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C401"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""EXCESS TRANSPORTATION INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C222"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TRANSPORT IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LOC_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC_3"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LOC01"" type=""EDIFACT_ID_3227"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location qualifier_3227"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C517_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C519_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C553_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LOC05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Relation, coded_5479"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_7"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TOD"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""TOD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TERMS OF DELIVERY"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""TOD01"" type=""EDIFACT_ID_4055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Terms of delivery function, coded_4055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TOD02"" type=""EDIFACT_ID_4215"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Transport charges method of payment, coded_4215"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C100"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TERMS OF DELIVERY"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LOC_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC_4"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LOC01"" type=""EDIFACT_ID_3227"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location qualifier_3227"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C517_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C519_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C553_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LOC05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Relation, coded_5479"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PAC"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PAC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""PAC01"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Number of packages_7224"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C531"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGING DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C202"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGE TYPE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C402"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGE TYPE IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C532"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RETURNABLE PACKAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MEA"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MEA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENTS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""MEA01"" type=""EDIFACT_ID_6311"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement application qualifier_6311"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C502"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENT DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C174"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""VALUE/RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""MEA04"" type=""EDIFACT_ID_7383"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Surface/layer indicator, coded_7383"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PCI"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PCI"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGE IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""PCI01"" type=""EDIFACT_ID_4233"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Marking instructions, coded_4233"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C210"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MARKS &amp; LABELS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PCI03"" type=""EDIFACT_ID_8275"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Container/package status, coded_8275"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RFF_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF_3"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C506_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_8"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_8"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_8"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GIN"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""GIN"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""GOODS IDENTITY NUMBER"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""GIN01"" type=""EDIFACT_ID_7405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number qualifier_7405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""C208"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C208_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C208_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C208_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C208_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""EQD"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""EQD"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""EQUIPMENT DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""EQD01"" type=""EDIFACT_ID_8053"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment qualifier_8053"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C237"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""EQUIPMENT IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C224"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""EQUIPMENT SIZE AND TYPE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""EQD04"" type=""EDIFACT_ID_8077"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment supplier, coded_8077"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""EQD05"" type=""EDIFACT_ID_8249"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment status, coded_8249"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""EQD06"" type=""EDIFACT_ID_8169"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Full/empty indicator, coded_8169"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""HAN"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""HAN"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""HANDLING INSTRUCTIONS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" ref=""C524"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""HANDLING INSTRUCTIONS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C218"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""HAZARDOUS MATERIAL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MEA_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MEA_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENTS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""MEA01"" type=""EDIFACT_ID_6311"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement application qualifier_6311"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C502_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENT DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C174_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""VALUE/RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""MEA04"" type=""EDIFACT_ID_7383"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Surface/layer indicator, coded_7383"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""FTX_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FTX_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FREE TEXT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FTX01"" type=""EDIFACT_ID_4451"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Text subject qualifier_4451"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FTX02"" type=""EDIFACT_ID_4453"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Text function, coded_4453"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C107_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C108_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT LITERAL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FTX05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Language, coded_3453"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SCC"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""SCC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""SCHEDULING CONDITIONS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""SCC01"" type=""EDIFACT_ID_4017"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Delivery plan status indicator, coded_4017"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""SCC02"" type=""EDIFACT_ID_4493"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Delivery requirements, coded_4493"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C329"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PATTERN DESCRIPTION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""FTX_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FTX_3"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FREE TEXT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FTX01"" type=""EDIFACT_ID_4451"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Text subject qualifier_4451"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FTX02"" type=""EDIFACT_ID_4453"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Text function, coded_4453"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C107_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C108_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT LITERAL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FTX05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Language, coded_3453"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RFF_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF_4"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C506_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""QTY"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QTY"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C186"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_9"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_9"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_9"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""API"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""API"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ADDITIONAL PRICE INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""API01"" type=""EDIFACT_ID_4043"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Class of trade, coded_4043"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C138"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PRICE MULTIPLIER INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C262"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REASON FOR CHANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_10"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_10"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_10"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RNG"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RNG01"" type=""EDIFACT_ID_6167"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range type qualifier_6167"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C280"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ALC"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""ALC"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ALLOWANCE OR CHARGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ALC01"" type=""EDIFACT_ID_5463"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or charge qualifier_5463"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C552"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ALLOWANCE/CHARGE INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALC03"" type=""EDIFACT_ID_4471"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Settlement, coded_4471"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALC04"" type=""EDIFACT_ID_1227"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Calculation sequence indicator, coded_1227"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C214"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""SPECIAL SERVICES IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ALI_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""ALI_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ADDITIONAL INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""ALI01"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Country of origin, coded_3239"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI02"" type=""EDIFACT_ID_9213"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of duty regime, coded_9213"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI03"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI04"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI05"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI06"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI07"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_11"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_11"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_11"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""QTY_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QTY_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C186_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RNG_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RNG01"" type=""EDIFACT_ID_6167"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range type qualifier_6167"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C280_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PCD_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PCD_3"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C501_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RNG_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG_3"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RNG01"" type=""EDIFACT_ID_6167"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range type qualifier_6167"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C280_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MOA_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA_3"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C516_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RNG_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG_4"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RNG01"" type=""EDIFACT_ID_6167"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range type qualifier_6167"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C280_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RTE"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RTE"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RATE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C128"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RATE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RNG_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG_5"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RNG01"" type=""EDIFACT_ID_6167"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range type qualifier_6167"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C280_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TAX_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""TAX_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""TAX01"" type=""EDIFACT_ID_5283"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee function qualifier_5283"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C241_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE TYPE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C533_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE ACCOUNT DETAIL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TAX04"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee assessment basis_5286"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C243_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE DETAIL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TAX06"" type=""EDIFACT_ID_5305"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee category, coded_5305"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TAX07"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party tax identification number_3446"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""20"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MOA_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA_4"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C516_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RCS"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RCS"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REQUIREMENTS AND CONDITIONS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RCS01"" type=""EDIFACT_ID_7293"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Sector/subject identification qualifier_7293"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""C550"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REQUIREMENT/CONDITION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""RCS03"" type=""EDIFACT_ID_1229"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Action request/notification, coded_1229"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RFF_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF_5"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C506_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_12"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_12"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_12"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""FTX_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FTX_4"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FREE TEXT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FTX01"" type=""EDIFACT_ID_4451"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Text subject qualifier_4451"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FTX02"" type=""EDIFACT_ID_4453"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Text function, coded_4453"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C107_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C108_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT LITERAL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FTX05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Language, coded_3453"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LIN"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LIN"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LINE ITEM"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""LIN01"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Line item number_1082"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LIN02"" type=""EDIFACT_ID_1229"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Action request/notification, coded_1229"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C212"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM NUMBER IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LIN04"" type=""EDIFACT_ID_5495"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Sub-line indicator, coded_5495"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LIN05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Configuration level_1222"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""2"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LIN06"" type=""EDIFACT_ID_7083"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Configuration, coded_7083"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PIA"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PIA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ADDITIONAL PRODUCT ID"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PIA01"" type=""EDIFACT_ID_4347"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Product id function qualifier_4347"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""C212_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM NUMBER IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C212_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM NUMBER IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C212_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM NUMBER IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C212_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM NUMBER IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C212_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM NUMBER IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""IMD_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""IMD_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM DESCRIPTION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""IMD01"" type=""EDIFACT_ID_7077"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item description type, coded_7077"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""IMD02"" type=""EDIFACT_ID_7081"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item characteristic, coded_7081"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C273_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM DESCRIPTION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""IMD04"" type=""EDIFACT_ID_7383"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Surface/layer indicator, coded_7383"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MEA_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MEA_3"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENTS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""MEA01"" type=""EDIFACT_ID_6311"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement application qualifier_6311"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C502_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENT DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C174_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""VALUE/RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""MEA04"" type=""EDIFACT_ID_7383"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Surface/layer indicator, coded_7383"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""QTY_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QTY_3"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C186_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PCD_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PCD_4"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C501_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ALI_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""ALI_3"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ADDITIONAL INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""ALI01"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Country of origin, coded_3239"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI02"" type=""EDIFACT_ID_9213"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of duty regime, coded_9213"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI03"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI04"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI05"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI06"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI07"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_13"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_13"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_13"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MOA_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA_5"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C516_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GIN_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""GIN_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""GOODS IDENTITY NUMBER"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""GIN01"" type=""EDIFACT_ID_7405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number qualifier_7405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""C208_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C208_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C208_8"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C208_9"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C208_10"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GIR"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""GIR"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED IDENTIFICATION NUMBERS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""GIR01"" type=""EDIFACT_ID_7297"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Set identification qualifier_7297"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""C206"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTIFICATION NUMBER"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C206_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTIFICATION NUMBER"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C206_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTIFICATION NUMBER"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C206_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTIFICATION NUMBER"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C206_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTIFICATION NUMBER"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""QVA"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QVA"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY VARIANCES"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" ref=""C279"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY DIFFERENCE INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""QVA02"" type=""EDIFACT_ID_4221"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Discrepancy, coded_4221"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C262_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REASON FOR CHANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DOC_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DOC_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C002_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE NAME"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C503_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""DOC03"" type=""EDIFACT_ID_3153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Communication channel identifier, coded_3153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""DOC04"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Number of copies of document required_1220"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""2"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""DOC05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Number of originals of document required_1218"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""2"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PAI_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PAI_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PAYMENT INSTRUCTIONS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C534_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PAYMENT INSTRUCTION DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""FTX_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FTX_5"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FREE TEXT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FTX01"" type=""EDIFACT_ID_4451"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Text subject qualifier_4451"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FTX02"" type=""EDIFACT_ID_4453"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Text function, coded_4453"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C107_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C108_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT LITERAL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FTX05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Language, coded_3453"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PAT_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PAT_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PAYMENT TERMS BASIS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PAT01"" type=""EDIFACT_ID_4279"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Payment terms type qualifier_4279"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C110_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PAYMENT TERMS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C112_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TERMS/TIME INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_14"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_14"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_14"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PCD_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PCD_5"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C501_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MOA_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA_6"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C516_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PRI"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PRI"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PRICE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" ref=""C509"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PRICE INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PRI02"" type=""EDIFACT_ID_5213"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Sub-line price change, coded_5213"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CUX_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""CUX_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CURRENCIES"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" ref=""C504_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CURRENCY DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C504_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CURRENCY DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""CUX03"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Rate of exchange_5402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""12"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""CUX04"" type=""EDIFACT_ID_6341"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency market exchange, coded_6341"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""API_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""API_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ADDITIONAL PRICE INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""API01"" type=""EDIFACT_ID_4043"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Class of trade, coded_4043"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C138_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PRICE MULTIPLIER INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C262_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REASON FOR CHANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RNG_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG_6"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RNG01"" type=""EDIFACT_ID_6167"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range type qualifier_6167"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C280_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_15"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_15"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_15"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RFF_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF_6"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C506_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_16"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_16"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_16"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PAC_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PAC_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""PAC01"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Number of packages_7224"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C531_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGING DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C202_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGE TYPE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C402_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGE TYPE IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C532_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RETURNABLE PACKAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MEA_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MEA_4"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENTS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""MEA01"" type=""EDIFACT_ID_6311"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement application qualifier_6311"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C502_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENT DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C174_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""VALUE/RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""MEA04"" type=""EDIFACT_ID_7383"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Surface/layer indicator, coded_7383"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""QTY_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QTY_4"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C186_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_17"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_17"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_17"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RFF_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF_7"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C506_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_18"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_18"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_18"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PCI_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PCI_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGE IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""PCI01"" type=""EDIFACT_ID_4233"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Marking instructions, coded_4233"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C210_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MARKS &amp; LABELS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""PCI03"" type=""EDIFACT_ID_8275"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Container/package status, coded_8275"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RFF_8"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF_8"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C506_8"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_19"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_19"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_19"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GIN_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""GIN_3"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""GOODS IDENTITY NUMBER"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""GIN01"" type=""EDIFACT_ID_7405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number qualifier_7405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""C208_11"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C208_12"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C208_13"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C208_14"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C208_15"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LOC_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC_5"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LOC01"" type=""EDIFACT_ID_3227"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location qualifier_3227"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C517_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C519_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C553_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LOC05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Relation, coded_5479"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""QTY_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QTY_5"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C186_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_20"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_20"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_20"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TAX_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""TAX_3"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""TAX01"" type=""EDIFACT_ID_5283"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee function qualifier_5283"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C241_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE TYPE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C533_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE ACCOUNT DETAIL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TAX04"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee assessment basis_5286"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C243_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE DETAIL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TAX06"" type=""EDIFACT_ID_5305"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee category, coded_5305"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TAX07"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party tax identification number_3446"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""20"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MOA_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA_7"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C516_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LOC_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC_6"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LOC01"" type=""EDIFACT_ID_3227"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location qualifier_3227"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C517_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C519_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C553_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LOC05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Relation, coded_5479"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""NAD_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""NAD_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""NAME AND ADDRESS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""NAD01"" type=""EDIFACT_ID_3035"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party qualifier_3035"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C082_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PARTY IDENTIFICATION DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C058_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""NAME AND ADDRESS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C080_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PARTY NAME"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C059_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""STREET"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""NAD06"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""City name_3164"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""NAD07"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Country sub-entity identification_3229"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""9"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""NAD08"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Postcode identification_3251"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""9"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""NAD09"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Country, coded_3207"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LOC_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC_7"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LOC01"" type=""EDIFACT_ID_3227"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location qualifier_3227"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C517_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C519_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C553_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LOC05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Relation, coded_5479"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RFF_9"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF_9"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C506_9"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_21"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_21"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_21"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DOC_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DOC_3"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C002_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE NAME"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C503_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""DOC03"" type=""EDIFACT_ID_3153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Communication channel identifier, coded_3153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""DOC04"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Number of copies of document required_1220"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""2"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""DOC05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Number of originals of document required_1218"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""2"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_22"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_22"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_22"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CTA_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""CTA_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CONTACT INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""CTA01"" type=""EDIFACT_ID_3139"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Contact function, coded_3139"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C056_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DEPARTMENT OR EMPLOYEE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""COM_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""COM_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""COMMUNICATION CONTACT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C076_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""COMMUNICATION CONTACT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ALC_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""ALC_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ALLOWANCE OR CHARGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ALC01"" type=""EDIFACT_ID_5463"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or charge qualifier_5463"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C552_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ALLOWANCE/CHARGE INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALC03"" type=""EDIFACT_ID_4471"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Settlement, coded_4471"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALC04"" type=""EDIFACT_ID_1227"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Calculation sequence indicator, coded_1227"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C214_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""SPECIAL SERVICES IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ALI_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""ALI_4"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ADDITIONAL INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""ALI01"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Country of origin, coded_3239"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI02"" type=""EDIFACT_ID_9213"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of duty regime, coded_9213"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI03"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI04"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI05"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI06"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI07"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_23"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_23"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_23"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""QTY_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QTY_6"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C186_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RNG_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG_7"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RNG01"" type=""EDIFACT_ID_6167"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range type qualifier_6167"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C280_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PCD_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""PCD_6"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C501_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RNG_8"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG_8"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RNG01"" type=""EDIFACT_ID_6167"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range type qualifier_6167"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C280_8"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MOA_8"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA_8"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C516_8"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RNG_9"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG_9"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RNG01"" type=""EDIFACT_ID_6167"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range type qualifier_6167"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C280_9"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RTE_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RTE_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RATE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C128_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RATE DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RNG_10"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RNG_10"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RNG01"" type=""EDIFACT_ID_6167"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range type qualifier_6167"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C280_10"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TAX_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""TAX_4"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""TAX01"" type=""EDIFACT_ID_5283"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee function qualifier_5283"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C241_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE TYPE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C533_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE ACCOUNT DETAIL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TAX04"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee assessment basis_5286"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C243_4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE DETAIL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TAX06"" type=""EDIFACT_ID_5305"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee category, coded_5305"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TAX07"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party tax identification number_3446"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""20"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MOA_9"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA_9"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C516_9"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TDT_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""TDT_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DETAILS OF TRANSPORT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""TDT01"" type=""EDIFACT_ID_8051"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Transport stage qualifier_8051"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TDT02"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Conveyance reference number_8028"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C220_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MODE OF TRANSPORT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C228_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TRANSPORT MEANS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C040_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CARRIER"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TDT06"" type=""EDIFACT_ID_8101"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Transit direction, coded_8101"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C401_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""EXCESS TRANSPORTATION INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C222_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TRANSPORT IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LOC_8"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC_8"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LOC01"" type=""EDIFACT_ID_3227"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location qualifier_3227"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C517_8"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C519_8"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C553_8"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LOC05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Relation, coded_5479"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_24"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_24"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_24"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TOD_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""TOD_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TERMS OF DELIVERY"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""TOD01"" type=""EDIFACT_ID_4055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Terms of delivery function, coded_4055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""TOD02"" type=""EDIFACT_ID_4215"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Transport charges method of payment, coded_4215"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C100_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TERMS OF DELIVERY"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LOC_9"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""LOC_9"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PLACE/LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LOC01"" type=""EDIFACT_ID_3227"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location qualifier_3227"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C517_9"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C519_9"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C553_9"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""LOC05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Relation, coded_5479"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""EQD_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""EQD_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""EQUIPMENT DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""EQD01"" type=""EDIFACT_ID_8053"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment qualifier_8053"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C237_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""EQUIPMENT IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C224_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""EQUIPMENT SIZE AND TYPE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""EQD04"" type=""EDIFACT_ID_8077"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment supplier, coded_8077"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""EQD05"" type=""EDIFACT_ID_8249"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment status, coded_8249"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""EQD06"" type=""EDIFACT_ID_8169"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Full/empty indicator, coded_8169"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""HAN_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""HAN_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""HANDLING INSTRUCTIONS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" ref=""C524_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""HANDLING INSTRUCTIONS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C218_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""HAZARDOUS MATERIAL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MEA_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MEA_5"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENTS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""MEA01"" type=""EDIFACT_ID_6311"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement application qualifier_6311"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C502_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENT DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C174_5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""VALUE/RANGE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""MEA04"" type=""EDIFACT_ID_7383"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Surface/layer indicator, coded_7383"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""FTX_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FTX_6"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FREE TEXT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FTX01"" type=""EDIFACT_ID_4451"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Text subject qualifier_4451"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FTX02"" type=""EDIFACT_ID_4453"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Text function, coded_4453"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C107_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C108_6"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT LITERAL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FTX05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Language, coded_3453"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SCC_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""SCC_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""SCHEDULING CONDITIONS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""SCC01"" type=""EDIFACT_ID_4017"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Delivery plan status indicator, coded_4017"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""SCC02"" type=""EDIFACT_ID_4493"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Delivery requirements, coded_4493"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C329_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PATTERN DESCRIPTION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""FTX_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FTX_7"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FREE TEXT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FTX01"" type=""EDIFACT_ID_4451"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Text subject qualifier_4451"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FTX02"" type=""EDIFACT_ID_4453"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Text function, coded_4453"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C107_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C108_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT LITERAL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FTX05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Language, coded_3453"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RFF_10"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF_10"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C506_10"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""QTY_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""QTY_7"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C186_7"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY DETAILS"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_25"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_25"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_25"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RCS_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RCS_2"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REQUIREMENTS AND CONDITIONS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RCS01"" type=""EDIFACT_ID_7293"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Sector/subject identification qualifier_7293"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""C550_2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REQUIREMENT/CONDITION IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""RCS03"" type=""EDIFACT_ID_1229"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Action request/notification, coded_1229"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RFF_11"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""RFF_11"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C506_11"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DTM_26"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""DTM_26"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C507_26"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""FTX_8"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""FTX_8"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""FREE TEXT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FTX01"" type=""EDIFACT_ID_4451"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Text subject qualifier_4451"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FTX02"" type=""EDIFACT_ID_4453"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Text function, coded_4453"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C107_8"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT REFERENCE"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C108_8"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT LITERAL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""FTX05"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Language, coded_3453"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""UNS"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""UNS"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""SECTION CONTROL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""UNS01"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Section identifier_0081"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_A"">
              <xs:length value=""1"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MOA_10"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA_10"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C516_10"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CNT"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""CNT"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CONTROL TOTAL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C270"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CONTROL"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ALC_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""ALC_3"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ALLOWANCE OR CHARGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ALC01"" type=""EDIFACT_ID_5463"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or charge qualifier_5463"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C552_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ALLOWANCE/CHARGE INFORMATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALC03"" type=""EDIFACT_ID_4471"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Settlement, coded_4471"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALC04"" type=""EDIFACT_ID_1227"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Calculation sequence indicator, coded_1227"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""C214_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""SPECIAL SERVICES IDENTIFICATION"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ALI_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""ALI_5"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ADDITIONAL INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""ALI01"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Country of origin, coded_3239"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI02"" type=""EDIFACT_ID_9213"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of duty regime, coded_9213"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI03"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI04"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI05"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI06"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ALI07"" type=""EDIFACT_ID_4183"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special conditions, coded_4183"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MOA_11"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""MOA_11"" delimiter_type=""inherit_field"" count_ignore=""no"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C516_11"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C002"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE NAME"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C00201"" type=""EDIFACT_ID_1001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message name, coded_1001"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00202"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00203"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message name_1000"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C534"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PAYMENT INSTRUCTION DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C53401"" type=""EDIFACT_ID_4439"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Payment conditions, coded_4439"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53402"" type=""EDIFACT_ID_4431"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Payment guarantee, coded_4431"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53403"" type=""EDIFACT_ID_4461"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Payment means, coded_4461"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53404"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53405"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53406"" type=""EDIFACT_ID_4435"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Payment channel, coded_4435"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C273"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM DESCRIPTION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C27301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item description identification_7009"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""7"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C27302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C27303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C27304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item description_7008"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C27305"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item description_7008"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C107"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C10701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text, coded_4441"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C108"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT LITERAL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C10801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10803"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10804"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10805"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C506"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50601"" type=""EDIFACT_ID_1153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference qualifier_1153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference number_1154"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Line number_1156"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50604"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference version number_4000"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C082"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PARTY IDENTIFICATION DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C08201"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party id identification_3039"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08202"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08203"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C058"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""NAME AND ADDRESS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C05801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Name and address line_3124"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C05802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Name and address line_3124"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C05803"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Name and address line_3124"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C05804"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Name and address line_3124"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C05805"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Name and address line_3124"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C080"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PARTY NAME"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C08001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party name_3036"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party name_3036"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08003"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party name_3036"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08004"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party name_3036"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party name_3036"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08006"" type=""EDIFACT_ID_3045"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party name format, coded_3045"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C059"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""STREET"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C05901"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Street and number/p.o. box_3042"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C05902"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Street and number/p.o. box_3042"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C05903"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Street and number/p.o. box_3042"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C517"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location identification_3225"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51704"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location_3224"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C519"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51901"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one identification_3223"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51902"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51903"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51904"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one_3222"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C553"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C55301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two identification_3233"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two_3232"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C078"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ACCOUNT IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C07801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Account holder number_3194"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C07802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Account holder name_3192"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C07803"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Account holder name_3192"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C07804"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency, coded_6345"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C088"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""INSTITUTION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C08801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Institution name identification_3433"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""11"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08802"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08803"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08804"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Institution branch number_3434"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08805"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08806"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08807"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Institution name_3432"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08808"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Institution branch place_3436"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C506_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50601"" type=""EDIFACT_ID_1153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference qualifier_1153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference number_1154"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Line number_1156"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50604"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference version number_4000"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C002_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE NAME"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C00201"" type=""EDIFACT_ID_1001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message name, coded_1001"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00202"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00203"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message name_1000"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C503"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C50301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message number_1004"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50302"" type=""EDIFACT_ID_1373"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message status, coded_1373"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50303"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message source_1366"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Language, coded_3453"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C056"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DEPARTMENT OR EMPLOYEE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C05601"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Department or employee identification_3413"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C05602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Department or employee_3412"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C076"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""COMMUNICATION CONTACT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C07601"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Communication number_3148"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element name=""C07602"" type=""EDIFACT_ID_3155"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Communication channel qualifier_3155"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C241"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE TYPE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C24101"" type=""EDIFACT_ID_5153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee type, coded_5153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24102"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24103"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24104"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee type_5152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C533"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE ACCOUNT DETAIL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C53301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee account identification_5289"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C243"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE DETAIL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C24301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee rate identification_5279"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""7"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee rate_5278"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24305"" type=""EDIFACT_ID_5273"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee rate basis identification_5273"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24306"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24307"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C516"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C51601"" type=""EDIFACT_ID_5025"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount type qualifier_5025"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount_5004"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency, coded_6345"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51604"" type=""EDIFACT_ID_6343"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency qualifier_6343"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51605"" type=""EDIFACT_ID_4405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Status, coded_4405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C517_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location identification_3225"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51704"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location_3224"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C519_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51901"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one identification_3223"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51902"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51903"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51904"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one_3222"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C553_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C55301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two identification_3233"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two_3232"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C504"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CURRENCY DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50401"" type=""EDIFACT_ID_6347"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency details qualifier_6347"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50402"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency, coded_6345"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50403"" type=""EDIFACT_ID_6343"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency qualifier_6343"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency rate base_6348"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""4"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C504_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CURRENCY DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50401"" type=""EDIFACT_ID_6347"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency details qualifier_6347"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50402"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency, coded_6345"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50403"" type=""EDIFACT_ID_6343"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency qualifier_6343"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency rate base_6348"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""4"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C501"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50101"" type=""EDIFACT_ID_5245"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage qualifier_5245"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50102"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage_5482"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50103"" type=""EDIFACT_ID_5249"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage basis, coded_5249"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50104"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50105"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C110"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PAYMENT TERMS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C11001"" type=""EDIFACT_ID_4277"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Terms of payment identification_4277"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C11002"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C11003"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C11004"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Terms of payment_4276"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C11005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Terms of payment_4276"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C112"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TERMS/TIME INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C11201"" type=""EDIFACT_ID_2475"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Payment time reference, coded_2475"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C11202"" type=""EDIFACT_ID_2009"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time relation, coded_2009"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C11203"" type=""EDIFACT_ID_2151"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of period, coded_2151"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C11204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Number of periods_2152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C501_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50101"" type=""EDIFACT_ID_5245"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage qualifier_5245"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50102"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage_5482"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50103"" type=""EDIFACT_ID_5249"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage basis, coded_5249"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50104"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50105"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C516_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C51601"" type=""EDIFACT_ID_5025"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount type qualifier_5025"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount_5004"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency, coded_6345"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51604"" type=""EDIFACT_ID_6343"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency qualifier_6343"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51605"" type=""EDIFACT_ID_4405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Status, coded_4405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C220"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MODE OF TRANSPORT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C22001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Mode of transport, coded_8067"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Mode of transport_8066"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C228"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TRANSPORT MEANS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C22801"" type=""EDIFACT_ID_8179"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of means of transport identification_8179"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of means of transport_8178"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C040"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CARRIER"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C04001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Carrier identification_3127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04002"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04003"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04004"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Carrier name_3128"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C401"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""EXCESS TRANSPORTATION INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C40101"" type=""EDIFACT_ID_8457"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Excess transportation reason, coded_8457"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C40102"" type=""EDIFACT_ID_8459"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Excess transportation responsibility, coded_8459"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C40103"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Customer authorization number_7130"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C222"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TRANSPORT IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C22201"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Id of means of transport identification_8213"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""9"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22202"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22203"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Id of the means of transport_8212"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22205"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Nationality of means of transport, coded_8453"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C517_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location identification_3225"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51704"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location_3224"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C519_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51901"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one identification_3223"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51902"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51903"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51904"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one_3222"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C553_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C55301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two identification_3233"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two_3232"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C100"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TERMS OF DELIVERY"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C10001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Terms of delivery, coded_4053"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10002"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10003"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10004"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Terms of delivery_4052"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Terms of delivery_4052"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C517_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location identification_3225"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51704"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location_3224"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C519_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51901"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one identification_3223"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51902"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51903"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51904"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one_3222"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C553_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C55301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two identification_3233"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two_3232"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C531"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGING DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C53101"" type=""EDIFACT_ID_7075"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Packaging level, coded_7075"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53102"" type=""EDIFACT_ID_7233"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Packaging related information, coded_7233"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53103"" type=""EDIFACT_ID_7073"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Packaging terms and conditions, coded_7073"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C202"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGE TYPE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C20201"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of packages identification_7065"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""7"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20202"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20203"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of packages_7064"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C402"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGE TYPE IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C40201"" type=""EDIFACT_ID_7077"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item description type, coded_7077"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C40202"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of packages_7064"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C40203"" type=""EDIFACT_ID_7143"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item number type, coded_7143"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C40204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of packages_7064"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C40205"" type=""EDIFACT_ID_7143"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item number type, coded_7143"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C532"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RETURNABLE PACKAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C53201"" type=""EDIFACT_ID_8395"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Returnable package freight payment responsibility, coded_8395"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53202"" type=""EDIFACT_ID_8393"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Returnable package load contents, coded_8393"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C502"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENT DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C50201"" type=""EDIFACT_ID_6313"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement dimension, coded_6313"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50202"" type=""EDIFACT_ID_6321"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement significance, coded_6321"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50203"" type=""EDIFACT_ID_6155"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement attribute, coded_6155"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C174"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""VALUE/RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C17401"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C17402"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement value_6314"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C17403"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range minimum_6162"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C17404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range maximum_6152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C210"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MARKS &amp; LABELS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C21001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21003"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21004"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21006"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21007"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21008"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21009"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21010"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C506_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50601"" type=""EDIFACT_ID_1153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference qualifier_1153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference number_1154"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Line number_1156"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50604"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference version number_4000"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_8"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C208"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C208_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C208_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C208_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C208_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C237"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""EQUIPMENT IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C23701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment identification number_8260"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C23702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C23703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C224"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""EQUIPMENT SIZE AND TYPE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C22401"" type=""EDIFACT_ID_8155"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment size and type identification_8155"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22402"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22403"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment size and type_8154"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C524"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""HANDLING INSTRUCTIONS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C52401"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Handling instructions, coded_4079"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C52402"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C52403"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C52404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Handling instructions_4078"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C218"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""HAZARDOUS MATERIAL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C21801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Hazardous material class code, identification_7419"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""4"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21802"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21803"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C502_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENT DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C50201"" type=""EDIFACT_ID_6313"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement dimension, coded_6313"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50202"" type=""EDIFACT_ID_6321"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement significance, coded_6321"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50203"" type=""EDIFACT_ID_6155"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement attribute, coded_6155"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C174_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""VALUE/RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C17401"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C17402"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement value_6314"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C17403"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range minimum_6162"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C17404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range maximum_6152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C107_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C10701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text, coded_4441"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C108_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT LITERAL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C10801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10803"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10804"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10805"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C329"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PATTERN DESCRIPTION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C32901"" type=""EDIFACT_ID_2013"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Frequency, coded_2013"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C32902"" type=""EDIFACT_ID_2015"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Despatch pattern, coded_2015"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C32903"" type=""EDIFACT_ID_2017"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Despatch pattern timing, coded_2017"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C107_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C10701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text, coded_4441"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C108_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT LITERAL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C10801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10803"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10804"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10805"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C506_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50601"" type=""EDIFACT_ID_1153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference qualifier_1153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference number_1154"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Line number_1156"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50604"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference version number_4000"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C186"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C18601"" type=""EDIFACT_ID_6063"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity qualifier_6063"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C18602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity_6060"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C18603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_9"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C138"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PRICE MULTIPLIER INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C13801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Price multiplier_5394"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""12"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C13802"" type=""EDIFACT_ID_5393"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Price multiplier qualifier_5393"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C262"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REASON FOR CHANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C26201"" type=""EDIFACT_ID_4295"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Change reason, coded_4295"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C26202"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Change reason_4294"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_10"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C280"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C28001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range minimum_6162"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28003"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range maximum_6152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C552"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ALLOWANCE/CHARGE INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C55201"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or charge number_1230"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55202"" type=""EDIFACT_ID_5189"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Charge/allowance description, coded_5189"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C214"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""SPECIAL SERVICES IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C21401"" type=""EDIFACT_ID_7161"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special services, coded_7161"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21402"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21403"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special service_7160"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_11"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C186_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C18601"" type=""EDIFACT_ID_6063"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity qualifier_6063"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C18602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity_6060"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C18603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C280_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C28001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range minimum_6162"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28003"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range maximum_6152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C501_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50101"" type=""EDIFACT_ID_5245"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage qualifier_5245"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50102"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage_5482"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50103"" type=""EDIFACT_ID_5249"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage basis, coded_5249"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50104"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50105"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C280_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C28001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range minimum_6162"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28003"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range maximum_6152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C516_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C51601"" type=""EDIFACT_ID_5025"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount type qualifier_5025"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount_5004"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency, coded_6345"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51604"" type=""EDIFACT_ID_6343"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency qualifier_6343"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51605"" type=""EDIFACT_ID_4405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Status, coded_4405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C280_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C28001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range minimum_6162"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28003"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range maximum_6152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C128"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RATE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C12801"" type=""EDIFACT_ID_5419"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Rate type qualifier_5419"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C12802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Rate per unit_5420"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C12803"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit price basis_5284"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""9"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C12804"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C280_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C28001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range minimum_6162"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28003"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range maximum_6152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C241_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE TYPE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C24101"" type=""EDIFACT_ID_5153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee type, coded_5153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24102"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24103"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24104"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee type_5152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C533_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE ACCOUNT DETAIL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C53301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee account identification_5289"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C243_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE DETAIL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C24301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee rate identification_5279"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""7"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee rate_5278"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24305"" type=""EDIFACT_ID_5273"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee rate basis identification_5273"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24306"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24307"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C516_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C51601"" type=""EDIFACT_ID_5025"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount type qualifier_5025"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount_5004"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency, coded_6345"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51604"" type=""EDIFACT_ID_6343"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency qualifier_6343"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51605"" type=""EDIFACT_ID_4405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Status, coded_4405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C550"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REQUIREMENT/CONDITION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C55001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Requirement/condition identification_7295"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55002"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55003"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C506_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50601"" type=""EDIFACT_ID_1153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference qualifier_1153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference number_1154"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Line number_1156"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50604"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference version number_4000"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_12"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C107_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C10701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text, coded_4441"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C108_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT LITERAL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C10801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10803"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10804"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10805"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C212"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM NUMBER IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C21201"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item number_7140"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21202"" type=""EDIFACT_ID_7143"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item number type, coded_7143"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21203"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21204"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C212_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM NUMBER IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C21201"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item number_7140"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21202"" type=""EDIFACT_ID_7143"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item number type, coded_7143"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21203"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21204"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C212_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM NUMBER IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C21201"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item number_7140"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21202"" type=""EDIFACT_ID_7143"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item number type, coded_7143"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21203"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21204"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C212_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM NUMBER IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C21201"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item number_7140"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21202"" type=""EDIFACT_ID_7143"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item number type, coded_7143"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21203"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21204"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C212_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM NUMBER IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C21201"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item number_7140"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21202"" type=""EDIFACT_ID_7143"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item number type, coded_7143"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21203"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21204"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C212_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM NUMBER IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C21201"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item number_7140"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21202"" type=""EDIFACT_ID_7143"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item number type, coded_7143"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21203"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21204"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C273_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ITEM DESCRIPTION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C27301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item description identification_7009"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""7"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C27302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C27303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C27304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item description_7008"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C27305"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item description_7008"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C502_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENT DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C50201"" type=""EDIFACT_ID_6313"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement dimension, coded_6313"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50202"" type=""EDIFACT_ID_6321"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement significance, coded_6321"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50203"" type=""EDIFACT_ID_6155"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement attribute, coded_6155"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C174_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""VALUE/RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C17401"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C17402"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement value_6314"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C17403"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range minimum_6162"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C17404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range maximum_6152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C186_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C18601"" type=""EDIFACT_ID_6063"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity qualifier_6063"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C18602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity_6060"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C18603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C501_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50101"" type=""EDIFACT_ID_5245"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage qualifier_5245"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50102"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage_5482"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50103"" type=""EDIFACT_ID_5249"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage basis, coded_5249"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50104"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50105"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_13"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C516_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C51601"" type=""EDIFACT_ID_5025"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount type qualifier_5025"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount_5004"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency, coded_6345"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51604"" type=""EDIFACT_ID_6343"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency qualifier_6343"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51605"" type=""EDIFACT_ID_4405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Status, coded_4405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C208_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C208_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C208_8"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C208_9"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C208_10"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C206"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTIFICATION NUMBER"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20601"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20602"" type=""EDIFACT_ID_7405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number qualifier_7405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C206_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTIFICATION NUMBER"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20601"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20602"" type=""EDIFACT_ID_7405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number qualifier_7405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C206_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTIFICATION NUMBER"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20601"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20602"" type=""EDIFACT_ID_7405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number qualifier_7405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C206_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTIFICATION NUMBER"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20601"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20602"" type=""EDIFACT_ID_7405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number qualifier_7405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C206_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTIFICATION NUMBER"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20601"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20602"" type=""EDIFACT_ID_7405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number qualifier_7405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C279"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY DIFFERENCE INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C27901"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity difference_6064"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C27902"" type=""EDIFACT_ID_6063"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity qualifier_6063"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C262_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REASON FOR CHANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C26201"" type=""EDIFACT_ID_4295"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Change reason, coded_4295"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C26202"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Change reason_4294"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C002_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE NAME"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C00201"" type=""EDIFACT_ID_1001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message name, coded_1001"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00202"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00203"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message name_1000"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C503_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C50301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message number_1004"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50302"" type=""EDIFACT_ID_1373"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message status, coded_1373"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50303"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message source_1366"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Language, coded_3453"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C534_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PAYMENT INSTRUCTION DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C53401"" type=""EDIFACT_ID_4439"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Payment conditions, coded_4439"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53402"" type=""EDIFACT_ID_4431"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Payment guarantee, coded_4431"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53403"" type=""EDIFACT_ID_4461"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Payment means, coded_4461"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53404"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53405"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53406"" type=""EDIFACT_ID_4435"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Payment channel, coded_4435"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C107_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C10701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text, coded_4441"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C108_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT LITERAL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C10801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10803"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10804"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10805"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C110_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PAYMENT TERMS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C11001"" type=""EDIFACT_ID_4277"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Terms of payment identification_4277"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C11002"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C11003"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C11004"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Terms of payment_4276"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C11005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Terms of payment_4276"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C112_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TERMS/TIME INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C11201"" type=""EDIFACT_ID_2475"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Payment time reference, coded_2475"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C11202"" type=""EDIFACT_ID_2009"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Time relation, coded_2009"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C11203"" type=""EDIFACT_ID_2151"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of period, coded_2151"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C11204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Number of periods_2152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_14"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C501_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50101"" type=""EDIFACT_ID_5245"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage qualifier_5245"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50102"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage_5482"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50103"" type=""EDIFACT_ID_5249"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage basis, coded_5249"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50104"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50105"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C516_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C51601"" type=""EDIFACT_ID_5025"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount type qualifier_5025"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount_5004"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency, coded_6345"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51604"" type=""EDIFACT_ID_6343"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency qualifier_6343"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51605"" type=""EDIFACT_ID_4405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Status, coded_4405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C509"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PRICE INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50901"" type=""EDIFACT_ID_5125"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Price qualifier_5125"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50902"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Price_5118"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50903"" type=""EDIFACT_ID_5375"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Price type, coded_5375"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50904"" type=""EDIFACT_ID_5387"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Price type qualifier_5387"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50905"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit price basis_5284"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""9"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50906"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C504_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CURRENCY DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50401"" type=""EDIFACT_ID_6347"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency details qualifier_6347"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50402"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency, coded_6345"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50403"" type=""EDIFACT_ID_6343"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency qualifier_6343"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency rate base_6348"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""4"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C504_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CURRENCY DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50401"" type=""EDIFACT_ID_6347"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency details qualifier_6347"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50402"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency, coded_6345"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50403"" type=""EDIFACT_ID_6343"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency qualifier_6343"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency rate base_6348"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""4"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C138_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PRICE MULTIPLIER INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C13801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Price multiplier_5394"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""12"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C13802"" type=""EDIFACT_ID_5393"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Price multiplier qualifier_5393"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C262_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REASON FOR CHANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C26201"" type=""EDIFACT_ID_4295"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Change reason, coded_4295"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C26202"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Change reason_4294"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C280_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C28001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range minimum_6162"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28003"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range maximum_6152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_15"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C506_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50601"" type=""EDIFACT_ID_1153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference qualifier_1153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference number_1154"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Line number_1156"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50604"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference version number_4000"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_16"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C531_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGING DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C53101"" type=""EDIFACT_ID_7075"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Packaging level, coded_7075"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53102"" type=""EDIFACT_ID_7233"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Packaging related information, coded_7233"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53103"" type=""EDIFACT_ID_7073"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Packaging terms and conditions, coded_7073"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C202_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGE TYPE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C20201"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of packages identification_7065"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""7"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20202"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20203"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of packages_7064"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C402_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PACKAGE TYPE IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C40201"" type=""EDIFACT_ID_7077"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item description type, coded_7077"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C40202"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of packages_7064"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C40203"" type=""EDIFACT_ID_7143"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item number type, coded_7143"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C40204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of packages_7064"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C40205"" type=""EDIFACT_ID_7143"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Item number type, coded_7143"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C532_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RETURNABLE PACKAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C53201"" type=""EDIFACT_ID_8395"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Returnable package freight payment responsibility, coded_8395"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53202"" type=""EDIFACT_ID_8393"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Returnable package load contents, coded_8393"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C502_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENT DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C50201"" type=""EDIFACT_ID_6313"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement dimension, coded_6313"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50202"" type=""EDIFACT_ID_6321"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement significance, coded_6321"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50203"" type=""EDIFACT_ID_6155"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement attribute, coded_6155"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C174_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""VALUE/RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C17401"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C17402"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement value_6314"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C17403"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range minimum_6162"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C17404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range maximum_6152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C186_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C18601"" type=""EDIFACT_ID_6063"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity qualifier_6063"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C18602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity_6060"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C18603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_17"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C506_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50601"" type=""EDIFACT_ID_1153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference qualifier_1153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference number_1154"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Line number_1156"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50604"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference version number_4000"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_18"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C210_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MARKS &amp; LABELS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C21001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21003"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21004"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21006"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21007"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21008"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21009"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21010"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Shipping marks_7102"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C506_8"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50601"" type=""EDIFACT_ID_1153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference qualifier_1153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference number_1154"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Line number_1156"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50604"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference version number_4000"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_19"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C208_11"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C208_12"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C208_13"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C208_14"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C208_15"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""IDENTITY NUMBER RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C20801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C20802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Identity number_7402"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C517_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location identification_3225"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51704"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location_3224"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C519_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51901"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one identification_3223"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51902"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51903"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51904"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one_3222"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C553_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C55301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two identification_3233"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two_3232"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C186_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C18601"" type=""EDIFACT_ID_6063"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity qualifier_6063"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C18602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity_6060"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C18603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_20"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C241_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE TYPE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C24101"" type=""EDIFACT_ID_5153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee type, coded_5153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24102"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24103"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24104"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee type_5152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C533_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE ACCOUNT DETAIL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C53301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee account identification_5289"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C243_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE DETAIL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C24301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee rate identification_5279"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""7"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee rate_5278"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24305"" type=""EDIFACT_ID_5273"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee rate basis identification_5273"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24306"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24307"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C516_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C51601"" type=""EDIFACT_ID_5025"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount type qualifier_5025"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount_5004"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency, coded_6345"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51604"" type=""EDIFACT_ID_6343"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency qualifier_6343"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51605"" type=""EDIFACT_ID_4405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Status, coded_4405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C517_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location identification_3225"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51704"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location_3224"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C519_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51901"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one identification_3223"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51902"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51903"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51904"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one_3222"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C553_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C55301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two identification_3233"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two_3232"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C082_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PARTY IDENTIFICATION DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C08201"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party id identification_3039"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08202"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08203"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C058_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""NAME AND ADDRESS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C05801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Name and address line_3124"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C05802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Name and address line_3124"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C05803"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Name and address line_3124"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C05804"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Name and address line_3124"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C05805"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Name and address line_3124"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C080_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PARTY NAME"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C08001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party name_3036"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party name_3036"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08003"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party name_3036"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08004"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party name_3036"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party name_3036"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C08006"" type=""EDIFACT_ID_3045"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Party name format, coded_3045"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C059_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""STREET"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C05901"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Street and number/p.o. box_3042"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C05902"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Street and number/p.o. box_3042"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C05903"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Street and number/p.o. box_3042"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C517_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location identification_3225"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51704"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location_3224"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C519_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51901"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one identification_3223"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51902"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51903"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51904"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one_3222"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C553_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C55301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two identification_3233"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two_3232"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C506_9"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50601"" type=""EDIFACT_ID_1153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference qualifier_1153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference number_1154"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Line number_1156"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50604"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference version number_4000"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_21"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C002_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE NAME"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C00201"" type=""EDIFACT_ID_1001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message name, coded_1001"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00202"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00203"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C00204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message name_1000"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C503_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DOCUMENT/MESSAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C50301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message number_1004"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50302"" type=""EDIFACT_ID_1373"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message status, coded_1373"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50303"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Document/message source_1366"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Language, coded_3453"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_22"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C056_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DEPARTMENT OR EMPLOYEE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C05601"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Department or employee identification_3413"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C05602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Department or employee_3412"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C076_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""COMMUNICATION CONTACT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C07601"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Communication number_3148"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element name=""C07602"" type=""EDIFACT_ID_3155"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Communication channel qualifier_3155"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C552_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ALLOWANCE/CHARGE INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C55201"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or charge number_1230"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55202"" type=""EDIFACT_ID_5189"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Charge/allowance description, coded_5189"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C214_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""SPECIAL SERVICES IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C21401"" type=""EDIFACT_ID_7161"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special services, coded_7161"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21402"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21403"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special service_7160"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_23"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C186_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C18601"" type=""EDIFACT_ID_6063"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity qualifier_6063"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C18602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity_6060"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C18603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C280_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C28001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range minimum_6162"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28003"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range maximum_6152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C501_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PERCENTAGE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50101"" type=""EDIFACT_ID_5245"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage qualifier_5245"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50102"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage_5482"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50103"" type=""EDIFACT_ID_5249"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Percentage basis, coded_5249"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50104"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50105"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C280_8"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C28001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range minimum_6162"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28003"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range maximum_6152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C516_8"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C51601"" type=""EDIFACT_ID_5025"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount type qualifier_5025"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount_5004"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency, coded_6345"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51604"" type=""EDIFACT_ID_6343"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency qualifier_6343"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51605"" type=""EDIFACT_ID_4405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Status, coded_4405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C280_9"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C28001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range minimum_6162"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28003"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range maximum_6152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C128_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RATE DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C12801"" type=""EDIFACT_ID_5419"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Rate type qualifier_5419"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C12802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Rate per unit_5420"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C12803"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Unit price basis_5284"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""9"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C12804"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C280_10"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C28001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range minimum_6162"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C28003"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range maximum_6152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C241_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE TYPE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C24101"" type=""EDIFACT_ID_5153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee type, coded_5153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24102"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24103"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24104"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee type_5152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C533_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE ACCOUNT DETAIL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C53301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee account identification_5289"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C53303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C243_4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DUTY/TAX/FEE DETAIL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C24301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee rate identification_5279"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""7"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee rate_5278"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24305"" type=""EDIFACT_ID_5273"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Duty/tax/fee rate basis identification_5273"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24306"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C24307"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C516_9"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C51601"" type=""EDIFACT_ID_5025"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount type qualifier_5025"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount_5004"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency, coded_6345"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51604"" type=""EDIFACT_ID_6343"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency qualifier_6343"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51605"" type=""EDIFACT_ID_4405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Status, coded_4405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C220_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MODE OF TRANSPORT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C22001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Mode of transport, coded_8067"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Mode of transport_8066"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C228_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TRANSPORT MEANS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C22801"" type=""EDIFACT_ID_8179"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of means of transport identification_8179"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Type of means of transport_8178"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C040_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CARRIER"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C04001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Carrier identification_3127"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04002"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04003"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C04004"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Carrier name_3128"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C401_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""EXCESS TRANSPORTATION INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C40101"" type=""EDIFACT_ID_8457"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Excess transportation reason, coded_8457"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C40102"" type=""EDIFACT_ID_8459"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Excess transportation responsibility, coded_8459"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C40103"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Customer authorization number_7130"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C222_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TRANSPORT IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C22201"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Id of means of transport identification_8213"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""9"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22202"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22203"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22204"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Id of the means of transport_8212"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22205"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Nationality of means of transport, coded_8453"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C517_8"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location identification_3225"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51704"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location_3224"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C519_8"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51901"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one identification_3223"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51902"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51903"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51904"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one_3222"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C553_8"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C55301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two identification_3233"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two_3232"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_24"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C100_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TERMS OF DELIVERY"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C10001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Terms of delivery, coded_4053"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10002"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10003"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10004"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Terms of delivery_4052"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Terms of delivery_4052"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C517_9"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""LOCATION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location identification_3225"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51704"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Place/location_3224"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C519_9"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION ONE IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C51901"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one identification_3223"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51902"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51903"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51904"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location one_3222"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C553_9"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""RELATED LOCATION TWO IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C55301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two identification_3233"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""25"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55302"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55303"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55304"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Related place/location two_3232"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C237_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""EQUIPMENT IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C23701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment identification number_8260"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C23702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C23703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C224_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""EQUIPMENT SIZE AND TYPE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C22401"" type=""EDIFACT_ID_8155"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment size and type identification_8155"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22402"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22403"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C22404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Equipment size and type_8154"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C524_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""HANDLING INSTRUCTIONS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C52401"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Handling instructions, coded_4079"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C52402"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C52403"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C52404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Handling instructions_4078"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C218_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""HAZARDOUS MATERIAL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C21801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Hazardous material class code, identification_7419"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""4"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21802"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21803"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C502_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MEASUREMENT DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C50201"" type=""EDIFACT_ID_6313"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement dimension, coded_6313"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50202"" type=""EDIFACT_ID_6321"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement significance, coded_6321"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50203"" type=""EDIFACT_ID_6155"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement attribute, coded_6155"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C174_5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""VALUE/RANGE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C17401"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C17402"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measurement value_6314"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C17403"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range minimum_6162"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C17404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Range maximum_6152"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C107_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C10701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text, coded_4441"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C108_6"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT LITERAL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C10801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10803"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10804"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10805"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C329_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""PATTERN DESCRIPTION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C32901"" type=""EDIFACT_ID_2013"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Frequency, coded_2013"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C32902"" type=""EDIFACT_ID_2015"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Despatch pattern, coded_2015"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C32903"" type=""EDIFACT_ID_2017"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Despatch pattern timing, coded_2017"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C107_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C10701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text, coded_4441"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C108_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT LITERAL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C10801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10803"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10804"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10805"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C506_10"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50601"" type=""EDIFACT_ID_1153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference qualifier_1153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference number_1154"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Line number_1156"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50604"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference version number_4000"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C186_7"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""QUANTITY DETAILS"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C18601"" type=""EDIFACT_ID_6063"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity qualifier_6063"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C18602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Quantity_6060"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""15"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C18603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_25"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C550_2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REQUIREMENT/CONDITION IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C55001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Requirement/condition identification_7295"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""17"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55002"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55003"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C506_11"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50601"" type=""EDIFACT_ID_1153"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference qualifier_1153"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference number_1154"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Line number_1156"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50604"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Reference version number_4000"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C507_26"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""DATE/TIME/PERIOD"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C50701"" type=""EDIFACT_ID_2005"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period qualifier_2005"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50702"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period_2380"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C50703"" type=""EDIFACT_ID_2379"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Date/time/period format qualifier_2379"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C107_8"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT REFERENCE"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C10701"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text, coded_4441"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10702"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10703"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C108_8"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""TEXT LITERAL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C10801"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10802"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10803"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10804"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C10805"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Free text_4440"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""70"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C516_10"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C51601"" type=""EDIFACT_ID_5025"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount type qualifier_5025"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount_5004"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency, coded_6345"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51604"" type=""EDIFACT_ID_6343"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency qualifier_6343"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51605"" type=""EDIFACT_ID_4405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Status, coded_4405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C270"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""CONTROL"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C27001"" type=""EDIFACT_ID_6069"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Control qualifier_6069"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""C27002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Control value_6066"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C27003"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Measure unit qualifier_6411"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C552_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""ALLOWANCE/CHARGE INFORMATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""C55201"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Allowance or charge number_1230"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C55202"" type=""EDIFACT_ID_5189"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Charge/allowance description, coded_5189"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C214_3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""SPECIAL SERVICES IDENTIFICATION"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C21401"" type=""EDIFACT_ID_7161"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special services, coded_7161"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21402"" type=""EDIFACT_ID_1131"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list qualifier_1131"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21403"" type=""EDIFACT_ID_3055"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Code list responsible agency, coded_3055"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C21404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Special service_7160"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""35"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C516_11"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" escape_type=""inherit_escape"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""MONETARY AMOUNT"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C51601"" type=""EDIFACT_ID_5025"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount type qualifier_5025"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51602"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Monetary amount_5004"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_N"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""18"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51603"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency, coded_6345"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""EDIFACT_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51604"" type=""EDIFACT_ID_6343"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Currency qualifier_6343"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C51605"" type=""EDIFACT_ID_4405"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Status, coded_4405"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:simpleType name=""EDIFACT_ID_1001"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""105"" />
      <xs:enumeration value=""110"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""120"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""130"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""140"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""150"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""190"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""201"" />
      <xs:enumeration value=""202"" />
      <xs:enumeration value=""203"" />
      <xs:enumeration value=""204"" />
      <xs:enumeration value=""205"" />
      <xs:enumeration value=""206"" />
      <xs:enumeration value=""207"" />
      <xs:enumeration value=""208"" />
      <xs:enumeration value=""209"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""210"" />
      <xs:enumeration value=""211"" />
      <xs:enumeration value=""212"" />
      <xs:enumeration value=""215"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""220"" />
      <xs:enumeration value=""221"" />
      <xs:enumeration value=""222"" />
      <xs:enumeration value=""223"" />
      <xs:enumeration value=""224"" />
      <xs:enumeration value=""225"" />
      <xs:enumeration value=""226"" />
      <xs:enumeration value=""227"" />
      <xs:enumeration value=""228"" />
      <xs:enumeration value=""229"" />
      <xs:enumeration value=""230"" />
      <xs:enumeration value=""231"" />
      <xs:enumeration value=""232"" />
      <xs:enumeration value=""233"" />
      <xs:enumeration value=""240"" />
      <xs:enumeration value=""241"" />
      <xs:enumeration value=""242"" />
      <xs:enumeration value=""245"" />
      <xs:enumeration value=""270"" />
      <xs:enumeration value=""271"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""310"" />
      <xs:enumeration value=""311"" />
      <xs:enumeration value=""315"" />
      <xs:enumeration value=""320"" />
      <xs:enumeration value=""325"" />
      <xs:enumeration value=""326"" />
      <xs:enumeration value=""327"" />
      <xs:enumeration value=""328"" />
      <xs:enumeration value=""330"" />
      <xs:enumeration value=""335"" />
      <xs:enumeration value=""340"" />
      <xs:enumeration value=""341"" />
      <xs:enumeration value=""343"" />
      <xs:enumeration value=""345"" />
      <xs:enumeration value=""350"" />
      <xs:enumeration value=""351"" />
      <xs:enumeration value=""370"" />
      <xs:enumeration value=""380"" />
      <xs:enumeration value=""381"" />
      <xs:enumeration value=""382"" />
      <xs:enumeration value=""383"" />
      <xs:enumeration value=""384"" />
      <xs:enumeration value=""385"" />
      <xs:enumeration value=""386"" />
      <xs:enumeration value=""387"" />
      <xs:enumeration value=""388"" />
      <xs:enumeration value=""389"" />
      <xs:enumeration value=""390"" />
      <xs:enumeration value=""393"" />
      <xs:enumeration value=""394"" />
      <xs:enumeration value=""395"" />
      <xs:enumeration value=""396"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""409"" />
      <xs:enumeration value=""412"" />
      <xs:enumeration value=""425"" />
      <xs:enumeration value=""426"" />
      <xs:enumeration value=""427"" />
      <xs:enumeration value=""428"" />
      <xs:enumeration value=""429"" />
      <xs:enumeration value=""430"" />
      <xs:enumeration value=""431"" />
      <xs:enumeration value=""435"" />
      <xs:enumeration value=""447"" />
      <xs:enumeration value=""448"" />
      <xs:enumeration value=""450"" />
      <xs:enumeration value=""451"" />
      <xs:enumeration value=""452"" />
      <xs:enumeration value=""454"" />
      <xs:enumeration value=""455"" />
      <xs:enumeration value=""456"" />
      <xs:enumeration value=""457"" />
      <xs:enumeration value=""458"" />
      <xs:enumeration value=""460"" />
      <xs:enumeration value=""465"" />
      <xs:enumeration value=""466"" />
      <xs:enumeration value=""467"" />
      <xs:enumeration value=""468"" />
      <xs:enumeration value=""469"" />
      <xs:enumeration value=""481"" />
      <xs:enumeration value=""485"" />
      <xs:enumeration value=""490"" />
      <xs:enumeration value=""491"" />
      <xs:enumeration value=""492"" />
      <xs:enumeration value=""493"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""520"" />
      <xs:enumeration value=""530"" />
      <xs:enumeration value=""550"" />
      <xs:enumeration value=""575"" />
      <xs:enumeration value=""580"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""610"" />
      <xs:enumeration value=""621"" />
      <xs:enumeration value=""622"" />
      <xs:enumeration value=""623"" />
      <xs:enumeration value=""624"" />
      <xs:enumeration value=""630"" />
      <xs:enumeration value=""631"" />
      <xs:enumeration value=""632"" />
      <xs:enumeration value=""633"" />
      <xs:enumeration value=""635"" />
      <xs:enumeration value=""640"" />
      <xs:enumeration value=""650"" />
      <xs:enumeration value=""655"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""700"" />
      <xs:enumeration value=""701"" />
      <xs:enumeration value=""702"" />
      <xs:enumeration value=""703"" />
      <xs:enumeration value=""704"" />
      <xs:enumeration value=""705"" />
      <xs:enumeration value=""706"" />
      <xs:enumeration value=""707"" />
      <xs:enumeration value=""708"" />
      <xs:enumeration value=""709"" />
      <xs:enumeration value=""710"" />
      <xs:enumeration value=""711"" />
      <xs:enumeration value=""712"" />
      <xs:enumeration value=""713"" />
      <xs:enumeration value=""714"" />
      <xs:enumeration value=""715"" />
      <xs:enumeration value=""716"" />
      <xs:enumeration value=""720"" />
      <xs:enumeration value=""722"" />
      <xs:enumeration value=""723"" />
      <xs:enumeration value=""724"" />
      <xs:enumeration value=""730"" />
      <xs:enumeration value=""740"" />
      <xs:enumeration value=""741"" />
      <xs:enumeration value=""743"" />
      <xs:enumeration value=""744"" />
      <xs:enumeration value=""745"" />
      <xs:enumeration value=""746"" />
      <xs:enumeration value=""750"" />
      <xs:enumeration value=""760"" />
      <xs:enumeration value=""761"" />
      <xs:enumeration value=""763"" />
      <xs:enumeration value=""764"" />
      <xs:enumeration value=""765"" />
      <xs:enumeration value=""766"" />
      <xs:enumeration value=""770"" />
      <xs:enumeration value=""775"" />
      <xs:enumeration value=""780"" />
      <xs:enumeration value=""781"" />
      <xs:enumeration value=""782"" />
      <xs:enumeration value=""783"" />
      <xs:enumeration value=""784"" />
      <xs:enumeration value=""785"" />
      <xs:enumeration value=""786"" />
      <xs:enumeration value=""787"" />
      <xs:enumeration value=""788"" />
      <xs:enumeration value=""789"" />
      <xs:enumeration value=""790"" />
      <xs:enumeration value=""791"" />
      <xs:enumeration value=""792"" />
      <xs:enumeration value=""793"" />
      <xs:enumeration value=""794"" />
      <xs:enumeration value=""795"" />
      <xs:enumeration value=""796"" />
      <xs:enumeration value=""797"" />
      <xs:enumeration value=""798"" />
      <xs:enumeration value=""799"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""810"" />
      <xs:enumeration value=""811"" />
      <xs:enumeration value=""812"" />
      <xs:enumeration value=""820"" />
      <xs:enumeration value=""821"" />
      <xs:enumeration value=""822"" />
      <xs:enumeration value=""823"" />
      <xs:enumeration value=""824"" />
      <xs:enumeration value=""825"" />
      <xs:enumeration value=""830"" />
      <xs:enumeration value=""833"" />
      <xs:enumeration value=""840"" />
      <xs:enumeration value=""841"" />
      <xs:enumeration value=""850"" />
      <xs:enumeration value=""851"" />
      <xs:enumeration value=""852"" />
      <xs:enumeration value=""853"" />
      <xs:enumeration value=""855"" />
      <xs:enumeration value=""856"" />
      <xs:enumeration value=""860"" />
      <xs:enumeration value=""861"" />
      <xs:enumeration value=""862"" />
      <xs:enumeration value=""863"" />
      <xs:enumeration value=""864"" />
      <xs:enumeration value=""865"" />
      <xs:enumeration value=""870"" />
      <xs:enumeration value=""890"" />
      <xs:enumeration value=""895"" />
      <xs:enumeration value=""896"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""901"" />
      <xs:enumeration value=""910"" />
      <xs:enumeration value=""911"" />
      <xs:enumeration value=""913"" />
      <xs:enumeration value=""914"" />
      <xs:enumeration value=""915"" />
      <xs:enumeration value=""916"" />
      <xs:enumeration value=""917"" />
      <xs:enumeration value=""925"" />
      <xs:enumeration value=""926"" />
      <xs:enumeration value=""927"" />
      <xs:enumeration value=""929"" />
      <xs:enumeration value=""930"" />
      <xs:enumeration value=""931"" />
      <xs:enumeration value=""932"" />
      <xs:enumeration value=""933"" />
      <xs:enumeration value=""934"" />
      <xs:enumeration value=""935"" />
      <xs:enumeration value=""936"" />
      <xs:enumeration value=""937"" />
      <xs:enumeration value=""938"" />
      <xs:enumeration value=""940"" />
      <xs:enumeration value=""941"" />
      <xs:enumeration value=""950"" />
      <xs:enumeration value=""951"" />
      <xs:enumeration value=""952"" />
      <xs:enumeration value=""953"" />
      <xs:enumeration value=""954"" />
      <xs:enumeration value=""955"" />
      <xs:enumeration value=""960"" />
      <xs:enumeration value=""961"" />
      <xs:enumeration value=""962"" />
      <xs:enumeration value=""963"" />
      <xs:enumeration value=""964"" />
      <xs:enumeration value=""965"" />
      <xs:enumeration value=""966"" />
      <xs:enumeration value=""990"" />
      <xs:enumeration value=""991"" />
      <xs:enumeration value=""995"" />
      <xs:enumeration value=""996"" />
      <xs:enumeration value=""998"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_1131"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""100"" />
      <xs:enumeration value=""101"" />
      <xs:enumeration value=""102"" />
      <xs:enumeration value=""103"" />
      <xs:enumeration value=""104"" />
      <xs:enumeration value=""105"" />
      <xs:enumeration value=""106"" />
      <xs:enumeration value=""107"" />
      <xs:enumeration value=""108"" />
      <xs:enumeration value=""109"" />
      <xs:enumeration value=""110"" />
      <xs:enumeration value=""112"" />
      <xs:enumeration value=""113"" />
      <xs:enumeration value=""114"" />
      <xs:enumeration value=""115"" />
      <xs:enumeration value=""116"" />
      <xs:enumeration value=""117"" />
      <xs:enumeration value=""118"" />
      <xs:enumeration value=""119"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""120"" />
      <xs:enumeration value=""121"" />
      <xs:enumeration value=""122"" />
      <xs:enumeration value=""123"" />
      <xs:enumeration value=""125"" />
      <xs:enumeration value=""126"" />
      <xs:enumeration value=""127"" />
      <xs:enumeration value=""128"" />
      <xs:enumeration value=""129"" />
      <xs:enumeration value=""130"" />
      <xs:enumeration value=""131"" />
      <xs:enumeration value=""132"" />
      <xs:enumeration value=""133"" />
      <xs:enumeration value=""134"" />
      <xs:enumeration value=""135"" />
      <xs:enumeration value=""136"" />
      <xs:enumeration value=""137"" />
      <xs:enumeration value=""139"" />
      <xs:enumeration value=""140"" />
      <xs:enumeration value=""141"" />
      <xs:enumeration value=""142"" />
      <xs:enumeration value=""143"" />
      <xs:enumeration value=""144"" />
      <xs:enumeration value=""145"" />
      <xs:enumeration value=""146"" />
      <xs:enumeration value=""147"" />
      <xs:enumeration value=""148"" />
      <xs:enumeration value=""149"" />
      <xs:enumeration value=""150"" />
      <xs:enumeration value=""151"" />
      <xs:enumeration value=""152"" />
      <xs:enumeration value=""153"" />
      <xs:enumeration value=""154"" />
      <xs:enumeration value=""155"" />
      <xs:enumeration value=""156"" />
      <xs:enumeration value=""157"" />
      <xs:enumeration value=""158"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""160"" />
      <xs:enumeration value=""161"" />
      <xs:enumeration value=""162"" />
      <xs:enumeration value=""163"" />
      <xs:enumeration value=""164"" />
      <xs:enumeration value=""165"" />
      <xs:enumeration value=""166"" />
      <xs:enumeration value=""167"" />
      <xs:enumeration value=""168"" />
      <xs:enumeration value=""169"" />
      <xs:enumeration value=""170"" />
      <xs:enumeration value=""171"" />
      <xs:enumeration value=""172"" />
      <xs:enumeration value=""173"" />
      <xs:enumeration value=""174"" />
      <xs:enumeration value=""175"" />
      <xs:enumeration value=""176"" />
      <xs:enumeration value=""177"" />
      <xs:enumeration value=""178"" />
      <xs:enumeration value=""179"" />
      <xs:enumeration value=""180"" />
      <xs:enumeration value=""181"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_3055"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""100"" />
      <xs:enumeration value=""101"" />
      <xs:enumeration value=""102"" />
      <xs:enumeration value=""103"" />
      <xs:enumeration value=""104"" />
      <xs:enumeration value=""105"" />
      <xs:enumeration value=""106"" />
      <xs:enumeration value=""107"" />
      <xs:enumeration value=""108"" />
      <xs:enumeration value=""109"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""110"" />
      <xs:enumeration value=""111"" />
      <xs:enumeration value=""112"" />
      <xs:enumeration value=""113"" />
      <xs:enumeration value=""114"" />
      <xs:enumeration value=""115"" />
      <xs:enumeration value=""116"" />
      <xs:enumeration value=""117"" />
      <xs:enumeration value=""118"" />
      <xs:enumeration value=""119"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""120"" />
      <xs:enumeration value=""121"" />
      <xs:enumeration value=""122"" />
      <xs:enumeration value=""123"" />
      <xs:enumeration value=""124"" />
      <xs:enumeration value=""125"" />
      <xs:enumeration value=""126"" />
      <xs:enumeration value=""128"" />
      <xs:enumeration value=""129"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""130"" />
      <xs:enumeration value=""131"" />
      <xs:enumeration value=""132"" />
      <xs:enumeration value=""133"" />
      <xs:enumeration value=""134"" />
      <xs:enumeration value=""135"" />
      <xs:enumeration value=""136"" />
      <xs:enumeration value=""137"" />
      <xs:enumeration value=""138"" />
      <xs:enumeration value=""139"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""140"" />
      <xs:enumeration value=""141"" />
      <xs:enumeration value=""142"" />
      <xs:enumeration value=""143"" />
      <xs:enumeration value=""144"" />
      <xs:enumeration value=""145"" />
      <xs:enumeration value=""146"" />
      <xs:enumeration value=""147"" />
      <xs:enumeration value=""148"" />
      <xs:enumeration value=""149"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""150"" />
      <xs:enumeration value=""151"" />
      <xs:enumeration value=""152"" />
      <xs:enumeration value=""153"" />
      <xs:enumeration value=""154"" />
      <xs:enumeration value=""155"" />
      <xs:enumeration value=""156"" />
      <xs:enumeration value=""157"" />
      <xs:enumeration value=""158"" />
      <xs:enumeration value=""159"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""160"" />
      <xs:enumeration value=""161"" />
      <xs:enumeration value=""162"" />
      <xs:enumeration value=""163"" />
      <xs:enumeration value=""164"" />
      <xs:enumeration value=""165"" />
      <xs:enumeration value=""166"" />
      <xs:enumeration value=""167"" />
      <xs:enumeration value=""168"" />
      <xs:enumeration value=""169"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""170"" />
      <xs:enumeration value=""171"" />
      <xs:enumeration value=""172"" />
      <xs:enumeration value=""173"" />
      <xs:enumeration value=""174"" />
      <xs:enumeration value=""175"" />
      <xs:enumeration value=""176"" />
      <xs:enumeration value=""177"" />
      <xs:enumeration value=""178"" />
      <xs:enumeration value=""179"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""181"" />
      <xs:enumeration value=""182"" />
      <xs:enumeration value=""183"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""86"" />
      <xs:enumeration value=""87"" />
      <xs:enumeration value=""88"" />
      <xs:enumeration value=""89"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""96"" />
      <xs:enumeration value=""97"" />
      <xs:enumeration value=""98"" />
      <xs:enumeration value=""99"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_1225"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4343"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""RE"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_2005"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""101"" />
      <xs:enumeration value=""107"" />
      <xs:enumeration value=""108"" />
      <xs:enumeration value=""109"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""110"" />
      <xs:enumeration value=""111"" />
      <xs:enumeration value=""113"" />
      <xs:enumeration value=""114"" />
      <xs:enumeration value=""115"" />
      <xs:enumeration value=""117"" />
      <xs:enumeration value=""119"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""123"" />
      <xs:enumeration value=""124"" />
      <xs:enumeration value=""125"" />
      <xs:enumeration value=""126"" />
      <xs:enumeration value=""128"" />
      <xs:enumeration value=""129"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""131"" />
      <xs:enumeration value=""132"" />
      <xs:enumeration value=""133"" />
      <xs:enumeration value=""134"" />
      <xs:enumeration value=""135"" />
      <xs:enumeration value=""136"" />
      <xs:enumeration value=""137"" />
      <xs:enumeration value=""138"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""140"" />
      <xs:enumeration value=""141"" />
      <xs:enumeration value=""143"" />
      <xs:enumeration value=""144"" />
      <xs:enumeration value=""146"" />
      <xs:enumeration value=""147"" />
      <xs:enumeration value=""148"" />
      <xs:enumeration value=""149"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""150"" />
      <xs:enumeration value=""151"" />
      <xs:enumeration value=""152"" />
      <xs:enumeration value=""153"" />
      <xs:enumeration value=""154"" />
      <xs:enumeration value=""155"" />
      <xs:enumeration value=""156"" />
      <xs:enumeration value=""157"" />
      <xs:enumeration value=""158"" />
      <xs:enumeration value=""159"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""160"" />
      <xs:enumeration value=""161"" />
      <xs:enumeration value=""162"" />
      <xs:enumeration value=""163"" />
      <xs:enumeration value=""164"" />
      <xs:enumeration value=""165"" />
      <xs:enumeration value=""166"" />
      <xs:enumeration value=""167"" />
      <xs:enumeration value=""168"" />
      <xs:enumeration value=""169"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""170"" />
      <xs:enumeration value=""171"" />
      <xs:enumeration value=""172"" />
      <xs:enumeration value=""173"" />
      <xs:enumeration value=""174"" />
      <xs:enumeration value=""175"" />
      <xs:enumeration value=""176"" />
      <xs:enumeration value=""177"" />
      <xs:enumeration value=""178"" />
      <xs:enumeration value=""179"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""180"" />
      <xs:enumeration value=""181"" />
      <xs:enumeration value=""182"" />
      <xs:enumeration value=""183"" />
      <xs:enumeration value=""184"" />
      <xs:enumeration value=""185"" />
      <xs:enumeration value=""186"" />
      <xs:enumeration value=""187"" />
      <xs:enumeration value=""188"" />
      <xs:enumeration value=""189"" />
      <xs:enumeration value=""190"" />
      <xs:enumeration value=""191"" />
      <xs:enumeration value=""192"" />
      <xs:enumeration value=""193"" />
      <xs:enumeration value=""194"" />
      <xs:enumeration value=""195"" />
      <xs:enumeration value=""196"" />
      <xs:enumeration value=""197"" />
      <xs:enumeration value=""198"" />
      <xs:enumeration value=""199"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""200"" />
      <xs:enumeration value=""201"" />
      <xs:enumeration value=""202"" />
      <xs:enumeration value=""203"" />
      <xs:enumeration value=""204"" />
      <xs:enumeration value=""205"" />
      <xs:enumeration value=""206"" />
      <xs:enumeration value=""207"" />
      <xs:enumeration value=""208"" />
      <xs:enumeration value=""209"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""210"" />
      <xs:enumeration value=""211"" />
      <xs:enumeration value=""212"" />
      <xs:enumeration value=""213"" />
      <xs:enumeration value=""214"" />
      <xs:enumeration value=""215"" />
      <xs:enumeration value=""216"" />
      <xs:enumeration value=""218"" />
      <xs:enumeration value=""219"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""221"" />
      <xs:enumeration value=""222"" />
      <xs:enumeration value=""223"" />
      <xs:enumeration value=""224"" />
      <xs:enumeration value=""225"" />
      <xs:enumeration value=""226"" />
      <xs:enumeration value=""227"" />
      <xs:enumeration value=""228"" />
      <xs:enumeration value=""229"" />
      <xs:enumeration value=""230"" />
      <xs:enumeration value=""231"" />
      <xs:enumeration value=""232"" />
      <xs:enumeration value=""233"" />
      <xs:enumeration value=""234"" />
      <xs:enumeration value=""235"" />
      <xs:enumeration value=""236"" />
      <xs:enumeration value=""237"" />
      <xs:enumeration value=""238"" />
      <xs:enumeration value=""239"" />
      <xs:enumeration value=""240"" />
      <xs:enumeration value=""242"" />
      <xs:enumeration value=""243"" />
      <xs:enumeration value=""244"" />
      <xs:enumeration value=""245"" />
      <xs:enumeration value=""246"" />
      <xs:enumeration value=""247"" />
      <xs:enumeration value=""248"" />
      <xs:enumeration value=""249"" />
      <xs:enumeration value=""250"" />
      <xs:enumeration value=""251"" />
      <xs:enumeration value=""252"" />
      <xs:enumeration value=""253"" />
      <xs:enumeration value=""254"" />
      <xs:enumeration value=""255"" />
      <xs:enumeration value=""257"" />
      <xs:enumeration value=""258"" />
      <xs:enumeration value=""259"" />
      <xs:enumeration value=""260"" />
      <xs:enumeration value=""261"" />
      <xs:enumeration value=""262"" />
      <xs:enumeration value=""263"" />
      <xs:enumeration value=""264"" />
      <xs:enumeration value=""265"" />
      <xs:enumeration value=""266"" />
      <xs:enumeration value=""267"" />
      <xs:enumeration value=""268"" />
      <xs:enumeration value=""269"" />
      <xs:enumeration value=""270"" />
      <xs:enumeration value=""271"" />
      <xs:enumeration value=""272"" />
      <xs:enumeration value=""273"" />
      <xs:enumeration value=""274"" />
      <xs:enumeration value=""275"" />
      <xs:enumeration value=""276"" />
      <xs:enumeration value=""277"" />
      <xs:enumeration value=""278"" />
      <xs:enumeration value=""279"" />
      <xs:enumeration value=""280"" />
      <xs:enumeration value=""281"" />
      <xs:enumeration value=""282"" />
      <xs:enumeration value=""283"" />
      <xs:enumeration value=""284"" />
      <xs:enumeration value=""285"" />
      <xs:enumeration value=""286"" />
      <xs:enumeration value=""287"" />
      <xs:enumeration value=""288"" />
      <xs:enumeration value=""290"" />
      <xs:enumeration value=""291"" />
      <xs:enumeration value=""292"" />
      <xs:enumeration value=""293"" />
      <xs:enumeration value=""294"" />
      <xs:enumeration value=""295"" />
      <xs:enumeration value=""296"" />
      <xs:enumeration value=""297"" />
      <xs:enumeration value=""298"" />
      <xs:enumeration value=""299"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""300"" />
      <xs:enumeration value=""301"" />
      <xs:enumeration value=""302"" />
      <xs:enumeration value=""303"" />
      <xs:enumeration value=""304"" />
      <xs:enumeration value=""305"" />
      <xs:enumeration value=""306"" />
      <xs:enumeration value=""307"" />
      <xs:enumeration value=""308"" />
      <xs:enumeration value=""309"" />
      <xs:enumeration value=""310"" />
      <xs:enumeration value=""311"" />
      <xs:enumeration value=""312"" />
      <xs:enumeration value=""313"" />
      <xs:enumeration value=""314"" />
      <xs:enumeration value=""315"" />
      <xs:enumeration value=""316"" />
      <xs:enumeration value=""317"" />
      <xs:enumeration value=""318"" />
      <xs:enumeration value=""319"" />
      <xs:enumeration value=""320"" />
      <xs:enumeration value=""321"" />
      <xs:enumeration value=""322"" />
      <xs:enumeration value=""323"" />
      <xs:enumeration value=""324"" />
      <xs:enumeration value=""325"" />
      <xs:enumeration value=""326"" />
      <xs:enumeration value=""327"" />
      <xs:enumeration value=""328"" />
      <xs:enumeration value=""329"" />
      <xs:enumeration value=""330"" />
      <xs:enumeration value=""331"" />
      <xs:enumeration value=""332"" />
      <xs:enumeration value=""333"" />
      <xs:enumeration value=""334"" />
      <xs:enumeration value=""335"" />
      <xs:enumeration value=""336"" />
      <xs:enumeration value=""337"" />
      <xs:enumeration value=""338"" />
      <xs:enumeration value=""339"" />
      <xs:enumeration value=""340"" />
      <xs:enumeration value=""341"" />
      <xs:enumeration value=""342"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""69"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""75"" />
      <xs:enumeration value=""76"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""84"" />
      <xs:enumeration value=""85"" />
      <xs:enumeration value=""89"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""96"" />
      <xs:enumeration value=""97"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_2379"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""101"" />
      <xs:enumeration value=""102"" />
      <xs:enumeration value=""103"" />
      <xs:enumeration value=""105"" />
      <xs:enumeration value=""106"" />
      <xs:enumeration value=""107"" />
      <xs:enumeration value=""108"" />
      <xs:enumeration value=""109"" />
      <xs:enumeration value=""110"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""201"" />
      <xs:enumeration value=""202"" />
      <xs:enumeration value=""203"" />
      <xs:enumeration value=""204"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""301"" />
      <xs:enumeration value=""302"" />
      <xs:enumeration value=""303"" />
      <xs:enumeration value=""304"" />
      <xs:enumeration value=""401"" />
      <xs:enumeration value=""402"" />
      <xs:enumeration value=""404"" />
      <xs:enumeration value=""501"" />
      <xs:enumeration value=""502"" />
      <xs:enumeration value=""503"" />
      <xs:enumeration value=""600"" />
      <xs:enumeration value=""601"" />
      <xs:enumeration value=""602"" />
      <xs:enumeration value=""603"" />
      <xs:enumeration value=""604"" />
      <xs:enumeration value=""608"" />
      <xs:enumeration value=""609"" />
      <xs:enumeration value=""610"" />
      <xs:enumeration value=""613"" />
      <xs:enumeration value=""614"" />
      <xs:enumeration value=""615"" />
      <xs:enumeration value=""616"" />
      <xs:enumeration value=""701"" />
      <xs:enumeration value=""702"" />
      <xs:enumeration value=""703"" />
      <xs:enumeration value=""704"" />
      <xs:enumeration value=""705"" />
      <xs:enumeration value=""706"" />
      <xs:enumeration value=""707"" />
      <xs:enumeration value=""708"" />
      <xs:enumeration value=""709"" />
      <xs:enumeration value=""710"" />
      <xs:enumeration value=""711"" />
      <xs:enumeration value=""713"" />
      <xs:enumeration value=""715"" />
      <xs:enumeration value=""716"" />
      <xs:enumeration value=""717"" />
      <xs:enumeration value=""718"" />
      <xs:enumeration value=""801"" />
      <xs:enumeration value=""802"" />
      <xs:enumeration value=""803"" />
      <xs:enumeration value=""804"" />
      <xs:enumeration value=""805"" />
      <xs:enumeration value=""806"" />
      <xs:enumeration value=""807"" />
      <xs:enumeration value=""808"" />
      <xs:enumeration value=""809"" />
      <xs:enumeration value=""810"" />
      <xs:enumeration value=""811"" />
      <xs:enumeration value=""812"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4439"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""69"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4431"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4461"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""75"" />
      <xs:enumeration value=""76"" />
      <xs:enumeration value=""77"" />
      <xs:enumeration value=""78"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""96"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4435"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_9213"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4183"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_7077"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""X"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_7081"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""68"" />
      <xs:enumeration value=""69"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_7383"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1S"" />
      <xs:enumeration value=""2S"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""LE"" />
      <xs:enumeration value=""OA"" />
      <xs:enumeration value=""OS"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""TB"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""UC"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4451"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AAA"" />
      <xs:enumeration value=""AAB"" />
      <xs:enumeration value=""AAC"" />
      <xs:enumeration value=""AAD"" />
      <xs:enumeration value=""AAG"" />
      <xs:enumeration value=""AAH"" />
      <xs:enumeration value=""AAI"" />
      <xs:enumeration value=""AAJ"" />
      <xs:enumeration value=""AAK"" />
      <xs:enumeration value=""AAL"" />
      <xs:enumeration value=""AAM"" />
      <xs:enumeration value=""AAN"" />
      <xs:enumeration value=""AAO"" />
      <xs:enumeration value=""AAP"" />
      <xs:enumeration value=""AAQ"" />
      <xs:enumeration value=""AAR"" />
      <xs:enumeration value=""AAS"" />
      <xs:enumeration value=""AAT"" />
      <xs:enumeration value=""AAU"" />
      <xs:enumeration value=""AAV"" />
      <xs:enumeration value=""AAW"" />
      <xs:enumeration value=""AAX"" />
      <xs:enumeration value=""AAY"" />
      <xs:enumeration value=""AAZ"" />
      <xs:enumeration value=""ABA"" />
      <xs:enumeration value=""ABJ"" />
      <xs:enumeration value=""ABL"" />
      <xs:enumeration value=""ABM"" />
      <xs:enumeration value=""ABN"" />
      <xs:enumeration value=""ABO"" />
      <xs:enumeration value=""ABP"" />
      <xs:enumeration value=""ABQ"" />
      <xs:enumeration value=""ABR"" />
      <xs:enumeration value=""ABS"" />
      <xs:enumeration value=""ABT"" />
      <xs:enumeration value=""ABU"" />
      <xs:enumeration value=""ABV"" />
      <xs:enumeration value=""ABW"" />
      <xs:enumeration value=""ABX"" />
      <xs:enumeration value=""ABY"" />
      <xs:enumeration value=""ABZ"" />
      <xs:enumeration value=""ACA"" />
      <xs:enumeration value=""ACB"" />
      <xs:enumeration value=""ACC"" />
      <xs:enumeration value=""ACD"" />
      <xs:enumeration value=""ACE"" />
      <xs:enumeration value=""ACF"" />
      <xs:enumeration value=""ALC"" />
      <xs:enumeration value=""ALL"" />
      <xs:enumeration value=""ARR"" />
      <xs:enumeration value=""AUT"" />
      <xs:enumeration value=""BLC"" />
      <xs:enumeration value=""BLR"" />
      <xs:enumeration value=""CCI"" />
      <xs:enumeration value=""CEX"" />
      <xs:enumeration value=""CHG"" />
      <xs:enumeration value=""CIP"" />
      <xs:enumeration value=""CLP"" />
      <xs:enumeration value=""CLR"" />
      <xs:enumeration value=""COI"" />
      <xs:enumeration value=""CUR"" />
      <xs:enumeration value=""CUS"" />
      <xs:enumeration value=""DAR"" />
      <xs:enumeration value=""DCL"" />
      <xs:enumeration value=""DEL"" />
      <xs:enumeration value=""DIN"" />
      <xs:enumeration value=""DOC"" />
      <xs:enumeration value=""DUT"" />
      <xs:enumeration value=""EUR"" />
      <xs:enumeration value=""FBC"" />
      <xs:enumeration value=""GBL"" />
      <xs:enumeration value=""GEN"" />
      <xs:enumeration value=""GS7"" />
      <xs:enumeration value=""HAN"" />
      <xs:enumeration value=""HAZ"" />
      <xs:enumeration value=""ICN"" />
      <xs:enumeration value=""IIN"" />
      <xs:enumeration value=""IMI"" />
      <xs:enumeration value=""IND"" />
      <xs:enumeration value=""INS"" />
      <xs:enumeration value=""INV"" />
      <xs:enumeration value=""IRP"" />
      <xs:enumeration value=""ITR"" />
      <xs:enumeration value=""ITS"" />
      <xs:enumeration value=""LIN"" />
      <xs:enumeration value=""LOI"" />
      <xs:enumeration value=""MCO"" />
      <xs:enumeration value=""MKS"" />
      <xs:enumeration value=""ORI"" />
      <xs:enumeration value=""OSI"" />
      <xs:enumeration value=""PAC"" />
      <xs:enumeration value=""PAI"" />
      <xs:enumeration value=""PAY"" />
      <xs:enumeration value=""PKG"" />
      <xs:enumeration value=""PKT"" />
      <xs:enumeration value=""PMD"" />
      <xs:enumeration value=""PMT"" />
      <xs:enumeration value=""PRD"" />
      <xs:enumeration value=""PRF"" />
      <xs:enumeration value=""PRI"" />
      <xs:enumeration value=""PUR"" />
      <xs:enumeration value=""QIN"" />
      <xs:enumeration value=""QQD"" />
      <xs:enumeration value=""QUT"" />
      <xs:enumeration value=""RAH"" />
      <xs:enumeration value=""REG"" />
      <xs:enumeration value=""RET"" />
      <xs:enumeration value=""REV"" />
      <xs:enumeration value=""RQR"" />
      <xs:enumeration value=""RQT"" />
      <xs:enumeration value=""SAF"" />
      <xs:enumeration value=""SIC"" />
      <xs:enumeration value=""SIN"" />
      <xs:enumeration value=""SLR"" />
      <xs:enumeration value=""SPA"" />
      <xs:enumeration value=""SPG"" />
      <xs:enumeration value=""SPH"" />
      <xs:enumeration value=""SPP"" />
      <xs:enumeration value=""SPT"" />
      <xs:enumeration value=""SRN"" />
      <xs:enumeration value=""SSR"" />
      <xs:enumeration value=""SUR"" />
      <xs:enumeration value=""TCA"" />
      <xs:enumeration value=""TDT"" />
      <xs:enumeration value=""TRA"" />
      <xs:enumeration value=""TRR"" />
      <xs:enumeration value=""TXD"" />
      <xs:enumeration value=""WHI"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4453"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_1153"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AAA"" />
      <xs:enumeration value=""AAB"" />
      <xs:enumeration value=""AAC"" />
      <xs:enumeration value=""AAD"" />
      <xs:enumeration value=""AAE"" />
      <xs:enumeration value=""AAG"" />
      <xs:enumeration value=""AAJ"" />
      <xs:enumeration value=""AAK"" />
      <xs:enumeration value=""AAL"" />
      <xs:enumeration value=""AAM"" />
      <xs:enumeration value=""AAN"" />
      <xs:enumeration value=""AAO"" />
      <xs:enumeration value=""AAP"" />
      <xs:enumeration value=""AAQ"" />
      <xs:enumeration value=""AAS"" />
      <xs:enumeration value=""AAT"" />
      <xs:enumeration value=""AAU"" />
      <xs:enumeration value=""AAV"" />
      <xs:enumeration value=""AAY"" />
      <xs:enumeration value=""AAZ"" />
      <xs:enumeration value=""ABA"" />
      <xs:enumeration value=""ABB"" />
      <xs:enumeration value=""ABC"" />
      <xs:enumeration value=""ABD"" />
      <xs:enumeration value=""ABE"" />
      <xs:enumeration value=""ABG"" />
      <xs:enumeration value=""ABH"" />
      <xs:enumeration value=""ABI"" />
      <xs:enumeration value=""ABJ"" />
      <xs:enumeration value=""ABK"" />
      <xs:enumeration value=""ABL"" />
      <xs:enumeration value=""ABO"" />
      <xs:enumeration value=""ABP"" />
      <xs:enumeration value=""ABQ"" />
      <xs:enumeration value=""ABR"" />
      <xs:enumeration value=""ABS"" />
      <xs:enumeration value=""ABT"" />
      <xs:enumeration value=""ABU"" />
      <xs:enumeration value=""ABW"" />
      <xs:enumeration value=""ABY"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""ACB"" />
      <xs:enumeration value=""ACC"" />
      <xs:enumeration value=""ACD"" />
      <xs:enumeration value=""ACE"" />
      <xs:enumeration value=""ACF"" />
      <xs:enumeration value=""ACG"" />
      <xs:enumeration value=""ACH"" />
      <xs:enumeration value=""ACI"" />
      <xs:enumeration value=""ACJ"" />
      <xs:enumeration value=""ACK"" />
      <xs:enumeration value=""ACL"" />
      <xs:enumeration value=""ACM"" />
      <xs:enumeration value=""ACN"" />
      <xs:enumeration value=""ACO"" />
      <xs:enumeration value=""ACP"" />
      <xs:enumeration value=""ACQ"" />
      <xs:enumeration value=""ACR"" />
      <xs:enumeration value=""ACS"" />
      <xs:enumeration value=""ACT"" />
      <xs:enumeration value=""ACU"" />
      <xs:enumeration value=""ACW"" />
      <xs:enumeration value=""ACX"" />
      <xs:enumeration value=""ADB"" />
      <xs:enumeration value=""ADC"" />
      <xs:enumeration value=""ADD"" />
      <xs:enumeration value=""ADE"" />
      <xs:enumeration value=""ADF"" />
      <xs:enumeration value=""ADG"" />
      <xs:enumeration value=""ADH"" />
      <xs:enumeration value=""ADI"" />
      <xs:enumeration value=""ADJ"" />
      <xs:enumeration value=""ADK"" />
      <xs:enumeration value=""ADP"" />
      <xs:enumeration value=""ADQ"" />
      <xs:enumeration value=""ADR"" />
      <xs:enumeration value=""ADS"" />
      <xs:enumeration value=""ADT"" />
      <xs:enumeration value=""ADU"" />
      <xs:enumeration value=""ADV"" />
      <xs:enumeration value=""ADW"" />
      <xs:enumeration value=""ADY"" />
      <xs:enumeration value=""ADZ"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AEA"" />
      <xs:enumeration value=""AEB"" />
      <xs:enumeration value=""AEC"" />
      <xs:enumeration value=""AED"" />
      <xs:enumeration value=""AEE"" />
      <xs:enumeration value=""AEF"" />
      <xs:enumeration value=""AEG"" />
      <xs:enumeration value=""AEH"" />
      <xs:enumeration value=""AEI"" />
      <xs:enumeration value=""AEJ"" />
      <xs:enumeration value=""AEK"" />
      <xs:enumeration value=""AEL"" />
      <xs:enumeration value=""AEN"" />
      <xs:enumeration value=""AEO"" />
      <xs:enumeration value=""AEP"" />
      <xs:enumeration value=""AEQ"" />
      <xs:enumeration value=""AER"" />
      <xs:enumeration value=""AES"" />
      <xs:enumeration value=""AET"" />
      <xs:enumeration value=""AEU"" />
      <xs:enumeration value=""AEV"" />
      <xs:enumeration value=""AEW"" />
      <xs:enumeration value=""AEX"" />
      <xs:enumeration value=""AEY"" />
      <xs:enumeration value=""AEZ"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AFA"" />
      <xs:enumeration value=""AFB"" />
      <xs:enumeration value=""AFC"" />
      <xs:enumeration value=""AFD"" />
      <xs:enumeration value=""AFE"" />
      <xs:enumeration value=""AFF"" />
      <xs:enumeration value=""AFG"" />
      <xs:enumeration value=""AFI"" />
      <xs:enumeration value=""AFJ"" />
      <xs:enumeration value=""AFK"" />
      <xs:enumeration value=""AFL"" />
      <xs:enumeration value=""AFM"" />
      <xs:enumeration value=""AFN"" />
      <xs:enumeration value=""AFO"" />
      <xs:enumeration value=""AFP"" />
      <xs:enumeration value=""AFQ"" />
      <xs:enumeration value=""AFR"" />
      <xs:enumeration value=""AFS"" />
      <xs:enumeration value=""AFT"" />
      <xs:enumeration value=""AFU"" />
      <xs:enumeration value=""AFV"" />
      <xs:enumeration value=""AFW"" />
      <xs:enumeration value=""AFX"" />
      <xs:enumeration value=""AFY"" />
      <xs:enumeration value=""AFZ"" />
      <xs:enumeration value=""AGA"" />
      <xs:enumeration value=""AGB"" />
      <xs:enumeration value=""AGC"" />
      <xs:enumeration value=""AGD"" />
      <xs:enumeration value=""AGE"" />
      <xs:enumeration value=""AGF"" />
      <xs:enumeration value=""AGG"" />
      <xs:enumeration value=""AGH"" />
      <xs:enumeration value=""AGI"" />
      <xs:enumeration value=""AGJ"" />
      <xs:enumeration value=""AGK"" />
      <xs:enumeration value=""AGL"" />
      <xs:enumeration value=""AGM"" />
      <xs:enumeration value=""AGN"" />
      <xs:enumeration value=""AGO"" />
      <xs:enumeration value=""AGP"" />
      <xs:enumeration value=""AGQ"" />
      <xs:enumeration value=""AGR"" />
      <xs:enumeration value=""AGS"" />
      <xs:enumeration value=""AGT"" />
      <xs:enumeration value=""AGU"" />
      <xs:enumeration value=""AGV"" />
      <xs:enumeration value=""AGW"" />
      <xs:enumeration value=""AGX"" />
      <xs:enumeration value=""AGY"" />
      <xs:enumeration value=""AGZ"" />
      <xs:enumeration value=""AHA"" />
      <xs:enumeration value=""AHB"" />
      <xs:enumeration value=""AHC"" />
      <xs:enumeration value=""AHD"" />
      <xs:enumeration value=""AHE"" />
      <xs:enumeration value=""AHF"" />
      <xs:enumeration value=""AHG"" />
      <xs:enumeration value=""AHH"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""ASC"" />
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""AWB"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BH"" />
      <xs:enumeration value=""BM"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""BW"" />
      <xs:enumeration value=""CAS"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CEC"" />
      <xs:enumeration value=""CFE"" />
      <xs:enumeration value=""CFO"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CKN"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CMR"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CNO"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""COF"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CRN"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CST"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""CV"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""CZ"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DAN"" />
      <xs:enumeration value=""DB"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DM"" />
      <xs:enumeration value=""DQ"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""EA"" />
      <xs:enumeration value=""EB"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EE"" />
      <xs:enumeration value=""EI"" />
      <xs:enumeration value=""EN"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""EQ"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""ERN"" />
      <xs:enumeration value=""ET"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FF"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""FLW"" />
      <xs:enumeration value=""FN"" />
      <xs:enumeration value=""FO"" />
      <xs:enumeration value=""FS"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""FV"" />
      <xs:enumeration value=""FX"" />
      <xs:enumeration value=""GA"" />
      <xs:enumeration value=""GC"" />
      <xs:enumeration value=""GD"" />
      <xs:enumeration value=""GDN"" />
      <xs:enumeration value=""GN"" />
      <xs:enumeration value=""HS"" />
      <xs:enumeration value=""HWB"" />
      <xs:enumeration value=""IA"" />
      <xs:enumeration value=""IB"" />
      <xs:enumeration value=""ICA"" />
      <xs:enumeration value=""ICE"" />
      <xs:enumeration value=""ICO"" />
      <xs:enumeration value=""II"" />
      <xs:enumeration value=""IL"" />
      <xs:enumeration value=""INB"" />
      <xs:enumeration value=""INN"" />
      <xs:enumeration value=""INO"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""IV"" />
      <xs:enumeration value=""JB"" />
      <xs:enumeration value=""JE"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""LAN"" />
      <xs:enumeration value=""LAR"" />
      <xs:enumeration value=""LB"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""LO"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MB"" />
      <xs:enumeration value=""MF"" />
      <xs:enumeration value=""MG"" />
      <xs:enumeration value=""MH"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""MRN"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""MSS"" />
      <xs:enumeration value=""MWB"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""OH"" />
      <xs:enumeration value=""OI"" />
      <xs:enumeration value=""ON"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""OR"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PK"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""POR"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PQ"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""PY"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RCN"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""REN"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SQ"" />
      <xs:enumeration value=""SRN"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""STA"" />
      <xs:enumeration value=""SW"" />
      <xs:enumeration value=""SZ"" />
      <xs:enumeration value=""TB"" />
      <xs:enumeration value=""TE"" />
      <xs:enumeration value=""TF"" />
      <xs:enumeration value=""TI"" />
      <xs:enumeration value=""TL"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""UAR"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UCN"" />
      <xs:enumeration value=""UN"" />
      <xs:enumeration value=""UO"" />
      <xs:enumeration value=""VA"" />
      <xs:enumeration value=""VC"" />
      <xs:enumeration value=""VM"" />
      <xs:enumeration value=""VN"" />
      <xs:enumeration value=""VON"" />
      <xs:enumeration value=""VP"" />
      <xs:enumeration value=""VR"" />
      <xs:enumeration value=""VS"" />
      <xs:enumeration value=""VT"" />
      <xs:enumeration value=""VV"" />
      <xs:enumeration value=""WE"" />
      <xs:enumeration value=""WM"" />
      <xs:enumeration value=""WN"" />
      <xs:enumeration value=""WR"" />
      <xs:enumeration value=""WS"" />
      <xs:enumeration value=""WY"" />
      <xs:enumeration value=""XA"" />
      <xs:enumeration value=""XC"" />
      <xs:enumeration value=""XP"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_3035"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AH"" />
      <xs:enumeration value=""AK"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AO"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AQ"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""AW"" />
      <xs:enumeration value=""AX"" />
      <xs:enumeration value=""AZ"" />
      <xs:enumeration value=""B1"" />
      <xs:enumeration value=""B2"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BB"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BF"" />
      <xs:enumeration value=""BG"" />
      <xs:enumeration value=""BH"" />
      <xs:enumeration value=""BI"" />
      <xs:enumeration value=""BK"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BM"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""BQ"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""BU"" />
      <xs:enumeration value=""BV"" />
      <xs:enumeration value=""BW"" />
      <xs:enumeration value=""BX"" />
      <xs:enumeration value=""BY"" />
      <xs:enumeration value=""BZ"" />
      <xs:enumeration value=""C1"" />
      <xs:enumeration value=""C2"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CJ"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""COP"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CPD"" />
      <xs:enumeration value=""CQ"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""CV"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""CX"" />
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""CZ"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DB"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""DCP"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""DG"" />
      <xs:enumeration value=""DH"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DJ"" />
      <xs:enumeration value=""DK"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DM"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""DP"" />
      <xs:enumeration value=""DQ"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""DU"" />
      <xs:enumeration value=""DV"" />
      <xs:enumeration value=""DW"" />
      <xs:enumeration value=""DX"" />
      <xs:enumeration value=""DY"" />
      <xs:enumeration value=""DZ"" />
      <xs:enumeration value=""EA"" />
      <xs:enumeration value=""EB"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EE"" />
      <xs:enumeration value=""EF"" />
      <xs:enumeration value=""EG"" />
      <xs:enumeration value=""EH"" />
      <xs:enumeration value=""EI"" />
      <xs:enumeration value=""EJ"" />
      <xs:enumeration value=""EK"" />
      <xs:enumeration value=""EL"" />
      <xs:enumeration value=""EM"" />
      <xs:enumeration value=""EN"" />
      <xs:enumeration value=""EO"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""EQ"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""ET"" />
      <xs:enumeration value=""EU"" />
      <xs:enumeration value=""EV"" />
      <xs:enumeration value=""EW"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""EY"" />
      <xs:enumeration value=""EZ"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FB"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FD"" />
      <xs:enumeration value=""FE"" />
      <xs:enumeration value=""FF"" />
      <xs:enumeration value=""FG"" />
      <xs:enumeration value=""FH"" />
      <xs:enumeration value=""FJ"" />
      <xs:enumeration value=""FK"" />
      <xs:enumeration value=""FL"" />
      <xs:enumeration value=""FM"" />
      <xs:enumeration value=""FN"" />
      <xs:enumeration value=""FO"" />
      <xs:enumeration value=""FP"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""FW"" />
      <xs:enumeration value=""GC"" />
      <xs:enumeration value=""GO"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""I1"" />
      <xs:enumeration value=""I2"" />
      <xs:enumeration value=""IB"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""II"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IO"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""IV"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""LP"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MF"" />
      <xs:enumeration value=""MG"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""MT"" />
      <xs:enumeration value=""N1"" />
      <xs:enumeration value=""N2"" />
      <xs:enumeration value=""NI"" />
      <xs:enumeration value=""OA"" />
      <xs:enumeration value=""OB"" />
      <xs:enumeration value=""OF"" />
      <xs:enumeration value=""OI"" />
      <xs:enumeration value=""OO"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""OR"" />
      <xs:enumeration value=""OS"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""OV"" />
      <xs:enumeration value=""OY"" />
      <xs:enumeration value=""P1"" />
      <xs:enumeration value=""P2"" />
      <xs:enumeration value=""P3"" />
      <xs:enumeration value=""P4"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PG"" />
      <xs:enumeration value=""PH"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PJ"" />
      <xs:enumeration value=""PK"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PM"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PQ"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""PX"" />
      <xs:enumeration value=""PY"" />
      <xs:enumeration value=""PZ"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RB"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RH"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""RM"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RV"" />
      <xs:enumeration value=""RW"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SG"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SK"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SO"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""SX"" />
      <xs:enumeration value=""SY"" />
      <xs:enumeration value=""SZ"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TCP"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UD"" />
      <xs:enumeration value=""UHP"" />
      <xs:enumeration value=""UP"" />
      <xs:enumeration value=""VN"" />
      <xs:enumeration value=""WD"" />
      <xs:enumeration value=""WH"" />
      <xs:enumeration value=""WM"" />
      <xs:enumeration value=""WPA"" />
      <xs:enumeration value=""WS"" />
      <xs:enumeration value=""XX"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_3045"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_3227"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""100"" />
      <xs:enumeration value=""101"" />
      <xs:enumeration value=""102"" />
      <xs:enumeration value=""103"" />
      <xs:enumeration value=""104"" />
      <xs:enumeration value=""105"" />
      <xs:enumeration value=""106"" />
      <xs:enumeration value=""107"" />
      <xs:enumeration value=""108"" />
      <xs:enumeration value=""109"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""110"" />
      <xs:enumeration value=""111"" />
      <xs:enumeration value=""113"" />
      <xs:enumeration value=""114"" />
      <xs:enumeration value=""115"" />
      <xs:enumeration value=""116"" />
      <xs:enumeration value=""118"" />
      <xs:enumeration value=""119"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""120"" />
      <xs:enumeration value=""121"" />
      <xs:enumeration value=""122"" />
      <xs:enumeration value=""123"" />
      <xs:enumeration value=""124"" />
      <xs:enumeration value=""125"" />
      <xs:enumeration value=""126"" />
      <xs:enumeration value=""127"" />
      <xs:enumeration value=""128"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""130"" />
      <xs:enumeration value=""131"" />
      <xs:enumeration value=""132"" />
      <xs:enumeration value=""133"" />
      <xs:enumeration value=""134"" />
      <xs:enumeration value=""135"" />
      <xs:enumeration value=""136"" />
      <xs:enumeration value=""137"" />
      <xs:enumeration value=""138"" />
      <xs:enumeration value=""139"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""140"" />
      <xs:enumeration value=""141"" />
      <xs:enumeration value=""142"" />
      <xs:enumeration value=""143"" />
      <xs:enumeration value=""144"" />
      <xs:enumeration value=""145"" />
      <xs:enumeration value=""146"" />
      <xs:enumeration value=""147"" />
      <xs:enumeration value=""148"" />
      <xs:enumeration value=""149"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""151"" />
      <xs:enumeration value=""152"" />
      <xs:enumeration value=""153"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""68"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""80"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""82"" />
      <xs:enumeration value=""83"" />
      <xs:enumeration value=""84"" />
      <xs:enumeration value=""85"" />
      <xs:enumeration value=""86"" />
      <xs:enumeration value=""87"" />
      <xs:enumeration value=""88"" />
      <xs:enumeration value=""89"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""96"" />
      <xs:enumeration value=""97"" />
      <xs:enumeration value=""98"" />
      <xs:enumeration value=""99"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_1373"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_3153"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""EI"" />
      <xs:enumeration value=""EM"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""FX"" />
      <xs:enumeration value=""GM"" />
      <xs:enumeration value=""IE"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""SW"" />
      <xs:enumeration value=""TE"" />
      <xs:enumeration value=""TG"" />
      <xs:enumeration value=""TL"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""XF"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_3139"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AH"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AJ"" />
      <xs:enumeration value=""AK"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AO"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AQ"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""AW"" />
      <xs:enumeration value=""AX"" />
      <xs:enumeration value=""AY"" />
      <xs:enumeration value=""AZ"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BB"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BF"" />
      <xs:enumeration value=""BU"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""EB"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""HE"" />
      <xs:enumeration value=""HG"" />
      <xs:enumeration value=""HM"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""LB"" />
      <xs:enumeration value=""LO"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""MH"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""NT"" />
      <xs:enumeration value=""OC"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PM"" />
      <xs:enumeration value=""QA"" />
      <xs:enumeration value=""QC"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TI"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""WH"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_3155"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""EI"" />
      <xs:enumeration value=""EM"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""FX"" />
      <xs:enumeration value=""GM"" />
      <xs:enumeration value=""IE"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""SW"" />
      <xs:enumeration value=""TE"" />
      <xs:enumeration value=""TG"" />
      <xs:enumeration value=""TL"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""XF"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_5283"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_5153"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AAA"" />
      <xs:enumeration value=""ADD"" />
      <xs:enumeration value=""BOL"" />
      <xs:enumeration value=""CAP"" />
      <xs:enumeration value=""CAR"" />
      <xs:enumeration value=""COC"" />
      <xs:enumeration value=""CST"" />
      <xs:enumeration value=""CUD"" />
      <xs:enumeration value=""CVD"" />
      <xs:enumeration value=""ENV"" />
      <xs:enumeration value=""EXC"" />
      <xs:enumeration value=""EXP"" />
      <xs:enumeration value=""FET"" />
      <xs:enumeration value=""FRE"" />
      <xs:enumeration value=""GCN"" />
      <xs:enumeration value=""GST"" />
      <xs:enumeration value=""ILL"" />
      <xs:enumeration value=""IMP"" />
      <xs:enumeration value=""IND"" />
      <xs:enumeration value=""LAC"" />
      <xs:enumeration value=""LCN"" />
      <xs:enumeration value=""LDP"" />
      <xs:enumeration value=""LOC"" />
      <xs:enumeration value=""LST"" />
      <xs:enumeration value=""MCA"" />
      <xs:enumeration value=""MCD"" />
      <xs:enumeration value=""OTH"" />
      <xs:enumeration value=""PDB"" />
      <xs:enumeration value=""PDC"" />
      <xs:enumeration value=""PRF"" />
      <xs:enumeration value=""SCN"" />
      <xs:enumeration value=""SSS"" />
      <xs:enumeration value=""STT"" />
      <xs:enumeration value=""SUP"" />
      <xs:enumeration value=""SUR"" />
      <xs:enumeration value=""SWT"" />
      <xs:enumeration value=""TAC"" />
      <xs:enumeration value=""TOT"" />
      <xs:enumeration value=""TOX"" />
      <xs:enumeration value=""TTA"" />
      <xs:enumeration value=""VAD"" />
      <xs:enumeration value=""VAT"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_5273"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_5305"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""Z"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_5025"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""100"" />
      <xs:enumeration value=""101"" />
      <xs:enumeration value=""102"" />
      <xs:enumeration value=""103"" />
      <xs:enumeration value=""104"" />
      <xs:enumeration value=""105"" />
      <xs:enumeration value=""106"" />
      <xs:enumeration value=""107"" />
      <xs:enumeration value=""108"" />
      <xs:enumeration value=""109"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""110"" />
      <xs:enumeration value=""111"" />
      <xs:enumeration value=""112"" />
      <xs:enumeration value=""113"" />
      <xs:enumeration value=""114"" />
      <xs:enumeration value=""115"" />
      <xs:enumeration value=""116"" />
      <xs:enumeration value=""117"" />
      <xs:enumeration value=""118"" />
      <xs:enumeration value=""119"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""120"" />
      <xs:enumeration value=""121"" />
      <xs:enumeration value=""122"" />
      <xs:enumeration value=""123"" />
      <xs:enumeration value=""124"" />
      <xs:enumeration value=""125"" />
      <xs:enumeration value=""126"" />
      <xs:enumeration value=""127"" />
      <xs:enumeration value=""128"" />
      <xs:enumeration value=""129"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""130"" />
      <xs:enumeration value=""131"" />
      <xs:enumeration value=""132"" />
      <xs:enumeration value=""133"" />
      <xs:enumeration value=""134"" />
      <xs:enumeration value=""135"" />
      <xs:enumeration value=""136"" />
      <xs:enumeration value=""138"" />
      <xs:enumeration value=""139"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""140"" />
      <xs:enumeration value=""142"" />
      <xs:enumeration value=""143"" />
      <xs:enumeration value=""144"" />
      <xs:enumeration value=""145"" />
      <xs:enumeration value=""146"" />
      <xs:enumeration value=""149"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""150"" />
      <xs:enumeration value=""151"" />
      <xs:enumeration value=""152"" />
      <xs:enumeration value=""153"" />
      <xs:enumeration value=""154"" />
      <xs:enumeration value=""155"" />
      <xs:enumeration value=""156"" />
      <xs:enumeration value=""157"" />
      <xs:enumeration value=""158"" />
      <xs:enumeration value=""159"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""160"" />
      <xs:enumeration value=""161"" />
      <xs:enumeration value=""162"" />
      <xs:enumeration value=""163"" />
      <xs:enumeration value=""164"" />
      <xs:enumeration value=""165"" />
      <xs:enumeration value=""166"" />
      <xs:enumeration value=""167"" />
      <xs:enumeration value=""168"" />
      <xs:enumeration value=""169"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""170"" />
      <xs:enumeration value=""172"" />
      <xs:enumeration value=""173"" />
      <xs:enumeration value=""175"" />
      <xs:enumeration value=""176"" />
      <xs:enumeration value=""177"" />
      <xs:enumeration value=""178"" />
      <xs:enumeration value=""179"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""180"" />
      <xs:enumeration value=""181"" />
      <xs:enumeration value=""182"" />
      <xs:enumeration value=""183"" />
      <xs:enumeration value=""184"" />
      <xs:enumeration value=""185"" />
      <xs:enumeration value=""186"" />
      <xs:enumeration value=""187"" />
      <xs:enumeration value=""188"" />
      <xs:enumeration value=""189"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""190"" />
      <xs:enumeration value=""192"" />
      <xs:enumeration value=""193"" />
      <xs:enumeration value=""194"" />
      <xs:enumeration value=""195"" />
      <xs:enumeration value=""196"" />
      <xs:enumeration value=""197"" />
      <xs:enumeration value=""198"" />
      <xs:enumeration value=""199"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""200"" />
      <xs:enumeration value=""201"" />
      <xs:enumeration value=""202"" />
      <xs:enumeration value=""203"" />
      <xs:enumeration value=""204"" />
      <xs:enumeration value=""205"" />
      <xs:enumeration value=""206"" />
      <xs:enumeration value=""207"" />
      <xs:enumeration value=""208"" />
      <xs:enumeration value=""209"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""210"" />
      <xs:enumeration value=""211"" />
      <xs:enumeration value=""212"" />
      <xs:enumeration value=""213"" />
      <xs:enumeration value=""214"" />
      <xs:enumeration value=""215"" />
      <xs:enumeration value=""216"" />
      <xs:enumeration value=""217"" />
      <xs:enumeration value=""218"" />
      <xs:enumeration value=""219"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""220"" />
      <xs:enumeration value=""221"" />
      <xs:enumeration value=""222"" />
      <xs:enumeration value=""223"" />
      <xs:enumeration value=""224"" />
      <xs:enumeration value=""225"" />
      <xs:enumeration value=""226"" />
      <xs:enumeration value=""227"" />
      <xs:enumeration value=""228"" />
      <xs:enumeration value=""229"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""230"" />
      <xs:enumeration value=""231"" />
      <xs:enumeration value=""232"" />
      <xs:enumeration value=""233"" />
      <xs:enumeration value=""234"" />
      <xs:enumeration value=""235"" />
      <xs:enumeration value=""236"" />
      <xs:enumeration value=""237"" />
      <xs:enumeration value=""238"" />
      <xs:enumeration value=""239"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""240"" />
      <xs:enumeration value=""241"" />
      <xs:enumeration value=""242"" />
      <xs:enumeration value=""243"" />
      <xs:enumeration value=""244"" />
      <xs:enumeration value=""245"" />
      <xs:enumeration value=""246"" />
      <xs:enumeration value=""247"" />
      <xs:enumeration value=""248"" />
      <xs:enumeration value=""249"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""250"" />
      <xs:enumeration value=""251"" />
      <xs:enumeration value=""252"" />
      <xs:enumeration value=""253"" />
      <xs:enumeration value=""254"" />
      <xs:enumeration value=""255"" />
      <xs:enumeration value=""256"" />
      <xs:enumeration value=""257"" />
      <xs:enumeration value=""258"" />
      <xs:enumeration value=""259"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""260"" />
      <xs:enumeration value=""261"" />
      <xs:enumeration value=""262"" />
      <xs:enumeration value=""263"" />
      <xs:enumeration value=""264"" />
      <xs:enumeration value=""265"" />
      <xs:enumeration value=""266"" />
      <xs:enumeration value=""267"" />
      <xs:enumeration value=""268"" />
      <xs:enumeration value=""269"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""270"" />
      <xs:enumeration value=""271"" />
      <xs:enumeration value=""272"" />
      <xs:enumeration value=""273"" />
      <xs:enumeration value=""274"" />
      <xs:enumeration value=""275"" />
      <xs:enumeration value=""276"" />
      <xs:enumeration value=""277"" />
      <xs:enumeration value=""278"" />
      <xs:enumeration value=""279"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""280"" />
      <xs:enumeration value=""281"" />
      <xs:enumeration value=""282"" />
      <xs:enumeration value=""283"" />
      <xs:enumeration value=""284"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""68"" />
      <xs:enumeration value=""69"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""76"" />
      <xs:enumeration value=""77"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""80"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""82"" />
      <xs:enumeration value=""83"" />
      <xs:enumeration value=""84"" />
      <xs:enumeration value=""85"" />
      <xs:enumeration value=""86"" />
      <xs:enumeration value=""87"" />
      <xs:enumeration value=""88"" />
      <xs:enumeration value=""89"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""96"" />
      <xs:enumeration value=""97"" />
      <xs:enumeration value=""98"" />
      <xs:enumeration value=""99"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_6343"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4405"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_6347"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_6341"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AAA"" />
      <xs:enumeration value=""AMS"" />
      <xs:enumeration value=""ARG"" />
      <xs:enumeration value=""AST"" />
      <xs:enumeration value=""AUS"" />
      <xs:enumeration value=""BEL"" />
      <xs:enumeration value=""CAN"" />
      <xs:enumeration value=""CAR"" />
      <xs:enumeration value=""CIE"" />
      <xs:enumeration value=""DEN"" />
      <xs:enumeration value=""ECR"" />
      <xs:enumeration value=""FIN"" />
      <xs:enumeration value=""FRA"" />
      <xs:enumeration value=""IMF"" />
      <xs:enumeration value=""LNF"" />
      <xs:enumeration value=""LNS"" />
      <xs:enumeration value=""MIL"" />
      <xs:enumeration value=""NOR"" />
      <xs:enumeration value=""NYC"" />
      <xs:enumeration value=""PHI"" />
      <xs:enumeration value=""SRE"" />
      <xs:enumeration value=""SWE"" />
      <xs:enumeration value=""ZUR"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_5245"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_5249"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4279"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4277"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_2475"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""68"" />
      <xs:enumeration value=""69"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""73"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""75"" />
      <xs:enumeration value=""76"" />
      <xs:enumeration value=""77"" />
      <xs:enumeration value=""78"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""80"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_2009"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_2151"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""3M"" />
      <xs:enumeration value=""6M"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""DW"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""HM"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""MN"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""W"" />
      <xs:enumeration value=""WD"" />
      <xs:enumeration value=""WW"" />
      <xs:enumeration value=""Y"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_8051"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""30"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_8179"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_8101"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_8457"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""J"" />
      <xs:enumeration value=""K"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""V"" />
      <xs:enumeration value=""W"" />
      <xs:enumeration value=""X"" />
      <xs:enumeration value=""Y"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_8459"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""X"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4055"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4215"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""FO"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""MX"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PU"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""WC"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_7075"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_7233"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""68"" />
      <xs:enumeration value=""69"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_7073"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_7143"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CV"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DW"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""EF"" />
      <xs:enumeration value=""EN"" />
      <xs:enumeration value=""GS"" />
      <xs:enumeration value=""HS"" />
      <xs:enumeration value=""IB"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""IZ"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MF"" />
      <xs:enumeration value=""MN"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""NB"" />
      <xs:enumeration value=""ON"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PV"" />
      <xs:enumeration value=""QS"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""RU"" />
      <xs:enumeration value=""RY"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SG"" />
      <xs:enumeration value=""SK"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SRS"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""TG"" />
      <xs:enumeration value=""UA"" />
      <xs:enumeration value=""UP"" />
      <xs:enumeration value=""VN"" />
      <xs:enumeration value=""VP"" />
      <xs:enumeration value=""VS"" />
      <xs:enumeration value=""VX"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_8395"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_8393"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_6311"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AAB"" />
      <xs:enumeration value=""AAC"" />
      <xs:enumeration value=""AAD"" />
      <xs:enumeration value=""AAE"" />
      <xs:enumeration value=""AAF"" />
      <xs:enumeration value=""AAG"" />
      <xs:enumeration value=""AAH"" />
      <xs:enumeration value=""AAI"" />
      <xs:enumeration value=""AAJ"" />
      <xs:enumeration value=""AAK"" />
      <xs:enumeration value=""AAL"" />
      <xs:enumeration value=""AAM"" />
      <xs:enumeration value=""AAN"" />
      <xs:enumeration value=""AAO"" />
      <xs:enumeration value=""AAP"" />
      <xs:enumeration value=""AAQ"" />
      <xs:enumeration value=""AAR"" />
      <xs:enumeration value=""AAS"" />
      <xs:enumeration value=""AAT"" />
      <xs:enumeration value=""AAU"" />
      <xs:enumeration value=""AAV"" />
      <xs:enumeration value=""ASW"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CHW"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""DEN"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""DV"" />
      <xs:enumeration value=""DX"" />
      <xs:enumeration value=""EGW"" />
      <xs:enumeration value=""EN"" />
      <xs:enumeration value=""EVO"" />
      <xs:enumeration value=""FO"" />
      <xs:enumeration value=""IV"" />
      <xs:enumeration value=""LAO"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LGL"" />
      <xs:enumeration value=""LL"" />
      <xs:enumeration value=""LMT"" />
      <xs:enumeration value=""NAX"" />
      <xs:enumeration value=""PAL"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PLL"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""SO"" />
      <xs:enumeration value=""SPG"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""SV"" />
      <xs:enumeration value=""TE"" />
      <xs:enumeration value=""TL"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""VO"" />
      <xs:enumeration value=""VOL"" />
      <xs:enumeration value=""VT"" />
      <xs:enumeration value=""WT"" />
      <xs:enumeration value=""WX"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_6313"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""AAA"" />
      <xs:enumeration value=""AAB"" />
      <xs:enumeration value=""AAC"" />
      <xs:enumeration value=""AAD"" />
      <xs:enumeration value=""AAE"" />
      <xs:enumeration value=""AAF"" />
      <xs:enumeration value=""AAG"" />
      <xs:enumeration value=""AAH"" />
      <xs:enumeration value=""AAI"" />
      <xs:enumeration value=""AAL"" />
      <xs:enumeration value=""AAM"" />
      <xs:enumeration value=""AAN"" />
      <xs:enumeration value=""AAO"" />
      <xs:enumeration value=""AAP"" />
      <xs:enumeration value=""AAQ"" />
      <xs:enumeration value=""AAR"" />
      <xs:enumeration value=""AAS"" />
      <xs:enumeration value=""AAT"" />
      <xs:enumeration value=""AAU"" />
      <xs:enumeration value=""AAV"" />
      <xs:enumeration value=""AAW"" />
      <xs:enumeration value=""AAX"" />
      <xs:enumeration value=""AAY"" />
      <xs:enumeration value=""AAZ"" />
      <xs:enumeration value=""ABA"" />
      <xs:enumeration value=""ABB"" />
      <xs:enumeration value=""ABC"" />
      <xs:enumeration value=""ABD"" />
      <xs:enumeration value=""ABE"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BND"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BRA"" />
      <xs:enumeration value=""BRE"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""BSW"" />
      <xs:enumeration value=""BW"" />
      <xs:enumeration value=""CHN"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CV"" />
      <xs:enumeration value=""CZ"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DP"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""DW"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""EA"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""FL"" />
      <xs:enumeration value=""FN"" />
      <xs:enumeration value=""FV"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""GG"" />
      <xs:enumeration value=""GW"" />
      <xs:enumeration value=""HF"" />
      <xs:enumeration value=""HM"" />
      <xs:enumeration value=""HT"" />
      <xs:enumeration value=""IB"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""LM"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""LND"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""MO"" />
      <xs:enumeration value=""MW"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""OD"" />
      <xs:enumeration value=""PRS"" />
      <xs:enumeration value=""PTN"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RJ"" />
      <xs:enumeration value=""RMW"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RUN"" />
      <xs:enumeration value=""RY"" />
      <xs:enumeration value=""SQ"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TH"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""VH"" />
      <xs:enumeration value=""VW"" />
      <xs:enumeration value=""WA"" />
      <xs:enumeration value=""WD"" />
      <xs:enumeration value=""WM"" />
      <xs:enumeration value=""WT"" />
      <xs:enumeration value=""WU"" />
      <xs:enumeration value=""XH"" />
      <xs:enumeration value=""XQ"" />
      <xs:enumeration value=""XZ"" />
      <xs:enumeration value=""YS"" />
      <xs:enumeration value=""ZAL"" />
      <xs:enumeration value=""ZAS"" />
      <xs:enumeration value=""ZB"" />
      <xs:enumeration value=""ZBI"" />
      <xs:enumeration value=""ZC"" />
      <xs:enumeration value=""ZCA"" />
      <xs:enumeration value=""ZCB"" />
      <xs:enumeration value=""ZCE"" />
      <xs:enumeration value=""ZCL"" />
      <xs:enumeration value=""ZCO"" />
      <xs:enumeration value=""ZCR"" />
      <xs:enumeration value=""ZCU"" />
      <xs:enumeration value=""ZFE"" />
      <xs:enumeration value=""ZFS"" />
      <xs:enumeration value=""ZGE"" />
      <xs:enumeration value=""ZH"" />
      <xs:enumeration value=""ZK"" />
      <xs:enumeration value=""ZMG"" />
      <xs:enumeration value=""ZMN"" />
      <xs:enumeration value=""ZMO"" />
      <xs:enumeration value=""ZN"" />
      <xs:enumeration value=""ZNA"" />
      <xs:enumeration value=""ZNI"" />
      <xs:enumeration value=""ZO"" />
      <xs:enumeration value=""ZP"" />
      <xs:enumeration value=""ZPB"" />
      <xs:enumeration value=""ZS"" />
      <xs:enumeration value=""ZSI"" />
      <xs:enumeration value=""ZSL"" />
      <xs:enumeration value=""ZSN"" />
      <xs:enumeration value=""ZTA"" />
      <xs:enumeration value=""ZTE"" />
      <xs:enumeration value=""ZTI"" />
      <xs:enumeration value=""ZV"" />
      <xs:enumeration value=""ZW"" />
      <xs:enumeration value=""ZWA"" />
      <xs:enumeration value=""ZZN"" />
      <xs:enumeration value=""ZZR"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_6321"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_6155"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4233"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_8275"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_7405"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BX"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""EE"" />
      <xs:enumeration value=""EM"" />
      <xs:enumeration value=""IL"" />
      <xs:enumeration value=""ML"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""VV"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_8053"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BPN"" />
      <xs:enumeration value=""BPY"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BX"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""DPA"" />
      <xs:enumeration value=""EFP"" />
      <xs:enumeration value=""EYP"" />
      <xs:enumeration value=""FPN"" />
      <xs:enumeration value=""FPR"" />
      <xs:enumeration value=""FSU"" />
      <xs:enumeration value=""LAR"" />
      <xs:enumeration value=""LU"" />
      <xs:enumeration value=""MPA"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PBP"" />
      <xs:enumeration value=""PFP"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PPA"" />
      <xs:enumeration value=""PST"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RG"" />
      <xs:enumeration value=""RGF"" />
      <xs:enumeration value=""RO"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""SCA"" />
      <xs:enumeration value=""SCB"" />
      <xs:enumeration value=""SCC"" />
      <xs:enumeration value=""SFA"" />
      <xs:enumeration value=""SPP"" />
      <xs:enumeration value=""STR"" />
      <xs:enumeration value=""SW"" />
      <xs:enumeration value=""TE"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TSU"" />
      <xs:enumeration value=""UL"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_8155"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_8077"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_8249"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_8169"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4017"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4493"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""BK"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DB"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""P1"" />
      <xs:enumeration value=""P2"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SP"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_2013"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""J"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""Q"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""W"" />
      <xs:enumeration value=""Y"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_2015"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_2017"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""Y"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_6063"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""100"" />
      <xs:enumeration value=""101"" />
      <xs:enumeration value=""102"" />
      <xs:enumeration value=""103"" />
      <xs:enumeration value=""104"" />
      <xs:enumeration value=""105"" />
      <xs:enumeration value=""106"" />
      <xs:enumeration value=""107"" />
      <xs:enumeration value=""108"" />
      <xs:enumeration value=""109"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""110"" />
      <xs:enumeration value=""111"" />
      <xs:enumeration value=""112"" />
      <xs:enumeration value=""113"" />
      <xs:enumeration value=""114"" />
      <xs:enumeration value=""115"" />
      <xs:enumeration value=""116"" />
      <xs:enumeration value=""117"" />
      <xs:enumeration value=""118"" />
      <xs:enumeration value=""119"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""120"" />
      <xs:enumeration value=""121"" />
      <xs:enumeration value=""122"" />
      <xs:enumeration value=""123"" />
      <xs:enumeration value=""124"" />
      <xs:enumeration value=""125"" />
      <xs:enumeration value=""126"" />
      <xs:enumeration value=""127"" />
      <xs:enumeration value=""128"" />
      <xs:enumeration value=""129"" />
      <xs:enumeration value=""130"" />
      <xs:enumeration value=""131"" />
      <xs:enumeration value=""132"" />
      <xs:enumeration value=""133"" />
      <xs:enumeration value=""134"" />
      <xs:enumeration value=""135"" />
      <xs:enumeration value=""136"" />
      <xs:enumeration value=""137"" />
      <xs:enumeration value=""138"" />
      <xs:enumeration value=""139"" />
      <xs:enumeration value=""140"" />
      <xs:enumeration value=""141"" />
      <xs:enumeration value=""142"" />
      <xs:enumeration value=""143"" />
      <xs:enumeration value=""144"" />
      <xs:enumeration value=""145"" />
      <xs:enumeration value=""146"" />
      <xs:enumeration value=""147"" />
      <xs:enumeration value=""148"" />
      <xs:enumeration value=""149"" />
      <xs:enumeration value=""150"" />
      <xs:enumeration value=""151"" />
      <xs:enumeration value=""152"" />
      <xs:enumeration value=""153"" />
      <xs:enumeration value=""154"" />
      <xs:enumeration value=""155"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""73"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""75"" />
      <xs:enumeration value=""77"" />
      <xs:enumeration value=""78"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""82"" />
      <xs:enumeration value=""83"" />
      <xs:enumeration value=""84"" />
      <xs:enumeration value=""85"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""99"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4043"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""BG"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""JB"" />
      <xs:enumeration value=""MF"" />
      <xs:enumeration value=""OE"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""WH"" />
      <xs:enumeration value=""WS"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_5393"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""CSD"" />
      <xs:enumeration value=""CSR"" />
      <xs:enumeration value=""DIS"" />
      <xs:enumeration value=""SEL"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4295"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AH"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AJ"" />
      <xs:enumeration value=""AK"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AO"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AQ"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BQ"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""EV"" />
      <xs:enumeration value=""GU"" />
      <xs:enumeration value=""GW"" />
      <xs:enumeration value=""LD"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PQ"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""PZ"" />
      <xs:enumeration value=""QO"" />
      <xs:enumeration value=""QP"" />
      <xs:enumeration value=""QT"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""UM"" />
      <xs:enumeration value=""UP"" />
      <xs:enumeration value=""WD"" />
      <xs:enumeration value=""WO"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_6167"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_5463"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""J"" />
      <xs:enumeration value=""K"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""Q"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""V"" />
      <xs:enumeration value=""W"" />
      <xs:enumeration value=""X"" />
      <xs:enumeration value=""Y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_5189"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4471"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_1227"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_7161"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AAA"" />
      <xs:enumeration value=""AAB"" />
      <xs:enumeration value=""AAC"" />
      <xs:enumeration value=""AAD"" />
      <xs:enumeration value=""AAE"" />
      <xs:enumeration value=""AAF"" />
      <xs:enumeration value=""AAG"" />
      <xs:enumeration value=""AAH"" />
      <xs:enumeration value=""AAI"" />
      <xs:enumeration value=""AAJ"" />
      <xs:enumeration value=""AAK"" />
      <xs:enumeration value=""AAL"" />
      <xs:enumeration value=""AAM"" />
      <xs:enumeration value=""AAN"" />
      <xs:enumeration value=""AAO"" />
      <xs:enumeration value=""AAP"" />
      <xs:enumeration value=""AAQ"" />
      <xs:enumeration value=""AAR"" />
      <xs:enumeration value=""AAS"" />
      <xs:enumeration value=""AAT"" />
      <xs:enumeration value=""AAU"" />
      <xs:enumeration value=""AAV"" />
      <xs:enumeration value=""AAW"" />
      <xs:enumeration value=""AAX"" />
      <xs:enumeration value=""AAY"" />
      <xs:enumeration value=""AAZ"" />
      <xs:enumeration value=""ABA"" />
      <xs:enumeration value=""ABB"" />
      <xs:enumeration value=""ABC"" />
      <xs:enumeration value=""ABD"" />
      <xs:enumeration value=""ABE"" />
      <xs:enumeration value=""ABF"" />
      <xs:enumeration value=""ABG"" />
      <xs:enumeration value=""ABH"" />
      <xs:enumeration value=""ABI"" />
      <xs:enumeration value=""ABJ"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AJ"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CAA"" />
      <xs:enumeration value=""CAB"" />
      <xs:enumeration value=""CAC"" />
      <xs:enumeration value=""CAD"" />
      <xs:enumeration value=""CAE"" />
      <xs:enumeration value=""CAF"" />
      <xs:enumeration value=""CAG"" />
      <xs:enumeration value=""CAH"" />
      <xs:enumeration value=""CAI"" />
      <xs:enumeration value=""CAJ"" />
      <xs:enumeration value=""CAK"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DAA"" />
      <xs:enumeration value=""DAB"" />
      <xs:enumeration value=""DAD"" />
      <xs:enumeration value=""DAE"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DM"" />
      <xs:enumeration value=""EAA"" />
      <xs:enumeration value=""EAB"" />
      <xs:enumeration value=""EG"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FAA"" />
      <xs:enumeration value=""FAB"" />
      <xs:enumeration value=""FAC"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FG"" />
      <xs:enumeration value=""FH"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""FN"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""GAA"" />
      <xs:enumeration value=""HAA"" />
      <xs:enumeration value=""HD"" />
      <xs:enumeration value=""HH"" />
      <xs:enumeration value=""IA"" />
      <xs:enumeration value=""IAA"" />
      <xs:enumeration value=""IAB"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IF"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IR"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""KO"" />
      <xs:enumeration value=""L1"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""LAA"" />
      <xs:enumeration value=""LAB"" />
      <xs:enumeration value=""LAC"" />
      <xs:enumeration value=""LF"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MAA"" />
      <xs:enumeration value=""MAB"" />
      <xs:enumeration value=""MAC"" />
      <xs:enumeration value=""MAD"" />
      <xs:enumeration value=""MAE"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""ML"" />
      <xs:enumeration value=""NAA"" />
      <xs:enumeration value=""OA"" />
      <xs:enumeration value=""OAA"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PAA"" />
      <xs:enumeration value=""PAB"" />
      <xs:enumeration value=""PAC"" />
      <xs:enumeration value=""PAD"" />
      <xs:enumeration value=""PAE"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""QAA"" />
      <xs:enumeration value=""QD"" />
      <xs:enumeration value=""RAA"" />
      <xs:enumeration value=""RAB"" />
      <xs:enumeration value=""RAC"" />
      <xs:enumeration value=""RAD"" />
      <xs:enumeration value=""RAE"" />
      <xs:enumeration value=""RAF"" />
      <xs:enumeration value=""RAG"" />
      <xs:enumeration value=""RAH"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RH"" />
      <xs:enumeration value=""RO"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RV"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SAA"" />
      <xs:enumeration value=""SAB"" />
      <xs:enumeration value=""SAC"" />
      <xs:enumeration value=""SAD"" />
      <xs:enumeration value=""SAE"" />
      <xs:enumeration value=""SAF"" />
      <xs:enumeration value=""SAG"" />
      <xs:enumeration value=""SAH"" />
      <xs:enumeration value=""SAI"" />
      <xs:enumeration value=""SAJ"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SF"" />
      <xs:enumeration value=""SG"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""SZ"" />
      <xs:enumeration value=""TAA"" />
      <xs:enumeration value=""TAB"" />
      <xs:enumeration value=""TAC"" />
      <xs:enumeration value=""TAD"" />
      <xs:enumeration value=""TAE"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""TV"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""TZ"" />
      <xs:enumeration value=""UM"" />
      <xs:enumeration value=""V1"" />
      <xs:enumeration value=""V2"" />
      <xs:enumeration value=""VAA"" />
      <xs:enumeration value=""VAB"" />
      <xs:enumeration value=""VL"" />
      <xs:enumeration value=""WH"" />
      <xs:enumeration value=""XAA"" />
      <xs:enumeration value=""YY"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_5419"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_7293"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_1229"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_5495"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_7083"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""I"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4347"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_7297"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_4221"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""BK"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""NF"" />
      <xs:enumeration value=""NN"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""OF"" />
      <xs:enumeration value=""OM"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""OS"" />
      <xs:enumeration value=""OW"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PK"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""TW"" />
      <xs:enumeration value=""UR"" />
      <xs:enumeration value=""ZZZ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_5125"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AAA"" />
      <xs:enumeration value=""AAB"" />
      <xs:enumeration value=""CAL"" />
      <xs:enumeration value=""INF"" />
      <xs:enumeration value=""INV"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_5375"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AQ"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""NW"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PK"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PU"" />
      <xs:enumeration value=""PV"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""QT"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""TB"" />
      <xs:enumeration value=""TU"" />
      <xs:enumeration value=""TW"" />
      <xs:enumeration value=""WH"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_5387"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AAA"" />
      <xs:enumeration value=""AAB"" />
      <xs:enumeration value=""AAD"" />
      <xs:enumeration value=""AAE"" />
      <xs:enumeration value=""AAF"" />
      <xs:enumeration value=""AAG"" />
      <xs:enumeration value=""AAH"" />
      <xs:enumeration value=""AAI"" />
      <xs:enumeration value=""AAJ"" />
      <xs:enumeration value=""AAK"" />
      <xs:enumeration value=""AAL"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""ALT"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""CAT"" />
      <xs:enumeration value=""CDV"" />
      <xs:enumeration value=""CON"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""CUP"" />
      <xs:enumeration value=""CUS"" />
      <xs:enumeration value=""DAP"" />
      <xs:enumeration value=""DIS"" />
      <xs:enumeration value=""DPR"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DSC"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""EUP"" />
      <xs:enumeration value=""FCR"" />
      <xs:enumeration value=""GRP"" />
      <xs:enumeration value=""INV"" />
      <xs:enumeration value=""LBL"" />
      <xs:enumeration value=""MAX"" />
      <xs:enumeration value=""MIN"" />
      <xs:enumeration value=""MNR"" />
      <xs:enumeration value=""MSR"" />
      <xs:enumeration value=""MXR"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""NQT"" />
      <xs:enumeration value=""NTP"" />
      <xs:enumeration value=""NW"" />
      <xs:enumeration value=""OCR"" />
      <xs:enumeration value=""OFR"" />
      <xs:enumeration value=""PAQ"" />
      <xs:enumeration value=""PBQ"" />
      <xs:enumeration value=""PPD"" />
      <xs:enumeration value=""PPR"" />
      <xs:enumeration value=""PRO"" />
      <xs:enumeration value=""PRP"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""QTE"" />
      <xs:enumeration value=""RES"" />
      <xs:enumeration value=""RTP"" />
      <xs:enumeration value=""SHD"" />
      <xs:enumeration value=""SRP"" />
      <xs:enumeration value=""SW"" />
      <xs:enumeration value=""TB"" />
      <xs:enumeration value=""TRF"" />
      <xs:enumeration value=""TU"" />
      <xs:enumeration value=""TW"" />
      <xs:enumeration value=""WH"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_5213"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID0081"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID_6069"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_N"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_AN"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_ID"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""EDIFACT_A"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
</xs:schema>";
        
        public EFACT_D93A_ORDERS() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "EFACT_D93A_ORDERS";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmercitAdapter
{
  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "EmercitAdapterServiceSoapBinding", Namespace = "http://emercitadapter.pins.iskratel.si/")]
  public interface IEmercitAdapterServiceSoapBinding
  {             
    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://emercitadapter.pins.iskratel.si/", ResponseNamespace = "http://emercitadapter.pins.iskratel.si/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    bool newIER([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] ier ier);
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://emercit.pins.iskratel.si/")]
  public partial class ier
  {

    private string identifierField;

    private string senderField;

    private System.DateTime sentField;

    private ierStatus statusField;

    private ierMsgType msgTypeField;

    private string sourceField;

    private string noteField;

    private string referencesField;

    private info[] infoField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string identifier
    {
      get
      {
        return this.identifierField;
      }
      set
      {
        this.identifierField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string sender
    {
      get
      {
        return this.senderField;
      }
      set
      {
        this.senderField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.DateTime sent
    {
      get
      {
        return this.sentField;
      }
      set
      {
        this.sentField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ierStatus status
    {
      get
      {
        return this.statusField;
      }
      set
      {
        this.statusField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ierMsgType msgType
    {
      get
      {
        return this.msgTypeField;
      }
      set
      {
        this.msgTypeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string source
    {
      get
      {
        return this.sourceField;
      }
      set
      {
        this.sourceField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string note
    {
      get
      {
        return this.noteField;
      }
      set
      {
        this.noteField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string references
    {
      get
      {
        return this.referencesField;
      }
      set
      {
        this.referencesField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("info", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
    public info[] info
    {
      get
      {
        return this.infoField;
      }
      set
      {
        this.infoField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://emercit.pins.iskratel.si/")]
  public enum ierStatus
  {

    /// <remarks/>
    Actual,

    /// <remarks/>
    Exercise,

    /// <remarks/>
    System,

    /// <remarks/>
    Test,
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://emercit.pins.iskratel.si/")]
  public enum ierMsgType
  {

    /// <remarks/>
    Alert,

    /// <remarks/>
    Update,

    /// <remarks/>
    Cancel,
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://emercit.pins.iskratel.si/")]
  public partial class info
  {

    private string languageField;

    private infoCategory[] categoryField;

    private infoUrgency urgencyField;

    private infoSeverity severityField;

    private infoCertainty certaintyField;

    private valueName[] eventCodeField;

    private System.DateTime onsetField;

    private bool onsetFieldSpecified;

    private System.DateTime expiresField;

    private bool expiresFieldSpecified;

    private string senderNameField;

    private string headlineField;

    private string descriptionField;

    private string instructionField;

    private string webField;

    private string contactField;

    private string waterLevelField;

    private valueName[] parameterField;

    private area[] areaField;

    public info()
    {
      this.languageField = "ru-RU";
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "language")]
    [System.ComponentModel.DefaultValueAttribute("ru-RU")]
    public string language
    {
      get
      {
        return this.languageField;
      }
      set
      {
        this.languageField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("category", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public infoCategory[] category
    {
      get
      {
        return this.categoryField;
      }
      set
      {
        this.categoryField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public infoUrgency urgency
    {
      get
      {
        return this.urgencyField;
      }
      set
      {
        this.urgencyField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public infoSeverity severity
    {
      get
      {
        return this.severityField;
      }
      set
      {
        this.severityField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public infoCertainty certainty
    {
      get
      {
        return this.certaintyField;
      }
      set
      {
        this.certaintyField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("eventCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
    public valueName[] eventCode
    {
      get
      {
        return this.eventCodeField;
      }
      set
      {
        this.eventCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.DateTime onset
    {
      get
      {
        return this.onsetField;
      }
      set
      {
        this.onsetField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool onsetSpecified
    {
      get
      {
        return this.onsetFieldSpecified;
      }
      set
      {
        this.onsetFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.DateTime expires
    {
      get
      {
        return this.expiresField;
      }
      set
      {
        this.expiresField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool expiresSpecified
    {
      get
      {
        return this.expiresFieldSpecified;
      }
      set
      {
        this.expiresFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string senderName
    {
      get
      {
        return this.senderNameField;
      }
      set
      {
        this.senderNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string headline
    {
      get
      {
        return this.headlineField;
      }
      set
      {
        this.headlineField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string description
    {
      get
      {
        return this.descriptionField;
      }
      set
      {
        this.descriptionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string instruction
    {
      get
      {
        return this.instructionField;
      }
      set
      {
        this.instructionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "anyURI")]
    public string web
    {
      get
      {
        return this.webField;
      }
      set
      {
        this.webField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string contact
    {
      get
      {
        return this.contactField;
      }
      set
      {
        this.contactField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string waterLevel
    {
      get
      {
        return this.waterLevelField;
      }
      set
      {
        this.waterLevelField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("parameter", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
    public valueName[] parameter
    {
      get
      {
        return this.parameterField;
      }
      set
      {
        this.parameterField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("area", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
    public area[] area
    {
      get
      {
        return this.areaField;
      }
      set
      {
        this.areaField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://emercit.pins.iskratel.si/")]
  public enum infoCategory
  {

    /// <remarks/>
    Geo,

    /// <remarks/>
    Met,

    /// <remarks/>
    Safety,

    /// <remarks/>
    Security,

    /// <remarks/>
    Rescue,

    /// <remarks/>
    Fire,

    /// <remarks/>
    Health,

    /// <remarks/>
    Env,

    /// <remarks/>
    Transport,

    /// <remarks/>
    Infra,

    /// <remarks/>
    CBRNE,

    /// <remarks/>
    Other,
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://emercit.pins.iskratel.si/")]
  public enum infoUrgency
  {

    /// <remarks/>
    Immediate,

    /// <remarks/>
    Expected,

    /// <remarks/>
    Future,

    /// <remarks/>
    Past,

    /// <remarks/>
    Unknown,
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://emercit.pins.iskratel.si/")]
  public enum infoSeverity
  {

    /// <remarks/>
    Extreme,

    /// <remarks/>
    Severe,

    /// <remarks/>
    Moderate,

    /// <remarks/>
    Minor,

    /// <remarks/>
    Unknown,
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://emercit.pins.iskratel.si/")]
  public enum infoCertainty
  {

    /// <remarks/>
    Observed,

    /// <remarks/>
    Likely,

    /// <remarks/>
    Possible,

    /// <remarks/>
    Unlikely,

    /// <remarks/>
    Unknown,
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://emercit.pins.iskratel.si/")]
  public partial class valueName
  {

    private string valueName1Field;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("valueName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string valueName1
    {
      get
      {
        return this.valueName1Field;
      }
      set
      {
        this.valueName1Field = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://emercit.pins.iskratel.si/")]
  public partial class area
  {

    private string areaDescField;

    private string[] polygonField;

    private string[] circleField;

    private valueName[] geocodeField;

    private string altitudeField;

    private string ceilingField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string areaDesc
    {
      get
      {
        return this.areaDescField;
      }
      set
      {
        this.areaDescField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("polygon", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
    public string[] polygon
    {
      get
      {
        return this.polygonField;
      }
      set
      {
        this.polygonField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("circle", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
    public string[] circle
    {
      get
      {
        return this.circleField;
      }
      set
      {
        this.circleField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("geocode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
    public valueName[] geocode
    {
      get
      {
        return this.geocodeField;
      }
      set
      {
        this.geocodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string altitude
    {
      get
      {
        return this.altitudeField;
      }
      set
      {
        this.altitudeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ceiling
    {
      get
      {
        return this.ceilingField;
      }
      set
      {
        this.ceilingField = value;
      }
    }
  }
}
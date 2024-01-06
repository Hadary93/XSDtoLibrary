using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "foulingPoint")]
public class FoulingPointRef
{
	[XmlAttribute(AttributeName ="ref")]
	public string? Ref {get;set;}
}

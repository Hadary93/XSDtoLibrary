using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "operationalPoint")]
public class OperationalPointRef
{
	[XmlAttribute(AttributeName ="ref")]
	public string? Ref {get;set;}
}

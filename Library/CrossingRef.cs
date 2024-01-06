using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "crossing")]
public class CrossingRef
{
	[XmlAttribute(AttributeName ="ref")]
	public string? Ref {get;set;}
}

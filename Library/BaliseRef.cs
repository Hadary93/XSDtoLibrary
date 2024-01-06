using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "balise")]
public class BaliseRef
{
	[XmlAttribute(AttributeName ="ref")]
	public string? Ref {get;set;}
}

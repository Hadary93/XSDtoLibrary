using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "preferredOppositeDi")]
public class PreferredOppositeDiRef
{
	[XmlAttribute(AttributeName ="ref")]
	public string Ref {get;set;}
}

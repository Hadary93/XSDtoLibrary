using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "preferredSameDi")]
public class PreferredSameDiRef
{
	[XmlAttribute(AttributeName ="ref")]
	public string Ref {get;set;}
}

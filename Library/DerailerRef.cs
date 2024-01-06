using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "derailer")]
public class DerailerRef
{
	[XmlAttribute(AttributeName ="ref")]
	public string Ref {get;set;}
}

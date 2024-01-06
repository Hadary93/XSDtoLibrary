using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "dependencie")]
public class DependencieRef
{
	[XmlAttribute(AttributeName ="ref")]
	public string? Ref {get;set;}
}

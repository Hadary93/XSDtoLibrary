using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "etcsMarker")]
public class EtcsMarkerRef
{
	[XmlAttribute(AttributeName ="ref")]
	public string? Ref {get;set;}
}

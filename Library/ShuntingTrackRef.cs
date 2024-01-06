using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "shuntingTrack")]
public class ShuntingTrackRef
{
	[XmlAttribute(AttributeName ="ref")]
	public string? Ref {get;set;}
}

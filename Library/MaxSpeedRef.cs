using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "maxSpeed")]
public class MaxSpeedRef
{
	[XmlAttribute(AttributeName ="value")]
	public uint value {get;set;}
}

using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainMaxWagons")]
public class TrainMaxWagonsRef
{
	[XmlAttribute(AttributeName ="value")]
	public uint value {get;set;}
}

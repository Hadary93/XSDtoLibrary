using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainMaxAxles")]
public class TrainMaxAxlesRef
{
	[XmlAttribute(AttributeName ="value")]
	public uint value {get;set;}
}

using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainMaxSize")]
public class TrainMaxSizeRef
{
	[XmlAttribute(AttributeName ="value")]
	public infra.TrainSize value {get;set;}
}

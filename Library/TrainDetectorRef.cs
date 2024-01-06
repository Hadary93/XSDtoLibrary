using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainDetector")]
public class TrainDetectorRef
{
	[XmlAttribute(AttributeName ="ref")]
	public string Ref {get;set;}
}

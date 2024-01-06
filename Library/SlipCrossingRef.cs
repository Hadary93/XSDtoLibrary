using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "slipCrossing")]
public class SlipCrossingRef
{
	[XmlAttribute(AttributeName ="ref")]
	public string Ref {get;set;}
}

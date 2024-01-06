using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "loadingGauge")]
public class LoadingGaugeRef
{
	[XmlAttribute(AttributeName ="value")]
	public uint value {get;set;}
}

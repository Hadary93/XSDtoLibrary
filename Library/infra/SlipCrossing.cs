using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "slipCrossing")]
	public class SlipCrossing
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("simplePoint", Namespace = "https://erju.org/")]
		public List<SimplePointRef>? simplePoints;
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("crossing")]
		public string? crossing {get;set;}
	}
}
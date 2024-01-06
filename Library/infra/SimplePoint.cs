using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "simplePoint")]
	public class SimplePoint
	{
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("reversalTime")]
		public uint reversalTime {get;set;}
		[XmlAttribute("pointLeft")]
		public string? pointLeft {get;set;}
		[XmlAttribute("pointRight")]
		public string? pointRight {get;set;}
	}
}
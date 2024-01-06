using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "platform")]
	public class Platform
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("platformEdge", Namespace = "https://erju.org/")]
		public List<infra.PlatformEdge>? platformEdges;
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("name")]
		public string name {get;set;}
	}
}
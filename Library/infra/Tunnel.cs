using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "tunnel")]
	public class Tunnel
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("tunnelTube", Namespace = "https://erju.org/")]
		public List<infra.TunnelTube>? tunnelTubes;
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("name")]
		public string? name {get;set;}
	}
}
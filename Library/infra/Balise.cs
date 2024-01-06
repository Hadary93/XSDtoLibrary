using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "balise")]
	public class Balise
	{
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("trackEdge")]
		public string? trackEdge {get;set;}
		[XmlAttribute("pos")]
		public uint pos {get;set;}
	}
}
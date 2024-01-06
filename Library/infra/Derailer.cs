using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "derailer")]
	public class Derailer
	{
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("trackEdge")]
		public string? trackEdge {get;set;}
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("sameDir")]
		public bool sameDir {get;set;}
		[XmlAttribute("reversalTime")]
		public uint reversalTime {get;set;}
		[XmlAttribute("derailToRight")]
		public bool derailToRight {get;set;}
	}
}
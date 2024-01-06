using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "bufferStop")]
	public class BufferStop
	{
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("trackEdge")]
		public string? trackEdge {get;set;}
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("sameDir")]
		public bool sameDir {get;set;}
		[XmlAttribute("isSwitchable")]
		public bool isSwitchable {get;set;}
	}
}
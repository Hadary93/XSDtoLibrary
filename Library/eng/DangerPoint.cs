using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "dangerPoint")]
	public class DangerPoint
	{
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("name")]
		public string name {get;set;}
		[XmlAttribute("trackEdge")]
		public string trackEdge {get;set;}
		[XmlAttribute("pos")]
		public uint pos {get;set;}
	}
}
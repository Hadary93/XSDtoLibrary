using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "dirTrackEdgePoint")]
	public class DirTrackEdgePoint
	{
		[XmlAttribute("trackEdge")]
		public string? trackEdge {get;set;}
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("sameDir")]
		public bool sameDir {get;set;}
	}
}
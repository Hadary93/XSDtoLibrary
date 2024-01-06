using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgePoint")]
	public class TrackEdgePoint
	{
		[XmlAttribute("trackEdge")]
		public string trackEdge {get;set;}
		[XmlAttribute("pos")]
		public uint pos {get;set;}
	}
}
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeSection")]
	public class TrackEdgeSection
	{
		[XmlAttribute("trackEdge")]
		public string trackEdge {get;set;}
		[XmlAttribute("skipFromPathStart")]
		public uint skipFromPathStart {get;set;}
		[XmlAttribute("skipFromPathEnd")]
		public uint skipFromPathEnd {get;set;}
	}
}
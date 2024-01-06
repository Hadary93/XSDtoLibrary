using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "dirTrackEdgeSection")]
	public class DirTrackEdgeSection
	{
		[XmlAttribute("trackEdge")]
		public string? trackEdge {get;set;}
		[XmlAttribute("skipFromPathStart")]
		public uint skipFromPathStart {get;set;}
		[XmlAttribute("skipFromPathEnd")]
		public uint skipFromPathEnd {get;set;}
		[XmlAttribute("direction")]
		public infra.Direction direction {get;set;}
	}
}
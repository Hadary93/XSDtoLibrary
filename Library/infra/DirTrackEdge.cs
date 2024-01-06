using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "dirTrackEdge")]
	public class DirTrackEdge
	{
		[XmlAttribute("trackEdge")]
		public string? trackEdge {get;set;}
		[XmlAttribute("sameDir")]
		public bool sameDir {get;set;}
	}
}
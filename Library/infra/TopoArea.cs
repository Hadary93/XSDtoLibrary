using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "topoArea")]
	public class TopoArea
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("trackEdge", Namespace = "https://erju.org/")]
		public List<infra.TrackEdge>? trackEdges;
		[XmlArray(Order=1)]
		[XmlArrayItem("trackEdgeLink", Namespace = "https://erju.org/")]
		public List<infra.TrackEdgeLink>? trackEdgeLinks;
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("versionTimestamp")]
		public string? versionTimestamp {get;set;}
	}
}
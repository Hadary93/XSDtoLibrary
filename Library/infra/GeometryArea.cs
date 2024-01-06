using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "geometryArea")]
	public class GeometryArea
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("trackEdgeGeometry", Namespace = "https://erju.org/")]
		public List<infra.TrackEdgeGeometry>? trackEdgeGeometries;
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("versionTimestamp")]
		public string? versionTimestamp {get;set;}
		[XmlAttribute("alignment3d")]
		public bool alignment3d {get;set;}
	}
}
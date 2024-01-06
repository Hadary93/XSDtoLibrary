using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "sampledGeometryArea")]
	public class SampledGeometryArea
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("sampledTrackEdgeGeometry", Namespace = "https://erju.org/")]
		public List<infra.SampledTrackEdgeGeometry>? sampledTrackEdgeGeometries;
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("versionTimestamp")]
		public string versionTimestamp {get;set;}
	}
}
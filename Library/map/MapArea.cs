using System.Xml.Serialization;
namespace map
{
	[XmlRoot(Namespace = "https://erju.org/map", ElementName = "mapArea")]
	public class MapArea
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("trackEdge", Namespace = "https://erju.org/")]
		public List<map.TrackEdgeProjection>? trackEdges;
		[XmlArray(Order=1)]
		[XmlArrayItem("funcElement", Namespace = "https://erju.org/")]
		public List<map.FuncElementProjection>? funcElements;
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("name")]
		public string? name {get;set;}
		[XmlAttribute("versionTimestamp")]
		public string? versionTimestamp {get;set;}
		[XmlAttribute("areaId")]
		public string? areaId {get;set;}
		[XmlAttribute("epsg")]
		public uint epsg {get;set;}
	}
}
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "mileageLine")]
	public class MileageLine
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("trackEdge", Namespace = "https://erju.org/")]
		public List<eng.TrackEdgeMileage>? trackEdges;
		[XmlArray(Order=1)]
		[XmlArrayItem("horizontalGeometryItem", Namespace = "https://erju.org/")]
		public List<infra.HorizontalSegment>? horizontalGeometry;
		[XmlArray(Order=2)]
		[XmlArrayItem("referenceMarker", Namespace = "https://erju.org/")]
		public List<eng.MileageReferenceMarker>? referenceMarkers;
		[XmlAttribute("id")]
		public string id {get;set;}
	}
}
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeGeometry")]
	public class TrackEdgeGeometry
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("horizontalAlignmentItem", Namespace = "https://erju.org/")]
		public List<infra.HorizontalSegment>? horizontalAlignment;
		[XmlArray(Order=1)]
		[XmlArrayItem("verticalAlignmentItem", Namespace = "https://erju.org/")]
		public List<infra.VerticalSegment>? verticalAlignment;
		[XmlArray(Order=2)]
		[XmlArrayItem("cantSample", Namespace = "https://erju.org/")]
		public List<infra.CantSamplePoint>? cantSamples;
		[XmlAttribute("id")]
		public string id {get;set;}
	}
}
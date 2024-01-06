using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "bufferStop")]
	public class BufferStop
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("dangerPoint", Namespace = "https://erju.org/")]
		public List<DangerPointRef?>? dangerPoints;
		[XmlArray(Order=1)]
		[XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/")]
		public List<infra.TrackEdgeSection>? trackEdgeSections;
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("bsType")]
		public eng.BufferStopType bsType {get;set;}
	}
}
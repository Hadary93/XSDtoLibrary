using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "sampledTrackEdgeGeometry")]
	public class SampledTrackEdgeGeometry
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("slope", Namespace = "https://erju.org/")]
		public List<infra.SlopeSamplePoint>? slopes;
		[XmlArray(Order=1)]
		[XmlArrayItem("curve", Namespace = "https://erju.org/")]
		public List<infra.CurveSamplePoint>? curves;
		[XmlArray(Order=2)]
		[XmlArrayItem("cant", Namespace = "https://erju.org/")]
		public List<infra.CantSamplePoint>? cants;
		[XmlAttribute("id")]
		public string id {get;set;}
	}
}
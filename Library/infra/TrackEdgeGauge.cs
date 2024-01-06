using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeGauge")]
	public class TrackEdgeGauge
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("trackSection", Namespace = "https://erju.org/")]
		public List<infra.TrackEdgeSection>? trackSections;
		[XmlAttribute("gauge")]
		public infra.TrackGaugeType gauge {get;set;}
	}
}
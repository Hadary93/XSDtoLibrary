using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeLoadingGauge")]
	public class TrackEdgeLoadingGauge
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("trackSection", Namespace = "https://erju.org/")]
		public List<infra.TrackEdgeSection>? trackSections;
		[XmlAttribute("loadingGaugeType")]
		public infra.LoadingGaugeType loadingGaugeType {get;set;}
	}
}
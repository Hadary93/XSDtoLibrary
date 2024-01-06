using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "tvpSection")]
	public class TvpSection
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("trackSection", Namespace = "https://erju.org/")]
		public List<infra.TrackEdgeSection>? trackSections;
		[XmlArray(Order=1)]
		[XmlArrayItem("trainDetector", Namespace = "https://erju.org/")]
		public List<TrainDetectorRef>? trainDetectors;
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("name")]
		public string? name {get;set;}
	}
}
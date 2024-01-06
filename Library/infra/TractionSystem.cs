using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "tractionSystem")]
	public class TractionSystem
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("trackSection", Namespace = "https://erju.org/")]
		public List<infra.TrackEdgeSection>? trackSections;
		[XmlAttribute("type")]
		public infra.VoltageType type {get;set;}
	}
}
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackCondition")]
	public class TrackCondition
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("trackSection", Namespace = "https://erju.org/")]
		public List<infra.TrackEdgeSection>? trackSections;
		[XmlAttribute("type")]
		public infra.ConditionType type {get;set;}
	}
}
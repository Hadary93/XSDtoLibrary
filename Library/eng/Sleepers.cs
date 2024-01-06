using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "sleepers")]
	public class Sleepers
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("trackEdgeSectionItem", Namespace = "https://erju.org/")]
		public List<infra.TrackEdgeSection>? trackEdgeSection;
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("type")]
		public eng.SleepersType type {get;set;}
	}
}
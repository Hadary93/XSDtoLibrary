using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "underpass")]
	public class Underpass
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/")]
		public List<infra.TrackEdgeSection>? trackEdgeSections;
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("name")]
		public string name {get;set;}
	}
}
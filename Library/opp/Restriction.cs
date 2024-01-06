using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "restriction")]
	public class Restriction
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("restrictionArea", Namespace = "https://erju.org/")]
		public List<opp.RestrictionArea>? restrictionAreas;
		[XmlArray(Order=1)]
		[XmlArrayItem("event", Namespace = "https://erju.org/")]
		public List<opp.RestrictionEvent>? events;
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("activationTime")]
		public string activationTime {get;set;}
		[XmlAttribute("removalTime")]
		public string removalTime {get;set;}
	}
}
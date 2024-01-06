using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "warningArea")]
	public class WarningArea
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/")]
		public List<infra.TrackEdgeSection>? trackEdgeSections;
		[XmlArray(Order=1)]
		[XmlArrayItem("warningDevice", Namespace = "https://erju.org/")]
		public List<opp.WarningDevice>? warningDevices;
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("activationTime")]
		public string activationTime {get;set;}
		[XmlAttribute("removalTime")]
		public string removalTime {get;set;}
	}
}
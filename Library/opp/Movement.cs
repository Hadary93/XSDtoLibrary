using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "movement")]
	public class Movement
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("operationalTrainUnit", Namespace = "https://erju.org/")]
		public List<opp.TrainUnit>? operationalTrainUnits;
		[XmlArray(Order=1)]
		[XmlArrayItem("movementEvent", Namespace = "https://erju.org/")]
		public List<opp.MovementEvent>? movementEvents;
		[XmlArray(Order=2)]
		[XmlArrayItem("restriction", Namespace = "https://erju.org/")]
		public List<opp.MovementRestriction>? restrictions;
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("issuedAt")]
		public string issuedAt {get;set;}
		[XmlAttribute("domainDataVersionRef")]
		public string domainDataVersionRef {get;set;}
	}
}
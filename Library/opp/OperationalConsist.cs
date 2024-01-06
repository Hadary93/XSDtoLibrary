using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "operationalConsist")]
	public class OperationalConsist
	{
		[XmlElement(Order=0)]
		public opp.SupportedOnBoardEquipment? supportedOnBoardEquipment {get;set;}
		[XmlAttribute("ref")]
		public string? Ref {get;set;}
	}
}
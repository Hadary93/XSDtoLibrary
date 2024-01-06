using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "supportedOnBoardEquipment")]
	public class SupportedOnBoardEquipment
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("anyClas", Namespace = "https://erju.org/")]
		public List<opp.AnyClass>? anyClass;
		[XmlAttribute("type")]
		public opp.TrainProtectionType type {get;set;}
		[XmlAttribute("etcsVersions")]
		public string? etcsVersions {get;set;}
	}
}
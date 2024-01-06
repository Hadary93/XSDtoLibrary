using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "physicalTrainUnitIdentifier")]
	public class PhysicalTrainUnitIdentifier
	{
		[XmlAttribute("trainRunningNumber")]
		public string? trainRunningNumber {get;set;}
		[XmlAttribute("additionalTrainRunningNumber")]
		public string? additionalTrainRunningNumber {get;set;}
		[XmlAttribute("tafTapTsiTrainID")]
		public string? tafTapTsiTrainID {get;set;}
		[XmlAttribute("leadingOnBoardUnitId")]
		public string? leadingOnBoardUnitId {get;set;}
	}
}
using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "trainUnitActivity")]
	public class TrainUnitActivity
	{
		[XmlAttribute("type")]
		public opp.ActivityType type {get;set;}
		[XmlAttribute("actualTrainUnitIndex")]
		public uint actualTrainUnitIndex {get;set;}
		[XmlAttribute("targetTrainUnitIndex")]
		public uint targetTrainUnitIndex {get;set;}
	}
}
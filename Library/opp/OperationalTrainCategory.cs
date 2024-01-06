using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "operationalTrainCategory")]
	public class OperationalTrainCategory
	{
		[XmlAttribute("type")]
		public opp.TrainCategoryType type {get;set;}
		[XmlAttribute("description")]
		public string? description {get;set;}
		[XmlAttribute("trainUsage")]
		public opp.TrainUsageType trainUsage {get;set;}
	}
}
using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "trainGroupSpec")]
	public class TrainGroupSpec
	{
		[XmlAttribute("trainTypes")]
		public opp.TrainType trainTypes {get;set;}
		[XmlAttribute("engineeringTrainsOnly")]
		public bool engineeringTrainsOnly {get;set;}
		[XmlAttribute("maxAxleLoad")]
		public uint maxAxleLoad {get;set;}
		[XmlAttribute("minCantDeficiency")]
		public infra.CantDeficiencyCategory minCantDeficiency {get;set;}
		[XmlAttribute("trainCategories")]
		public opp.TrainCategoryType trainCategories {get;set;}
		[XmlAttribute("tractionTypes")]
		public opp.TrainTractionType tractionTypes {get;set;}
		[XmlAttribute("prohibitedLoadingGaugeTypes")]
		public infra.LoadingGaugeType prohibitedLoadingGaugeTypes {get;set;}
		[XmlAttribute("prohibitedLoadingType")]
		public infra.TrainLoadType prohibitedLoadingType {get;set;}
		[XmlAttribute("minTrainAirTightness")]
		public opp.TrainAirTightness minTrainAirTightness {get;set;}
	}
}
using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "trainUsageType")]
	public enum TrainUsageType
	{
		TRAIN_USAGE_UNDEFINED,
		COMMERCIAL_PASSENGER_TRAIN,
		COMMERCIAL_CARGO_TRAIN,
		LOCOMOTIVE_RUNNING_LIGHT,
		LIGHT_RUNNING,
		NOT_IN_SERVICE,
		ENGINEERING_TRAIN,
		BREAKDOWN_TRAIN,
		MIXED_TRAIN,
		SPECIAL_TRAIN,
		OTHER_TRAIN,
	}
}
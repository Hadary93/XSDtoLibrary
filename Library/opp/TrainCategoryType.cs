using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "trainCategoryType")]
	public enum TrainCategoryType
	{
		TRAIN_CATEGORY_UNKNOWN,
		INTERREGIONAL,
		REGIONAL,
		SUB_URBAN,
		NIGHT_TRAIN,
		MOTOR_RAIL,
		MOUNTAIN_TRAIN,
		HISTORIC_TRAIN,
		COACH_GROUP,
		TRAM,
		UNDERGROUND,
		HIGHSPEED_TRAIN,
		INTERCITY,
	}
}
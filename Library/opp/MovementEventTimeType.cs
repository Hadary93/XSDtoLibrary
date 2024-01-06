using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "movementEventTimeType")]
	public enum MovementEventTimeType
	{
		earliestOperationalDeparture,
		latestOperationalDeparture,
		earliestOperationalArrival,
		lastOperationalArrival,
		operationalDeparture,
		publishedArrival,
		publishedDeparture,
		realisedArrival,
		realisedDeparture,
	}
}
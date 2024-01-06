using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "brakePosition")]
	public enum BrakePosition
	{
		passengerTrainInP,
		freightTrainInP,
		freightTrainInG,
		unknown_bp,
	}
}
using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "movementType")]
	public enum MovementType
	{
		PASSAGE,
		STOP,
		OTHER_EVENT,
	}
}
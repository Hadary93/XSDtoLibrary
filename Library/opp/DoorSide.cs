using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "doorSide")]
	public enum DoorSide
	{
		noneSide,
		rightSide,
		leftSide,
		bothSides,
	}
}
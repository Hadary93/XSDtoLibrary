using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "positionType")]
	public enum PositionType
	{
		PositionOnTrack,
		LogicalPosition,
	}
}
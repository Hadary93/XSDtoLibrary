using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "deviceType")]
	public enum DeviceType
	{
		acousticalIndicator,
		opticalIndicator,
		hapticIndicator,
	}
}
using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "stopType")]
	public enum StopType
	{
		COMMERCIAL,
		COMMERCIAL_ONDEMAND,
		OPERATIONAL,
		CONDITIONAL,
	}
}
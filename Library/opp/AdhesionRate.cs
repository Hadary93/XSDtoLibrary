using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "adhesionRate")]
	public enum AdhesionRate
	{
		ADH_UNKNOWN,
	}
}
using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "adhesionCategory")]
	public enum AdhesionCategory
	{
		dryRail,
		medium,
		normal_low,
		lowAdhesion,
		veryLowAdhesion,
		extremelyLowAdhesion,
	}
}
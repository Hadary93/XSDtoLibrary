using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "trainAirTightness")]
	public enum TrainAirTightness
	{
		TAT_UNKNOWN,
	}
}
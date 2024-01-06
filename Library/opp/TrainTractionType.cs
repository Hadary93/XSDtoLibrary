using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "trainTractionType")]
	public enum TrainTractionType
	{
		TTT_UNKNOWN,
	}
}
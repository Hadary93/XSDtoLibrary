using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "trainType")]
	public enum TrainType
	{
		TrainType_UNKNOWN,
	}
}
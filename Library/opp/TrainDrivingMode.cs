using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "trainDrivingMode")]
	public enum TrainDrivingMode
	{
		TDM_UNKNOWN,
	}
}
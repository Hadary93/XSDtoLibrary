using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "trainProtectionType")]
	public enum TrainProtectionType
	{
		Etcs,
	}
}
using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "brakeModelType")]
	public enum BrakeModelType
	{
		lambda,
		gamma,
	}
}
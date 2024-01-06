using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "trainEndApplicability")]
	public enum TrainEndApplicability
	{
		trainFront,
		trainBack,
	}
}
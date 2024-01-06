using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackGaugeType")]
	public enum TrackGaugeType
	{
		tgUnknown,
		tg750,
		tg1000mm,
		tg1435mm,
		tg1520mm,
		tg1524mm,
		tg1600mm,
		tg1680mm,
	}
}
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "stopLocationTolerance")]
	public enum StopLocationTolerance
	{
		T_Undefined,
		T_10cm,
		T_20cm,
		T_30cm,
		T_40cm,
		T_50cm,
		T_1m,
		T_150cm,
		T_2m,
		T_3m,
		T_5m,
		T_750cm,
		T_10m,
		T_15m,
		T_20m,
		T_25m,
		T_30m,
		T_50m,
		T_75m,
		T_100m,
	}
}
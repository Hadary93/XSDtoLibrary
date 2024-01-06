using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "stopTimes")]
	public class StopTimes
	{
		[XmlAttribute("minStopTime")]
		public uint minStopTime {get;set;}
		[XmlAttribute("operationalReserve")]
		public uint operationalReserve {get;set;}
		[XmlAttribute("additionalReserve")]
		public uint additionalReserve {get;set;}
	}
}
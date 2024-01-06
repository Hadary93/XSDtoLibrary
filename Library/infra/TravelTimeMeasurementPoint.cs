using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "travelTimeMeasurementPoint")]
	public class TravelTimeMeasurementPoint
	{
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("trackEdge")]
		public string trackEdge {get;set;}
		[XmlAttribute("pos")]
		public uint pos {get;set;}
	}
}
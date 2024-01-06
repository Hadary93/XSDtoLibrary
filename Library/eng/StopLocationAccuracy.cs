using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "stopLocationAccuracy")]
	public class StopLocationAccuracy
	{
		[XmlAttribute("stopLocationId")]
		public string? stopLocationId {get;set;}
		[XmlAttribute("accuracy")]
		public uint accuracy {get;set;}
	}
}
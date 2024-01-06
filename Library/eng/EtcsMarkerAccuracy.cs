using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "etcsMarkerAccuracy")]
	public class EtcsMarkerAccuracy
	{
		[XmlAttribute("markerId")]
		public string? markerId {get;set;}
		[XmlAttribute("accuracy")]
		public uint accuracy {get;set;}
	}
}
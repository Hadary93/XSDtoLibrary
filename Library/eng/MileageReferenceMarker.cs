using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "mileageReferenceMarker")]
	public class MileageReferenceMarker
	{
		[XmlAttribute("name")]
		public string? name {get;set;}
		[XmlAttribute("mileage")]
		public double mileage {get;set;}
		[XmlAttribute("trackEdge")]
		public string? trackEdge {get;set;}
		[XmlAttribute("pos")]
		public double pos {get;set;}
	}
}
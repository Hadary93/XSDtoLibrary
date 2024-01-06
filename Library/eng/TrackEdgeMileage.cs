using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "trackEdgeMileage")]
	public class TrackEdgeMileage
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("point", Namespace = "https://erju.org/")]
		public List<eng.MileagePoint>? points;
		[XmlAttribute("id")]
		public string id {get;set;}
	}
}
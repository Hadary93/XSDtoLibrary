using System.Xml.Serialization;
namespace map
{
	[XmlRoot(Namespace = "https://erju.org/map", ElementName = "trackEdgeProjection")]
	public class TrackEdgeProjection
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("coordinate", Namespace = "https://erju.org/")]
		public List<map.TrackEdgeCoordinate>? coordinates;
		[XmlAttribute("id")]
		public string id {get;set;}
	}
}
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "crossing")]
	public class Crossing
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("trackEdgePoint", Namespace = "https://erju.org/")]
		public List<infra.TrackEdgePoint>? trackEdgePoints;
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("isSwitchable")]
		public bool isSwitchable {get;set;}
	}
}
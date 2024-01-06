using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "operationalPoint")]
	public class OperationalPoint
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("travelTimeMeasurementPoint", Namespace = "https://erju.org/")]
		public List<infra.TravelTimeMeasurementPoint>? travelTimeMeasurementPoints;
		[XmlArray(Order=1)]
		[XmlArrayItem("platform", Namespace = "https://erju.org/")]
		public List<infra.Platform>? platforms;
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("name")]
		public string? name {get;set;}
		[XmlAttribute("type")]
		public infra.OPType type {get;set;}
	}
}
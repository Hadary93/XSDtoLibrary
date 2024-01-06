using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "platformEdge")]
	public class PlatformEdge
	{
		[XmlElement(Order=0)]
		public infra.LinkedPath? linearLocation {get;set;}
		[XmlArray(Order=1)]
		[XmlArrayItem("stopLocation", Namespace = "https://erju.org/")]
		public List<StopLocationRef>? stopLocations;
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("name")]
		public string? name {get;set;}
		[XmlAttribute("height")]
		public infra.PlatformHeight height {get;set;}
	}
}
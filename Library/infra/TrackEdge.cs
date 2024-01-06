using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdge")]
	public class TrackEdge
	{
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("length")]
		public uint length {get;set;}
	}
}
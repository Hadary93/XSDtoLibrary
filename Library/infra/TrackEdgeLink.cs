using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeLink")]
	public class TrackEdgeLink
	{
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("trackEdgeA")]
		public string? trackEdgeA {get;set;}
		[XmlAttribute("trackEdgeB")]
		public string? trackEdgeB {get;set;}
		[XmlAttribute("startOfA")]
		public bool startOfA {get;set;}
		[XmlAttribute("startOfB")]
		public bool startOfB {get;set;}
	}
}
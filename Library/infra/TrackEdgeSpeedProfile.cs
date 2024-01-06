using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeSpeedProfile")]
	public class TrackEdgeSpeedProfile
	{
		[XmlElement(Order=0)]
		public infra.SpeedProfile? sameDirProfile {get;set;}
		[XmlElement(Order=1)]
		public infra.SpeedProfile? oppositeDirProfile {get;set;}
		[XmlAttribute("id")]
		public string? id {get;set;}
	}
}
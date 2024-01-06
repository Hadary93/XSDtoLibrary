using System.Xml.Serialization;
namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "driveProtectionSection")]
	public class DriveProtectionSection
	{
		[XmlElement(Order=0)]
		public infra.TrackEdgeSection? trackEdgeSection {get;set;}
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("name")]
		public string? name {get;set;}
	}
}
using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "warningDevice")]
	public class WarningDevice
	{
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("type")]
		public opp.DeviceType type {get;set;}
	}
}
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "nationalBorder")]
	public class NationalBorder
	{
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("trackEdge")]
		public string trackEdge {get;set;}
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("fromCountryCode")]
		public string fromCountryCode {get;set;}
		[XmlAttribute("toCountryCode")]
		public string toCountryCode {get;set;}
	}
}
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "atoTSContactInfo")]
	public class AtoTSContactInfo
	{
		[XmlAttribute("nidATOTS")]
		public uint nidATOTS {get;set;}
		[XmlAttribute("nidSP")]
		public uint nidSP {get;set;}
		[XmlAttribute("spNidC")]
		public uint spNidC {get;set;}
		[XmlAttribute("atotsNidC")]
		public uint atotsNidC {get;set;}
	}
}
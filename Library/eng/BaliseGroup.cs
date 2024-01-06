using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "baliseGroup")]
	public class BaliseGroup
	{
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("m_version")]
		public ss026.ETCSVersion m_version {get;set;}
		[XmlAttribute("q_link")]
		public bool q_link {get;set;}
		[XmlAttribute("telegram")]
		public string telegram {get;set;}
		[XmlAttribute("telegramChecksum")]
		public string telegramChecksum {get;set;}
	}
}